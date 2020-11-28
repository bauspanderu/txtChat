Imports System.IO

Public Class PrvWindow

    Public Sub LoadFile(Filter)
        FileSystemWatcher1.Path = Path.GetDirectoryName(Form1.OpenFileDialog1.FileName)
        FileSystemWatcher1.Filter = Filter
        FileSystemWatcher1.EnableRaisingEvents = True
        Dim rawop As String = File.ReadAllText(Path.GetDirectoryName(Form1.OpenFileDialog1.FileName) & "\" & Filter)
        PrvBox.Text = rawop

        PrvBox.SelectionStart = PrvBox.Text.Length
        PrvBox.ScrollToCaret()
    End Sub

    Private Sub PrvWindow_Load(ByVal sender, ByVal e) Handles MyBase.Load

        Text = "Private Chat with " & Form1.PrivateUser.Text


        If File.Exists(Path.GetDirectoryName(Form1.OpenFileDialog1.FileName) & "\" & Form1.uname.Text & Form1.PrivateUser.Text & ".prv") Then

            LoadFile(Form1.uname.Text & Form1.PrivateUser.Text & ".prv")

        ElseIf File.Exists(Path.GetDirectoryName(Form1.OpenFileDialog1.FileName) & "\" & Form1.PrivateUser.Text & Form1.uname.Text & ".prv") Then

            LoadFile(Form1.PrivateUser.Text & Form1.uname.Text & ".prv")

        Else

            Dim crfile = File.Create(Path.GetDirectoryName(Form1.OpenFileDialog1.FileName) & "\" & Form1.uname.Text & Form1.PrivateUser.Text & ".prv")
            crfile.Close()
            LoadFile(Form1.uname.Text & Form1.PrivateUser.Text & ".prv")

        End If



    End Sub

    Public Sub Write_private(Filter)
        Using OutFile As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(Path.GetDirectoryName(Form1.OpenFileDialog1.FileName) & "\" & Filter, True)
            OutFile.WriteLine(Form1.uname.Text + ": " + PrvMsg.Text)
            OutFile.Close()
        End Using

        PrvMsg.Text = ""
    End Sub

    Public Sub Send_Private()
        If PrvMsg.TextLength = 0 Then

            MsgBox("You can't send empty messages")

        ElseIf File.Exists(Path.GetDirectoryName(Form1.OpenFileDialog1.FileName) & "\" & Form1.uname.Text & Form1.PrivateUser.Text & ".prv") Then

            Write_private(Form1.uname.Text & Form1.PrivateUser.Text & ".prv")

        ElseIf File.Exists(Path.GetDirectoryName(Form1.OpenFileDialog1.FileName) & "\" & Form1.PrivateUser.Text & Form1.uname.Text & ".prv") Then

            Write_private(Form1.PrivateUser.Text & Form1.uname.Text & ".prv")

        Else

            Dim crfile = File.Create(Path.GetDirectoryName(Form1.OpenFileDialog1.FileName) & "\" & Form1.uname.Text & Form1.PrivateUser.Text & ".prv")
            crfile.Close()
            Write_private(Form1.uname.Text & Form1.PrivateUser.Text & ".prv")

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Send_Private()

    End Sub

    Private Sub PrvMsg_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles PrvMsg.KeyDown
        If e.KeyCode = Keys.Enter Then
            Send_Private()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub


    Public Sub Update_msg(Filter)

        Dim InPath As String = Path.GetDirectoryName(Form1.OpenFileDialog1.FileName) & "\" & Filter
        Dim rawop As String = File.ReadAllText(InPath)
        PrvBox.Text = rawop

        PrvBox.SelectionStart = PrvBox.Text.Length
        PrvBox.ScrollToCaret()

    End Sub
    Private Sub FileSystemWatcher1_Changed(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Changed

        If File.Exists(Path.GetDirectoryName(Form1.OpenFileDialog1.FileName) & "\" & Form1.uname.Text & Form1.PrivateUser.Text & ".prv") Then

            Update_msg(Form1.uname.Text & Form1.PrivateUser.Text & ".prv")

        ElseIf File.Exists(Path.GetDirectoryName(Form1.OpenFileDialog1.FileName) & "\" & Form1.PrivateUser.Text & Form1.uname.Text & ".prv") Then

            Update_msg(Form1.PrivateUser.Text & Form1.uname.Text & ".prv")

        Else

            Dim crfile = File.Create(Path.GetDirectoryName(Form1.OpenFileDialog1.FileName) & "\" & Form1.uname.Text & Form1.PrivateUser.Text & ".prv")
            crfile.Close()
            Update_msg(Form1.uname.Text & Form1.PrivateUser.Text & ".prv")

        End If

    End Sub


    Public Sub Close_prv(Filter)
        Dim InPath As String = Path.GetDirectoryName(Form1.OpenFileDialog1.FileName) & "\" & Filter

        Using OutFile As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(InPath, True)
            OutFile.WriteLine(Form1.uname.Text & " has left")
            OutFile.Close()
        End Using
    End Sub

    Private Sub frmProgramma_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If File.Exists(Path.GetDirectoryName(Form1.OpenFileDialog1.FileName) & "\" & Form1.uname.Text & Form1.PrivateUser.Text & ".prv") Then

            Close_prv(Form1.uname.Text & Form1.PrivateUser.Text & ".prv")

        ElseIf File.Exists(Path.GetDirectoryName(Form1.OpenFileDialog1.FileName) & "\" & Form1.PrivateUser.Text & Form1.uname.Text & ".prv") Then

            Close_prv(Form1.PrivateUser.Text & Form1.uname.Text & ".prv")

        Else

            Dim crfile = File.Create(Path.GetDirectoryName(Form1.OpenFileDialog1.FileName) & "\" & Form1.uname.Text & Form1.PrivateUser.Text & ".prv")
            crfile.Close()
            Close_prv(Form1.uname.Text & Form1.PrivateUser.Text & ".prv")


        End If

    End Sub

End Class
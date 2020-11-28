Imports System.IO

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'opens Fileselect
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk 'sets up when file was selected, checks for onl file

        If File.Exists(OpenFileDialog1.FileName + ".onl") Then

            Dim chatroomlabel1 = chatroomlabel
            chatroomlabel1.Text = OpenFileDialog1.FileName

            FileSystemWatcher1.Path = Path.GetDirectoryName(OpenFileDialog1.FileName)
            FileSystemWatcher1.Filter = OpenFileDialog1.SafeFileName
            FileSystemWatcher1.EnableRaisingEvents = True

            Dim rawop As String = File.ReadAllText(OpenFileDialog1.FileName)
            output.Text = rawop

            output.SelectionStart = output.Text.Length
            output.ScrollToCaret()

            Button1.Enabled = False
            uname.Enabled = True
            Button2.Enabled = True

        Else

            MsgBox("This chatroom won't work, try another one.")

        End If

    End Sub

    Public Sub Select_Username() 'method for setting username
        Dim inFileOnline As StreamReader = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog1.FileName & ".onl")

        Dim onlineusers As String = inFileOnline.ReadToEnd
        inFileOnline.Close()

        If uname.TextLength <> 0 And onlineusers.Contains(uname.Text) = False Then
            uname.Enabled = False
            Button2.Enabled = False

            Dim outFileOnline As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(OpenFileDialog1.FileName & ".onl", True)
            outFileOnline.WriteLine(uname.Text)
            outFileOnline.Close()

            Dim outFile As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(OpenFileDialog1.FileName, True)
            outFile.WriteLine(uname.Text & " has joined the Chat.")
            outFile.Close()

            Button3.Enabled = True
            Button4.Enabled = True

        ElseIf uname.TextLength = 0 Then
            MsgBox("Please type in a username.")
        ElseIf onlineusers.Contains(uname.Text) = True Then
            MsgBox("This username is taken.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'sets Username when button is clicked

        Select_Username()

    End Sub

    Private Sub uname_KeyDown(sender As Object, e As KeyEventArgs) Handles uname.KeyDown 'sets Username when enter is pressed

        If e.KeyCode = Keys.Enter Then
            Select_Username()
            e.Handled = True
            e.SuppressKeyPress = True
        End If

    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Changed 'updates chat when file was changed
        Dim rawop As String = File.ReadAllText(OpenFileDialog1.FileName)
        output.Text = rawop

        output.SelectionStart = output.Text.Length
        output.ScrollToCaret()

        Dim rawonl As String = File.ReadAllText(OpenFileDialog1.FileName & ".onl")
        onlineUsers.Text = rawonl
    End Sub

    Public Sub Message_Send() 'method for sending messages
        If message.TextLength = 0 Then

            MsgBox("You can't send empty Messages.")

        Else

            Dim outFile As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(OpenFileDialog1.FileName, True)
            outFile.WriteLine(uname.Text & ": " & message.Text)
            outFile.Close()

            message.Text = ""

            output.SelectionStart = output.Text.Length
            output.ScrollToCaret()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'sends a message hen button is clicked

        Message_Send()

    End Sub
    Private Sub msg_KeyDown(sender As Object, e As KeyEventArgs) Handles message.KeyDown 'sends a message when enter is pressed
        If e.KeyCode = Keys.Enter And Button3.Enabled = True Then
            Message_Send()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub frmProgramma_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing 'sends close message when user closes program

        If uname.TextLength <> 0 Then

            Dim linesList As New List(Of String)(File.ReadAllLines(OpenFileDialog1.FileName & ".onl"))
            linesList.Remove(uname.Text)
            File.WriteAllLines(OpenFileDialog1.FileName & ".onl", linesList.ToArray())

            Dim outFile As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(OpenFileDialog1.FileName, True)
            outFile.WriteLine(uname.Text & " has left the Chat.")
            outFile.Close()

        End If
    End Sub

    Public Sub Start_PRV() 'method for handling the private message window
        Dim linesList As New List(Of String)(File.ReadAllLines(OpenFileDialog1.FileName & ".onl"))

        If PrivateUser.Text = uname.Text Then

            MsgBox("You can't chat with youself")

        ElseIf linesList.Contains(PrivateUser.Text) = True Then

            PrvWindow.Show()

        Else

            MsgBox("The specified user is not online")

        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'starts private message window when button is clicked
        Start_PRV()

    End Sub

    Private Sub prv_KeyDown(sender As Object, e As KeyEventArgs) Handles PrivateUser.KeyDown 'starts private message window when enter is pressed
        If e.KeyCode = Keys.Enter And Button4.Enabled = True Then
            Start_PRV()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub


End Class

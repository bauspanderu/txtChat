<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chatroomlabel = New System.Windows.Forms.Label()
        Me.uname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.output = New System.Windows.Forms.TextBox()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.message = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.onlineUsers = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrivateUser = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "cha"
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Chatrooms (*.cha)|*.cha|Alle Dateien (*.*)|*.*"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.Location = New System.Drawing.Point(192, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Choose .cha file"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chatroomlabel
        '
        Me.chatroomlabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chatroomlabel.Location = New System.Drawing.Point(12, 45)
        Me.chatroomlabel.Name = "chatroomlabel"
        Me.chatroomlabel.Size = New System.Drawing.Size(502, 13)
        Me.chatroomlabel.TabIndex = 7
        Me.chatroomlabel.Text = "Please choose a Chatroom"
        Me.chatroomlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uname
        '
        Me.uname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.uname.Enabled = False
        Me.uname.Location = New System.Drawing.Point(192, 88)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(135, 20)
        Me.uname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(128, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username:"
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(333, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 20)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Submit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'output
        '
        Me.output.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.output.Location = New System.Drawing.Point(15, 142)
        Me.output.Multiline = True
        Me.output.Name = "output"
        Me.output.ReadOnly = True
        Me.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.output.Size = New System.Drawing.Size(342, 224)
        Me.output.TabIndex = 5
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'message
        '
        Me.message.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.message.Location = New System.Drawing.Point(15, 372)
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(290, 20)
        Me.message.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(311, 371)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(46, 21)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Send"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'onlineUsers
        '
        Me.onlineUsers.Location = New System.Drawing.Point(375, 142)
        Me.onlineUsers.Multiline = True
        Me.onlineUsers.Name = "onlineUsers"
        Me.onlineUsers.ReadOnly = True
        Me.onlineUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.onlineUsers.Size = New System.Drawing.Size(139, 224)
        Me.onlineUsers.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(372, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Online Users:"
        '
        'PrivateUser
        '
        Me.PrivateUser.Location = New System.Drawing.Point(375, 373)
        Me.PrivateUser.Name = "PrivateUser"
        Me.PrivateUser.Size = New System.Drawing.Size(78, 20)
        Me.PrivateUser.TabIndex = 10
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(459, 373)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(55, 20)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "PrivChat"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 404)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PrivateUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.onlineUsers)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.message)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.uname)
        Me.Controls.Add(Me.chatroomlabel)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "txtChat V. 2.0"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents chatroomlabel As Label
    Friend WithEvents uname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents output As TextBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Button3 As Button
    Friend WithEvents message As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents onlineUsers As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents PrivateUser As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrvWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrvWindow))
        Me.PrvBox = New System.Windows.Forms.TextBox()
        Me.PrvMsg = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrvBox
        '
        Me.PrvBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrvBox.Location = New System.Drawing.Point(12, 12)
        Me.PrvBox.Multiline = True
        Me.PrvBox.Name = "PrvBox"
        Me.PrvBox.ReadOnly = True
        Me.PrvBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PrvBox.Size = New System.Drawing.Size(292, 480)
        Me.PrvBox.TabIndex = 0
        '
        'PrvMsg
        '
        Me.PrvMsg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrvMsg.Location = New System.Drawing.Point(13, 498)
        Me.PrvMsg.Name = "PrvMsg"
        Me.PrvMsg.Size = New System.Drawing.Size(244, 20)
        Me.PrvMsg.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(263, 498)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 22)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'PrvWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 530)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PrvMsg)
        Me.Controls.Add(Me.PrvBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PrvWindow"
        Me.Text = "You shouldnt see this, plz report"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrvBox As TextBox
    Friend WithEvents PrvMsg As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
End Class

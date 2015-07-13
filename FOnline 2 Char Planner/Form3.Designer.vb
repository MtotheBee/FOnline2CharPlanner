<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Me.F3MsgBoxText = New System.Windows.Forms.Label()
        Me.F3TimerMsgBox = New System.Windows.Forms.Timer(Me.components)
        Me.BtnF3Ok = New System.Windows.Forms.Button()
        Me.BtnF3DontB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'F3MsgBoxText
        '
        Me.F3MsgBoxText.AutoSize = True
        Me.F3MsgBoxText.BackColor = System.Drawing.Color.Transparent
        Me.F3MsgBoxText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F3MsgBoxText.ForeColor = System.Drawing.Color.SandyBrown
        Me.F3MsgBoxText.Location = New System.Drawing.Point(8, 10)
        Me.F3MsgBoxText.Name = "F3MsgBoxText"
        Me.F3MsgBoxText.Size = New System.Drawing.Size(30, 13)
        Me.F3MsgBoxText.TabIndex = 0
        Me.F3MsgBoxText.Text = "test"
        '
        'F3TimerMsgBox
        '
        Me.F3TimerMsgBox.Enabled = True
        Me.F3TimerMsgBox.Interval = 25
        '
        'BtnF3Ok
        '
        Me.BtnF3Ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnF3Ok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnF3Ok.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnF3Ok.FlatAppearance.BorderSize = 0
        Me.BtnF3Ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnF3Ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnF3Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnF3Ok.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnF3Ok.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnF3Ok.Location = New System.Drawing.Point(166, 83)
        Me.BtnF3Ok.Name = "BtnF3Ok"
        Me.BtnF3Ok.Size = New System.Drawing.Size(83, 21)
        Me.BtnF3Ok.TabIndex = 45
        Me.BtnF3Ok.Text = "Understood!"
        Me.BtnF3Ok.UseCompatibleTextRendering = True
        Me.BtnF3Ok.UseVisualStyleBackColor = False
        '
        'BtnF3DontB
        '
        Me.BtnF3DontB.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnF3DontB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnF3DontB.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnF3DontB.FlatAppearance.BorderSize = 0
        Me.BtnF3DontB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow
        Me.BtnF3DontB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.BtnF3DontB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnF3DontB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnF3DontB.ForeColor = System.Drawing.Color.Crimson
        Me.BtnF3DontB.Location = New System.Drawing.Point(1, 83)
        Me.BtnF3DontB.Name = "BtnF3DontB"
        Me.BtnF3DontB.Size = New System.Drawing.Size(144, 19)
        Me.BtnF3DontB.TabIndex = 46
        Me.BtnF3DontB.Text = "Don't bother me again!"
        Me.BtnF3DontB.UseCompatibleTextRendering = True
        Me.BtnF3DontB.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(251, 104)
        Me.Controls.Add(Me.BtnF3DontB)
        Me.Controls.Add(Me.BtnF3Ok)
        Me.Controls.Add(Me.F3MsgBoxText)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Opacity = 0.0R
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents F3MsgBoxText As System.Windows.Forms.Label
    Friend WithEvents F3TimerMsgBox As System.Windows.Forms.Timer
    Friend WithEvents BtnF3Ok As System.Windows.Forms.Button
    Friend WithEvents BtnF3DontB As System.Windows.Forms.Button
End Class

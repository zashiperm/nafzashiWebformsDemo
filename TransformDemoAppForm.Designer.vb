<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransformDemoAppForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PutNameButton = New System.Windows.Forms.Button()
        Me.NameInputForm = New System.Windows.Forms.TextBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ResultNameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PutNameButton
        '
        Me.PutNameButton.Location = New System.Drawing.Point(194, 27)
        Me.PutNameButton.Name = "PutNameButton"
        Me.PutNameButton.Size = New System.Drawing.Size(57, 31)
        Me.PutNameButton.TabIndex = 0
        Me.PutNameButton.Text = "Send"
        Me.PutNameButton.UseVisualStyleBackColor = True
        '
        'NameInputForm
        '
        Me.NameInputForm.Location = New System.Drawing.Point(35, 38)
        Me.NameInputForm.Name = "NameInputForm"
        Me.NameInputForm.Size = New System.Drawing.Size(153, 20)
        Me.NameInputForm.TabIndex = 1
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Location = New System.Drawing.Point(32, 22)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(101, 13)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "What is your name?"
        '
        'ResultNameLabel
        '
        Me.ResultNameLabel.AutoSize = True
        Me.ResultNameLabel.Location = New System.Drawing.Point(32, 78)
        Me.ResultNameLabel.Name = "ResultNameLabel"
        Me.ResultNameLabel.Size = New System.Drawing.Size(0, 13)
        Me.ResultNameLabel.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 110)
        Me.Controls.Add(Me.ResultNameLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.NameInputForm)
        Me.Controls.Add(Me.PutNameButton)
        Me.Name = "Form1"
        Me.Text = "TransformDemoWebformsApp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PutNameButton As Button
    Friend WithEvents NameInputForm As TextBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents ResultNameLabel As Label
End Class

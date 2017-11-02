<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSetUp = New System.Windows.Forms.Button()
        Me.btnPunchLine = New System.Windows.Forms.Button()
        Me.lblSetUp = New System.Windows.Forms.Label()
        Me.lblPunchline = New System.Windows.Forms.Label()
        Me.lblLaugh = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSetUp
        '
        Me.btnSetUp.Location = New System.Drawing.Point(21, 35)
        Me.btnSetUp.Name = "btnSetUp"
        Me.btnSetUp.Size = New System.Drawing.Size(75, 23)
        Me.btnSetUp.TabIndex = 0
        Me.btnSetUp.Text = "Set Up"
        Me.btnSetUp.UseVisualStyleBackColor = True
        '
        'btnPunchLine
        '
        Me.btnPunchLine.Location = New System.Drawing.Point(21, 140)
        Me.btnPunchLine.Name = "btnPunchLine"
        Me.btnPunchLine.Size = New System.Drawing.Size(75, 23)
        Me.btnPunchLine.TabIndex = 1
        Me.btnPunchLine.Text = "Punch Line"
        Me.btnPunchLine.UseVisualStyleBackColor = True
        '
        'lblSetUp
        '
        Me.lblSetUp.AutoSize = True
        Me.lblSetUp.Location = New System.Drawing.Point(130, 40)
        Me.lblSetUp.Name = "lblSetUp"
        Me.lblSetUp.Size = New System.Drawing.Size(275, 13)
        Me.lblSetUp.TabIndex = 2
        Me.lblSetUp.Text = "What is the difference between a guitar and a tuna fish? "
        Me.lblSetUp.Visible = False
        '
        'lblPunchline
        '
        Me.lblPunchline.AutoSize = True
        Me.lblPunchline.Location = New System.Drawing.Point(130, 145)
        Me.lblPunchline.Name = "lblPunchline"
        Me.lblPunchline.Size = New System.Drawing.Size(219, 13)
        Me.lblPunchline.TabIndex = 3
        Me.lblPunchline.Text = "You can tune a guitar but you can't tuna fish."
        Me.lblPunchline.Visible = False
        '
        'lblLaugh
        '
        Me.lblLaugh.AutoSize = True
        Me.lblLaugh.Location = New System.Drawing.Point(126, 218)
        Me.lblLaugh.Name = "lblLaugh"
        Me.lblLaugh.Size = New System.Drawing.Size(50, 13)
        Me.lblLaugh.TabIndex = 4
        Me.lblLaugh.Text = "Tee hee!"
        Me.lblLaugh.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 264)
        Me.Controls.Add(Me.lblLaugh)
        Me.Controls.Add(Me.lblPunchline)
        Me.Controls.Add(Me.lblSetUp)
        Me.Controls.Add(Me.btnPunchLine)
        Me.Controls.Add(Me.btnSetUp)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSetUp As System.Windows.Forms.Button
    Friend WithEvents btnPunchLine As System.Windows.Forms.Button
    Friend WithEvents lblSetUp As System.Windows.Forms.Label
    Friend WithEvents lblPunchline As System.Windows.Forms.Label
    Friend WithEvents lblLaugh As System.Windows.Forms.Label

End Class

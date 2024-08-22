<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.btnAddPersonnel = New System.Windows.Forms.Button()
        Me.btnCheckIn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ExitPicture = New System.Windows.Forms.PictureBox()
        Me.btnReports = New System.Windows.Forms.Button()
        CType(Me.ExitPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddPersonnel
        '
        Me.btnAddPersonnel.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPersonnel.Location = New System.Drawing.Point(331, 200)
        Me.btnAddPersonnel.Name = "btnAddPersonnel"
        Me.btnAddPersonnel.Size = New System.Drawing.Size(142, 71)
        Me.btnAddPersonnel.TabIndex = 15
        Me.btnAddPersonnel.Text = "Add personnel"
        Me.btnAddPersonnel.UseVisualStyleBackColor = True
        '
        'btnCheckIn
        '
        Me.btnCheckIn.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckIn.Location = New System.Drawing.Point(171, 200)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Size = New System.Drawing.Size(126, 71)
        Me.btnCheckIn.TabIndex = 14
        Me.btnCheckIn.Text = "CHECK-IN"
        Me.btnCheckIn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(344, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 22)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Welcome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(261, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(277, 42)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Point Security"
        '
        'ExitPicture
        '
        Me.ExitPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitPicture.Image = CType(resources.GetObject("ExitPicture.Image"), System.Drawing.Image)
        Me.ExitPicture.Location = New System.Drawing.Point(336, 314)
        Me.ExitPicture.Name = "ExitPicture"
        Me.ExitPicture.Size = New System.Drawing.Size(116, 84)
        Me.ExitPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ExitPicture.TabIndex = 11
        Me.ExitPicture.TabStop = False
        '
        'btnReports
        '
        Me.btnReports.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.Location = New System.Drawing.Point(505, 200)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(142, 71)
        Me.btnReports.TabIndex = 16
        Me.btnReports.Text = "REPORTS"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnAddPersonnel)
        Me.Controls.Add(Me.btnCheckIn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ExitPicture)
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.ExitPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddPersonnel As Button
    Friend WithEvents btnCheckIn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ExitPicture As PictureBox
    Friend WithEvents btnReports As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.dgvReportResults = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.chkResidents = New System.Windows.Forms.CheckBox()
        Me.chkVisitor = New System.Windows.Forms.CheckBox()
        Me.chkMultiDayYes = New System.Windows.Forms.CheckBox()
        Me.chkMultiDayNo = New System.Windows.Forms.CheckBox()
        Me.chkCheckedIn = New System.Windows.Forms.CheckBox()
        Me.chkCheckedOut = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.chkWorker = New System.Windows.Forms.CheckBox()
        CType(Me.dgvReportResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvReportResults
        '
        Me.dgvReportResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReportResults.Location = New System.Drawing.Point(31, 90)
        Me.dgvReportResults.Name = "dgvReportResults"
        Me.dgvReportResults.Size = New System.Drawing.Size(538, 303)
        Me.dgvReportResults.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(264, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 22)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Guests"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(601, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 22)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Filter Options"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.Font = New System.Drawing.Font("MS PGothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(620, 342)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(123, 33)
        Me.btnSubmit.TabIndex = 31
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'chkResidents
        '
        Me.chkResidents.AutoSize = True
        Me.chkResidents.Location = New System.Drawing.Point(605, 125)
        Me.chkResidents.Name = "chkResidents"
        Me.chkResidents.Size = New System.Drawing.Size(73, 17)
        Me.chkResidents.TabIndex = 32
        Me.chkResidents.Text = "Residents"
        Me.chkResidents.UseVisualStyleBackColor = True
        '
        'chkVisitor
        '
        Me.chkVisitor.AutoSize = True
        Me.chkVisitor.Location = New System.Drawing.Point(689, 125)
        Me.chkVisitor.Name = "chkVisitor"
        Me.chkVisitor.Size = New System.Drawing.Size(54, 17)
        Me.chkVisitor.TabIndex = 33
        Me.chkVisitor.Text = "Visitor"
        Me.chkVisitor.UseVisualStyleBackColor = True
        '
        'chkMultiDayYes
        '
        Me.chkMultiDayYes.AutoSize = True
        Me.chkMultiDayYes.Location = New System.Drawing.Point(608, 212)
        Me.chkMultiDayYes.Name = "chkMultiDayYes"
        Me.chkMultiDayYes.Size = New System.Drawing.Size(44, 17)
        Me.chkMultiDayYes.TabIndex = 34
        Me.chkMultiDayYes.Text = "Yes"
        Me.chkMultiDayYes.UseVisualStyleBackColor = True
        '
        'chkMultiDayNo
        '
        Me.chkMultiDayNo.AutoSize = True
        Me.chkMultiDayNo.Location = New System.Drawing.Point(695, 212)
        Me.chkMultiDayNo.Name = "chkMultiDayNo"
        Me.chkMultiDayNo.Size = New System.Drawing.Size(40, 17)
        Me.chkMultiDayNo.TabIndex = 35
        Me.chkMultiDayNo.Text = "No"
        Me.chkMultiDayNo.UseVisualStyleBackColor = True
        '
        'chkCheckedIn
        '
        Me.chkCheckedIn.AutoSize = True
        Me.chkCheckedIn.Location = New System.Drawing.Point(608, 283)
        Me.chkCheckedIn.Name = "chkCheckedIn"
        Me.chkCheckedIn.Size = New System.Drawing.Size(81, 17)
        Me.chkCheckedIn.TabIndex = 36
        Me.chkCheckedIn.Text = "Checked In"
        Me.chkCheckedIn.UseVisualStyleBackColor = True
        '
        'chkCheckedOut
        '
        Me.chkCheckedOut.AutoSize = True
        Me.chkCheckedOut.Location = New System.Drawing.Point(695, 283)
        Me.chkCheckedOut.Name = "chkCheckedOut"
        Me.chkCheckedOut.Size = New System.Drawing.Size(89, 17)
        Me.chkCheckedOut.TabIndex = 37
        Me.chkCheckedOut.Text = "Checked Out"
        Me.chkCheckedOut.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(599, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Visit Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(602, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Multi-Day Visit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(602, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Status"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("MS PGothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(623, 395)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(112, 33)
        Me.btnBack.TabIndex = 41
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'chkWorker
        '
        Me.chkWorker.AutoSize = True
        Me.chkWorker.Location = New System.Drawing.Point(605, 148)
        Me.chkWorker.Name = "chkWorker"
        Me.chkWorker.Size = New System.Drawing.Size(61, 17)
        Me.chkWorker.TabIndex = 42
        Me.chkWorker.Text = "Worker"
        Me.chkWorker.UseVisualStyleBackColor = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.chkWorker)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkCheckedOut)
        Me.Controls.Add(Me.chkCheckedIn)
        Me.Controls.Add(Me.chkMultiDayNo)
        Me.Controls.Add(Me.chkMultiDayYes)
        Me.Controls.Add(Me.chkVisitor)
        Me.Controls.Add(Me.chkResidents)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvReportResults)
        Me.Name = "Form8"
        Me.Text = "Form8"
        CType(Me.dgvReportResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvReportResults As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents chkResidents As CheckBox
    Friend WithEvents chkVisitor As CheckBox
    Friend WithEvents chkMultiDayYes As CheckBox
    Friend WithEvents chkMultiDayNo As CheckBox
    Friend WithEvents chkCheckedIn As CheckBox
    Friend WithEvents chkCheckedOut As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents chkWorker As CheckBox
End Class

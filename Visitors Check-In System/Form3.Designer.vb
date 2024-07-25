<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbVisitType = New System.Windows.Forms.ComboBox()
        Me.txtNames = New System.Windows.Forms.TextBox()
        Me.cmbHouseNo = New System.Windows.Forms.ComboBox()
        Me.txtIDNo = New System.Windows.Forms.TextBox()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.cmbMultiDayVisit = New System.Windows.Forms.ComboBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnVisitors = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCheckIn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpVisitDate = New System.Windows.Forms.DateTimePicker()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(323, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 22)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Visitor Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Visit Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(184, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 22)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Names:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 22)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "House No:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(192, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 22)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "ID No:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(189, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 22)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Phone:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(104, 292)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 22)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Multi day Visit?"
        '
        'cmbVisitType
        '
        Me.cmbVisitType.FormattingEnabled = True
        Me.cmbVisitType.Items.AddRange(New Object() {"Visitor", "Resident", "Worker"})
        Me.cmbVisitType.Location = New System.Drawing.Point(292, 70)
        Me.cmbVisitType.Name = "cmbVisitType"
        Me.cmbVisitType.Size = New System.Drawing.Size(165, 21)
        Me.cmbVisitType.TabIndex = 16
        '
        'txtNames
        '
        Me.txtNames.Location = New System.Drawing.Point(292, 121)
        Me.txtNames.Name = "txtNames"
        Me.txtNames.Size = New System.Drawing.Size(165, 20)
        Me.txtNames.TabIndex = 17
        '
        'cmbHouseNo
        '
        Me.cmbHouseNo.FormattingEnabled = True
        Me.cmbHouseNo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26"})
        Me.cmbHouseNo.Location = New System.Drawing.Point(292, 163)
        Me.cmbHouseNo.Name = "cmbHouseNo"
        Me.cmbHouseNo.Size = New System.Drawing.Size(165, 21)
        Me.cmbHouseNo.TabIndex = 18
        '
        'txtIDNo
        '
        Me.txtIDNo.Location = New System.Drawing.Point(292, 207)
        Me.txtIDNo.Name = "txtIDNo"
        Me.txtIDNo.Size = New System.Drawing.Size(165, 20)
        Me.txtIDNo.TabIndex = 19
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Location = New System.Drawing.Point(292, 248)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(165, 20)
        Me.txtPhoneNo.TabIndex = 20
        '
        'cmbMultiDayVisit
        '
        Me.cmbMultiDayVisit.FormattingEnabled = True
        Me.cmbMultiDayVisit.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbMultiDayVisit.Location = New System.Drawing.Point(292, 296)
        Me.cmbMultiDayVisit.Name = "cmbMultiDayVisit"
        Me.cmbMultiDayVisit.Size = New System.Drawing.Size(165, 21)
        Me.cmbMultiDayVisit.TabIndex = 21
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("MS PGothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(266, 387)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(112, 33)
        Me.btnBack.TabIndex = 22
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnVisitors
        '
        Me.btnVisitors.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVisitors.Font = New System.Drawing.Font("MS PGothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisitors.Location = New System.Drawing.Point(415, 387)
        Me.btnVisitors.Name = "btnVisitors"
        Me.btnVisitors.Size = New System.Drawing.Size(112, 33)
        Me.btnVisitors.TabIndex = 23
        Me.btnVisitors.Text = "Visitors"
        Me.btnVisitors.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Red
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("MS PGothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(509, 163)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 33)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCheckIn
        '
        Me.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckIn.Font = New System.Drawing.Font("MS PGothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckIn.Location = New System.Drawing.Point(509, 224)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Size = New System.Drawing.Size(112, 33)
        Me.btnCheckIn.TabIndex = 25
        Me.btnCheckIn.Text = "Checkin"
        Me.btnCheckIn.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(505, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 22)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Date:"
        '
        'dtpVisitDate
        '
        Me.dtpVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVisitDate.Location = New System.Drawing.Point(581, 70)
        Me.dtpVisitDate.Name = "dtpVisitDate"
        Me.dtpVisitDate.Size = New System.Drawing.Size(108, 20)
        Me.dtpVisitDate.TabIndex = 27
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("MS PGothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(562, 387)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 33)
        Me.btnExit.TabIndex = 28
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.dtpVisitDate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCheckIn)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnVisitors)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.cmbMultiDayVisit)
        Me.Controls.Add(Me.txtPhoneNo)
        Me.Controls.Add(Me.txtIDNo)
        Me.Controls.Add(Me.cmbHouseNo)
        Me.Controls.Add(Me.txtNames)
        Me.Controls.Add(Me.cmbVisitType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbVisitType As ComboBox
    Friend WithEvents txtNames As TextBox
    Friend WithEvents cmbHouseNo As ComboBox
    Friend WithEvents txtIDNo As TextBox
    Friend WithEvents txtPhoneNo As TextBox
    Friend WithEvents cmbMultiDayVisit As ComboBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnVisitors As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCheckIn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpVisitDate As DateTimePicker
    Friend WithEvents btnExit As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentFeesForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.unitsTextBox = New System.Windows.Forms.TextBox()
        Me.newStudentButton = New System.Windows.Forms.Button()
        Me.residentRadioButton = New System.Windows.Forms.RadioButton()
        Me.nonResidentRadioButton = New System.Windows.Forms.RadioButton()
        Me.nonUSCitizenRadioButton = New System.Windows.Forms.RadioButton()
        Me.asbCardFeeCheckBox = New System.Windows.Forms.CheckBox()
        Me.parkingFeeCheckBox = New System.Windows.Forms.CheckBox()
        Me.photoIdFeeCheckBox = New System.Windows.Forms.CheckBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.feeLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(24, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Fees"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.photoIdFeeCheckBox)
        Me.GroupBox1.Controls.Add(Me.parkingFeeCheckBox)
        Me.GroupBox1.Controls.Add(Me.asbCardFeeCheckBox)
        Me.GroupBox1.Controls.Add(Me.nonUSCitizenRadioButton)
        Me.GroupBox1.Controls.Add(Me.nonResidentRadioButton)
        Me.GroupBox1.Controls.Add(Me.residentRadioButton)
        Me.GroupBox1.Controls.Add(Me.newStudentButton)
        Me.GroupBox1.Controls.Add(Me.unitsTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 152)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Information"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Units"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'unitsTextBox
        '
        Me.unitsTextBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unitsTextBox.Location = New System.Drawing.Point(64, 32)
        Me.unitsTextBox.Name = "unitsTextBox"
        Me.unitsTextBox.Size = New System.Drawing.Size(48, 22)
        Me.unitsTextBox.TabIndex = 1
        Me.unitsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'newStudentButton
        '
        Me.newStudentButton.Location = New System.Drawing.Point(192, 24)
        Me.newStudentButton.Name = "newStudentButton"
        Me.newStudentButton.Size = New System.Drawing.Size(96, 24)
        Me.newStudentButton.TabIndex = 2
        Me.newStudentButton.Text = "&New Student"
        Me.newStudentButton.UseVisualStyleBackColor = True
        '
        'residentRadioButton
        '
        Me.residentRadioButton.AutoSize = True
        Me.residentRadioButton.Checked = True
        Me.residentRadioButton.Location = New System.Drawing.Point(24, 72)
        Me.residentRadioButton.Name = "residentRadioButton"
        Me.residentRadioButton.Size = New System.Drawing.Size(67, 17)
        Me.residentRadioButton.TabIndex = 3
        Me.residentRadioButton.TabStop = True
        Me.residentRadioButton.Text = "Resident"
        Me.residentRadioButton.UseVisualStyleBackColor = True
        '
        'nonResidentRadioButton
        '
        Me.nonResidentRadioButton.AutoSize = True
        Me.nonResidentRadioButton.Location = New System.Drawing.Point(24, 96)
        Me.nonResidentRadioButton.Name = "nonResidentRadioButton"
        Me.nonResidentRadioButton.Size = New System.Drawing.Size(90, 17)
        Me.nonResidentRadioButton.TabIndex = 4
        Me.nonResidentRadioButton.Text = "Non-Resident"
        Me.nonResidentRadioButton.UseVisualStyleBackColor = True
        '
        'nonUSCitizenRadioButton
        '
        Me.nonUSCitizenRadioButton.AutoSize = True
        Me.nonUSCitizenRadioButton.Location = New System.Drawing.Point(24, 120)
        Me.nonUSCitizenRadioButton.Name = "nonUSCitizenRadioButton"
        Me.nonUSCitizenRadioButton.Size = New System.Drawing.Size(97, 17)
        Me.nonUSCitizenRadioButton.TabIndex = 5
        Me.nonUSCitizenRadioButton.Text = "Non-US Citizen"
        Me.nonUSCitizenRadioButton.UseVisualStyleBackColor = True
        '
        'asbCardFeeCheckBox
        '
        Me.asbCardFeeCheckBox.AutoSize = True
        Me.asbCardFeeCheckBox.Location = New System.Drawing.Point(176, 72)
        Me.asbCardFeeCheckBox.Name = "asbCardFeeCheckBox"
        Me.asbCardFeeCheckBox.Size = New System.Drawing.Size(93, 17)
        Me.asbCardFeeCheckBox.TabIndex = 6
        Me.asbCardFeeCheckBox.Text = "ASB Card Fee"
        Me.asbCardFeeCheckBox.UseVisualStyleBackColor = True
        '
        'parkingFeeCheckBox
        '
        Me.parkingFeeCheckBox.AutoSize = True
        Me.parkingFeeCheckBox.Location = New System.Drawing.Point(176, 96)
        Me.parkingFeeCheckBox.Name = "parkingFeeCheckBox"
        Me.parkingFeeCheckBox.Size = New System.Drawing.Size(83, 17)
        Me.parkingFeeCheckBox.TabIndex = 7
        Me.parkingFeeCheckBox.Text = "Parking Fee"
        Me.parkingFeeCheckBox.UseVisualStyleBackColor = True
        '
        'photoIdFeeCheckBox
        '
        Me.photoIdFeeCheckBox.AutoSize = True
        Me.photoIdFeeCheckBox.Location = New System.Drawing.Point(176, 120)
        Me.photoIdFeeCheckBox.Name = "photoIdFeeCheckBox"
        Me.photoIdFeeCheckBox.Size = New System.Drawing.Size(89, 17)
        Me.photoIdFeeCheckBox.TabIndex = 8
        Me.photoIdFeeCheckBox.Text = "Photo ID Fee"
        Me.photoIdFeeCheckBox.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(16, 232)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(96, 24)
        Me.calculateButton.TabIndex = 2
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(16, 264)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(96, 24)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(176, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fee"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'feeLabel
        '
        Me.feeLabel.BackColor = System.Drawing.Color.White
        Me.feeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.feeLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.feeLabel.Location = New System.Drawing.Point(240, 232)
        Me.feeLabel.Name = "feeLabel"
        Me.feeLabel.Size = New System.Drawing.Size(88, 24)
        Me.feeLabel.TabIndex = 5
        Me.feeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(180, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Created by Jenny Nguyen"
        '
        'studentFeesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 321)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.feeLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "studentFeesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB4-Student Fees"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents photoIdFeeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents parkingFeeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents asbCardFeeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents nonUSCitizenRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents nonResidentRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents residentRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents newStudentButton As System.Windows.Forms.Button
    Friend WithEvents unitsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents feeLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class

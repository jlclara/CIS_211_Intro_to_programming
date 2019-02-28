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
        Me.seniorDiscountCheckBox = New System.Windows.Forms.CheckBox()
        Me.medicalDiscountCheckBox = New System.Windows.Forms.CheckBox()
        Me.incomeDiscountCheckBox = New System.Windows.Forms.CheckBox()
        Me.agriculturalRadioButton = New System.Windows.Forms.RadioButton()
        Me.commericalRadioButton = New System.Windows.Forms.RadioButton()
        Me.residentialRadioButton = New System.Windows.Forms.RadioButton()
        Me.newCustomerButton = New System.Windows.Forms.Button()
        Me.kiloWattsTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.billLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(24, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Electric Bill"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.seniorDiscountCheckBox)
        Me.GroupBox1.Controls.Add(Me.medicalDiscountCheckBox)
        Me.GroupBox1.Controls.Add(Me.incomeDiscountCheckBox)
        Me.GroupBox1.Controls.Add(Me.agriculturalRadioButton)
        Me.GroupBox1.Controls.Add(Me.commericalRadioButton)
        Me.GroupBox1.Controls.Add(Me.residentialRadioButton)
        Me.GroupBox1.Controls.Add(Me.newCustomerButton)
        Me.GroupBox1.Controls.Add(Me.kiloWattsTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 152)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'seniorDiscountCheckBox
        '
        Me.seniorDiscountCheckBox.AutoSize = True
        Me.seniorDiscountCheckBox.Location = New System.Drawing.Point(176, 120)
        Me.seniorDiscountCheckBox.Name = "seniorDiscountCheckBox"
        Me.seniorDiscountCheckBox.Size = New System.Drawing.Size(101, 17)
        Me.seniorDiscountCheckBox.TabIndex = 8
        Me.seniorDiscountCheckBox.Text = "Senior Discount"
        Me.seniorDiscountCheckBox.UseVisualStyleBackColor = True
        '
        'medicalDiscountCheckBox
        '
        Me.medicalDiscountCheckBox.AutoSize = True
        Me.medicalDiscountCheckBox.Location = New System.Drawing.Point(176, 96)
        Me.medicalDiscountCheckBox.Name = "medicalDiscountCheckBox"
        Me.medicalDiscountCheckBox.Size = New System.Drawing.Size(108, 17)
        Me.medicalDiscountCheckBox.TabIndex = 7
        Me.medicalDiscountCheckBox.Text = "Medical Discount"
        Me.medicalDiscountCheckBox.UseVisualStyleBackColor = True
        '
        'incomeDiscountCheckBox
        '
        Me.incomeDiscountCheckBox.AutoSize = True
        Me.incomeDiscountCheckBox.Location = New System.Drawing.Point(176, 72)
        Me.incomeDiscountCheckBox.Name = "incomeDiscountCheckBox"
        Me.incomeDiscountCheckBox.Size = New System.Drawing.Size(106, 17)
        Me.incomeDiscountCheckBox.TabIndex = 6
        Me.incomeDiscountCheckBox.Text = "Income Discount"
        Me.incomeDiscountCheckBox.UseVisualStyleBackColor = True
        '
        'agriculturalRadioButton
        '
        Me.agriculturalRadioButton.AutoSize = True
        Me.agriculturalRadioButton.Location = New System.Drawing.Point(24, 120)
        Me.agriculturalRadioButton.Name = "agriculturalRadioButton"
        Me.agriculturalRadioButton.Size = New System.Drawing.Size(77, 17)
        Me.agriculturalRadioButton.TabIndex = 5
        Me.agriculturalRadioButton.Text = "Agricultural"
        Me.agriculturalRadioButton.UseVisualStyleBackColor = True
        '
        'commericalRadioButton
        '
        Me.commericalRadioButton.AutoSize = True
        Me.commericalRadioButton.Location = New System.Drawing.Point(24, 96)
        Me.commericalRadioButton.Name = "commericalRadioButton"
        Me.commericalRadioButton.Size = New System.Drawing.Size(79, 17)
        Me.commericalRadioButton.TabIndex = 4
        Me.commericalRadioButton.Text = "Commercial"
        Me.commericalRadioButton.UseVisualStyleBackColor = True
        '
        'residentialRadioButton
        '
        Me.residentialRadioButton.AutoSize = True
        Me.residentialRadioButton.Checked = True
        Me.residentialRadioButton.Location = New System.Drawing.Point(24, 72)
        Me.residentialRadioButton.Name = "residentialRadioButton"
        Me.residentialRadioButton.Size = New System.Drawing.Size(77, 17)
        Me.residentialRadioButton.TabIndex = 3
        Me.residentialRadioButton.TabStop = True
        Me.residentialRadioButton.Text = "Residential"
        Me.residentialRadioButton.UseVisualStyleBackColor = True
        '
        'newCustomerButton
        '
        Me.newCustomerButton.Location = New System.Drawing.Point(192, 24)
        Me.newCustomerButton.Name = "newCustomerButton"
        Me.newCustomerButton.Size = New System.Drawing.Size(96, 24)
        Me.newCustomerButton.TabIndex = 2
        Me.newCustomerButton.Text = "&New Customer"
        Me.newCustomerButton.UseVisualStyleBackColor = True
        '
        'kiloWattsTextBox
        '
        Me.kiloWattsTextBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kiloWattsTextBox.Location = New System.Drawing.Point(80, 32)
        Me.kiloWattsTextBox.Name = "kiloWattsTextBox"
        Me.kiloWattsTextBox.Size = New System.Drawing.Size(48, 22)
        Me.kiloWattsTextBox.TabIndex = 1
        Me.kiloWattsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "KiloWatts"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Label3.Text = "Bill"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'billLabel
        '
        Me.billLabel.BackColor = System.Drawing.Color.White
        Me.billLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.billLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.billLabel.Location = New System.Drawing.Point(240, 232)
        Me.billLabel.Name = "billLabel"
        Me.billLabel.Size = New System.Drawing.Size(88, 24)
        Me.billLabel.TabIndex = 5
        Me.billLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Controls.Add(Me.billLabel)
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
    Friend WithEvents seniorDiscountCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents medicalDiscountCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents incomeDiscountCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents agriculturalRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents commericalRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents residentialRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents newCustomerButton As System.Windows.Forms.Button
    Friend WithEvents kiloWattsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents billLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calculatorForm
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
        Dim label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calculatorForm))
        Me.label12 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.codeLabel = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.rateLabel = New System.Windows.Forms.Label()
        Me.kiloWattsLabel = New System.Windows.Forms.Label()
        Me.codeComboBox = New System.Windows.Forms.ComboBox()
        Me.priorTextBox = New System.Windows.Forms.TextBox()
        Me.lighteningPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.currentTextBox = New System.Windows.Forms.TextBox()
        label1 = New System.Windows.Forms.Label()
        CType(Me.lighteningPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        label1.Font = New System.Drawing.Font("Arial", 22.0!, System.Drawing.FontStyle.Bold)
        label1.ForeColor = System.Drawing.Color.Red
        label1.Location = New System.Drawing.Point(80, 16)
        label1.Name = "label1"
        label1.Size = New System.Drawing.Size(280, 32)
        label1.TabIndex = 21
        label1.Text = "Electric Calculator"
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(5, 256)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(171, 16)
        Me.label12.TabIndex = 35
        Me.label12.Text = "Created by Jenny Nguyen"
        Me.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exitButton
        '
        Me.exitButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(280, 216)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(80, 23)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(176, 216)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(80, 23)
        Me.calculateButton.TabIndex = 4
        Me.calculateButton.Text = "C&alculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(72, 216)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(80, 23)
        Me.clearButton.TabIndex = 3
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'label11
        '
        Me.label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(280, 137)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(80, 23)
        Me.label11.TabIndex = 34
        Me.label11.Text = "Total"
        Me.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label10
        '
        Me.label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(176, 137)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(80, 23)
        Me.label10.TabIndex = 33
        Me.label10.Text = "Rate"
        Me.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label9
        '
        Me.label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(72, 137)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(80, 23)
        Me.label9.TabIndex = 32
        Me.label9.Text = "KiloWatts"
        Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'codeLabel
        '
        Me.codeLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codeLabel.Location = New System.Drawing.Point(72, 71)
        Me.codeLabel.Name = "codeLabel"
        Me.codeLabel.Size = New System.Drawing.Size(80, 23)
        Me.codeLabel.TabIndex = 30
        Me.codeLabel.Text = "Code"
        Me.codeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label3
        '
        Me.label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(176, 73)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(80, 23)
        Me.label3.TabIndex = 29
        Me.label3.Text = "Prior"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalLabel
        '
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLabel.Location = New System.Drawing.Point(280, 160)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(80, 23)
        Me.totalLabel.TabIndex = 28
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rateLabel
        '
        Me.rateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rateLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rateLabel.Location = New System.Drawing.Point(176, 160)
        Me.rateLabel.Name = "rateLabel"
        Me.rateLabel.Size = New System.Drawing.Size(80, 23)
        Me.rateLabel.TabIndex = 27
        Me.rateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'kiloWattsLabel
        '
        Me.kiloWattsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kiloWattsLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kiloWattsLabel.Location = New System.Drawing.Point(72, 160)
        Me.kiloWattsLabel.Name = "kiloWattsLabel"
        Me.kiloWattsLabel.Size = New System.Drawing.Size(80, 23)
        Me.kiloWattsLabel.TabIndex = 26
        Me.kiloWattsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'codeComboBox
        '
        Me.codeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.codeComboBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codeComboBox.FormattingEnabled = True
        Me.codeComboBox.Items.AddRange(New Object() {"Resident", "Business", "Income", "Senior", "None"})
        Me.codeComboBox.Location = New System.Drawing.Point(72, 95)
        Me.codeComboBox.Name = "codeComboBox"
        Me.codeComboBox.Size = New System.Drawing.Size(80, 24)
        Me.codeComboBox.TabIndex = 0
        '
        'priorTextBox
        '
        Me.priorTextBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priorTextBox.Location = New System.Drawing.Point(176, 97)
        Me.priorTextBox.Name = "priorTextBox"
        Me.priorTextBox.Size = New System.Drawing.Size(80, 22)
        Me.priorTextBox.TabIndex = 1
        Me.priorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lighteningPictureBox
        '
        Me.lighteningPictureBox.Image = CType(resources.GetObject("lighteningPictureBox.Image"), System.Drawing.Image)
        Me.lighteningPictureBox.Location = New System.Drawing.Point(8, 8)
        Me.lighteningPictureBox.Name = "lighteningPictureBox"
        Me.lighteningPictureBox.Size = New System.Drawing.Size(50, 50)
        Me.lighteningPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lighteningPictureBox.TabIndex = 18
        Me.lighteningPictureBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(280, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Current"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'currentTextBox
        '
        Me.currentTextBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentTextBox.Location = New System.Drawing.Point(280, 97)
        Me.currentTextBox.Name = "currentTextBox"
        Me.currentTextBox.Size = New System.Drawing.Size(80, 22)
        Me.currentTextBox.TabIndex = 2
        Me.currentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'calculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 281)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.currentTextBox)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.codeLabel)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.rateLabel)
        Me.Controls.Add(Me.kiloWattsLabel)
        Me.Controls.Add(Me.codeComboBox)
        Me.Controls.Add(Me.priorTextBox)
        Me.Controls.Add(label1)
        Me.Controls.Add(Me.lighteningPictureBox)
        Me.Name = "calculatorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB1-Electric Calculator"
        CType(Me.lighteningPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents exitButton As System.Windows.Forms.Button
    Private WithEvents calculateButton As System.Windows.Forms.Button
    Private WithEvents clearButton As System.Windows.Forms.Button
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents codeLabel As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents totalLabel As System.Windows.Forms.Label
    Private WithEvents rateLabel As System.Windows.Forms.Label
    Private WithEvents kiloWattsLabel As System.Windows.Forms.Label
    Private WithEvents codeComboBox As System.Windows.Forms.ComboBox
    Private WithEvents priorTextBox As System.Windows.Forms.TextBox
    Private WithEvents lighteningPictureBox As System.Windows.Forms.PictureBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents currentTextBox As System.Windows.Forms.TextBox

End Class

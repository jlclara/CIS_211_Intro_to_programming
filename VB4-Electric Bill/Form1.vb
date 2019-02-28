' ******************************************************************************
' *                                Electric Bill                               *
' ******************************************************************************
' *                                                                            *
' *  Programmer   : Jenny Nguyen                                               *
' *  Chapter      : VB4                                                        *
' *  Assignment   : 11                                                         *
' *  Form Name    : Electric Bill                                              *
' *  Date Created : 12/6/2015                                                  *
' *  Description  : This form calculates a customer's electric bill            *
' *                                                                            *
' ******************************************************************************

' Set Define Variables Option On
Option Explicit On

' Set No Automatic Data Conversion On
Option Strict On

Public Class studentFeesForm

    ' Set Residential Rate constant to .20
    Const RESIDENTIAL_RATE_Decimal As Decimal = 0.2D

    ' Set Commercial Rate constant to .15
    Const COMMERCIAL_RATE_Decimal As Decimal = 0.15D

    ' Set Agricultural Rate constant to .10
    Const AGRICULTURAL_RATE_Decimal As Decimal = 0.1D

    ' Set Income Discount constant to .05
    Const INCOME_DISCOUNT_Decimal As Decimal = 0.05D

    ' Set Medical Discount constant to .05
    Const MEDICAL_DISCOUNT_Decimal As Decimal = 0.05D

    ' Set Senior Discount constant to .05
    Const SENIOR_DISCOUNT_Decimal As Decimal = 0.05D

    ' Set Minimum KiloWatts to 1
    Const MINIMUM_KILOWATTS_Integer As Integer = 1

    ' Set Maximum KiloWatts to 10000
    Const MAXINUM_KILOWATTS_Integer As Integer = 10000

    Private Sub newCustomerButton_Click(sender As Object, e As EventArgs) Handles newCustomerButton.Click

        ' **************************************************************************
        ' *  Procedure    : New Customer-Click                                     *
        ' *  Description  : The New Customer button clears the KiloWatts textbox   *
        ' *                 and Bill label box.  It turns the Residential radio    *
        ' *                 button On and turns Off the Income, Medical, and       *
        ' *                 Senior Discount check boxes.  Finally, it sets the     *
        ' *                 focus to the KiloWatts textbox.                        *
        ' **************************************************************************

        ' Define Variables: None

        ' Clear KiloWatts TextBox
        kiloWattsTextBox.Text = ""

        ' Clear Bill Label
        billLabel.Text = ""

        ' Set Residential RadioButton On
        residentialRadioButton.Checked = True

        ' Clear Income Discount CheckBox
        incomeDiscountCheckBox.Checked = False

        ' Clear Medical Discount CheckBox
        medicalDiscountCheckBox.Checked = False

        ' Clear Senior Discount CheckBox
        seniorDiscountCheckBox.Checked = False

        ' Set the Focus to KiloWattsTextBox
        kiloWattsTextBox.Focus()

        ' End New Customer-Click
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        ' **************************************************************************
        ' *  Procedure    : Exit-Click                                             *
        ' *  Description  : When the Exit button is clicked the message "Do you    *
        ' *                 want to Exit?" is displayed with Yes/No buttons and a  *
        ' *                 Question icon.  The form is closed if the response is  *
        ' *                 Yes                                                    *
        ' **************************************************************************

        ' Define Variables: Exit Message Response
        Dim exitResponseDialogResult As DialogResult

        ' Display Exit Message
        ' Get Exit Message Response
        exitResponseDialogResult = MessageBox.Show("Do you want to Exit?", _
                                                   "Exit Electric Bill", _
                                                   MessageBoxButtons.YesNo, _
                                                   MessageBoxIcon.Question, _
                                            MessageBoxDefaultButton.Button1)

        ' IF Exit Message Response = Yes
        If exitResponseDialogResult = Windows.Forms.DialogResult.Yes Then
            ' Close the Form
            Me.Close()
            ' End IF
        End If


    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click

        ' **************************************************************************
        ' *  Procedure    : Calculate-Click                                        *
        ' *  Description  : This procedures call the Check KiloWatts, Electric     *
        ' *                 Charge, and Discount Rate procedures.  When the        *
        ' *                 Calculate button is clicked a customer bill is         *
        ' *                 calculated.  It calls the Check KiloWatts procedure to *
        ' *                 determine if the kilowatts are within a specified      *
        ' *                 range.  If the kilowatts are valid, then a customer    *
        ' *                 bill is calculated and displayed.  The Bill is         *
        ' *                 calculated by multiplying the Electric Charge by ( 1   *
        ' *                 minus the Discount Rate ).  If the kilowatts are       *
        ' *                 invalid, an error message is displayed and the focus   *
        ' *                 is returned to the KiloWatts textbox.                  *
        ' **************************************************************************

        ' Define Variables: KiloWatts, KiloWatts Are Valid, Bill
        Dim kiloWattsInteger As Integer
        Dim kiloWattsAreValidBoolean As Boolean
        Dim billDecimal As Decimal

        ' Call Check KiloWatts (Out: KiloWatts, KiloWatts Are Valid)
        checkKiloWatts(kiloWattsInteger, kiloWattsAreValidBoolean)

        ' IF KiloWatts Are Valid  = True
        If kiloWattsAreValidBoolean Then

            ' Calculate Bill = Electric Charge ( In: KiloWatts ) * ( 1 - Discount Rate () )
            billDecimal = electricCharge(kiloWattsInteger) * (1 - discountRate())

            ' Display Bill
            billLabel.Text = billDecimal.ToString("C2")

        Else
            ' Display Units Error Message
            MessageBox.Show("KiloWatts must be a number from " & _
                            MINIMUM_KILOWATTS_Integer & " to " & _
                            MAXINUM_KILOWATTS_Integer & " !", "KiloWatts Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Set the Focus to the KiloWatts TextBox
            kiloWattsTextBox.Focus()

            ' End IF
        End If


    End Sub
    ' Begin Check KiloWatts ( Out: Out: KiloWatts, KiloWatts Are Valid )
    Private Sub checkKiloWatts(ByRef kiloWattsInteger As Integer, _
                               ByRef kiloWattsAreValidBoolean As Boolean)
        ' **************************************************************************
        ' *  Procedure    : Check KiloWatts                                        *
        ' *  Description  : This procedure validates the kilowatts.  The kilowatts *
        ' *                 must be numeric and within the minimum and maximum     *
        ' *                 kilowatts range.  A value of true is returned if the   *
        ' *                 kilowatts are valid; false if the kilowatts are        *
        ' *                 invalid.  It returns the kilowatts and kilowatts are   *
        ' *                 valid as output parameters when completed	              *
        ' **************************************************************************

        ' Define Variables: None
        ' Get KiloWatts from Form
        ' IF KiloWatts >= Minimum KiloWatts constant AND KiloWatts <= Maximum KiloWatts constant
        If Integer.TryParse(kiloWattsTextBox.Text, kiloWattsInteger) = True And _
            kiloWattsInteger >= MINIMUM_KILOWATTS_Integer And _
            kiloWattsInteger <= MAXINUM_KILOWATTS_Integer Then

            ' Set KiloWatts Are Valid to True
            kiloWattsAreValidBoolean = True

        Else
            ' Set KiloWatts are Valid to False
            kiloWattsAreValidBoolean = False
            ' End IF
        End If
        ' End Check KiloWatts

    End Sub
    ' Begin Electric Charge ( In: KiloWatts ) As a Decimal Number
    Private Function electricCharge(ByVal kiloWattsInteger As Integer) As Decimal
        ' **************************************************************************
        ' *  Procedure    : Electric Charge                                        *
        ' *  Description  : This value return procedure calculates the electric    *
        ' *                 charge.  The electric charge is calculated by          *
        ' *                 multiplying the kilowatts time sthe appropriate rate   *
        ' *                 as determined by the account type options.  These      *
        ' *                 rates are defined as form constants. It receives the   *
        ' *                 kilowatts as an input parameter and returns the charge *
        ' *                 as a decimal value when completed.                     *
        ' **************************************************************************

        ' Define Variables: Rate, charge
        Dim rateDecimal, chargeDecimal As Decimal

        ' IF Residential RadioButton is Selected
        If residentialRadioButton.Checked Then

            ' Rate = Residential Rate Constant
            rateDecimal = RESIDENTIAL_RATE_Decimal

            ' Else IF Commerical RadioButton is Selected
        ElseIf commericalRadioButton.Checked Then

            ' Rate = Commercial Rate Constant
            rateDecimal = COMMERCIAL_RATE_Decimal

        Else
            ' Rate = Agricultural Rate Constant
            rateDecimal = AGRICULTURAL_RATE_Decimal

            ' End IF
        End If
        ' Calculate Bill = KiloWatts * Rate
        chargeDecimal = kiloWattsInteger * rateDecimal

        ' Return Charge 
        Return chargeDecimal

        ' End Electric Charge
    End Function
    ' Begin Discount Rate () As a Decimal Number
    Private Function discountRate() As Decimal

        ' **************************************************************************
        ' *  Procedure    : Discount Rate                                          *
        ' *  Description  : This value returning procedure calculates the total    *
        ' *                 discount rate.  The total discount rate is determined  *
        ' *                 from the discount check boxes.  The total discount     *
        ' *                 rate is the sum of the individual discount rates.  It  *
        ' *                 returns the total discount rate as decimal value when  *
        ' *                 completed.                                             *
        ' **************************************************************************

        ' Define Variables:Total Rate Discount
        Dim totalRateDiscountRate As Decimal

        ' Set Total Discount Rate to 0

        ' IF Medical Discount CheckBox is Checked
        If medicalDiscountCheckBox.Checked Then
            ' Add Medical Discount Constant to Total Rate Discount
            totalRateDiscountRate += MEDICAL_DISCOUNT_Decimal
            ' End IF
        End If

        ' IF Senior Discount CheckBox is Checked
        If seniorDiscountCheckBox.Checked Then
            'Add Senior Discount Constant to Total Rate Discount
            totalRateDiscountRate += SENIOR_DISCOUNT_Decimal
            ' End IF
        End If

        ' IF Income Discount CheckBox is Checked
        If incomeDiscountCheckBox.Checked Then
            ' Add Income Discount Constant to Total Rate Discount
            totalRateDiscountRate += INCOME_DISCOUNT_Decimal
            ' End IF
        End If

        ' Return Total Discount Rate 
        Return totalRateDiscountRate

        ' End Discount Rate
    End Function
End Class

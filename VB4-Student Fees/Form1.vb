' ******************************************************************************
' *                                Student Fees                                *
' ******************************************************************************
' *                                                                            *
' *  Programmer   : Jenny Nguyen                                               *
' *  Chapter      : VB4                                                        *
' *  Assignment   : Example                                                    *
' *  Form Name    : Student Fees                                               *
' *  Date Created : 12/6/2015                                                  *
' *  Description  : This form calculates a student's fee.                      *
' *                                                                            *
' ******************************************************************************

' Set Define Variables Option On
Option Explicit On

' Set No Automatic Data Conversion On
Option Strict On

Public Class studentFeesForm

    ' Set Enrollment Rate constant to $20
    Const ENROLLMENT_RATE_Integer As Integer = 20

    ' Set Non Resident Rate constant to $162
    Const NON_RESIDENT_RATE_Integer As Integer = 162

    ' Set Non US Citizen Rate constant to $182
    Const NON_US_CITIZEN_RATE_Integer As Integer = 182

    ' Set Health Fee constant to $14
    Const HEALTH_FEE_Integer As Integer = 14

    ' Set ASB Card Fee constant to $7
    Const ASB_CARD_FEE_Integer As Integer = 7

    ' Set Parking Fee constant to $35
    Const PARKING_FEE_Integer As Integer = 35

    ' Set Photo ID Fee constant to $2.50
    Const PHOTO_ID_FEE_Decimal As Decimal = 2.5D

    ' Set Minimum Units to .5
    Const MINIMUM_UNITS_Decimal As Decimal = 0.5D

    ' Set Maximum Units to 19
    Const MAXIMUM_UNITS_Integer As Integer = 19

    Private Sub newStudentButton_Click(sender As Object, e As EventArgs) Handles newStudentButton.Click

        ' **************************************************************************
        ' *  Procedure    : New Student-Click                                      *
        ' *  Description  : The New Student button clears the Units textbox and    *
        ' *                 Fee label box.  It turns the Resident radiobutton On   *
        ' *                 and turns Off the ASB Card, Parking, and Photo ID Fee  *
        ' *                 checkboxes.  Finally, it sets the focus to the Units   *
        ' *                 textbox.                                               *
        ' **************************************************************************

        ' Define Variables: None

        ' Clear Units TextBox
        unitsTextBox.Text = ""

        ' Clear Fee Label
        feeLabel.Text = ""

        ' Set Resident RadioButton On
        residentRadioButton.Checked = True

        ' Clear ASB Card Fee CheckBox
        asbCardFeeCheckBox.Checked = False

        ' Clear Parking Fee CheckBox
        parkingFeeCheckBox.Checked = False

        ' Clear Photo ID Fee CheckBox
        photoIdFeeCheckBox.Checked = False

        ' Set the Focus to Units TextBox
        unitsTextBox.Focus()

    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        ' **************************************************************************
        ' *  Procedure    : Calculate-Click                                        *
        ' *  Description  : The calculate button calls the Check Units, Enrollment *
        ' *                 Fee, and Optional Fees procedures.  When the Calculate *
        ' *                 button is clicked a student fee is calculated. It      *
        ' *                 calls the Check Units module to determine if the units *
        ' *                 are within a specified minimum and maximum range.  If  *
        ' *                 the units are valid then a student fee is calculated   *
        ' *                 and displayed.  The student fee is calculated by       *
        ' *                 adding the Enrollment Fee, Health Fee, and any         *
        ' *                 Optioinal Fees.  If the units are invalid an error     *
        ' *                 message is displayed and the focus returned to the     *
        ' *                 units textbox.                                         *
        ' **************************************************************************

        ' Define Variables: Units, Units Are Valid, Fee
        Dim unitsDecimal, feeDecimal As Decimal
        Dim unitsAreValidBoolean As Boolean

        ' Call Check Units (Out: Units, Units Are Valid)
        CheckUnits(unitsDecimal, unitsAreValidBoolean)

        ' IF Units Are Valid = True
        If unitsAreValidBoolean Then
            ' Calculate Fee = Enrollment Fee (In: Units) + Optional Fees ( )+ Health Fee constant
            feeDecimal = EnrollmentFee(unitsDecimal) + OptionalFees() + HEALTH_FEE_Integer

            ' Display Fee
            feeLabel.Text = feeDecimal.ToString("C2")
        Else

            ' Display Error Message
            MessageBox.Show("Units must be a number from " & _
                            MINIMUM_UNITS_Decimal & " to " & _
                            MAXIMUM_UNITS_Integer & " !", "Units Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Set the Focus to Units TextBox
            unitsTextBox.Focus()
            ' End IF
        End If
       

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
                                                    "Exit Student Fees", _
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
    ' Begin Check Units ( Out: Units, Units Are Valid )
    Private Sub CheckUnits(ByRef unitsDecimal As Decimal, _
                            ByRef unitsAreValidBoolean As Boolean)

        ' **************************************************************************
        ' *  Procedure    : Check Units                                            *
        ' *  Description  : This procedure validates the units.  The units must be *
        ' *                 numeric and a value within the minimum to maximum      *
        ' *                 units range.  A value of true is returned if the units *
        ' *                 are valid; false if the units are invalid.  It returns *
        ' *                 the Units and Units Are Valid as outputer parameters   *
        ' *                 when completed.                                        *
        ' **************************************************************************
        ' Define Variables: None

        ' Get Units from Form 
        'IF Units >= Minimum Units constant AND Units <= Maximum Units constant
        If Decimal.TryParse(unitsTextBox.Text, unitsDecimal) = True And _
            unitsDecimal >= MINIMUM_UNITS_Decimal And _
            unitsDecimal <= MAXIMUM_UNITS_Integer Then

            ' Set Units Are Valid to True
            unitsAreValidBoolean = True

        Else

            ' Set Units are Valid to False
            unitsAreValidBoolean = False
            ' End IF

        End If

    End Sub
    ' Begin Enrollment Fee ( In: Units ) As a Decimal Number
    Private Function EnrollmentFee(ByVal unitsDecimal As Decimal) As Decimal
        ' **************************************************************************
        ' *  Procedure    : Enrollment Fee                                         *
        ' *  Description  : This value returning procedure calculates the          *
        ' *                 enrollment fee.  The enrollment fee is calculated by   *
        ' *                 multiplying the units times the appropriate rate as    *
        ' *                 determined by the residency options.  All students pay *
        ' *                 the enrollment rate.  Non-Resdients of California and  *
        ' *                 Non-US Citizens pay their respective rate plus the     *
        ' *                 enrollment fee.  It receives the units as an input     *
        ' *                 parameter and returns the fee as a decimal value when  *
        ' *                 completed.                                             *
        ' **************************************************************************

        ' Define Variables: Rate, Fee
        Dim rateInteger As Integer
        Dim feeDecimal As Decimal

        ' IF Resident RadioButton is Selected
        If residentRadioButton.Checked Then

            ' Rate = Enrollment Rate constant
            rateInteger = ENROLLMENT_RATE_Integer

            ' Else IF Non-Resident RadioButton is Selected
        ElseIf nonResidentRadioButton.Checked Then

            ' Rate = Non-Resident Rate constant + Enrollment Rate constant
            rateInteger = NON_RESIDENT_RATE_Integer + ENROLLMENT_RATE_Integer

        Else
            ' Rate = Non-US Citizen Rate Constant + Enrollment Rate constant
            rateInteger = NON_US_CITIZEN_RATE_Integer + ENROLLMENT_RATE_Integer

            ' End IF
        End If
        ' Calculate Fee = Units times Rate
        feeDecimal = unitsDecimal * rateInteger

        ' Return Fee 
        Return feeDecimal

    End Function

    ' Begin Optional Fees () As a Decimal Number
    Private Function OptionalFees() As Decimal
        ' **************************************************************************
        ' *  Procedure    : Optional Fees                                          *
        ' *  Description  : This value returning procedure calculates the optional *
        ' *                 fees total.  The optional fees are determined from the *
        ' *                 fee check boxes.  These fees are defined as form       *
        ' *                 constants.  It returns the total optional fees as a    *
        ' *                 decimal value when completed.                          *
        ' **************************************************************************

        ' Define Variables: Optional Fees Total
        Dim optionalFeesTotalDecimal As Decimal

        ' Set the Optional Fees Total to 0

        ' IF ASB Card Fee CheckBox is Checked
        If asbCardFeeCheckBox.Checked Then

            ' Add ASB Card Fee constant to Optional Fees Total
            optionalFeesTotalDecimal += ASB_CARD_FEE_Integer
            ' End IF
        End If

        ' IF Parking Fee CheckBox is Checked
        If parkingFeeCheckBox.Checked Then

            ' Add Parking Fee constant to Optional Fees Total
            optionalFeesTotalDecimal += PARKING_FEE_Integer
            ' End IF
        End If


        ' IF Photo ID Fee CheckBox is Checked
        If photoIdFeeCheckBox.Checked Then
            ' Add Photo ID Fee constant to Optional Fees Total
            optionalFeesTotalDecimal += PHOTO_ID_FEE_Decimal
            ' End IF
        End If

        ' Return Optional Fees Total 
        Return optionalFeesTotalDecimal

    End Function
End Class

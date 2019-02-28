' ******************************************************************************
' *                            Electric Calculator                             *
' ******************************************************************************
' *                                                                            *
' *  Programmer   : Jenny Nguyen                                               *
' *  Chapter      : VB1                                                        *
' *  Assignment   : Assign.                                                    *
' *  Form Name    : Electric Calculator                                        *
' *  Date Created : 11/10/2015                                                 *
' *  Description  : This form calculates the kilowatts, rates, and total       *
' *                 amounts for the customer.                                  *
' *                                                                            *
' ******************************************************************************

' Set Define Variables Option On
Option Explicit On

' Set No Automatic Data Conversion On
Option Strict On

Public Class calculatorForm

    ' Set High KiloWatts constant = 500
    Const HIGH_KILOWATTS_Integer As Integer = 500

    ' Set Residential Rate constant = .13
    Const RESIDENTIAL_RATE_Decimal As Decimal = 0.13D

    ' Set Business Rate constant = .10
    Const BUSINESS_RATE_Decimal As Decimal = 0.1D

    ' Set Minimum Rate constant = .05
    Const MINIMUM_RATE_Decimal As Decimal = 0.05D

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ' **************************************************************************
        ' *  Procedure    : Clear-Click                                            *
        ' *  Description  : The Clear button clears the Prior, Current, KiloWatts, *
        ' *                 Rate, and Total information. It sets the Code to       *
        ' *                 "Resident", makes the Lightning Bolt image invisible,  *
        ' *                 and sets the focus to the prior field.                 *
        ' **************************************************************************

        ' Define Variables: None

        ' Set Code ComboBox to "Resident"
        codeComboBox.Text = "Resident"

        ' Clear Prior Textbox
        priorTextBox.Text = ""

        ' Clear Current Textbox
        currentTextBox.Text = ""

        ' Clear KiloWatts Label
        kiloWattsLabel.Text = ""

        ' Clear Total Label
        totalLabel.Text = ""

        ' Make Lightning Bolt Invisible
        lighteningPictureBox.Visible = False

        ' Set the Focus to the Prior TextBox
        priorTextBox.Focus()

    End Sub
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        ' **************************************************************************
        ' *  Procedure    : Calculate-Click                                        *
        ' *  Description  : The Calculate button determines, calculates, and       *
        ' *                 displays the KiloWatts, Rate, and Total for the        *
        ' *                 customer.  It displays a lightning bolt image if the   *
        ' *                 KiloWatts is greater than or equal to the constant     *
        ' *                 High KiloWatts.                                        *
        ' **************************************************************************

        ' Define Variables: KiloWatts, Code, Rate, Total Due, Prior, Current
        Dim kiloWattsInteger, priorInteger, currentInteger As Integer
        Dim rateDecimal, totalDueDecimal As Decimal
        Dim codeString As String

        ' Get Prior from Form
        priorInteger = Integer.Parse(priorTextBox.Text)

        ' Get Current from Form
        currentInteger = Integer.Parse(currentTextBox.Text)

        ' Get Code From Form
        codeString = codeComboBox.Text

        ' IF Code = "Resident"
        If codeString = "Resident" Then

            ' Rate = Residential Rate constant
            rateDecimal = RESIDENTIAL_RATE_Decimal

            ' Else IF Code = "Business"
        ElseIf codeString = "Business" Then

            ' Rate = Business Rate constant
            rateDecimal = BUSINESS_RATE_Decimal

            ' Else IF Code = "Income" or "Senior"
        ElseIf codeString = "Income" Or codeString = "Senior" Then

            ' Rate = Minimum Rate constant
            rateDecimal = MINIMUM_RATE_Decimal

            ' Else
        Else

            ' Rate = 0
            rateDecimal = 0
            ' End IF
        End If


        ' Calculate KiloWatts = Current - Prior
        kiloWattsInteger = currentInteger - priorInteger

        ' Calculate Total Due = KiloWatts * Rate
        totalDueDecimal = kiloWattsInteger * rateDecimal

        ' Display KiloWatts
        kiloWattsLabel.Text = kiloWattsInteger.ToString()

        ' Display Rate
        rateLabel.Text = rateDecimal.ToString("N2")

        ' Display Total
        totalLabel.Text = totalDueDecimal.ToString("C2")

        ' IF KiloWatts >= High KiloWatts Constant
        If kiloWattsInteger >= HIGH_KILOWATTS_Integer Then

            ' Display Lightning Bolt Image
            lighteningPictureBox.Visible = True
            ' Else
        Else
            ' Hide Lightning Bolt Image
            lighteningPictureBox.Visible = False

            ' End IF
        End If
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click

        ' **************************************************************************
        ' *  Procedure    : Exit-Click                                             *
        ' *  Description  : When the Exit button is clicked, the form closes.      *
        ' **************************************************************************

        ' Close the Form
        Me.Close()

    End Sub

End Class






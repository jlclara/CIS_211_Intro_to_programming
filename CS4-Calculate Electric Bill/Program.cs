// *****************************************************************************
// *                        CS4-Calculate Electric Bill                        *
// *****************************************************************************
// *                                                                           *
// *  Programmer   : Jenny Nguyen                                              *
// *  Chapter      : CS4                                                       *
// *  Assignment   : #5                                                        *
// *  Class Name   : CS4-Calculate Electric Bill                               *
// *  Date Created : 9/24/2015                                                 *
// *  Description  : This class calculates a customer's electric bill.         *
// *                                                                           *
// *****************************************************************************

// Using System Namespace
using System;

// Begin CS4-Calculate Electric Bill Class
class CS4_Calculate_Electric_Bill
{

    // *************************************************************************
    // *  Method       : Main                                                  *
    // *  Description  : This method calls Input KiloWatt Data and Electric    *
    // *                 Bill methods.  It displays an end of program message  *
    // *                 when completed.                                       *
    // *************************************************************************

    // Begin Main ()
    static void Main()
    {
        // Define Variables: KiloWatt, Rate
        int kiloWattInteger;
        decimal rateDecimal;

        // Display Title
        Console.WriteLine("****  Calculate Electric Bill  ****");

        // Display Blank Line
        Console.WriteLine();

        // Call Input KiloWatt Data ( Out: KiloWatt, Rate )
        InputKiloWattData(out kiloWattInteger, out rateDecimal);

        // Display Blank Line
        Console.WriteLine();

        // Display Electric Bill ( In: KiloWatt, Rate)
        Console.WriteLine("Your Electric Bill is " + ElectricBill(kiloWattInteger, rateDecimal));

        // Display Blank Line
        Console.WriteLine();

        // Display End of Program Message
        Console.WriteLine("End of Program!");

        // Display Blank Line
        Console.WriteLine();

        // Display Press any key Prompt
        Console.Write("Press any key to continue . . .");

        // Input Press any key 
        Console.ReadKey();

    }// End Main

    // *************************************************************************
    // *  Method       : Input KiloWatt Data                                   *
    // *  Description  : This method inputs the kilowatts and rate per         *
    // *                 kilowatt from the keyboard.  It returns the kilowatts *
    // *                 and rate as output parameters when completed.  Note:  *
    // *                 Assume that the kilowatts is a whole number.          *
    // *************************************************************************

    // Begin Input KiloWatt Data ( Out: KiloWatt, Rate )
    static void InputKiloWattData(out int kiloWattInteger, out decimal rateDecimal)
    {
        // Define Variables: None

        // Display KiloWatt  Prompt
        Console.Write("Enter Number of KiloWatts : ");
      
        // Input KiloWatt
        int.TryParse(Console.ReadLine(), out kiloWattInteger);

        // Display Rate Prompt
        Console.Write("Enter Rate Per KiloWatt   : ");

        // Input Rate
        decimal.TryParse(Console.ReadLine(), out rateDecimal);

    }// End Input KiloWatt Data

    // *************************************************************************
    // *  Method       : Electric Bill                                         *
    // *  Description  : This value returning method calculates an electric    *
    // *                 bill.  It receives the kilowatts and rate as input    *
    // *                 parameters.  The bill is calculated by multriplying   *
    // *                 the kilowatts times the rate. It returns the          *
    // *                 formatted electric bill as a string value in currency *
    // *                 format when completed                                 *
    // *************************************************************************

    // Begin Electric Bill ( In: KiloWatts, Rate ) As a String
    static string ElectricBill(int kiloWattsInteger, decimal rateDecimal)
    {
        // Define Variables: Electric Bill, Formatted Electric Bill
        decimal electricBillDecimal;
        string formattedElectricBillString;

        // Calculate Electric Bill = KiloWatts * Rate
        electricBillDecimal = kiloWattsInteger * rateDecimal;

        // Create Formatted Fee
        formattedElectricBillString = electricBillDecimal.ToString("C2");

        // Return fomrattedElectricBill 
        return formattedElectricBillString;

    }// End Electric Bill


}// End CS4-Calculate Electric Bill Class


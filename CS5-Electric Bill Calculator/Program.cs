// *****************************************************************************
// *                       CS5-Electric Bill Calculator                        *
// *****************************************************************************
// *                                                                           *
// *  Programmer   : Jenny Nguyen                                              *
// *  Chapter      : CS5                                                       *
// *  Assignment   : Lab #6                                                    *
// *  Class Name   : CS5-Electric Bill Calculator                              *
// *  Date Created : 10/5/2015                                                 *
// *  Description  : This class determines a customer's electric bill.         *
// *                                                                           *
// *****************************************************************************

// Using System Namespace
using System;
// Begin CS5-Electric Bill Calculator Class
class CS5_Electric_Bill_Calculator
{
    // Residential Rate = .20
    const decimal RESIDENTIAL_RATE_Decimal = 0.20M;

    // Commercial Rate = .15
    const decimal COMMERCIAL_RATE_Decimal = 0.15M;

    // Agricultural Rate = .10
    const decimal AGRICULTURAL_RATE_Decimal = 0.10M;

    // Minimum KiloWatts  = 1
    const int MINIMUM_KILOWATTS_Integer = 1;

    // Maximum KiloWatts = 10000
    const int MAXIMUM_KILOWATTS_Integer = 10000;


    // *************************************************************************
    // *  Method       : Main                                                  *
    // *  Description  : This method calls the Input Electric Data and Display *
    // *                 Information methods.  It displays an end of program   *
    // *                 message when completed.                               *
    // *************************************************************************

    // Begin Main ()
    static void Main()
    {
        // Define Variables: KiloWatts, Electric Rate Code, Answer
        int kiloWattsInteger;
        string electricRateCodeString, answerString;

        // Do 
        do
        {
            // Clear Screen
            Console.Clear();

            // Display Three Title Lines
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("****  Electric Bill Calculator Program  ****");
            Console.WriteLine("--------------------------------------------");

            // Display Blank Line
            Console.WriteLine();

            // Call Input Electric Data ( Out: KiloWatts, Electric Rate Code)
            InputElectricData(out kiloWattsInteger, out electricRateCodeString);

            // Display Blank Line
            Console.WriteLine();

            // Display Call Display Information
            DisplayInformation(kiloWattsInteger, electricRateCodeString);

            // Display Blank Line
            Console.WriteLine();

            // Do 
            do
            {
                // Display Enter More Electric Bill Data Prompt
                Console.Write("Calculate another Electric Bill (Y/N) ? ");

                // Input Answer
                answerString = Console.ReadLine().ToUpper();

                // While (Answer Not = "Y" And Answer Not = "N")
            } while (answerString != "Y" && answerString != "N");

            // While Answer = "Y"
        } while (answerString == "Y");

        // Clear Screen
        Console.Clear();

        // Display End of Program Message
        Console.WriteLine("End of Electric Bill Calculator!");


        // Display Blank Line
        Console.WriteLine();

        // Display Press any key Prompt
        Console.Write("Press any key to continue . .  .");

        // Input Press Any Key
        Console.ReadKey();

    }// End Main

    // *************************************************************************
    // *  Method       : Input Electric Data                                   *
    // *  Description  : This method inputs the KiloWatts and Electric Rate    *
    // *                 code data from the keyboard.   It must validate the   *
    // *                 input data that it is within the specified limits.    *
    // *                 It returns the KiloWatts and Electric Rate code as    *
    // *                 output parameters when completed.                     *
    // *************************************************************************

    // Begin Input Electric Data ( Out: KiloWatts, Electric Rate Code )
    static void InputElectricData(out int kiloWattsInteger,
                                    out string electricRateCodeString)
    {
        // Define Variables: None
        // Display KiloWattsPrompt
        Console.Write("Enter KiloWatts (" + MINIMUM_KILOWATTS_Integer + " to "
                           + MAXIMUM_KILOWATTS_Integer + ") : ");

        // Input KiloWatts
        int.TryParse(Console.ReadLine(), out kiloWattsInteger);

        // Do  While ( KiloWatts < Minimum KiloWatts constant Or KiloWatts > Maximum KiloWatts constant )
        while (kiloWattsInteger < MINIMUM_KILOWATTS_Integer || 
                kiloWattsInteger > MAXIMUM_KILOWATTS_Integer)
        {
            // Display KiloWattsError Message
            Console.Write("KiloWatts Error - Try Again  : ");

            // Input Another KiloWatts
            int.TryParse(Console.ReadLine(), out kiloWattsInteger);

        }// End Do 
        
        // Display Blank Line
        Console.WriteLine();

        // Display Electric Rate Codes (4 lines)
        Console.WriteLine("Electric Rate Codes:");
        Console.WriteLine("R - Residential Rate");
        Console.WriteLine("C - Commercial Rate");
        Console.WriteLine("A - Agricultural Rate");

        // Display Blank Line
        Console.WriteLine();

        // Display Electric Rate Code Prompt
        Console.Write("Enter Rate Code (R,C,A)      : ");
            
        // Input Electric Rate Code
        electricRateCodeString = Console.ReadLine().ToUpper();

        // Do  While ( Electric Rate Code != "R" && Electric Rate Code != "C" && Electric Rate Code != "A" )
        while( electricRateCodeString != "R" && electricRateCodeString != "C" 
                && electricRateCodeString != "A")
        {
            // Display Electric Rate Code Error Message
            Console.Write("Rate Code Error - Try Again  : ");

            // Input Another Electric Rate Code
            electricRateCodeString = Console.ReadLine().ToUpper();
        }// End Do 

    }// End Input Electric Data

    // *************************************************************************
    // *  Method       : Display Information                                   *
    // *  Description  : This method calculates the bill amount and displays   *
    // *                 the customer's kilowatts, rate, and bill amount.  It  *
    // *                 receives the kilowatts, and rate code as input        *
    // *                 parameters.  The bill amount is calculated by         *
    // *                 multiplying the kilowatts times the electric rate.    *
    // *                 The electric rate is obtained by calling the Electric *
    // *                 Rate method.                                          *
    // *************************************************************************

    // Begin Display Information ( In: KiloWatts, Rate Code )
    static void DisplayInformation(int kiloWattsInteger,
                                    string rateCodeString)
    {

        // Define Variables: Bill
        decimal billDecimal;

        // Display Kilowatt Usage
        Console.WriteLine("Your KiloWatt Usage is " + kiloWattsInteger);

        // Display Call Get Electric Rate (In: Rate Code)
        Console.WriteLine("Your Rate Per KiloWatt is " +
                           GetElectricRate(rateCodeString).ToString("C2"));

        // Display Blank Line
        Console.WriteLine();

        // Calculate Bill = KiloWatts times Electric Rate
        billDecimal = kiloWattsInteger * GetElectricRate(rateCodeString);

        // Display Bill 
        Console.WriteLine("Your Electric Bill is " + 
                            billDecimal.ToString("C2"));

    }// End Display Information

    // *************************************************************************
    // *  Method       : Get Electric Rate                                     *
    // *  Description  : This value returning method determines a rate based   *
    // *                 upon the rate code.  The rate is determined: "R" uses *
    // *                 Residential Rate, "C" uses Commericial Rate, and "A"  *
    // *                 uses Agricultural Rate.  These rates are defined as   *
    // *                 class constants. It receives the rate code as an      *
    // *                 input parameter and returns the rate as a decimal     *
    // *                 value when completed.                                 *
    // *************************************************************************

    // Begin Get Electric Rate ( In: Rate Code ) As a Decimal Number
    static decimal GetElectricRate(string electricRateCodeString)
    {
        // Define Variables: Electric Rate
        decimal electricRateDecimal;

        // IF Rate Code = "R"
        if (electricRateCodeString == "R")
            // Electric Rate = Residential Rate Constant
            electricRateDecimal = RESIDENTIAL_RATE_Decimal;

        // Else IF Rate Code "C"
        else if (electricRateCodeString == "C")
            // Electric Rate = Commerical Rate Constant
            electricRateDecimal = COMMERCIAL_RATE_Decimal;

        // Else
        else
            // Electric Rate = Agricultural Rate Constant
            electricRateDecimal = AGRICULTURAL_RATE_Decimal;
        // End IF

        // Return Electric Rate 
        return electricRateDecimal;

    }// End Get Electric Rate


}// End CS5-Electric Bill Calculator Class


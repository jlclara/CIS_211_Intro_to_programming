// *****************************************************************************
// *                             CS3-Electric Bill                             *
// *****************************************************************************
// *                                                                           *
// *  Programmer   : Jenny Nguyen                                              *
// *  Chapter      : CS3                                                       *
// *  Assignment   : Assign.                                                   *
// *  Class Name   : CS3-Electric Bill                                         *
// *  Date Created : 9/10/2015                                                 *
// *  Description  : This class calculates an electric bill.                   *
// *                                                                           *
// *****************************************************************************

// Using System Namespace
using System;
// Begin CS3-Electric Bill Class
class CS3_Electric_Bill
{


    // *************************************************************************
    // *  Method       : Main                                                  *
    // *  Description  : This method prompts the operator to enter the         *
    // *                 kilowatts usage and electric rate from the keyboard.  *
    // *                 It then calculates and displays the electric bill     *
    // *                 amount.                                               *
    // *************************************************************************

    // Begin Main ()
    static void Main()
    {
        // Define Variables: KiloWatts Usage, Electric Rate, Electric Bill
        decimal kilowattsDecimal, electricRate, electricBill;

        // Display Title
        Console.WriteLine("Calculates Electric Bill");
        
        // Display Blank Line
        Console.WriteLine();

        // Display KiloWatts Usage Prompt
        Console.Write("Enter KiloWatts Usage : ");

        // Input KiloWatts Usage
        kilowattsDecimal = decimal.Parse(Console.ReadLine());

        // Display Electric Rate Prompt
        Console.Write("Enter Electric Rate   : ");

        // Input Electric Rate
        electricRate = decimal.Parse(Console.ReadLine());

        // Calculate Electric Bill: Electric Bill = KiloWatts Usage * Electric Rate
        electricBill = kilowattsDecimal * electricRate;

        // Display Blank Line
        Console.WriteLine();

        // Display Electric Bill 
        Console.WriteLine("Your Electric Bill is " + electricBill.ToString("C2"));

        // Display Blank Line
        Console.WriteLine();

        // Display Press Any Key Prompt
        Console.Write("Press any key to continue . . .");

        // Input Press Any Key
        Console.ReadKey();
    }
    // End Main

}
// End CS3-Electric Bill Class


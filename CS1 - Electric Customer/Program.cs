// *****************************************************************************
// *                          CS1 - Electric Customer                          *
// *****************************************************************************
// *                                                                           *
// *  Programmer   : Jenny Nguyen                                              *
// *  Chapter      : CS1                                                       *
// *  Assignment   : Assign.                                                   *
// *  Class Name   : CS1 - Electric Customer                                   *
// *  Date Created : 9/3/2015                                                  *
// *  Description  : This class displays customer information. The operator is *
// *                 prompted to enter the customer number, last name, and     *
// *                 first name from the keyboard. The class displays the      *
// *                 customer number and name.                                 *
// *                                                                           *
// *****************************************************************************

// Using Namepsace
using System;
// Begin CS1 - Electric Customer Class
class CS1_Electric_Customer
{


    // *************************************************************************
    // *  Method       : Main                                                  *
    // *  Description  : This method prompts the operator to enter the         *
    // *                 customer number, last name, and first name from the   *
    // *                 keyboard. It then displays the customer number and    *
    // *                 name                                                  *
    // *************************************************************************

    // Begin Main ()
    static void Main()
    {

        // Define Variables: Number, Last Name, First Name
        string number, lastNameString, firstNameString;

        // Display Title
        // Display Blank Line
        Console.WriteLine("Electric Customer Information\n");

        // Display Number Prompt
        Console.Write("Enter Number     : ");
        
        // Input Number
        number = Console.ReadLine();

        // Display Last Name Prompt
        Console.Write("Enter Last Name  : ");

        // Input Last Name
        lastNameString = Console.ReadLine();

        // Display First Name Prompt
        Console.Write("Enter First Name : ");

        // Input First Name
        firstNameString = Console.ReadLine();

        // Display Blank Line
        Console.WriteLine();

        // Display Number
        Console.WriteLine(number);

        // Display First and Last Name
        Console.WriteLine(firstNameString + " " + lastNameString);

        // Display Blank Line
        Console.WriteLine();

        // Display Press any key Prompt
        Console.Write("Press any key to continue . . .");

        // Input Press Any Key
        Console.ReadKey();

    }// End Main


}// End CS1 - Electric Customer Class


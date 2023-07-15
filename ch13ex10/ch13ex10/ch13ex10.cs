using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*************************************************************************/
/* Program Name:     Ch13Ex10.cs                                         */
/* Date:             05/01/2022                                      	 */
/* Programmer:       Miranda Morris                                  	 */
/* Class:            CSCI 234                                            */
/*                                                                       */
/* Program Description: The purpose of this program is to show that we   */
/* understand format exceptions by creating an app that uses miles driven*/
/* and gallons used that are inputted to calculate miles per gallon.     */
/*                                                                       */
/* Input: miles driven & gallons used								     */
/*                                                                       */
/* Output: miles per gallon				                                 */
/*                                                                       */
/* Givens: miles per gallon = miles driven / gallons used 				 */
/*                                                                       */
/* Testing Data:                                                         */
/*                                                                       */
/*List the Testing Input Data:                                           */
/* 150,                                                                  */
/* ab,                                                                   */
/* add the line: Convert.ToChar(milesDriven); then input 2               */
/* 15 & 30,                                                              */
/*                                                                       */
/*List the Testing Output Data:                                          */
/* There are no cars that can drive that many miles!                     */
/* Index was outside the bounds of the array,                            */
/* You cannot enter that value                                           */
/* Input string was not in a correct format,                             */
/* You are not allowed to do that                                        */
/* Invalid cast from 'Double' to 'Char',                                 */
/* Mileage is 0.5 miles per gallon,                                      */                                                                       
/*************************************************************************/

namespace ch13ex10
{
    class ch13ex10
    {
        static void Main(string[] args)
        {
            double milesDriven = 0;
            double gallonsUsed = 0;
            try
            {
                Console.WriteLine("Please input the number of miles driven:");
                milesDriven = Convert.ToDouble(Console.ReadLine());

                if (milesDriven > 100)
                    throw new IndexOutOfRangeException();

                 //Convert.ToChar(milesDriven);

                Console.WriteLine("Please input the number of gallons used:");
                gallonsUsed = Convert.ToDouble(Console.ReadLine());

                double milesPerGallon = milesDriven / gallonsUsed;
                Console.WriteLine("Mileage is {0} miles per gallon", milesPerGallon);
            }
            catch(FormatException e )
            {
                Console.WriteLine("You cannot enter that value\n{0}", e.Message);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("There are no cars that can drive that many miles!\n{0}", e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("You are not allowed to do that\n{0}", e.Message);
            }

            Console.ReadKey();
        }

    }
}

using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Library.Game.Loop();
            }
            catch (FormatException InputError)
            {
                Console.WriteLine(InputError);
            }
            catch (OverflowException InputError)
            {
                Console.WriteLine(InputError);
            }
            finally { }
            Console.ReadLine();
        }
    }
}

 /*Introduction > 
 *      TravelTo: 
 *          C > 
 *              Y = Console stops -- GOOD 
 *              N = Back to 'TravelTo' -- GOOD
 *                  
 *          V, E, L, M, A > 
 *              L = 'TravelTo' -- GOOD
 *              T = Merchant Transaction > 'TravelTo' -- GOOD
 *          L >
 *              Acquired > VictoryScreen > Merchant bidding farewell > CockpitScreen [PATCHED but not fixed entirely; needs to be prettier]
 *              Denied > still prints "you have received __" 'TravelTo' [PATCHED, but not fixed entirely; needs to be prettier]
 *
 * Migrate everything from Console-dependent to Console-INDEPENDENT
 *
 * Need to implement an actual Library, this placeholder folder is NOT a classLibrary - it's just a folder
 * 
 * Get rid of 'static' modifiers
 *
 * [PATCH] Enum / List statements for the option menu's regarding Planets which SHOULD be objects but aren't - in the ideal sense of the word
 *
 * Needs mroe dialogue, and a smoother trade interface - currently it's abrupt and ugly
 *
 * Complicate the economy a little more where different planets require different resources for trade - as opposed to the merchant just giving you stuff
 */

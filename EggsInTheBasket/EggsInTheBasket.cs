using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggsInTheBasket
{
    class EggsInTheBasket
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The minimum number of Eggs in the basket given the situation is");
            for (int numberOfEggs = 1; ; numberOfEggs++) {
                if ((numberOfEggs % 1==0) && (numberOfEggs % 2 == 1) && (numberOfEggs % 3==0)  && (numberOfEggs % 4 == 1) && ((numberOfEggs+1) % 5 == 0) && (numberOfEggs % 6 == 3) && (numberOfEggs % 7 ==0) && (numberOfEggs % 8 == 1) && (numberOfEggs % 9==0)) {
                    Console.WriteLine(numberOfEggs);
                    break;
                }
                
            }
        }
    }
}

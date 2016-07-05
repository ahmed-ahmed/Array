using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_test
{
    class AhmedList
    {
        public int[] myArray = new int[1];
        int i;





        //ADD
        public void add(int x)
        {
            int[] y = new int[myArray.Length + 1];

            for (i = 0; i < myArray.Length; i++)
            {
                y[i] = myArray[i];
            }
            y[i] = x;


            // el mafrod hna a5ly myArray length = y length w b3deen el for deh bs msh 3arf ezay
            for (i = 0; i < y.Length; i++)
            {
                myArray[i] = y[i];
            }
        }



        // Get



        // Size


        


    }
}

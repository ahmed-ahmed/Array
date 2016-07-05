using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_test
{
    class AhmedList
    {
        private int[] myArray = new int[1];             //you don't want the user of the class to access the array
        //int i;                                          //this is a very local variable
        //ADD
        public void add(int x)
        {
            // create new array
            int[] y = new int[myArray.Length + 1];

            // copy the array
            for (int i = 0; i < myArray.Length; i++)
            {
                y[i] = myArray[i];
            }
            // add the element 
            y[i] = x;

            //set my array to the "y"
            myArray = y; 
            // el mafrod hna a5ly myArray length = y length w b3deen el for deh bs msh 3arf ezay
            //for (int i = 0; i < y.Length; i++)
            //{
            //    myArray[i] = y[i];
            //}
        }



        // Get



        // Size


        


    }
}

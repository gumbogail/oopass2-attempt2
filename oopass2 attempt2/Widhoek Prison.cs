using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopass2_attempt2
{
    internal class Widhoek_Prison

    {
        Inmates[] inmates;
        Wardens[] wardens;
        int NumberOfInmates; 
        int NumberOfWardens; 
        Widhoek_Prison()
        {
            inmates = new Inmates[50];
            wardens = new Wardens[20];
            NumberOfInmates = 0;
            NumberOfWardens = 0;
        }
        public void addNewInmates(Inmates newinmate)
        {
            if (NumberOfInmates< inmates.Length)
            {
                inmates[NumberOfInmates] = newinmate;

            }
        }
        public void addNewWarden(Wardens newwardens)
        {
            if(NumberOfWardens< wardens.Length)
            {
                
                    wardens[NumberOfWardens] = newwardens;
        }
              }
           
    }
}

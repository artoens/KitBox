﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_kitbox
{
    class Output
    {
        public Output()
        {


        }

        public void PrettyOrder(Order order)
        {
            foreach (Product product in order.GenerateOrder())
            {
                //Display the list onto the interface
            }
        }
        public void MakeBill(Order order)
        {
            DateTime now = DateTime.Now;
            string line = null;
            string path = (@"../../../Bill of" + now + ".txt");
            List<string> lines = new List<string>
                {
                    "Bill made on the" + now + "for" + "client",
                    " "
                };
            foreach (Product product in order.GenerateOrder())
            {

            
            }
        }
        public void MakeList(Order order)
        {
            DateTime now = DateTime.Now;
            string line = null;
            string path = (@"../../../List of" + now + ".txt");
            List<string> lines = new List<string>
                {
                    "List of the" + now + "for" + "client",
                    " "
                };
            foreach (Product item in order.GenerateOrder())
            {
                order.item
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsMVVM.Model
{
    public class Customer
    {
        private string customerName;

        public string CustomerName { get => customerName; set => customerName = value; }
        

        private int amount;
        public int Amount { get => amount; set => amount = value; }
       

        private bool marrid;

        public bool Marrid { get => marrid; set => marrid = value; }

        private double tax;

        public double Tax { get => tax; set => tax = value; }


        public void CalculateTax()
        {
            if (amount > 2000)
            {
                tax = 20;
            }
            else if (amount > 1000)
            {
                tax = 10;
            }
            else
            {
                tax = 5;
            }
        }
    }
}

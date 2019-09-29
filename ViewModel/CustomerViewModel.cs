using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WhatsMVVM.Model;

namespace WhatsMVVM.ViewModel
{
    /// <summary>
    /// ViewModel是对Model的封装和类型转换
    /// 为UI提供绑定数据
    /// </summary>
    public class CustomerViewModel : INotifyPropertyChanged
    {

        public CustomerViewModel()
        {
            buttonCommand = new ButtonCommand(Calaulate, Vertify);
        }

        public ICommand btn_Click
        {
            get { return buttonCommand; }
        }
        private Customer customer = new Customer();

        private ButtonCommand buttonCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        public string TxtName
        {
            get { return customer.CustomerName; }
            set { customer.CustomerName = value; }
        }

        public string TxtAmount
        {
            get { return customer.Amount.ToString(); }
            set { customer.Amount = int.Parse(value); }
        }

        //颜色
        public string LabColor
        {
            get
            {
                if (customer.Amount > 2000)
                {
                    return "Red";
                }
                else if (customer.Amount > 1500)
                {
                    return "Purple";
                }
                else
                {
                    return "Green";
                }
            }
            //set { }
        }

        public bool IsMarried
        {
            get
            {
                return customer.Marrid;
            }
            set
            {
                customer.Marrid = value;
            }
        }


        public double Tax
        {
            get { return customer.Tax; }
            set { customer.Tax = value; }
        }
        public void Calaulate()
        {
            customer.CalculateTax();
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Tax"));
            }
        }

        public bool Vertify()
        {
            return true;
        }
    }
}

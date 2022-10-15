using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_3_Saveliy
{
    class Product
    {
        private string имя;
        public string Имя
            {
            get
            {
                return имя;
            }
            set
            {
                имя = value;
            }
            }

        private string произв;
        public string Произв
        {
            get
            {
                return произв;
            }
            set
            {
                произв = value;
            }
        }
        private double цена;
        public double Цена
        {
            get
            {
                return цена;
            }
            set
            {
                цена = value;
            }
        }
        private DateTime срок;
        public DateTime Срок
        {
            get
            {
                return срок;
            }
            set
            {
                срок = value;
            }
        }
        private int кол;
        public int Кол
        {
            get
            {
                return кол;
            }
            set
            {
                кол = value;
            }
        }
    }
}

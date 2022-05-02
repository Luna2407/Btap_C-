using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btapngay_2604
{

    class giai_pt_bac2
    {
        private double a_66, b_66, c_66;
        public giai_pt_bac2()
        {

        }
        public double A_67
        {
            get { return a_66; }
            set { a_66 = value; }

        }
        public double B_67
        {
            get { return b_66; }
            set { b_66 = value; }

        }
        public double C_66
        {
            get { return c_66; }
            set { c_66 = value; }

        }
        public giai_pt_bac2(double a_66, double b_66, double c_67)
        {
            this.A_67 = a_66;
            this.B_67 = b_66;
            this.C_66 = c_67;
        }

        public double Delta(double a_66, double b_66, double c_66)
        {
            return (b_66 * b_66 - 4 * a_66 * c_66);
        }

        public void nghiem_PT(double a_66, double b_66, double c_66)
        {
            double delta_258 = Delta(a_66, b_66, c_66);
            if (a_66 == 0)
            {
                Console.WriteLine("Phuong trinh tro thanh bac nhat");
                Console.WriteLine("Co nghiem bang, x = {0}", -c_66 / b_66);
            }
            else
            {
                if (delta_258 < 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else if (delta_258 == 0)
                    Console.WriteLine("Phuong trinh co nghiem kep: x1 = x2 = {0}", -b_66 / (2 * a_66));
                else
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet: ");
                    Console.WriteLine("x1 = {0}", (-b_66 + Math.Sqrt(delta_258) / (2 * a_66)));
                    Console.WriteLine("x2 = {0}", (-b_66 - Math.Sqrt(delta_258) / (2 * a_66)));
                }

            }
        }
    }
}
    

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Calc
    {
        public string d = "+", result = "";
        public float b =0, a=0, k, res = 0 ;
        public int n = 0, l=0;
        


        public void Pin(string value)
        {
            result = result + value;

        }

        public void Act(string value)
        {
            int l = result.Length;
            if (l != 0)
                 
             try   {
                  
                

                    b = Convert.ToSingle(result.Substring(n, l - n));
                    n = result.Length;
                    result = result + value;
                    if (d == "+" ) res = a + b;
                    if (d == "-" ) res = a - b;
                    if (d == "*") res = a * b;
                    if (d == "/") res = a / b;
                    if (d == "C") Null();
                     a = res;
                        d = value;
                

                
            }
                catch
                {
                    result = "Ошибка";
                }
            else
            result = result + value;
            n = result.Length;
            d = value;
        }

        
       

        public void Equally(string value)
        {
            try
            {
                result = result  + res;
            }
            catch
            {
                result = "Ошибка";

            }

        }

        public void Null()
        {
            result = "";
            d = "+"; 
           b=a= k = n =0 ;
            res = 0;

        }




    }

}

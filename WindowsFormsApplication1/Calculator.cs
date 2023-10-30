using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Calculator

    {
        private int a, b;
        public Calculator(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Execute(string symbol)
        {
            int res = 0;
            switch (symbol)
            {
                case "+":
                    res = this.a + this.b;
                    break;
                case "-":
                    res = this.a - this.b;
                    break;
                case "*":
                    res = this.a * this.b;
                    break;
                case "/":
                    res = this.a / this.b;
                    break;
            }
            return res;
        }
    }
}

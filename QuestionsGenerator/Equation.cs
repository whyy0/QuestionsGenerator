using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsGenerator
{
    /// <summary>
    /// 算式
    /// </summary>
    class Equation
    {
        public int Num1
        {
            get; set;
        }

        public Generator.Operators Operator
        {
            get; set;
        }

        public int Num2
        {
            get; set;
        }

        public bool HasParentheses
        {
            get
            {
                Random ran = new Random();
                return ran.Next(0, 1) == 0 ? true : false;
            }
        }

        public int Value
        {
            get
            {
                return Int32.Parse(new System.Data.DataTable().Compute(this.ToString(), "").ToString());
            }
        }

        public override String ToString()
        {
            if(HasParentheses)
            {
                return "(" + Num1 + Operator.ToString() + Num2 + ")";
            }
            else
            {
                return Num1 + Operator.ToString() + Num2;
            }
        }
    }
}

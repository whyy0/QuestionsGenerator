using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionsGenerator
{
    class Generator
    {
        
        private List<Operators> _operatorScope;
        private int _numberAmount;
        private int _questionsAmount;

        public Generator(List<Operators> operatorsScope, int numberAmount, int questionAmount)
        {
            this._operatorScope = operatorsScope;
            this._numberAmount = numberAmount;
            this._questionsAmount = questionAmount;
        }

        public List<string> DoGenerate()
        {
            List<String> results = new List<string>(this._questionsAmount);

            for(int i = 0; i < _questionsAmount; i++)
            {

            }

            return results;
        }

        private String generateQuestion()
        {
            string result = "";

            List<Operators> operators = generateRandomOperators();

            Random ran = new Random();
            bool parentheses = ran.Next(0, 1) == 0 ? true : false;

            int num2 = ran.Next(100, 1000); //被减数、被除数
            int num1 = 0;
            if (operators[0] == Operators.Add) //
            {
                num1 = ran.Next(100, 1000 - num2); // the first num
            }
            else if(operators[0] == Operators.Subtract) //减数
            {
                num1 = ran.Next(num2, 1000-num2);
            }
            else if (operators[0] == Operators.Multiply) //乘法
            {
                num2 = ran.Next(10, 100);
                num1 = ran.Next(2, 10);
            }
            else if (operators[0] == Operators.Divide) //除法
            {
                num2 = ran.Next(2, 10);
                num1 = num2 * ran.Next(10, 100);
            }

            result = num1 + "" + num2;

            return result;
        }

        private List<Operators> generateRandomOperators()
        {
            List<Operators> ranOperators = new List<Operators>(_numberAmount - 1);  //运算符

            Random ran = new Random();
            for (int i = 0; i < _numberAmount - 1; i++)
            {
                int t = ran.Next(0, _operatorScope.Count);
                ranOperators.Add(_operatorScope[t]);
                System.Diagnostics.Debug.WriteLine(string.Format("random operator: [{0}]", _operatorScope[t]));
            }

            System.Diagnostics.Debug.WriteLine(string.Format("_ranOperatorList: [{0}]", ranOperators));

            return ranOperators;
        }

        public enum Operators { Add, Subtract, Multiply, Divide };
    }
}

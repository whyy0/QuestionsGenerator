using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionsGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            List<Generator.Operators> selectOperators = new List<Generator.Operators>(4);
            if (this.cbAdd.Checked)
            {
                selectOperators.Add(Generator.Operators.Add);
            }
            if (this.cbDivide.Checked)
            {
                selectOperators.Add(Generator.Operators.Divide);
            }
            if (this.cbMultiply.Checked)
            {
                selectOperators.Add(Generator.Operators.Multiply);
            }
            if (this.cbSubtract.Checked)
            {
                selectOperators.Add(Generator.Operators.Subtract);
            }

            Generator gen = new Generator(selectOperators, (int)this.numCount.Value, (int)this.numQuestion.Value);
        }
    }
}

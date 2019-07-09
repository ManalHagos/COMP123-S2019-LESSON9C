using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_LESSON9C
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculateForm_Click(object sender, EventArgs e)
        {
            var TheButton = sender as Button;
            int ButtonValue;
            bool Result = int.TryParse(TheButton.Text, out ButtonValue);
            if(Result)
            {
                ResultLabel.Text = TheButton.Text;
            }
            ResultLabel.Text = TheButton.Text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc002
{
    public partial class Form1 : Form
    {
        private Calc calc;

        public Form1()
        {
            InitializeComponent();
            calc = new Calc();
            updateDisplay();

        }

        private void updateDisplay() 
        {
            display1.Text = calc.ExpText;
            display2.Text = calc.OpText;
        }

        private void b0_Click(object sender, EventArgs e)
        {
            calc.pushNum(0);
            updateDisplay();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            calc.pushNum(1);
            updateDisplay();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            calc.pushNum(2);
            updateDisplay();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            calc.pushNum(3);
            updateDisplay();
        }
        private void b4_Click(object sender, EventArgs e)
        {
            calc.pushNum(4);
            updateDisplay();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            calc.pushNum(5);
            updateDisplay();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            calc.pushNum(6);
            updateDisplay();

        }

        private void b7_Click(object sender, EventArgs e)
        {
            calc.pushNum(7);
            updateDisplay();

        }

        private void b8_Click(object sender, EventArgs e)
        {
            calc.pushNum(8);
            updateDisplay();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            calc.pushNum(9);
            updateDisplay();

        }



        private void bPlus_Click(object sender, EventArgs e)
        {
            calc.pushOp(Operator.Plus);
            updateDisplay();
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            calc.pushOp(Operator.Minus);
            updateDisplay();

        }

        private void bMulti_Click(object sender, EventArgs e)
        {
            calc.pushOp(Operator.Multi);
            updateDisplay();

        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            calc.pushOp(Operator.Divide);
            updateDisplay();

        }

        private void bEq_Click(object sender, EventArgs e)
        {
            calc.pushOp(Operator.Equal);
            updateDisplay();

        }

        private void bDot_Click(object sender, EventArgs e)
        {
            calc.pushDot();
            updateDisplay();
        }

        private void bC_Click(object sender, EventArgs e)
        {
            calc.init();
            updateDisplay();
        }

        private void bCE_Click(object sender, EventArgs e)
        {
            calc.pushCE();
            updateDisplay();

        }

        private void bBS_Click(object sender, EventArgs e)
        {
            calc.pushBS();
            updateDisplay();
        }

        private void b00_Click(object sender, EventArgs e)
        {
            calc.push("00");
            updateDisplay();
        }






    }
}

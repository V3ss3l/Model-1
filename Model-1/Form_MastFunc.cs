using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_1
{
    public partial class Form_MastFunc : Form
    {
        public String expression;

        private StringBuilder strExp;

        public Form_MastFunc()
        {
            InitializeComponent();
            strExp = new StringBuilder();
            expression = string.Empty;
        }

        #region ButtonsEvents
        private void button_Del_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            strExp.Clear();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            strExp.Append("1");
            textBox1.Text = strExp.ToString();
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            strExp.Append("2");
            textBox1.Text = strExp.ToString();
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            strExp.Append("3");
            textBox1.Text = strExp.ToString();
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            strExp.Append("4");
            textBox1.Text = strExp.ToString();
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            strExp.Append("5");
            textBox1.Text = strExp.ToString();
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            strExp.Append("6");
            textBox1.Text = strExp.ToString();
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            strExp.Append("7");
            textBox1.Text = strExp.ToString();
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            strExp.Append("8");
            textBox1.Text = strExp.ToString();
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            strExp.Append("9");
            textBox1.Text = strExp.ToString();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            strExp.Append("0");
            textBox1.Text = strExp.ToString();
        }

        private void button_Dot_Click(object sender, EventArgs e)
        {
            strExp.Append(".");
            textBox1.Text = strExp.ToString();
        }

        private void button_Pi_Click(object sender, EventArgs e)
        {
            strExp.Append("P");
            textBox1.Text = strExp.ToString();
        }

        private void button_LeftBracket_Click(object sender, EventArgs e)
        {
            strExp.Append("(");
            textBox1.Text = strExp.ToString();
        }

        private void button_RightBracket_Click(object sender, EventArgs e)
        {
            strExp.Append(")");
            textBox1.Text = strExp.ToString();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            expression = strExp.ToString();
            button_Cancel_Click(sender, e);
        }
        

        private void button_Decrease_Click(object sender, EventArgs e)
        {
            strExp.Append("/");
            textBox1.Text = strExp.ToString();
        }

        private void button_Multiply_Click(object sender, EventArgs e)
        {
            strExp.Append("*");
            textBox1.Text = strExp.ToString();
        }

        private void button_Minus_Click(object sender, EventArgs e)
        {
            strExp.Append("-");
            textBox1.Text = strExp.ToString();
        }

        private void button_Plus_Click(object sender, EventArgs e)
        {
            strExp.Append("+");
            textBox1.Text = strExp.ToString();
        }

        private void button_Sqrt_Click(object sender, EventArgs e)
        {
            strExp.Append("√(");
            textBox1.Text = strExp.ToString();
        }

        private void button_Sqr_Click(object sender, EventArgs e)
        {
            strExp.Append("^2");
            textBox1.Text = strExp.ToString();
        }

        private void button_Exp_Click(object sender, EventArgs e)
        {
            strExp.Append("e");
            textBox1.Text = strExp.ToString();
        }

        private void button_Pow_Click(object sender, EventArgs e)
        {
            strExp.Append("^");
            textBox1.Text = strExp.ToString();
        }

        private void button_Lg_Click(object sender, EventArgs e)
        {
            strExp.Append("lg(");
            textBox1.Text = strExp.ToString();
        }

        private void button_Ln_Click(object sender, EventArgs e)
        {
            strExp.Append("ln(");
            textBox1.Text = strExp.ToString();
        }

        private void button_Sin_Click(object sender, EventArgs e)
        {
            strExp.Append("sin(");
            textBox1.Text = strExp.ToString();
        }

        private void button_Cos_Click(object sender, EventArgs e)
        {
            strExp.Append("cos(");
            textBox1.Text = strExp.ToString();
        }
        private void button_Tg_Click(object sender, EventArgs e)
        {
            strExp.Append("tg(");
            textBox1.Text = strExp.ToString();
        }
        private void button_Ctg_Click(object sender, EventArgs e)
        {
            strExp.Append("ctg(");
            textBox1.Text = strExp.ToString();
        }
        private void button_ArcSin_Click(object sender, EventArgs e)
        {
            strExp.Append("arcsin(");
            textBox1.Text = strExp.ToString();
        }
        private void button_ArcCos_Click(object sender, EventArgs e)
        {
            strExp.Append("arccos(");
            textBox1.Text = strExp.ToString();
        }
        private void button_ArcTg_Click(object sender, EventArgs e)
        {
            strExp.Append("arctg(");
            textBox1.Text = strExp.ToString();
        }
        private void button_ArcCtg_Click(object sender, EventArgs e)
        {
            strExp.Append("arcctg(");
            textBox1.Text = strExp.ToString();
        }
        private void button_Sh_Click(object sender, EventArgs e)
        {
            strExp.Append("sh(");
            textBox1.Text = strExp.ToString();
        }
        private void button_Ch_Click(object sender, EventArgs e)
        {
            strExp.Append("ch(");
            textBox1.Text = strExp.ToString();
        }
        private void button_Th_Click(object sender, EventArgs e)
        {
            strExp.Append("th(");
            textBox1.Text = strExp.ToString();
        }
        private void button_Cth_Click(object sender, EventArgs e)
        {
            strExp.Append("cth(");
            textBox1.Text = strExp.ToString();
        }
        private void button_Arsh_Click(object sender, EventArgs e)
        {
            strExp.Append("arsh(");
            textBox1.Text = strExp.ToString();
        }
        private void button_Arch_Click(object sender, EventArgs e)
        {
            strExp.Append("arch(");
            textBox1.Text = strExp.ToString();
        }
        private void button_Arth_Click(object sender, EventArgs e)
        {
            strExp.Append("arth(");
            textBox1.Text = strExp.ToString();
        }
        private void button_Arcth_Click(object sender, EventArgs e)
        {
            strExp.Append("arcth(");
            textBox1.Text = strExp.ToString();
        }
        private void button_Round_Click(object sender, EventArgs e)
        {
            strExp.Append("round(");
            textBox1.Text = strExp.ToString();
        }
        private void button_Trunc_Click(object sender, EventArgs e)
        {
            strExp.Append("trunc(");
            textBox1.Text = strExp.ToString();
        }
        private void button_Fruc_Click(object sender, EventArgs e)
        {
            strExp.Append("fruc(");
            textBox1.Text = strExp.ToString();
        }
        private void button_Abs_Click(object sender, EventArgs e)
        {
            strExp.Append("abs(");
            textBox1.Text = strExp.ToString();
        }
        private void button_RandR_Click(object sender, EventArgs e)
        {
            strExp.Append("randR(");
            textBox1.Text = strExp.ToString();
        }

        private void button_LeftSlide_Click(object sender, EventArgs e)
        {
            this.textBox1.SelectionStart = 0;
            this.textBox1.Focus();
        }

        private void button_SLeftSlide_Click(object sender, EventArgs e)
        {
            /*var selectionIndex = this.textBox1.Se;
            this.textBox1.Select(selectionIndex, selectionIndex - 1);
            this.textBox1.Focus();*/
        }

        private void button_SRightSlide_Click(object sender, EventArgs e)
        {

        }

        private void button_RightSlide_Click(object sender, EventArgs e)
        {
            this.textBox1.SelectionStart = this.textBox1.TextLength;
            this.textBox1.Focus();
        }
        #endregion


    }
}

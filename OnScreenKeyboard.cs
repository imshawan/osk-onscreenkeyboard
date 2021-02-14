using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnScreenKeyboard
{
    public partial class OnScreenKeyboard : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 8;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }
        public OnScreenKeyboard()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F1}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F2}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F3}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                SendKeys.Send("%{F4}");
                checkBox7.Checked = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F8}");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGDN}");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            AuthorINFO author = new AuthorINFO();
            author.ShowDialog();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                SendKeys.Send("7");
            } 
            else
            {
                SendKeys.Send("{HOME}");
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("E");
            }
            else
            {
                SendKeys.Send("e");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("!");
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("1");
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("W");
            }
            else
            {
                SendKeys.Send("w");
            }
        }

        private void button87_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("<");
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send(",");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("@");
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("2");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("#");
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("3");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("$");
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("4");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("%");
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("5");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("^");
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("6");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("&");
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("7");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("*");
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("8");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("(");
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("9");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send(")");
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("0");
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("_");
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("-");
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("+");
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("=");
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("~");
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("`");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F5}");
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("Q");
            }
            else
            {
                SendKeys.Send("q");
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("R");
            }
            else
            {
                SendKeys.Send("r");
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("T");
            }
            else
            {
                SendKeys.Send("t");
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("Y");
            }
            else
            {
                SendKeys.Send("y");
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("U");
            }
            else if (checkBox4.Checked || checkBox9.Checked)
            {
                SendKeys.Send("^U");
                checkBox4.Checked = false;
                checkBox9.Checked = false;
            }
            else
            {
                SendKeys.Send("u");
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("I");
            }
            else if (checkBox4.Checked || checkBox9.Checked)
            {
                SendKeys.Send("^I");
                checkBox4.Checked = false;
                checkBox9.Checked = false;
            }
            else
            {
                SendKeys.Send("i");
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("O");
            }
            else
            {
                SendKeys.Send("o");
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("P");
            }
            else
            {
                SendKeys.Send("p");
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("{");
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("[");
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("}");
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("]");
            }
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("|");
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("\\");
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("A");
            }
            else if (checkBox4.Checked || checkBox9.Checked)
            {
                SendKeys.Send("^A");
                checkBox4.Checked = false;
                checkBox9.Checked = false;
            }
            else
            {
                SendKeys.Send("a");
            }
        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("S");
            }
            else if (checkBox4.Checked)
            {
                SendKeys.Send("^S");
                checkBox4.Checked = false;
            }
            else
            {
                SendKeys.Send("s");
            }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("D");
            }
            else
            {
                SendKeys.Send("d");
            }
        }

        private void button71_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("F");
            }
            else
            {
                SendKeys.Send("f");
            }
        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("G");
            }
            else
            {
                SendKeys.Send("g");
            }
        }

        private void button73_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("H");
            }
            else
            {
                SendKeys.Send("h");
            }
        }

        private void button74_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("J");
            }
            else if (checkBox4.Checked || checkBox9.Checked)
            {
                SendKeys.Send("^J");
                checkBox4.Checked = false;
                checkBox9.Checked = false;
            }
            else
            {
                SendKeys.Send("j");
            }
        }

        private void button75_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("K");
            }
            else
            {
                SendKeys.Send("k");
            }
        }

        private void button76_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("L");
            }
            else
            {
                SendKeys.Send("l");
            }
        }

        private void button77_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send(":");
            }
            else
            {
                SendKeys.Send(";");
            }
        }

        private void button78_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("\"");
            }
            else
            {
                SendKeys.Send("'");
            }
        }

        private void button80_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void button54_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }

        private void button94_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGUP}");
        }

        private void button92_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{UP}");
        }

        private void button93_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DOWN}");
        }

        private void button91_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{LEFT}");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{END}");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            { SendKeys.Send("{INSERT}");
                checkBox5.Checked = false;
            }
            else { SendKeys.Send("{DEL}"); }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        private void button79_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("Z");
            }
            else if (checkBox4.Checked || checkBox9.Checked)
            {
                SendKeys.Send("^Z");
                checkBox4.Checked = false;
                checkBox9.Checked = false;
            }
            else
            {
                SendKeys.Send("z");
            }
        }

        private void button81_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("X");
            }
            else if (checkBox4.Checked || checkBox9.Checked)
            {
                SendKeys.Send("^X");
                checkBox4.Checked = false;
                checkBox9.Checked = false;
            }
            else
            {
                SendKeys.Send("x");
            }
        }

        private void button82_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("C");
            }
            else if (checkBox4.Checked || checkBox9.Checked)
            {
                SendKeys.Send("^C");
                checkBox4.Checked = false;
                checkBox9.Checked = false;
            }
            else
            {
                SendKeys.Send("c");
            }
        }

        private void button83_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("V");
            }
            else if (checkBox4.Checked || checkBox9.Checked)
            {
                SendKeys.Send("^V");
                checkBox4.Checked = false;
                checkBox9.Checked = false;
            }
            else
            {
                SendKeys.Send("v");
            }
        }

        private void button84_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("B");
            }
            else if (checkBox4.Checked || checkBox9.Checked)
            {
                SendKeys.Send("^B");
                checkBox4.Checked = false;
                checkBox9.Checked = false;
            }
            else
            {
                SendKeys.Send("b");
            }
        }

        private void button85_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("N");
            }
            else
            {
                SendKeys.Send("n");
            }
        }

        private void button86_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("M");
            }
            else
            {
                SendKeys.Send("m");
            }
        }

        private void button88_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send(">");
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send(".");
            }
        }

        private void button89_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("?");
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("/");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PRTSC}");
        }

        private void OnScreenKeyboard_Load(object sender, EventArgs e)
        {
            
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                SendKeys.Send("3");
            }
            else
            {
                SendKeys.Send("{PGDN}");
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DIVIDE}");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                SendKeys.Send("8");
            }
            else
            {
                SendKeys.Send("{UP}");
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                SendKeys.Send("9");
            }
            else
            {
                SendKeys.Send("{PGUP}");
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                SendKeys.Send("4");
            }
            else
            {
                SendKeys.Send("{LEFT}");
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                SendKeys.Send("9");
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                SendKeys.Send("6");
            }
            else
            {
                SendKeys.Send("{RIGHT}");
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                SendKeys.Send("1");
            }
            else
            {
                SendKeys.Send("{END}");
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                SendKeys.Send("2");
            }
            else
            {
                SendKeys.Send("{DOWN}");
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                SendKeys.Send("0");
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^({ESC})");
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F12}");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F7}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F6}");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F9}");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F10}");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F11}");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ADD}");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{SUBTRACT}");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{MULTIPLY}");
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                SendKeys.Send(".");
            }
            else
            {
                SendKeys.Send("{DEL}");
            }
        }
    }
}

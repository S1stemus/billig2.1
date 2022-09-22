using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static биллиг1.solution;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {                
                int maxnum = int.Parse(MaxNum.Text);
                int minnum = int.Parse(MinNum.Text);
                if (maxnum <= 0 || minnum <= 0) throw new IndexOutOfRangeException();
                List<int> Simp = Eratosfen(maxnum);
                Filter(Simp, minnum);
            }
            catch (FormatException )
            {
                Result.Text = "Не туда воюешь";
            }
            catch (OverflowException)
            {
                Result.Text = "Введите число которое больше нуля";
            }
            catch (IndexOutOfRangeException)
            {
                Result.Text = "Введите число которое больше нуля";
            }


        }

        private void MaxNum_TextChanged(object sender, EventArgs e)
        {
            Result.Text = "";
        }
    }
}

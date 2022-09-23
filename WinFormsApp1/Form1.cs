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
                if (maxnum < minnum)
                {
                    DialogResult dialogResult = MessageBox.Show("Изменить?", "Максимальное значение меньше минимального", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int tmp = maxnum;
                        maxnum = minnum;
                        minnum = tmp;
                        MaxNum.Text = maxnum.ToString();
                        MinNum.Text = minnum.ToString();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                if (maxnum > 10000 || minnum > 10000) throw new OverflowException();
                List<int> Simp = Eratosfen(maxnum);
                Filter(Simp, minnum);
                int Diff= MaxDiff1(Simp);
                Result.Text = String.Join(",",Simp);
                MaxDiff.Text = Diff.ToString();
            }
            catch (FormatException )
            {
                Result.Text = "Вводите только числа";
            }
            catch (OverflowException)
            {
                Result.Text = "Введено слишком большое число";
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

        private void MinNum_TextChanged(object sender, EventArgs e)
        {
            Result.Text = "";
        }
    }
}

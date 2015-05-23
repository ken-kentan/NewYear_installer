using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asobi01
{
    public partial class Form1 : Form
    {
        int M,D,Y,sum_day;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            Y = DateTime.Now.Year + 1;
            M = DateTime.Now.Month;
            D = DateTime.Now.Day;
            DateTime now = new DateTime(Y, M, D);
            DateTime O = new DateTime(Y, 1, 1);
            TimeSpan sum = now - O;
            sum_day = Convert.ToInt32(sum.TotalDays);
            label2.Text = sum_day.ToString() + "/365days";
            this.Text = Y.ToString() + "年インストーラ";
            label1.Text = Y.ToString() + "年を読み込み中です。";
            progressBar_year.Value = sum_day;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("操作を完了出来ませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

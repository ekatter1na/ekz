using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Скопировано", "Копировать");
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вставлено", "Вставить");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("О программе", "Справка");
        }

       

        private void button33_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void обычныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CC.Enabled = true;
            c1.Enabled = true;
            c2.Enabled = true;
            c3.Enabled = true;
            c4.Enabled = true;
            c5.Enabled = true;
            c6.Enabled = true;
            c7.Enabled = true;
            c8.Enabled = true;
            c9.Enabled = true;
            c0.Enabled = true;
            zakr.Enabled = true;
            otkr.Enabled = true;
            plus.Enabled = true;
            minus.Enabled = true;
            umnoj.Enabled = true;
            delit.Enabled = true;

            sin.Enabled = false;
            sinh.Enabled = false;
            log.Enabled = false;
            x1.Enabled = false;
            exp.Enabled = false;
            cos.Enabled = false;
            cosh.Enabled = false;
            N.Enabled = false;
            tan.Enabled = false;
            tanh.Enabled = false;
            a.Enabled = false;
            b.Enabled = false;
            c.Enabled = false;
            d.Enabled = false;
            E.Enabled = false;
            f.Enabled = false;

            grafik.Enabled = false;

        }

        private void инженерныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CC.Enabled = true;
            c1.Enabled = true;
            c2.Enabled = true;
            c3.Enabled = true;
            c4.Enabled = true;
            c5.Enabled = true;
            c6.Enabled = true;
            c7.Enabled = true;
            c8.Enabled = true;
            c9.Enabled = true;
            c0.Enabled = true;
            zakr.Enabled = true;
            otkr.Enabled = true;
            plus.Enabled = true;
            minus.Enabled = true;
            umnoj.Enabled = true;
            delit.Enabled = true;

            sin.Enabled = true;
            sinh.Enabled = true;
            log.Enabled = true;
            x1.Enabled = true;
            exp.Enabled = true;
            cos.Enabled = true;
            cosh.Enabled = true;
            N.Enabled = true;
            tan.Enabled = true;
            tanh.Enabled = true;
            a.Enabled = true;
            b.Enabled = true;
            c.Enabled = true;
            d.Enabled = true;
            E.Enabled = true;
            f.Enabled = true;

            grafik.Enabled = false;
        }

        private void функцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CC.Enabled = true;
            c1.Enabled = true;
            c2.Enabled = true;
            c3.Enabled = true;
            c4.Enabled = true;
            c5.Enabled = true;
            c6.Enabled = true;
            c7.Enabled = true;
            c8.Enabled = true;
            c9.Enabled = true;
            c0.Enabled = true;
            zakr.Enabled = true;
            otkr.Enabled = true;
            plus.Enabled = true;
            minus.Enabled = true;
            umnoj.Enabled = true;
            delit.Enabled = true;

            sin.Enabled = true;
            sinh.Enabled = true;
            log.Enabled = true;
            x1.Enabled = true;
            exp.Enabled = true;
            cos.Enabled = true;
            cosh.Enabled = true;
            N.Enabled = true;
            tan.Enabled = true;
            tanh.Enabled = true;
            a.Enabled = false;
            b.Enabled = false;
            c.Enabled = false;
            d.Enabled = false;
            E.Enabled = false;
            f.Enabled = false;

            grafik.Enabled = true;

        }

        
    }
    }


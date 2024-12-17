using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanhwinbuoi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            label4.Text = today.ToString("dd/MM/yyyy");
            resetBTN_Color();
        }

        private void resetBTN_Color()
        {
            Button[] btn = { btnSV, btnClass };
            foreach (Button button in btn)
            {
                button.BackColor = SystemColors.Control;
            }
        }
        private void btnSV_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Form2 frm = new Form2();
            frm.MdiParent = this;
            panel4.Controls.Add(frm);
            frm.Show();
            frm.Text = "Sinh Vien";
            resetBTN_Color();
            btnSV.BackColor = Color.Gray;
            
        }



        private void btnClass_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Form3 frm = new Form3();
            frm.MdiParent = this;
            panel4.Controls.Add(frm);
            frm.Show();
            frm.Text = "Lop";
            resetBTN_Color();
            btnClass.BackColor = Color.Gray;
        }
    }
}

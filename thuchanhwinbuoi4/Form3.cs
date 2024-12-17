﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace thuchanhwinbuoi4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void clearinput()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string ms = textBox1.Text;
            string tl = textBox2.Text;
            string kh = textBox3.Text;
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" )
                    throw new Exception("hay nhap du thong tin can thiet");
                else
                {
                    dataGridView1.Rows.Add(ms,tl,kh);
                    clearinput();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                    throw new Exception("hay chon 1 dong de sua");

                int rowIndex = dataGridView1.CurrentRow.Index;

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    throw new Exception("hay nhap du thong tin can thiet");

                // Cập nhật giá trị
                dataGridView1.Rows[rowIndex].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[rowIndex].Cells[1].Value = textBox2.Text;
                dataGridView1.Rows[rowIndex].Cells[2].Value = textBox3.Text;
               
                clearinput();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                    throw new Exception("hay chon 1 dong de xoa");

                int rowIndex = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(rowIndex);
                clearinput();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Kiểm tra nếu không phải header
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Hiển thị dữ liệu lên TextBox
                    textBox1.Text = row.Cells[0].Value.ToString();
                    textBox2.Text = row.Cells[1].Value.ToString();
                    textBox3.Text = row.Cells[2].Value.ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POchTA
{

    //interface transport 
    //{
    //     
    //}
    interface pak
    {
        string name1 { get; set; }
        string name2 { get; set; }
        double vag { get; set; }
        double ob { get; set; }
        double h { get; set; }
        double l { get; set; }
        double w { get; set; }
        double rang { get; set; }
        int i { get; set; }
        int a { get; set; }
        bool b { get; set; }

        double costOB(double ob);
        double costVag(double vag);
        double CostFuil(double rang, int i);
        double costTyPac(int a);
        double Cost();
    
    }

   
        
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<SRtovar> sRtovars = new List<SRtovar>();
        List<OBtovar> OBtovars = new List<OBtovar>();
        List<Valu> val = new List<Valu>();
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (checkBox2.Checked==false) 
            {
                OBtovar ppp = new OBtovar(textBox1.Text, textBox2.Text, Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox3.Text),
                                 Convert.ToDouble(textBox6.Text), Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox5.Text), comboBox1.SelectedIndex, comboBox2.SelectedIndex,
                                 checkBox1.Checked);
                OBtovars.Add(ppp);
                dataGridView1.Rows.Add();
                Valu va = new Valu(textBox1.Text, textBox2.Text, ppp.Cost(),
                  checkBox2.Checked);
                val.Add(va);
            }
            else
            {
                SRtovar sr = new SRtovar(textBox1.Text, textBox2.Text, Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox3.Text),
                  Convert.ToDouble(textBox6.Text), Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox5.Text), comboBox1.SelectedIndex, comboBox2.SelectedIndex,
                  checkBox2.Checked);
         

            //SRtovar sr = new SRtovar ("qwer", "wwww", 3, 100, 2, 2, 2, 1, 1, true);
            sRtovars.Add(sr);
            dataGridView1.Rows.Add();
                Valu v = new Valu(textBox1.Text, textBox2.Text, sr.Cost(),
                  checkBox2.Checked);
                val.Add(v);
            }
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int k = 0;
            int i = 1;
            //if (k % 2 != 0)  dataGridView1.Rows.Add();
            
            
                for (int addres = 0; addres < val.Count; addres++)
                {
                    
                    dataGridView1.Rows[k].Cells[0].Value = i++;
                    dataGridView1.Rows[k].Cells[1].Value = val[addres].name;
                    dataGridView1.Rows[k].Cells[2].Value = val[addres].name2;
                if (val[addres].dos==true) { dataGridView1.Rows[k].Cells[3].Style.BackColor = System.Drawing.Color.Green; } else { dataGridView1.Rows[k].Cells[3].Style.BackColor = System.Drawing.Color.Red; }
                    dataGridView1.Rows[k].Cells[4].Value = val[addres].cost;
                k++;
                }
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
            int n= dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            val.RemoveAt(n);
        }
    }
}

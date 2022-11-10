using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCFS
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            data = new Data[0];
            listview();
        }
        private Data[] data;
        struct Data
        {
            public string nama;
            public int Arrival, burst, wait, finished, start, TurnAround;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int Arrival, burst;
            if (textbox1.Text == "")
                MessageBox.Show("Input Number of Process !!!");
            else
            {
                for (int i = 0; i < int.Parse(textbox1.Text); i++)
                {
                    Array.Resize(ref data, data.Length-1 );
                    Arrival = rnd.Next(1, 30);
                    burst = rnd.Next(1, 30);
                    LV.Items.Add(data[data.GetUpperBound(0)].nama = "Proses  " + (i + 1));
                    LV.Items[LV.Items.Count - 1].SubItems.Add(Convert.ToString((data[data.GetUpperBound(0)].Arrival = Arrival)));
                    LV.Items[LV.Items.Count - 1].SubItems.Add(Convert.ToString((data[data.GetUpperBound(0)].burst = burst)));

                }
                textbox1.Clear();
            }
        }
        private void listview()
        {
            LV.Clear();
            LV.View = View.Details;
            LV.Columns.Add("Name", 80);
            LV.Columns.Add("Arrival time", 80);
            LV.Columns.Add("Burst Time", 80);
            LV.Columns.Add("start", 80);
            LV.Columns.Add("Finished", 80);
            LV.Columns.Add("Wait", 80);
            LV.Columns.Add("TA", 80);
            LV.GridLines = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listview();
            int WT, LE;
            string NP;
            float total = 0, total_1 = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (data[i].Arrival < data[j].Arrival)
                    {
                        WT = data[j].Arrival;
                        data[j].Arrival = data[i].Arrival;
                        data[i].Arrival = WT;
                        NP = data[j].nama;
                        data[j].nama = data[i].nama;
                        data[i].nama = NP;
                        LE = data[j].burst;
                        data[j].burst = data[i].burst;
                        data[i].burst = LE;

                    }
                }
            }
            for (int r = 0; r < data.Length; r++)
            {
                if (r > 0)
                {
                    if (data[r].Arrival <= data[r - 1].finished)
                    {
                        data[r].start = data[r - 1].finished;
                    }
                    else
                    {
                        data[r].start = data[r].Arrival;
                    }
                }
                else
                    data[r].start = data[r].Arrival;

                data[r].finished = data[r].burst + data[r].start;
                data[r].wait = data[r].start - data[r].Arrival;
                data[r].TurnAround = data[r].finished - data[r].Arrival;
                total += data[r].TurnAround;
                total_1 += data[r].wait;
            }

            textbox2.Text = total.ToString();
            textbox3.Text = (total / data.Length).ToString();
            textBox4.Text = total_1.ToString();
            textBox5.Text = (total_1 / data.Length).ToString();


            for (int r = 0; r < data.Length; r++)
            {
                LV.Items.Add(data[r].nama);
                LV.Items[r].SubItems.Add(data[r].Arrival.ToString());
                LV.Items[r].SubItems.Add(data[r].burst.ToString());
                LV.Items[r].SubItems.Add(data[r].start.ToString());
                LV.Items[r].SubItems.Add(data[r].finished.ToString());
                LV.Items[r].SubItems.Add(data[r].wait.ToString());
                LV.Items[r].SubItems.Add(data[r].TurnAround.ToString());
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            textbox2.Clear();
            textbox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            listview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form2 sh = new Form2();
            sh.Show();


        }
    }
    }


    


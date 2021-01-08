using SwissTransport.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var transport = new Transport();
            var connections = transport.GetConnections(comboBox1.Text , comboBox2.Text);
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(connections.ConnectionList[0].Duration, connections.ConnectionList[0].From.Departure, connections.ConnectionList[0].From.Delay, connections.ConnectionList[0].From.Platform);
            dataGridView1.Rows.Add(connections.ConnectionList[1].Duration, connections.ConnectionList[1].From.Departure, connections.ConnectionList[1].From.Delay, connections.ConnectionList[1].From.Platform);
            dataGridView1.Rows.Add(connections.ConnectionList[2].Duration, connections.ConnectionList[2].From.Departure, connections.ConnectionList[2].From.Delay, connections.ConnectionList[2].From.Platform);
            dataGridView1.Rows.Add(connections.ConnectionList[3].Duration, connections.ConnectionList[3].From.Departure, connections.ConnectionList[3].From.Delay, connections.ConnectionList[3].From.Platform);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            var transport = new Transport();
            if (comboBox1.Text != "")
            {
                var stations = transport.GetStations(comboBox1.Text);
                var temp = stations.StationList[0].Name;

                foreach (var x in stations.StationList)
                {
                    comboBox1.Items.Add(x.Name);
                }


            }
            else 
            {
                comboBox1.Text = "";
            }            

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            var transport = new Transport();
            if (comboBox2.Text != "")
            {
                var stations = transport.GetStations(comboBox2.Text);
                var temp = stations.StationList[0].Name;

                foreach (var x in stations.StationList)
                {
                    comboBox2.Items.Add(x.Name);
                }


            }
            else
            {
                comboBox2.Text = "";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            var transport = new Transport();
            if (comboBox3.Text != "")
            {
                var stations = transport.GetStations(comboBox3.Text);
                var temp = stations.StationList[0].Name;

                foreach (var x in stations.StationList)
                {
                    comboBox3.Items.Add(x.Name);
                }


            }
            else
            {
                comboBox3.Text = "";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var transport = new Transport();
            var connections = transport.GetStationBoard(comboBox3.Text,comboBox3.Text);
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(connections.Entries[0].Stop.Departure, connections.Entries[0].To, connections.Entries[0].Name);
            dataGridView2.Rows.Add(connections.Entries[1].Stop.Departure, connections.Entries[1].To, connections.Entries[1].Name);
            dataGridView2.Rows.Add(connections.Entries[2].Stop.Departure, connections.Entries[2].To, connections.Entries[2].Name);
            dataGridView2.Rows.Add(connections.Entries[3].Stop.Departure, connections.Entries[3].To, connections.Entries[3].Name);
            dataGridView2.Rows.Add(connections.Entries[4].Stop.Departure, connections.Entries[4].To, connections.Entries[4].Name);
            dataGridView2.Rows.Add(connections.Entries[5].Stop.Departure, connections.Entries[5].To, connections.Entries[5].Name);
            dataGridView2.Rows.Add(connections.Entries[6].Stop.Departure, connections.Entries[6].To, connections.Entries[6].Name);
            dataGridView2.Rows.Add(connections.Entries[7].Stop.Departure, connections.Entries[7].To, connections.Entries[7].Name);
            dataGridView2.Rows.Add(connections.Entries[8].Stop.Departure, connections.Entries[8].To, connections.Entries[8].Name);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }   
}

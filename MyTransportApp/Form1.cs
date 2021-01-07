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
            dataGridView1.Rows.Add(connections.ConnectionList[1].Duration, connections.ConnectionList[1].From.Departure, connections.ConnectionList[1].From.Delay);
            dataGridView1.Rows.Add(connections.ConnectionList[2].Duration, connections.ConnectionList[2].From.Departure, connections.ConnectionList[2].From.Delay);
            dataGridView1.Rows.Add(connections.ConnectionList[3].Duration, connections.ConnectionList[3].From.Departure, connections.ConnectionList[3].From.Delay);
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var transport = new Transport();
            var connections = transport.GetConnections("luzern","sursee");
            var temp = connections.ConnectionList[0].From.Station;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            var transport = new Transport();
            var stations = transport.GetStations(comboBox1.Text);
            var temp = stations.StationList[0].Name;

            foreach(var x in stations.StationList)
            {
                comboBox1.Items.Add(x.Name);
            }
            
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            var transport = new Transport();
            var stations = transport.GetStations(comboBox2.Text);
            var temp = stations.StationList[0].Name;

            foreach (var x in stations.StationList)
            {
                comboBox2.Items.Add(x.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }   
}

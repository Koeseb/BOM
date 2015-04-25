using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BOM
{
    public partial class Main : Form
    {
        string[] topicList = { "Aktivitaeten", "Buchungen", "Fahrtenbuch" };
        int index_topicList;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // examples
            listView_ActivityList.Items.Add("Franz Mueller hat 2543 Euro abgebucht (Grund: Kaffeemaschine kaputt).\n");
            listView_ActivityList.Items.Add("Ramasan Butaki hat fuer 300 Euro einen Schrank gekauft.\n");
            listView_ActivityList.Items.Add("Marus Troester hat 20 Euro abgebucht (Grund: Nach Neuseeland fliegen.)\n");
        }

        private void button_Forward_Click(object sender, EventArgs e)
        {
            /*
             * reset
             */
            index_topicList++;
            if (index_topicList > topicList.Length - 1)
            {
                index_topicList = 0;
            }

            switch (index_topicList)
            {
                case 0:
                    label_Topic.Text = topicList[index_topicList];
                    listView_ActivityList.Show();
                    break;
                case 1:
                    label_Topic.Text = topicList[index_topicList];
                    if (listView_ActivityList.Visible)
                    {
                        listView_ActivityList.Hide();
                    }
                    break;
                case 2:
                    label_Topic.Text = topicList[index_topicList];
                    if (listView_ActivityList.Visible)
                    {
                        listView_ActivityList.Hide();
                    }
                    break;
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            /*
             * reset
             */
            index_topicList--;
            if (index_topicList < 0)
            {
                index_topicList = topicList.Length;
            }

            switch (index_topicList)
            {
                case 0:
                    label_Topic.Text = topicList[index_topicList];
                    listView_ActivityList.Show();
                    break;
                case 1:
                    label_Topic.Text = topicList[index_topicList];
                    if (listView_ActivityList.Visible)
                    {
                        listView_ActivityList.Hide();
                    }
                    break;
                case 2:
                    label_Topic.Text = topicList[index_topicList];
                    if (listView_ActivityList.Visible)
                    {
                        listView_ActivityList.Hide();
                    }
                    break;
            }
        }
    }
}

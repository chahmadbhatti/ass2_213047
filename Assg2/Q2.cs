using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class MainForm : Form
    {
        private List<string> dataList = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string data = dataInputTextBox.Text;
            if (!string.IsNullOrEmpty(data))
            {
                dataList.Add(data);
                listBox.Items.Add(data);
                dataInputTextBox.Clear();
            }
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                int selectedIndex = listBox.SelectedIndex;
                dataList.RemoveAt(selectedIndex);
                listBox.Items.RemoveAt(selectedIndex);
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            dataList.Clear();
            listBox.Items.Clear();
        }
    }

}
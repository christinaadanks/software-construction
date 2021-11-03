﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;
using WebBrowser.Data;
using WebBrowser.Data.HistoryDataSetTableAdapters;

/**
 * @author Christina Liu
 * @version 4/3/2021
 */

namespace WebBrowser.UI
{
    public partial class HistoryManagerForm : Form
    {
        public static string SetURL = "";
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            // Get items from the history database
            var items = HistoryManager.GetItems();
            foreach (var item in items)
            {
                // Display history items in the list box
                listBox1.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
            }
        }

        private void histSrchBtn_Click(object sender, EventArgs e)
        {
            // Search in history
            var items = HistoryManager.GetItems();
            listBox1.Items.Clear();
            foreach (var item in items)
            {
                bool result = item.Title.IndexOf(histSrchBox.Text, StringComparison.OrdinalIgnoreCase) >= 0;
                bool result2 = item.URL.IndexOf(histSrchBox.Text, StringComparison.OrdinalIgnoreCase) >= 0;
                if (result == true || result2 == true)
                {
                    listBox1.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
                }
            }
        }

        private void histSrchBox_KeyUp(object sender, KeyEventArgs e)
        {
            // Search if enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                histSrchBtn_Click(sender, e);
            }
        }

        private void histDelBtn_Click(object sender, EventArgs e)
        {
            // Delete selected item
            try
            {
                string item = listBox1.GetItemText(listBox1.SelectedItem);
                HistoryManager.DeleteHistory(item);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

            catch
            {
                MessageBox.Show("please select something to delete ♥.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dlog = MessageBox.Show("are you sure you want to clear your entire history?", "clear history",MessageBoxButtons.YesNo);
            if (dlog == DialogResult.Yes)
            {
                // clear history
                HistoryManager.ClearHistory();
                listBox1.Items.Clear();
            }
            else if (dlog == DialogResult.No)
            {
                // nothing happens
            }

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var items = HistoryManager.GetItems();
            foreach (var item in items)
            {
                // Display history items in the list box
                listBox1.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var adapter = new HistoryTableAdapter();
                var list = adapter.GetData();
                var item = listBox1.SelectedItem.ToString();
                foreach (var bitem in list)
                {
                    if (item.Contains(bitem.URL))
                    {
                        SetURL = bitem.URL;
                        if (System.Windows.Forms.Application.OpenForms["MainWindow"] != null)
                        {
                            (System.Windows.Forms.Application.OpenForms["MainWindow"] as MainWindow).HistoryLinkTo();
                        }
                        this.Close();
                    }
                }
            }
            catch
            {
                // do nothing
            }

        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            //if the item state is selected them change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.LightPink) ;//Choose the color

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Draw the current item text
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }
    }
}

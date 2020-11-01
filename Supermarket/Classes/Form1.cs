
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Supermarkt : Form
    {
        private Dictionary<string, int> ItemsWithCount;
        private string filePath;

        public Supermarkt()
        {
            InitializeComponent();
            ItemsWithCount = new Dictionary<string, int>();
            filePath = @"C:\Users\DCV\Desktop\Code\05 C#\Supermarket\Supermarket\bin\Debug\SuperMarket.txt";
            ReadExternalFile();
            PrintItemsWithCountInlbItems();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string key = tbItemName.Text;
            int value = Convert.ToInt32(nudCount.Value);

            if (!IsItemInDictIncluded(key))
            {
                AddNewItemToDict(key, value);
            }
            else
            {
                AddValueToItem(key, value);
            }

            PrintItemsWithCountInlbItems();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            string key = tbItemName.Text;
            int value = Convert.ToInt32(nudCount.Value);

            if (!IsItemInDictIncluded(key))
            {
                MessageBox.Show("Artikel ist nicht enthalten!");
            }
            else
            {
                SubtractValueToItem(key, value);
            }

            PrintItemsWithCountInlbItems();
        }

        private bool IsItemInDictIncluded(string key)
        {
            bool isIncluded = false;

            if (!ItemsWithCount.ContainsKey(key))
            {
                MessageBox.Show("Neuer Artikel angelegt");
            }
            else
            {
                isIncluded = true;
            }

            return isIncluded;
        }

        private void AddValueToItem(string key, int value)
        {
            ItemsWithCount[key] += value;
        }

        private void SubtractValueToItem(string key, int value)
        {
            if (ItemsWithCount[key] >= value)
            {
                ItemsWithCount[key] -= value;
            }
            else
            {
                ItemsWithCount[key] = 0;
            }
        }

        private void AddNewItemToDict(string key, int value)

        {
            ItemsWithCount.Add(key, value);
        }

        private void PrintItemsWithCountInlbItems()
        {
            lbItems.Items.Clear();

            foreach (var item in ItemsWithCount)
            {
                lbItems.Items.Add(item.Key + " [" + item.Value + "]");
            }
        }

        private void WriteTxtFile()
        {
            using (StreamWriter writer = new StreamWriter(this.filePath))
            {
                foreach (var element in ItemsWithCount)
                {
                    writer.WriteLine(element.Key + ";" + element.Value);
                }
            }
        }

        private void ReadExternalFile()
        {
            string[] lines = System.IO.File.ReadLines(this.filePath).ToArray();

            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(';');
                ItemsWithCount.Add(temp[0], Convert.ToInt32(temp[1]));
            }
        }

        private void btExportToCsv_Click(object sender, EventArgs e)
        {
            WriteTxtFile();
            MessageBox.Show("Einkaufsliste wurde als CSV exportiert");
        }
    }
}
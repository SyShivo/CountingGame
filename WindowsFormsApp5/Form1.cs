using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {

        string[] strName = { "Саша", "Аня", "Макс", "Пабло", "Дон", "Андре", "Аліна", "Росомаха" };
        int randName;
        Random random = new Random();
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            randName = random.Next(strName.Length);
            listView1.Items.Add(strName[randName]);
            int j = listView1.Items.Count;
            label1.Text = Convert.ToString(j);
        }

        private void listView1_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.RemoveAt(listView1.Items.Count - 1);
            }

            int j = listView1.Items.Count;
            label1.Text = Convert.ToString(j);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string[] Accounting = { };
        string[] Accounting1 = {"Цар","Імператор","Шах","Король","Великий князь","Фараон","А ти вийди геть","Ти навіть не \nбарон"};
        string[] Accounting2 = { "Тихіше", "миші", "Кіт на даху", "Хто не чув", "Той і вийшов!" };
        string[] Accounting3 = {"Хмари", "хмари!", "хмарии", "Хмари","Скаче кінь \n великий", "могутній","Через хмари \n скаче він","Хто не вірить – \n вийди геть!"};

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            switch (selectedState)
            {
                case "ти навіть не барон!":
                    Accounting = Accounting1;
                    break;
                case "Кіт на даху!":
                    Accounting = Accounting2;
                    break;
                case "Скаче кінь великий!":
                    Accounting = Accounting3;
                    break;
                default:
                    return;
            }
            if (listView1.Items.Count == 0 || listView1.Items.Count == 1)
            {
                return;
            }
            
            for (int i = 0; i < Accounting.Length; i++)
            {
                    int index = i % listView1.Items.Count;
                    if (index < listView1.Items.Count)
                    {
                        listView1.Items[index].ForeColor = Color.Red;
                    }

                    if (Accounting[i] == Accounting.Last())
                    {
                        if (index < listView1.Items.Count)
                        {
                            listView1.Items.RemoveAt(index);
                            int k = listView1.Items.Count;
                            label1.Text = Convert.ToString(k);
                        }
                    }
                

                var t = Task.Delay(700);
                Label label = new Label();
                panel3.Controls.Add(label);
                label.ForeColor = Color.Red;
                label.AutoSize = true;
                label.Font = new Font("Time New Romance", 10);
                label.Location = new Point(36, 16);
                label.Text = Accounting[i];
                t.Wait();
                if (index < listView1.Items.Count)
                {
                    listView1.Items[index].ForeColor = Color.Black;
                }
                label.Dispose();
            }
        }


    }
}

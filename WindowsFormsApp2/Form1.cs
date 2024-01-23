using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            int inputDataVal = 0;
            //int outputDatal = Int32.Parse(outputData.Text);
            object ComboInputVal = comboinput.SelectedItem;
            object ComboOutputVal = combooutput.SelectedItem;
            bool error = false;
            if(ComboInputVal == null)
            { 
            //if(ComboInputVal.ToString() == "Не выбрано!")
            
                MessageBox.Show("Не выбрано входное значение данных!", "Ошибка!");
                error = true;
                return;
            }

            if(ComboOutputVal == null)
            {
                MessageBox.Show("Не выбрано входное значение данных!", "Ошибка!");
                error = true;
            }
            if(InputData.Text.Length > 0)
            {
                inputDataVal = Int32.Parse(InputData.Text);
            }
            else
            {
                InputData.Text = "0";
            }
            if (!error)
            {
                Console.WriteLine(inputDataVal);
                Console.WriteLine(ComboInputVal.ToString());
                Console.WriteLine(ComboOutputVal.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboinput.Items.Add("Выберите ");
            combooutput.Items.Add("Выберите ");
            comboinput.SelectedText = "Выберите";

        }

        private void button1_Resize(object sender, EventArgs e)
        {
           int HeightWindow = this.Size.Height;
           int WidthWindow = this.Size.Width;

            
            groupBox1.Size = new System.Drawing.Size(WidthWindow / 2 - 55, HeightWindow - button1.Size.Height - 81);

            groupBox2.Size = new System.Drawing.Size(WidthWindow / 2 - 55, HeightWindow - button1.Size.Height - 81);

            groupBox2.Location = new Point(WidthWindow / 2, 52);

            button1.Size = new System.Drawing.Size(WidthWindow - 55,button1.Size.Height);

            button1.Location = new Point(38, HeightWindow - button1.Size.Height - 70);

            OutputData.Size = new System.Drawing.Size(groupBox2.Size.Width - 24, OutputData.Size.Height);

            OutputData.Location = new Point(12, groupBox2.Size.Height / 2 - OutputData.Size.Height / 2);

            outputText.Size = new System.Drawing.Size(groupBox1.Size.Width - 24,outputText.Size.Height);

            outputText.Location = new Point(12, groupBox2.Size.Height / 2 - outputText.Size.Height / 2 + OutputData.Size.Height - 25);

        }
    }
}

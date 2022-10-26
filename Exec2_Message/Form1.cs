using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Message
{
    public partial class Form1 : Form
    {
        //Button click 時, 用 Label 顯示目前系統時間及問候語
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //得到輸入名字
            string name = NameTextBox.Text;
            //組合出問候語
            string message = $"Hi, {name}";
            //指派給label
            label1.Text = message;
            //顯示時間
            DateTime datetime = DateTime.Now;
            this.Datelabel.Text = datetime.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
        }
    }
}

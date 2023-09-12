using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Розпочинаємо вивчення основ ООП", "ООП", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Йде собі їжачок лісом. Бачить - стоїть їжачка раком. Ну, їжачок і так до неї, і сяк - не дістає. Побіг, приніс цеглу – знову не дістає. Збігав ще за одним, а їжачка вже пішла. Їжачок: - Не дуже й хотілося...", "Анекдот",MessageBoxButtons.OK,MessageBoxIcon.Question );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new Form1()).Show();   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В інкубаторі, сидів дідок.\r\nПочухав яйця і сказав:\r\n\"Ти хочешь в армію? Во-о-во!\r\nТи, підеш в армію!\" Є-є-а.\r\n \r\nА за горою, пасся петух.\r\nКорова перднула, петух потух.\r\nНе хочу в армію! Во-о-во!\r\nНе піду в армію. Є-є-а.\r\n \r\nЯ пам'ятаю, свое рідне село,\r\nЯк я на тракторі ганяв у кіно.\r\nНе хочу в армію! Во-о-во!\r\nНе піду в армію. Є-є-а.\r\n \r\nЯ пам'ятаю, свое рідне село,\r\nЯк я лопатою черпав ґівно.\r\nНе хочу в армію! Во-о-во!\r\nНе піду в армію. Є-є-а.\r\n \r\nЯ пам'ятаю рідний мопед,\r\nЯк на ньому я зламав хребет.\r\nНе хочу в армію! Во-о-во!\r\nНе піду в армію. Є-є-а.\r\n \r\nА я назбираю мішок гранат,\r\nІ підірву военкомат!\r\nІ підірву його! Во-о-во!\r\nІ підірву його! Є-є-а.\r\n \r\nА в армії є йще один военкомат,\r\nА я назбіраю йще один мішок гранат.\r\nІ підірву його! Во-о-во!\r\nІ підірву його! Є-є-а.", "Не піду в армію", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}

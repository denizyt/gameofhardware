﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deniz
{
    public partial class Test : Form
    {
        Test form5;
        Bitis bitis;
        int dogru = 0;
        int yanlis = 0;
        int basari = 0;
        int bos = 0;
        public string ad, soyad, numara;

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //4 şıktan hiçbiri seçilmedi ise o soru boş bırakılmıştır.
            if(!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked) { bos++; }
            if (!radioButton5.Checked && !radioButton6.Checked && !radioButton7.Checked && !radioButton8.Checked) { bos++; }
            if (!radioButton9.Checked && !radioButton10.Checked && !radioButton11.Checked && !radioButton12.Checked) { bos++; }
            if (!radioButton13.Checked && !radioButton14.Checked && !radioButton15.Checked && !radioButton16.Checked) { bos++; }
            if (!radioButton17.Checked && !radioButton18.Checked && !radioButton19.Checked && !radioButton20.Checked) { bos++; }
            if (!radioButton21.Checked && !radioButton22.Checked && !radioButton23.Checked && !radioButton24.Checked) { bos++; }
            //yanlis cevap secildiyse pictureboxları akti ederek carpi butonu gösteriyoruz.
            if (radioButton1.Checked || radioButton2.Checked || radioButton4.Checked) { pictureBox7.Visible = true; }
            if(radioButton5.Checked || radioButton6.Checked || radioButton7.Checked) { pictureBox8.Visible = true; }
            if(radioButton12.Checked || radioButton9.Checked || radioButton11.Checked) { pictureBox9.Visible = true; }
            if(radioButton16.Checked || radioButton13.Checked || radioButton14.Checked) { pictureBox10.Visible = true; }
            if(radioButton20.Checked || radioButton17.Checked || radioButton19.Checked) { pictureBox11.Visible = true; }
            if(radioButton24.Checked || radioButton21.Checked || radioButton23.Checked) { pictureBox12.Visible = true; }
            //dogru buttonlar seçilirse dogru sayısını bir arttırıyoruz.
            if (radioButton3.Checked) { dogru = dogru + 1; pictureBox1.Visible = true; }
            if (radioButton8.Checked) { dogru = dogru + 1; pictureBox2.Visible = true; }
            if (radioButton10.Checked) { dogru = dogru + 1; pictureBox3.Visible = true; }
            if (radioButton15.Checked) { dogru = dogru + 1; pictureBox4.Visible = true; }
            if (radioButton18.Checked) { dogru = dogru + 1; pictureBox5.Visible = true; }
            if (radioButton22.Checked) { dogru = dogru + 1; pictureBox6.Visible = true; }
            yanlis = 6 - dogru - bos;
            basari = dogru * 16;
            if (dogru == 6) { basari = 100; } //eger hepsi dogru ise 100'e yuvarladik 
            if (dogru <= 3 )//basarisiz olma durumu
            {
                string message = "Testi bir daha çözmeniz gerekmektedir.\n" +
                                 "Doğru Sayınız: " + dogru + "\n"+
                                 "Yanlış Sayınız: " + yanlis + "\n"+ 
                                 "Boş Sayınız: " + bos + "\n" +
                                 "Başarı Oranınız: %" + basari;

                string caption = "Başarısız oldunuz.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                
                // Messagebox gösterilir.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    form5 = new Test();
                    form5.Show();
                    this.Close();
                }
            }
            else if(dogru>3)
            {
                string message = "Tebrikler testi başarıyla tamamladınız.\n" +
                                 "Doğru Sayınız: " + dogru + "\n" +
                                 "Yanlış Sayınız: " + yanlis + "\n" +
                                 "Boş Sayınız: " + bos +"\n" +
                                 "Başarı Oranınız: %" + basari;

                string caption = "Başarılı oldunuz!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Messagebox gösterilir.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)//eger kazandiysa ve tamama tıkladıysa bitis acilir
                {
                    bitis = new Bitis();
                    bitis.Show();
                    this.Close();
                }

            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = "Merhaba, Sayın " + ad + " " + soyad + " sınavınız başlamış bulunmaktadır.";//Text olarak aldığım adı gösteremeye çalıştım.

        }

        public Test()
        {
            InitializeComponent();
            


        }

    }
}

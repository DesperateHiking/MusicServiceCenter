﻿using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Reflection;
using System.Drawing.Imaging;

namespace NewCenter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }  
        private void button1_Click_1(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Фотография|*.jpg" };
            var dr = ofd.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var d = new DescriptionForm() { ProblemDescription = new ProblemDescription() };
            if (d.ShowDialog(this) == DialogResult.OK)
            {
                listBox1.Items.Add(d.ProblemDescription);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is ProblemDescription)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBox1.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                var item = (ProblemDescription)listBox1.Items[index];
                var df = new DescriptionForm() { ProblemDescription = item };
                if (df.ShowDialog(this) == DialogResult.OK)
                {
                    listBox1.Items.Remove(item);
                    listBox1.Items.Insert(index, item);
                }
            }
        }  
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "Заявление|*.application" };

            if (sfd.ShowDialog(this) != DialogResult.OK)
                return;

            var application = new CompletingForm()
            {
                FormName = textBox1.Text,
                Name = textBox2.Text,
                Surname = textBox3.Text,
                Patronymic = textBox4.Text,
                ContactDetails = textBox5.Text,
                ProblemDescription = listBox1.Items.OfType<ProblemDescription>().ToList(),
            };

            var stream = new MemoryStream();
            pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
            application.Photo = stream.ToArray();

            switch (comboBox1.SelectedValue?.ToString())
            {
                case "Струнные":
                    application.InstrumentType = InstrumentType.String;
                    break;
                case "Духовые":
                    application.InstrumentType = InstrumentType.Woodwind;
                    break;
                case "Ударные":
                    application.InstrumentType = InstrumentType.Drum;
                    break;
                case "Клавишные":
                    application.InstrumentType = InstrumentType.Keyboard;
                    break;
                case "Электронные":
                    application.InstrumentType = InstrumentType.Electric;
                    break;
                default:
                    application.InstrumentType = InstrumentType.Electric;
                    break;
            }

            var xs = new XmlSerializer(typeof(CompletingForm));
            var file = File.Create(sfd.FileName);
            xs.Serialize(file, application);
            file.Close();
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Заявление|*.application" };

            if (ofd.ShowDialog(this) != DialogResult.OK)
                return;

            var xs = new XmlSerializer(typeof(CompletingForm));
            var file = File.OpenRead(ofd.FileName);
            var application = (CompletingForm)xs.Deserialize(file);
            file.Close();

            textBox1.Text = application.FormName;
            textBox2.Text = application.Name;
            textBox3.Text = application.Surname;
            textBox4.Text = application.Patronymic;
            textBox5.Text = application.ContactDetails;

            var ms = new MemoryStream(application.Photo);
            pictureBox1.Image = Image.FromStream(ms);

            switch (application.InstrumentType)
            {

                case InstrumentType.String:
                    comboBox1.Text = "Струнные";
                    break;
                case InstrumentType.Woodwind:
                    comboBox1.Text = "Духовые";
                    break;
                case InstrumentType.Drum:
                    comboBox1.Text = "Ударные";
                    break;
                case InstrumentType.Keyboard:
                    comboBox1.Text = "Клавишные";
                    break;
                case InstrumentType.Electric:
                    comboBox1.Text = "Электронные";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            listBox1.Items.Clear();
            foreach (var problems in application.ProblemDescription)
            {
                listBox1.Items.Add(problems);
            }
        }
        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Alert("1. Заполните заявление\n2.Опишите проблему", 1).ShowDialog();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Alert("О программе ''Music Service Center''Music Service Center v. 1.0\n© 2019 Kamberbutch", 0).ShowDialog();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
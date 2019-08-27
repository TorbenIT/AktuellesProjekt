using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace SpanishLearner
{
    public partial class Form1 : Form
    {
        private List<string> quest = new List<string>();

        private List<string> res = new List<string>();

        private int random;

        private int direction;

        private Random r = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            direction = 2; // Spanisch - Deutsch = 2
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();

            OleDbCommand comm = new OleDbCommand();

            OleDbDataReader reader;

            conn.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=E:\\Informatik\\Software\\C#\\Windows Forms\\SpanishLearner\\SpanishLearner\\vocabulary.accdb";
            
            comm.Connection = conn;

            comm.CommandText = "SELECT * FROM vocabel";

            quest.Clear();
            
            res.Clear();

            try
            {
                conn.Open();
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    // question
                    if (direction == 1 || direction == 3 || direction == 5)
                        quest.Add((string)reader["deutsch"]);

                    else if (direction == 2)
                        quest.Add((string)reader["Spanisch"]);

                    else if (direction == 4)
                        quest.Add((string)reader["portugiesisch"]);

                    else
                        quest.Add((string)reader["english"]);

                    // response
                    if (direction == 2 || direction == 4 || direction == 6)
                        res.Add((string)reader["deutsch"]);

                    else if (direction == 1)
                        res.Add((string)reader["spanisch"]);

                    else if (direction == 3)
                        res.Add((string)reader["portugiesisch"]);

                    else
                        res.Add((string)reader["english"]);
                }

                reader.Close();

                conn.Close();

                buttonStart.Enabled = false;

                buttonNext.Enabled = true;

                MenuDirection.Enabled = false;

                textBoxEingabe.Enabled = true;

                ShowNext();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ShowNext()
        {
            if (quest.Count < 1) {
                MessageBox.Show("Gratuliere! Alles geschafft");
                Restart();
            }
            else
            {
                random = r.Next(0, quest.Count);

                labelVokabel.Text = "" + quest[random];

                textBoxEingabe.Text = "";
            }
        }

        private void Restart()
        {
            buttonStart.Enabled = true;

            buttonNext.Enabled = false;

            MenuDirection.Enabled = true;

            textBoxEingabe.Enabled = false;




            labelVokabel.Text = "";

            textBoxEingabe.Text = "";
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (textBoxEingabe.Text == (string)res[random])
            {
                MessageBox.Show("Richtig", "Vokabel");

                quest.RemoveAt(random);

                res.RemoveAt(random);
            }
            else
                MessageBox.Show("Falsch, richtige Antwort" +
                    " ist\n'" + res[random] +
                    "'", "Vokabel");



            ShowNext();
            
        }

        private void testBeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Test wirklich beenden?", "Vokabel",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                Restart();
        }

        private void programmBeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programm wirklich beenden?", "Vokabel",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void deutschSpanischToolStripMenuItem_Click(object sender, EventArgs e)
        {
            direction = 1;

            Ignore();

            deutschSpanischToolStripMenuItem.Checked = true;

            labelAnzeige.Text = "deutsch/spanisch";
        }

        private void spanischDeutschToolStripMenuItem_Click(object sender, EventArgs e)
        {
            direction = 2;

            Ignore();

            spanischDeutschToolStripMenuItem.Checked = true;

            labelAnzeige.Text = "spanisch/deutsch";
        }

        private void deutschPortugiesischToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            direction = 3;

            Ignore();

            deutschPortugiesischToolStripMenuItem.Checked = true;

            labelAnzeige.Text = "deutsch/portugiesisch";
        }

        private void portugiesischDeutschToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            direction = 4;

            Ignore();

            portugiesischDeutschToolStripMenuItem.Checked = true;

            labelAnzeige.Text = "portugiesisch/deutsch";
        }

        private void deutschEnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            direction = 5;

            Ignore();

            deutschEnglishToolStripMenuItem.Checked = true;

            labelAnzeige.Text = "deutsch/english";
        }

        private void englishDeutschToolStripMenuItem_Click(object sender, EventArgs e)
        {
            direction = 6;

            Ignore();

            englishDeutschToolStripMenuItem.Checked = true;

            labelAnzeige.Text = "english/deutsch";
        }

        private void Ignore()
        {
            deutschSpanischToolStripMenuItem.Checked = false;
            spanischDeutschToolStripMenuItem.Checked = false;
            deutschPortugiesischToolStripMenuItem.Checked = false;
            portugiesischDeutschToolStripMenuItem.Checked = false;
            deutschEnglishToolStripMenuItem.Checked = false;
            englishDeutschToolStripMenuItem.Checked = false;
        }

        private void anleitungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs;

            StreamReader sr;

            string file = "hilfe.txt";

            string output;

            if (!File.Exists(file))
            {
                MessageBox.Show("Die Datei " + file +
                    " existiert nicht");
                return;
            }

            fs = new FileStream(file, FileMode.Open);

            sr = new StreamReader(fs);

            output = "";

            while (sr.Peek() != -1)
            {
                output += sr.ReadLine() + "\n";
            }

            sr.Close();



            MessageBox.Show(output);


        }


    }
}

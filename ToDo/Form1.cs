using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            btnSave.Visible = false;
            btnDelete.Visible = false;
        }

        // nou
        private void nouToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files(.txt)|.txt|All Files (.)|.";


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                using (FileStream fs = File.Create(saveFileDialog.FileName))
                {
                    byte[] info = new byte[fs.Length];
                    fs.Write(info, 0, info.Length);
                }
            }
        }

        // open

        private void deschidereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;
                var fileContents = File.ReadAllLines(filePath);
                taskList.Items.Clear();
                taskList.Items.AddRange(fileContents);
            }
        }

        // save

        private void SalvareToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.Title = "Save File";
            saveFileDialog.ShowDialog();

            //daca utilizatorul a selectat un fisier, se salveaza

            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (object item in taskList.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }
            }
        }

        // save as
        private void salvareCaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.Title = "Save File";
            saveFileDialog.ShowDialog();

            //daca utilizatorul a selectat un fisier, se salveaza

            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (object item in taskList.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }
            }
        }

        // exit
        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // add
        private void adaugareSarcinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnDelete.Visible = false;

            //preluare valori din GB
            string numeT = nume.Text;
            string descriereT = descriere.Text;
            DateTime dateT = date.Value;
            string prioritateT = prioritate.SelectedItem.ToString();



            string item = $"{numeT}-{descriereT}-{dateT.ToShortDateString()}-{prioritateT}";

            taskList.Items.Add(item);

            nume.Text = "";
            descriere.Text = "";
            date.Value = DateTime.Now;
            prioritate.Text = null;


        }

        // edit

        private void EditatiSarcinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            btnDelete.Visible = false;
        }

        // delete
        private void stergetiSarcinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnDelete.Visible = true;
        }

        // about

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Informatii despre aplicatie:\n" + "Creata de : Grigore Andreea\n" +
                "Facultatea: IESC\n" + "Specializarea : TI\n" + "Anul de studii: II\n");
        }

        private void selected(object sender, EventArgs e)
        {
            if (taskList.SelectedItem != null)
            {
                string selectedItem = taskList.SelectedItem.ToString();
                string[] values = selectedItem.Split('-');

                if (values.Length == 4)
                {
                    nume.Text = values[0].Trim();
                    descriere.Text = values[1].Trim();
                    date.Value = DateTime.Parse(values[2].Trim());
                    prioritate.SelectedItem = values[3].Trim();

                }
            }

        }

        // delete btn
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (taskList.SelectedIndex != -1)
            {
                taskList.Items.RemoveAt(taskList.SelectedIndex);
            }
            //delete values campuri
            nume.Text = "";
            descriere.Text = "";
            date.Value = DateTime.Now;
            prioritate.Text = null;


        }

        // save edit btn
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (taskList.SelectedItem! != null)
            {
                string selectedItem = taskList.SelectedItem.ToString();
                string[] values = selectedItem.Split('-');

                // creearea modificarilor si salvarea acestora:

                if (values.Length == 4)
                {
                    string numeT = nume.Text;
                    string descriereT = descriere.Text;
                    DateTime dateT = date.Value;
                    string prioritateT = prioritate.SelectedItem.ToString();

                    string newitem = $"{numeT}-{descriereT}-{dateT.ToShortDateString()}-{prioritateT}";


                    int selectedIndex = taskList.SelectedIndex;

                    taskList.Items.RemoveAt(selectedIndex);

                    taskList.Items.Insert(selectedIndex, newitem);
                    nume.Text = "";
                    descriere.Text = "";
                    date.Value = DateTime.Now;
                    prioritate.Text = null;
                }
            }
        }
    }


}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Dictionary<string, string>> subjectGrades = new Dictionary<string, Dictionary<string, string>>();
        private string currentSubject;

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateStudentIDs()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (!dataGridView1.Rows[i].IsNewRow)
                {
                    dataGridView1.Rows[i].Cells["ColumnID"].Value = i + 1;
                }
            }
        }

        private void SyncNames()
        {
            if (currentSubject == null) return;
            // Clear all rows in DataGridView2 before syncing
            dataGridView2.Rows.Clear();

            // Add names from DataGridView1 to DataGridView2, preserving any grades entered
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow) // Skip the new row placeholder
                {
                    string id = row.Cells["ColumnID"].Value?.ToString();
                    string priezvisko = row.Cells["ColumnPriezvisko"].Value?.ToString();
                    string meno = row.Cells["ColumnMeno"].Value?.ToString();
                    string fullName = $"{priezvisko} {meno}";

                    // Find existing grade for this student (if any) using ID
                    string existingGrade = "";
                    if (subjectGrades.ContainsKey(currentSubject) && subjectGrades[currentSubject].ContainsKey(id))
                    {
                        existingGrade = subjectGrades[currentSubject][id]; // Get the existing grade
                    }

                    // Add the student to DataGridView2
                    dataGridView2.Rows.Add(id, priezvisko, meno, existingGrade);
                }
            }
        }

        private void SaveCurrentSubjectGrades()
        {
            // Save grades from DataGridView2 to the dictionary for the current subject
            var grades = new Dictionary<string, string>();

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (!row.IsNewRow)
                {
                    string id = row.Cells["Column2ID"].Value?.ToString();
                    string priezvisko = row.Cells["Column2Priezvisko"].Value?.ToString();
                    string meno = row.Cells["Column2Meno"].Value?.ToString();
                    string grade = row.Cells["Column2Znamka"].Value?.ToString();

                    grades[id] = grade; // Save grade by student ID
                }
            }

            if (currentSubject != null)
            {
                subjectGrades[currentSubject] = grades;
            }
        }

        private void LoadSubjectGrades(string subject)
        {
            if (subjectGrades.ContainsKey(subject))
            {
                var grades = subjectGrades[subject];

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string id = row.Cells["Column2ID"].Value?.ToString();

                        // Set the grade if it exists
                        if (grades.ContainsKey(id))
                        {
                            row.Cells["Column2Znamka"].Value = grades[id];
                        }
                        else
                        {
                            row.Cells["Column2Znamka"].Value = ""; // Default empty grade
                        }
                    }
                }
            }
        }

        private void buttonPridajStudenta_Click(object sender, EventArgs e)
        {
            // Add an empty student row to DataGridView1
            dataGridView1.Rows.Add("", "", "");

            // Reassign IDs automatically
            UpdateStudentIDs();
            SaveCurrentSubjectGrades();
            SyncNames(); // Sync names after adding a student
        }

        private void buttonVymazStudenta_Click(object sender, EventArgs e)
        {
            var aktivnaBunka = dataGridView1.CurrentCell;
            if (aktivnaBunka != null)
            {
                int cisloRiadku = aktivnaBunka.RowIndex;
                dataGridView1.Rows.RemoveAt(cisloRiadku);

                // Reassign IDs automatically after removal
                UpdateStudentIDs();
                SyncNames(); // Sync names after removing a student
            }
        }

        private void buttonPridajPredmet_Click(object sender, EventArgs e)
        {
            string predmet = textBoxPridajPredmet.Text;
            if (!comboBoxSubjects.Items.Contains(predmet))
            {
                comboBoxSubjects.Items.Add(predmet);
                comboBoxVymazPredmet.Items.Add(predmet);
                subjectGrades[predmet] = new Dictionary<string, string>();
            }
            else
            {
                MessageBox.Show("Subject already exists.");
            }

            //currentSubject = predmet;

        }

        private void buttonVymazPredmet_Click(object sender, EventArgs e)
        {
            int index = comboBoxVymazPredmet.SelectedIndex;

            if (index != -1)
            {
                string predmet = comboBoxVymazPredmet.Items[index].ToString();
                comboBoxVymazPredmet.Items.RemoveAt(index);
                comboBoxSubjects.Items.Remove(predmet);

                if (subjectGrades.ContainsKey(predmet))
                {
                    subjectGrades.Remove(predmet);
                }

                if (currentSubject == predmet)
                {
                    currentSubject = null;
                    dataGridView2.Rows.Clear();
                    labelPredmet.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please select a subject to remove.");
            }
        }

        private void comboBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveCurrentSubjectGrades();

            string selectedSubject = comboBoxSubjects.SelectedItem.ToString();
            currentSubject = selectedSubject;

            LoadSubjectGrades(currentSubject);
            SyncNames();
            labelPredmet.Text = currentSubject;
        }
    }
}

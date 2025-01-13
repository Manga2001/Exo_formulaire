using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORML3
{
    public partial class Form1 : Form
    {
        List<Personne> list = new List<Personne>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string prenom=txtPrenom.Text;
            string nom=txtNom.Text;
           MessageBox.Show("Bonjour"+prenom+" "+nom,"Message de Bienvenue",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtprenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Personne personne = new Personne();

            personne.prenom = txtPrenom.Text;
            personne.nom = txtNom.Text;
            personne.tel = txtTel.Text;
            if (rbFemme.Checked)
            {
                personne.sexe = "Femme";
            }else
            {
                personne.sexe = "Homme";
            }

            string tempocomp = "";

            if (ckbJava.Checked)
            {
                tempocomp += "JAVA ";
            }
            if (ckbPhp.Checked)
            {
                tempocomp += "Php ";
            }
            if (ckbCsharp.Checked)
            {
                tempocomp += "C# ";
            }
            if (ckbCplusplus.Checked)
            {
                tempocomp += "C++ ";
            }

            personne.competences = tempocomp;
            personne.classe = cmbClasse.Text;

            // sav data in list

            list.Add(personne);
            MessageBox.Show("Données Ajouter ", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Chargement du Datagrid new

            refresh();
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;

            effacer();
        }
        private void effacer()
        {
            txtNom.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtPrenom.Text = string.Empty;

            rbFemme.Checked = false;
            rbHomme.Checked = false;

            ckbJava.Checked = false;
            ckbPhp.Checked = false;
            ckbCsharp.Checked = false;
            ckbCplusplus.Checked = false;
            cmbClasse.Text = "Selectionner";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            effacer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        Personne personneselected = null;
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < list.Count)
            {
                personneselected = list[e.RowIndex];
                txtNom.Text = personneselected.nom;
                txtPrenom.Text=personneselected.prenom;
                txtTel.Text=personneselected.tel;

                if (personneselected.sexe == "Femme")
                {
                    rbFemme.Checked=true;
                }
                else
                {
                    rbHomme.Checked = true;
                }

                string[] langue = personneselected.competences.Split();

                ckbCplusplus.Checked = langue.Contains("C++");
                ckbJava.Checked = langue.Contains("Java");
                ckbCsharp.Checked = langue.Contains("C#");
                ckbPhp.Checked = langue.Contains("Php");

                cmbClasse.Text=personneselected.classe;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (personneselected==null)
            {
                MessageBox.Show("Verifier que vous avez Selectionner", "Avertissement", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult result = MessageBox.Show("Voulez_vous confirmer la Suppression","Avertissement",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {               
                list.Remove(personneselected);
                 refresh();
                 effacer();
                }
            }
        }

        public void refresh()
        { 
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (personneselected == null)
            {
                MessageBox.Show("Verifier que vous avez Selectionner", "Avertissement", MessageBoxButtons.OK);
            }
            else
            {
                int pos = list.IndexOf(personneselected);
                personneselected.nom=txtNom.Text;
                personneselected.tel=txtTel.Text;
                personneselected.prenom=txtPrenom.Text;

                personneselected.sexe = (rbFemme.Checked) ? "Femme" : "Homme";


                string tempocomp = "";

                if (ckbJava.Checked)
                {
                    tempocomp += "JAVA ";
                }
                if (ckbPhp.Checked)
                {
                    tempocomp += "Php ";
                }
                if (ckbCsharp.Checked)
                {
                    tempocomp += "C# ";
                }
                if (ckbCplusplus.Checked)
                {
                    tempocomp += "C++ ";
                }

                personneselected.competences = tempocomp;
                personneselected.classe = cmbClasse.Text;

                list[pos] = personneselected;
                refresh();
                effacer();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}

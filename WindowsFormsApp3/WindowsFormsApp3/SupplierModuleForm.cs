using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class SupplierModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O7DEG44\SQLEXPRESS;Initial Catalog=Garage;Integrated Security=True;Encrypt=False");
        SqlCommand cm = new SqlCommand();
        public SupplierModuleForm()
        {
            InitializeComponent();
        }

        private void SupplierModuleForm_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            textNomFournisseur.Clear();
            textAdresseFournisseur.Clear();
            textTelephoneFournisseur.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Êtes-vous sûr(e) de vouloir ajouter ce fournisseur?", "Enregistrement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO Fournisseurs(Nom, Adresse, Telephone) VALUES (@Nom, @Adresse, @Telephone)", con);
                    cm.Parameters.AddWithValue("@Nom", textNomFournisseur.Text);
                    cm.Parameters.AddWithValue("@Adresse", textAdresseFournisseur.Text);
                    cm.Parameters.AddWithValue("@Telephone", textTelephoneFournisseur.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Fournisseur ajouté avec succès.");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Êtes-vous sûr(e) de vouloir mettre à jour ce fournisseur?", "Mise à jour", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE Fournisseurs SET Nom=@Nom, Adresse=@Adresse, Telephone=@Telephone WHERE Id=@Id", con);
                    cm.Parameters.AddWithValue("@Nom", textNomFournisseur.Text);
                    cm.Parameters.AddWithValue("@Adresse", textAdresseFournisseur.Text);
                    cm.Parameters.AddWithValue("@Telephone", textTelephoneFournisseur.Text);
                    cm.Parameters.AddWithValue("@Id", labelSupplierId.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Fournisseur mis à jour avec succès.");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

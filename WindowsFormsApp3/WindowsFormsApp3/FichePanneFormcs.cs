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
    public partial class FichePanneFormcs : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O7DEG44\SQLEXPRESS;Initial Catalog=Garage;Integrated Security=True;Encrypt=False");
        public FichePanneFormcs()
        {
            InitializeComponent();
            LoadMatricules();
            LoadReparations();
            LoadPieces();
            dvgReparation.AutoGenerateColumns = false;
            matricule.SelectedIndexChanged += matricule_SelectedIndexChanged;
            reparation.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            piece.SelectedIndexChanged += piece_SelectedIndexChanged;
            dvgReparation.CellContentClick += dvgReparation_CellContentClick;
            dgvPiece.CellContentClick += dgvPiece_CellContentClick;
        }
        private void LoadMatricules()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Matricule FROM Vehicules", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    matricule.Items.Add(reader["Matricule"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors du chargement des matricules : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        private void LoadReparations()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Description FROM Reparations", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    reparation.Items.Add(new KeyValuePair<int, string>((int)reader["Id"], reader["Description"].ToString()));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors du chargement des réparations : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void LoadReparationDetails(int reparationId)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Reparations WHERE Id = @ReparationId", con);
                cmd.Parameters.AddWithValue("@ReparationId", reparationId);
                SqlDataReader reader = cmd.ExecuteReader();

                // Créer une nouvelle DataTable
                DataTable dt = new DataTable();
                dt.Load(reader);

                // Lier la DataTable à la DataGridView
                dvgReparation.DataSource = dt;

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors du chargement des détails de la réparation : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void LoadPieces()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Nom FROM PiecesDetachees", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    piece.Items.Add(new KeyValuePair<int, string>((int)reader["Id"], reader["Nom"].ToString()));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors du chargement des pièces : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void LoadPieceDetails(int pieceId)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PiecesDetachees WHERE Id = @PieceId", con);
                cmd.Parameters.AddWithValue("@PieceId", pieceId);
                SqlDataReader reader = cmd.ExecuteReader();

                // Créer une nouvelle DataTable
                DataTable dt = new DataTable();
                dt.Load(reader);

                // Lier la DataTable à la DataGridView
                dgvPiece.DataSource = dt;

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors du chargement des détails de la pièce : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void matricule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (matricule.SelectedItem != null)
            {
                // Copier le matricule sélectionné dans la TextBox "textmatricule"
                textmatricule.Text = matricule.SelectedItem.ToString();
            }
        }

        private void FichePanneFormcs_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reparation.SelectedItem != null)
            {
              
                dvgReparation.Rows.Clear();

                
                int reparationId = ((KeyValuePair<int, string>)reparation.SelectedItem).Key;

                
                LoadReparationDetails(reparationId);
            }
        }

        private void piece_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (piece.SelectedItem != null)
            {
                // Effacer les lignes existantes dans la DataGridView
                dgvPiece.Rows.Clear();

                // Récupérer l'ID de la pièce sélectionnée
                int pieceId = ((KeyValuePair<int, string>)piece.SelectedItem).Key;

                // Charger les détails de la pièce dans la DataGridView
                LoadPieceDetails(pieceId);
            }
        }

        private void dvgReparation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                object cellValue = dvgReparation.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                MessageBox.Show("La valeur de la cellule est : " + cellValue.ToString(), "Cellule Cliquée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvPiece_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                object cellValue = dgvPiece.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                MessageBox.Show("La valeur de la cellule est : " + cellValue.ToString(), "Cellule Cliquée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textmatricule_TextChanged(object sender, EventArgs e)
        {
            if (matricule.SelectedItem != null)
            {
                // Copier le matricule sélectionné dans la TextBox "textmatricule"
                textmatricule.Text = matricule.SelectedItem.ToString();
            }
        }

        private void matricule_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class LigneReparationForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O7DEG44\SQLEXPRESS;Initial Catalog=Garage;Integrated Security=True;Encrypt=False");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        int qty = 0;
        public LigneReparationForm()
        {
            InitializeComponent();
            LoadReparation();
            LoadPiece();
            LoadLigne();
        }
        // fonction consulte réparation
        public void LoadReparation()
        {
            dvgReparation.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM Reparations", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dvgReparation.Rows.Add(dr["Id"], dr["Description"], dr["Cout"], dr["VehiculeID"], dr["EmployeID"]);
            }
            dr.Close();
            con.Close();
        }
        // fonction consulte piece
        public void LoadPiece()
        {
            dgvPiece.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM PiecesDetachees", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvPiece.Rows.Add(dr["Id"], dr["Nom"], dr["Description"], dr["Prix"], dr["Unite"], dr["FournisseurID"]);
            }
            dr.Close();
            con.Close();
        }
        // fonction consulte ligne reparation
        public void LoadLigne()
        {
            dvgLigne.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM LigneReparation", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dvgLigne.Rows.Add(dr["Id"], dr["ReparationID"], dr["PieceDetacheID"], dr["Prix"]);
            }
            dr.Close();
            con.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textSearchReparation_TextChanged(object sender, EventArgs e)
        {
            LoadReparation();
        }

        private void textSearchPiece_TextChanged(object sender, EventArgs e)
        {
            LoadPiece();
        }

        private void textQuantity_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void CalculateTotal()
        {
            if (dvgReparation.SelectedRows.Count > 0 && dgvPiece.SelectedRows.Count > 0)
            {
                decimal reparationCost = Convert.ToDecimal(dvgReparation.SelectedRows[0].Cells["cout"].Value);
                decimal piecePrice = Convert.ToDecimal(dgvPiece.SelectedRows[0].Cells["price"].Value);
                decimal total = reparationCost + piecePrice;
                textTotal.Text = total.ToString();
            }
        }

        private void dvgReparation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textréparationId.Text = dvgReparation.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                textdescription.Text = dvgReparation.Rows[e.RowIndex].Cells["description"].Value.ToString();
                textcout.Text = dvgReparation.Rows[e.RowIndex].Cells["cout"].Value.ToString();
                textvehicule.Text = dvgReparation.Rows[e.RowIndex].Cells["vehicule_id"].Value.ToString();
                textemployeid.Text = dvgReparation.Rows[e.RowIndex].Cells["employe_id"].Value.ToString();

                CalculateTotal();
            }
        }

        private void dgvPiece_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPiece.Rows.Count)
            {
                textPieceId.Text = dgvPiece.Rows[e.RowIndex].Cells["Id_piece"].Value.ToString();
                textName.Text = dgvPiece.Rows[e.RowIndex].Cells["piece_name"].Value.ToString();
                textdescript.Text = dgvPiece.Rows[e.RowIndex].Cells["piece_description"].Value.ToString();
                textPrice.Text = dgvPiece.Rows[e.RowIndex].Cells["price"].Value.ToString();
                textUnite.Text = dgvPiece.Rows[e.RowIndex].Cells["unite"].Value.ToString();
                textfournisseurid.Text = dgvPiece.Rows[e.RowIndex].Cells["fournisseur_id"].Value.ToString();


                CalculateTotal();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textréparationId.Text == "" || textPieceId.Text == "")
                {
                    MessageBox.Show("Veuillez sélectionner une réparation et une pièce détachée.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                int reparationId = Convert.ToInt32(textréparationId.Text);
                int pieceId = Convert.ToInt32(textPieceId.Text);


                decimal piecePrice = Convert.ToDecimal(textPrice.Text);


                decimal total = piecePrice + Convert.ToDecimal(textcout.Text);

                if (MessageBox.Show("Voulez-vous ajouter cette ligne de réparation ?", "Enregistrement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O7DEG44\SQLEXPRESS;Initial Catalog=Garage;Integrated Security=True;Encrypt=False"))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO LigneReparation (ReparationID, PieceDetacheID, Prix) VALUES (@ReparationID, @PieceDetacheID, @Prix)", con);
                        cmd.Parameters.AddWithValue("@ReparationID", reparationId);
                        cmd.Parameters.AddWithValue("@PieceDetacheID", pieceId);
                        cmd.Parameters.AddWithValue("@Prix", total);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Ligne de réparation enregistrée avec succès.");

                    Clear();
                    LoadPiece();
                    LoadLigne(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void Clear()
        {
            textréparationId.Clear();
            textdescription.Clear();
            textcout.Clear();
            textvehicule.Clear();
            textemployeid.Clear();
            textPieceId.Clear();
            textName.Clear();
            textPrice.Clear();
            textUnite.Clear();
            textfournisseurid.Clear();
            textTotal.Clear();

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textréparationId.Text == "" || textPieceId.Text == "")
                {
                    MessageBox.Show("Veuillez sélectionner une réparation et une pièce détachée.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Récupérer l'ID de réparation et de pièce détachée
                int reparationId = Convert.ToInt32(textréparationId.Text);
                int pieceId = Convert.ToInt32(textPieceId.Text);

                // Récupérer le prix de la pièce détachée
                decimal piecePrice = Convert.ToDecimal(textPrice.Text);

                // Calculer le prix total
                decimal total = piecePrice + Convert.ToDecimal(textcout.Text);

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE LigneReparation SET ReparationID = @ReparationID, PieceDetacheID = @PieceDetacheID, Prix = @Prix WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@ReparationID", reparationId);
                cmd.Parameters.AddWithValue("@PieceDetacheID", pieceId);
                cmd.Parameters.AddWithValue("@Prix", total);
                cmd.Parameters.AddWithValue("@Id", selectedLigneReparationId); // Utilisez l'ID de la ligne sélectionnée
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Mise à jour de la ligne de réparation a été complétée avec succès!");
                LoadLigne();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void LigneReparationForm_Load(object sender, EventArgs e)
        {

        }

        private void textTotal_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void textTotal_Click(object sender, EventArgs e)
        {
            

        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void LoadReparationData(int reparationId)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Reparations WHERE Id = @ReparationId", con);
                cmd.Parameters.AddWithValue("@ReparationId", reparationId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textréparationId.Text = reader["Id"].ToString();
                    textdescription.Text = reader["Description"].ToString();
                    textcout.Text = reader["Cout"].ToString();
                    textvehicule.Text = reader["VehiculeID"].ToString();
                    textemployeid.Text = reader["EmployeID"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void LoadPieceData(int pieceId)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PiecesDetachees WHERE Id = @PieceId", con);
                cmd.Parameters.AddWithValue("@PieceId", pieceId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textPieceId.Text = reader["Id"].ToString();
                    textName.Text = reader["Nom"].ToString();
                    textdescript.Text = reader["Description"].ToString();
                    textPrice.Text = reader["Prix"].ToString();
                    textUnite.Text = reader["Unite"].ToString();
                    textfournisseurid.Text = reader["FournisseurID"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void dvgLigne_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
          
                // Afficher un message d'erreur générique à l'utilisateur
                MessageBox.Show("Une erreur est survenue lors de l'affichage des données. Veuillez vérifier les données saisies.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Annuler la propagation de l'exception pour éviter l'affichage de la boîte de dialogue par défaut
                e.Cancel = true;
            
        }
        private int selectedLigneReparationId;
        private void dvgLigne_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedLigneReparationId = Convert.ToInt32(dvgLigne.Rows[e.RowIndex].Cells["ligne_id"].Value); // Mettez à jour l'ID de la ligne sélectionnée
                int reparationId = Convert.ToInt32(dvgLigne.Rows[e.RowIndex].Cells["ReparationID"].Value);
                int pieceId = Convert.ToInt32(dvgLigne.Rows[e.RowIndex].Cells["PieceDetacheID"].Value);

                LoadReparationData(reparationId);
                LoadPieceData(pieceId);
            }
        }

        private void textcout_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void textPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void dvgLigne_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dvgLigne.Columns["Delete"].Index) // Vérifier si le clic est sur le bouton "Supprimer"
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cette ligne de réparation ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int ligneReparationId = Convert.ToInt32(dvgLigne.Rows[e.RowIndex].Cells["ligne_id"].Value);
                    DeleteLigneReparation(ligneReparationId);
                }
            }
        }
        private void DeleteLigneReparation(int ligneReparationId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O7DEG44\SQLEXPRESS;Initial Catalog=Garage;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM LigneReparation WHERE Id = @Id", con);
                    cmd.Parameters.AddWithValue("@Id", ligneReparationId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Ligne de réparation supprimée avec succès.");
                LoadLigne(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la suppression de la ligne de réparation : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
    

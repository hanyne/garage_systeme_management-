namespace WindowsFormsApp3
{
    partial class FichePanneFormcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FichePanneFormcs));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvgReparation = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicule_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employe_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reparation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPiece = new System.Windows.Forms.DataGridView();
            this.Id_piece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piece_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piece_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fournisseur_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.piece = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bntajouteclient = new System.Windows.Forms.Button();
            this.matricule = new System.Windows.Forms.ComboBox();
            this.textmatricule = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgReparation)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiece)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvgReparation);
            this.groupBox1.Controls.Add(this.reparation);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(31, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 362);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panne";
            // 
            // dvgReparation
            // 
            this.dvgReparation.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.dvgReparation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dvgReparation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgReparation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgReparation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dvgReparation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgReparation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.description,
            this.cout,
            this.vehicule_id,
            this.employe_id});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgReparation.DefaultCellStyle = dataGridViewCellStyle11;
            this.dvgReparation.EnableHeadersVisualStyles = false;
            this.dvgReparation.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dvgReparation.Location = new System.Drawing.Point(6, 60);
            this.dvgReparation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgReparation.Name = "dvgReparation";
            this.dvgReparation.RowHeadersVisible = false;
            this.dvgReparation.RowHeadersWidth = 51;
            this.dvgReparation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgReparation.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dvgReparation.RowTemplate.Height = 24;
            this.dvgReparation.Size = new System.Drawing.Size(564, 293);
            this.dvgReparation.TabIndex = 48;
            this.dvgReparation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgReparation_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            // 
            // cout
            // 
            this.cout.HeaderText = "Cout";
            this.cout.MinimumWidth = 6;
            this.cout.Name = "cout";
            // 
            // vehicule_id
            // 
            this.vehicule_id.HeaderText = "VehiculeID";
            this.vehicule_id.MinimumWidth = 6;
            this.vehicule_id.Name = "vehicule_id";
            // 
            // employe_id
            // 
            this.employe_id.HeaderText = "ID Employe";
            this.employe_id.MinimumWidth = 6;
            this.employe_id.Name = "employe_id";
            // 
            // reparation
            // 
            this.reparation.FormattingEnabled = true;
            this.reparation.Location = new System.Drawing.Point(6, 23);
            this.reparation.Name = "reparation";
            this.reparation.Size = new System.Drawing.Size(168, 33);
            this.reparation.TabIndex = 6;
            this.reparation.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(111, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matricule";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Navy;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(550, 683);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 39);
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPiece);
            this.groupBox2.Controls.Add(this.quantity);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.piece);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(647, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 362);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Piece";
            // 
            // dgvPiece
            // 
            this.dgvPiece.AllowUserToAddRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.dgvPiece.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvPiece.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPiece.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPiece.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPiece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPiece.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_piece,
            this.piece_name,
            this.piece_description,
            this.price,
            this.unite,
            this.fournisseur_id});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPiece.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPiece.EnableHeadersVisualStyles = false;
            this.dgvPiece.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvPiece.Location = new System.Drawing.Point(-3, 60);
            this.dgvPiece.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPiece.Name = "dgvPiece";
            this.dgvPiece.RowHeadersVisible = false;
            this.dgvPiece.RowHeadersWidth = 51;
            this.dgvPiece.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPiece.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvPiece.RowTemplate.Height = 24;
            this.dgvPiece.Size = new System.Drawing.Size(614, 293);
            this.dgvPiece.TabIndex = 49;
            this.dgvPiece.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPiece_CellContentClick);
            // 
            // Id_piece
            // 
            this.Id_piece.HeaderText = "ID";
            this.Id_piece.MinimumWidth = 6;
            this.Id_piece.Name = "Id_piece";
            // 
            // piece_name
            // 
            this.piece_name.HeaderText = "Nom";
            this.piece_name.MinimumWidth = 6;
            this.piece_name.Name = "piece_name";
            // 
            // piece_description
            // 
            this.piece_description.HeaderText = "Description";
            this.piece_description.MinimumWidth = 6;
            this.piece_description.Name = "piece_description";
            // 
            // price
            // 
            this.price.HeaderText = "Prix";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            // 
            // unite
            // 
            this.unite.HeaderText = "Unite";
            this.unite.MinimumWidth = 6;
            this.unite.Name = "unite";
            // 
            // fournisseur_id
            // 
            this.fournisseur_id.HeaderText = "fournisseur_id";
            this.fournisseur_id.MinimumWidth = 6;
            this.fournisseur_id.Name = "fournisseur_id";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(379, 25);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(186, 30);
            this.quantity.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "Quantité ";
            // 
            // piece
            // 
            this.piece.FormattingEnabled = true;
            this.piece.Location = new System.Drawing.Point(6, 22);
            this.piece.Name = "piece";
            this.piece.Size = new System.Drawing.Size(206, 33);
            this.piece.TabIndex = 6;
            this.piece.SelectedIndexChanged += new System.EventHandler(this.piece_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel2.Location = new System.Drawing.Point(95, 173);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 2);
            this.panel2.TabIndex = 70;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Location = new System.Drawing.Point(85, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 2);
            this.panel1.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(76, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 52);
            this.label3.TabIndex = 74;
            this.label3.Text = "Fiche de Panne";
            // 
            // bntajouteclient
            // 
            this.bntajouteclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.bntajouteclient.FlatAppearance.BorderSize = 0;
            this.bntajouteclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntajouteclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntajouteclient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bntajouteclient.Image = ((System.Drawing.Image)(resources.GetObject("bntajouteclient.Image")));
            this.bntajouteclient.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bntajouteclient.Location = new System.Drawing.Point(799, 20);
            this.bntajouteclient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntajouteclient.Name = "bntajouteclient";
            this.bntajouteclient.Size = new System.Drawing.Size(317, 62);
            this.bntajouteclient.TabIndex = 68;
            this.bntajouteclient.Text = "Ajouter";
            this.bntajouteclient.UseVisualStyleBackColor = false;
            // 
            // matricule
            // 
            this.matricule.FormattingEnabled = true;
            this.matricule.Location = new System.Drawing.Point(217, 128);
            this.matricule.Name = "matricule";
            this.matricule.Size = new System.Drawing.Size(168, 24);
            this.matricule.TabIndex = 49;
            this.matricule.SelectedIndexChanged += new System.EventHandler(this.matricule_SelectedIndexChanged_1);
            // 
            // textmatricule
            // 
            this.textmatricule.Location = new System.Drawing.Point(431, 128);
            this.textmatricule.Name = "textmatricule";
            this.textmatricule.Size = new System.Drawing.Size(186, 22);
            this.textmatricule.TabIndex = 75;
            this.textmatricule.TextChanged += new System.EventHandler(this.textmatricule_TextChanged);
            // 
            // FichePanneFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 746);
            this.Controls.Add(this.textmatricule);
            this.Controls.Add(this.matricule);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bntajouteclient);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FichePanneFormcs";
            this.Text = "FichePanneFormcs";
            this.Load += new System.EventHandler(this.FichePanneFormcs_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgReparation)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox reparation;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox piece;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.DataGridView dvgReparation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn cout;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicule_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn employe_id;
        private System.Windows.Forms.DataGridView dgvPiece;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_piece;
        private System.Windows.Forms.DataGridViewTextBoxColumn piece_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn piece_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn unite;
        private System.Windows.Forms.DataGridViewTextBoxColumn fournisseur_id;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntajouteclient;
        private System.Windows.Forms.ComboBox matricule;
        private System.Windows.Forms.TextBox textmatricule;
    }
}
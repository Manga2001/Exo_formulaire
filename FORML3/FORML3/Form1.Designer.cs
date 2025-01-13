namespace FORML3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbHomme = new System.Windows.Forms.RadioButton();
            this.rbFemme = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.ckbJava = new System.Windows.Forms.CheckBox();
            this.ckbCplusplus = new System.Windows.Forms.CheckBox();
            this.ckbPhp = new System.Windows.Forms.CheckBox();
            this.ckbCsharp = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(122, 25);
            this.txtPrenom.Multiline = true;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(144, 22);
            this.txtPrenom.TabIndex = 3;
            this.txtPrenom.TextChanged += new System.EventHandler(this.txtprenom_TextChanged);
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNom.Location = new System.Drawing.Point(122, 76);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(144, 24);
            this.txtNom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tel";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTel.Location = new System.Drawing.Point(122, 126);
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(144, 23);
            this.txtTel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sexe";
            // 
            // rbHomme
            // 
            this.rbHomme.AutoSize = true;
            this.rbHomme.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rbHomme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbHomme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHomme.Location = new System.Drawing.Point(122, 182);
            this.rbHomme.Name = "rbHomme";
            this.rbHomme.Size = new System.Drawing.Size(93, 22);
            this.rbHomme.TabIndex = 10;
            this.rbHomme.TabStop = true;
            this.rbHomme.Text = "HOMME";
            this.rbHomme.UseVisualStyleBackColor = false;
            // 
            // rbFemme
            // 
            this.rbFemme.AutoSize = true;
            this.rbFemme.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rbFemme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFemme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemme.Location = new System.Drawing.Point(240, 182);
            this.rbFemme.Name = "rbFemme";
            this.rbFemme.Size = new System.Drawing.Size(89, 22);
            this.rbFemme.TabIndex = 11;
            this.rbFemme.TabStop = true;
            this.rbFemme.Text = "FEMME";
            this.rbFemme.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Competence";
            // 
            // ckbJava
            // 
            this.ckbJava.AutoSize = true;
            this.ckbJava.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ckbJava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbJava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbJava.Location = new System.Drawing.Point(171, 260);
            this.ckbJava.Name = "ckbJava";
            this.ckbJava.Size = new System.Drawing.Size(65, 22);
            this.ckbJava.TabIndex = 13;
            this.ckbJava.Text = "Java";
            this.ckbJava.UseVisualStyleBackColor = false;
            // 
            // ckbCplusplus
            // 
            this.ckbCplusplus.AutoSize = true;
            this.ckbCplusplus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ckbCplusplus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbCplusplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCplusplus.Location = new System.Drawing.Point(315, 327);
            this.ckbCplusplus.Name = "ckbCplusplus";
            this.ckbCplusplus.Size = new System.Drawing.Size(62, 22);
            this.ckbCplusplus.TabIndex = 14;
            this.ckbCplusplus.Text = "C++";
            this.ckbCplusplus.UseVisualStyleBackColor = false;
            // 
            // ckbPhp
            // 
            this.ckbPhp.AutoSize = true;
            this.ckbPhp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ckbPhp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbPhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPhp.Location = new System.Drawing.Point(315, 258);
            this.ckbPhp.Name = "ckbPhp";
            this.ckbPhp.Size = new System.Drawing.Size(59, 22);
            this.ckbPhp.TabIndex = 15;
            this.ckbPhp.Text = "Php";
            this.ckbPhp.UseVisualStyleBackColor = false;
            // 
            // ckbCsharp
            // 
            this.ckbCsharp.AutoSize = true;
            this.ckbCsharp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ckbCsharp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbCsharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCsharp.Location = new System.Drawing.Point(171, 327);
            this.ckbCsharp.Name = "ckbCsharp";
            this.ckbCsharp.Size = new System.Drawing.Size(51, 22);
            this.ckbCsharp.TabIndex = 16;
            this.ckbCsharp.Text = "C#";
            this.ckbCsharp.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Classe";
            // 
            // cmbClasse
            // 
            this.cmbClasse.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmbClasse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Items.AddRange(new object[] {
            "L3 IAGE",
            "L3 GL",
            "L3 MULTIMEDIA",
            "L3 GESTION",
            "L3 RI"});
            this.cmbClasse.Location = new System.Drawing.Point(122, 387);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(144, 26);
            this.cmbClasse.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(391, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(709, 388);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Yellow;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(27, 466);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 32);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MistyRose;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1000, 466);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 32);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Cyan;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(823, 466);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 32);
            this.btnOpen.TabIndex = 22;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Chocolate;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(470, 466);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 32);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(315, 466);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 32);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lime;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(166, 466);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 32);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 518);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ckbCsharp);
            this.Controls.Add(this.ckbPhp);
            this.Controls.Add(this.ckbCplusplus);
            this.Controls.Add(this.ckbJava);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbFemme);
            this.Controls.Add(this.rbHomme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "L3 IAGE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbHomme;
        private System.Windows.Forms.RadioButton rbFemme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckbJava;
        private System.Windows.Forms.CheckBox ckbCplusplus;
        private System.Windows.Forms.CheckBox ckbPhp;
        private System.Windows.Forms.CheckBox ckbCsharp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}


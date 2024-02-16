namespace wfa_hobby
{
    partial class ajouterEtudiantForm
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
            humourNumericUpDown = new NumericUpDown();
            humourLabel = new Label();
            prenomTextBox = new TextBox();
            nomLabel = new Label();
            nomTextBox = new TextBox();
            prenomLabel = new Label();
            ajouterButton = new Button();
            provenanceComboBox = new ComboBox();
            provenanceLabel = new Label();
            cellulaireTextBox = new TextBox();
            cellulaireLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)humourNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // humourNumericUpDown
            // 
            humourNumericUpDown.Font = new Font("Segoe UI", 13.8F);
            humourNumericUpDown.Location = new Point(274, 228);
            humourNumericUpDown.Name = "humourNumericUpDown";
            humourNumericUpDown.Size = new Size(260, 38);
            humourNumericUpDown.TabIndex = 17;
            // 
            // humourLabel
            // 
            humourLabel.AutoSize = true;
            humourLabel.Font = new Font("Segoe UI", 13.8F);
            humourLabel.Location = new Point(70, 230);
            humourLabel.Name = "humourLabel";
            humourLabel.Size = new Size(181, 31);
            humourLabel.TabIndex = 16;
            humourLabel.Text = "Degré d'humour";
            // 
            // prenomTextBox
            // 
            prenomTextBox.Font = new Font("Segoe UI", 13.8F);
            prenomTextBox.Location = new Point(276, 41);
            prenomTextBox.Name = "prenomTextBox";
            prenomTextBox.Size = new Size(260, 38);
            prenomTextBox.TabIndex = 13;
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Font = new Font("Segoe UI", 13.8F);
            nomLabel.Location = new Point(70, 102);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new Size(64, 31);
            nomLabel.TabIndex = 12;
            nomLabel.Text = "Nom";
            // 
            // nomTextBox
            // 
            nomTextBox.Font = new Font("Segoe UI", 13.8F);
            nomTextBox.Location = new Point(276, 102);
            nomTextBox.Name = "nomTextBox";
            nomTextBox.Size = new Size(260, 38);
            nomTextBox.TabIndex = 11;
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Font = new Font("Segoe UI", 13.8F);
            prenomLabel.Location = new Point(70, 41);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new Size(93, 31);
            prenomLabel.TabIndex = 10;
            prenomLabel.Text = "Prénom";
            // 
            // ajouterButton
            // 
            ajouterButton.Font = new Font("Segoe UI", 13.8F);
            ajouterButton.Location = new Point(274, 356);
            ajouterButton.Name = "ajouterButton";
            ajouterButton.Size = new Size(260, 43);
            ajouterButton.TabIndex = 9;
            ajouterButton.Text = "Ajouter";
            ajouterButton.UseVisualStyleBackColor = true;
            ajouterButton.Click += ajouterButton_Click;
            // 
            // provenanceComboBox
            // 
            provenanceComboBox.Font = new Font("Segoe UI", 12F);
            provenanceComboBox.FormattingEnabled = true;
            provenanceComboBox.Location = new Point(274, 295);
            provenanceComboBox.Name = "provenanceComboBox";
            provenanceComboBox.Size = new Size(260, 36);
            provenanceComboBox.TabIndex = 19;
            // 
            // provenanceLabel
            // 
            provenanceLabel.AutoSize = true;
            provenanceLabel.Font = new Font("Segoe UI", 13.8F);
            provenanceLabel.Location = new Point(70, 295);
            provenanceLabel.Name = "provenanceLabel";
            provenanceLabel.Size = new Size(132, 31);
            provenanceLabel.TabIndex = 20;
            provenanceLabel.Text = "Provenance";
            // 
            // cellulaireTextBox
            // 
            cellulaireTextBox.Font = new Font("Segoe UI", 13.8F);
            cellulaireTextBox.Location = new Point(274, 165);
            cellulaireTextBox.Margin = new Padding(4);
            cellulaireTextBox.Name = "cellulaireTextBox";
            cellulaireTextBox.Size = new Size(260, 38);
            cellulaireTextBox.TabIndex = 22;
            // 
            // cellulaireLabel
            // 
            cellulaireLabel.AutoSize = true;
            cellulaireLabel.Font = new Font("Segoe UI", 13.8F);
            cellulaireLabel.Location = new Point(70, 172);
            cellulaireLabel.Margin = new Padding(4, 0, 4, 0);
            cellulaireLabel.Name = "cellulaireLabel";
            cellulaireLabel.Size = new Size(109, 31);
            cellulaireLabel.TabIndex = 21;
            cellulaireLabel.Text = "Cellulaire";
            // 
            // ajouterEtudiantForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 432);
            Controls.Add(cellulaireTextBox);
            Controls.Add(cellulaireLabel);
            Controls.Add(provenanceLabel);
            Controls.Add(provenanceComboBox);
            Controls.Add(humourNumericUpDown);
            Controls.Add(humourLabel);
            Controls.Add(prenomTextBox);
            Controls.Add(nomLabel);
            Controls.Add(nomTextBox);
            Controls.Add(prenomLabel);
            Controls.Add(ajouterButton);
            Name = "ajouterEtudiantForm";
            Text = "Ajouter un étudiant";
            Load += ajouterEtudiantForm_Load;
            ((System.ComponentModel.ISupportInitialize)humourNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown humourNumericUpDown;
        private Label humourLabel;
        private TextBox prenomTextBox;
        private Label nomLabel;
        private TextBox nomTextBox;
        private Label prenomLabel;
        private Button ajouterButton;
        private ComboBox provenanceComboBox;
        private Label provenanceLabel;
        private TextBox cellulaireTextBox;
        private Label cellulaireLabel;
    }
}
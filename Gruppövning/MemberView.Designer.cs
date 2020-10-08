namespace Gruppövning
{
    partial class MemberView
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
            this.cmdShowRecipesLogin = new System.Windows.Forms.Button();
            this.cboTypeRecipe = new System.Windows.Forms.ComboBox();
            this.cmdSearchLogin = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtSearchRecipe = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdAddRecipe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdShowRecipesLogin
            // 
            this.cmdShowRecipesLogin.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdShowRecipesLogin.Location = new System.Drawing.Point(30, 372);
            this.cmdShowRecipesLogin.Name = "cmdShowRecipesLogin";
            this.cmdShowRecipesLogin.Size = new System.Drawing.Size(107, 35);
            this.cmdShowRecipesLogin.TabIndex = 12;
            this.cmdShowRecipesLogin.Text = "Visa";
            this.cmdShowRecipesLogin.UseVisualStyleBackColor = true;
            // 
            // cboTypeRecipe
            // 
            this.cboTypeRecipe.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTypeRecipe.FormattingEnabled = true;
            this.cboTypeRecipe.Location = new System.Drawing.Point(30, 37);
            this.cboTypeRecipe.Name = "cboTypeRecipe";
            this.cboTypeRecipe.Size = new System.Drawing.Size(121, 21);
            this.cboTypeRecipe.TabIndex = 11;
            // 
            // cmdSearchLogin
            // 
            this.cmdSearchLogin.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSearchLogin.Location = new System.Drawing.Point(240, 73);
            this.cmdSearchLogin.Name = "cmdSearchLogin";
            this.cmdSearchLogin.Size = new System.Drawing.Size(100, 23);
            this.cmdSearchLogin.TabIndex = 10;
            this.cmdSearchLogin.Text = "Sök";
            this.cmdSearchLogin.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(406, 225);
            this.listBox1.TabIndex = 9;
            // 
            // txtSearchRecipe
            // 
            this.txtSearchRecipe.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRecipe.Location = new System.Drawing.Point(30, 73);
            this.txtSearchRecipe.Name = "txtSearchRecipe";
            this.txtSearchRecipe.Size = new System.Drawing.Size(188, 22);
            this.txtSearchRecipe.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdAddRecipe);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 410);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sök recept";
            // 
            // cmdAddRecipe
            // 
            this.cmdAddRecipe.Location = new System.Drawing.Point(140, 360);
            this.cmdAddRecipe.Name = "cmdAddRecipe";
            this.cmdAddRecipe.Size = new System.Drawing.Size(107, 35);
            this.cmdAddRecipe.TabIndex = 15;
            this.cmdAddRecipe.Text = "Lägg till";
            this.cmdAddRecipe.UseVisualStyleBackColor = true;
            // 
            // MedlemsVy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 443);
            this.Controls.Add(this.cmdShowRecipesLogin);
            this.Controls.Add(this.cboTypeRecipe);
            this.Controls.Add(this.cmdSearchLogin);
            this.Controls.Add(this.txtSearchRecipe);
            this.Controls.Add(this.groupBox1);
            this.Name = "MedlemsVy";
            this.Text = "InloggadVy";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdShowRecipesLogin;
        private System.Windows.Forms.ComboBox cboTypeRecipe;
        private System.Windows.Forms.Button cmdSearchLogin;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtSearchRecipe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdAddRecipe;
    }
}
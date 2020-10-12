namespace Gruppövning
{
    partial class SearchRecipe
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
            this.cmdLogin = new System.Windows.Forms.Button();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.cboRecipeType = new System.Windows.Forms.ComboBox();
            this.cmdShowRecipes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdAddRecipe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdLogin
            // 
            this.cmdLogin.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.Location = new System.Drawing.Point(471, 17);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(66, 23);
            this.cmdLogin.TabIndex = 0;
            this.cmdLogin.Text = "Logga in";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // txtSearchText
            // 
            this.txtSearchText.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchText.Location = new System.Drawing.Point(30, 73);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(188, 22);
            this.txtSearchText.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(406, 225);
            this.listBox1.TabIndex = 2;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSearch.Location = new System.Drawing.Point(240, 73);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(100, 23);
            this.cmdSearch.TabIndex = 3;
            this.cmdSearch.Text = "Sök";
            this.cmdSearch.UseVisualStyleBackColor = true;
            // 
            // cboRecipeType
            // 
            this.cboRecipeType.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRecipeType.FormattingEnabled = true;
            this.cboRecipeType.Location = new System.Drawing.Point(30, 37);
            this.cboRecipeType.Name = "cboRecipeType";
            this.cboRecipeType.Size = new System.Drawing.Size(121, 21);
            this.cboRecipeType.TabIndex = 4;
            // 
            // cmdShowRecipes
            // 
            this.cmdShowRecipes.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdShowRecipes.Location = new System.Drawing.Point(30, 379);
            this.cmdShowRecipes.Name = "cmdShowRecipes";
            this.cmdShowRecipes.Size = new System.Drawing.Size(100, 28);
            this.cmdShowRecipes.TabIndex = 5;
            this.cmdShowRecipes.Text = "Visa";
            this.cmdShowRecipes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdAddRecipe);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 410);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sök recept";
            // 
            // cmdAddRecipe
            // 
            this.cmdAddRecipe.Location = new System.Drawing.Point(138, 367);
            this.cmdAddRecipe.Name = "cmdAddRecipe";
            this.cmdAddRecipe.Size = new System.Drawing.Size(97, 28);
            this.cmdAddRecipe.TabIndex = 16;
            this.cmdAddRecipe.Text = "Lägg till";
            this.cmdAddRecipe.UseVisualStyleBackColor = true;
            // 
            // SearchRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 452);
            this.Controls.Add(this.cmdShowRecipes);
            this.Controls.Add(this.cboRecipeType);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchRecipe";
            this.Text = "Search Recipe";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.ComboBox cboRecipeType;
        private System.Windows.Forms.Button cmdShowRecipes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdAddRecipe;
    }
}


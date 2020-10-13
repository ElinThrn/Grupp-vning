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
            this.lstRecipe = new System.Windows.Forms.ListBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.cboRecipeType = new System.Windows.Forms.ComboBox();
            this.cmdEditRecipes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdAddRecipe = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdLogin
            // 
            this.cmdLogin.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.Location = new System.Drawing.Point(628, 21);
            this.cmdLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(88, 28);
            this.cmdLogin.TabIndex = 0;
            this.cmdLogin.Text = "Logga in";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // txtSearchText
            // 
            this.txtSearchText.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchText.Location = new System.Drawing.Point(40, 90);
            this.txtSearchText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(249, 26);
            this.txtSearchText.TabIndex = 1;
            // 
            // lstRecipe
            // 
            this.lstRecipe.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecipe.FormattingEnabled = true;
            this.lstRecipe.ItemHeight = 19;
            this.lstRecipe.Location = new System.Drawing.Point(40, 171);
            this.lstRecipe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstRecipe.Name = "lstRecipe";
            this.lstRecipe.Size = new System.Drawing.Size(540, 270);
            this.lstRecipe.TabIndex = 2;
            this.lstRecipe.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstRecipe_MouseDoubleClick);
            // 
            // cmdSearch
            // 
            this.cmdSearch.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSearch.Location = new System.Drawing.Point(320, 90);
            this.cmdSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(133, 28);
            this.cmdSearch.TabIndex = 3;
            this.cmdSearch.Text = "Sök";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // cboRecipeType
            // 
            this.cboRecipeType.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRecipeType.FormattingEnabled = true;
            this.cboRecipeType.Location = new System.Drawing.Point(40, 45);
            this.cboRecipeType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboRecipeType.Name = "cboRecipeType";
            this.cboRecipeType.Size = new System.Drawing.Size(160, 27);
            this.cboRecipeType.TabIndex = 4;
            // 
            // cmdEditRecipes
            // 
            this.cmdEditRecipes.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEditRecipes.Location = new System.Drawing.Point(40, 467);
            this.cmdEditRecipes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdEditRecipes.Name = "cmdEditRecipes";
            this.cmdEditRecipes.Size = new System.Drawing.Size(133, 35);
            this.cmdEditRecipes.TabIndex = 5;
            this.cmdEditRecipes.Text = "Redigera";
            this.cmdEditRecipes.UseVisualStyleBackColor = true;
            this.cmdEditRecipes.Click += new System.EventHandler(this.cmdEditRecipes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdAdd);
            this.groupBox1.Controls.Add(this.cmdAddRecipe);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(604, 504);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sök recept";
            // 
            // cmdAddRecipe
            // 
            this.cmdAddRecipe.Location = new System.Drawing.Point(92, 235);
            this.cmdAddRecipe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdAddRecipe.Name = "cmdAddRecipe";
            this.cmdAddRecipe.Size = new System.Drawing.Size(65, 18);
            this.cmdAddRecipe.TabIndex = 16;
            this.cmdAddRecipe.Text = "Lägg till";
            this.cmdAddRecipe.UseVisualStyleBackColor = true;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.Location = new System.Drawing.Point(177, 452);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(133, 35);
            this.cmdAdd.TabIndex = 7;
            this.cmdAdd.Text = "Lägg till";
            this.cmdAdd.UseVisualStyleBackColor = true;
            // 
            // SearchRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 556);
            this.Controls.Add(this.cmdEditRecipes);
            this.Controls.Add(this.cboRecipeType);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.lstRecipe);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchRecipe";
            this.Text = "Search Recipe";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.ListBox lstRecipe;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.ComboBox cboRecipeType;
        private System.Windows.Forms.Button cmdEditRecipes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdAddRecipe;
        private System.Windows.Forms.Button cmdAdd;
    }
}


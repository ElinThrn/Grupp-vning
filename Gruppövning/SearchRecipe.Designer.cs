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
            this.cmdShowRecipes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // cmdLogin
            // 
            this.cmdLogin.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.Location = new System.Drawing.Point(942, 33);
            this.cmdLogin.Margin = new System.Windows.Forms.Padding(6);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(132, 44);
            this.cmdLogin.TabIndex = 0;
            this.cmdLogin.Text = "Logga in";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // txtSearchText
            // 
            this.txtSearchText.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchText.Location = new System.Drawing.Point(60, 140);
            this.txtSearchText.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(372, 37);
            this.txtSearchText.TabIndex = 1;
            // 
            // lstRecipe
            // 
            this.lstRecipe.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecipe.FormattingEnabled = true;
            this.lstRecipe.ItemHeight = 30;
            this.lstRecipe.Location = new System.Drawing.Point(60, 267);
            this.lstRecipe.Margin = new System.Windows.Forms.Padding(6);
            this.lstRecipe.Name = "lstRecipe";
            this.lstRecipe.Size = new System.Drawing.Size(808, 424);
            this.lstRecipe.TabIndex = 2;
            this.lstRecipe.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstRecipe_MouseDoubleClick);
            // 
            // cmdSearch
            // 
            this.cmdSearch.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSearch.Location = new System.Drawing.Point(480, 140);
            this.cmdSearch.Margin = new System.Windows.Forms.Padding(6);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(200, 44);
            this.cmdSearch.TabIndex = 3;
            this.cmdSearch.Text = "Sök";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // cboRecipeType
            // 
            this.cboRecipeType.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRecipeType.FormattingEnabled = true;
            this.cboRecipeType.Location = new System.Drawing.Point(60, 71);
            this.cboRecipeType.Margin = new System.Windows.Forms.Padding(6);
            this.cboRecipeType.Name = "cboRecipeType";
            this.cboRecipeType.Size = new System.Drawing.Size(238, 38);
            this.cboRecipeType.TabIndex = 4;
            // 
            // cmdShowRecipes
            // 
            this.cmdShowRecipes.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdShowRecipes.Location = new System.Drawing.Point(60, 729);
            this.cmdShowRecipes.Margin = new System.Windows.Forms.Padding(6);
            this.cmdShowRecipes.Name = "cmdShowRecipes";
            this.cmdShowRecipes.Size = new System.Drawing.Size(200, 54);
            this.cmdShowRecipes.TabIndex = 5;
            this.cmdShowRecipes.Text = "Visa";
            this.cmdShowRecipes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(906, 788);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sök recept";
            // 
            // SearchRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 869);
            this.Controls.Add(this.cmdShowRecipes);
            this.Controls.Add(this.cboRecipeType);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.lstRecipe);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SearchRecipe";
            this.Text = "Sök recept";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.ListBox lstRecipe;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.ComboBox cboRecipeType;
        private System.Windows.Forms.Button cmdShowRecipes;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


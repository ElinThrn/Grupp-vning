namespace Gruppövning
{
    partial class EditRecipe
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
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.txtRecipeInfo = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdSaveRecipe = new System.Windows.Forms.Button();
            this.cmdDeleteRecipe = new System.Windows.Forms.Button();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.txtIngredientMeasure = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdAddIngredient = new System.Windows.Forms.Button();
            this.cmdDeleteIngredient = new System.Windows.Forms.Button();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipeName.Location = new System.Drawing.Point(67, 43);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(421, 26);
            this.txtRecipeName.TabIndex = 0;
            // 
            // txtRecipeInfo
            // 
            this.txtRecipeInfo.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipeInfo.Location = new System.Drawing.Point(67, 110);
            this.txtRecipeInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRecipeInfo.Multiline = true;
            this.txtRecipeInfo.Name = "txtRecipeInfo";
            this.txtRecipeInfo.Size = new System.Drawing.Size(421, 128);
            this.txtRecipeInfo.TabIndex = 1;
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(67, 302);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(421, 27);
            this.cboCategory.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Namn på receptet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Beskrivning";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 267);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Välj en kategori";
            // 
            // cmdSaveRecipe
            // 
            this.cmdSaveRecipe.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSaveRecipe.Location = new System.Drawing.Point(532, 485);
            this.cmdSaveRecipe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSaveRecipe.Name = "cmdSaveRecipe";
            this.cmdSaveRecipe.Size = new System.Drawing.Size(179, 52);
            this.cmdSaveRecipe.TabIndex = 10;
            this.cmdSaveRecipe.Text = "Spara";
            this.cmdSaveRecipe.UseVisualStyleBackColor = true;
            this.cmdSaveRecipe.Click += new System.EventHandler(this.cmdAddRecipe_Click);
            // 
            // cmdDeleteRecipe
            // 
            this.cmdDeleteRecipe.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeleteRecipe.Location = new System.Drawing.Point(760, 485);
            this.cmdDeleteRecipe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdDeleteRecipe.Name = "cmdDeleteRecipe";
            this.cmdDeleteRecipe.Size = new System.Drawing.Size(179, 52);
            this.cmdDeleteRecipe.TabIndex = 11;
            this.cmdDeleteRecipe.Text = "Ta bort recept";
            this.cmdDeleteRecipe.UseVisualStyleBackColor = true;
            // 
            // txtIngredient
            // 
            this.txtIngredient.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredient.Location = new System.Drawing.Point(528, 43);
            this.txtIngredient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(421, 26);
            this.txtIngredient.TabIndex = 12;
            // 
            // txtIngredientMeasure
            // 
            this.txtIngredientMeasure.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredientMeasure.Location = new System.Drawing.Point(528, 106);
            this.txtIngredientMeasure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIngredientMeasure.Name = "txtIngredientMeasure";
            this.txtIngredientMeasure.Size = new System.Drawing.Size(421, 26);
            this.txtIngredientMeasure.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(528, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ingrediens";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(528, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mått";
            // 
            // cmdAddIngredient
            // 
            this.cmdAddIngredient.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddIngredient.Location = new System.Drawing.Point(532, 140);
            this.cmdAddIngredient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAddIngredient.Name = "cmdAddIngredient";
            this.cmdAddIngredient.Size = new System.Drawing.Size(100, 28);
            this.cmdAddIngredient.TabIndex = 16;
            this.cmdAddIngredient.Text = "Lägg till";
            this.cmdAddIngredient.UseVisualStyleBackColor = true;
            this.cmdAddIngredient.Click += new System.EventHandler(this.cmdAddIngredient_Click);
            // 
            // cmdDeleteIngredient
            // 
            this.cmdDeleteIngredient.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeleteIngredient.Location = new System.Drawing.Point(640, 140);
            this.cmdDeleteIngredient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdDeleteIngredient.Name = "cmdDeleteIngredient";
            this.cmdDeleteIngredient.Size = new System.Drawing.Size(103, 28);
            this.cmdDeleteIngredient.TabIndex = 18;
            this.cmdDeleteIngredient.Text = "Ta bort";
            this.cmdDeleteIngredient.UseVisualStyleBackColor = true;
            this.cmdDeleteIngredient.Click += new System.EventHandler(this.cmdDeleteIngredient_Click);
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.ItemHeight = 16;
            this.lstIngredients.Location = new System.Drawing.Point(532, 197);
            this.lstIngredients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(417, 244);
            this.lstIngredients.TabIndex = 19;
            // 
            // EditRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 572);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.cmdDeleteIngredient);
            this.Controls.Add(this.cmdAddIngredient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIngredientMeasure);
            this.Controls.Add(this.txtIngredient);
            this.Controls.Add(this.cmdDeleteRecipe);
            this.Controls.Add(this.cmdSaveRecipe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.txtRecipeInfo);
            this.Controls.Add(this.txtRecipeName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditRecipe";
            this.Text = "Redigera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.TextBox txtRecipeInfo;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdSaveRecipe;
        private System.Windows.Forms.Button cmdDeleteRecipe;
        private System.Windows.Forms.TextBox txtIngredient;
        private System.Windows.Forms.TextBox txtIngredientMeasure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdAddIngredient;
        private System.Windows.Forms.Button cmdDeleteIngredient;
        private System.Windows.Forms.ListBox lstIngredients;
    }
}
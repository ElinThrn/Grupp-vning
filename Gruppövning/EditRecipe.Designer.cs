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
            this.cboKitchen = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboRecipeMethod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdAddRecipe = new System.Windows.Forms.Button();
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
            this.txtRecipeName.Location = new System.Drawing.Point(49, 35);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(317, 22);
            this.txtRecipeName.TabIndex = 0;
            // 
            // txtRecipeInfo
            // 
            this.txtRecipeInfo.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipeInfo.Location = new System.Drawing.Point(49, 89);
            this.txtRecipeInfo.Multiline = true;
            this.txtRecipeInfo.Name = "txtRecipeInfo";
            this.txtRecipeInfo.Size = new System.Drawing.Size(317, 105);
            this.txtRecipeInfo.TabIndex = 1;
            // 
            // cboKitchen
            // 
            this.cboKitchen.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKitchen.FormattingEnabled = true;
            this.cboKitchen.Location = new System.Drawing.Point(49, 234);
            this.cboKitchen.Name = "cboKitchen";
            this.cboKitchen.Size = new System.Drawing.Size(317, 21);
            this.cboKitchen.TabIndex = 2;
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(49, 285);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(317, 21);
            this.cboCategory.TabIndex = 3;
            // 
            // cboRecipeMethod
            // 
            this.cboRecipeMethod.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRecipeMethod.FormattingEnabled = true;
            this.cboRecipeMethod.Location = new System.Drawing.Point(49, 336);
            this.cboRecipeMethod.Name = "cboRecipeMethod";
            this.cboRecipeMethod.Size = new System.Drawing.Size(317, 21);
            this.cboRecipeMethod.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Namn på receptet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Beskrivning";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Välj ett kök";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Välj en kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Välj tillagningssätt";
            // 
            // cmdAddRecipe
            // 
            this.cmdAddRecipe.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddRecipe.Location = new System.Drawing.Point(49, 402);
            this.cmdAddRecipe.Name = "cmdAddRecipe";
            this.cmdAddRecipe.Size = new System.Drawing.Size(146, 42);
            this.cmdAddRecipe.TabIndex = 10;
            this.cmdAddRecipe.Text = "Lägg till recept";
            this.cmdAddRecipe.UseVisualStyleBackColor = true;
            this.cmdAddRecipe.Click += new System.EventHandler(this.cmdAddRecipe_Click);
            // 
            // cmdDeleteRecipe
            // 
            this.cmdDeleteRecipe.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeleteRecipe.Location = new System.Drawing.Point(220, 402);
            this.cmdDeleteRecipe.Name = "cmdDeleteRecipe";
            this.cmdDeleteRecipe.Size = new System.Drawing.Size(146, 42);
            this.cmdDeleteRecipe.TabIndex = 11;
            this.cmdDeleteRecipe.Text = "Ta bort recept";
            this.cmdDeleteRecipe.UseVisualStyleBackColor = true;
            // 
            // txtIngredient
            // 
            this.txtIngredient.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredient.Location = new System.Drawing.Point(396, 35);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(317, 22);
            this.txtIngredient.TabIndex = 12;
            // 
            // txtIngredientMeasure
            // 
            this.txtIngredientMeasure.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredientMeasure.Location = new System.Drawing.Point(396, 86);
            this.txtIngredientMeasure.Name = "txtIngredientMeasure";
            this.txtIngredientMeasure.Size = new System.Drawing.Size(317, 22);
            this.txtIngredientMeasure.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ingrediens";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(396, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mått";
            // 
            // cmdAddIngredient
            // 
            this.cmdAddIngredient.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddIngredient.Location = new System.Drawing.Point(399, 114);
            this.cmdAddIngredient.Name = "cmdAddIngredient";
            this.cmdAddIngredient.Size = new System.Drawing.Size(75, 23);
            this.cmdAddIngredient.TabIndex = 16;
            this.cmdAddIngredient.Text = "Lägg till";
            this.cmdAddIngredient.UseVisualStyleBackColor = true;
            this.cmdAddIngredient.Click += new System.EventHandler(this.cmdAddIngredient_Click);
            // 
            // cmdDeleteIngredient
            // 
            this.cmdDeleteIngredient.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeleteIngredient.Location = new System.Drawing.Point(480, 114);
            this.cmdDeleteIngredient.Name = "cmdDeleteIngredient";
            this.cmdDeleteIngredient.Size = new System.Drawing.Size(77, 23);
            this.cmdDeleteIngredient.TabIndex = 18;
            this.cmdDeleteIngredient.Text = "Ta bort";
            this.cmdDeleteIngredient.UseVisualStyleBackColor = true;
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.Location = new System.Drawing.Point(399, 160);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(314, 199);
            this.lstIngredients.TabIndex = 19;
            // 
            // EditRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 465);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.cmdDeleteIngredient);
            this.Controls.Add(this.cmdAddIngredient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIngredientMeasure);
            this.Controls.Add(this.txtIngredient);
            this.Controls.Add(this.cmdDeleteRecipe);
            this.Controls.Add(this.cmdAddRecipe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboRecipeMethod);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.cboKitchen);
            this.Controls.Add(this.txtRecipeInfo);
            this.Controls.Add(this.txtRecipeName);
            this.Name = "EditRecipe";
            this.Text = "Redigera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.TextBox txtRecipeInfo;
        private System.Windows.Forms.ComboBox cboKitchen;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboRecipeMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdAddRecipe;
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
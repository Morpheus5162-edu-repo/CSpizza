
namespace CSpizza
{
    partial class Pizza
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
            this.GbPizza = new System.Windows.Forms.GroupBox();
            this.RdPromo = new System.Windows.Forms.RadioButton();
            this.RdSpecial = new System.Windows.Forms.RadioButton();
            this.Rddeluxe = new System.Windows.Forms.RadioButton();
            this.GbIngredients = new System.Windows.Forms.GroupBox();
            this.Ckbtomato = new System.Windows.Forms.CheckBox();
            this.CkbOnions = new System.Windows.Forms.CheckBox();
            this.Ckbmushroom = new System.Windows.Forms.CheckBox();
            this.Ckbbaconham = new System.Windows.Forms.CheckBox();
            this.Ckbpepper = new System.Windows.Forms.CheckBox();
            this.Ckbcheese = new System.Windows.Forms.CheckBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.TxtBill = new System.Windows.Forms.TextBox();
            this.LblBill = new System.Windows.Forms.Label();
            this.GbPizza.SuspendLayout();
            this.GbIngredients.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbPizza
            // 
            this.GbPizza.Controls.Add(this.RdPromo);
            this.GbPizza.Controls.Add(this.RdSpecial);
            this.GbPizza.Controls.Add(this.Rddeluxe);
            this.GbPizza.Location = new System.Drawing.Point(21, 24);
            this.GbPizza.Name = "GbPizza";
            this.GbPizza.Size = new System.Drawing.Size(135, 100);
            this.GbPizza.TabIndex = 0;
            this.GbPizza.TabStop = false;
            this.GbPizza.Text = "Pizza";
            // 
            // RdPromo
            // 
            this.RdPromo.AutoSize = true;
            this.RdPromo.Location = new System.Drawing.Point(22, 68);
            this.RdPromo.Name = "RdPromo";
            this.RdPromo.Size = new System.Drawing.Size(55, 17);
            this.RdPromo.TabIndex = 2;
            this.RdPromo.Text = "Promo";
            this.RdPromo.UseVisualStyleBackColor = true;
            this.RdPromo.CheckedChanged += new System.EventHandler(this.RdPromo_CheckedChanged);
            // 
            // RdSpecial
            // 
            this.RdSpecial.AutoSize = true;
            this.RdSpecial.Location = new System.Drawing.Point(22, 44);
            this.RdSpecial.Name = "RdSpecial";
            this.RdSpecial.Size = new System.Drawing.Size(60, 17);
            this.RdSpecial.TabIndex = 1;
            this.RdSpecial.Text = "Special";
            this.RdSpecial.UseVisualStyleBackColor = true;
            this.RdSpecial.CheckedChanged += new System.EventHandler(this.RdSpecial_CheckedChanged);
            // 
            // Rddeluxe
            // 
            this.Rddeluxe.AutoSize = true;
            this.Rddeluxe.Location = new System.Drawing.Point(22, 20);
            this.Rddeluxe.Name = "Rddeluxe";
            this.Rddeluxe.Size = new System.Drawing.Size(58, 17);
            this.Rddeluxe.TabIndex = 0;
            this.Rddeluxe.Text = "Deluxe";
            this.Rddeluxe.UseVisualStyleBackColor = true;
            this.Rddeluxe.CheckedChanged += new System.EventHandler(this.Rddeluxe_CheckedChanged);
            // 
            // GbIngredients
            // 
            this.GbIngredients.Controls.Add(this.Ckbtomato);
            this.GbIngredients.Controls.Add(this.CkbOnions);
            this.GbIngredients.Controls.Add(this.Ckbmushroom);
            this.GbIngredients.Controls.Add(this.Ckbbaconham);
            this.GbIngredients.Controls.Add(this.Ckbpepper);
            this.GbIngredients.Controls.Add(this.Ckbcheese);
            this.GbIngredients.Location = new System.Drawing.Point(192, 24);
            this.GbIngredients.Name = "GbIngredients";
            this.GbIngredients.Size = new System.Drawing.Size(233, 174);
            this.GbIngredients.TabIndex = 1;
            this.GbIngredients.TabStop = false;
            this.GbIngredients.Text = "Ingredients";
            // 
            // Ckbtomato
            // 
            this.Ckbtomato.AutoSize = true;
            this.Ckbtomato.Location = new System.Drawing.Point(36, 135);
            this.Ckbtomato.Name = "Ckbtomato";
            this.Ckbtomato.Size = new System.Drawing.Size(62, 17);
            this.Ckbtomato.TabIndex = 5;
            this.Ckbtomato.Text = "Tomato";
            this.Ckbtomato.UseVisualStyleBackColor = true;
            // 
            // CkbOnions
            // 
            this.CkbOnions.AutoSize = true;
            this.CkbOnions.Location = new System.Drawing.Point(36, 112);
            this.CkbOnions.Name = "CkbOnions";
            this.CkbOnions.Size = new System.Drawing.Size(59, 17);
            this.CkbOnions.TabIndex = 4;
            this.CkbOnions.Text = "Onions";
            this.CkbOnions.UseVisualStyleBackColor = true;
            // 
            // Ckbmushroom
            // 
            this.Ckbmushroom.AutoSize = true;
            this.Ckbmushroom.Location = new System.Drawing.Point(36, 89);
            this.Ckbmushroom.Name = "Ckbmushroom";
            this.Ckbmushroom.Size = new System.Drawing.Size(80, 17);
            this.Ckbmushroom.TabIndex = 3;
            this.Ckbmushroom.Text = "Mushrooms";
            this.Ckbmushroom.UseVisualStyleBackColor = true;
            // 
            // Ckbbaconham
            // 
            this.Ckbbaconham.AutoSize = true;
            this.Ckbbaconham.Location = new System.Drawing.Point(36, 66);
            this.Ckbbaconham.Name = "Ckbbaconham";
            this.Ckbbaconham.Size = new System.Drawing.Size(91, 17);
            this.Ckbbaconham.TabIndex = 2;
            this.Ckbbaconham.Text = "Bacon && Ham";
            this.Ckbbaconham.UseVisualStyleBackColor = true;
            // 
            // Ckbpepper
            // 
            this.Ckbpepper.AutoSize = true;
            this.Ckbpepper.Location = new System.Drawing.Point(36, 43);
            this.Ckbpepper.Name = "Ckbpepper";
            this.Ckbpepper.Size = new System.Drawing.Size(60, 17);
            this.Ckbpepper.TabIndex = 1;
            this.Ckbpepper.Text = "Pepper";
            this.Ckbpepper.UseVisualStyleBackColor = true;
            // 
            // Ckbcheese
            // 
            this.Ckbcheese.AutoSize = true;
            this.Ckbcheese.Location = new System.Drawing.Point(36, 20);
            this.Ckbcheese.Name = "Ckbcheese";
            this.Ckbcheese.Size = new System.Drawing.Size(62, 17);
            this.Ckbcheese.TabIndex = 0;
            this.Ckbcheese.Text = "Cheese";
            this.Ckbcheese.UseVisualStyleBackColor = true;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Location = new System.Drawing.Point(21, 131);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(31, 13);
            this.LblPrice.TabIndex = 2;
            this.LblPrice.Text = "Price";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(21, 148);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(135, 20);
            this.TxtPrice.TabIndex = 3;
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(21, 191);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(135, 20);
            this.TxtQuantity.TabIndex = 5;
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Location = new System.Drawing.Point(21, 174);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(46, 13);
            this.LblQuantity.TabIndex = 4;
            this.LblQuantity.Text = "Quantity";
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.LightGray;
            this.btnCompute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompute.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompute.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCompute.Location = new System.Drawing.Point(43, 233);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(86, 23);
            this.btnCompute.TabIndex = 6;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // TxtBill
            // 
            this.TxtBill.Location = new System.Drawing.Point(192, 235);
            this.TxtBill.Name = "TxtBill";
            this.TxtBill.Size = new System.Drawing.Size(135, 20);
            this.TxtBill.TabIndex = 8;
            // 
            // LblBill
            // 
            this.LblBill.AutoSize = true;
            this.LblBill.Location = new System.Drawing.Point(192, 218);
            this.LblBill.Name = "LblBill";
            this.LblBill.Size = new System.Drawing.Size(20, 13);
            this.LblBill.TabIndex = 7;
            this.LblBill.Text = "Bill";
            // 
            // Pizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 291);
            this.Controls.Add(this.TxtBill);
            this.Controls.Add(this.LblBill);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.GbIngredients);
            this.Controls.Add(this.GbPizza);
            this.Name = "Pizza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza";
            this.GbPizza.ResumeLayout(false);
            this.GbPizza.PerformLayout();
            this.GbIngredients.ResumeLayout(false);
            this.GbIngredients.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbPizza;
        private System.Windows.Forms.RadioButton RdPromo;
        private System.Windows.Forms.RadioButton RdSpecial;
        private System.Windows.Forms.RadioButton Rddeluxe;
        private System.Windows.Forms.GroupBox GbIngredients;
        private System.Windows.Forms.CheckBox Ckbtomato;
        private System.Windows.Forms.CheckBox CkbOnions;
        private System.Windows.Forms.CheckBox Ckbmushroom;
        private System.Windows.Forms.CheckBox Ckbbaconham;
        private System.Windows.Forms.CheckBox Ckbpepper;
        private System.Windows.Forms.CheckBox Ckbcheese;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox TxtBill;
        private System.Windows.Forms.Label LblBill;
    }
}


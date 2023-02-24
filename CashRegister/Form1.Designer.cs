namespace CashRegister
{
    partial class HappyLittleFrogShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HappyLittleFrogShop));
            this.titleLabel = new System.Windows.Forms.Label();
            this.frogsLabel = new System.Windows.Forms.Label();
            this.toadsLabel = new System.Windows.Forms.Label();
            this.lilypadsLabel = new System.Windows.Forms.Label();
            this.frogsInput = new System.Windows.Forms.TextBox();
            this.toadsInput = new System.Windows.Forms.TextBox();
            this.lilypadsInput = new System.Windows.Forms.TextBox();
            this.totalsButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.verticalDividerLabel = new System.Windows.Forms.Label();
            this.receiptTitleLabel = new System.Windows.Forms.Label();
            this.receiptbutton = new System.Windows.Forms.Button();
            this.receiptOrderedLabel = new System.Windows.Forms.Label();
            this.receiptPricesLabel = new System.Windows.Forms.Label();
            this.receiptEndLabel = new System.Windows.Forms.Label();
            this.receiptTotalsLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.goodbyeLabel = new System.Windows.Forms.Label();
            this.frogPicturebox = new System.Windows.Forms.PictureBox();
            this.totalsErrorLabel = new System.Windows.Forms.Label();
            this.changeErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frogPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.titleLabel.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(1, -2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(801, 51);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "The Happy Frog Shop";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frogsLabel
            // 
            this.frogsLabel.AutoSize = true;
            this.frogsLabel.Font = new System.Drawing.Font("Garamond", 13F);
            this.frogsLabel.Location = new System.Drawing.Point(34, 71);
            this.frogsLabel.Name = "frogsLabel";
            this.frogsLabel.Size = new System.Drawing.Size(138, 21);
            this.frogsLabel.TabIndex = 1;
            this.frogsLabel.Text = "Number of Frogs:";
            // 
            // toadsLabel
            // 
            this.toadsLabel.AutoSize = true;
            this.toadsLabel.Font = new System.Drawing.Font("Garamond", 13F);
            this.toadsLabel.Location = new System.Drawing.Point(34, 104);
            this.toadsLabel.Name = "toadsLabel";
            this.toadsLabel.Size = new System.Drawing.Size(141, 21);
            this.toadsLabel.TabIndex = 2;
            this.toadsLabel.Text = "Number of Toads:";
            // 
            // lilypadsLabel
            // 
            this.lilypadsLabel.AutoSize = true;
            this.lilypadsLabel.Font = new System.Drawing.Font("Garamond", 13F);
            this.lilypadsLabel.Location = new System.Drawing.Point(34, 138);
            this.lilypadsLabel.Name = "lilypadsLabel";
            this.lilypadsLabel.Size = new System.Drawing.Size(157, 21);
            this.lilypadsLabel.TabIndex = 3;
            this.lilypadsLabel.Text = "Number of Lilypads:";
            // 
            // frogsInput
            // 
            this.frogsInput.Location = new System.Drawing.Point(198, 71);
            this.frogsInput.Name = "frogsInput";
            this.frogsInput.Size = new System.Drawing.Size(100, 20);
            this.frogsInput.TabIndex = 4;
            // 
            // toadsInput
            // 
            this.toadsInput.Location = new System.Drawing.Point(198, 105);
            this.toadsInput.Name = "toadsInput";
            this.toadsInput.Size = new System.Drawing.Size(100, 20);
            this.toadsInput.TabIndex = 5;
            // 
            // lilypadsInput
            // 
            this.lilypadsInput.Location = new System.Drawing.Point(197, 139);
            this.lilypadsInput.Name = "lilypadsInput";
            this.lilypadsInput.Size = new System.Drawing.Size(100, 20);
            this.lilypadsInput.TabIndex = 6;
            // 
            // totalsButton
            // 
            this.totalsButton.BackColor = System.Drawing.Color.LimeGreen;
            this.totalsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.totalsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.totalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalsButton.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsButton.Location = new System.Drawing.Point(38, 165);
            this.totalsButton.Name = "totalsButton";
            this.totalsButton.Size = new System.Drawing.Size(259, 46);
            this.totalsButton.TabIndex = 7;
            this.totalsButton.Text = "Calculate Totals";
            this.totalsButton.UseVisualStyleBackColor = false;
            this.totalsButton.Click += new System.EventHandler(this.totalsButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Garamond", 13F);
            this.subtotalLabel.Location = new System.Drawing.Point(34, 214);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(72, 21);
            this.subtotalLabel.TabIndex = 8;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Garamond", 13F);
            this.taxLabel.Location = new System.Drawing.Point(37, 252);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(48, 21);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "HST:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Garamond", 13F);
            this.totalLabel.Location = new System.Drawing.Point(37, 287);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(51, 21);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total:";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.Color.Gold;
            this.subtotalOutput.Font = new System.Drawing.Font("Garamond", 12F);
            this.subtotalOutput.Location = new System.Drawing.Point(195, 215);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(100, 20);
            this.subtotalOutput.TabIndex = 11;
            this.subtotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.Gold;
            this.taxOutput.Font = new System.Drawing.Font("Garamond", 12F);
            this.taxOutput.Location = new System.Drawing.Point(194, 252);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(100, 20);
            this.taxOutput.TabIndex = 12;
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.Color.Gold;
            this.totalOutput.Font = new System.Drawing.Font("Garamond", 12F);
            this.totalOutput.Location = new System.Drawing.Point(194, 287);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(100, 20);
            this.totalOutput.TabIndex = 13;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dividerLabel
            // 
            this.dividerLabel.BackColor = System.Drawing.Color.Black;
            this.dividerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Bold);
            this.dividerLabel.Location = new System.Drawing.Point(-2, 318);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(326, 2);
            this.dividerLabel.TabIndex = 14;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Garamond", 13F);
            this.tenderedLabel.Location = new System.Drawing.Point(34, 329);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(82, 21);
            this.tenderedLabel.TabIndex = 15;
            this.tenderedLabel.Text = "Tendered:";
            this.tenderedLabel.Visible = false;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(197, 329);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(100, 20);
            this.tenderedInput.TabIndex = 16;
            this.tenderedInput.Visible = false;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.LimeGreen;
            this.changeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(38, 355);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(256, 46);
            this.changeButton.TabIndex = 17;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Visible = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Garamond", 13F);
            this.changeLabel.Location = new System.Drawing.Point(34, 420);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(66, 21);
            this.changeLabel.TabIndex = 18;
            this.changeLabel.Text = "Change:";
            this.changeLabel.Visible = false;
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.Color.Gold;
            this.changeOutput.Font = new System.Drawing.Font("Garamond", 12F);
            this.changeOutput.Location = new System.Drawing.Point(194, 420);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(100, 20);
            this.changeOutput.TabIndex = 19;
            this.changeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // verticalDividerLabel
            // 
            this.verticalDividerLabel.BackColor = System.Drawing.Color.Black;
            this.verticalDividerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verticalDividerLabel.Location = new System.Drawing.Point(322, 49);
            this.verticalDividerLabel.Name = "verticalDividerLabel";
            this.verticalDividerLabel.Size = new System.Drawing.Size(2, 2000);
            this.verticalDividerLabel.TabIndex = 20;
            // 
            // receiptTitleLabel
            // 
            this.receiptTitleLabel.BackColor = System.Drawing.Color.White;
            this.receiptTitleLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline);
            this.receiptTitleLabel.Location = new System.Drawing.Point(330, 138);
            this.receiptTitleLabel.Name = "receiptTitleLabel";
            this.receiptTitleLabel.Size = new System.Drawing.Size(297, 64);
            this.receiptTitleLabel.TabIndex = 21;
            this.receiptTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.receiptTitleLabel.Visible = false;
            // 
            // receiptbutton
            // 
            this.receiptbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.receiptbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.receiptbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.receiptbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptbutton.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptbutton.Location = new System.Drawing.Point(330, 71);
            this.receiptbutton.Name = "receiptbutton";
            this.receiptbutton.Size = new System.Drawing.Size(297, 46);
            this.receiptbutton.TabIndex = 22;
            this.receiptbutton.Text = "Print Receipt";
            this.receiptbutton.UseVisualStyleBackColor = false;
            this.receiptbutton.Visible = false;
            this.receiptbutton.Click += new System.EventHandler(this.receiptbutton_Click);
            // 
            // receiptOrderedLabel
            // 
            this.receiptOrderedLabel.BackColor = System.Drawing.Color.White;
            this.receiptOrderedLabel.Font = new System.Drawing.Font("Courier New", 12F);
            this.receiptOrderedLabel.Location = new System.Drawing.Point(330, 202);
            this.receiptOrderedLabel.Name = "receiptOrderedLabel";
            this.receiptOrderedLabel.Size = new System.Drawing.Size(188, 108);
            this.receiptOrderedLabel.TabIndex = 23;
            this.receiptOrderedLabel.Visible = false;
            // 
            // receiptPricesLabel
            // 
            this.receiptPricesLabel.BackColor = System.Drawing.Color.White;
            this.receiptPricesLabel.Font = new System.Drawing.Font("Courier New", 12F);
            this.receiptPricesLabel.Location = new System.Drawing.Point(514, 202);
            this.receiptPricesLabel.Name = "receiptPricesLabel";
            this.receiptPricesLabel.Size = new System.Drawing.Size(113, 108);
            this.receiptPricesLabel.TabIndex = 24;
            this.receiptPricesLabel.Visible = false;
            // 
            // receiptEndLabel
            // 
            this.receiptEndLabel.BackColor = System.Drawing.Color.White;
            this.receiptEndLabel.Font = new System.Drawing.Font("Courier New", 12F);
            this.receiptEndLabel.Location = new System.Drawing.Point(330, 310);
            this.receiptEndLabel.Name = "receiptEndLabel";
            this.receiptEndLabel.Size = new System.Drawing.Size(188, 118);
            this.receiptEndLabel.TabIndex = 25;
            this.receiptEndLabel.Visible = false;
            // 
            // receiptTotalsLabel
            // 
            this.receiptTotalsLabel.BackColor = System.Drawing.Color.White;
            this.receiptTotalsLabel.Font = new System.Drawing.Font("Courier New", 12F);
            this.receiptTotalsLabel.Location = new System.Drawing.Point(514, 310);
            this.receiptTotalsLabel.Name = "receiptTotalsLabel";
            this.receiptTotalsLabel.Size = new System.Drawing.Size(113, 120);
            this.receiptTotalsLabel.TabIndex = 26;
            this.receiptTotalsLabel.Visible = false;
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.LimeGreen;
            this.newOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(640, 382);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(148, 46);
            this.newOrderButton.TabIndex = 27;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Visible = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // goodbyeLabel
            // 
            this.goodbyeLabel.Font = new System.Drawing.Font("Garamond", 17F);
            this.goodbyeLabel.Location = new System.Drawing.Point(640, 223);
            this.goodbyeLabel.Name = "goodbyeLabel";
            this.goodbyeLabel.Size = new System.Drawing.Size(148, 127);
            this.goodbyeLabel.TabIndex = 29;
            this.goodbyeLabel.Text = "Thank You For Shopping At The Happy Frog Shop! :)";
            this.goodbyeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.goodbyeLabel.Visible = false;
            // 
            // frogPicturebox
            // 
            this.frogPicturebox.Image = global::CashRegister.Properties.Resources.smileyfrog;
            this.frogPicturebox.Location = new System.Drawing.Point(640, 71);
            this.frogPicturebox.Name = "frogPicturebox";
            this.frogPicturebox.Size = new System.Drawing.Size(148, 131);
            this.frogPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frogPicturebox.TabIndex = 28;
            this.frogPicturebox.TabStop = false;
            this.frogPicturebox.Visible = false;
            // 
            // totalsErrorLabel
            // 
            this.totalsErrorLabel.AutoSize = true;
            this.totalsErrorLabel.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Bold);
            this.totalsErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.totalsErrorLabel.Location = new System.Drawing.Point(106, 215);
            this.totalsErrorLabel.Name = "totalsErrorLabel";
            this.totalsErrorLabel.Size = new System.Drawing.Size(0, 42);
            this.totalsErrorLabel.TabIndex = 30;
            this.totalsErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // changeErrorLabel
            // 
            this.changeErrorLabel.AutoSize = true;
            this.changeErrorLabel.Font = new System.Drawing.Font("Gabriola", 17F, System.Drawing.FontStyle.Bold);
            this.changeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.changeErrorLabel.Location = new System.Drawing.Point(100, 408);
            this.changeErrorLabel.Name = "changeErrorLabel";
            this.changeErrorLabel.Size = new System.Drawing.Size(0, 42);
            this.changeErrorLabel.TabIndex = 31;
            this.changeErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HappyLittleFrogShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeErrorLabel);
            this.Controls.Add(this.totalsErrorLabel);
            this.Controls.Add(this.goodbyeLabel);
            this.Controls.Add(this.frogPicturebox);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.receiptTotalsLabel);
            this.Controls.Add(this.receiptEndLabel);
            this.Controls.Add(this.receiptPricesLabel);
            this.Controls.Add(this.receiptOrderedLabel);
            this.Controls.Add(this.receiptbutton);
            this.Controls.Add(this.receiptTitleLabel);
            this.Controls.Add(this.verticalDividerLabel);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.totalsButton);
            this.Controls.Add(this.lilypadsInput);
            this.Controls.Add(this.toadsInput);
            this.Controls.Add(this.frogsInput);
            this.Controls.Add(this.lilypadsLabel);
            this.Controls.Add(this.toadsLabel);
            this.Controls.Add(this.frogsLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HappyLittleFrogShop";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.frogPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label frogsLabel;
        private System.Windows.Forms.Label toadsLabel;
        private System.Windows.Forms.Label lilypadsLabel;
        private System.Windows.Forms.TextBox frogsInput;
        private System.Windows.Forms.TextBox toadsInput;
        private System.Windows.Forms.TextBox lilypadsInput;
        private System.Windows.Forms.Button totalsButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label dividerLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label verticalDividerLabel;
        private System.Windows.Forms.Label receiptTitleLabel;
        private System.Windows.Forms.Button receiptbutton;
        private System.Windows.Forms.Label receiptOrderedLabel;
        private System.Windows.Forms.Label receiptPricesLabel;
        private System.Windows.Forms.Label receiptEndLabel;
        private System.Windows.Forms.Label receiptTotalsLabel;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.PictureBox frogPicturebox;
        private System.Windows.Forms.Label goodbyeLabel;
        private System.Windows.Forms.Label totalsErrorLabel;
        private System.Windows.Forms.Label changeErrorLabel;
    }
}


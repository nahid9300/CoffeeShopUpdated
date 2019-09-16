namespace CoffeShop_Updated
{
    partial class CoffeShopUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoffeShopUI));
            this.label1 = new System.Windows.Forms.Label();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.showButton = new System.Windows.Forms.Button();
            this.outputRichBox = new System.Windows.Forms.RichTextBox();
            this.entryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // customerTextBox
            // 
            this.customerTextBox.Location = new System.Drawing.Point(139, 52);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(123, 20);
            this.customerTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contact No";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(139, 97);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(123, 20);
            this.contactTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(139, 137);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(123, 20);
            this.addressTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Order";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(139, 231);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(123, 20);
            this.quantityTextBox.TabIndex = 1;
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.orderComboBox.Location = new System.Drawing.Point(139, 171);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(121, 21);
            this.orderComboBox.TabIndex = 2;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(187, 293);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 5;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // outputRichBox
            // 
            this.outputRichBox.Location = new System.Drawing.Point(363, 52);
            this.outputRichBox.Name = "outputRichBox";
            this.outputRichBox.Size = new System.Drawing.Size(300, 278);
            this.outputRichBox.TabIndex = 6;
            this.outputRichBox.Text = "";
            // 
            // entryButton
            // 
            this.entryButton.Location = new System.Drawing.Point(67, 293);
            this.entryButton.Name = "entryButton";
            this.entryButton.Size = new System.Drawing.Size(75, 23);
            this.entryButton.TabIndex = 7;
            this.entryButton.Text = "Entry";
            this.entryButton.UseVisualStyleBackColor = true;
            this.entryButton.Click += new System.EventHandler(this.entryButton_Click);
            // 
            // CoffeShopUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.entryButton);
            this.Controls.Add(this.outputRichBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.orderComboBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.customerTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CoffeShopUI";
            this.Text = "CoffeShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.RichTextBox outputRichBox;
        private System.Windows.Forms.Button entryButton;
    }
}


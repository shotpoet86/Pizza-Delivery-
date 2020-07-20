namespace PizzaDelivery
{
    partial class Form1
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.yourSelectionLabel = new System.Windows.Forms.Label();
            this.selectPizzaLabel = new System.Windows.Forms.Label();
            this.pizzaSizeComboBox = new System.Windows.Forms.ComboBox();
            this.pizzaQuantityComboBox = new System.Windows.Forms.ComboBox();
            this.selectSauceComboBox = new System.Windows.Forms.ComboBox();
            this.pizzaSizeLabel = new System.Windows.Forms.Label();
            this.pizzaQuantityLabel = new System.Windows.Forms.Label();
            this.pizzaSauceLabel = new System.Windows.Forms.Label();
            this.breadQuantityTextBox = new System.Windows.Forms.TextBox();
            this.garlicKnotsTextBox = new System.Windows.Forms.TextBox();
            this.sodaTextBox = new System.Windows.Forms.TextBox();
            this.wingsQuantityTextBox = new System.Windows.Forms.TextBox();
            this.chickenStripsTextBox = new System.Windows.Forms.TextBox();
            this.makeOrderButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.pizzaListBox = new System.Windows.Forms.ListBox();
            this.breadQuantityLabel = new System.Windows.Forms.Label();
            this.garlicKnotsLabel = new System.Windows.Forms.Label();
            this.SodaLabel = new System.Windows.Forms.Label();
            this.wingsQuantityLabel = new System.Windows.Forms.Label();
            this.chickenStripsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(296, 20);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(181, 20);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Hot Pizza !!!";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(273, 59);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(55, 13);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "*  Address";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(59, 59);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(48, 13);
            this.phoneLabel.TabIndex = 2;
            this.phoneLabel.Text = "*  Phone";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(476, 59);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(45, 13);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "*  E-mail";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(334, 59);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 4;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged_1);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(527, 59);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 5;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged_1);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(113, 59);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 6;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged_1);
            // 
            // yourSelectionLabel
            // 
            this.yourSelectionLabel.AutoSize = true;
            this.yourSelectionLabel.Location = new System.Drawing.Point(549, 173);
            this.yourSelectionLabel.Name = "yourSelectionLabel";
            this.yourSelectionLabel.Size = new System.Drawing.Size(81, 13);
            this.yourSelectionLabel.TabIndex = 7;
            this.yourSelectionLabel.Text = "Select add ons:";
            // 
            // selectPizzaLabel
            // 
            this.selectPizzaLabel.AutoSize = true;
            this.selectPizzaLabel.Location = new System.Drawing.Point(250, 162);
            this.selectPizzaLabel.Name = "selectPizzaLabel";
            this.selectPizzaLabel.Size = new System.Drawing.Size(147, 13);
            this.selectPizzaLabel.TabIndex = 8;
            this.selectPizzaLabel.Text = "*  Select your FREE toppings:";
            // 
            // pizzaSizeComboBox
            // 
            this.pizzaSizeComboBox.FormattingEnabled = true;
            this.pizzaSizeComboBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large\t\t"});
            this.pizzaSizeComboBox.Location = new System.Drawing.Point(92, 245);
            this.pizzaSizeComboBox.Name = "pizzaSizeComboBox";
            this.pizzaSizeComboBox.Size = new System.Drawing.Size(121, 21);
            this.pizzaSizeComboBox.TabIndex = 9;
            this.pizzaSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.pizzaSizeComboBox_SelectedIndexChanged_1);
            // 
            // pizzaQuantityComboBox
            // 
            this.pizzaQuantityComboBox.FormattingEnabled = true;
            this.pizzaQuantityComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.pizzaQuantityComboBox.Location = new System.Drawing.Point(92, 287);
            this.pizzaQuantityComboBox.Name = "pizzaQuantityComboBox";
            this.pizzaQuantityComboBox.Size = new System.Drawing.Size(121, 21);
            this.pizzaQuantityComboBox.TabIndex = 10;
            this.pizzaQuantityComboBox.SelectedIndexChanged += new System.EventHandler(this.pizzaQuantityComboBox_SelectedIndexChanged_1);
            // 
            // selectSauceComboBox
            // 
            this.selectSauceComboBox.FormattingEnabled = true;
            this.selectSauceComboBox.Items.AddRange(new object[] {
            "Tomato",
            "Pesto",
            "None"});
            this.selectSauceComboBox.Location = new System.Drawing.Point(92, 326);
            this.selectSauceComboBox.Name = "selectSauceComboBox";
            this.selectSauceComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectSauceComboBox.TabIndex = 11;
            this.selectSauceComboBox.SelectedIndexChanged += new System.EventHandler(this.selectSauceComboBox_SelectedIndexChanged);
            // 
            // pizzaSizeLabel
            // 
            this.pizzaSizeLabel.AutoSize = true;
            this.pizzaSizeLabel.Location = new System.Drawing.Point(21, 245);
            this.pizzaSizeLabel.Name = "pizzaSizeLabel";
            this.pizzaSizeLabel.Size = new System.Drawing.Size(65, 13);
            this.pizzaSizeLabel.TabIndex = 12;
            this.pizzaSizeLabel.Text = "*  Pizza Size";
            // 
            // pizzaQuantityLabel
            // 
            this.pizzaQuantityLabel.AutoSize = true;
            this.pizzaQuantityLabel.Location = new System.Drawing.Point(2, 287);
            this.pizzaQuantityLabel.Name = "pizzaQuantityLabel";
            this.pizzaQuantityLabel.Size = new System.Drawing.Size(84, 13);
            this.pizzaQuantityLabel.TabIndex = 13;
            this.pizzaQuantityLabel.Text = "*  Pizza Quantity";
            // 
            // pizzaSauceLabel
            // 
            this.pizzaSauceLabel.AutoSize = true;
            this.pizzaSauceLabel.Location = new System.Drawing.Point(10, 326);
            this.pizzaSauceLabel.Name = "pizzaSauceLabel";
            this.pizzaSauceLabel.Size = new System.Drawing.Size(76, 13);
            this.pizzaSauceLabel.TabIndex = 14;
            this.pizzaSauceLabel.Text = "*  Pizza Sauce";
            // 
            // breadQuantityTextBox
            // 
            this.breadQuantityTextBox.Location = new System.Drawing.Point(696, 238);
            this.breadQuantityTextBox.Name = "breadQuantityTextBox";
            this.breadQuantityTextBox.Size = new System.Drawing.Size(36, 20);
            this.breadQuantityTextBox.TabIndex = 15;
            this.breadQuantityTextBox.TextChanged += new System.EventHandler(this.breadQuantityTextBox_TextChanged_1);
            // 
            // garlicKnotsTextBox
            // 
            this.garlicKnotsTextBox.Location = new System.Drawing.Point(696, 264);
            this.garlicKnotsTextBox.Name = "garlicKnotsTextBox";
            this.garlicKnotsTextBox.Size = new System.Drawing.Size(36, 20);
            this.garlicKnotsTextBox.TabIndex = 16;
            this.garlicKnotsTextBox.TextChanged += new System.EventHandler(this.garlicKnotsTextBox_TextChanged_1);
            // 
            // sodaTextBox
            // 
            this.sodaTextBox.Location = new System.Drawing.Point(696, 212);
            this.sodaTextBox.Name = "sodaTextBox";
            this.sodaTextBox.Size = new System.Drawing.Size(36, 20);
            this.sodaTextBox.TabIndex = 18;
            this.sodaTextBox.TextChanged += new System.EventHandler(this.SodaTextBox_TextChanged_1);
            // 
            // wingsQuantityTextBox
            // 
            this.wingsQuantityTextBox.Location = new System.Drawing.Point(696, 290);
            this.wingsQuantityTextBox.Name = "wingsQuantityTextBox";
            this.wingsQuantityTextBox.Size = new System.Drawing.Size(36, 20);
            this.wingsQuantityTextBox.TabIndex = 19;
            this.wingsQuantityTextBox.TextChanged += new System.EventHandler(this.wingsQuantityTextBox_TextChanged_1);
            // 
            // chickenStripsTextBox
            // 
            this.chickenStripsTextBox.Location = new System.Drawing.Point(696, 316);
            this.chickenStripsTextBox.Name = "chickenStripsTextBox";
            this.chickenStripsTextBox.Size = new System.Drawing.Size(36, 20);
            this.chickenStripsTextBox.TabIndex = 20;
            this.chickenStripsTextBox.TextChanged += new System.EventHandler(this.chickenStripsTextBox_TextChanged_1);
            // 
            // makeOrderButton
            // 
            this.makeOrderButton.Location = new System.Drawing.Point(164, 409);
            this.makeOrderButton.Name = "makeOrderButton";
            this.makeOrderButton.Size = new System.Drawing.Size(75, 23);
            this.makeOrderButton.TabIndex = 24;
            this.makeOrderButton.Text = "Order";
            this.makeOrderButton.UseVisualStyleBackColor = true;
            this.makeOrderButton.Click += new System.EventHandler(this.makeOrderButton_Click_1);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(468, 409);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 25;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click_1);
            // 
            // pizzaListBox
            // 
            this.pizzaListBox.FormattingEnabled = true;
            this.pizzaListBox.Items.AddRange(new object[] {
            "Cheese",
            "Extra Cheese",
            "Pepperoni",
            "Extra Pepperoni",
            "Pork",
            "Sausage",
            "Italian Sausage",
            "Ham",
            "Bacon",
            "Canadian Bacon",
            "Mushrooms",
            "Black Olives",
            "Green Olives",
            "Green Peppers",
            "Jalapenos",
            "Tomatoes",
            "",
            "",
            ""});
            this.pizzaListBox.Location = new System.Drawing.Point(288, 215);
            this.pizzaListBox.Name = "pizzaListBox";
            this.pizzaListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.pizzaListBox.Size = new System.Drawing.Size(129, 238);
            this.pizzaListBox.TabIndex = 26;
            this.pizzaListBox.SelectedIndexChanged += new System.EventHandler(this.pizzaListBox_SelectedIndexChanged);
            // 
            // breadQuantityLabel
            // 
            this.breadQuantityLabel.AutoSize = true;
            this.breadQuantityLabel.Location = new System.Drawing.Point(598, 238);
            this.breadQuantityLabel.Name = "breadQuantityLabel";
            this.breadQuantityLabel.Size = new System.Drawing.Size(92, 13);
            this.breadQuantityLabel.TabIndex = 27;
            this.breadQuantityLabel.Text = "Breadsticks $3.00";
            // 
            // garlicKnotsLabel
            // 
            this.garlicKnotsLabel.AutoSize = true;
            this.garlicKnotsLabel.Location = new System.Drawing.Point(597, 264);
            this.garlicKnotsLabel.Name = "garlicKnotsLabel";
            this.garlicKnotsLabel.Size = new System.Drawing.Size(93, 13);
            this.garlicKnotsLabel.TabIndex = 28;
            this.garlicKnotsLabel.Text = "Garlic knots $4.00";
            this.garlicKnotsLabel.Click += new System.EventHandler(this.garlicKnotsLabel_Click);
            // 
            // SodaLabel
            // 
            this.SodaLabel.AutoSize = true;
            this.SodaLabel.Location = new System.Drawing.Point(598, 215);
            this.SodaLabel.Name = "SodaLabel";
            this.SodaLabel.Size = new System.Drawing.Size(92, 13);
            this.SodaLabel.TabIndex = 29;
            this.SodaLabel.Text = "Large Soda $2.00";
            // 
            // wingsQuantityLabel
            // 
            this.wingsQuantityLabel.AutoSize = true;
            this.wingsQuantityLabel.Location = new System.Drawing.Point(623, 290);
            this.wingsQuantityLabel.Name = "wingsQuantityLabel";
            this.wingsQuantityLabel.Size = new System.Drawing.Size(67, 13);
            this.wingsQuantityLabel.TabIndex = 31;
            this.wingsQuantityLabel.Text = "Wings $6.00";
            // 
            // chickenStripsLabel
            // 
            this.chickenStripsLabel.AutoSize = true;
            this.chickenStripsLabel.Location = new System.Drawing.Point(572, 316);
            this.chickenStripsLabel.Name = "chickenStripsLabel";
            this.chickenStripsLabel.Size = new System.Drawing.Size(118, 13);
            this.chickenStripsLabel.TabIndex = 32;
            this.chickenStripsLabel.Text = "Chicken Tenders $5.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "* Select Pizza Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Medium $20.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Large $ 25.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Small $15.00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PizzaDelivery.Properties.Resources.pizza_neon_light_signage_1596888;
            this.pictureBox1.Location = new System.Drawing.Point(101, 512);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "CTRL + mouse click to select multiple toppings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 842);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chickenStripsLabel);
            this.Controls.Add(this.wingsQuantityLabel);
            this.Controls.Add(this.SodaLabel);
            this.Controls.Add(this.garlicKnotsLabel);
            this.Controls.Add(this.breadQuantityLabel);
            this.Controls.Add(this.pizzaListBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.makeOrderButton);
            this.Controls.Add(this.chickenStripsTextBox);
            this.Controls.Add(this.wingsQuantityTextBox);
            this.Controls.Add(this.sodaTextBox);
            this.Controls.Add(this.garlicKnotsTextBox);
            this.Controls.Add(this.breadQuantityTextBox);
            this.Controls.Add(this.pizzaSauceLabel);
            this.Controls.Add(this.pizzaQuantityLabel);
            this.Controls.Add(this.pizzaSizeLabel);
            this.Controls.Add(this.selectSauceComboBox);
            this.Controls.Add(this.pizzaQuantityComboBox);
            this.Controls.Add(this.pizzaSizeComboBox);
            this.Controls.Add(this.selectPizzaLabel);
            this.Controls.Add(this.yourSelectionLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label yourSelectionLabel;
        private System.Windows.Forms.Label selectPizzaLabel;
        private System.Windows.Forms.ComboBox pizzaSizeComboBox;
        private System.Windows.Forms.ComboBox pizzaQuantityComboBox;
        private System.Windows.Forms.ComboBox selectSauceComboBox;
        private System.Windows.Forms.Label pizzaSizeLabel;
        private System.Windows.Forms.Label pizzaQuantityLabel;
        private System.Windows.Forms.Label pizzaSauceLabel;
        private System.Windows.Forms.TextBox breadQuantityTextBox;
        private System.Windows.Forms.TextBox garlicKnotsTextBox;
        private System.Windows.Forms.TextBox sodaTextBox;
        private System.Windows.Forms.TextBox wingsQuantityTextBox;
        private System.Windows.Forms.TextBox chickenStripsTextBox;
        private System.Windows.Forms.Button makeOrderButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ListBox pizzaListBox;
        private System.Windows.Forms.Label breadQuantityLabel;
        private System.Windows.Forms.Label garlicKnotsLabel;
        private System.Windows.Forms.Label SodaLabel;
        private System.Windows.Forms.Label wingsQuantityLabel;
        private System.Windows.Forms.Label chickenStripsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}


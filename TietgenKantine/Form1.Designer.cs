namespace TietgenKantine
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
            this.cmbDishes = new System.Windows.Forms.ComboBox();
            this.lblMainCourse = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainDishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beveragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAccessories = new System.Windows.Forms.Label();
            this.lstBoxAccessories = new System.Windows.Forms.ListBox();
            this.lblBeverages = new System.Windows.Forms.Label();
            this.rdbMilk = new System.Windows.Forms.RadioButton();
            this.rdbJuice = new System.Windows.Forms.RadioButton();
            this.rdbSoda = new System.Windows.Forms.RadioButton();
            this.rdbLemonade = new System.Windows.Forms.RadioButton();
            this.rdbTea = new System.Windows.Forms.RadioButton();
            this.rdbCoffee = new System.Windows.Forms.RadioButton();
            this.chkBoxWater = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDishes
            // 
            this.cmbDishes.FormattingEnabled = true;
            this.cmbDishes.Location = new System.Drawing.Point(26, 70);
            this.cmbDishes.Name = "cmbDishes";
            this.cmbDishes.Size = new System.Drawing.Size(121, 21);
            this.cmbDishes.TabIndex = 0;
            this.cmbDishes.SelectedIndexChanged += new System.EventHandler(this.cmbDishes_SelectedIndexChanged);
            // 
            // lblMainCourse
            // 
            this.lblMainCourse.AutoSize = true;
            this.lblMainCourse.Location = new System.Drawing.Point(23, 54);
            this.lblMainCourse.Name = "lblMainCourse";
            this.lblMainCourse.Size = new System.Drawing.Size(101, 13);
            this.lblMainCourse.TabIndex = 1;
            this.lblMainCourse.Text = "Pick a Main course:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(362, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem,
            this.deleteOrderToolStripMenuItem,
            this.showOrderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.orderToolStripMenuItem.Text = "Confirm order";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // deleteOrderToolStripMenuItem
            // 
            this.deleteOrderToolStripMenuItem.Name = "deleteOrderToolStripMenuItem";
            this.deleteOrderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteOrderToolStripMenuItem.Text = "Delete order";
            this.deleteOrderToolStripMenuItem.Click += new System.EventHandler(this.deleteOrderToolStripMenuItem_Click);
            // 
            // showOrderToolStripMenuItem
            // 
            this.showOrderToolStripMenuItem.Name = "showOrderToolStripMenuItem";
            this.showOrderToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.showOrderToolStripMenuItem.Text = "Show order";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainDishToolStripMenuItem,
            this.beveragesToolStripMenuItem,
            this.accessoriesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // mainDishToolStripMenuItem
            // 
            this.mainDishToolStripMenuItem.Name = "mainDishToolStripMenuItem";
            this.mainDishToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.mainDishToolStripMenuItem.Text = "Main dish";
            // 
            // beveragesToolStripMenuItem
            // 
            this.beveragesToolStripMenuItem.Name = "beveragesToolStripMenuItem";
            this.beveragesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.beveragesToolStripMenuItem.Text = "Beverages";
            // 
            // accessoriesToolStripMenuItem
            // 
            this.accessoriesToolStripMenuItem.Name = "accessoriesToolStripMenuItem";
            this.accessoriesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.accessoriesToolStripMenuItem.Text = "Accessories";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // lblAccessories
            // 
            this.lblAccessories.AutoSize = true;
            this.lblAccessories.Location = new System.Drawing.Point(23, 135);
            this.lblAccessories.Name = "lblAccessories";
            this.lblAccessories.Size = new System.Drawing.Size(67, 13);
            this.lblAccessories.TabIndex = 3;
            this.lblAccessories.Text = "Accessories:";
            // 
            // lstBoxAccessories
            // 
            this.lstBoxAccessories.FormattingEnabled = true;
            this.lstBoxAccessories.Location = new System.Drawing.Point(26, 151);
            this.lstBoxAccessories.Name = "lstBoxAccessories";
            this.lstBoxAccessories.Size = new System.Drawing.Size(121, 82);
            this.lstBoxAccessories.TabIndex = 4;
            this.lstBoxAccessories.SelectedIndexChanged += new System.EventHandler(this.lstBoxAccessories_SelectedIndexChanged);
            // 
            // lblBeverages
            // 
            this.lblBeverages.AutoSize = true;
            this.lblBeverages.Location = new System.Drawing.Point(181, 54);
            this.lblBeverages.Name = "lblBeverages";
            this.lblBeverages.Size = new System.Drawing.Size(61, 13);
            this.lblBeverages.TabIndex = 5;
            this.lblBeverages.Text = "Beverages:";
            // 
            // rdbMilk
            // 
            this.rdbMilk.AutoSize = true;
            this.rdbMilk.Location = new System.Drawing.Point(184, 78);
            this.rdbMilk.Name = "rdbMilk";
            this.rdbMilk.Size = new System.Drawing.Size(52, 17);
            this.rdbMilk.TabIndex = 6;
            this.rdbMilk.TabStop = true;
            this.rdbMilk.Text = "Mælk";
            this.rdbMilk.UseVisualStyleBackColor = true;
            this.rdbMilk.CheckedChanged += new System.EventHandler(this.rdbSoda_CheckedChanged);
            // 
            // rdbJuice
            // 
            this.rdbJuice.AutoSize = true;
            this.rdbJuice.Location = new System.Drawing.Point(184, 101);
            this.rdbJuice.Name = "rdbJuice";
            this.rdbJuice.Size = new System.Drawing.Size(50, 17);
            this.rdbJuice.TabIndex = 7;
            this.rdbJuice.TabStop = true;
            this.rdbJuice.Text = "Juice";
            this.rdbJuice.UseVisualStyleBackColor = true;
            this.rdbJuice.CheckedChanged += new System.EventHandler(this.rdbSoda_CheckedChanged);
            // 
            // rdbSoda
            // 
            this.rdbSoda.AutoSize = true;
            this.rdbSoda.Location = new System.Drawing.Point(184, 124);
            this.rdbSoda.Name = "rdbSoda";
            this.rdbSoda.Size = new System.Drawing.Size(74, 17);
            this.rdbSoda.TabIndex = 8;
            this.rdbSoda.TabStop = true;
            this.rdbSoda.Text = "Sodavand";
            this.rdbSoda.UseVisualStyleBackColor = true;
            this.rdbSoda.CheckedChanged += new System.EventHandler(this.rdbSoda_CheckedChanged);
            // 
            // rdbLemonade
            // 
            this.rdbLemonade.AutoSize = true;
            this.rdbLemonade.Location = new System.Drawing.Point(184, 147);
            this.rdbLemonade.Name = "rdbLemonade";
            this.rdbLemonade.Size = new System.Drawing.Size(71, 17);
            this.rdbLemonade.TabIndex = 9;
            this.rdbLemonade.TabStop = true;
            this.rdbLemonade.Text = "Limonade";
            this.rdbLemonade.UseVisualStyleBackColor = true;
            this.rdbLemonade.CheckedChanged += new System.EventHandler(this.rdbSoda_CheckedChanged);
            // 
            // rdbTea
            // 
            this.rdbTea.AutoSize = true;
            this.rdbTea.Location = new System.Drawing.Point(184, 170);
            this.rdbTea.Name = "rdbTea";
            this.rdbTea.Size = new System.Drawing.Size(44, 17);
            this.rdbTea.TabIndex = 10;
            this.rdbTea.TabStop = true;
            this.rdbTea.Text = "The";
            this.rdbTea.UseVisualStyleBackColor = true;
            this.rdbTea.CheckedChanged += new System.EventHandler(this.rdbSoda_CheckedChanged);
            // 
            // rdbCoffee
            // 
            this.rdbCoffee.AutoSize = true;
            this.rdbCoffee.Location = new System.Drawing.Point(184, 193);
            this.rdbCoffee.Name = "rdbCoffee";
            this.rdbCoffee.Size = new System.Drawing.Size(50, 17);
            this.rdbCoffee.TabIndex = 11;
            this.rdbCoffee.TabStop = true;
            this.rdbCoffee.Text = "Kaffe";
            this.rdbCoffee.UseVisualStyleBackColor = true;
            this.rdbCoffee.CheckedChanged += new System.EventHandler(this.rdbSoda_CheckedChanged);
            // 
            // chkBoxWater
            // 
            this.chkBoxWater.AutoSize = true;
            this.chkBoxWater.Location = new System.Drawing.Point(26, 250);
            this.chkBoxWater.Name = "chkBoxWater";
            this.chkBoxWater.Size = new System.Drawing.Size(55, 17);
            this.chkBoxWater.TabIndex = 12;
            this.chkBoxWater.Text = "Water";
            this.chkBoxWater.UseVisualStyleBackColor = true;
            this.chkBoxWater.CheckedChanged += new System.EventHandler(this.chkBoxWater_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 302);
            this.Controls.Add(this.chkBoxWater);
            this.Controls.Add(this.rdbCoffee);
            this.Controls.Add(this.rdbTea);
            this.Controls.Add(this.rdbLemonade);
            this.Controls.Add(this.rdbSoda);
            this.Controls.Add(this.rdbJuice);
            this.Controls.Add(this.rdbMilk);
            this.Controls.Add(this.lblBeverages);
            this.Controls.Add(this.lstBoxAccessories);
            this.Controls.Add(this.lblAccessories);
            this.Controls.Add(this.lblMainCourse);
            this.Controls.Add(this.cmbDishes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDishes;
        private System.Windows.Forms.Label lblMainCourse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainDishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beveragesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lblAccessories;
        private System.Windows.Forms.ListBox lstBoxAccessories;
        private System.Windows.Forms.Label lblBeverages;
        private System.Windows.Forms.RadioButton rdbMilk;
        private System.Windows.Forms.RadioButton rdbJuice;
        private System.Windows.Forms.RadioButton rdbSoda;
        private System.Windows.Forms.RadioButton rdbLemonade;
        private System.Windows.Forms.RadioButton rdbTea;
        private System.Windows.Forms.RadioButton rdbCoffee;
        private System.Windows.Forms.CheckBox chkBoxWater;
    }
}


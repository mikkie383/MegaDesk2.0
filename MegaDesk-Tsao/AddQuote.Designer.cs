namespace MegaDesk_Tsao
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGetQuote = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.widthNum = new System.Windows.Forms.NumericUpDown();
            this.tansD = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.depthNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.drawerNum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.comDeliveryOption = new System.Windows.Forms.ComboBox();
            this.labDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbBasePrice = new System.Windows.Forms.Label();
            this.lbSurfaceAreaPrice = new System.Windows.Forms.Label();
            this.lbMaterialPrice = new System.Windows.Forms.Label();
            this.lbShippingPrice = new System.Windows.Forms.Label();
            this.lbDrawerPrice = new System.Windows.Forms.Label();
            this.lbTotalCost = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbSurfaceArea = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.widthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tansD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerNum)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(249, 101);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(185, 30);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustomerName_Validating);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(203, 370);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 39);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetQuote.Location = new System.Drawing.Point(424, 370);
            this.btnGetQuote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(146, 39);
            this.btnGetQuote.TabIndex = 5;
            this.btnGetQuote.Text = "Get Quote";
            this.btnGetQuote.UseVisualStyleBackColor = true;
            this.btnGetQuote.Click += new System.EventHandler(this.btnGetQuote_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(75, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Width";
            // 
            // widthNum
            // 
            this.widthNum.Location = new System.Drawing.Point(203, 154);
            this.widthNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.widthNum.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthNum.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthNum.Name = "widthNum";
            this.widthNum.Size = new System.Drawing.Size(120, 22);
            this.widthNum.TabIndex = 2;
            this.widthNum.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthNum.Leave += new System.EventHandler(this.countSum_Leave);
            // 
            // tansD
            // 
            this.tansD.Location = new System.Drawing.Point(79, 7);
            this.tansD.Margin = new System.Windows.Forms.Padding(4);
            this.tansD.Name = "tansD";
            this.tansD.Size = new System.Drawing.Size(651, 210);
            this.tansD.TabIndex = 9;
            this.tansD.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 34F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(64, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 74);
            this.label3.TabIndex = 10;
            this.label3.Text = "Der Desk";
            // 
            // depthNum
            // 
            this.depthNum.Location = new System.Drawing.Point(203, 183);
            this.depthNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.depthNum.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthNum.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthNum.Name = "depthNum";
            this.depthNum.Size = new System.Drawing.Size(120, 22);
            this.depthNum.TabIndex = 3;
            this.depthNum.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthNum.Leave += new System.EventHandler(this.countSum_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Depth";
            // 
            // drawerNum
            // 
            this.drawerNum.Location = new System.Drawing.Point(203, 251);
            this.drawerNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drawerNum.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawerNum.Name = "drawerNum";
            this.drawerNum.Size = new System.Drawing.Size(120, 22);
            this.drawerNum.TabIndex = 4;
            this.drawerNum.Leave += new System.EventHandler(this.countSum_Leave);
            this.drawerNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustomerName_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Number of drawer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 296);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Surface Material: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 329);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Delivery Option:";
            // 
            // comSurfaceMaterial
            // 
            this.comSurfaceMaterial.FormattingEnabled = true;
            this.comSurfaceMaterial.Location = new System.Drawing.Point(200, 293);
            this.comSurfaceMaterial.Name = "comSurfaceMaterial";
            this.comSurfaceMaterial.Size = new System.Drawing.Size(153, 24);
            this.comSurfaceMaterial.TabIndex = 5;
            this.comSurfaceMaterial.Leave += new System.EventHandler(this.countSum_Leave);
            this.comSurfaceMaterial.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustomerName_Validating);
            // 
            // comDeliveryOption
            // 
            this.comDeliveryOption.FormattingEnabled = true;
            this.comDeliveryOption.Location = new System.Drawing.Point(200, 326);
            this.comDeliveryOption.Name = "comDeliveryOption";
            this.comDeliveryOption.Size = new System.Drawing.Size(153, 24);
            this.comDeliveryOption.TabIndex = 6;
            this.comDeliveryOption.Leave += new System.EventHandler(this.countSum_Leave);
            this.comDeliveryOption.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustomerName_Validating);
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Location = new System.Drawing.Point(546, 87);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(36, 17);
            this.labDate.TabIndex = 21;
            this.labDate.Text = "date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(542, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Quote Cost Summary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Base: $";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Surface Area: $";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Desktop Material: $";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(64, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Drawer(s): $";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(71, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "Shipping: $";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(26, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 25);
            this.label14.TabIndex = 28;
            this.label14.Text = "Total Cost: $";
            // 
            // lbBasePrice
            // 
            this.lbBasePrice.AutoSize = true;
            this.lbBasePrice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbBasePrice.Location = new System.Drawing.Point(176, 32);
            this.lbBasePrice.Name = "lbBasePrice";
            this.lbBasePrice.Size = new System.Drawing.Size(16, 17);
            this.lbBasePrice.TabIndex = 29;
            this.lbBasePrice.Text = "0";
            // 
            // lbSurfaceAreaPrice
            // 
            this.lbSurfaceAreaPrice.AutoSize = true;
            this.lbSurfaceAreaPrice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbSurfaceAreaPrice.Location = new System.Drawing.Point(175, 61);
            this.lbSurfaceAreaPrice.Name = "lbSurfaceAreaPrice";
            this.lbSurfaceAreaPrice.Size = new System.Drawing.Size(16, 17);
            this.lbSurfaceAreaPrice.TabIndex = 30;
            this.lbSurfaceAreaPrice.Text = "0";
            // 
            // lbMaterialPrice
            // 
            this.lbMaterialPrice.AutoSize = true;
            this.lbMaterialPrice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbMaterialPrice.Location = new System.Drawing.Point(176, 120);
            this.lbMaterialPrice.Name = "lbMaterialPrice";
            this.lbMaterialPrice.Size = new System.Drawing.Size(16, 17);
            this.lbMaterialPrice.TabIndex = 31;
            this.lbMaterialPrice.Text = "0";
            // 
            // lbShippingPrice
            // 
            this.lbShippingPrice.AutoSize = true;
            this.lbShippingPrice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbShippingPrice.Location = new System.Drawing.Point(176, 154);
            this.lbShippingPrice.Name = "lbShippingPrice";
            this.lbShippingPrice.Size = new System.Drawing.Size(16, 17);
            this.lbShippingPrice.TabIndex = 33;
            this.lbShippingPrice.Text = "0";
            // 
            // lbDrawerPrice
            // 
            this.lbDrawerPrice.AutoSize = true;
            this.lbDrawerPrice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbDrawerPrice.Location = new System.Drawing.Point(176, 90);
            this.lbDrawerPrice.Name = "lbDrawerPrice";
            this.lbDrawerPrice.Size = new System.Drawing.Size(16, 17);
            this.lbDrawerPrice.TabIndex = 32;
            this.lbDrawerPrice.Text = "0";
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.AutoSize = true;
            this.lbTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCost.ForeColor = System.Drawing.Color.Red;
            this.lbTotalCost.Location = new System.Drawing.Point(174, 190);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(19, 25);
            this.lbTotalCost.TabIndex = 34;
            this.lbTotalCost.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(76, 212);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 17);
            this.label15.TabIndex = 35;
            this.label15.Text = "Area: sq in";
            // 
            // lbSurfaceArea
            // 
            this.lbSurfaceArea.AutoSize = true;
            this.lbSurfaceArea.Location = new System.Drawing.Point(200, 212);
            this.lbSurfaceArea.Name = "lbSurfaceArea";
            this.lbSurfaceArea.Size = new System.Drawing.Size(16, 17);
            this.lbSurfaceArea.TabIndex = 36;
            this.lbSurfaceArea.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbTotalCost);
            this.panel1.Controls.Add(this.lbShippingPrice);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lbDrawerPrice);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lbMaterialPrice);
            this.panel1.Controls.Add(this.lbSurfaceAreaPrice);
            this.panel1.Controls.Add(this.lbBasePrice);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(474, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 229);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(60, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 90);
            this.panel2.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(112, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 17);
            this.label16.TabIndex = 39;
            this.label16.Text = "Surface Area";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbSurfaceArea);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.comDeliveryOption);
            this.Controls.Add(this.comSurfaceMaterial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.drawerNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.depthNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.widthNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGetQuote);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tansD);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.widthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tansD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerNum)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGetQuote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown widthNum;
        private System.Windows.Forms.PictureBox tansD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown depthNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown drawerNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comSurfaceMaterial;
        private System.Windows.Forms.ComboBox comDeliveryOption;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbBasePrice;
        private System.Windows.Forms.Label lbSurfaceAreaPrice;
        private System.Windows.Forms.Label lbMaterialPrice;
        private System.Windows.Forms.Label lbShippingPrice;
        private System.Windows.Forms.Label lbDrawerPrice;
        private System.Windows.Forms.Label lbTotalCost;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbSurfaceArea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
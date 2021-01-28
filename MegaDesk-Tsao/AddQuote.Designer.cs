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
            ((System.ComponentModel.ISupportInitialize)(this.widthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tansD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerNum)).BeginInit();
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
            this.txtCustomerName.Size = new System.Drawing.Size(129, 30);
            this.txtCustomerName.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(457, 318);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(245, 91);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetQuote.Location = new System.Drawing.Point(93, 318);
            this.btnGetQuote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(245, 91);
            this.btnGetQuote.TabIndex = 5;
            this.btnGetQuote.Text = "Get Quote";
            this.btnGetQuote.UseVisualStyleBackColor = true;
            this.btnGetQuote.Click += new System.EventHandler(this.btnGetQuote_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Width";
            // 
            // widthNum
            // 
            this.widthNum.Location = new System.Drawing.Point(203, 170);
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
            this.widthNum.TabIndex = 8;
            this.widthNum.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // tansD
            // 
            this.tansD.Location = new System.Drawing.Point(79, 7);
            this.tansD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.depthNum.Location = new System.Drawing.Point(203, 199);
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
            this.depthNum.TabIndex = 12;
            this.depthNum.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Depth";
            // 
            // drawerNum
            // 
            this.drawerNum.Location = new System.Drawing.Point(203, 229);
            this.drawerNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drawerNum.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawerNum.Name = "drawerNum";
            this.drawerNum.Size = new System.Drawing.Size(120, 22);
            this.drawerNum.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Number of drawer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Surface Material: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 199);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Delivery Option:";
            // 
            // comSurfaceMaterial
            // 
            this.comSurfaceMaterial.FormattingEnabled = true;
            this.comSurfaceMaterial.Location = new System.Drawing.Point(547, 163);
            this.comSurfaceMaterial.Name = "comSurfaceMaterial";
            this.comSurfaceMaterial.Size = new System.Drawing.Size(153, 24);
            this.comSurfaceMaterial.TabIndex = 19;
            // 
            // comDeliveryOption
            // 
            this.comDeliveryOption.FormattingEnabled = true;
            this.comDeliveryOption.Location = new System.Drawing.Point(547, 196);
            this.comDeliveryOption.Name = "comDeliveryOption";
            this.comDeliveryOption.Size = new System.Drawing.Size(153, 24);
            this.comDeliveryOption.TabIndex = 20;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.tansD);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.widthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tansD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerNum)).EndInit();
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
    }
}
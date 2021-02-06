namespace MegaDesk_Tsao
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnAddNewQuote = new System.Windows.Forms.Button();
            this.btnViewQuote = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearchQuote = new System.Windows.Forms.Button();
            this.background = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewQuote
            // 
            this.btnAddNewQuote.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddNewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewQuote.Location = new System.Drawing.Point(75, 223);
            this.btnAddNewQuote.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewQuote.Name = "btnAddNewQuote";
            this.btnAddNewQuote.Size = new System.Drawing.Size(173, 67);
            this.btnAddNewQuote.TabIndex = 0;
            this.btnAddNewQuote.Text = "Add New Quote";
            this.btnAddNewQuote.UseVisualStyleBackColor = false;
            this.btnAddNewQuote.Click += new System.EventHandler(this.btnAddNewQuote_Click);
            // 
            // btnViewQuote
            // 
            this.btnViewQuote.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewQuote.Location = new System.Drawing.Point(348, 223);
            this.btnViewQuote.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewQuote.Name = "btnViewQuote";
            this.btnViewQuote.Size = new System.Drawing.Size(173, 67);
            this.btnViewQuote.TabIndex = 2;
            this.btnViewQuote.Text = "View Quote";
            this.btnViewQuote.UseVisualStyleBackColor = false;
            this.btnViewQuote.Click += new System.EventHandler(this.btnViewQuote_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(348, 324);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 67);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearchQuote
            // 
            this.btnSearchQuote.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchQuote.Location = new System.Drawing.Point(75, 324);
            this.btnSearchQuote.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchQuote.Name = "btnSearchQuote";
            this.btnSearchQuote.Size = new System.Drawing.Size(173, 67);
            this.btnSearchQuote.TabIndex = 3;
            this.btnSearchQuote.Text = "Search Quote";
            this.btnSearchQuote.UseVisualStyleBackColor = false;
            this.btnSearchQuote.Click += new System.EventHandler(this.btnSearchQuote_Click);
            // 
            // background
            // 
            this.background.Image = global::MegaDesk_Tsao.Properties.Resources.MDesk;
            this.background.Location = new System.Drawing.Point(45, -11);
            this.background.Margin = new System.Windows.Forms.Padding(2);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(476, 391);
            this.background.TabIndex = 5;
            this.background.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 34F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 59);
            this.label1.TabIndex = 6;
            this.label1.Text = "Der Desk";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(586, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearchQuote);
            this.Controls.Add(this.btnViewQuote);
            this.Controls.Add(this.btnAddNewQuote);
            this.Controls.Add(this.background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewQuote;
        private System.Windows.Forms.Button btnViewQuote;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearchQuote;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Label label1;
    }
}


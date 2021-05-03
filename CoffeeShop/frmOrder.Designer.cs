
using System;

namespace CoffeeShop
{
    partial class frmOrder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new System.Windows.Forms.Label();
            this.lbCoffee = new System.Windows.Forms.Label();
            this.lbDonuts = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbCoffee = new System.Windows.Forms.TextBox();
            this.txbDonuts = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 45);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // lbCoffee
            // 
            this.lbCoffee.AutoSize = true;
            this.lbCoffee.Location = new System.Drawing.Point(12, 85);
            this.lbCoffee.Name = "lbCoffee";
            this.lbCoffee.Size = new System.Drawing.Size(53, 20);
            this.lbCoffee.TabIndex = 1;
            this.lbCoffee.Text = "Coffee";
            this.lbCoffee.Click += new System.EventHandler(this.lbCoffee_Click);
            // 
            // lbDonuts
            // 
            this.lbDonuts.AutoSize = true;
            this.lbDonuts.Location = new System.Drawing.Point(12, 128);
            this.lbDonuts.Name = "lbDonuts";
            this.lbDonuts.Size = new System.Drawing.Size(56, 20);
            this.lbDonuts.TabIndex = 2;
            this.lbDonuts.Text = "Donuts";
            this.lbDonuts.Click += new System.EventHandler(this.lbDonuts_Click);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(106, 42);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(125, 27);
            this.txbName.TabIndex = 3;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            // 
            // txbCoffee
            // 
            this.txbCoffee.Location = new System.Drawing.Point(106, 82);
            this.txbCoffee.Name = "txbCoffee";
            this.txbCoffee.Size = new System.Drawing.Size(125, 27);
            this.txbCoffee.TabIndex = 4;
            this.txbCoffee.TextChanged += new System.EventHandler(this.txbCoffee_TextChanged);
            // 
            // txbDonuts
            // 
            this.txbDonuts.Location = new System.Drawing.Point(106, 125);
            this.txbDonuts.Name = "txbDonuts";
            this.txbDonuts.Size = new System.Drawing.Size(125, 27);
            this.txbDonuts.TabIndex = 5;
            this.txbDonuts.TextChanged += new System.EventHandler(this.txbDonuts_TextChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(117, 177);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(94, 29);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 234);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txbDonuts);
            this.Controls.Add(this.txbCoffee);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lbDonuts);
            this.Controls.Add(this.lbCoffee);
            this.Controls.Add(this.lbName);
            this.Name = "frmOrder";
            this.Text = "Coffee Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCoffee;
        private System.Windows.Forms.Label lbDonuts;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbCoffee;
        private System.Windows.Forms.TextBox txbDonuts;
        private System.Windows.Forms.Button btnOrder;
    }
}


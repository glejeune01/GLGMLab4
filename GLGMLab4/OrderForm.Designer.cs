namespace GLGMLab4
{
    partial class OrderForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtNameEntry = new System.Windows.Forms.TextBox();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.cboOrderSelect = new System.Windows.Forms.ComboBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblGrandTotalDisplay = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReadOrders = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // txtNameEntry
            // 
            this.txtNameEntry.Location = new System.Drawing.Point(87, 26);
            this.txtNameEntry.Name = "txtNameEntry";
            this.txtNameEntry.Size = new System.Drawing.Size(260, 22);
            this.txtNameEntry.TabIndex = 1;
            // 
            // lstOrders
            // 
            this.lstOrders.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 16;
            this.lstOrders.Location = new System.Drawing.Point(15, 67);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(348, 244);
            this.lstOrders.TabIndex = 2;
            this.lstOrders.TabStop = false;
            // 
            // cboOrderSelect
            // 
            this.cboOrderSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderSelect.FormattingEnabled = true;
            this.cboOrderSelect.Location = new System.Drawing.Point(388, 67);
            this.cboOrderSelect.Name = "cboOrderSelect";
            this.cboOrderSelect.Size = new System.Drawing.Size(284, 24);
            this.cboOrderSelect.TabIndex = 3;
            this.cboOrderSelect.TabStop = false;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Location = new System.Drawing.Point(417, 160);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(114, 28);
            this.lblGrandTotal.TabIndex = 4;
            this.lblGrandTotal.Text = "Grand Total:";
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrandTotalDisplay
            // 
            this.lblGrandTotalDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrandTotalDisplay.Location = new System.Drawing.Point(537, 159);
            this.lblGrandTotalDisplay.Name = "lblGrandTotalDisplay";
            this.lblGrandTotalDisplay.Size = new System.Drawing.Size(135, 28);
            this.lblGrandTotalDisplay.TabIndex = 5;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(46, 362);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(85, 43);
            this.btnAddOrder.TabIndex = 6;
            this.btnAddOrder.Text = "&Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(215, 362);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 43);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReadOrders
            // 
            this.btnReadOrders.Location = new System.Drawing.Point(384, 362);
            this.btnReadOrders.Name = "btnReadOrders";
            this.btnReadOrders.Size = new System.Drawing.Size(85, 43);
            this.btnReadOrders.TabIndex = 8;
            this.btnReadOrders.Text = "&Read Orders";
            this.btnReadOrders.UseVisualStyleBackColor = true;
            this.btnReadOrders.Click += new System.EventHandler(this.btnReadOrders_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(553, 362);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 43);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // OrderForm
            // 
            this.AcceptButton = this.btnAddOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReadOrders);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.lblGrandTotalDisplay);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.cboOrderSelect);
            this.Controls.Add(this.lstOrders);
            this.Controls.Add(this.txtNameEntry);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNameEntry;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.ComboBox cboOrderSelect;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblGrandTotalDisplay;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReadOrders;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
    }
}


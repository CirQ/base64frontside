namespace Base64Tool {
    partial class Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.enBtn = new System.Windows.Forms.Button();
            this.deBtn = new System.Windows.Forms.Button();
            this.plain = new System.Windows.Forms.TextBox();
            this.cipher = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enBtn
            // 
            this.enBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.enBtn.Font = new System.Drawing.Font("FZMiaoWuS-GB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enBtn.Location = new System.Drawing.Point(219, 57);
            this.enBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.enBtn.Name = "enBtn";
            this.enBtn.Size = new System.Drawing.Size(120, 40);
            this.enBtn.TabIndex = 2;
            this.enBtn.TabStop = false;
            this.enBtn.Text = "◥Encode◤";
            this.enBtn.UseVisualStyleBackColor = false;
            this.enBtn.Click += new System.EventHandler(this.enBtn_Click);
            // 
            // deBtn
            // 
            this.deBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deBtn.Font = new System.Drawing.Font("FZMiaoWuS-GB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deBtn.Location = new System.Drawing.Point(444, 57);
            this.deBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.deBtn.Name = "deBtn";
            this.deBtn.Size = new System.Drawing.Size(120, 40);
            this.deBtn.TabIndex = 3;
            this.deBtn.TabStop = false;
            this.deBtn.Text = "◢Decode◣";
            this.deBtn.UseVisualStyleBackColor = false;
            this.deBtn.Click += new System.EventHandler(this.deBtn_Click);
            // 
            // plain
            // 
            this.plain.Location = new System.Drawing.Point(20, 20);
            this.plain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.plain.Name = "plain";
            this.plain.Size = new System.Drawing.Size(743, 34);
            this.plain.TabIndex = 0;
            // 
            // cipher
            // 
            this.cipher.Location = new System.Drawing.Point(20, 100);
            this.cipher.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cipher.Name = "cipher";
            this.cipher.Size = new System.Drawing.Size(743, 34);
            this.cipher.TabIndex = 1;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(782, 153);
            this.Controls.Add(this.cipher);
            this.Controls.Add(this.plain);
            this.Controls.Add(this.deBtn);
            this.Controls.Add(this.enBtn);
            this.Font = new System.Drawing.Font("FZMiaoWuS-GB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Base64Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enBtn;
        private System.Windows.Forms.Button deBtn;
        private System.Windows.Forms.TextBox plain;
        private System.Windows.Forms.TextBox cipher;
    }
}


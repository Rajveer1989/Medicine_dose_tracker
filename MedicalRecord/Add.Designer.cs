namespace MedicalRecord
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmedicine = new System.Windows.Forms.TextBox();
            this.txtdosabge = new System.Windows.Forms.TextBox();
            this.txtfrequ = new System.Windows.Forms.TextBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.White;
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(249, 224);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(89, 34);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save";
            this.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // btncancle
            // 
            this.btncancle.BackColor = System.Drawing.Color.White;
            this.btncancle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancle.Location = new System.Drawing.Point(344, 224);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(93, 34);
            this.btncancle.TabIndex = 1;
            this.btncancle.Text = "Cancle";
            this.btncancle.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Medicine Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dosage ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Frequency ";
            // 
            // txtmedicine
            // 
            this.txtmedicine.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmedicine.Location = new System.Drawing.Point(249, 49);
            this.txtmedicine.Name = "txtmedicine";
            this.txtmedicine.Size = new System.Drawing.Size(188, 26);
            this.txtmedicine.TabIndex = 5;
            this.txtmedicine.Validating += new System.ComponentModel.CancelEventHandler(this.txtmedicine_Validating);
            this.txtmedicine.Validated += new System.EventHandler(this.txtmedicine_Validated);
            // 
            // txtdosabge
            // 
            this.txtdosabge.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdosabge.Location = new System.Drawing.Point(249, 94);
            this.txtdosabge.Name = "txtdosabge";
            this.txtdosabge.Size = new System.Drawing.Size(188, 26);
            this.txtdosabge.TabIndex = 6;
            this.txtdosabge.Validating += new System.ComponentModel.CancelEventHandler(this.txtdosabge_Validating);
            this.txtdosabge.Validated += new System.EventHandler(this.txtdosabge_Validated);
            // 
            // txtfrequ
            // 
            this.txtfrequ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfrequ.Location = new System.Drawing.Point(249, 144);
            this.txtfrequ.Name = "txtfrequ";
            this.txtfrequ.Size = new System.Drawing.Size(188, 26);
            this.txtfrequ.TabIndex = 7;
            this.txtfrequ.Validating += new System.ComponentModel.CancelEventHandler(this.txtfrequ_Validating);
            this.txtfrequ.Validated += new System.EventHandler(this.txtfrequ_Validated);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.Location = new System.Drawing.Point(228, 189);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 19);
            this.lblerror.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 276);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.txtfrequ);
            this.Controls.Add(this.txtdosabge);
            this.Controls.Add(this.txtmedicine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.btnsave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmedicine;
        private System.Windows.Forms.TextBox txtdosabge;
        private System.Windows.Forms.TextBox txtfrequ;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

namespace BancoABC
{
    partial class Form4
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
            this.texUser = new System.Windows.Forms.TextBox();
            this.but_envio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textVal_Depositar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // texUser
            // 
            this.texUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.texUser.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.texUser.Location = new System.Drawing.Point(363, 105);
            this.texUser.Name = "texUser";
            this.texUser.ReadOnly = true;
            this.texUser.Size = new System.Drawing.Size(127, 23);
            this.texUser.TabIndex = 12;
            this.texUser.TextChanged += new System.EventHandler(this.textUser_TextChanged);
            // 
            // but_envio
            // 
            this.but_envio.Location = new System.Drawing.Point(533, 286);
            this.but_envio.Name = "but_envio";
            this.but_envio.Size = new System.Drawing.Size(35, 35);
            this.but_envio.TabIndex = 11;
            this.but_envio.UseVisualStyleBackColor = true;
            this.but_envio.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.label3.Location = new System.Drawing.Point(291, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "CONFIRMAR DEPOSITO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textVal_Depositar
            // 
            this.textVal_Depositar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(140)))), ((int)(((byte)(152)))));
            this.textVal_Depositar.Location = new System.Drawing.Point(363, 180);
            this.textVal_Depositar.Name = "textVal_Depositar";
            this.textVal_Depositar.Size = new System.Drawing.Size(127, 23);
            this.textVal_Depositar.TabIndex = 9;
            this.textVal_Depositar.TextChanged += new System.EventHandler(this.textval_retirar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.label2.Location = new System.Drawing.Point(107, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "VALOR A DEPOSITAR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(233)))), ((int)(((byte)(228)))));
            this.label1.Location = new System.Drawing.Point(107, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "N° CUENTA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(601, 356);
            this.Controls.Add(this.texUser);
            this.Controls.Add(this.but_envio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textVal_Depositar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texUser;
        private System.Windows.Forms.Button but_envio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textVal_Depositar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
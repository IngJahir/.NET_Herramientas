
namespace CRUD
{
    partial class FrmNuevo
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Depertamento = new System.Windows.Forms.TextBox();
            this.tb_Id_Depertamento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id_Departamento";
            // 
            // tb_Depertamento
            // 
            this.tb_Depertamento.Location = new System.Drawing.Point(163, 31);
            this.tb_Depertamento.Name = "tb_Depertamento";
            this.tb_Depertamento.Size = new System.Drawing.Size(100, 20);
            this.tb_Depertamento.TabIndex = 2;
            // 
            // tb_Id_Depertamento
            // 
            this.tb_Id_Depertamento.Location = new System.Drawing.Point(163, 73);
            this.tb_Id_Depertamento.Name = "tb_Id_Depertamento";
            this.tb_Id_Depertamento.Size = new System.Drawing.Size(100, 20);
            this.tb_Id_Depertamento.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 174);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_Id_Depertamento);
            this.Controls.Add(this.tb_Depertamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNuevo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Depertamento;
        private System.Windows.Forms.TextBox tb_Id_Depertamento;
        private System.Windows.Forms.Button button1;
    }
}
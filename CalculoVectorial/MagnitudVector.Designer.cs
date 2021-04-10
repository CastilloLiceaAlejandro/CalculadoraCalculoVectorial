namespace CalculoVectorial
{
	partial class MagnitudVector
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
			this.btnRealizar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.valor_i = new System.Windows.Forms.TextBox();
			this.valor_k = new System.Windows.Forms.TextBox();
			this.valor_j = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.Resultado_Magnitud = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnRealizar
			// 
			this.btnRealizar.AccessibleName = "btRealizar";
			this.btnRealizar.Location = new System.Drawing.Point(12, 87);
			this.btnRealizar.Name = "btnRealizar";
			this.btnRealizar.Size = new System.Drawing.Size(92, 30);
			this.btnRealizar.TabIndex = 0;
			this.btnRealizar.Text = "Realizar";
			this.btnRealizar.UseVisualStyleBackColor = true;
			this.btnRealizar.Click += new System.EventHandler(this.btnRealizar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(9, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "i";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(9, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "j";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "k";
			// 
			// valor_i
			// 
			this.valor_i.AccessibleName = "";
			this.valor_i.Location = new System.Drawing.Point(48, 9);
			this.valor_i.Name = "valor_i";
			this.valor_i.Size = new System.Drawing.Size(56, 20);
			this.valor_i.TabIndex = 4;
			// 
			// valor_k
			// 
			this.valor_k.AccessibleName = "";
			this.valor_k.Location = new System.Drawing.Point(48, 61);
			this.valor_k.Name = "valor_k";
			this.valor_k.Size = new System.Drawing.Size(56, 20);
			this.valor_k.TabIndex = 5;
			// 
			// valor_j
			// 
			this.valor_j.AccessibleName = "";
			this.valor_j.Location = new System.Drawing.Point(48, 35);
			this.valor_j.Name = "valor_j";
			this.valor_j.Size = new System.Drawing.Size(56, 20);
			this.valor_j.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "=";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(29, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(13, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "=";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(29, 12);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(13, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "=";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 126);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(21, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "R=";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// Resultado_Magnitud
			// 
			this.Resultado_Magnitud.Location = new System.Drawing.Point(32, 123);
			this.Resultado_Magnitud.Name = "Resultado_Magnitud";
			this.Resultado_Magnitud.Size = new System.Drawing.Size(72, 20);
			this.Resultado_Magnitud.TabIndex = 11;
			// 
			// MagnitudVector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(120, 163);
			this.Controls.Add(this.Resultado_Magnitud);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.valor_j);
			this.Controls.Add(this.valor_k);
			this.Controls.Add(this.valor_i);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnRealizar);
			this.Name = "MagnitudVector";
			this.Text = "MagnitudVector";
			this.Load += new System.EventHandler(this.MagnitudVector_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRealizar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox valor_i;
		private System.Windows.Forms.TextBox valor_k;
		private System.Windows.Forms.TextBox valor_j;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox Resultado_Magnitud;
	}
}
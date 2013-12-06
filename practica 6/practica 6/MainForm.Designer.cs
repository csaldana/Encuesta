/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 31/10/2013
 * Time: 05:39 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace practica_6
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textcod = new System.Windows.Forms.TextBox();
			this.textnom = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.radDF = new System.Windows.Forms.RadioButton();
			this.radguadalajara = new System.Windows.Forms.RadioButton();
			this.radmonterrey = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.checkportugal = new System.Windows.Forms.CheckBox();
			this.checkchile = new System.Windows.Forms.CheckBox();
			this.checkreinounido = new System.Windows.Forms.CheckBox();
			this.checkmacedonia = new System.Windows.Forms.CheckBox();
			this.checkaustralia = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.Calendario = new System.Windows.Forms.MonthCalendar();
			this.label6 = new System.Windows.Forms.Label();
			this.butTerminar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Codigo";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre";
			// 
			// textcod
			// 
			this.textcod.Location = new System.Drawing.Point(56, 15);
			this.textcod.Name = "textcod";
			this.textcod.Size = new System.Drawing.Size(100, 20);
			this.textcod.TabIndex = 2;
			// 
			// textnom
			// 
			this.textnom.Location = new System.Drawing.Point(56, 50);
			this.textnom.Name = "textnom";
			this.textnom.Size = new System.Drawing.Size(100, 20);
			this.textnom.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "1- Capital de mexico?";
			// 
			// radDF
			// 
			this.radDF.Location = new System.Drawing.Point(13, 113);
			this.radDF.Name = "radDF";
			this.radDF.Size = new System.Drawing.Size(104, 24);
			this.radDF.TabIndex = 5;
			this.radDF.TabStop = true;
			this.radDF.Text = "DF";
			this.radDF.UseVisualStyleBackColor = true;
			// 
			// radguadalajara
			// 
			this.radguadalajara.Location = new System.Drawing.Point(13, 144);
			this.radguadalajara.Name = "radguadalajara";
			this.radguadalajara.Size = new System.Drawing.Size(104, 24);
			this.radguadalajara.TabIndex = 6;
			this.radguadalajara.TabStop = true;
			this.radguadalajara.Text = "Guadalajara";
			this.radguadalajara.UseVisualStyleBackColor = true;
			// 
			// radmonterrey
			// 
			this.radmonterrey.Location = new System.Drawing.Point(13, 174);
			this.radmonterrey.Name = "radmonterrey";
			this.radmonterrey.Size = new System.Drawing.Size(104, 24);
			this.radmonterrey.TabIndex = 7;
			this.radmonterrey.TabStop = true;
			this.radmonterrey.Text = "Monterrey";
			this.radmonterrey.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(9, 266);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "2- Paises de europa?";
			// 
			// checkportugal
			// 
			this.checkportugal.Location = new System.Drawing.Point(9, 292);
			this.checkportugal.Name = "checkportugal";
			this.checkportugal.Size = new System.Drawing.Size(104, 24);
			this.checkportugal.TabIndex = 9;
			this.checkportugal.Text = "Portugal";
			this.checkportugal.UseVisualStyleBackColor = true;
			// 
			// checkchile
			// 
			this.checkchile.Location = new System.Drawing.Point(9, 322);
			this.checkchile.Name = "checkchile";
			this.checkchile.Size = new System.Drawing.Size(104, 24);
			this.checkchile.TabIndex = 10;
			this.checkchile.Text = "Chile";
			this.checkchile.UseVisualStyleBackColor = true;
			// 
			// checkreinounido
			// 
			this.checkreinounido.Location = new System.Drawing.Point(9, 352);
			this.checkreinounido.Name = "checkreinounido";
			this.checkreinounido.Size = new System.Drawing.Size(104, 24);
			this.checkreinounido.TabIndex = 11;
			this.checkreinounido.Text = "Reino Unido";
			this.checkreinounido.UseVisualStyleBackColor = true;
			// 
			// checkmacedonia
			// 
			this.checkmacedonia.Location = new System.Drawing.Point(9, 382);
			this.checkmacedonia.Name = "checkmacedonia";
			this.checkmacedonia.Size = new System.Drawing.Size(104, 24);
			this.checkmacedonia.TabIndex = 12;
			this.checkmacedonia.Text = "Macedonia";
			this.checkmacedonia.UseVisualStyleBackColor = true;
			// 
			// checkaustralia
			// 
			this.checkaustralia.Location = new System.Drawing.Point(9, 412);
			this.checkaustralia.Name = "checkaustralia";
			this.checkaustralia.Size = new System.Drawing.Size(104, 24);
			this.checkaustralia.TabIndex = 13;
			this.checkaustralia.Text = "Australia";
			this.checkaustralia.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(156, 87);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(283, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "3- Cantidad de estados de los que se compone mexico?";
			this.label5.Click += new System.EventHandler(this.Label5Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(168, 117);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(34, 20);
			this.numericUpDown1.TabIndex = 15;
			// 
			// Calendario
			// 
			this.Calendario.Location = new System.Drawing.Point(207, 238);
			this.Calendario.Name = "Calendario";
			this.Calendario.TabIndex = 16;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(207, 206);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(202, 23);
			this.label6.TabIndex = 17;
			this.label6.Text = "4- Dia en que termino la guerra mundial?";
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// butTerminar
			// 
			this.butTerminar.Location = new System.Drawing.Point(345, 412);
			this.butTerminar.Name = "butTerminar";
			this.butTerminar.Size = new System.Drawing.Size(75, 23);
			this.butTerminar.TabIndex = 18;
			this.butTerminar.Text = "Terminar";
			this.butTerminar.UseVisualStyleBackColor = true;
			this.butTerminar.Click += new System.EventHandler(this.ButTerminarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(499, 468);
			this.Controls.Add(this.butTerminar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Calendario);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.checkaustralia);
			this.Controls.Add(this.checkmacedonia);
			this.Controls.Add(this.checkreinounido);
			this.Controls.Add(this.checkchile);
			this.Controls.Add(this.checkportugal);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.radmonterrey);
			this.Controls.Add(this.radguadalajara);
			this.Controls.Add(this.radDF);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textnom);
			this.Controls.Add(this.textcod);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "practica 6";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button butTerminar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.MonthCalendar Calendario;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox checkaustralia;
		private System.Windows.Forms.CheckBox checkmacedonia;
		private System.Windows.Forms.CheckBox checkreinounido;
		private System.Windows.Forms.CheckBox checkchile;
		private System.Windows.Forms.CheckBox checkportugal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton radmonterrey;
		private System.Windows.Forms.RadioButton radguadalajara;
		private System.Windows.Forms.RadioButton radDF;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textnom;
		private System.Windows.Forms.TextBox textcod;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

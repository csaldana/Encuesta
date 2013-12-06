/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 31/10/2013
 * Time: 05:39 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace practica_6
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label6Click(object sender, EventArgs e)
		{
			
		}
		
		void ButTerminarClick(object sender, EventArgs e)
		{
		    string fecha = Calendario.SelectionStart.ToShortDateString();
			string nom = this.textnom.Text;
			string codigo = this.textcod.Text;
			
			
			
			string capital;
			int aciertos = 0;
			if(this.radDF.Checked){
				capital = "DF";
				aciertos++;
			}
			
			
			string europa;
			if(this.checkportugal.Checked){
				europa = "Portugal";
				aciertos++;
				}
			if(this.checkreinounido.Checked){
				europa = "Reino Unido";
				aciertos++;
			}
			if(this.checkmacedonia.Checked){
				europa = "Macedonia";
				aciertos++;
			}
			string estados;
			if(this.numericUpDown1.Text == "31"){
				aciertos++;
			}


            string valorCalendario = Calendario.SelectionRange.Start.ToShortDateString();
            if (valorCalendario == "07/05/1945")
            {
				aciertos++;
			}
			
			
			
			MessageBox.Show("Nombre:"+"\t" + nom + "\n" +"Codigo:" + "\t" + codigo + "\n"+
			                "Aciertos:" +"\t" + aciertos);
			                
			
		}
		
		void Label5Click(object sender, EventArgs e)
		{
			
		}
	}
}

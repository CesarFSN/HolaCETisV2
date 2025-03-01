/*
 * Creado por SharpDevelop.
 * Usuario: Cesar Fernando
 * Fecha: 26/02/2025
 * Hora: 01:19 p. m.
 * Programa: HolaMundo
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HolaMundo_SNCF
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
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void BtnAceptarClick(object sender, EventArgs e)
		{
			DialogResult opcion;
			opcion=MessageBox.Show("¿Realmente Desea Salir?", "Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			
			if(opcion==DialogResult.Yes)
			{
				this.Close();
			}
			
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
	
		}
	}
}

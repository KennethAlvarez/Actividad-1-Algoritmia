/*
 * Created by SharpDevelop.
 * User: 1GX69LA_RS4
 * Date: 25/08/2019
 * Time: 12:52 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AlgoritmiaAct1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Bitmap bm;
		List<Circulo> cLista = new List<Circulo>();
		int contador = 0;
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
		
		void ButtonSelectImageClick(object sender, EventArgs e)
		{
			string dir_archivo;
			this.openFileDialog1.ShowDialog();
			dir_archivo = this.openFileDialog1.FileName;
			bm = new Bitmap(dir_archivo);
			pictureBox1.Image = bm;
			buttonAnalisis.Enabled = true;
			cLista.Clear();
		}
		
		void ButtonAnalisisClick(object sender, EventArgs e)
		{
			Point centro;
			int radio = 0;
			contador = 0;
			for(int i = 0; i<bm.Height-1;i++)
			{
				for(int j = 0; j<bm.Width-1;j++)
				{
					if(Color.Equals(bm.GetPixel(j,i), Color.FromArgb(0,0,0))){
						centro = obtenerCentro(j, i);
						radio = obtenerRadio(centro);
						dibujarCirculo(j,i,radio);

						if(radio != -1)
						{
							Circulo c = new Circulo(radio, contador, centro.X, centro.Y);	
							dibujarCentro(c.getPoint().X, c.getPoint().Y);
							cLista.Add(c);
						}
						contador++;
					}
				}		
				pictureBox1.Image = bm;
			}
			listarCirculos();

		}
		private void dibujarCentro(int x, int y)
		{
			int k = 10;

	   		for(int i = -k; i<k;i++)
	   		{
	   			for(int j = -k; j<k;j++)
	   			{
	   				bm.SetPixel(x+i, y+j, Color.Red);	   
	   			}	   	

	   		}

		} 
		void listarCirculos()
		{
			listView1.Items.Clear();
			int i =0;
			while(i<cLista.Count)
			{
				ListViewItem item = new ListViewItem(cLista[i].getID().ToString());
				item.SubItems.Add(cLista[i].getRadio().ToString());
				item.SubItems.Add(cLista[i].getPoint().X.ToString());
				item.SubItems.Add(cLista[i].getPoint().Y.ToString());
				listView1.Items.Add(item);
				i++;
			}
		}
		void dibujarCirculo(int x, int y, int rdo)
		{
			Color col;
			if(rdo == -1)
			{contador--;
				col = Color.FromArgb(255,255,255);
			}else
			{
				col = Color.Blue;
				
			}
			int _x = x+1;
			int _y = y;
			int cont;
			while(bm.GetPixel(_x, _y) != Color.FromArgb(255,255,255))
			{
			    cont = 0;
			    while(bm.GetPixel(_x, _y) != Color.FromArgb(255, 255, 255))
			    {
			      bm.SetPixel(_x, _y, col);
				  cont++; 	
					_x++;

			   	}			   
			    _y++;
				_x=x;
			   //pictureBox1.Refresh();
	     	}
			_x = x;
			x--;
			_y = y;
			while(bm.GetPixel(_x, _y) != Color.FromArgb(255,255,255))
			{
			    cont = 0;
			    while(bm.GetPixel(_x, _y) != Color.FromArgb(255, 255, 255))
			    {
			      bm.SetPixel(_x, _y, col);
				  cont++; 	
					_x--;
			   	}			   
			    _y++;
				_x=x;
			//pictureBox1.Refresh();
	     	}		
			pictureBox1.Refresh();

		}
		Point obtenerCentro(int x, int y)
		{
			int aux=0;
			int auxy=0;
			aux = x;
			auxy = y;
			//MessageBox.Show("antes x: "+aux+" y: "+auxy);
			while(bm.GetPixel(aux, auxy) == Color.FromArgb(0, 0, 0))
			{
				aux++;
			}
			int xTotal = (aux-x)/2;
			aux = x;
			while(bm.GetPixel(aux, auxy) == Color.FromArgb(0, 0, 0))
			{
				auxy++;
			}
			int yTotal = (auxy-y)/2;
			Point centro = new Point((xTotal+x), (yTotal+y));
			//MessageBox.Show("Total: "+(xTotal+x)+" "+(yTotal+y));
			return centro;
			
		}
		int obtenerRadio(Point p)
		{	
			int _x = p.X;
			int _y = p.Y;
			int contx = 0;
			int conty = 0;
			while(bm.GetPixel(_x, p.Y) != Color.FromArgb(255,255,255))
			{
				_x++;
				contx++;
				
			}
			while(bm.GetPixel(p.X, _y) != Color.FromArgb(255,255,255))
			{
				_y++;
				conty++;
			}
			int diferencia = conty-contx;
		//	MessageBox.Show("_x "+contx+" _y: "+conty);
		//	MessageBox.Show("diferencia: "+diferencia);
			if(diferencia > 10 || diferencia < -10)
			return -1;
			
			return conty;
		}
		
	}
}

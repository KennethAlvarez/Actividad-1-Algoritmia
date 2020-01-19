/*
 * Created by SharpDevelop.
 * User: 1GX69LA_RS4
 * Date: 25/08/2019
 * Time: 12:54 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Collections.Generic;
namespace AlgoritmiaAct1
{
	/// <summary>
	/// Description of Circulo.
	/// </summary>
	public class Circulo
	{
		private int radio;
		private int ID;
		private Point coordenadas;
		public Circulo(int r, int i, int posx, int posy)
		{
			this.radio = r;
			this.ID = i;
			this.coordenadas = new Point(posx, posy);
		}
		public int getRadio(){
			return radio;
		}
		public int getID()
		{
			return ID;
		}
		public Point getPoint()
		{
			return coordenadas;
		}
	}
}

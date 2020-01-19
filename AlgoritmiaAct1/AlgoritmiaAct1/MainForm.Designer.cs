/*
 * Created by SharpDevelop.
 * User: 1GX69LA_RS4
 * Date: 25/08/2019
 * Time: 12:52 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AlgoritmiaAct1
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
			this.buttonSelectImage = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.buttonAnalisis = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.ID = new System.Windows.Forms.ColumnHeader();
			this.Radio = new System.Windows.Forms.ColumnHeader();
			this.X = new System.Windows.Forms.ColumnHeader();
			this.Y = new System.Windows.Forms.ColumnHeader();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonSelectImage
			// 
			this.buttonSelectImage.Location = new System.Drawing.Point(12, 416);
			this.buttonSelectImage.Name = "buttonSelectImage";
			this.buttonSelectImage.Size = new System.Drawing.Size(90, 38);
			this.buttonSelectImage.TabIndex = 0;
			this.buttonSelectImage.Text = "Seleccionar imagen";
			this.buttonSelectImage.UseVisualStyleBackColor = true;
			this.buttonSelectImage.Click += new System.EventHandler(this.ButtonSelectImageClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(633, 398);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// buttonAnalisis
			// 
			this.buttonAnalisis.Enabled = false;
			this.buttonAnalisis.Location = new System.Drawing.Point(108, 416);
			this.buttonAnalisis.Name = "buttonAnalisis";
			this.buttonAnalisis.Size = new System.Drawing.Size(90, 38);
			this.buttonAnalisis.TabIndex = 2;
			this.buttonAnalisis.Text = "Empezar análisis";
			this.buttonAnalisis.UseVisualStyleBackColor = true;
			this.buttonAnalisis.Click += new System.EventHandler(this.ButtonAnalisisClick);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.ID,
									this.Radio,
									this.X,
									this.Y});
			this.listView1.Location = new System.Drawing.Point(651, 12);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(305, 308);
			this.listView1.TabIndex = 3;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// ID
			// 
			this.ID.Tag = "ID";
			this.ID.Text = "ID";
			// 
			// Radio
			// 
			this.Radio.Tag = "Radio";
			this.Radio.Text = "Radio";
			this.Radio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// X
			// 
			this.X.Tag = "X";
			this.X.Text = "X";
			this.X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Y
			// 
			this.Y.Tag = "Y";
			this.Y.Text = "Y";
			this.Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(968, 471);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.buttonAnalisis);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonSelectImage);
			this.Name = "MainForm";
			this.Text = "AlgoritmiaAct1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ColumnHeader Y;
		private System.Windows.Forms.ColumnHeader X;
		private System.Windows.Forms.ColumnHeader Radio;
		private System.Windows.Forms.ColumnHeader ID;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button buttonAnalisis;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonSelectImage;
	}
}

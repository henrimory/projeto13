/*
 * Created by SharpDevelop.
 * User: henrique
 * Date: 02/10/2019
 * Time: 08:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace projeto13
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
		
			InitializeComponent();		
	
		
		}
		
		int p1,p2,ptPc=0,ptJog=0,j1,j2,j3,j4,j5;
		Random rnd = new Random();
				
		void Button1Click(object sender, EventArgs e)
		{		
			pictureBox1.Load("inter.png");
			pictureBox2.Load("inter.png");
			
			
			pictureBox5.Load("inter.png");
			pictureBox6.Load("inter.png");
			pictureBox7.Load("inter.png");
			
			pictureBox5.Enabled = true;
			pictureBox6.Enabled = true;
			pictureBox7.Enabled = true;
			pictureBox6.Visible=false;
			pictureBox7.Visible=false;
			
			
			j1 = rnd.Next(1,7);
			j2 = rnd.Next(1,7);
			ptJog = j1 + j2;
			pictureBox3.Load("dado"+ j1 + ".jpg" );
			pictureBox4.Load("dado"+ j2 + ".jpg" );			
			label4.Text = ptJog.ToString();	
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			p1 = rnd.Next(1,7);
			p2 = rnd.Next(1,7);
			ptPc = p1 + p2;
			pictureBox1.Load("dado"+ p1 + ".jpg" );
			pictureBox2.Load("dado"+ p2 + ".jpg" );			
			label3.Text = ptPc.ToString();
			
			if(ptJog>13){
					MessageBox.Show("Voce perdeu, e eu ganhei otario!!");
					
				}else if (ptPc > 13){
					MessageBox.Show("Eu perdi,estourei os pontos!!!");
						
				}else if (ptJog == ptPc){
					MessageBox.Show("Empate é meu, trouxa!!!");
						
				}else if(ptJog == 13){
					MessageBox.Show("Você ganhou,muito bem!");
				}
				
				else if (ptPc == 13){
					MessageBox.Show("Voce perdeu");
			}
		}		
	
		void PictureBox5Click(object sender, EventArgs e)
		{
			j3= rnd.Next(1,7);
			ptJog+=j3;
			pictureBox5.Load("dado"+ j3 + ".jpg" );
			label4.Text = ptJog.ToString();
			pictureBox6.Visible = true;
			pictureBox6.Enabled = true;
		}
		
		void PictureBox6Click(object sender, EventArgs e)
		{
			j4= rnd.Next(1,7);
			ptJog+=j4;
			pictureBox6.Load("dado"+ j4 + ".jpg" );
			label4.Text = ptJog.ToString();
			pictureBox7.Visible = true;
			pictureBox6.Enabled = true;
		}
		
		void PictureBox7Click(object sender, EventArgs e)
		{
			j5= rnd.Next(1,7);
			ptJog+=j5;
			pictureBox7.Load("dado"+ j5 + ".jpg" );
			label4.Text = ptJog.ToString();			
			pictureBox7.Enabled = true;
	
		}
		void Button3Click(object sender, EventArgs e)
		{
			label3.Text ="";
			label4.Text ="";
			ptJog=0;
			ptPc=0;
		}
		
		
	}
}

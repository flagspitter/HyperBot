using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyperBot
{
	public partial class MainWindow : Form
	{
		private int BlockSize = 32;
		private int xNum = 20;
		private int yNum = 20;
		private int ofsLine = 1;
		
		private Field MainField;
		
		public MainWindow()
		{
			InitializeComponent();
		}
		
		private void MainWindow_Load(object sender, EventArgs e)
		{
			MainField = new Field( xNum, yNum );
			
			this.Height = BlockSize * yNum + 4 + ( this.Height - splTop.Height );
			this.Width  = BlockSize * xNum + 4 + ( this.Width - splTop.Panel2.Width );
			
			#if false
			// test
			MainField.SetWall_X( 1, 1 );
			MainField.SetWall_X( 2, 2 );
			MainField.SetWall_Y( 3, 3 );
			MainField.SetWall_Y( 4, 4 );
			#endif
		}
		
		private void MainWindow_Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		private void picField_Paint(object sender, PaintEventArgs e)
		{
			int x0, x1;
			int y0, y1;
			
			Pen p0 = Pens.LightGray;  // 通路
			
			// 下地( | )を描画
			x0 = 0;
			x1 = BlockSize * xNum;
			for( int i=0; i<xNum+1; i++ )
			{
				y0 = i * BlockSize + ofsLine;
				y1 = i * BlockSize + ofsLine;
				
				e.Graphics.DrawLine( p0, x0, y0, x1, y1 );
			}
			
			// 下地( - )を描画
			y0 = 0;
			y1 = BlockSize * yNum + ofsLine;
			for( int i=0; i<yNum+1; i++ )
			{
				x0 = i * BlockSize + ofsLine;
				x1 = i * BlockSize + ofsLine;
				
				e.Graphics.DrawLine( p0, x0, y0, x1, y1 );
			}
			
			using( Pen p1 = new Pen( Color.Black, 3 ) )
			{
				// 壁( | )を描画
				for( int i=0; i<yNum; i++ )
				{
					y0 = i * BlockSize + ofsLine;
					y1 = y0 + BlockSize;
					foreach( var tg in MainField.GetWalls_X( i ) )
					{
						x0 = x1 = tg * BlockSize + ofsLine;
						e.Graphics.DrawLine( p1, x0, y0, x1, y1 );
					}
				}
				
				// 壁( - )を描画
				for( int i=0; i<xNum; i++ )
				{
					x0 = i * BlockSize + ofsLine;
					x1 = x0 + BlockSize;
					foreach( var tg in MainField.GetWalls_Y( i ) )
					{
						y0 = y1 = tg * BlockSize + ofsLine;
						e.Graphics.DrawLine( p1, x0, y0, x1, y1 );
					}
				}
			}
		}
	}
}

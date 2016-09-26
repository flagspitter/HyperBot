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
		private int xNum = 16;
		private int yNum = 16;
		private int ofsLine = 1;
		
		private Field MainField;
		
		#region 初期化関係
		
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
		
		#endregion
		
		#region 描画関係
		
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
			
			// 現在選択中の位置を描画
			using( Pen p1 = new Pen( Color.Red, 2 ) )
			{
				if( isVertical )
				{
					x0 = curX * BlockSize + ofsLine - 1;
					x1 = 3;
					y0 = curY * BlockSize + ofsLine;
					y1 = BlockSize;
				}
				else
				{
					x0 = curX * BlockSize + ofsLine;
					x1 = BlockSize;
					y0 = curY * BlockSize + ofsLine - 1;
					y1 = 3;
				}
				e.Graphics.DrawRectangle( p1, x0, y0, x1, y1 );
			}
		}
		#endregion
		
		#region 操作関係のイベント
		
		private int curX;
		private int curY;
		private bool isVertical;
		
		private void picField_MouseMove(object sender, MouseEventArgs e)
		{
			int nextX = Point2Num( e.X, BlockSize,  isVertical );
			int nextY = Point2Num( e.Y, BlockSize, !isVertical );
			
			if( ( nextX != curX ) || ( nextY != curY ) )
			{
				curX = nextX;
				curY = nextY;
				splTop.Panel2.Refresh();
				
				Console.WriteLine( curX.ToString() + ", " + curY.ToString() );
			}
		}
		
		static private int Point2Num( int pos, int unit, bool revise )
		{
			int revCoef = revise ? unit / 2 : 0;
			return ( pos + revCoef ) / unit;
		}
		
		private void picField_MouseDown(object sender, MouseEventArgs e)
		{
			if( e.Button == MouseButtons.Right )
			{
				ToggleVH();
			}
			
			if( e.Button == MouseButtons.Left )
			{
				SetWall();
			}
		}
		
		private void ToggleVH()
		{
			isVertical = !isVertical;
			splTop.Panel2.Refresh();
		}
		
		private void SetWall()
		{
			if( isVertical )
			{
				MainField.ToggleWall_X( curX, curY );
			}
			else
			{
				MainField.ToggleWall_Y( curX, curY );
			}
			splTop.Panel2.Refresh();
		}
		
		private void picRed_MouseDown(object sender, MouseEventArgs e)
		{
			var tg = (PictureBox)sender;
			var dde = tg.DoDragDrop( 0, DragDropEffects.All );
		}
		
		private void picGreen_MouseDown(object sender, MouseEventArgs e)
		{
			var tg = (PictureBox)sender;
			var dde = tg.DoDragDrop( 1, DragDropEffects.All );
		}
		
		private void picBlue_MouseDown(object sender, MouseEventArgs e)
		{
			var tg = (PictureBox)sender;
			var dde = tg.DoDragDrop( 2, DragDropEffects.All );
		}
		
		private void picYellow_MouseDown(object sender, MouseEventArgs e)
		{
			var tg = (PictureBox)sender;
			var dde = tg.DoDragDrop( 3, DragDropEffects.All );
		}
		
		private void picSilver_MouseDown(object sender, MouseEventArgs e)
		{
			var tg = (PictureBox)sender;
			var dde = tg.DoDragDrop( 4, DragDropEffects.All );
		}
		
		#endregion
		
		#region 左側に表示するロボ
		
		private void picRed_Paint(object sender, PaintEventArgs e)
		{
			DrawCircle( (PictureBox)sender, e.Graphics, Color.Red );
		}
		
		private void picGreen_Paint(object sender, PaintEventArgs e)
		{
			DrawCircle( (PictureBox)sender, e.Graphics, Color.Green );
		}
		
		private void picBlue_Paint(object sender, PaintEventArgs e)
		{
			DrawCircle( (PictureBox)sender, e.Graphics, Color.Blue );
		}
		
		private void picYellow_Paint(object sender, PaintEventArgs e)
		{
			DrawCircle( (PictureBox)sender, e.Graphics, Color.Gold );
		}
		
		private void picSilver_Paint(object sender, PaintEventArgs e)
		{
			DrawCircle( (PictureBox)sender, e.Graphics, Color.Gray );
		}
		
		private void DrawCircle( PictureBox target, Graphics g, Color col )
		{
			using( var p = new Pen( Color.Black, 2 ) )
			{
				g.DrawRectangle( p, 0, 0, target.Width, target.Height );
			}
			
			using( var b = new SolidBrush( col ) )
			{
				g.FillEllipse( b, 2, 2, target.Width - 4, target.Height - 4 );
			}
		}
		#endregion
	}
}

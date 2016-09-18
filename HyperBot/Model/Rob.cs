using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyb
{
	public class Robot
	{
		#region プロパティ
		public int x { get; set; }
		public int y { get; set; }
		public string Name { get; set; }
		#endregion
		
		#region 内部変数
		private Field Parent;
		#endregion
		
		#region 初期化関係
		
		public Robot( Field p )
		{
			Parent = p;
		}
		
		#endregion
		
		#region 操作
		
		public void MoveToRight()
		{
			while( Parent.IsPassable( x, y, Parent.ToRight ) )
			{
				x++;
			}
		}
		
		public void MoveToLeft()
		{
			while( Parent.IsPassable( x, y, Parent.ToLeft ) )
			{
				x--;
			}
		}
		
		public void MoveToUp()
		{
			while( Parent.IsPassable( x, y, Parent.ToUp ) )
			{
				y--;
			}
		}
		
		public void MoveToDown()
		{
			while( Parent.IsPassable( x, y, Parent.ToDown ) )
			{
				y++;
			}
		}
		
		public bool CheckExisting( int nextX, int nextY )
		{
			return ( x == nextX ) && ( y == nextY );
		}
		
		#endregion
	}
}

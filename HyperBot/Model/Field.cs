using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperBot
{
	public class Field
	{
		#region プロパティ
		
		public int Width  { get; set; }
		public int Height { get; set; }
		
		public int Age { get; set; }
		
		#endregion
		
		#region enumのような使い方をするプロパティ
		
		public Right ToRight { get; private set; }
		public Left  ToLeft  { get; private set; }
		public Up    ToUp    { get; private set; }
		public Down  ToDown  { get; private set; }
		
		#endregion
		
		#region 内部変数
		
		private bool[,] Wall_X;
		private bool[,] Wall_Y;
		
		private List<Robot> Robs = new List<Robot>();
		
		#endregion
		
		#region 公開型
		
		public abstract class Direction
		{
			protected bool[,] Wall_X;
			protected bool[,] Wall_Y;
			
			public Direction( bool[,] x, bool[,] y )
			{
				Wall_X = x;
				Wall_Y = y;
			}
			
			public abstract bool IsWall( int x, int y );
			
			public abstract int NextX( int x );
			public abstract int NextY( int y );
		}
		
		public class Right : Direction
		{
			public Right( bool[,] x, bool[,] y ) : base( x, y )
			{
			}
			
			public override bool IsWall( int x, int y )
			{
				return Wall_X[ x + 1, y ];
			}
			
			public override int NextX( int x )
			{
				return x + 1;
			}
			
			public override int NextY( int y )
			{
				return y;
			}
		}
		
		public class Left : Direction
		{
			public Left( bool[,] x, bool[,] y ) : base( x, y )
			{
			}
			
			public override bool IsWall( int x, int y )
			{
				return Wall_X[ x, y ];
			}
			
			public override int NextX( int x )
			{
				return x - 1;
			}
			
			public override int NextY( int y )
			{
				return y;
			}
		}
		
		public class Up : Direction
		{
			public Up( bool[,] x, bool[,] y ) : base( x, y )
			{
			}
			
			public override bool IsWall( int x, int y )
			{
				return Wall_Y[ x, y ];
			}
			
			public override int NextX( int x )
			{
				return x;
			}
			
			public override int NextY( int y )
			{
				return y - 1;
			}
		}
		
		public class Down : Direction
		{
			public Down( bool[,] x, bool[,] y ) : base( x, y )
			{
			}
			
			public override bool IsWall( int x, int y )
			{
				return Wall_Y[ x, y + 1 ];
			}
			
			public override int NextX( int x )
			{
				return x;
			}
			
			public override int NextY( int y )
			{
				return y + 1;
			}
		}
		
		#endregion
		
		#region 初期化関係
		
		public Field( int x, int y )
		{
			ToRight = new Right( Wall_X, Wall_Y );
			ToLeft  = new Left ( Wall_X, Wall_Y );
			ToUp    = new Up   ( Wall_X, Wall_Y );
			ToDown  = new Down ( Wall_X, Wall_Y );
			
			Width = x;
			Height = y;
			Wall_X = new bool[x+1,y+1]; // マスの左側に壁があるか
			Wall_Y = new bool[x+1,y+1]; // マスの上側に壁があるか
			
			// 外壁(上と下)
			for( int i=0; i<x; i++ )
			{
				Wall_Y[ i, 0 ] = true;
				Wall_Y[ i, y ] = true;
			}
			
			// 外壁(左と右)
			for( int i=0; i<y; i++ )
			{
				Wall_X[ 0, i ] = true;
				Wall_X[ x, i ] = true;
			}
			
			// 中央
			Wall_X[ 9,      9 ] = true;
			Wall_X[ 9 + 2,  9 ] = true;
			Wall_X[ 9,     10 ] = true;
			Wall_X[ 9 + 2, 10 ] = true;
			
			Wall_Y[  9, 9     ] = true;
			Wall_Y[  9, 9 + 2 ] = true;
			Wall_Y[ 10, 9     ] = true;
			Wall_Y[ 10, 9 + 2 ] = true;
		}
		
		#endregion
		
		#region 操作
		
		public void AddRob( string name, int x, int y )
		{
			var r = new Robot( this );
			r.Name = name;
			r.x    = x;
			r.y    = y;
			Robs.Add( r );
		}
		
		public bool IsPassable( int orgX, int orgY, Direction dir )
		{
			// その方向に壁がある？
			bool wall = dir.IsWall( orgX, orgY );
			
			// その方向に他のRobotがある？
			int nextX = dir.NextX( orgX );
			int nextY = dir.NextY( orgY );
			Robot Exists = Robs.Find( tg => tg.CheckExisting( nextX, nextY ) );
			
			return ( Exists == null ) && ( wall == false );
		}
		
		public void SetWall_X( int x, int y )
		{
			Wall_X[ x, y ] = true;
		}
		
		public void SetWall_Y( int x, int y )
		{
			Wall_Y[ x, y ] = true;
		}
		
		public void ResetWall_X( int x, int y )
		{
			Wall_X[ x, y ] = false;
		}
		
		public void ResetWall_Y( int x, int y )
		{
			Wall_Y[ x, y ] = !Wall_Y[ x, y ];
		}
		
		public void ToggleWall_X( int x, int y )
		{
			Wall_X[ x, y ] = !Wall_X[ x, y ];
		}
		
		public void ToggleWall_Y( int x, int y )
		{
			Wall_Y[ x, y ] = !Wall_Y[ x, y ];
		}
		
		#endregion
		
		#region イテレータ関係
		
		public IEnumerable<int> GetWalls_X( int y )
		{
			for( int i=0; i<Width + 1; i++ )
			{
				if( Wall_X[ i, y ] )
				{
					yield return i;
				}
			}
		}
		
		public IEnumerable<int> GetWalls_Y( int x )
		{
			for( int i=0; i<Height + 1; i++ )
			{
				if( Wall_Y[ x, i ] )
				{
					yield return i;
				}
			}
		}
		
		#endregion
	}
}

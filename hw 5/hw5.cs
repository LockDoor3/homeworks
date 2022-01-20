using System;
using System.Diagnostics.CodeAnalysis;

namespace hw5
{
	internal sealed class RN
	{
		private int _numerator;
		private int _denominator;


		public RN() : this(0)
		{
		}

		public RN(int x ) : this(0,0)
		{
			X = x;
			Y = 0;
		}

		public RN(int x, int y)
		{
			X = x;
			Y = y;
		}


		public int X
        {
            get { return _numerator; }
            set { _numerator = value; }
        }

		public int Y
        {
            get { return _denominator; }
            set { _denominator = value; }
        }


		public static RN operator +(RN a, RN b)
        {
			return new RN(a.X + b.X, a.Y + b.Y);
        }

		public static RN operator -(RN a, RN b)
		{
			if (a.X > b.Y & a.Y > b.Y)
				return new RN(a.X - b.X, a.Y - b.Y);
			else
				throw new Exception("«a» must be bigger than «b»!");
		}

		public static RN operator *(RN a, RN b)
		{
			return new RN(a.X * b.X, a.Y * b.Y);
		}

		public static RN operator /(RN a, RN b)
		{
			return new RN(a.X / b.X, a.Y / b.Y);
		}

		public static RN operator %(RN a, RN b)
		{
			return new RN(a.X % b.X, a.Y % b.Y);
		}

		public static RN operator ++(RN a)
		{
			a.X++;
			a.Y++;
			return a;
		}

		public static RN operator --(RN a)
		{
			a.X--;
			a.Y--;
			return a;
		}

		public static bool operator ==(RN a, RN b)
        {
			if( a is not null && b is not null)
				return (a.X == b.X && a.Y == b.Y);
			return false;
        }

		public static bool operator !=(RN a, RN b)
		{
			return (a.X != b.X || a.Y != b.Y);
		}

		public static bool operator >(RN a, RN b)
		{
			return (a.X + a.Y > b.X + b.Y);
		}

		public static bool operator <(RN a, RN b)
		{
			return (a.X + a.Y < b.X + b.Y);
		}

		public static bool operator >=(RN a, RN b)
		{
			return (a.X + a.Y >= b.X + b.Y);
		}

		public static bool operator <=(RN a, RN b)
		{
			return (a.X + a.Y <= b.X + b.Y);
		}


		public static implicit operator float(RN a)
        {
			return ((float)a.X / (float)a.Y ) ;
		}

		public static implicit operator int(RN a)
        {
			return ((int)a.X / (int)a.Y);
        }


		public override string ToString()
        {
            if (X != 0 && Y != 0 )
				return (X, Y).ToString();

			if (X != 0)
				return X.ToString();

			if (Y != 0)
				return Y.ToString();

			else
				return null;
		}

        public override int GetHashCode()
        {
            return (X, Y).GetHashCode();
        }

		public override bool Equals(object obj)
		{
			RN a = obj as RN;

			if (obj == null)
				return false;

			if (a as RN == null)
				return false;

			return a.X == this.X && a.Y == this.Y;
		}
	}
}
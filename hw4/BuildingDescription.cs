using System;
namespace hw4
{
	internal sealed class BuildingDescription
	{
		private int _id;
		private int _height;
		private int _flats;
		private int _storeys;
		private int _entrances;

		private int _floorHeight;
		private int _flatsOnEntrance;
		private int _flatsOnStorey;
		private static int _idUpper;


		public BuildingDescription() : this(0)
		{
			randomId();
		}

		public BuildingDescription(int h) :this(0,0)
        {
			randomId();
			Height = h;
		}

		public BuildingDescription(int h, int f) : this(0,0,0)
		{
			randomId();
			Height = h;
			Flats = f;
		}

		public BuildingDescription(int h, int f, int s) : this (0,0,0,0)
		{
			randomId();
			Height = h;
			Flats = f;
			Storeys = s;
		}

		public BuildingDescription(int h, int f, int s, int e)
		{
			randomId();
			Height = h;
			Flats = f;
			Storeys = s;
			Entrances = e;
		}


		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		public int Height
		{
			get { return _height; }
			set { _height = value; }
		}

		public int Flats
		{
			get { return _flats; }
			set { _flats = value; }
		}

		public int Storeys
		{
			get { return _storeys; }
			set { _storeys = value; }
		}

		public int Entrances
		{
			get { return _entrances; }
			set { _entrances = value; }
		}

		public int FloorHeight
        {
			get { return _floorHeight; }
			set { _floorHeight = value; }
        }

		public int FlatsOnEntrance
        {
            get{ return _flatsOnEntrance; }
            set { _flatsOnEntrance = value; }
        }

		public int FlatsOnStorey
        {
            get { return _flatsOnStorey; }
            set { _flatsOnStorey = value; }
        }


		public void sumFloorHeight()
		{
			if(Height == 0 || Storeys == 0)
            {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Отклонено, попробуйте добавить этажность или высоту");
				Console.ResetColor();
            }
            else
            {
				FloorHeight += Height / Storeys;
				Console.WriteLine(FloorHeight);
			}
		}

		public void sumFlatsinEntrances()
        {
			if (Flats == 0 || Entrances == 0)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Отклонено, попробуйте добавить квартиры и подъезды");
				Console.ResetColor();
			}
            else
            {
				FlatsOnEntrance = Flats / Entrances;
				Console.WriteLine(FlatsOnEntrance);

			}
        }

		public void sumFlatsOnStorey()
        {
			if (Flats == 0 || Storeys == 0)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Отклонено, попробуйте добавить квартиры и подъезды");
				Console.ResetColor();
			}
			else
			{
				FlatsOnStorey = Flats / Storeys;
				Console.WriteLine(FlatsOnStorey);

			}
		}

		private void randomId()
		{
			Random rnd = new();
			_idUpper += rnd.Next(0, 10);
			_id += _idUpper;
		}
	}
}
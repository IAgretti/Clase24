
using System;

namespace Clase24A
{
	class Program
	{
		public static void Main(string[] args)
		{
			AlbumFotos af = new AlbumFotos();
			AlbumFotos af2 = new AlbumFotos(24);
			SuperAlbum sa = new SuperAlbum();
			Console.WriteLine("El álbum predeterminado tiene " + af.NumPag + " páginas.");
			Console.WriteLine("El segundo álbum tiene " + af2.NumPag + " páginas.");
			Console.WriteLine("El súper álbum tiene " + sa.NumPag + " páginas.\n");
			      
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
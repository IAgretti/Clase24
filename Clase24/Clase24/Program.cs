
using System;

namespace Clase24
{
	
	class Program
	{
		public static void Main(string[] args)
		{
					
			AlbumFotos af = new AlbumFotos();
			AlbumFotos af2 = new AlbumFotos(24);
			SuperAlbum sa = new SuperAlbum();
			
			Console.WriteLine("El álbum por defecto tiene " + af.NumPag + " páginas.");
			Console.WriteLine("El segundo álbum tiene " + af2.NumPag + " páginas.");
			Console.WriteLine("El súper álbum tiene " + sa.NumPag + " páginas.\n");
			
//				int[] num = {2, 4, 8, 16, 32, 64, 128};
//				int[] denom = {1, 2, 0, 0, 4};
//				
//				for (int i = 0; i < num.Length; i++){
//				try{
//					Console.WriteLine("{0}/{1} = {2}", num[i],denom[i],(num[i]/denom[i]));
//				}
//				catch (DivideByZeroException e){
//					Console.WriteLine("División por cero");
//					}
//				catch (IndexOutOfRangeException e){
//					Console.WriteLine("El array está fuera de rango");
//				}
//				
//			}
		
			
//			DivNumbers dn = new DivNumbers();
//			dn.Division(25, 0);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
		
}
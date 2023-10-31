
using System;

namespace Clase24A
{
	
	public class AlbumFotos
	{
//		private int numPag;
//		public int NumPag {
//			get {return numPag;}
//			set {numPag = value;}
//		}
		public int NumPag {get; set;}
		
		public AlbumFotos()
		{
			NumPag = 16;
		}
		public AlbumFotos(int p){
			NumPag = p;
		}
	}
	class SuperAlbum: AlbumFotos {
		public SuperAlbum(){
			NumPag = 64;
		}
	}
}

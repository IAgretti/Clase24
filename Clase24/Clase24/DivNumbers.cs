
using System;

namespace Clase24
{

	public class DivNumbers
	{
		int res;
		public DivNumbers()
		{
			res = 0;
		}
		public void Division(int n1, int n2){
			try{
				res = n1/n2;
			}
			catch (DivideByZeroException e){
				Console.WriteLine("Hubo una excepción: {0}", e);
			}
			catch (Exception e){
				Console.WriteLine(e.Message);
			}
			finally{
				Console.WriteLine("Resultado: {0}", res);
			}
		}
	}
}

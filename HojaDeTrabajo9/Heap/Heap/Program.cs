using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
	public class Program
	{
		public static int Heap;
			
		static void Main(string[] args)
		{
		}
		public static void Heapify(int[] A)
		{
			Heap = A.Length - 1;

			for (int i = floop(A.Length); i >= 0; i--)
			{
				ShiftDown(A, i);
			}

		}

		public static void ShiftDown(int[] A, int i)
		{

			int izq = Izquierdo(i);
			int der = Derecho(i);

			int variable = 0;
            
			if (izq <= Heap && A[izq] > A[i])
			{
				variable = izq;
			}
			else
			{
				variable = i;
			}
			if (der <= Heap && A[der] > A[variable])
			{
				variable = der;
			}
            
			if (variable != i)
			{
				int temp = A[variable];
				A[variable] = A[i];
				A[i] = temp;
				ShiftDown(A, variable);
			}

		}

		private static int floop(int actual)
		{
			return (actual - 1)/ 2;
		}

		private static int Izquierdo(int actual)
		{
			return actual * 2 + 2;
		}

		private static int Derecho(int actual)
		{
			return actual * 2 + 1;
		}

	}
}

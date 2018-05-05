using Heap;
using System;
using Xunit;

namespace HeapTest
{
	public class HeapTest
	{
		[Fact]
		public void HeapfyTest()
		{
			int[] arreglo = { 2, 4, 9, 5, 19, 12 };
			Program.Heapify(arreglo);
			Assert.Equal(new int[] { 19, 12, 9, 5, 4, 2 }, arreglo);			
		}
	}
}

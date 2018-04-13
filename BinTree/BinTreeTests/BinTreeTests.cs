using System;
using Xunit;

namespace BinTreeTests
{
    public class BinTreeTests
    {
        [Fact]
        public void TestSuma()
        {
            IBinTree sut = new BinaryTree(
                5,
                new BinaryTree(4),
                new BinaryTree(
                    9,
                    new BinaryTree(8),
                    null
                )
            );

            Assert.Equal(26, sut.Sumar());
        }

        [Fact]
        public void TestInsert()
        {
            IBinTree sut = new BinaryTree(8);
            sut.Insert(14);
            sut.Insert(5);
            sut.Insert(56);
            sut.Insert(9);
            sut.Insert(12);
            sut.Insert(45);
            sut.Insert(8);

            int[] result = sut.ToArray();

            for (int i = 0; i < result.Length - 1; i++)
            {
                Assert.True(result[i] <= result[i + 1]);
            }
        }
    }
}

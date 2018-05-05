using ParseTree;
using System;
using Xunit;

namespace ParseTreeTest
{
    public class UnitTest1
    {
        [Fact]
        public void EvaluarTest()
        {
            ParseTree.ParseTree sut = new ParseTree.ParseTree("1+2*2+9");
            sut.Expandir();
            Assert.Equal(14, sut.Evaluar());
        }
    }
}

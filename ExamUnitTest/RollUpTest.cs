using Xunit.Abstractions;
using ExamApp;

namespace ExamUnitTest
{
    public class RollUpTest
    {
        private readonly RollUp _sut;
        

        public RollUpTest()
        {
            
            _sut = new RollUp();
        }

        [Fact]
        public void Test1()
        {
            List<Input> inputList = new List<Input>()
            {
                new Input(new GTin { Code = "G1" }, new Variant { Code = "V1" }, new Product { Code = "P1" }, 100),
                new Input(new GTin { Code = "G2" }, new Variant { Code = "V1" }, new Product { Code = "P1" }, 100),
                new Input(new GTin { Code = "G3" }, new Variant { Code = "V2" }, new Product { Code = "P1" }, 100),
                new Input(new GTin { Code = "G4" }, new Variant { Code = "V2" }, new Product { Code = "P1" }, 100)
            };
            var result = _sut.RollUpMethod(inputList);
            Assert.Equal("P1", result.Product);
            Assert.Equal(100, result.Price);
        }

        //[Fact]
        //public void Test2()
        //{
        //    List<Input> inputList = new List<Input>()
        //    {
        //        new Input(new GTin { Code = "G1" }, new Variant { Code = "V1" }, new Product { Code = "P1" }, 100),
        //        new Input(new GTin { Code = "G2" }, new Variant { Code = "V1" }, new Product { Code = "P1" }, 100),
        //        new Input(new GTin { Code = "G3" }, new Variant { Code = "V2" }, new Product { Code = "P1" }, 100),
        //        new Input(new GTin { Code = "G4" }, new Variant { Code = "V2" }, new Product { Code = "P1" }, 100),
        //        new Input(new GTin { Code = "G5" }, new Variant { Code = "V2" }, new Product { Code = "P1" }, 100)

        //    };
        //    var result = _sut.RollUpMethod(inputList);
        //    Assert.Equal("P1", result.Product);
        //    Assert.Equal(100, result.Price);
        //}

        //[Fact]
        //public void Test3()
        //{
        //    List<Input> inputList = new List<Input>()
        //    {
        //        new Input(new GTin { Code = "G1" }, new Variant { Code = "V1" }, new Product { Code = "P1" }, 100),
        //        new Input(new GTin { Code = "G2" }, new Variant { Code = "V1" }, new Product { Code = "P1" }, 100),
        //        new Input(new GTin { Code = "G3" }, new Variant { Code = "V2" }, new Product { Code = "P1" }, 100),
        //        new Input(new GTin { Code = "G4" }, new Variant { Code = "V2" }, new Product { Code = "P1" }, 100),
        //        new Input(new GTin { Code = "G5" }, new Variant { Code = "V2" }, new Product { Code = "P1" }, 100)

        //    };
        //    var result = _sut.RollUpMethod(inputList);
        //    Assert.Equal("P1", result.Product);
        //    Assert.Equal(100, result.Price);
        //}
    }
}
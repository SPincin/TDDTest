// See https://aka.ms/new-console-template for more information
using ExamApp;

Console.WriteLine("Hello, World!");
List<Input> inputList = new List<Input>()
{
    new Input(new GTin { Code = "G1" }, new Variant { Code = "V1" }, new Product { Code = "P1" }, 100),
    new Input(new GTin { Code = "G2" }, new Variant { Code = "V1" }, new Product { Code = "P1" }, 100),
    new Input(new GTin { Code = "G3" }, new Variant { Code = "V2" }, new Product { Code = "P1" }, 100),
    new Input(new GTin { Code = "G4" }, new Variant { Code = "V2" }, new Product { Code = "P1" }, 100)
};
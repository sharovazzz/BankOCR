using BankOCR.Lib;

namespace BankOCR.Tests
{
    public class Case1
    {
        [Fact]
        public void Digit0()
        {
            var fileParser = new FileParser();
            var expected = new Row([0, 0, 0, 0, 0, 0, 0, 0, 0]);

            var result = fileParser.Load("D:\\BankOCR\\BankOCR.Lib\\Case1\\Digit0.txt");

            Assert.Equal(expected.Digits, result[0].Digits);
        }

        [Fact]
        public void Digit1()
        {
            var fileParser = new FileParser();
            var expected = new Row([1, 1, 1, 1, 1, 1, 1, 1, 1]);

            var result = fileParser.Load("D:\\BankOCR\\BankOCR.Lib\\Case1\\Digit1.txt");

            Assert.Equal(expected.Digits, result[0].Digits);
        }

        [Fact]
        public void EmptyFile_ReturnsEmptyList()
        {
            var fileParser = new FileParser();

            var result = fileParser.Load("D:\\BankOCR\\BankOCR.Lib\\Case1\\EmptyFile.txt");

            Assert.Empty(result);
        }

        [Fact]
        public void NotFoundFile_ReturnsEmptyList()
        {
            var fileParser = new FileParser();

            var result = fileParser.Load("D:\\BankOCR\\BankOCR.Lib\\Case1\\NotFoundFile.txt");

            Assert.Empty(result);
        }

        [Fact]
        public void OneRowInFile_ReturnsOneRow()
        {
            var fileParser = new FileParser();

            var result = fileParser.Load("D:\\BankOCR\\BankOCR.Lib\\Case1\\1Row.txt");

            Assert.Single(result);
        }

        [Fact]
        public void TwoRowInFile_ReturnsTwoRow()
        {
            var fileParser = new FileParser();

            var result = fileParser.Load("D:\\BankOCR\\BankOCR.Lib\\Case1\\2Row.txt");

            Assert.Equal(2, result.Count);
        }
    }
}
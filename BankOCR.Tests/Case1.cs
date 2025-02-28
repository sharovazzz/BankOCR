using BankOCR.Lib;

namespace BankOCR.Tests
{
    public class Case1
    {
        [Fact]
        public void Load_Digit0_Zeros()
        {
            var fileParser = new FileParser();
            var expected = new Row([0, 0, 0, 0, 0, 0, 0, 0, 0]);

            var result = fileParser.Load("D:\\BankOCR\\BankOCR.Lib\\Case1\\Digit0.txt");

            Assert.Equal(expected.Digits, result[0].Digits);
        }

        [Fact]
        public void Load_Digit1_Units()
        {
            var fileParser = new FileParser();
            var expected = new Row([1, 1, 1, 1, 1, 1, 1, 1, 1]);

            var result = fileParser.Load("D:\\BankOCR\\BankOCR.Lib\\Case1\\Digit1.txt");

            Assert.Equal(expected.Digits, result[0].Digits);
        }

        [Fact]
        public void Load_EmptyFile_EmptyList()
        {
            var fileParser = new FileParser();

            var result = fileParser.Load("D:\\BankOCR\\BankOCR.Lib\\Case1\\EmptyFile.txt");

            Assert.Empty(result);
        }

        [Fact]
        public void Load_NotFoundFile_EmptyList()
        {
            var fileParser = new FileParser();

            var result = fileParser.Load("D:\\BankOCR\\BankOCR.Lib\\Case1\\NotFoundFile.txt");

            Assert.Empty(result);
        }

        [Fact]
        public void Load_OneRowInFile_OneRow()
        {
            var fileParser = new FileParser();

            var result = fileParser.Load("D:\\BankOCR\\BankOCR.Lib\\Case1\\1Row.txt");

            Assert.Single(result);
        }

        [Fact]
        public void Load_TwoRowInFile_TwoRow()
        {
            var fileParser = new FileParser();

            var result = fileParser.Load("D:\\BankOCR\\BankOCR.Lib\\Case1\\2Row.txt");

            Assert.Equal(2, result.Count);
        }
    }
}
using NumberTextService;

namespace NumberTextServiceTests
{
    [TestFixture]
    public class NumberTextService
    {
        private  NumberTextGenerator  _numberTextGenerator;
        [SetUp]
        public void Setup()
        {
            _numberTextGenerator = new NumberTextGenerator();
        }

        [Test]
        public void ShouldGenerateStringArray()
        {
            var result = _numberTextGenerator.GetStringArray(10, new Dictionary<short, string>());
            Assert.Pass();
        }

        [Test]
        public void ShouldRequirePositiveUpperBounds()
        {
            var result = _numberTextGenerator.GetStringArray(0, new Dictionary<short, string>());
            Assert.That(result[0] == "Upper Bound must be a positive number.");
        }

        [Test]
        public void ShouldReplaceTextWhenZeroRemainderForGivenKey()
        {
            var result = _numberTextGenerator.GetStringArray(2, new Dictionary<short, string>{{2, "Greg"}});
            Assert.That(result[1].Trim() == "Greg");
        }

        [Test]
        public void ShouldReplaceWithMultipleValuesIfZeroRemainderForMultipleKeys()
        {
            var result = _numberTextGenerator.GetStringArray(10, new Dictionary<short, string> {
                { 2, "Greg" } ,
                {5, "Lawrence" }
            });
            Assert.That(result[9].Trim() == "Greg Lawrence");
        }

        [Test]
        public void ShouldReturnNumberIfRemainderExistsForKey()
        {
            var result = _numberTextGenerator.GetStringArray(11, new Dictionary<short, string> {
                { 2, "Greg" } ,
                {5, "Lawrence" }
            });
            Assert.That(result[10].Trim() == "11");
        }

    }
}
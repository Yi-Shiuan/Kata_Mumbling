namespace Mumbling.Tests
{
    #region

    using FluentAssertions;

    using Kata_Mumbling;

    using Xunit;

    #endregion

    public class MumblingTest
    {
        [Fact]
        public void InputAOutOneUpCaseWord()
        {
            var service = new Mumbling();

            var result = service.Accum("a");

            result.Should().Be("A");
        }

        [Fact]
        public void InputBOutUpCaseB()
        {
            var service = new Mumbling();

            var result = service.Accum("b");

            result.Should().Be("B");
        }
    }
}
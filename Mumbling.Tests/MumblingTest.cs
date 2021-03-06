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

        [Fact]
        public void InputABOutUpCaseAAndBb()
        {
            var service = new Mumbling();

            var result = service.Accum("ab");

            result.Should().Be("A-Bb");
        }

        [Fact]
        public void InputACOutUpCaseAAndCc()
        {
            var service = new Mumbling();

            var result = service.Accum("ac");

            result.Should().Be("A-Cc");
        }

        [Fact]
        public void InputABCOutUpCaseABbCcc()
        {
            var service = new Mumbling();

            var result = service.Accum("abc");

            result.Should().Be("A-Bb-Ccc");
        }
    }
}
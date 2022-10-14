namespace Kata.UnitTests
{
    using Xunit;

    public class BowlingTests
    {
        [Fact]
        public void When12RollsAnd12Strings_ScoreShouldBe300()
        {
            var bowling = new Bowling();

            for (var i = 0; i < 12; i++)
            {
                bowling.Roll(10);
            }

            var score = bowling.GetScore();

            Assert.Equal(300, score);
        }
    }
}

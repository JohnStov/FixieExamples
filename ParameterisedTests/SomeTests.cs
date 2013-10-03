using FluentAssertions;

namespace ParameterisedTests
{
    public class SomeTests
    {
        [Input(2, 3, 5)]
        [Input(3, 3, 6)]
        [Input(3, 3, 7)]
        public void AddTest(int a, int b, int result)
        {
            (a + b).Should().Be(result);
        }
    }
}

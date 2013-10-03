using System.Threading.Tasks;

using FluentAssertions;

namespace SimpleFixieExample
{
    public class ExampleTests
    {
        public void ThisTestShouldPass()
        {
            3.Should().BePositive();
        }

        public void ThisTestShouldFail()
        {
            "This String".Should().BeBlank();
        }

        public async Task ThisAsyncTetShouldPass()
        {
            var result = await AsyncAdd(3, 7);
            result.Should().Be(10);
        }

        private Task<int> AsyncAdd(int i, int j)
        {
            return Task.FromResult(i + j);
        }
    }
}

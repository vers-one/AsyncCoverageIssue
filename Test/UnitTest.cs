using Target;
using Xunit;

namespace AsyncCoverageIssue
{
    public class UnitTest
    {
        [Fact]
        public async void Test()
        {
            await new TargetClass().Copy();
        }
    }
}

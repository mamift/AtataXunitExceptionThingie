using Atata;
using Xunit;
using Xunit.Abstractions;

namespace WhyDoesNunitExceptionThrow
{
    [Collection(AtataSetUpCollection.CollectionName)]
    public class SampleTests : UiTestFixture
    {
        public SampleTests(ITestOutputHelper output) : base(output) { }

        [Fact]
        public void SampleTest()
        {
            Go.To<OrdinaryPage>()
                .PageTitle.Should.Contain("Atata");
        }
    }
}

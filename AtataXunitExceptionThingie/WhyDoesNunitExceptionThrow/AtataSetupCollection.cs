using Xunit;

namespace WhyDoesNunitExceptionThrow
{
    [CollectionDefinition(CollectionName)]
    public class AtataSetUpCollection : ICollectionFixture<SimpleUiTestsFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.

        public const string CollectionName = "AtataSetUp";
    }
}
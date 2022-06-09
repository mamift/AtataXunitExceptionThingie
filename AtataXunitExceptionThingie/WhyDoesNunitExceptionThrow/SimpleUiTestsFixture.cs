using Atata;
using Microsoft.Extensions.Configuration;

namespace WhyDoesNunitExceptionThrow
{
    public class SimpleUiTestsFixture
    {
        public IConfigurationRoot RunSettings { get; }

        public SimpleUiTestsFixture()
        {
            var configBuilder = new ConfigurationBuilder().AddEnvironmentVariables().AddXmlFile("local.runsettings");

            RunSettings = configBuilder.Build();
            
            string testEnvironmentAlias = RunSettings["TestRunParameters:Parameter:TestEnvironment:value"];
            string driverAlias = RunSettings["TestRunParameters:Parameter:DriverAlias:value"] ?? DriverAliases.Chrome;

            // Find information on AtataContext set-up on https://atata.io/getting-started/#set-up
            // Find information on Atata JSON configuration on https://github.com/atata-framework/atata-configuration-json
            AtataContext.GlobalConfiguration
                // uncomment this one line and it throws an nunit exception? which is very weird; nunit stuff appears to be hardcoded in the config lib
                .ApplyJsonConfig<SimpleUiTestConfig>()
                .ApplyJsonConfig<SimpleUiTestConfig>(environmentAlias: testEnvironmentAlias)
                .UseDriver(driverAlias);

            AtataContext.GlobalConfiguration.AutoSetUpDriverToUse();
        }
    }
}

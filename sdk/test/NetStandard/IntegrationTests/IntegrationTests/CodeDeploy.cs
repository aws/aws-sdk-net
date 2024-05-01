using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon;
using Amazon.CodeDeploy;
using Amazon.CodeDeploy.Model;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

namespace Amazon.DNXCore.IntegrationTests
{
    
    public class CodeDeploy : TestBase<AmazonCodeDeployClient>
    {
        [Fact]
        public void TestListApplications()
        {
            Client.ListApplicationsAsync().Wait();
        }


        [Fact]
        public async Task TestDeleteApplication()
        {
            var appName = UtilityMethods.GenerateName();
            await Client.CreateApplicationAsync(new CreateApplicationRequest { ApplicationName = appName });
            Assert.Contains(appName, Client.ListApplicationsAsync().Result.Applications);
            await Client.DeleteApplicationAsync(new DeleteApplicationRequest { ApplicationName = appName });
            Assert.DoesNotContain(appName, Client.ListApplicationsAsync().Result.Applications);
        }
    }
}

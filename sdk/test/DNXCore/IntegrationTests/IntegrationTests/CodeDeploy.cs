using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public void TestCreateApplication()
        {
            var appName = UtilityMethods.GenerateName();
            Client.CreateApplicationAsync(new CreateApplicationRequest { ApplicationName = appName }).Wait();
            Assert.True(Client.ListApplicationsAsync().Result.Applications.Contains(appName));
            Client.DeleteApplicationAsync(new DeleteApplicationRequest { ApplicationName = appName }).Wait();
        }

        [Fact]
        public void TestDeleteApplication()
        {
            var appName = UtilityMethods.GenerateName();
            Client.CreateApplicationAsync(new CreateApplicationRequest { ApplicationName = appName }).Wait();
            Assert.True(Client.ListApplicationsAsync().Result.Applications.Contains(appName));
            Client.DeleteApplicationAsync(new DeleteApplicationRequest { ApplicationName = appName }).Wait();
            Assert.False(Client.ListApplicationsAsync().Result.Applications.Contains(appName));
        }
    }
}

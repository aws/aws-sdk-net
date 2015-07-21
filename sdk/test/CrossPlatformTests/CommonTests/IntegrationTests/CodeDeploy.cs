using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon;
using Amazon.CodeDeploy;
using Amazon.CodeDeploy.Model;
using NUnit.Framework;
using CommonTests.Framework;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class CodeDeploy : TestBase<AmazonCodeDeployClient>
    {
        [Test]
        public void TestListApplications()
        {
            Client.ListApplicationsAsync().Wait();
        }

        [Test]
        public void TestCreateApplication()
        {
            var appName = UtilityMethods.GenerateName();
            Client.CreateApplicationAsync(new CreateApplicationRequest { ApplicationName = appName }).Wait();
            Assert.IsTrue(Client.ListApplicationsAsync().Result.Applications.Contains(appName));
            Client.DeleteApplicationAsync(new DeleteApplicationRequest { ApplicationName = appName }).Wait();
        }

        [Test]
        public void TestDeleteApplication()
        {
            var appName = UtilityMethods.GenerateName();
            Client.CreateApplicationAsync(new CreateApplicationRequest { ApplicationName = appName }).Wait();
            Assert.IsTrue(Client.ListApplicationsAsync().Result.Applications.Contains(appName));
            Client.DeleteApplicationAsync(new DeleteApplicationRequest { ApplicationName = appName }).Wait();
            Assert.IsFalse(Client.ListApplicationsAsync().Result.Applications.Contains(appName));
        }
    }
}

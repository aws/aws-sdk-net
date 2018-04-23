using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon;
using Amazon.CodeDeploy;
using Amazon.CodeDeploy.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class CodeDeploy : TestBase<AmazonCodeDeployClient>
    {
        [TestMethod]
        [TestCategory("CodeDeploy")]
        public void TestListApplications()
        {
            Client.ListApplications();
        }

        [TestMethod]
        [TestCategory("CodeDeploy")]
        public void TestCreateApplication()
        {
            var appName = Utils.UtilityMethods.GenerateName();
            Client.CreateApplication(new CreateApplicationRequest { ApplicationName = appName });
            Assert.IsTrue(Client.ListApplications().Applications.Contains(appName));
            Client.DeleteApplication(new DeleteApplicationRequest { ApplicationName = appName });
        }

        [TestMethod]
        [TestCategory("CodeDeploy")]
        public void TestDeleteApplication()
        {
            var appName = Utils.UtilityMethods.GenerateName();
            Client.CreateApplication(new CreateApplicationRequest { ApplicationName = appName });
            Assert.IsTrue(Client.ListApplications().Applications.Contains(appName));
            Client.DeleteApplication(new DeleteApplicationRequest { ApplicationName = appName });
            Assert.IsFalse(Client.ListApplications().Applications.Contains(appName));
        }
    }
}

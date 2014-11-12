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
        static string currentProfileConfig;

        [ClassInitialize]
        public static void SetUp(TestContext ctx)
        {
            currentProfileConfig = AWSConfigs.AWSProfileName;
            AWSConfigs.AWSProfileName = "jimflDev";
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            AWSConfigs.AWSProfileName = currentProfileConfig;
            BaseClean();
        }

        [TestMethod]
        public void TestListApplications()
        {
            Client.ListApplications();
        }

        [TestMethod]
        public void TestCreateApplication()
        {
            var appName = Utils.UtilityMethods.GenerateName();
            Client.CreateApplication(new CreateApplicationRequest { ApplicationName = appName });
            Assert.IsTrue(Client.ListApplications().Applications.Contains(appName));
            Client.DeleteApplication(new DeleteApplicationRequest { ApplicationName = appName });
        }

        [TestMethod]
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

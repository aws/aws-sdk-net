using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Inspector;
using Amazon.Inspector.Model;
using Amazon.Runtime;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    /* Tests disabled pending update to new 2016-02-16 API version
    [TestClass]
    public class Inspector : TestBase<AmazonInspectorClient>
    {
        [TestInitialize]
        public void Init()
        {
            SetEndpoint(Client, "https://inspector.us-west-2.amazonaws.com", "us-west-2");
        }

        [TestMethod]
        public void TestListOperation()
        {
            Client.ListApplications(new ListApplicationsRequest { });
        }

        [TestMethod]
        public void TestErrorMessageUnmarshalling()
        {
            try
            {
                Client.CreateResourceGroup(@"{""foo"":""bar""}");
            }
            catch (AmazonInspectorException e)
            {
                Assert.IsNotNull(e.Message);
            }
        }

        [TestMethod]
        public void TestCrudOperations()
        {
            var groupTags = @"[{""key"": ""foo"", ""values"" :[""bar"",""baz""]}]";
            var groupArn = Client.CreateResourceGroup(new CreateResourceGroupRequest 
            { 
                ResourceGroupTags = groupTags,
            }).ResourceGroupArn;

            Assert.IsNotNull(groupArn);

            var appName = Utils.UtilityMethods.GenerateName();
            var appArn = Client.CreateApplication(new CreateApplicationRequest { ApplicationName = appName, ResourceGroupArn = groupArn }).ApplicationArn;

            Assert.IsNotNull(appArn);

            var app = Utils.UtilityMethods.WaitUntilSuccess(() => 
                Client.DescribeApplication(new DescribeApplicationRequest { ApplicationArn = appArn}).Application);

            Assert.AreEqual(appName, app.ApplicationName);
            Assert.AreEqual(appArn, app.ApplicationArn); 
            Assert.AreEqual(groupArn, app.ResourceGroupArn);

            Client.UpdateApplication(new UpdateApplicationRequest {  ApplicationArn = appArn, ApplicationName = appName + "X", ResourceGroupArn = groupArn });

            app = Utils.UtilityMethods.WaitUntilSuccess(() =>
                Client.DescribeApplication(new DescribeApplicationRequest { ApplicationArn = appArn }).Application);

            Assert.AreEqual(appName + "X", app.ApplicationName);

            Client.DeleteApplication(new DeleteApplicationRequest { ApplicationArn = appArn });
        }

    }*/
}

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.ElasticBeanstalk;
using Amazon.ElasticBeanstalk.Model;

using AWSSDK_DotNet.IntegrationTests.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class Beanstalk : TestBase<AmazonElasticBeanstalkClient>
    {

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestMethod]
        [TestCategory("ElasticBeanstalk")]
        public void ListAvailableSolutionStacksTest()
        {
            ListAvailableSolutionStacksResponse response = Client.ListAvailableSolutionStacks(new ListAvailableSolutionStacksRequest());
            Assert.IsNotNull(response);
            Assert.IsTrue(response.SolutionStacks.Count > 0);
            foreach (string stack in response.SolutionStacks)
            {
                Assert.IsNotNull(stack);
            }
        }

        [TestMethod]
        [TestCategory("ElasticBeanstalk")]
        public void CheckDNSAvailabilityTest()
        {
            CheckDNSAvailabilityRequest request = new CheckDNSAvailabilityRequest()
            {
                CNAMEPrefix = "mycnamecheck" + DateTime.Now.Ticks
            };

            CheckDNSAvailabilityResponse response = Client.CheckDNSAvailability(request);
            Assert.IsTrue(response.Available);
            Assert.IsNotNull(response.FullyQualifiedCNAME);
        }

        [TestMethod]
        [TestCategory("ElasticBeanstalk")]
        public void CRUDApplication()
        {
            string applicationName = "dotnet-integ-app" + DateTime.Now.Ticks;
            CreateApplicationRequest createRequest = new CreateApplicationRequest()
            {
                ApplicationName = applicationName,
                Description = "Test Application"
            };

            CreateApplicationResponse createResponse = Client.CreateApplication(createRequest);
            Assert.IsNotNull(createResponse.ResponseMetadata.RequestId);

            try
            {
                DescribeApplicationsResponse describeResponse = Client.DescribeApplications(new DescribeApplicationsRequest() { ApplicationNames = new List<string>() { applicationName } });
                Assert.AreEqual(1, describeResponse.Applications.Count);
                ApplicationDescription app = describeResponse.Applications[0];
                Assert.AreEqual(applicationName, app.ApplicationName);
                Assert.AreEqual("Test Application", app.Description);
                Assert.AreNotEqual(DateTime.MinValue, app.DateCreated);
                Assert.AreNotEqual(DateTime.MinValue, app.DateUpdated);

                UpdateApplicationRequest updateRequest = new UpdateApplicationRequest()
                {
                    ApplicationName = applicationName,
                    Description = "updated description"
                };
                UpdateApplicationResponse updateResponse = Client.UpdateApplication(updateRequest);
                Assert.AreEqual(applicationName, updateResponse.Application.ApplicationName);
                Assert.AreEqual("updated description", updateResponse.Application.Description);
            }
            finally
            {
                Client.DeleteApplication(new DeleteApplicationRequest() { ApplicationName = applicationName });
            }
        }
    }
}

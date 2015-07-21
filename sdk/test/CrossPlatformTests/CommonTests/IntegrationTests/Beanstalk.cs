using System;
using System.Collections.Generic;

using Amazon.ElasticBeanstalk;
using Amazon.ElasticBeanstalk.Model;

using NUnit.Framework;
using CommonTests.Framework;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class Beanstalk : TestBase<AmazonElasticBeanstalkClient>
    {

        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        [Test]
        [Category("Beanstalk")]
        public void ListAvailableSolutionStacksTest()
        {
            ListAvailableSolutionStacksResponse response = Client.ListAvailableSolutionStacksAsync(new ListAvailableSolutionStacksRequest()).Result;
            Assert.IsNotNull(response);
            Assert.IsTrue(response.SolutionStacks.Count > 0);
            foreach (string stack in response.SolutionStacks)
            {
                Assert.IsNotNull(stack);
            }
        }

        [Test]
        [Category("Beanstalk")]
        public void CheckDNSAvailabilityTest()
        {
            CheckDNSAvailabilityRequest request = new CheckDNSAvailabilityRequest()
            {
                CNAMEPrefix = "mycnamecheck" + DateTime.Now.Ticks
            };

            CheckDNSAvailabilityResponse response = Client.CheckDNSAvailabilityAsync(request).Result;
            Assert.IsTrue(response.Available);
            Assert.IsNotNull(response.FullyQualifiedCNAME);
        }

        [Test]
        [Category("Beanstalk")]
        public void CRUDApplication()
        {
            string applicationName = "dotnet-integ-app" + DateTime.Now.Ticks;
            CreateApplicationRequest createRequest = new CreateApplicationRequest()
            {
                ApplicationName = applicationName,
                Description = "Test Application"
            };

            CreateApplicationResponse createResponse = Client.CreateApplicationAsync(createRequest).Result;
            Assert.IsNotNull(createResponse.ResponseMetadata.RequestId);

            try
            {
                DescribeApplicationsResponse describeResponse = Client.DescribeApplicationsAsync(new DescribeApplicationsRequest() { ApplicationNames = new List<string>() { applicationName } }).Result;
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
                UpdateApplicationResponse updateResponse = Client.UpdateApplicationAsync(updateRequest).Result;
                Assert.AreEqual(applicationName, updateResponse.Application.ApplicationName);
                Assert.AreEqual("updated description", updateResponse.Application.Description);
            }
            finally
            {
                Client.DeleteApplicationAsync(new DeleteApplicationRequest() { ApplicationName = applicationName }).Wait();
            }
        }
    }
}

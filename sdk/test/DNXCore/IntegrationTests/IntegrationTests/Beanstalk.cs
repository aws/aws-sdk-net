using System;
using System.Collections.Generic;

using Amazon.ElasticBeanstalk;
using Amazon.ElasticBeanstalk.Model;

using Xunit;
using Amazon.DNXCore.IntegrationTests;

namespace Amazon.DNXCore.IntegrationTests
{
    
    public class Beanstalk : TestBase<AmazonElasticBeanstalkClient>
    {
        [Fact]
        [Trait(CategoryAttribute,"Beanstalk")]
        public void ListAvailableSolutionStacksTest()
        {
            ListAvailableSolutionStacksResponse response = Client.ListAvailableSolutionStacksAsync(new ListAvailableSolutionStacksRequest()).Result;
            Assert.NotNull(response);
            Assert.True(response.SolutionStacks.Count > 0);
            foreach (string stack in response.SolutionStacks)
            {
                Assert.NotNull(stack);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"Beanstalk")]
        public void CheckDNSAvailabilityTest()
        {
            CheckDNSAvailabilityRequest request = new CheckDNSAvailabilityRequest()
            {
                CNAMEPrefix = "mycnamecheck" + DateTime.Now.Ticks
            };

            CheckDNSAvailabilityResponse response = Client.CheckDNSAvailabilityAsync(request).Result;
            Assert.True(response.Available);
            Assert.NotNull(response.FullyQualifiedCNAME);
        }

        [Fact]
        [Trait(CategoryAttribute,"Beanstalk")]
        public void CRUDApplication()
        {
            string applicationName = "dotnet-integ-app" + DateTime.Now.Ticks;
            CreateApplicationRequest createRequest = new CreateApplicationRequest()
            {
                ApplicationName = applicationName,
                Description = "Test Application"
            };

            CreateApplicationResponse createResponse = Client.CreateApplicationAsync(createRequest).Result;
            Assert.NotNull(createResponse.ResponseMetadata.RequestId);

            try
            {
                DescribeApplicationsResponse describeResponse = Client.DescribeApplicationsAsync(new DescribeApplicationsRequest() { ApplicationNames = new List<string>() { applicationName } }).Result;
                Assert.Equal(1, describeResponse.Applications.Count);
                ApplicationDescription app = describeResponse.Applications[0];
                Assert.Equal(applicationName, app.ApplicationName);
                Assert.Equal("Test Application", app.Description);
                Assert.NotEqual(DateTime.MinValue, app.DateCreated);
                Assert.NotEqual(DateTime.MinValue, app.DateUpdated);

                UpdateApplicationRequest updateRequest = new UpdateApplicationRequest()
                {
                    ApplicationName = applicationName,
                    Description = "updated description"
                };
                UpdateApplicationResponse updateResponse = Client.UpdateApplicationAsync(updateRequest).Result;
                Assert.Equal(applicationName, updateResponse.Application.ApplicationName);
                Assert.Equal("updated description", updateResponse.Application.Description);
            }
            finally
            {
                Client.DeleteApplicationAsync(new DeleteApplicationRequest() { ApplicationName = applicationName }).Wait();
            }
        }
    }
}

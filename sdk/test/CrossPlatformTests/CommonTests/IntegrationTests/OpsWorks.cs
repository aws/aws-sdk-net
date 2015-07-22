using System;
using System.Collections.Generic;

using Amazon.OpsWorks;
using Amazon.OpsWorks.Model;

using Amazon.IdentityManagement;
using NUnit.Framework;
using CommonTests.Framework;


namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class OpsWorks : TestBase<AmazonOpsWorksClient>
    {
        protected override Amazon.RegionEndpoint AlternateEndpoint
        {
            get
            {
                return Amazon.RegionEndpoint.USEast1;
            }
        }
        static IAmazonIdentityManagementService iamClient;

        [OneTimeSetUp]
        public void ClassInitialize()
        {
            iamClient = TestBase.CreateClient<AmazonIdentityManagementServiceClient>();
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
            if (iamClient != null)
            {
                iamClient.Dispose();
                iamClient = null;
            }
        }

        [Test]
        [Category("OpsWorks")]
        public void CRUDUserProfile()
        {
            var createUserRequest = new Amazon.IdentityManagement.Model.CreateUserRequest { UserName = "DotNetSDK" + DateTime.Now.Ticks };
            var createUserResponse = iamClient.CreateUserAsync(createUserRequest).Result;
            try
            {
                CreateUserProfileResponse createUserProfileResponse = Client.CreateUserProfileAsync(new CreateUserProfileRequest
                {
                    IamUserArn = createUserResponse.User.Arn
                }).Result;

                Assert.IsNotNull(createUserProfileResponse.IamUserArn);

                DescribeUserProfilesResponse describeResponse = Client.DescribeUserProfilesAsync(new DescribeUserProfilesRequest
                {
                    IamUserArns = new List<string> { createUserProfileResponse.IamUserArn }
                }).Result;

                Assert.AreEqual(1, describeResponse.UserProfiles.Count);
                Assert.AreEqual(createUserProfileResponse.IamUserArn, describeResponse.UserProfiles[0].IamUserArn);

                Client.DeleteUserProfileAsync(new DeleteUserProfileRequest { IamUserArn = createUserProfileResponse.IamUserArn }).Wait();

                AssertExtensions.ExpectExceptionAsync<ResourceNotFoundException>(
                        Client.DescribeUserProfilesAsync(new DescribeUserProfilesRequest
                        {
                            IamUserArns = new List<string> { createUserProfileResponse.IamUserArn }
                        }));

            }
            finally
            {
                iamClient.DeleteUserAsync(new Amazon.IdentityManagement.Model.DeleteUserRequest { UserName = createUserRequest.UserName }).Wait();
            }
        }
    }
}

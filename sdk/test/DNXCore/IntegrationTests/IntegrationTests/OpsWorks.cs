using System;
using System.Collections.Generic;

using Amazon.OpsWorks;
using Amazon.OpsWorks.Model;

using Amazon.IdentityManagement;
using Xunit;
using Amazon.DNXCore.IntegrationTests;


namespace Amazon.DNXCore.IntegrationTests
{
    
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

        public OpsWorks()
        {
            iamClient = TestBase.CreateClient<AmazonIdentityManagementServiceClient>();
        }
        
        protected override void Dispose(bool disposing)
        {
            if (iamClient != null)
            {
                iamClient.Dispose();
                iamClient = null;
            }
            base.Dispose(disposing);
        }
        
        [Fact]
        [Trait(CategoryAttribute,"OpsWorks")]
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

                Assert.NotNull(createUserProfileResponse.IamUserArn);

                DescribeUserProfilesResponse describeResponse = Client.DescribeUserProfilesAsync(new DescribeUserProfilesRequest
                {
                    IamUserArns = new List<string> { createUserProfileResponse.IamUserArn }
                }).Result;

                Assert.Equal(1, describeResponse.UserProfiles.Count);
                Assert.Equal(createUserProfileResponse.IamUserArn, describeResponse.UserProfiles[0].IamUserArn);

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

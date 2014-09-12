using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.OpsWorks;
using Amazon.OpsWorks.Model;

using Amazon.IdentityManagement;


namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class OpsWorks : TestBase<AmazonOpsWorksClient>
    {

        static IAmazonIdentityManagementService iamClient;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            iamClient = new AmazonIdentityManagementServiceClient();
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
            if (iamClient != null)
            {
                iamClient.Dispose();
                iamClient = null;
            }
        }

        [TestMethod]
        [TestCategory("OpsWorks")]
        public void CRUDUserProfile()
        {
            var createUserRequest = new Amazon.IdentityManagement.Model.CreateUserRequest { UserName = "DotNetSDK" + DateTime.Now.Ticks };
            var createUserResponse = iamClient.CreateUser(createUserRequest);
            try
            {
                CreateUserProfileResponse createUserProfileResponse = Client.CreateUserProfile(new CreateUserProfileRequest
                {
                    IamUserArn = createUserResponse.User.Arn
                });

                Assert.IsNotNull(createUserProfileResponse.IamUserArn);

                DescribeUserProfilesResponse describeResponse = Client.DescribeUserProfiles(new DescribeUserProfilesRequest
                {
                    IamUserArns = new List<string> { createUserProfileResponse.IamUserArn }
                });

                Assert.AreEqual(1, describeResponse.UserProfiles.Count);
                Assert.AreEqual(createUserProfileResponse.IamUserArn, describeResponse.UserProfiles[0].IamUserArn);

                Client.DeleteUserProfile(new DeleteUserProfileRequest { IamUserArn = createUserProfileResponse.IamUserArn });

                AssertExtensions.ExpectException((() =>
                    {
                        Client.DescribeUserProfiles(new DescribeUserProfilesRequest
                        {
                            IamUserArns = new List<string> { createUserProfileResponse.IamUserArn }
                        });
                    }), typeof(ResourceNotFoundException));

            }
            finally
            {
                iamClient.DeleteUser(new Amazon.IdentityManagement.Model.DeleteUserRequest { UserName = createUserRequest.UserName });
            }
        }
    }
}

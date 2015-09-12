using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Amazon.DNXCore.IntegrationTests;
using System.Threading;

using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests.IAM
{
    /// <summary>
    /// Summary description for LoginProfileTests
    /// </summary>
    
    public class LoginProfileTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        [Fact]
        [Trait(CategoryAttribute, "IAM")]
        public void TestCreateGetLoginProfile()
        {
            using (var session = new IAMTestSession("TestCreateGetLoginProfile", Client))
            {
                string username = session.CreateTestUser();
                string password = "strongpassword";

                CreateLoginProfileResponse createRes =
                    Client.CreateLoginProfileAsync(new CreateLoginProfileRequest
                    {
                        UserName = username,
                        Password = password,
                        PasswordResetRequired = true
                    }).Result;

                UtilityMethods.Sleep(TimeSpan.FromSeconds(20));

                Assert.Equal(username, createRes.LoginProfile.UserName);

                GetLoginProfileResponse getRes =
                    Client.GetLoginProfileAsync(new GetLoginProfileRequest() { UserName = username }).Result;
                Assert.NotEqual(DateTime.MinValue, getRes.LoginProfile.CreateDate);

                var login = getRes.LoginProfile;
                Assert.Equal(username, login.UserName);
                Assert.True(login.PasswordResetRequired);


                Client.UpdateLoginProfileAsync(new UpdateLoginProfileRequest
                {
                    UserName = username,
                    Password = password,
                    PasswordResetRequired = false
                }).Wait();

                Assert.Equal(username, createRes.LoginProfile.UserName);

                getRes = Client.GetLoginProfileAsync(new GetLoginProfileRequest() { UserName = username }).Result;
                Assert.NotEqual(DateTime.MinValue, getRes.LoginProfile.CreateDate);

                login = getRes.LoginProfile;
                Assert.Equal(username, login.UserName);
                Assert.False(login.PasswordResetRequired);

            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        //[ExpectedException(typeof(EntityAlreadyExistsException))]
        public void TestCreateLoginProfileTwiceException()
        {
            using (var session = new IAMTestSession("TestCreateLoginProfileTwiceException", Client))
            {
                string username = session.CreateTestUser();
                string password = "strong-password";

                try
                {
                    Client.CreateLoginProfileAsync(new CreateLoginProfileRequest() { UserName = username, Password = password }).Wait();
                    UtilityMethods.Sleep(TimeSpan.FromSeconds(10));
                    Client.CreateLoginProfileAsync(new CreateLoginProfileRequest() { UserName = username, Password = password }).Wait();
                }
                catch (AggregateException ae)
                {
                    AssertExtensions.VerifyException<EntityAlreadyExistsException>(ae);
                }
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        //[ExpectedException(typeof(NoSuchEntityException))]
        public void TestDeleteLoginProfile()
        {
            using (var session = new IAMTestSession("TestDeleteLoginProfile", Client))
            {
                string username = session.CreateTestUser();
                string password = "strong-password";

                try
                {
                    Client.CreateLoginProfileAsync(new CreateLoginProfileRequest() { UserName = username, Password = password }).Wait();
                    UtilityMethods.Sleep(TimeSpan.FromSeconds(10));
                    Client.DeleteLoginProfileAsync(new DeleteLoginProfileRequest() { UserName = username }).Wait();
                    UtilityMethods.Sleep(TimeSpan.FromSeconds(10));

                    GetLoginProfileResponse getRes =
                        Client.GetLoginProfileAsync(new GetLoginProfileRequest() { UserName = username }).Result;
                }
                catch (AggregateException ae)
                {
                    AssertExtensions.VerifyException<NoSuchEntityException>(ae);
                }
            }
        }

    }
}

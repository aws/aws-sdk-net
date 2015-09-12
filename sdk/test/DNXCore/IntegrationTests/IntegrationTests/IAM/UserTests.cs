using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using System.Threading.Tasks;
using System.Threading;

namespace AWSSDK_DotNet.IntegrationTests.Tests.IAM
{
    /// <summary>
    /// Summary description for GetUserTest
    /// </summary>
    
    public class UserTests : TestBase<AmazonIdentityManagementServiceClient>
    {

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void TestGetUserImplicit()
        {
            GetUserRequest request = new GetUserRequest();

            GetUserResponse response = Client.GetUserAsync(request).Result;
            Assert.False(string.IsNullOrEmpty(response.User.Arn));

            // The assert will succeed if you run with root credentials.
            //Assert.Equal(string.Format("arn:aws:iam::{0}:root", response.User.UserId), response.User.Arn);
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void TestCreateGetUser()
        {
            string username = "sdk-testuser-" + DateTime.Now.Ticks;

            try
            {
                CreateUserRequest request = new CreateUserRequest() { UserName = username, Path = IAMUtil.TEST_PATH };
                CreateUserResponse response = Client.CreateUserAsync(request).Result;
                Assert.Equal(username, response.User.UserName);
                GetUserResponse getResponse = Client.GetUserAsync(new GetUserRequest() { UserName = username }).Result;
                Assert.Equal(username, getResponse.User.UserName);
                Assert.NotEqual(DateTime.MinValue, getResponse.User.CreateDate);
            }
            finally
            {
                Client.DeleteUserAsync(new DeleteUserRequest() { UserName = username }).Wait();
            }
        }

        [Fact]
        [Trait(CategoryAttribute, "IAM")]
        public void TestListUsers()
        {
            using (var session = new IAMTestSession("TestListUsers", Client))
            {
                string username1 = session.CreateTestUser();
                string username2 = session.CreateTestUser();
                string username3 = session.CreateTestUser();

                ListUsersResponse response = Client.ListUsersAsync(new ListUsersRequest() { PathPrefix = session.Prefix }).Result;

                int matches = 0;
                foreach (User user in response.Users)
                {
                    if (user.UserName.Equals(username1))
                        matches |= 1;
                    if (user.UserName.Equals(username2))
                        matches |= 2;
                    if (user.UserName.Equals(username3))
                        matches |= 4;
                }
                Assert.Equal(7, matches);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void TestUserWithPath()
        {
            string username = "sdk-testuser-" + DateTime.Now.Ticks;
            string path = IAMUtil.MakePath("one", "two", "three");
            try
            {
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username, Path = path }).Wait();
                GetUserResponse response = Client.GetUserAsync(new GetUserRequest() { UserName = username }).Result;
                Assert.Equal(username, response.User.UserName);
                Assert.Equal(path, response.User.Path);
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void TestListUsersByPath()
        {
            string username1 = "sdk-testuser1-" + DateTime.Now.Ticks;
            string username2 = "sdk-testuser2-" + DateTime.Now.Ticks;
            string username3 = "sdk-testuser3-" + DateTime.Now.Ticks;
            string username4 = "sdk-testuser4-" + DateTime.Now.Ticks;

            string pathA = IAMUtil.MakePath("A");
            string pathB = IAMUtil.MakePath("B");

            try
            {
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username1, Path = pathA }).Wait();
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username2, Path = pathA }).Wait();
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username3, Path = pathB }).Wait();
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username4, Path = pathA }).Wait();
                
                ListUsersResponse response = Client.ListUsersAsync(new ListUsersRequest() { PathPrefix = pathA }).Result;
                
                int matches = 0;

                foreach (User u in response.Users)
                {
                    if (u.UserName.Equals(username1))
                        matches |= 1;
                    if (u.UserName.Equals(username2))
                        matches |= 2;
                    if (u.UserName.Equals(username4))
                        matches |= 4;
                    if (u.UserName.Equals(username3))
                        AssertExtensions.Fail();
                }
                Assert.Equal(7, matches);

                response = Client.ListUsersAsync(new ListUsersRequest(){ PathPrefix = pathB }).Result;
                               
                matches = 0;

                foreach (User u in response.Users)
                {
                    if (u.UserName.Equals(username1))
                        AssertExtensions.Fail();
                    if (u.UserName.Equals(username2))
                        AssertExtensions.Fail();
                    if (u.UserName.Equals(username4))
                        AssertExtensions.Fail();
                    if (u.UserName.Equals(username3))
                        matches = 1;
                }
                Assert.Equal(1, matches);
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username1, username2, username3, username4);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void TestListUsersMaxResults()
        {
            string username1 = "sdk-testuser1-" + DateTime.Now.Ticks;
            string username2 = "sdk-testuser2-" + DateTime.Now.Ticks;
            string username3 = "sdk-testuser3-" + DateTime.Now.Ticks;
            string username4 = "sdk-testuser4-" + DateTime.Now.Ticks;

            string pathA = IAMUtil.MakePath("TestListUsersMaxResults");

            try
            {
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username1, Path = pathA }).Wait();
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username2, Path = pathA }).Wait();
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username3, Path = pathA }).Wait();
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username4, Path = pathA }).Wait();

                ListUsersResponse response = Client.ListUsersAsync(new ListUsersRequest() { MaxItems = 2,
                    PathPrefix = pathA }).Result;

                Assert.Equal(2, response.Users.Count());
                Assert.Equal(true, response.IsTruncated);

                int matches = 0;

                foreach (User u in response.Users)
                {
                    if (u.UserName.Equals(username1))
                        matches |= 1;
                    if (u.UserName.Equals(username2))
                        matches |= 2;
                    if (u.UserName.Equals(username4))
                        matches |= 3;
                    if (u.UserName.Equals(username3))
                        matches |= 4;
                }

                string marker = response.Marker;

                response = Client.ListUsersAsync(new ListUsersRequest() { PathPrefix = pathA, Marker = marker }).Result;

                Assert.Equal(2, response.Users.Count());
                Assert.Equal(false, response.IsTruncated);

                foreach (User u in response.Users)
                {
                    if (u.UserName.Equals(username1))
                        matches |= 1;
                    if (u.UserName.Equals(username2))
                        matches |= 2;
                    if (u.UserName.Equals(username4))
                        matches |= 3;
                    if (u.UserName.Equals(username3))
                        matches |= 4;
                }

                Assert.Equal(7, matches);
            }
            finally
            {
                IAMUtil.DeleteTestUsers(Client, username1, username2, username3, username4);
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void TestUpdateUser()
        {
            string
                username    = "sdk-testuser-" + DateTime.Now.Ticks,
                newusername = "sdk-testnewuser-" + DateTime.Now.Ticks;
            string
                firstPath  = IAMUtil.MakePath("first"),
                secondPath = IAMUtil.MakePath("second");

            try
            {
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username, Path = firstPath }).Wait();

                GetUserResponse response = Client.GetUserAsync(new GetUserRequest() { UserName = username }).Result;
                Assert.Equal(firstPath, response.User.Path);

                string id = response.User.UserId;

                Client.UpdateUserAsync(new UpdateUserRequest() { UserName = username, NewPath = secondPath, NewUserName = newusername }).Wait();

                response = Client.GetUserAsync(new GetUserRequest() { UserName = newusername }).Result;

                Assert.Equal(newusername, response.User.UserName);
                Assert.Equal(secondPath, response.User.Path);
                Assert.Equal(id, response.User.UserId);
            }
            finally
            {
                Client.DeleteUserAsync(new DeleteUserRequest() { UserName = newusername }).Wait();
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        //[ExpectedException(typeof(NoSuchEntityException))]
        public void TestDeleteUser()
        {
            string username = "sdk-testuser-" + DateTime.Now.Ticks;

            Client.CreateUserAsync(new CreateUserRequest() { UserName = username, Path = IAMUtil.TEST_PATH }).Wait();

            GetUserResponse response = Client.GetUserAsync(new GetUserRequest() { UserName = username }).Result;
            Assert.Equal(username, response.User.UserName);

            Client.DeleteUserAsync(new DeleteUserRequest() { UserName = username }).Wait();

            AssertExtensions.ExpectExceptionAsync(Client.GetUserAsync(new GetUserRequest() { UserName = username })).Wait();
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        //[ExpectedException(typeof(EntityAlreadyExistsException))]
        public void TestDoubleCreateUser()
        {
            string username = "sdk-testuser-" + DateTime.Now.Ticks;

            try
            {
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username, Path = IAMUtil.TEST_PATH }).Wait();
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username, Path = IAMUtil.TEST_PATH }).Wait();
            }
            catch (AggregateException ae)
            {
                AssertExtensions.VerifyException<EntityAlreadyExistsException>(ae);
            }
            finally
            {
                Client.DeleteUserAsync(new DeleteUserRequest() { UserName = username }).Wait();
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        //[ExpectedException(typeof(NoSuchEntityException))]
        public void TestUpdateNonexistantUser()
        {
            string username = "sdk-testuser-" + DateTime.Now.Ticks;

            AssertExtensions.ExpectExceptionAsync(Client.UpdateUserAsync(new UpdateUserRequest() { UserName = username, NewPath = "/lala/" })).Wait();
        }
        


    }
}

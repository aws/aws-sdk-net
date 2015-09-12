using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests.IAM
{
    /// <summary>
    /// Summary description for GroupTests
    /// </summary>
    
    public class GroupTests : TestBase<AmazonIdentityManagementServiceClient>
    {
        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void TestCreateGetGroup()
        {
            string groupname = Guid.NewGuid().ToString().Replace('-', '0');

            try
            {
                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = groupname }).Wait();
                GetGroupResponse response = Client.GetGroupAsync(new GetGroupRequest() { GroupName = groupname }).Result;
                Assert.NotEqual(DateTime.MinValue, response.Group.CreateDate);
                Assert.Equal(0, response.Users.Count());
            }
            finally
            {
                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = groupname }).Wait();
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void TestGroupWithUsers()
        {
            string
                username1 = "user1" + DateTime.Now.Ticks,
                username2 = "user2" + DateTime.Now.Ticks,
                username3 = "user3" + DateTime.Now.Ticks,
                groupname = "group" + DateTime.Now.Ticks;

            try
            {
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username1, Path = IAMUtil.TEST_PATH }).Wait();
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username2, Path = IAMUtil.TEST_PATH }).Wait();
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username3, Path = IAMUtil.TEST_PATH }).Wait();

                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = groupname, Path = IAMUtil.TEST_PATH }).Wait();

                Client.AddUserToGroupAsync(new AddUserToGroupRequest() { GroupName = groupname, UserName = username1 }).Wait();
                Client.AddUserToGroupAsync(new AddUserToGroupRequest() { GroupName = groupname, UserName = username2 }).Wait();
                Client.AddUserToGroupAsync(new AddUserToGroupRequest() { GroupName = groupname, UserName = username3 }).Wait();

                GetGroupResponse response =
                    Client.GetGroupAsync(new GetGroupRequest() { GroupName = groupname }).Result;

                Assert.Equal(3, response.Users.Count());
                Assert.Equal(false, response.IsTruncated);

                int matches = 0;

                foreach (User u in response.Users)
                {
                    if (u.UserName.Equals(username1))
                        matches |= 1;
                    if (u.UserName.Equals(username2))
                        matches |= 2;
                    if (u.UserName.Equals(username3))
                        matches |= 4;
                }

                Assert.Equal(7, matches);
            }
            finally
            {
                Client.RemoveUserFromGroupAsync(new RemoveUserFromGroupRequest() { GroupName = groupname, UserName = username1 }).Wait();
                Client.RemoveUserFromGroupAsync(new RemoveUserFromGroupRequest() { GroupName = groupname, UserName = username2 }).Wait();
                Client.RemoveUserFromGroupAsync(new RemoveUserFromGroupRequest() { GroupName = groupname, UserName = username3 }).Wait();
                Client.DeleteUserAsync(new DeleteUserRequest() { UserName = username1 }).Wait();
                Client.DeleteUserAsync(new DeleteUserRequest() { UserName = username2 }).Wait();
                Client.DeleteUserAsync(new DeleteUserRequest() { UserName = username3 }).Wait();
                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = groupname }).Wait();
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void TestRemoveUsersFromGroup()
        {
            string
                username1 = "user1" + DateTime.Now.Ticks,
                username2 = "user2" + DateTime.Now.Ticks,
                username3 = "user3" + DateTime.Now.Ticks,
                groupname = "group" + DateTime.Now.Ticks;

            try
            {
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username1, Path = IAMUtil.TEST_PATH }).Wait();
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username2, Path = IAMUtil.TEST_PATH }).Wait();
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username3, Path = IAMUtil.TEST_PATH }).Wait();

                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = groupname, Path = IAMUtil.TEST_PATH }).Wait();

                Client.AddUserToGroupAsync(new AddUserToGroupRequest() { GroupName = groupname, UserName = username1 }).Wait();
                Client.AddUserToGroupAsync(new AddUserToGroupRequest() { GroupName = groupname, UserName = username2 }).Wait();
                Client.AddUserToGroupAsync(new AddUserToGroupRequest() { GroupName = groupname, UserName = username3 }).Wait();

                GetGroupResponse response =
                    Client.GetGroupAsync(new GetGroupRequest() { GroupName = groupname }).Result;

                Assert.Equal(3, response.Users.Count());

                Client.RemoveUserFromGroupAsync(new RemoveUserFromGroupRequest() { GroupName = groupname, UserName = username2 }).Wait();

                response =
                    Client.GetGroupAsync(new GetGroupRequest() { GroupName = groupname }).Result;

                Assert.Equal(2, response.Users.Count());

                int matches = 0;

                foreach (User u in response.Users)
                {
                    if (u.UserName.Equals(username1))
                        matches |= 1;
                    if (u.UserName.Equals(username2))
                        AssertExtensions.Fail();
                    if (u.UserName.Equals(username3))
                        matches |= 4;
                }

                Assert.Equal(5, matches);
            }
            finally
            {
                Client.RemoveUserFromGroupAsync(new RemoveUserFromGroupRequest() { GroupName = groupname, UserName = username1 }).Wait();
                Client.RemoveUserFromGroupAsync(new RemoveUserFromGroupRequest() { GroupName = groupname, UserName = username3 }).Wait();
                Client.DeleteUserAsync(new DeleteUserRequest() { UserName = username1 }).Wait();
                Client.DeleteUserAsync(new DeleteUserRequest() { UserName = username2 }).Wait();
                Client.DeleteUserAsync(new DeleteUserRequest() { UserName = username3 }).Wait();
                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = groupname }).Wait();
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void TestGroupPaging()
        {
            string
                username1 = "user1" + DateTime.Now.Ticks,
                username2 = "user2" + DateTime.Now.Ticks,
                username3 = "user3" + DateTime.Now.Ticks,
                username4 = "user4" + DateTime.Now.Ticks,
                groupname = "group" + DateTime.Now.Ticks;


            try
            {
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username1, Path = IAMUtil.TEST_PATH }).Wait();
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username2, Path = IAMUtil.TEST_PATH }).Wait();
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username3, Path = IAMUtil.TEST_PATH }).Wait();
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username4, Path = IAMUtil.TEST_PATH }).Wait();

                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = groupname, Path = IAMUtil.TEST_PATH }).Wait();

                Client.AddUserToGroupAsync(new AddUserToGroupRequest() { GroupName = groupname, UserName = username1 }).Wait();
                Client.AddUserToGroupAsync(new AddUserToGroupRequest() { GroupName = groupname, UserName = username2 }).Wait();
                Client.AddUserToGroupAsync(new AddUserToGroupRequest() { GroupName = groupname, UserName = username3 }).Wait();
                Client.AddUserToGroupAsync(new AddUserToGroupRequest() { GroupName = groupname, UserName = username4 }).Wait();

                GetGroupResponse response =
                    Client.GetGroupAsync(new GetGroupRequest() { GroupName = groupname, MaxItems = 2 }).Result;

                Assert.Equal(2, response.Users.Count());
                Assert.Equal(true, response.IsTruncated);

                string marker = response.Marker;

                int matches = 0;

                foreach (User u in response.Users)
                {
                    if (u.UserName.Equals(username1))
                        matches |= 1;
                    if (u.UserName.Equals(username2))
                        matches |= 2;
                    if (u.UserName.Equals(username3))
                        matches |= 4;
                    if (u.UserName.Equals(username4))
                        matches |= 8;
                }

                response = Client.GetGroupAsync(new GetGroupRequest() { GroupName = groupname, Marker = marker }).Result;

                Assert.Equal(2, response.Users.Count());
                Assert.Equal(false, response.IsTruncated);

                foreach (User u in response.Users)
                {
                    if (u.UserName.Equals(username1))
                        matches |= 1;
                    if (u.UserName.Equals(username2))
                        matches |= 2;
                    if (u.UserName.Equals(username3))
                        matches |= 4;
                    if (u.UserName.Equals(username4))
                        matches |= 8;
                }

                Assert.Equal(15, matches);
            }
            finally
            {
                Client.RemoveUserFromGroupAsync(new RemoveUserFromGroupRequest() { GroupName = groupname, UserName = username1 }).Wait();
                Client.RemoveUserFromGroupAsync(new RemoveUserFromGroupRequest() { GroupName = groupname, UserName = username2 }).Wait();
                Client.RemoveUserFromGroupAsync(new RemoveUserFromGroupRequest() { GroupName = groupname, UserName = username3 }).Wait();
                Client.RemoveUserFromGroupAsync(new RemoveUserFromGroupRequest() { GroupName = groupname, UserName = username4 }).Wait();
                Client.DeleteUserAsync(new DeleteUserRequest() { UserName = username1 }).Wait();
                Client.DeleteUserAsync(new DeleteUserRequest() { UserName = username2 }).Wait();
                Client.DeleteUserAsync(new DeleteUserRequest() { UserName = username3 }).Wait();
                Client.DeleteUserAsync(new DeleteUserRequest() { UserName = username4 }).Wait();
                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = groupname }).Wait();

            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void TestListGroupWithPaths()
        {

            string
                groupname1 = "group1" + DateTime.Now.Ticks,
                groupname2 = "group2" + DateTime.Now.Ticks,
                groupname3 = "group3" + DateTime.Now.Ticks,
                groupname4 = "group4" + DateTime.Now.Ticks;

            string
                pathA = IAMUtil.MakePath("A"),
                pathB = IAMUtil.MakePath("B");

            try
            {
                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = groupname1, Path = pathA }).Wait();
                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = groupname2, Path = pathA }).Wait();
                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = groupname3, Path = pathB }).Wait();
                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = groupname4, Path = pathB }).Wait();

                ListGroupsResponse response =
                    Client.ListGroupsAsync(new ListGroupsRequest() { PathPrefix = pathA }).Result;

                Assert.Equal(2, response.Groups.Count());

                int matches = 0;

                foreach (Group g in response.Groups)
                {
                    if(g.GroupName.Equals(groupname1))
                        matches |= 1;
                    if(g.GroupName.Equals(groupname2))
                        matches |= 2;
                    if(g.GroupName.Equals(groupname3))
                        AssertExtensions.Fail();
                    if(g.GroupName.Equals(groupname4))
                        AssertExtensions.Fail();
                }

                response = Client.ListGroupsAsync(new ListGroupsRequest() { PathPrefix = pathB }).Result;
                
                Assert.Equal(2, response.Groups.Count());

                foreach (Group g in response.Groups)
                {
                    if (g.GroupName.Equals(groupname1))
                        AssertExtensions.Fail();
                    if (g.GroupName.Equals(groupname2))
                        AssertExtensions.Fail();
                    if (g.GroupName.Equals(groupname3))
                        matches |= 4;
                    if (g.GroupName.Equals(groupname4))
                        matches |= 8;
                }

                Assert.Equal(15, matches);

            }
            finally
            {
                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = groupname1 }).Wait();
                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = groupname2 }).Wait();
                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = groupname3 }).Wait();
                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = groupname4 }).Wait();
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        public void TestListGroupsPaging()
        {
            string
                groupname1 = "group1" + DateTime.Now.Ticks,
                groupname2 = "group2" + DateTime.Now.Ticks,
                groupname3 = "group3" + DateTime.Now.Ticks,
                groupname4 = "group4" + DateTime.Now.Ticks;

            
            var path = IAMUtil.MakePath("TestListGroupsPaging");

            try
            {
                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = groupname1, Path = path }).Wait();
                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = groupname2, Path = path }).Wait();
                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = groupname3, Path = path }).Wait();
                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = groupname4, Path = path }).Wait();

                ListGroupsResponse response =
                    Client.ListGroupsAsync(new ListGroupsRequest()).Result;
                Assert.True(response.Groups.Count >= 4);

                response =
                    Client.ListGroupsAsync(new ListGroupsRequest() { MaxItems = 2, PathPrefix = path }).Result;

                Assert.Equal(2, response.Groups.Count());
                Assert.Equal(true, response.IsTruncated);

                string marker = response.Marker;

                int matches = 0;

                foreach (Group g in response.Groups)
                {
                    if (g.GroupName.Equals(groupname1))
                        matches |= 1;
                    if (g.GroupName.Equals(groupname2))
                        matches |= 2;
                    if (g.GroupName.Equals(groupname3))
                        matches |= 4;
                    if (g.GroupName.Equals(groupname4))
                        matches |= 8;
                }

                response = Client.ListGroupsAsync(new ListGroupsRequest() { Marker = marker, PathPrefix = path }).Result;

                Assert.Equal(2, response.Groups.Count());
                Assert.Equal(false, response.IsTruncated);

                foreach (Group g in response.Groups)
                {
                    if (g.GroupName.Equals(groupname1))
                        matches |= 1;
                    if (g.GroupName.Equals(groupname2))
                        matches |= 2;
                    if (g.GroupName.Equals(groupname3))
                        matches |= 4;
                    if (g.GroupName.Equals(groupname4))
                        matches |= 8;
                }

                Assert.Equal(15, matches);

            }
            finally
            {
                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = groupname1 }).Wait();
                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = groupname2 }).Wait();
                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = groupname3 }).Wait();
                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = groupname4 }).Wait();
            }

        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        //[ExpectedException(typeof(NoSuchEntityException))]
        public void AddUserToNonExistentGroup()
        {
            string
                username = "user" + DateTime.Now.Ticks,
                grpname = "group" + DateTime.Now.Ticks;
            try
            {
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username, Path = IAMUtil.TEST_PATH }).Wait();
                Client.AddUserToGroupAsync(new AddUserToGroupRequest() { GroupName = grpname, UserName = username }).Wait();
            }
            catch (AggregateException ae)
            {
                AssertExtensions.VerifyException<NoSuchEntityException>(ae);
            }
            finally
            {
                Client.DeleteUserAsync(new DeleteUserRequest() { UserName = username }).Wait();
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        //[ExpectedException(typeof(EntityAlreadyExistsException))]
        public void TestDoubleCreation()
        {
            string
                grpname = "group" + DateTime.Now.Ticks;
           
            try
            {
                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = grpname, Path = IAMUtil.TEST_PATH }).Wait();
                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = grpname, Path = IAMUtil.TEST_PATH }).Wait();
            }
            catch (AggregateException ae)
            {
                AssertExtensions.VerifyException<EntityAlreadyExistsException>(ae);
            }
            finally
            {
                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = grpname }).Wait();
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        //[ExpectedException(typeof(DeleteConflictException))]
        public void TestDeleteUserInGroupThrowsException()
        {
            string
                username = "user" + DateTime.Now.Ticks,
                grpname = "group" + DateTime.Now.Ticks;

            try
            {
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username, Path = IAMUtil.TEST_PATH }).Wait();
                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = grpname, Path = IAMUtil.TEST_PATH }).Wait();
                Client.AddUserToGroupAsync(new AddUserToGroupRequest() { UserName = username, GroupName = grpname }).Wait();

                Client.DeleteUserAsync(new DeleteUserRequest() { UserName = username }).Wait();
            }
            catch (AggregateException ae)
            {
                AssertExtensions.VerifyException<DeleteConflictException>(ae);
            }
            finally
            {
                Client.RemoveUserFromGroupAsync(new RemoveUserFromGroupRequest() { UserName = username, GroupName = grpname }).Wait();
                Client.DeleteUserAsync(new DeleteUserRequest() { UserName = username }).Wait();
                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = grpname }).Wait();
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"IAM")]
        //[ExpectedException(typeof(DeleteConflictException))]
        public void TestDeleteGroupWithUsersThrowsException()
        {
            string
                username = "user" + DateTime.Now.Ticks,
                grpname = "group" + DateTime.Now.Ticks;


            try
            {
                Client.CreateUserAsync(new CreateUserRequest() { UserName = username, Path = IAMUtil.TEST_PATH }).Wait();
                Client.CreateGroupAsync(new CreateGroupRequest() { GroupName = grpname, Path = IAMUtil.TEST_PATH }).Wait();
                Client.AddUserToGroupAsync(new AddUserToGroupRequest() { UserName = username, GroupName = grpname }).Wait();

                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = grpname }).Wait();
            }
            catch (AggregateException ae)
            {
                AssertExtensions.VerifyException<DeleteConflictException>(ae);
            }
            finally
            {
                Client.RemoveUserFromGroupAsync(new RemoveUserFromGroupRequest() { UserName = username, GroupName = grpname }).Wait();
                Client.DeleteUserAsync(new DeleteUserRequest() { UserName = username }).Wait();
                Client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = grpname }).Wait();
            }
        }

    }
}

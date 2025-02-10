using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using Amazon.DNXCore.IntegrationTests;

namespace AWSSDK_DotNet.IntegrationTests.Tests.IAM
{
    public class IAMTestSession : IDisposable
    {
        List<string> _users = new List<string>();
        List<Group> _groups = new List<Group>();
        AmazonIdentityManagementServiceClient _client;
        string _testName;

        public string Prefix { get; set; }


        public IAMTestSession(string testName, AmazonIdentityManagementServiceClient client)
        {
            Prefix = IAMUtil.MakePath(testName);
            _testName = testName;
            _client = client;
        }

        public string CreateTestUser()
        {
            var user = IAMUtil.CreateTestUser(_client, _testName);
            _users.Add(user);
            return user;
        }
        
        public void Dispose()
        {
            // Delete the users created in the session
            IAMUtil.DeleteTestUsers(_client, _users.ToArray());
            _users.Clear();
        }
    }

    class IAMUtil
    {
        public static string TEST_PATH = "/IntegrationTests/IAM/";

        public static string MakePath(params string[] elements)
        {
            string path = TEST_PATH;
            foreach (string s in elements)
            {
                path = string.Format("{0}{1}/", path, s);
            }

            return path;
        }

        public static void DeleteUsersAndGroupsInTestNameSpace(string testPrefix)
        {
            AmazonIdentityManagementServiceClient client = UtilityMethods.CreateClient<AmazonIdentityManagementServiceClient>();
            var prefix = MakePath(testPrefix);
            ListGroupsResponse lgRes = client.ListGroupsAsync(new ListGroupsRequest() { PathPrefix = prefix }).Result;
            foreach (Group g in lgRes.Groups)
            {
                GetGroupResponse ggRes = client.GetGroupAsync(new GetGroupRequest() { GroupName = g.GroupName }).Result;
                foreach (User u in ggRes.Users)
                {
                    client.RemoveUserFromGroupAsync(new RemoveUserFromGroupRequest() { GroupName = g.GroupName, UserName = u.UserName }).Wait();
                }
                client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = g.GroupName }).Wait();
            }

            ListUsersResponse luRes = client.ListUsersAsync(new ListUsersRequest() { PathPrefix = prefix }).Result;
            foreach (User u in luRes.Users)
            {
                DeleteTestUsers(client, u.UserName);
            }
        }

        public static void DeleteAccessKeysForUser(AmazonIdentityManagementServiceClient client, string username)
        {
            ListAccessKeysResponse response = client.ListAccessKeysAsync(new ListAccessKeysRequest() { UserName = username }).Result;
            foreach (AccessKeyMetadata akm in response.AccessKeyMetadata)
            {
                client.DeleteAccessKeyAsync(new DeleteAccessKeyRequest() { UserName = username, AccessKeyId = akm.AccessKeyId }).Wait();
            }
        }

        public static void DeleteUserPoliciesForUser(AmazonIdentityManagementServiceClient client, string username)
        {
            ListUserPoliciesResponse response =
                client.ListUserPoliciesAsync(new ListUserPoliciesRequest() { UserName = username }).Result;
            foreach (string pName in response.PolicyNames)
            {
                client.DeleteUserPolicyAsync(new DeleteUserPolicyRequest() { UserName = username, PolicyName = pName }).Wait();
            }
        }

        public static void DeleteCertificatesForUser(AmazonIdentityManagementServiceClient client, string username)
        {
            ListSigningCertificatesResponse response =
                client.ListSigningCertificatesAsync(new ListSigningCertificatesRequest() { UserName = username }).Result;
            foreach (SigningCertificate cert in response.Certificates)
            {
                client.DeleteSigningCertificateAsync(new DeleteSigningCertificateRequest() { UserName = username, CertificateId = cert.CertificateId }).Wait();
            }
        }

        internal static string CreateTestUser(AmazonIdentityManagementServiceClient client, string testPrefix)
        {
            var prefix = MakePath(testPrefix);
            string username = "sdk-testuser-" + DateTime.UtcNow.Ticks;
            client.CreateUserAsync(new CreateUserRequest() { UserName = username, Path = prefix }).Wait();
            return username;
        }

        public static void DeleteTestUsers(AmazonIdentityManagementServiceClient client, params string[] usernames)
        {
            UtilityMethods.WaitUntilSuccess(() => {
                foreach (string s in usernames)
                {
                    DeleteAccessKeysForUser(client, s);
                    DeleteUserPoliciesForUser(client, s);
                    DeleteCertificatesForUser(client, s);
                    try 
                    {
                        client.DeleteLoginProfileAsync(new DeleteLoginProfileRequest() { UserName = s }).Wait(); 
                    } catch { }

                    client.DeleteUserAsync(new DeleteUserRequest() { UserName = s }).Wait();
                }
            },10,500);
        }
    }
}

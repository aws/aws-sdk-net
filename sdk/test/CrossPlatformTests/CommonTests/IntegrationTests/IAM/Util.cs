using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using CommonTests.Framework;

namespace AWSSDK_DotNet.IntegrationTests.Tests.IAM
{
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

        public static void DeleteUsersAndGroupsInTestNameSpace(AmazonIdentityManagementServiceClient client)
        {
            ListGroupsResponse lgRes = client.ListGroupsAsync(new ListGroupsRequest() { PathPrefix = TEST_PATH }).Result;
            foreach (Group g in lgRes.Groups)
            {
                GetGroupResponse ggRes = client.GetGroupAsync(new GetGroupRequest() { GroupName = g.GroupName }).Result;
                foreach (User u in ggRes.Users)
                {
                    client.RemoveUserFromGroupAsync(new RemoveUserFromGroupRequest() { GroupName = g.GroupName, UserName = u.UserName }).Wait();
                }
                client.DeleteGroupAsync(new DeleteGroupRequest() { GroupName = g.GroupName }).Wait();
            }

            ListUsersResponse luRes = client.ListUsersAsync(new ListUsersRequest() { PathPrefix = TEST_PATH }).Result;
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

        public static string CreateTestUser(AmazonIdentityManagementServiceClient client)
        {
            string username = "sdk-testuser-" + DateTime.Now.Ticks;
            client.CreateUserAsync(new CreateUserRequest() { UserName = username, Path = TEST_PATH }).Wait();
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
            });
        }
    }
}

using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using Amazon.Lambda;
using Amazon.Lambda.Model;
using Amazon.Runtime;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace AWSSDK.Tests.Framework
{
    class UtilityMethods
    {
        public static string CreateRoleIfNotExists(IAmazonIdentityManagementService iamClient, string roleName, string assumeRolePolicyDocument, bool waitForEventualConsistency = true)
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            Role role = GetRoleIfExists(iamClient, roleName);
            if (role != null && !string.IsNullOrEmpty(role.Arn))
            {
                return role.Arn;
            }
            iamClient.CreateRoleAsync(new CreateRoleRequest
            {
                RoleName = roleName,
                AssumeRolePolicyDocument = assumeRolePolicyDocument
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    role = response.Response.Role;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            if (waitForEventualConsistency)
            {
                // Wait for eventual consistency of IAM role:
                Thread.Sleep(TimeSpan.FromSeconds(5));
            }
            return role.Arn;
        }

        public static Role GetRoleIfExists(IAmazonIdentityManagementService iamClient, string roleName)
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();

            // Get role arn if it exists.
            Role iamRole = null;
            iamClient.GetRoleAsync(new GetRoleRequest()
            {
                RoleName = roleName
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    iamRole = response.Response.Role;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            if (responseException == null)
            {
                Assert.IsNotNull(iamRole);
            }
            else
            {
                Assert.IsInstanceOf(typeof(NoSuchEntityException), responseException);
            }
            return iamRole;
        }

        public static string GetFunctionArnIfExists(IAmazonLambda lambdaClient, string functionName)
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            string functionArn = null;

            lambdaClient.GetFunctionAsync(new GetFunctionRequest()
            {
                FunctionName = functionName
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    functionArn = response.Response.Configuration.FunctionArn;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();

            if (responseException == null)
            {
                Assert.IsNotNull(functionArn);
            }
            else
            {
                Assert.IsInstanceOf(typeof(ResourceNotFoundException), responseException);
            }
            return functionArn;
        }
    }
}

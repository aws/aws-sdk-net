using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using Amazon.Lambda;
using Amazon.Lambda.Model;
using Amazon.Runtime;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Threading;
using UnityEngine;

namespace AWSSDK.Tests.Framework
{
    class UtilityMethods
    {
        public const string SDK_TEST_PREFIX = "aws-net-sdk";

        public static readonly string LambdaAssumeRolePolicyDocument =
@"
{
  ""Version"": ""2012-10-17"",
  ""Statement"": [
    {
      ""Sid"": """",
      ""Effect"": ""Allow"",
      ""Principal"": {
        ""Service"": ""lambda.amazonaws.com""
      },
      ""Action"": ""sts:AssumeRole""
    }
  ]
}
".Trim();

        public static readonly string FirehoseAssumeRolePolicyDocumentFormat =
@"{{
  ""Version"": ""2012-10-17"",
  ""Statement"": [
    {{
      ""Sid"": """",
      ""Effect"": ""Allow"",
      ""Principal"": {{
        ""Service"": ""firehose.amazonaws.com""
      }},
      ""Action"": ""sts:AssumeRole"",
      ""Condition"": {{
        ""StringEquals"": {{
          ""sts:ExternalId"": ""{0}""
        }}
      }}
    }}
  ]
}}
".Trim();

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
                Thread.Sleep(TimeSpan.FromSeconds(10));
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


        private static MemoryStream GetScriptStream(string codeb64)
        {
            return new MemoryStream(Convert.FromBase64String(codeb64));
        }

        /// <summary>
        /// Create a Lambda Function or return the ARN of the existing Lambda Function with the same name.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="functionName">Name of lambda function.</param>
        /// <param name="functionHandlerName">The name of the .js file that contains the Lambda handler.
        /// e.g helloworld.js has functionHandlerName "helloworld". </param>
        /// <param name="code">The Base64-encoded zip file of the code to be used. The name of the file
        /// in the zip file that contains the Lambda functio handler should match functionHandlerName.
        /// .Net 2.0 does not support System.IO.Compression.ZipArchive so the process of creating the
        /// Base64-encoded zip file should be done outside of the test framework in the following way:
        /// private static string CreateScriptBytesBase64(string name, string script)
        /// {
        ///     using (var stream = new MemoryStream())
        ///     {
        ///         using (var archive = new ZipArchive(stream, ZipArchiveMode.Create, true))
        ///         {
        ///             var entry = archive.CreateEntry(name + ".js");
        ///             using (var entryStream = entry.Open())
        ///             using (var writer = new StreamWriter(entryStream))
        ///             {
        ///                 writer.Write(script);
        ///             }
        ///         }
        ///         var bytes = stream.ToArray();
        ///         var base64 = Convert.ToBase64String(bytes);
        ///         return base64;
        ///     }
        /// }
        /// </param>
        /// <param name="iamRoleArn"></param>
        /// <returns></returns>
        public static string CreateFunctionIfNotExists(AmazonLambdaClient client, string functionName, string functionHandlerName, string code, string iamRoleArn)
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();

            string functionArn = UtilityMethods.GetFunctionArnIfExists(client, functionName);

            if (functionArn == null)
            {
                int retries = 3;
                long codeSize = -1;
                while (retries > 0)
                {
                    client.CreateFunctionAsync(new CreateFunctionRequest
                    {
                        FunctionName = functionName,
                        Code = new FunctionCode
                        {
                            ZipFile = GetScriptStream(code)
                        },
                        Handler = functionHandlerName + ".handler",
                        Runtime = Runtime.Nodejs,
                        Description = "Feel free to delete this function. The tests will recreate it when needed.",
                        Role = iamRoleArn
                    }, (response) =>
                    {
                        responseException = response.Exception;
                        if (responseException == null)
                        {
                            functionArn = response.Response.FunctionArn;
                            codeSize = response.Response.CodeSize;
                        }
                        ars.Set();
                    }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                    ars.WaitOne();
                    if (responseException == null)
                    {
                        break;
                    }
                    else
                    {
                        Utils.AssertTrue(responseException is InvalidParameterValueException);
                        // Need to wait longer for eventual consistency of role
                        retries--;
                        Thread.Sleep(TimeSpan.FromSeconds(10));
                    }
                }
                Assert.IsNotNull(functionArn);
                Utils.AssertTrue(codeSize > 0);
            }
            return functionArn;
        }


        public static bool DoesRoleHavePolicy(IAmazonIdentityManagementService iamClient, string policyName, string roleName)
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            List<string> policyNames = null;
            iamClient.ListRolePoliciesAsync(new ListRolePoliciesRequest()
            {
                RoleName = roleName,
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    policyNames = response.Response.PolicyNames;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.IsNotNull(policyNames);
            return policyNames.Contains(policyName);
        }

        public static void CreatePolicyIfNotExists(IAmazonIdentityManagementService iamClient, string policyName, string policyDocument, string roleName)
        {
            if (DoesRoleHavePolicy(iamClient, policyName, roleName))
            {
                return;
            }
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            iamClient.PutRolePolicyAsync(new PutRolePolicyRequest()
            {
                PolicyName = policyName,
                PolicyDocument = policyDocument,
                RoleName = roleName
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
        }


        public static string GenerateName()
        {
            return GenerateName(SDK_TEST_PREFIX + "-");
        }

        public static string GenerateName(string name)
        {
            return name + new System.Random().Next();
        }

    }
}

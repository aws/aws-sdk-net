using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Auth.AccessControlPolicy;
using Amazon.Auth.AccessControlPolicy.ActionIdentifiers;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using Amazon.Lambda;
using Amazon.Lambda.Model;
using Amazon.Runtime;

using AWSSDK_DotNet.IntegrationTests.Tests.S3;

#if BCL45
using System.IO.Compression;
using System.Text;
using AWSSDK_DotNet.IntegrationTests.Utils;
#endif

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class LambdaTests : TestBase<AmazonLambdaClient>
	{
        static readonly string LAMBDA_ASSUME_ROLE_POLICY =
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

        static IAmazonIdentityManagementService iamClient = new AmazonIdentityManagementServiceClient();
        static List<string> createdFunctionNames = new List<string>();
        static List<string> createdRoleNames = new List<string>();

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            DeleteCreatedFunctions(Client);
        }

        public static void DeleteCreatedFunctions(IAmazonLambda lambdaClient)
        {
            var deletedFunctions = new List<string>();
            foreach(var function in createdFunctionNames)
            {
                try
                {
                    lambdaClient.DeleteFunction(function);
                    deletedFunctions.Add(function);
                }
                catch { }
            }

            foreach (var df in deletedFunctions)
                createdFunctionNames.Remove(df);
        }

        [TestMethod]
        [TestCategory("Lambda")]
        public void ListFunctionsTest()
        {
            Client.ListFunctions();
        }

// This test depends on functionality that is only in 4.5
#if BCL45

        [TestMethod]
        [TestCategory("Lambda")]
        public void PolicyAndPermissionTest()
        {
            string functionName;
            string iamRoleName = null;
            bool iamRoleCreated = false;
            try
            {
                string iamRoleArn;
                string functionArn;
                CreateLambdaFunction(out functionName, out functionArn, out iamRoleName, out iamRoleArn);

                var publishResponse = Client.PublishVersion(new PublishVersionRequest
                {
                    FunctionName = functionName
                });
                var version = publishResponse.Version;

                var apr = new AddPermissionRequest
                {
                    FunctionName = functionName,
                    SourceAccount = "999999999999",
                    SourceArn = "arn:aws:s3:::cloudtrail-999999999999",
                    StatementId = "id1",
                    Principal = "s3.amazonaws.com",
                    Action = "lambda:InvokeFunction",
                    Qualifier = version
                };

                var addResponse = Client.AddPermission(apr);
                var statement = addResponse.Statement;
                var expectedFunctionName = functionArn + ":" + version;
                // verify that the qualifier (in query string) got sent to the server correctly
                // by checking that the function with the qualifier (version) is specified in the
                // statement we get back from the service
                Assert.IsTrue(statement.IndexOf(expectedFunctionName, StringComparison.Ordinal) >= 0);

                var policy = Client.GetPolicy(new Amazon.Lambda.Model.GetPolicyRequest
                {
                    FunctionName = functionName,
                    Qualifier = version
                }).Policy;
                // verify that the function is part of the policy
                Assert.IsTrue(policy.IndexOf(expectedFunctionName, StringComparison.Ordinal) >= 0);
            }
            finally
            {
                if (iamRoleCreated)
                    iamClient.DeleteRole(new DeleteRoleRequest { RoleName = iamRoleName });
            }
        }

        [TestMethod]
        [TestCategory("Lambda")]
        public void LambdaFunctionTest()
        {
            string functionName;
            string iamRoleName = null;
            bool iamRoleCreated = false;
            try
            {
                string iamRoleArn;
                string functionArn;
                CreateLambdaFunction(out functionName, out functionArn, out iamRoleName, out iamRoleArn);

                // List all the functions and make sure the newly uploaded function is in the collection
                var listResponse = Client.ListFunctions();
                var function = listResponse.Functions.FirstOrDefault(x => x.FunctionName == functionName);
                Assert.IsNotNull(function);
                Assert.AreEqual("helloworld.handler", function.Handler);
                Assert.AreEqual(iamRoleArn, function.Role);

                // Get the function with a presigned URL to the uploaded code
                var getFunctionResponse = Client.GetFunction(functionName);
                Assert.AreEqual("helloworld.handler", getFunctionResponse.Configuration.Handler);
                Assert.IsNotNull(getFunctionResponse.Code.Location);

                // Get the function's configuration only
                var getFunctionConfiguration = Client.GetFunctionConfiguration(functionName);
                Assert.AreEqual("helloworld.handler", getFunctionConfiguration.Handler);

                // Call the function
                var invokeAsyncResponse = Client.InvokeAsync(functionName);
                Assert.AreEqual(invokeAsyncResponse.Status, 202); // Status Code Accepted

                var clientContext = @"{""System"": ""Windows""}";
                var clientContextBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(clientContext));
                var request = new InvokeRequest
                {
                    FunctionName = functionName,
                    InvocationType = InvocationType.RequestResponse,
                    LogType = LogType.None,
                    ClientContext = clientContext,
                    Payload = @"{""Key"": ""testing""}"
                };
                Assert.AreEqual(clientContext, request.ClientContext);
                Assert.AreEqual(clientContextBase64, request.ClientContextBase64);

                // Call the function sync
                var invokeSyncResponse = Client.Invoke(request);
                Assert.IsNull(invokeSyncResponse.FunctionError);
                Assert.IsNull(invokeSyncResponse.LogResult);
                Assert.IsNotNull(invokeSyncResponse.Payload);
                Assert.AreNotEqual(0, invokeSyncResponse.Payload.Length);
                Assert.AreNotEqual(0, invokeSyncResponse.StatusCode);

                // Call the function sync, dry run, no payload
                invokeSyncResponse = Client.Invoke(new InvokeRequest
                {
                    FunctionName = functionName,
                    InvocationType = InvocationType.DryRun,
                    LogType = LogType.None,
                    ClientContext = clientContext,
                    Payload = @"{""Key"": ""testing""}"
                });
                Assert.IsNull(invokeSyncResponse.FunctionError);
                Assert.IsNull(invokeSyncResponse.LogResult);
                Assert.IsNotNull(invokeSyncResponse.Payload);
                Assert.AreEqual(0, invokeSyncResponse.Payload.Length);
                Assert.AreNotEqual(0, invokeSyncResponse.StatusCode);

                // Call the function sync, pass non-JSON payload
                invokeSyncResponse = Client.Invoke(new InvokeRequest
                {
                    FunctionName = functionName,
                    InvocationType = InvocationType.RequestResponse,
                    LogType = LogType.None,
                    ClientContext = clientContext,
                    Payload = @"""Key"": ""testing"""
                });
                Assert.IsNotNull(invokeSyncResponse.FunctionError);
                Assert.IsNull(invokeSyncResponse.LogResult);
                Assert.IsNotNull(invokeSyncResponse.Payload);
                Assert.AreNotEqual(0, invokeSyncResponse.Payload.Length);
                Assert.AreNotEqual(0, invokeSyncResponse.StatusCode);
            }
            finally
            {
                if (iamRoleCreated)
                    iamClient.DeleteRole(new DeleteRoleRequest { RoleName = iamRoleName });
            }
        }

        public static void CreateLambdaFunction(out string functionName, out string functionArn, out string iamRoleName, out string iamRoleArn)
        {
            functionName = "HelloWorld-" + DateTime.Now.Ticks;
            iamRoleName = "Lambda-" + DateTime.Now.Ticks;

            CreateLambdaFunction(functionName, iamRoleName, out iamRoleArn, out functionArn);
        }

        public static void CreateLambdaFunction(string functionName, string iamRoleName, out string iamRoleArn, out string functionArn)
        {
            var iamCreateResponse = iamClient.CreateRole(new CreateRoleRequest
            {
                RoleName = iamRoleName,
                AssumeRolePolicyDocument = LAMBDA_ASSUME_ROLE_POLICY
            });
            iamRoleArn = iamCreateResponse.Role.Arn;
            
            var statement = new Amazon.Auth.AccessControlPolicy.Statement(
                Amazon.Auth.AccessControlPolicy.Statement.StatementEffect.Allow);
            statement.Actions.Add(S3ActionIdentifiers.PutObject);
            statement.Actions.Add(S3ActionIdentifiers.GetObject);
            statement.Resources.Add(new Resource("*"));


            var policy = new Amazon.Auth.AccessControlPolicy.Policy();
            policy.Statements.Add(statement);

            iamClient.PutRolePolicy(new PutRolePolicyRequest
            {
                RoleName = iamRoleName,
                PolicyName = "admin",
                PolicyDocument = policy.ToJson()
            });

            MemoryStream stream = CreateScriptStream();
            var uploadRequest = new CreateFunctionRequest
            {
                FunctionName = functionName,
                Code = new FunctionCode
                {
                    ZipFile = stream
                },
                Handler = "helloworld.handler",
                //Mode = Mode.Event,
                Runtime = Runtime.Nodejs,
                Role = iamCreateResponse.Role.Arn
            };

            var uploadResponse = UtilityMethods.WaitUntilSuccess(() => Client.CreateFunction(uploadRequest));
            createdFunctionNames.Add(functionName);

            Assert.IsTrue(uploadResponse.CodeSize > 0);
            Assert.IsNotNull(uploadResponse.FunctionArn);

            functionArn = uploadResponse.FunctionArn;
        }

        private static MemoryStream CreateScriptStream()
        {
            const string HELLO_SCRIPT =
@"console.log('Loading event');
exports.handler = function(event, context) {
  console.log(""value = "" + event.Key);
  context.done(null, ""Hello World:"" + event.Key + "", "" + context.System);  // SUCCESS with message
}";
            MemoryStream stream = new MemoryStream();
            using (ZipArchive archive = new ZipArchive(stream, ZipArchiveMode.Create, true))
            {
                var entry = archive.CreateEntry("helloworld.js");
                using (var entryStream = entry.Open())
                using (var writer = new StreamWriter(entryStream))
                {
                    writer.Write(HELLO_SCRIPT);
                }
            }
            stream.Position = 0;
            return stream;
        }
#endif
    }
}
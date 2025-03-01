using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Auth.AccessControlPolicy;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using Amazon.Lambda;
using Amazon.Lambda.Model;
using Amazon.Runtime;
using System.Threading.Tasks;
using System.Net;
using Amazon.Lambda.Model.Internal.MarshallTransformations;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;

#if BCL
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
        const string HELLO_SCRIPT =
@"console.log('Loading event');
exports.handler = function(event, context) {
  console.log(""value = "" + event.Key);
  context.done(null, ""Hello World:"" + event.Key + "", "" + context.System);  // SUCCESS with message
}";
        const string STREAMIFY_RESPONSE_SCRIPT =
            @"
import util from 'util'; 
import stream from 'stream';
const { Readable } = stream;
const pipeline = util.promisify(stream.pipeline);

export const handler = awslambda.streamifyResponse(async (event, responseStream, _context) => {
  const requestStream = Readable.from(Buffer.from(new Array(1024*1024).join( '🚣' )));
  await pipeline(requestStream, responseStream);
});
";
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
            var functions = EnumerateFunctions().ToList();
        }

        public static IEnumerable<FunctionConfiguration> EnumerateFunctions()
        {
            var request = new ListFunctionsRequest();
            do
            {
                var response = Client.ListFunctions(request);
                request.Marker = response.NextMarker;
                foreach (var function in response.Functions)
                    yield return function;
            } while (!string.IsNullOrEmpty(request.Marker));
        }

        // This test depends on functionality that is only in 4.5
#if BCL
        [Ignore("Excluding tests that need IAM Write/Permissions management.")]
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
                CreateLambdaFunction(out functionName, out functionArn, out iamRoleName, out iamRoleArn, HELLO_SCRIPT, Runtime.Nodejs43);

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
        [Ignore("Excluding tests that need IAM Write/Permissions management.")]
        [TestMethod]
        [TestCategory("Lambda")]
        public async Task StreamifyLambdaResponseTest()
        {
            try
            {
                //Arrange
                var functionName = "HelloWorld-" + DateTime.UtcNow.Ticks;
                var iamRoleName = "Lambda-" + DateTime.UtcNow.Ticks;
                var request = new CreateRoleRequest
                {
                    RoleName = iamRoleName,
                    AssumeRolePolicyDocument = LAMBDA_ASSUME_ROLE_POLICY
                };
                var iamRoleResponse = UtilityMethods.WaitUntilSuccess(() => iamClient.CreateRole(request));
                SetupPolicies(iamRoleName);
                var iamRole = iamRoleResponse.Role;
                MemoryStream stream = CreateScriptStream(STREAMIFY_RESPONSE_SCRIPT);
                string handlerName = "helloworld.handler";
                var uploadRequest = new CreateFunctionRequest
                {
                    FunctionName = functionName,
                    Code = new FunctionCode
                    {
                        ZipFile = stream
                    },
                    Handler = handlerName,
                    Runtime = Runtime.Nodejs14X,
                    Role = iamRole.Arn
                };
                var uploadResponse = UtilityMethods.WaitUntilSuccess( () => Client.CreateFunction(uploadRequest));
                GetFunctionRequest getFunctionRequest = new GetFunctionRequest
                {
                    FunctionName = functionName
                };
                int attempts = 0;
                while(true || attempts < 5) // do not wait for longer than 10 seconds
                {
                    var responseState = Client.GetFunction(getFunctionRequest);
                    if (responseState.Configuration.State == State.Active)
                        break;
                    Thread.Sleep(2000);
                    attempts++;
                }
                Assert.IsTrue(uploadResponse.CodeSize > 0);
                Assert.IsNotNull(uploadResponse.FunctionArn);
                // Get the function with a presigned URL to the uploaded code
                var getFunctionResponse = await Client.GetFunctionAsync(functionName);
                Assert.AreEqual(handlerName, getFunctionResponse.Configuration.Handler);
                Assert.IsNotNull(getFunctionResponse.Code.Location);

                // Get the function's configuration only
                var getFunctionConfiguration = await Client.GetFunctionConfigurationAsync(functionName);
                Assert.AreEqual(handlerName, getFunctionConfiguration.Handler);
                createdFunctionNames.Add(functionName);
                var endWaitHandle = new AutoResetEvent(false);
                InvokeWithResponseStreamResponse response;
                try
                {
                    response = await Client.InvokeWithResponseStreamAsync(new InvokeWithResponseStreamRequest()
                    {
                        FunctionName = functionName,
                        InvocationType = ResponseStreamingInvocationType.DryRun
                    });
                    using (var eventStream = response.EventStream)
                    {
                        // Since everything happens on a background thread, exceptions are raised as events.
                        // Here, we are just throwing the exception received.
                        eventStream.ExceptionReceived += (sender, args) =>
                        {
                            endWaitHandle.Set();
                            throw args.EventStreamException;
                        };

                        eventStream.EventReceived += (sender, args) =>
                            Console.WriteLine($"Received {args.EventStreamEvent.GetType().Name}!");
                        eventStream.PayloadChunkReceived += (sender, args) =>
                            Console.WriteLine($"Received {args.EventStreamEvent.GetType().Name}!");
                        eventStream.InvokeCompleteReceived += (sender, args) => endWaitHandle.Set();

                        eventStream.StartProcessing();
                        endWaitHandle.WaitOne(TimeSpan.FromSeconds(10)); // if we get the data sooner it will exit and not wait.
                        Assert.AreEqual(HttpStatusCode.OK, response.HttpStatusCode);
                    }
                }
                catch (Exception)
                {
                    throw;
                }

            }
            catch(Exception)
            {
                throw;
            }
        }

        [Ignore("Excluding tests that need IAM Write/Permissions management.")]
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
                CreateLambdaFunction(out functionName, out functionArn, out iamRoleName, out iamRoleArn, HELLO_SCRIPT, Runtime.Nodejs43);

                // List all the functions and make sure the newly uploaded function is in the collection
                UtilityMethods.WaitUntilSuccess(() =>
                {
                    var functions = EnumerateFunctions().ToList();
                    var function = functions.FirstOrDefault(x => x.FunctionName == functionName);
                    Assert.IsNotNull(function);
                    Assert.AreEqual("helloworld.handler", function.Handler);
                    Assert.AreEqual(iamRoleArn, function.Role);
                });

                // Get the function with a presigned URL to the uploaded code
                var getFunctionResponse = Client.GetFunction(functionName);
                Assert.AreEqual("helloworld.handler", getFunctionResponse.Configuration.Handler);
                Assert.IsNotNull(getFunctionResponse.Code.Location);

                // Get the function's configuration only
                var getFunctionConfiguration = Client.GetFunctionConfiguration(functionName);
                Assert.AreEqual("helloworld.handler", getFunctionConfiguration.Handler);

                // Call the function
                var invokeResponse = Client.Invoke(new InvokeRequest { FunctionName = functionName });
                Assert.AreEqual(invokeResponse.StatusCode, 202); // Status Code Accepted

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

        public static void CreateLambdaFunction(out string functionName, out string functionArn, out string iamRoleName, out string iamRoleArn, string functionCode, Runtime runtime)
        {
            functionName = "HelloWorld-" + DateTime.UtcNow.Ticks;
            iamRoleName = "Lambda-" + DateTime.UtcNow.Ticks;

            CreateLambdaFunction(functionName, iamRoleName, out iamRoleArn, out functionArn, functionCode, runtime);
        }

        private static void SetupPolicies(string iamRoleName)
        {
            var statement = new Amazon.Auth.AccessControlPolicy.Statement(
                Amazon.Auth.AccessControlPolicy.Statement.StatementEffect.Allow);
            statement.Actions.Add("s3:PutObject");
            statement.Actions.Add("s3:GetObject");
            statement.Resources.Add(new Resource("*"));

            var policy = new Amazon.Auth.AccessControlPolicy.Policy();
            policy.Statements.Add(statement);

            iamClient.PutRolePolicy(new PutRolePolicyRequest
            {
                RoleName = iamRoleName,
                PolicyName = "admin",
                PolicyDocument = policy.ToJson()
            });

        }

        public static void CreateLambdaFunction(string functionName, string iamRoleName, out string iamRoleArn, out string functionArn, string functionCode, Runtime runtime)
        {
            var iamCreateResponse = iamClient.CreateRole(new CreateRoleRequest
            {
                RoleName = iamRoleName,
                AssumeRolePolicyDocument = LAMBDA_ASSUME_ROLE_POLICY
            });
            iamRoleArn = iamCreateResponse.Role.Arn;
            SetupPolicies(iamRoleName);

            MemoryStream stream = CreateScriptStream(functionCode);
            var uploadRequest = new CreateFunctionRequest
            {
                FunctionName = functionName,
                Code = new FunctionCode
                {
                    ZipFile = stream
                },
                Handler = "helloworld.handler",
                Runtime = runtime,
                Role = iamCreateResponse.Role.Arn
            };

            var uploadResponse = UtilityMethods.WaitUntilSuccess(() => Client.CreateFunction(uploadRequest));
            createdFunctionNames.Add(functionName);

            Assert.IsTrue(uploadResponse.CodeSize > 0);
            Assert.IsNotNull(uploadResponse.FunctionArn);

            functionArn = uploadResponse.FunctionArn;
        }

        private static MemoryStream CreateScriptStream(string functionCode)
        {
            MemoryStream stream = new MemoryStream();
            using (ZipArchive archive = new ZipArchive(stream, ZipArchiveMode.Create, true))
            {
                var entry = archive.CreateEntry("helloworld.js");
                using (var entryStream = entry.Open())
                using (var writer = new StreamWriter(entryStream))
                {
                    writer.Write(functionCode);
                }
            }
            stream.Position = 0;
            return stream;
        }
#endif
    }
}
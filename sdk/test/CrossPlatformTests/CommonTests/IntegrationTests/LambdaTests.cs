using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading;


using Amazon.Auth.AccessControlPolicy;
using Amazon.Auth.AccessControlPolicy.ActionIdentifiers;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using Amazon.Lambda;
using Amazon.Lambda.Model;
using Amazon.Runtime;
using CommonTests.Framework;
using NUnit.Framework;

using System.IO.Compression;
using System.Text;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class LambdaTests : TestBase<AmazonLambdaClient>
	{
        static IAmazonIdentityManagementService iamClient = TestBase.CreateClient<AmazonIdentityManagementServiceClient>();
        static List<string> createdFunctionNames = new List<string>();

        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        [TearDown]
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
                    lambdaClient.DeleteFunctionAsync(function).Wait();
                    deletedFunctions.Add(function);
                }
                catch { }
            }

            foreach (var df in deletedFunctions)
                createdFunctionNames.Remove(df);
        }

        [Test]
        public void ListFunctionsTest()
        {
            var result = Client.ListFunctionsAsync().Result;
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ResponseMetadata);
            Assert.IsNotNull(result.ResponseMetadata.RequestId);
        }

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

        [Test]
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
                var listResponse = Client.ListFunctionsAsync().Result;
                var function = listResponse.Functions.FirstOrDefault(x => x.FunctionName == functionName);
                Assert.IsNotNull(function);
                Assert.AreEqual("helloworld.handler", function.Handler);
                Assert.AreEqual(iamRoleArn, function.Role);

                // Get the function with a presigned URL to the uploaded code
                var getFunctionResponse = Client.GetFunctionAsync(functionName).Result;
                Assert.AreEqual("helloworld.handler", getFunctionResponse.Configuration.Handler);
                Assert.IsNotNull(getFunctionResponse.Code.Location);

                // Get the function's configuration only
                var getFunctionConfiguration = Client.GetFunctionConfigurationAsync(functionName).Result;
                Assert.AreEqual("helloworld.handler", getFunctionConfiguration.Handler);

                // Call the function
#pragma warning disable 618
                var invokeAsyncResponse = Client.InvokeAsyncAsync(new InvokeAsyncRequest
                {
                    FunctionName = functionName,
                    InvokeArgs = "{}"
                }).Result;
#pragma warning restore 618
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
                var invokeSyncResponse = Client.InvokeAsync(request).Result;
                Assert.IsNull(invokeSyncResponse.FunctionError);
                Assert.IsNull(invokeSyncResponse.LogResult);
                Assert.IsNotNull(invokeSyncResponse.Payload);
                Assert.AreNotEqual(0, invokeSyncResponse.Payload.Length);
                Assert.AreNotEqual(0, invokeSyncResponse.StatusCode);

                // Call the function sync, dry run, no payload
                invokeSyncResponse = Client.InvokeAsync(new InvokeRequest
                {
                    FunctionName = functionName,
                    InvocationType = InvocationType.DryRun,
                    LogType = LogType.None,
                    ClientContext = clientContext,
                    Payload = @"{""Key"": ""testing""}"
                }).Result;
                Assert.IsNull(invokeSyncResponse.FunctionError);
                Assert.IsNull(invokeSyncResponse.LogResult);
                Assert.IsNotNull(invokeSyncResponse.Payload);
                Assert.AreEqual(0, invokeSyncResponse.Payload.Length);
                Assert.AreNotEqual(0, invokeSyncResponse.StatusCode);

                // Call the function sync, pass non-JSON payload
                invokeSyncResponse = Client.InvokeAsync(new InvokeRequest
                {
                    FunctionName = functionName,
                    InvocationType = InvocationType.RequestResponse,
                    LogType = LogType.None,
                    ClientContext = clientContext,
                    Payload = @"""Key"": ""testing"""
                }).Result;
                Assert.IsNotNull(invokeSyncResponse.FunctionError);
                Assert.IsNull(invokeSyncResponse.LogResult);
                Assert.IsNotNull(invokeSyncResponse.Payload);
                Assert.AreNotEqual(0, invokeSyncResponse.Payload.Length);
                Assert.AreNotEqual(0, invokeSyncResponse.StatusCode);
            }
            finally
            {
                if (iamRoleCreated)
                    iamClient.DeleteRoleAsync(new DeleteRoleRequest { RoleName = iamRoleName }).Wait();
            }
        }

        public void CreateLambdaFunction(out string functionName, out string functionArn, out string iamRoleName, out string iamRoleArn)
        {
            functionName = "HelloWorld-" + DateTime.Now.Ticks;
            iamRoleName = "Lambda-" + DateTime.Now.Ticks;

            CreateLambdaFunction(functionName, iamRoleName, out iamRoleArn, out functionArn);
        }

        public void CreateLambdaFunction(string functionName, string iamRoleName, out string iamRoleArn, out string functionArn)
        {
            var iamCreateResponse = iamClient.CreateRoleAsync(new CreateRoleRequest
            {
                RoleName = iamRoleName,
                AssumeRolePolicyDocument = LAMBDA_ASSUME_ROLE_POLICY
            }).Result;
            iamRoleArn = iamCreateResponse.Role.Arn;
            
            var statement = new Amazon.Auth.AccessControlPolicy.Statement(
                Amazon.Auth.AccessControlPolicy.Statement.StatementEffect.Allow);
            statement.Actions.Add(S3ActionIdentifiers.PutObject);
            statement.Actions.Add(S3ActionIdentifiers.GetObject);
            statement.Resources.Add(new Resource("*"));


            var policy = new Amazon.Auth.AccessControlPolicy.Policy();
            policy.Statements.Add(statement);

            iamClient.PutRolePolicyAsync(new PutRolePolicyRequest
            {
                RoleName = iamRoleName,
                PolicyName = "admin",
                PolicyDocument = policy.ToJson()
            }).Wait();

            MemoryStream stream = GetScriptStream();
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

            var uploadResponse = UtilityMethods.WaitUntilSuccess(() => Client.CreateFunctionAsync(uploadRequest).Result);
            createdFunctionNames.Add(functionName);

            Assert.IsTrue(uploadResponse.CodeSize > 0);
            Assert.IsNotNull(uploadResponse.FunctionArn);

            functionArn = uploadResponse.FunctionArn;
        }

        private static MemoryStream GetScriptStream()
        {
            return new MemoryStream(Convert.FromBase64String(HELLO_SCRIPT_BYTES_BASE64));
        }

        private static string HELLO_SCRIPT_BYTES_BASE64 = "UEsDBBQAAAAIANZsA0emOtZ2nwAAANoAAAANAAAAaGVsbG93b3JsZC5qc1XMQQuCQBCG4bvgfxj2opKs96STBEHdJDovOqkwzoS7mhL999Qw6DYfzPMWwlYINUkVBhcxZcMV4IDsgij1PRwf0jmra8MlYQcHuPdcuEY4XJ9iKIQdji6Cl+/Bsn45NRjqcSYKdt+kPuO0VGFTuhTGkHuiGNQJiQRu0lG5/yPzreK1srF8sg7bKAVIEsivWXbMc3g2roYWrTUV+t77A1BLAQIUABQAAAAIANZsA0emOtZ2nwAAANoAAAANAAAAAAAAAAAAAAAAAAAAAABoZWxsb3dvcmxkLmpzUEsFBgAAAAABAAEAOwAAAMoAAAAAAA==";

        // The above base64 string was generated by calling the below function in a 4.5 application with name="helloworld" and script=HELLO_SCRIPT

//        private static string HELLO_SCRIPT =
//@"console.log('Loading event');
//exports.handler = function(event, context) {
//  console.log(""value = "" + event.Key);
//  context.done(null, ""Hello World:"" + event.Key + "", "" + context.System);  // SUCCESS with message
//}";

        //private static string CreateScriptBytesBase64(string name, string script)
        //{
        //    using (var stream = new MemoryStream())
        //    {
        //        using (var archive = new ZipArchive(stream, ZipArchiveMode.Create, true))
        //        {
        //            var entry = archive.CreateEntry(name + ".js");
        //            using (var entryStream = entry.Open())
        //            using (var writer = new StreamWriter(entryStream))
        //            {
        //                writer.Write(script);
        //            }
        //        }
        //        var bytes = stream.ToArray();
        //        var base64 = Convert.ToBase64String(bytes);
        //        return base64;
        //    }
        //}
        
//#endif
    }
}
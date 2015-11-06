using Amazon.Runtime;
using Amazon.Lambda;
using Amazon.Lambda.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;
using AWSSDK.Tests.Framework;

namespace AWSSDK.IntegrationTests.Lambda
{
    [TestFixture(TestOf = typeof(LambdaTests))]
    [Category("Integration")]
    class LambdaTests : TestBase<AmazonLambdaClient>
    {
        static IAmazonIdentityManagementService iamClient = TestBase.CreateClient<AmazonIdentityManagementServiceClient>();
        static List<string> createdFunctionNames = new List<string>();

        static readonly string FunctionName = "UnityLambdaTestFunction";
        static readonly string IAMRoleName = "UnityLambdaTestFunctionRole";
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

        private string FunctionArn = null;

        [Test]
        public void ListFunctionsTest()
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            ResponseMetadata responseMetadata = null;
            Client.ListFunctionsAsync((response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    responseMetadata = response.Response.ResponseMetadata;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.IsNotNull(responseMetadata);
            Assert.IsNotNull(responseMetadata.RequestId);
        }

        [Test]
        public void LambdaFunctionTest()
        {
            // Call the function
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            string functionError = null;
            string logResult = null;
            MemoryStream payload = null;
            int statusCode = -1;
            Client.InvokeAsync(new InvokeRequest
            {
                FunctionName = FunctionName,
                InvocationType = InvocationType.RequestResponse,
                LogType = LogType.None,
                // TODO: Use client context
                Payload = @"{""Key"": ""testing""}"
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    functionError = response.Response.FunctionError;
                    logResult = response.Response.LogResult;
                    payload = response.Response.Payload;
                    statusCode = response.Response.StatusCode;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.IsNull(functionError);
            Assert.IsNull(logResult);
            Assert.IsNotNull(payload);
            Assert.AreNotEqual(0, payload.Length);
            Assert.AreNotEqual(0, statusCode);

            // Call the function dry run
            Client.InvokeAsync(new InvokeRequest
            {
                FunctionName = FunctionName,
                InvocationType = InvocationType.DryRun,
                LogType = LogType.None,
                // TODO: Use client context
                Payload = @"{""Key"": ""testing""}"
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    functionError = response.Response.FunctionError;
                    logResult = response.Response.LogResult;
                    payload = response.Response.Payload;
                    statusCode = response.Response.StatusCode;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.IsNull(functionError);
            Assert.IsNull(logResult);
            Assert.IsNotNull(payload);
            Assert.AreEqual(0, payload.Length);
            Assert.AreNotEqual(0, statusCode);

            // Call the function, pass non-JSON payload
            Client.InvokeAsync(new InvokeRequest
            {
                FunctionName = FunctionName,
                InvocationType = InvocationType.RequestResponse,
                LogType = LogType.None,
                // TODO: Use client context
                Payload = @"""Key"": ""testing"""
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    functionError = response.Response.FunctionError;
                    logResult = response.Response.LogResult;
                    payload = response.Response.Payload;
                    statusCode = response.Response.StatusCode;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.IsNotNull(functionError);
            Assert.IsNull(logResult);
            Assert.IsNotNull(payload);
            Assert.AreNotEqual(0, payload.Length);
            Assert.AreNotEqual(0, statusCode);
        }

        [TestFixtureSetUp]
        public void CreateLambdaFunctionIfDoesNotExist()
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();

            // Get role arn if it exists.
            string iamRoleArn = null;
            iamClient.GetRoleAsync(new GetRoleRequest()
            {
                RoleName = IAMRoleName
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    iamRoleArn = response.Response.Role.Arn;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            if (responseException == null)
            {
                Assert.IsNotNull(iamRoleArn);
            }
            else
            {
                Assert.IsInstanceOf(typeof(NoSuchEntityException), responseException);
            }

            // Get the function if it exists.
            Client.GetFunctionAsync(new GetFunctionRequest()
            {
                FunctionName = FunctionName
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    FunctionArn = response.Response.Configuration.FunctionArn;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            if (responseException == null)
            {
                Assert.IsNotNull(FunctionArn);
            }
            else
            {
                Assert.IsInstanceOf(typeof(ResourceNotFoundException), responseException);
            }

            // Create the role if we couldn't find it.
            if (iamRoleArn == null)
            {
                iamClient.CreateRoleAsync(new CreateRoleRequest
                {
                    RoleName = IAMRoleName,
                    AssumeRolePolicyDocument = LAMBDA_ASSUME_ROLE_POLICY
                }, (response) =>
                {
                    responseException = response.Exception;
                    if (responseException == null)
                    {
                        iamRoleArn = response.Response.Role.Arn;
                    }
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Assert.IsNull(responseException);
                Assert.IsFalse(string.IsNullOrEmpty(iamRoleArn));

                // Wait for role to be fully initialized
                Thread.Sleep(TimeSpan.FromSeconds(3));
            }

            if (FunctionArn == null)
            {
                long codeSize = -1;
                Client.CreateFunctionAsync(new CreateFunctionRequest
                {
                    FunctionName = FunctionName,
                    Code = new FunctionCode
                    {
                        ZipFile = GetScriptStream()
                    },
                    Handler = "helloworld.handler",
                    Runtime = Runtime.Nodejs,
                    Description = "Feel free to delete this function. The tests will recreate it when needed.",
                    Role = iamRoleArn
                }, (response) =>
                {
                    responseException = response.Exception;
                    if (responseException == null)
                    {
                        FunctionArn = response.Response.FunctionArn;
                        codeSize = response.Response.CodeSize;
                    }
                    ars.Set();
                }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
                ars.WaitOne();
                Assert.IsNull(responseException);
                Assert.IsNotNull(FunctionArn);
                Assert.IsTrue(codeSize > 0);
            }

            // List all the functions and make sure the newly uploaded function is in the collection
            List<FunctionConfiguration> functions = null;
            Client.ListFunctionsAsync((response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    functions = response.Response.Functions;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);

            FunctionConfiguration function = null;
            foreach (FunctionConfiguration functionConfig in functions)
            {
                if (functionConfig.FunctionName == FunctionName)
                {
                    function = functionConfig;
                    break;
                }
            }
            Assert.IsNotNull(function);
            Assert.AreEqual("helloworld.handler", function.Handler);
            Assert.AreEqual(iamRoleArn, function.Role);

            // Get the function with a presigned URL to the uploaded code
            FunctionConfiguration configuration = null;
            FunctionCodeLocation code = null;
            Client.GetFunctionAsync(FunctionName, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    configuration = response.Response.Configuration;
                    code = response.Response.Code;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.AreEqual("helloworld.handler", configuration.Handler);
            Assert.IsNotNull(code.Location);

            // Get the function's configuration only
            string handler = null;
            Client.GetFunctionConfigurationAsync(FunctionName, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    handler = response.Response.Handler;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.AreEqual("helloworld.handler", handler);
        }

        private static MemoryStream GetScriptStream()
        {
            return new MemoryStream(Convert.FromBase64String(HELLO_SCRIPT_BYTES_BASE64));
        }

        private static string HELLO_SCRIPT_BYTES_BASE64 = "UEsDBBQAAAAIANZsA0emOtZ2nwAAANoAAAANAAAAaGVsbG93b3JsZC5qc1XMQQuCQBCG4bvgfxj2opKs96STBEHdJDovOqkwzoS7mhL999Qw6DYfzPMWwlYINUkVBhcxZcMV4IDsgij1PRwf0jmra8MlYQcHuPdcuEY4XJ9iKIQdji6Cl+/Bsn45NRjqcSYKdt+kPuO0VGFTuhTGkHuiGNQJiQRu0lG5/yPzreK1srF8sg7bKAVIEsivWXbMc3g2roYWrTUV+t77A1BLAQIUABQAAAAIANZsA0emOtZ2nwAAANoAAAANAAAAAAAAAAAAAAAAAAAAAABoZWxsb3dvcmxkLmpzUEsFBgAAAAABAAEAOwAAAMoAAAAAAA==";
    }
}

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
using UnityEngine;

namespace AWSSDK.IntegrationTests.Lambda
{
    [TestFixture(TestOf = typeof(LambdaTests))]
    [Category("Integration")]
    class LambdaTests : TestBase<AmazonLambdaClient>
    {
        IAmazonIdentityManagementService iamClient = TestBase.CreateClient<AmazonIdentityManagementServiceClient>();
        List<string> createdFunctionNames = new List<string>();

        static readonly string FunctionHandleName = "unitytest-helloworld";
        // The Base64 representation of the Zip file of the Lambda function's code. See the
        // comments for UtilityMethods.CreateFunctionIfNotExists for more information.
        static readonly string FunctionScriptBytesBase64 = "UEsDBBQAAAAIALp8akdqGoqboQAAAN4AAAAXAAAAdW5pdHl0ZXN0LWhlbGxvd29ybGQuanNVjEELgkAQRu+C/2HwopKs96STBEHdJDov66TCOBPuakr031MrqO/0Hd57RtgKoSKpovAkumy4AhyQXRhnvofjTTpnVa25JOxgB9eejWuEoxVKwAg7HF0MD9+DeeYnGAyaepylADbvqDritHQ/5GKqUhgj7okSCA5IJHCRjsrtnzT/IFk7X62YrMM2zgDSFIpznu+LAu6Nq6FFa3WFvvd8AVBLAQIUABQAAAAIALp8akdqGoqboQAAAN4AAAAXAAAAAAAAAAAAAAAAAAAAAAB1bml0eXRlc3QtaGVsbG93b3JsZC5qc1BLBQYAAAAAAQABAEUAAADWAAAAAAA=";

        static readonly string IAMRoleName = "UnityLambdaTestFunctionRole";

        private string FunctionName = null;

        [Test]
        [Category("WWW")]
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
        [Category("WWW")]
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
                LogType = Amazon.Lambda.LogType.None,
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
                LogType = Amazon.Lambda.LogType.None,
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
                LogType = Amazon.Lambda.LogType.None,
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

        [OneTimeTearDown]
        public void TearDown()
        {
            MissingAPILambdaFunctions.DeleteLambdaFunction(FunctionName, TestRunner.RegionEndpoint);
        }

        [OneTimeSetUp]
        public void SetUp()
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();

            string iamRoleArn = UtilityMethods.CreateRoleIfNotExists(iamClient, IAMRoleName, UtilityMethods.LambdaAssumeRolePolicyDocument);
            Assert.IsNotNull(iamRoleArn);

            FunctionName = "UnityTestFunction" + DateTime.Now.Ticks;
            UtilityMethods.CreateFunctionIfNotExists(Client, FunctionName, FunctionHandleName, FunctionScriptBytesBase64, iamRoleArn);

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
            Assert.AreEqual(FunctionHandleName + ".handler", function.Handler);
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
            Assert.AreEqual(FunctionHandleName + ".handler", configuration.Handler);
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
            Assert.AreEqual(FunctionHandleName + ".handler", handler);
        }
    }
}

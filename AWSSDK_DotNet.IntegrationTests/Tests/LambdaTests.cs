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
#endif

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class LambdaTests
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

        static IAmazonIdentityManagementService iamClient;
        static IAmazonLambda lambdaClient;
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            lambdaClient = new AmazonLambdaClient();

            iamClient = new AmazonIdentityManagementServiceClient();
        }

        [TestMethod]
        public void ListFunctionsTest()
        {
            lambdaClient.ListFunctions();
        }

#if BCL45
        [TestMethod]
        public void LambdaFunctionTest()
        {
            const string HELLO_SCRIPT = 
@"console.log('Loading http')
 
exports.handler = function (request, response) {
    response.write(""Hello, world!"");
    response.end();
    console.log(""Request completed"");
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

            var functionName = "HelloWorld";
            bool uploaded = false;

            var iamRoleName = "Lambda-" + DateTime.Now.Ticks;
            bool iamRoleCreated = false;
            try
            {
                var iamCreateResponse = iamClient.CreateRole(new CreateRoleRequest
                    {
                        RoleName = iamRoleName,
                        AssumeRolePolicyDocument = LAMBDA_ASSUME_ROLE_POLICY
                    });

                var statement = new Statement(Statement.StatementEffect.Allow);
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

                // Wait for the role and policy to propagate
                Thread.Sleep(5000);

                var uploadRequest = new UploadFunctionRequest
                {
                    FunctionName = functionName,
                    FunctionZip = stream,
                    Handler = "helloworld.handler",
                    Mode = Mode.Event,
                    Runtime = Runtime.Nodejs,
                    Role = iamCreateResponse.Role.Arn
                };

                var uploadResponse = lambdaClient.UploadFunction(uploadRequest);
                uploaded = true;
                Assert.IsTrue(uploadResponse.CodeSize > 0);
                Assert.IsNotNull(uploadResponse.ConfigurationId);

                // List all the functions and make sure the newly uploaded function is in the collection
                var listResponse = lambdaClient.ListFunctions();
                var function = listResponse.Functions.FirstOrDefault(x => x.FunctionName == functionName);
                Assert.IsNotNull(function);
                Assert.AreEqual("helloworld.handler", function.Handler);
                Assert.AreEqual(iamCreateResponse.Role.Arn, function.Role);

                // Get the function with a presigned URL to the uploaded code
                var getFunctionResponse = lambdaClient.GetFunction(functionName);
                Assert.AreEqual("helloworld.handler", getFunctionResponse.Configuration.Handler);
                Assert.IsNotNull(getFunctionResponse.Code.Location);

                // Get the function's configuration only
                var getFunctionConfiguration = lambdaClient.GetFunctionConfiguration(functionName);
                Assert.AreEqual("helloworld.handler", getFunctionConfiguration.Handler);

                // Call the function
                var invokeResponse = lambdaClient.InvokeAsync(functionName);
                Assert.AreEqual(invokeResponse.Status, 202); // Status Code Accepted

            }
            finally
            {
                if(uploaded)
                    lambdaClient.DeleteFunction(functionName);

                if (iamRoleCreated)
                    iamClient.DeleteRole(new DeleteRoleRequest { RoleName = iamRoleName });
            }
        }
#endif
    }
}
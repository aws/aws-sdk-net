using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using System.IO;
using AWSSDK_DotNet35.UnitTests;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Util;
using System.Threading;
using System.Net;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.Util;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Amazon.Redshift;
using ServiceClientGenerator;
using System.Reflection;
using Amazon.S3.Encryption;
using System.Security.Cryptography;

namespace AWSSDK.UnitTests
{
    [TestClass()]
    public class UnparseableResponsesTests
    {
        // This test invokes all methods on most clients, testing how
        // those clients are able to handle incorrect data
        //[TestMethod]
        public void TestAll()
        {
            LoadServices();

            string requestId = null;

            using (new DisableLogging())
            {
                TestAll(requestId);
            }
            TestAll(requestId);

            requestId = "FakeRequestId123";
            using (new DisableLogging())
            {
                TestAll(requestId);
            }
            TestAll(requestId);
        }

        private void TestAll(string requestId)
        {
            TestXmlServices(requestId);
            TestJsonServices(requestId);
        }

        private List<Type> xmlServices = new List<Type>();
        private List<Type> jsonServices = new List<Type>();
        
        private void LoadServices()
        {
            var manifestPath = @"..\..\..\_manifest.json";
            var versionsPath = @"..\..\..\_sdk-versions.json";
            var modelsFolder = @"..\..\..\ServiceModels";
            var compileCustomizations = true;

            if (compileCustomizations) // Compile all servicename.customizations*.json files into one json file in bin
                CustomizationCompiler.CompileServiceCustomizations(modelsFolder);
            var configs = ServiceClientGenerator.GenerationManifest.Load(manifestPath, versionsPath, modelsFolder).ServiceConfigurations.ToList();
            var baseClientType = typeof(AmazonServiceClient);

            foreach(var config in configs)
            {
                var clientTypeName = config.Namespace + ".Amazon" + config.BaseName + "Client";
                var clientType = baseClientType.Assembly.GetType(clientTypeName);
                Assert.IsNotNull(clientType);

                var protocol = config.ServiceModel.Type;
                if (protocol == ServiceClientGenerator.ServiceType.Json ||
                    protocol == ServiceClientGenerator.ServiceType.Rest_Json)
                {
                    jsonServices.Add(clientType);
                }
                else if (protocol == ServiceClientGenerator.ServiceType.Rest_Xml ||
                    protocol == ServiceClientGenerator.ServiceType.Query)
                {
                    xmlServices.Add(clientType);
                }
                else
                    throw new InvalidOperationException();
            }
        }

        private void TestXmlServices(string requestId)
        {
            var clientTypes = xmlServices
                .Except(new Type[] { typeof(Amazon.S3.AmazonS3Client), typeof(Amazon.SQS.AmazonSQSClient) })
                .ToList();

            TestServices(clientTypes, jsonResponse, requestId, isOK: true);
            TestServices(clientTypes, jsonResponse, requestId, isOK: false);
            TestServices(clientTypes, htmlResponse, requestId, isOK: true);
            TestServices(clientTypes, htmlResponse, requestId, isOK: false);
        }
        private void TestJsonServices(string requestId)
        {
            var clientTypes = jsonServices
                .Except(new Type[] { typeof(Amazon.CloudSearchDomain.AmazonCloudSearchDomainClient) })
                .ToList();

            TestServices(clientTypes, xmlResponse, requestId, isOK: true);
            TestServices(clientTypes, xmlResponse, requestId, isOK: false);
            TestServices(clientTypes, htmlResponse, requestId, isOK: true);
            TestServices(clientTypes, htmlResponse, requestId, isOK: false);
        }


        private void TestServices(List<Type> clientTypes, string content, string requestId, bool isOK)
        {
            var baseClientType = typeof(AmazonServiceClient);

            foreach(var clientType in clientTypes)
            {
                Console.WriteLine("Testing client {0}", clientType.FullName);

                var clientObject = InstantiateClient(clientType);
                var client = clientObject as AmazonServiceClient;
                var requestMethods = GetValidRequestMethods(clientType);

                using(client)
                {
                    CustomResponses.SetResponse(client, content, requestId, isOK);

                    foreach (var requestMethod in requestMethods)
                    {
                        TestOperation(clientObject, requestMethod, content, requestId);
                    }
                }
            }
        }
        private static void TestSingle(Type clientType, string methodName, string content, string requestId, bool isOK, object methodInput = null)
        {
            var clientObject = InstantiateClient(clientType);
            var client = clientObject as AmazonServiceClient;

            using (client)
            {
                CustomResponses.SetResponse(client, content, requestId, isOK);

                var requestMethods = GetValidRequestMethods(clientType);
                var requestMethod = requestMethods.First(m => m.Name.Equals(methodName, StringComparison.Ordinal));
                TestOperation(clientObject, requestMethod, content, requestId, methodInput);
            }
        }

        private static List<MethodInfo> GetValidRequestMethods(Type clientType)
        {
            var requestType = typeof(AmazonWebServiceRequest);
            var requestMethods = clientType
                .GetMethods()
                .OrderBy(m => m.Name)
                .Where(m =>
                    m.GetParameters().Length == 1 &&
                    m.GetParameters()[0].ParameterType.IsSubclassOf(requestType))
                .ToList();
            return requestMethods;
        }

        private static void TestOperation(object clientObject, MethodInfo requestMethod, string content, string requestId, object methodInput = null)
        {
            var name = requestMethod.Name;
            Console.WriteLine("Calling {0}", name);

            if (methodInput == null)
            {
                var inputType = requestMethod.GetParameters()[0].ParameterType;
                methodInput = InstantiateClassGenerator.Execute(inputType);
            }

            VerifyAction(content, requestId, () => Invoke(clientObject, requestMethod, methodInput));
        }

        private static void VerifyAction(string content, string requestId, Action action)
        {
            try
            {
                action();
            }
            catch (AmazonUnmarshallingException aue)
            {
                // verify request id is correct. if not present, it is empty string
                Assert.AreEqual(requestId ?? string.Empty, aue.RequestId);
                if (!string.IsNullOrEmpty(requestId))
                    Assert.IsTrue(aue.Message.Contains(requestId));
                Assert.IsTrue(aue.Message.Contains(content));
            }
        }

        private static void Invoke(object clientObject, System.Reflection.MethodInfo requestMethod, object input)
        {
            try
            {
                requestMethod.Invoke(clientObject, new object[] { input });
            }
            catch (System.Reflection.TargetInvocationException tie)
            {
                Assert.IsNotNull(tie);
                Assert.IsNotNull(tie.InnerException);

                var innerException = tie.InnerException;
                PreserveStackTrace(innerException);
                throw innerException;
            }
        }

        private static void PreserveStackTrace(Exception exception)
        {
            var preserveStackTrace = typeof(Exception).GetMethod("InternalPreserveStackTrace",
                BindingFlags.Instance | BindingFlags.NonPublic);
            preserveStackTrace.Invoke(exception, null);
        }

        private static object InstantiateClient(Type clientType)
        {
            object inputObject = RegionEndpoint.USEast1;

            // AmazonCloudSearchDomainClient has no RegionEndpoint constructor, so
            // using its string constructor
            if (clientType == typeof(Amazon.CloudSearchDomain.AmazonCloudSearchDomainClient))
                inputObject = "http://www.amazon.com";

            return Activator.CreateInstance(clientType, inputObject);
        }

        private const string xmlResponse = @"<?xml version=""1.0"" encoding=""utf-8""?>
<bookstore xmlns=""http://www.w3.org/2001/XMLSchema-instance"">
    <book price=""25.50"" publicationdate=""2015-05-19"">
        <title>Seveneves</title>
        <author>
            <first-name>Neal</first-name>
            <last-name>Stephenson</last-name>
        </author>
        <genre>Science fiction</genre>
    </book>
</bookstore>";
        private const string jsonResponse = @"{
	""Books"":
	[
		""Cryptonomicon"", ""Seveneves""
	]
}";
        private const string htmlResponse = @"<!DOCTYPE html>
<html lang=""en-US"" xmlns=""http://www.w3.org/1999/xhtml"">
<head> 
	<meta http-equiv=""content-type"" content=""text/html; charset=UTF-8"" /> 
</head> 
<body> 
	<div>
		<p>Proxy error</p><br>
		<p>Something happened, proxy at fault, whoops.</p>
	</div>
</body>
</html>";
    }
}

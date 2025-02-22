using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using Amazon.Runtime.Internal;
using Amazon.Util;
using AWSSDK_DotNet.CommonTest.Utils;
using AWSSDK_DotNet.UnitTests.TestTools;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// <see cref="MultipleResponseServlet"/> emulating the EC2 Instance Metadata Service.
    /// </summary>
    public class EC2InstanceMetadataServlet : MultipleResponseServlet
    {
        private readonly DisposableSwitch _metadataServiceEndpointSwitch;

        public EC2InstanceMetadataServlet()
        {
            SetupResponseHandler();

            var currentEndpointUrl = Environment.GetEnvironmentVariable("AWS_EC2_METADATA_SERVICE_ENDPOINT");
            _metadataServiceEndpointSwitch =
                new DisposableSwitch(
                    onStart: () => SetEC2InstanceMetadataEndpoint(ServiceURL),
                    onEnd: () => SetEC2InstanceMetadataEndpoint(currentEndpointUrl));
        }

        public override void Dispose()
        {
            _metadataServiceEndpointSwitch.Dispose();
            base.Dispose();
        }

        public Queue<MultipleResponseServlet.Response> Responses { get; } = new Queue<Response>();

        public void AddTokenFetchResponse(string token, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            var headers = new Dictionary<string, string>();
            headers.Add(HeaderKeys.XAwsEc2MetadataTokenTtlSeconds, "21600");
            
            Responses.Enqueue(new MultipleResponseServlet.Response
            {
                Contents = token,
                Headers = headers,
                StatusCode = (int)statusCode
            });
        }

        public void AddMetadataGetSecurityCredentialsResponse(
            IAMSecurityCredentialMetadata metadata,
            string token,
            HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            string contents = JsonSerializer.Serialize(metadata);
            AddMetadataGenericResponse(contents, token, statusCode);
        }

        public void AddMetadataSecurityInfoResponse(IAMInstanceProfileMetadata metadata, string token, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            string contents = JsonSerializer.Serialize(metadata);
            AddMetadataGenericResponse(contents, token, statusCode);
        }

        public void AddMetadataGenericResponse(string contents, string token, HttpStatusCode statusCode)
        {
            var headers = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(token))
            {
                headers.Add(HeaderKeys.XAwsEc2MetadataToken, token);
            }

            Responses.Enqueue(new MultipleResponseServlet.Response
            {
                Contents = contents,
                Headers = headers,
                StatusCode = (int)statusCode
            });
        }

        private void SetupResponseHandler()
        {
            OnRequest += path =>
            {
                if (Responses.Count == 0)
                    Assert.Fail("Number or responses requested exceeds the number of mocked responses.");

                var response = Responses.Dequeue();
                return response;
            };
        }

        private static IDictionary<string, IAMSecurityCredentialMetadata> GetSecurityCredentials(MultipleResponseServlet servlet)
        {
            var currentEMSValue = Environment.GetEnvironmentVariable("AWS_EC2_METADATA_SERVICE_ENDPOINT");

            Action setEMSAction = () => SetEC2InstanceMetadataEndpoint(servlet.ServiceURL);
            Action resetEMSAction = () => SetEC2InstanceMetadataEndpoint(currentEMSValue);

            using (new DisposableSwitch(setEMSAction, resetEMSAction))
            {
                var metadata = EC2InstanceMetadata.IAMSecurityCredentials;
                return metadata;
            }
        }

        private static void SetEC2InstanceMetadataEndpoint(string address)
        {
            Environment.SetEnvironmentVariable("AWS_EC2_METADATA_SERVICE_ENDPOINT", address);
            FallbackInternalConfigurationFactory.Reset();
        }
    }
}
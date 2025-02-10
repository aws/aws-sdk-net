using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using Amazon.Runtime.Internal;
using Amazon.Util;
using AWSSDK_DotNet.CommonTest.Utils;
using AWSSDK_DotNet.UnitTests.TestTools;
using Json.LitJson;
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
            ResetUseNullToken();

            SetupResponseHandler();

            var currentEndpointUrl = Environment.GetEnvironmentVariable("AWS_EC2_METADATA_SERVICE_ENDPOINT");
            _metadataServiceEndpointSwitch =
                new DisposableSwitch(
                    onStart: () => SetEC2InstanceMetadataEndpoint(ServiceURL),
                    onEnd: () => SetEC2InstanceMetadataEndpoint(currentEndpointUrl));

            // JsonMapper.ToJson's DateTime writing exporter will output any date as a string formatted
            // as a local or unspecified time. This changes it so the data is mocked as IMDS would
            // actually return it which is "yyyy-MM-ddTHH:mm:ssZ" ending in a Z specified as UTC.
            JsonMapper.RegisterExporter<DateTime>(
                (DateTime date, JsonWriter writer) => {                     
                    if(date == DateTime.MinValue && date.Kind != DateTimeKind.Utc)
                    {
                        //Do not use .ToUniversalTime on a min datetime as it will adjust the hours.
                        DateTime.SpecifyKind(date, DateTimeKind.Utc);
                    }
                    else if(date.Kind != DateTimeKind.Utc)
                    {
                        date = date.ToUniversalTime();
                    }

                    writer.Write(date.ToString("yyyy-MM-ddTHH:mm:ssZ"));
                }
            );
        }

        public override void Dispose()
        {
            JsonMapper.UnregisterExporters();
            _metadataServiceEndpointSwitch.Dispose();

            ResetUseNullToken();

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
            AddMetadataGenericResponse(JsonMapper.ToJson(metadata), token, statusCode);
        }

        public void AddMetadataSecurityInfoResponse(IAMInstanceProfileMetadata metadata, string token, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            AddMetadataGenericResponse(JsonMapper.ToJson(metadata), token, statusCode);
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

        private static FieldInfo ResetUseNullToken()
        {
            var nullTokenField = 
                typeof(EC2InstanceMetadata)
                    .GetField("useNullToken", BindingFlags.NonPublic | BindingFlags.Static);


            nullTokenField.SetValue(null, false);

            Assert.IsFalse((bool)nullTokenField.GetValue(null));
            return nullTokenField;
        }
    }
}
/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Transfer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.Transfer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateServer Request Marshaller
    /// </summary>       
    public class CreateServerRequestMarshaller : IMarshaller<IRequest, CreateServerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateServerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateServerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Transfer");
            string target = "TransferService.CreateServer";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-05";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCertificate())
            {
                context.Writer.WritePropertyName("Certificate");
                context.Writer.WriteStringValue(publicRequest.Certificate);
            }

            if(publicRequest.IsSetDomain())
            {
                context.Writer.WritePropertyName("Domain");
                context.Writer.WriteStringValue(publicRequest.Domain);
            }

            if(publicRequest.IsSetEndpointDetails())
            {
                context.Writer.WritePropertyName("EndpointDetails");
                context.Writer.WriteStartObject();

                var marshaller = EndpointDetailsMarshaller.Instance;
                marshaller.Marshall(publicRequest.EndpointDetails, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEndpointType())
            {
                context.Writer.WritePropertyName("EndpointType");
                context.Writer.WriteStringValue(publicRequest.EndpointType);
            }

            if(publicRequest.IsSetHostKey())
            {
                context.Writer.WritePropertyName("HostKey");
                context.Writer.WriteStringValue(publicRequest.HostKey);
            }

            if(publicRequest.IsSetIdentityProviderDetails())
            {
                context.Writer.WritePropertyName("IdentityProviderDetails");
                context.Writer.WriteStartObject();

                var marshaller = IdentityProviderDetailsMarshaller.Instance;
                marshaller.Marshall(publicRequest.IdentityProviderDetails, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIdentityProviderType())
            {
                context.Writer.WritePropertyName("IdentityProviderType");
                context.Writer.WriteStringValue(publicRequest.IdentityProviderType);
            }

            if(publicRequest.IsSetIpAddressType())
            {
                context.Writer.WritePropertyName("IpAddressType");
                context.Writer.WriteStringValue(publicRequest.IpAddressType);
            }

            if(publicRequest.IsSetLoggingRole())
            {
                context.Writer.WritePropertyName("LoggingRole");
                context.Writer.WriteStringValue(publicRequest.LoggingRole);
            }

            if(publicRequest.IsSetPostAuthenticationLoginBanner())
            {
                context.Writer.WritePropertyName("PostAuthenticationLoginBanner");
                context.Writer.WriteStringValue(publicRequest.PostAuthenticationLoginBanner);
            }

            if(publicRequest.IsSetPreAuthenticationLoginBanner())
            {
                context.Writer.WritePropertyName("PreAuthenticationLoginBanner");
                context.Writer.WriteStringValue(publicRequest.PreAuthenticationLoginBanner);
            }

            if(publicRequest.IsSetProtocolDetails())
            {
                context.Writer.WritePropertyName("ProtocolDetails");
                context.Writer.WriteStartObject();

                var marshaller = ProtocolDetailsMarshaller.Instance;
                marshaller.Marshall(publicRequest.ProtocolDetails, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetProtocols())
            {
                context.Writer.WritePropertyName("Protocols");
                context.Writer.WriteStartArray();
                foreach(var publicRequestProtocolsListValue in publicRequest.Protocols)
                {
                        context.Writer.WriteStringValue(publicRequestProtocolsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetS3StorageOptions())
            {
                context.Writer.WritePropertyName("S3StorageOptions");
                context.Writer.WriteStartObject();

                var marshaller = S3StorageOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.S3StorageOptions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSecurityPolicyName())
            {
                context.Writer.WritePropertyName("SecurityPolicyName");
                context.Writer.WriteStringValue(publicRequest.SecurityPolicyName);
            }

            if(publicRequest.IsSetStructuredLogDestinations())
            {
                context.Writer.WritePropertyName("StructuredLogDestinations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestStructuredLogDestinationsListValue in publicRequest.StructuredLogDestinations)
                {
                        context.Writer.WriteStringValue(publicRequestStructuredLogDestinationsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetWorkflowDetails())
            {
                context.Writer.WritePropertyName("WorkflowDetails");
                context.Writer.WriteStartObject();

                var marshaller = WorkflowDetailsMarshaller.Instance;
                marshaller.Marshall(publicRequest.WorkflowDetails, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateServerRequestMarshaller _instance = new CreateServerRequestMarshaller();        

        internal static CreateServerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateServerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
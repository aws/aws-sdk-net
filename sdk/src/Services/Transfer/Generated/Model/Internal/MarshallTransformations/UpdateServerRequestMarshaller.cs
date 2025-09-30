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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Transfer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateServer Request Marshaller
    /// </summary>       
    public class UpdateServerRequestMarshaller : IMarshaller<IRequest, UpdateServerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateServerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateServerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Transfer");
            string target = "TransferService.UpdateServer";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-05";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCertificate())
                {
                    context.Writer.WritePropertyName("Certificate");
                    context.Writer.Write(publicRequest.Certificate);
                }

                if(publicRequest.IsSetEndpointDetails())
                {
                    context.Writer.WritePropertyName("EndpointDetails");
                    context.Writer.WriteObjectStart();

                    var marshaller = EndpointDetailsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EndpointDetails, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEndpointType())
                {
                    context.Writer.WritePropertyName("EndpointType");
                    context.Writer.Write(publicRequest.EndpointType);
                }

                if(publicRequest.IsSetHostKey())
                {
                    context.Writer.WritePropertyName("HostKey");
                    context.Writer.Write(publicRequest.HostKey);
                }

                if(publicRequest.IsSetIdentityProviderDetails())
                {
                    context.Writer.WritePropertyName("IdentityProviderDetails");
                    context.Writer.WriteObjectStart();

                    var marshaller = IdentityProviderDetailsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.IdentityProviderDetails, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIdentityProviderType())
                {
                    context.Writer.WritePropertyName("IdentityProviderType");
                    context.Writer.Write(publicRequest.IdentityProviderType);
                }

                if(publicRequest.IsSetIpAddressType())
                {
                    context.Writer.WritePropertyName("IpAddressType");
                    context.Writer.Write(publicRequest.IpAddressType);
                }

                if(publicRequest.IsSetLoggingRole())
                {
                    context.Writer.WritePropertyName("LoggingRole");
                    context.Writer.Write(publicRequest.LoggingRole);
                }

                if(publicRequest.IsSetPostAuthenticationLoginBanner())
                {
                    context.Writer.WritePropertyName("PostAuthenticationLoginBanner");
                    context.Writer.Write(publicRequest.PostAuthenticationLoginBanner);
                }

                if(publicRequest.IsSetPreAuthenticationLoginBanner())
                {
                    context.Writer.WritePropertyName("PreAuthenticationLoginBanner");
                    context.Writer.Write(publicRequest.PreAuthenticationLoginBanner);
                }

                if(publicRequest.IsSetProtocolDetails())
                {
                    context.Writer.WritePropertyName("ProtocolDetails");
                    context.Writer.WriteObjectStart();

                    var marshaller = ProtocolDetailsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ProtocolDetails, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetProtocols())
                {
                    context.Writer.WritePropertyName("Protocols");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestProtocolsListValue in publicRequest.Protocols)
                    {
                            context.Writer.Write(publicRequestProtocolsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetS3StorageOptions())
                {
                    context.Writer.WritePropertyName("S3StorageOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = S3StorageOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.S3StorageOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSecurityPolicyName())
                {
                    context.Writer.WritePropertyName("SecurityPolicyName");
                    context.Writer.Write(publicRequest.SecurityPolicyName);
                }

                if(publicRequest.IsSetServerId())
                {
                    context.Writer.WritePropertyName("ServerId");
                    context.Writer.Write(publicRequest.ServerId);
                }

                if(publicRequest.IsSetStructuredLogDestinations())
                {
                    context.Writer.WritePropertyName("StructuredLogDestinations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestStructuredLogDestinationsListValue in publicRequest.StructuredLogDestinations)
                    {
                            context.Writer.Write(publicRequestStructuredLogDestinationsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetWorkflowDetails())
                {
                    context.Writer.WritePropertyName("WorkflowDetails");
                    context.Writer.WriteObjectStart();

                    var marshaller = WorkflowDetailsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.WorkflowDetails, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateServerRequestMarshaller _instance = new UpdateServerRequestMarshaller();        

        internal static UpdateServerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateServerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
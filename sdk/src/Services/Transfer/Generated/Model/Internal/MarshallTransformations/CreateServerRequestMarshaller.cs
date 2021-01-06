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
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCertificate())
                {
                    context.Writer.WritePropertyName("Certificate");
                    context.Writer.Write(publicRequest.Certificate);
                }

                if(publicRequest.IsSetDomain())
                {
                    context.Writer.WritePropertyName("Domain");
                    context.Writer.Write(publicRequest.Domain);
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

                if(publicRequest.IsSetLoggingRole())
                {
                    context.Writer.WritePropertyName("LoggingRole");
                    context.Writer.Write(publicRequest.LoggingRole);
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

                if(publicRequest.IsSetSecurityPolicyName())
                {
                    context.Writer.WritePropertyName("SecurityPolicyName");
                    context.Writer.Write(publicRequest.SecurityPolicyName);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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
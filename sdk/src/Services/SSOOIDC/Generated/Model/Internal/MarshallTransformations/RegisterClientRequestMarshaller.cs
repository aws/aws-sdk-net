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
 * Do not modify this file. This file is generated from the sso-oidc-2019-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSOOIDC.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#pragma warning disable CS0612,CS0618
namespace Amazon.SSOOIDC.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RegisterClient Request Marshaller
    /// </summary>       
    public class RegisterClientRequestMarshaller : IMarshaller<IRequest, RegisterClientRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterClientRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterClientRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SSOOIDC");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-06-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/client/register";
#if NETCOREAPP3_1_OR_GREATER
            ArrayBufferWriter<byte> arrayBufferWriter = new ArrayBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientName())
            {
                context.Writer.WritePropertyName("clientName");
                context.Writer.WriteStringValue(publicRequest.ClientName);
            }

            if(publicRequest.IsSetClientType())
            {
                context.Writer.WritePropertyName("clientType");
                context.Writer.WriteStringValue(publicRequest.ClientType);
            }

            if(publicRequest.IsSetEntitledApplicationArn())
            {
                context.Writer.WritePropertyName("entitledApplicationArn");
                context.Writer.WriteStringValue(publicRequest.EntitledApplicationArn);
            }

            if(publicRequest.IsSetGrantTypes())
            {
                context.Writer.WritePropertyName("grantTypes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestGrantTypesListValue in publicRequest.GrantTypes)
                {
                        context.Writer.WriteStringValue(publicRequestGrantTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetIssuerUrl())
            {
                context.Writer.WritePropertyName("issuerUrl");
                context.Writer.WriteStringValue(publicRequest.IssuerUrl);
            }

            if(publicRequest.IsSetRedirectUris())
            {
                context.Writer.WritePropertyName("redirectUris");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRedirectUrisListValue in publicRequest.RedirectUris)
                {
                        context.Writer.WriteStringValue(publicRequestRedirectUrisListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetScopes())
            {
                context.Writer.WritePropertyName("scopes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestScopesListValue in publicRequest.Scopes)
                {
                        context.Writer.WriteStringValue(publicRequestScopesListValue);
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETCOREAPP3_1_OR_GREATER
            request.Content = arrayBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static RegisterClientRequestMarshaller _instance = new RegisterClientRequestMarshaller();        

        internal static RegisterClientRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterClientRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
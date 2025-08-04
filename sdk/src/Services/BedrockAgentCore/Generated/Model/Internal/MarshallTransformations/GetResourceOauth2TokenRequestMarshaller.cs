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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCore.Model;
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
namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetResourceOauth2Token Request Marshaller
    /// </summary>       
    public class GetResourceOauth2TokenRequestMarshaller : IMarshaller<IRequest, GetResourceOauth2TokenRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetResourceOauth2TokenRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetResourceOauth2TokenRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCore");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-02-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/identities/oauth2/token";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCustomParameters())
            {
                context.Writer.WritePropertyName("customParameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestCustomParametersKvp in publicRequest.CustomParameters)
                {
                    context.Writer.WritePropertyName(publicRequestCustomParametersKvp.Key);
                    var publicRequestCustomParametersValue = publicRequestCustomParametersKvp.Value;

                        context.Writer.WriteStringValue(publicRequestCustomParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetForceAuthentication())
            {
                context.Writer.WritePropertyName("forceAuthentication");
                context.Writer.WriteBooleanValue(publicRequest.ForceAuthentication.Value);
            }

            if(publicRequest.IsSetOauth2Flow())
            {
                context.Writer.WritePropertyName("oauth2Flow");
                context.Writer.WriteStringValue(publicRequest.Oauth2Flow);
            }

            if(publicRequest.IsSetResourceCredentialProviderName())
            {
                context.Writer.WritePropertyName("resourceCredentialProviderName");
                context.Writer.WriteStringValue(publicRequest.ResourceCredentialProviderName);
            }

            if(publicRequest.IsSetResourceOauth2ReturnUrl())
            {
                context.Writer.WritePropertyName("resourceOauth2ReturnUrl");
                context.Writer.WriteStringValue(publicRequest.ResourceOauth2ReturnUrl);
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

            if(publicRequest.IsSetWorkloadIdentityToken())
            {
                context.Writer.WritePropertyName("workloadIdentityToken");
                context.Writer.WriteStringValue(publicRequest.WorkloadIdentityToken);
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
        private static GetResourceOauth2TokenRequestMarshaller _instance = new GetResourceOauth2TokenRequestMarshaller();        

        internal static GetResourceOauth2TokenRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetResourceOauth2TokenRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
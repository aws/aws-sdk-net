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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.APIGateway.Model;
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
namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAuthorizer Request Marshaller
    /// </summary>       
    public class CreateAuthorizerRequestMarshaller : IMarshaller<IRequest, CreateAuthorizerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAuthorizerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAuthorizerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.APIGateway");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-07-09";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetRestApiId())
                throw new AmazonAPIGatewayException("Request object does not have required field RestApiId set");
            request.AddPathResource("{restapi_id}", StringUtils.FromString(publicRequest.RestApiId));
            request.ResourcePath = "/restapis/{restapi_id}/authorizers";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAuthorizerCredentials())
            {
                context.Writer.WritePropertyName("authorizerCredentials");
                context.Writer.WriteStringValue(publicRequest.AuthorizerCredentials);
            }

            if(publicRequest.IsSetAuthorizerResultTtlInSeconds())
            {
                context.Writer.WritePropertyName("authorizerResultTtlInSeconds");
                context.Writer.WriteNumberValue(publicRequest.AuthorizerResultTtlInSeconds.Value);
            }

            if(publicRequest.IsSetAuthorizerUri())
            {
                context.Writer.WritePropertyName("authorizerUri");
                context.Writer.WriteStringValue(publicRequest.AuthorizerUri);
            }

            if(publicRequest.IsSetAuthType())
            {
                context.Writer.WritePropertyName("authType");
                context.Writer.WriteStringValue(publicRequest.AuthType);
            }

            if(publicRequest.IsSetIdentitySource())
            {
                context.Writer.WritePropertyName("identitySource");
                context.Writer.WriteStringValue(publicRequest.IdentitySource);
            }

            if(publicRequest.IsSetIdentityValidationExpression())
            {
                context.Writer.WritePropertyName("identityValidationExpression");
                context.Writer.WriteStringValue(publicRequest.IdentityValidationExpression);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetProviderARNs())
            {
                context.Writer.WritePropertyName("providerARNs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestProviderARNsListValue in publicRequest.ProviderARNs)
                {
                        context.Writer.WriteStringValue(publicRequestProviderARNsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(publicRequest.Type);
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
        private static CreateAuthorizerRequestMarshaller _instance = new CreateAuthorizerRequestMarshaller();        

        internal static CreateAuthorizerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAuthorizerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
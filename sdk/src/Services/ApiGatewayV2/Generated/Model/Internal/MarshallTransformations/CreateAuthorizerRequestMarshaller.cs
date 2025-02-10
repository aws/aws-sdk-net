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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApiGatewayV2.Model;
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
namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
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
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApiGatewayV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-29";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetApiId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field ApiId set");
            request.AddPathResource("{apiId}", StringUtils.FromString(publicRequest.ApiId));
            request.ResourcePath = "/v2/apis/{apiId}/authorizers";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAuthorizerCredentialsArn())
            {
                context.Writer.WritePropertyName("authorizerCredentialsArn");
                context.Writer.WriteStringValue(publicRequest.AuthorizerCredentialsArn);
            }

            if(publicRequest.IsSetAuthorizerPayloadFormatVersion())
            {
                context.Writer.WritePropertyName("authorizerPayloadFormatVersion");
                context.Writer.WriteStringValue(publicRequest.AuthorizerPayloadFormatVersion);
            }

            if(publicRequest.IsSetAuthorizerResultTtlInSeconds())
            {
                context.Writer.WritePropertyName("authorizerResultTtlInSeconds");
                context.Writer.WriteNumberValue(publicRequest.AuthorizerResultTtlInSeconds.Value);
            }

            if(publicRequest.IsSetAuthorizerType())
            {
                context.Writer.WritePropertyName("authorizerType");
                context.Writer.WriteStringValue(publicRequest.AuthorizerType);
            }

            if(publicRequest.IsSetAuthorizerUri())
            {
                context.Writer.WritePropertyName("authorizerUri");
                context.Writer.WriteStringValue(publicRequest.AuthorizerUri);
            }

            if(publicRequest.IsSetEnableSimpleResponses())
            {
                context.Writer.WritePropertyName("enableSimpleResponses");
                context.Writer.WriteBooleanValue(publicRequest.EnableSimpleResponses.Value);
            }

            if(publicRequest.IsSetIdentitySource())
            {
                context.Writer.WritePropertyName("identitySource");
                context.Writer.WriteStartArray();
                foreach(var publicRequestIdentitySourceListValue in publicRequest.IdentitySource)
                {
                        context.Writer.WriteStringValue(publicRequestIdentitySourceListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetIdentityValidationExpression())
            {
                context.Writer.WritePropertyName("identityValidationExpression");
                context.Writer.WriteStringValue(publicRequest.IdentityValidationExpression);
            }

            if(publicRequest.IsSetJwtConfiguration())
            {
                context.Writer.WritePropertyName("jwtConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = JWTConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.JwtConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
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
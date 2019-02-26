/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAuthorizer Request Marshaller
    /// </summary>       
    public class UpdateAuthorizerRequestMarshaller : IMarshaller<IRequest, UpdateAuthorizerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAuthorizerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAuthorizerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApiGatewayV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-29";            
            request.HttpMethod = "PATCH";

            string uriResourcePath = "/v2/apis/{apiId}/authorizers/{authorizerId}";
            if (!publicRequest.IsSetApiId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field ApiId set");
            uriResourcePath = uriResourcePath.Replace("{apiId}", StringUtils.FromStringWithSlashEncoding(publicRequest.ApiId));
            if (!publicRequest.IsSetAuthorizerId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field AuthorizerId set");
            uriResourcePath = uriResourcePath.Replace("{authorizerId}", StringUtils.FromStringWithSlashEncoding(publicRequest.AuthorizerId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuthorizerCredentialsArn())
                {
                    context.Writer.WritePropertyName("authorizerCredentialsArn");
                    context.Writer.Write(publicRequest.AuthorizerCredentialsArn);
                }

                if(publicRequest.IsSetAuthorizerResultTtlInSeconds())
                {
                    context.Writer.WritePropertyName("authorizerResultTtlInSeconds");
                    context.Writer.Write(publicRequest.AuthorizerResultTtlInSeconds);
                }

                if(publicRequest.IsSetAuthorizerType())
                {
                    context.Writer.WritePropertyName("authorizerType");
                    context.Writer.Write(publicRequest.AuthorizerType);
                }

                if(publicRequest.IsSetAuthorizerUri())
                {
                    context.Writer.WritePropertyName("authorizerUri");
                    context.Writer.Write(publicRequest.AuthorizerUri);
                }

                if(publicRequest.IsSetIdentitySource())
                {
                    context.Writer.WritePropertyName("identitySource");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestIdentitySourceListValue in publicRequest.IdentitySource)
                    {
                            context.Writer.Write(publicRequestIdentitySourceListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetIdentityValidationExpression())
                {
                    context.Writer.WritePropertyName("identityValidationExpression");
                    context.Writer.Write(publicRequest.IdentityValidationExpression);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetProviderArns())
                {
                    context.Writer.WritePropertyName("providerArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestProviderArnsListValue in publicRequest.ProviderArns)
                    {
                            context.Writer.Write(publicRequestProviderArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateAuthorizerRequestMarshaller _instance = new UpdateAuthorizerRequestMarshaller();        

        internal static UpdateAuthorizerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAuthorizerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
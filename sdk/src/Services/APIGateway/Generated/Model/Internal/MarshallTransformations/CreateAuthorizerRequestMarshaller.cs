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
using ThirdParty.Json.LitJson;

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
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "POST";

            string uriResourcePath = "/restapis/{restapi_id}/authorizers";
            if (!publicRequest.IsSetRestApiId())
                throw new AmazonAPIGatewayException("Request object does not have required field RestApiId set");
            uriResourcePath = uriResourcePath.Replace("{restapi_id}", StringUtils.FromString(publicRequest.RestApiId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuthorizerCredentials())
                {
                    context.Writer.WritePropertyName("authorizerCredentials");
                    context.Writer.Write(publicRequest.AuthorizerCredentials);
                }

                if(publicRequest.IsSetAuthorizerResultTtlInSeconds())
                {
                    context.Writer.WritePropertyName("authorizerResultTtlInSeconds");
                    context.Writer.Write(publicRequest.AuthorizerResultTtlInSeconds);
                }

                if(publicRequest.IsSetAuthorizerUri())
                {
                    context.Writer.WritePropertyName("authorizerUri");
                    context.Writer.Write(publicRequest.AuthorizerUri);
                }

                if(publicRequest.IsSetAuthType())
                {
                    context.Writer.WritePropertyName("authType");
                    context.Writer.Write(publicRequest.AuthType);
                }

                if(publicRequest.IsSetIdentitySource())
                {
                    context.Writer.WritePropertyName("identitySource");
                    context.Writer.Write(publicRequest.IdentitySource);
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

                if(publicRequest.IsSetProviderARNs())
                {
                    context.Writer.WritePropertyName("providerARNs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestProviderARNsListValue in publicRequest.ProviderARNs)
                    {
                            context.Writer.Write(publicRequestProviderARNsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetType())
                {
                    context.Writer.WritePropertyName("type");
                    context.Writer.Write(publicRequest.Type);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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
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
    /// TestInvokeAuthorizer Request Marshaller
    /// </summary>       
    public class TestInvokeAuthorizerRequestMarshaller : IMarshaller<IRequest, TestInvokeAuthorizerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((TestInvokeAuthorizerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(TestInvokeAuthorizerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.APIGateway");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "POST";

            string uriResourcePath = "/restapis/{restapi_id}/authorizers/{authorizer_id}";
            if (!publicRequest.IsSetAuthorizerId())
                throw new AmazonAPIGatewayException("Request object does not have required field AuthorizerId set");
            uriResourcePath = uriResourcePath.Replace("{authorizer_id}", StringUtils.FromString(publicRequest.AuthorizerId));
            if (!publicRequest.IsSetRestApiId())
                throw new AmazonAPIGatewayException("Request object does not have required field RestApiId set");
            uriResourcePath = uriResourcePath.Replace("{restapi_id}", StringUtils.FromString(publicRequest.RestApiId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdditionalContext())
                {
                    context.Writer.WritePropertyName("additionalContext");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAdditionalContextKvp in publicRequest.AdditionalContext)
                    {
                        context.Writer.WritePropertyName(publicRequestAdditionalContextKvp.Key);
                        var publicRequestAdditionalContextValue = publicRequestAdditionalContextKvp.Value;

                            context.Writer.Write(publicRequestAdditionalContextValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetBody())
                {
                    context.Writer.WritePropertyName("body");
                    context.Writer.Write(publicRequest.Body);
                }

                if(publicRequest.IsSetHeaders())
                {
                    context.Writer.WritePropertyName("headers");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestHeadersKvp in publicRequest.Headers)
                    {
                        context.Writer.WritePropertyName(publicRequestHeadersKvp.Key);
                        var publicRequestHeadersValue = publicRequestHeadersKvp.Value;

                            context.Writer.Write(publicRequestHeadersValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPathWithQueryString())
                {
                    context.Writer.WritePropertyName("pathWithQueryString");
                    context.Writer.Write(publicRequest.PathWithQueryString);
                }

                if(publicRequest.IsSetStageVariables())
                {
                    context.Writer.WritePropertyName("stageVariables");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestStageVariablesKvp in publicRequest.StageVariables)
                    {
                        context.Writer.WritePropertyName(publicRequestStageVariablesKvp.Key);
                        var publicRequestStageVariablesValue = publicRequestStageVariablesKvp.Value;

                            context.Writer.Write(publicRequestStageVariablesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static TestInvokeAuthorizerRequestMarshaller _instance = new TestInvokeAuthorizerRequestMarshaller();        

        internal static TestInvokeAuthorizerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TestInvokeAuthorizerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
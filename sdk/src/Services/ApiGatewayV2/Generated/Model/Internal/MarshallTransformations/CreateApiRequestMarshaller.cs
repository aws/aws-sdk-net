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
using ThirdParty.Json.LitJson;

namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateApi Request Marshaller
    /// </summary>       
    public class CreateApiRequestMarshaller : IMarshaller<IRequest, CreateApiRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateApiRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateApiRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApiGatewayV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-29";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/v2/apis";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApiKeySelectionExpression())
                {
                    context.Writer.WritePropertyName("apiKeySelectionExpression");
                    context.Writer.Write(publicRequest.ApiKeySelectionExpression);
                }

                if(publicRequest.IsSetCorsConfiguration())
                {
                    context.Writer.WritePropertyName("corsConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = CorsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CorsConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCredentialsArn())
                {
                    context.Writer.WritePropertyName("credentialsArn");
                    context.Writer.Write(publicRequest.CredentialsArn);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDisableExecuteApiEndpoint())
                {
                    context.Writer.WritePropertyName("disableExecuteApiEndpoint");
                    context.Writer.Write(publicRequest.DisableExecuteApiEndpoint);
                }

                if(publicRequest.IsSetDisableSchemaValidation())
                {
                    context.Writer.WritePropertyName("disableSchemaValidation");
                    context.Writer.Write(publicRequest.DisableSchemaValidation);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetProtocolType())
                {
                    context.Writer.WritePropertyName("protocolType");
                    context.Writer.Write(publicRequest.ProtocolType);
                }

                if(publicRequest.IsSetRouteKey())
                {
                    context.Writer.WritePropertyName("routeKey");
                    context.Writer.Write(publicRequest.RouteKey);
                }

                if(publicRequest.IsSetRouteSelectionExpression())
                {
                    context.Writer.WritePropertyName("routeSelectionExpression");
                    context.Writer.Write(publicRequest.RouteSelectionExpression);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTarget())
                {
                    context.Writer.WritePropertyName("target");
                    context.Writer.Write(publicRequest.Target);
                }

                if(publicRequest.IsSetVersion())
                {
                    context.Writer.WritePropertyName("version");
                    context.Writer.Write(publicRequest.Version);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateApiRequestMarshaller _instance = new CreateApiRequestMarshaller();        

        internal static CreateApiRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateApiRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
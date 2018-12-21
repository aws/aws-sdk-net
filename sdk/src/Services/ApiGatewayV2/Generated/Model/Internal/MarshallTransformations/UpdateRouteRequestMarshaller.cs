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
    /// UpdateRoute Request Marshaller
    /// </summary>       
    public class UpdateRouteRequestMarshaller : IMarshaller<IRequest, UpdateRouteRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateRouteRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateRouteRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApiGatewayV2");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-29";            
            request.HttpMethod = "PATCH";

            string uriResourcePath = "/v2/apis/{apiId}/routes/{routeId}";
            if (!publicRequest.IsSetApiId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field ApiId set");
            uriResourcePath = uriResourcePath.Replace("{apiId}", StringUtils.FromStringWithSlashEncoding(publicRequest.ApiId));
            if (!publicRequest.IsSetRouteId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field RouteId set");
            uriResourcePath = uriResourcePath.Replace("{routeId}", StringUtils.FromStringWithSlashEncoding(publicRequest.RouteId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApiKeyRequired())
                {
                    context.Writer.WritePropertyName("apiKeyRequired");
                    context.Writer.Write(publicRequest.ApiKeyRequired);
                }

                if(publicRequest.IsSetAuthorizationScopes())
                {
                    context.Writer.WritePropertyName("authorizationScopes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAuthorizationScopesListValue in publicRequest.AuthorizationScopes)
                    {
                            context.Writer.Write(publicRequestAuthorizationScopesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAuthorizationType())
                {
                    context.Writer.WritePropertyName("authorizationType");
                    context.Writer.Write(publicRequest.AuthorizationType);
                }

                if(publicRequest.IsSetAuthorizerId())
                {
                    context.Writer.WritePropertyName("authorizerId");
                    context.Writer.Write(publicRequest.AuthorizerId);
                }

                if(publicRequest.IsSetModelSelectionExpression())
                {
                    context.Writer.WritePropertyName("modelSelectionExpression");
                    context.Writer.Write(publicRequest.ModelSelectionExpression);
                }

                if(publicRequest.IsSetOperationName())
                {
                    context.Writer.WritePropertyName("operationName");
                    context.Writer.Write(publicRequest.OperationName);
                }

                if(publicRequest.IsSetRequestModels())
                {
                    context.Writer.WritePropertyName("requestModels");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestRequestModelsKvp in publicRequest.RequestModels)
                    {
                        context.Writer.WritePropertyName(publicRequestRequestModelsKvp.Key);
                        var publicRequestRequestModelsValue = publicRequestRequestModelsKvp.Value;

                            context.Writer.Write(publicRequestRequestModelsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRequestParameters())
                {
                    context.Writer.WritePropertyName("requestParameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestRequestParametersKvp in publicRequest.RequestParameters)
                    {
                        context.Writer.WritePropertyName(publicRequestRequestParametersKvp.Key);
                        var publicRequestRequestParametersValue = publicRequestRequestParametersKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = ParameterConstraintsMarshaller.Instance;
                        marshaller.Marshall(publicRequestRequestParametersValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRouteKey())
                {
                    context.Writer.WritePropertyName("routeKey");
                    context.Writer.Write(publicRequest.RouteKey);
                }

                if(publicRequest.IsSetRouteResponseSelectionExpression())
                {
                    context.Writer.WritePropertyName("routeResponseSelectionExpression");
                    context.Writer.Write(publicRequest.RouteResponseSelectionExpression);
                }

                if(publicRequest.IsSetTarget())
                {
                    context.Writer.WritePropertyName("target");
                    context.Writer.Write(publicRequest.Target);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateRouteRequestMarshaller _instance = new UpdateRouteRequestMarshaller();        

        internal static UpdateRouteRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateRouteRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
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
    /// CreateRouteResponse Request Marshaller
    /// </summary>       
    public class CreateRouteResponseRequestMarshaller : IMarshaller<IRequest, CreateRouteResponseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateRouteResponseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateRouteResponseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApiGatewayV2");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-29";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/v2/apis/{apiId}/routes/{routeId}/routeresponses";
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
                if(publicRequest.IsSetModelSelectionExpression())
                {
                    context.Writer.WritePropertyName("modelSelectionExpression");
                    context.Writer.Write(publicRequest.ModelSelectionExpression);
                }

                if(publicRequest.IsSetResponseModels())
                {
                    context.Writer.WritePropertyName("responseModels");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestResponseModelsKvp in publicRequest.ResponseModels)
                    {
                        context.Writer.WritePropertyName(publicRequestResponseModelsKvp.Key);
                        var publicRequestResponseModelsValue = publicRequestResponseModelsKvp.Value;

                            context.Writer.Write(publicRequestResponseModelsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetResponseParameters())
                {
                    context.Writer.WritePropertyName("responseParameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestResponseParametersKvp in publicRequest.ResponseParameters)
                    {
                        context.Writer.WritePropertyName(publicRequestResponseParametersKvp.Key);
                        var publicRequestResponseParametersValue = publicRequestResponseParametersKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = ParameterConstraintsMarshaller.Instance;
                        marshaller.Marshall(publicRequestResponseParametersValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRouteResponseKey())
                {
                    context.Writer.WritePropertyName("routeResponseKey");
                    context.Writer.Write(publicRequest.RouteResponseKey);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateRouteResponseRequestMarshaller _instance = new CreateRouteResponseRequestMarshaller();        

        internal static CreateRouteResponseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateRouteResponseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
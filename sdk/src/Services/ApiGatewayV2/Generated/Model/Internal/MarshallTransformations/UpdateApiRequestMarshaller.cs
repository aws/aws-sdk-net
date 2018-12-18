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
    /// UpdateApi Request Marshaller
    /// </summary>       
    public class UpdateApiRequestMarshaller : IMarshaller<IRequest, UpdateApiRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateApiRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateApiRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApiGatewayV2");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "PATCH";

            string uriResourcePath = "/v2/apis/{apiId}";
            if (!publicRequest.IsSetApiId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field ApiId set");
            uriResourcePath = uriResourcePath.Replace("{apiId}", StringUtils.FromStringWithSlashEncoding(publicRequest.ApiId));
            request.ResourcePath = uriResourcePath;
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

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
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

                if(publicRequest.IsSetRouteSelectionExpression())
                {
                    context.Writer.WritePropertyName("routeSelectionExpression");
                    context.Writer.Write(publicRequest.RouteSelectionExpression);
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
        private static UpdateApiRequestMarshaller _instance = new UpdateApiRequestMarshaller();        

        internal static UpdateApiRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateApiRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
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
    /// UpdateApiMapping Request Marshaller
    /// </summary>       
    public class UpdateApiMappingRequestMarshaller : IMarshaller<IRequest, UpdateApiMappingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateApiMappingRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateApiMappingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApiGatewayV2");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "PATCH";

            string uriResourcePath = "/v2/domainnames/{domainName}/apimappings/{apiMappingId}";
            if (!publicRequest.IsSetApiMappingId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field ApiMappingId set");
            uriResourcePath = uriResourcePath.Replace("{apiMappingId}", StringUtils.FromStringWithSlashEncoding(publicRequest.ApiMappingId));
            if (!publicRequest.IsSetDomainName())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field DomainName set");
            uriResourcePath = uriResourcePath.Replace("{domainName}", StringUtils.FromStringWithSlashEncoding(publicRequest.DomainName));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApiId())
                {
                    context.Writer.WritePropertyName("apiId");
                    context.Writer.Write(publicRequest.ApiId);
                }

                if(publicRequest.IsSetApiMappingKey())
                {
                    context.Writer.WritePropertyName("apiMappingKey");
                    context.Writer.Write(publicRequest.ApiMappingKey);
                }

                if(publicRequest.IsSetStage())
                {
                    context.Writer.WritePropertyName("stage");
                    context.Writer.Write(publicRequest.Stage);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateApiMappingRequestMarshaller _instance = new UpdateApiMappingRequestMarshaller();        

        internal static UpdateApiMappingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateApiMappingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
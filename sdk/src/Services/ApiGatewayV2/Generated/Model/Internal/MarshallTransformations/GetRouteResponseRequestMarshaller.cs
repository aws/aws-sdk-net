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
    /// GetRouteResponse Request Marshaller
    /// </summary>       
    public class GetRouteResponseRequestMarshaller : IMarshaller<IRequest, GetRouteResponseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetRouteResponseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetRouteResponseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApiGatewayV2");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-29";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetApiId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field ApiId set");
            request.AddPathResource("{apiId}", StringUtils.FromString(publicRequest.ApiId));
            if (!publicRequest.IsSetRouteId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field RouteId set");
            request.AddPathResource("{routeId}", StringUtils.FromString(publicRequest.RouteId));
            if (!publicRequest.IsSetRouteResponseId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field RouteResponseId set");
            request.AddPathResource("{routeResponseId}", StringUtils.FromString(publicRequest.RouteResponseId));
            request.ResourcePath = "/v2/apis/{apiId}/routes/{routeId}/routeresponses/{routeResponseId}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static GetRouteResponseRequestMarshaller _instance = new GetRouteResponseRequestMarshaller();        

        internal static GetRouteResponseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetRouteResponseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
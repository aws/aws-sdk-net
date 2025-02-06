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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetSdk Request Marshaller
    /// </summary>       
    public class GetSdkRequestMarshaller : IMarshaller<IRequest, GetSdkRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSdkRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetSdkRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.APIGateway");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-07-09";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetRestApiId())
                throw new AmazonAPIGatewayException("Request object does not have required field RestApiId set");
            request.AddPathResource("{restapi_id}", StringUtils.FromString(publicRequest.RestApiId));
            if (!publicRequest.IsSetSdkType())
                throw new AmazonAPIGatewayException("Request object does not have required field SdkType set");
            request.AddPathResource("{sdk_type}", StringUtils.FromString(publicRequest.SdkType));
            if (!publicRequest.IsSetStageName())
                throw new AmazonAPIGatewayException("Request object does not have required field StageName set");
            request.AddPathResource("{stage_name}", StringUtils.FromString(publicRequest.StageName));
            if (publicRequest.IsSetParameters())
            {
                foreach(var kvp in publicRequest.Parameters)
                {
                    if(request.Parameters.ContainsKey(kvp.Key))
                       continue;
                    else
                       request.Parameters.Add(kvp.Key, StringUtils.FromString(kvp.Value));
                }
            }
            request.ResourcePath = "/restapis/{restapi_id}/stages/{stage_name}/sdks/{sdk_type}";
            request.UseQueryString = true;

            return request;
        }
        private static GetSdkRequestMarshaller _instance = new GetSdkRequestMarshaller();        

        internal static GetSdkRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetSdkRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
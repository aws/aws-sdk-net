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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetConnectionGroupByRoutingEndpoint Request Marshaller
    /// </summary>       
    public class GetConnectionGroupByRoutingEndpointRequestMarshaller : IMarshaller<IRequest, GetConnectionGroupByRoutingEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetConnectionGroupByRoutingEndpointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetConnectionGroupByRoutingEndpointRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "GET";
            
            if (publicRequest.IsSetRoutingEndpoint())
                request.Parameters.Add("RoutingEndpoint", StringUtils.FromString(publicRequest.RoutingEndpoint));
            request.ResourcePath = "/2020-05-31/connection-group";


            request.UseQueryString = true;
            return request;
        }
        private static GetConnectionGroupByRoutingEndpointRequestMarshaller _instance = new GetConnectionGroupByRoutingEndpointRequestMarshaller();        

        internal static GetConnectionGroupByRoutingEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetConnectionGroupByRoutingEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}
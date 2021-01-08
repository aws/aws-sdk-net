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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListTrafficPolicyVersions Request Marshaller
    /// </summary>       
    public class ListTrafficPolicyVersionsRequestMarshaller : IMarshaller<IRequest, ListTrafficPolicyVersionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListTrafficPolicyVersionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListTrafficPolicyVersionsRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.Route53");
            request.HttpMethod = "GET";
            if (!publicRequest.IsSetId())
                throw new AmazonRoute53Exception("Request object does not have required field Id set");
            request.AddPathResource("{Id}", StringUtils.FromString(publicRequest.Id));
            
            if (publicRequest.IsSetTrafficPolicyVersionMarker())
                request.Parameters.Add("trafficpolicyversion", StringUtils.FromString(publicRequest.TrafficPolicyVersionMarker));
            
            if (publicRequest.IsSetMaxItems())
                request.Parameters.Add("maxitems", StringUtils.FromString(publicRequest.MaxItems));
            request.ResourcePath = "/2013-04-01/trafficpolicies/{Id}/versions";
            request.MarshallerVersion = 2;


            request.UseQueryString = true;
            return request;
        }
        private static ListTrafficPolicyVersionsRequestMarshaller _instance = new ListTrafficPolicyVersionsRequestMarshaller();        

        internal static ListTrafficPolicyVersionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListTrafficPolicyVersionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}
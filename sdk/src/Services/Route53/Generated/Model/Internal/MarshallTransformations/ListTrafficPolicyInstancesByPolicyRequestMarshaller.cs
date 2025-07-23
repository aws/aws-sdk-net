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

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListTrafficPolicyInstancesByPolicy Request Marshaller
    /// </summary>       
    public partial class ListTrafficPolicyInstancesByPolicyRequestMarshaller : IMarshaller<IRequest, ListTrafficPolicyInstancesByPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListTrafficPolicyInstancesByPolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListTrafficPolicyInstancesByPolicyRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.Route53");
            request.HttpMethod = "GET";
            
            if (publicRequest.IsSetTrafficPolicyId())
                request.Parameters.Add("id", StringUtils.FromString(publicRequest.TrafficPolicyId));
            
            if (publicRequest.IsSetTrafficPolicyVersion())
                request.Parameters.Add("version", StringUtils.FromInt(publicRequest.TrafficPolicyVersion));
            
            if (publicRequest.IsSetHostedZoneIdMarker())
                request.Parameters.Add("hostedzoneid", StringUtils.FromString(publicRequest.HostedZoneIdMarker));
            
            if (publicRequest.IsSetTrafficPolicyInstanceNameMarker())
                request.Parameters.Add("trafficpolicyinstancename", StringUtils.FromString(publicRequest.TrafficPolicyInstanceNameMarker));
            
            if (publicRequest.IsSetTrafficPolicyInstanceTypeMarker())
                request.Parameters.Add("trafficpolicyinstancetype", StringUtils.FromString(publicRequest.TrafficPolicyInstanceTypeMarker));
            
            if (publicRequest.IsSetMaxItems())
                request.Parameters.Add("maxitems", StringUtils.FromString(publicRequest.MaxItems));
            request.ResourcePath = "/2013-04-01/trafficpolicyinstances/trafficpolicy";


            PostMarshallCustomization(request, publicRequest);
            request.UseQueryString = true;
            return request;
        }
        private static ListTrafficPolicyInstancesByPolicyRequestMarshaller _instance = new ListTrafficPolicyInstancesByPolicyRequestMarshaller();        

        internal static ListTrafficPolicyInstancesByPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListTrafficPolicyInstancesByPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, ListTrafficPolicyInstancesByPolicyRequest publicRequest);
    }    
}
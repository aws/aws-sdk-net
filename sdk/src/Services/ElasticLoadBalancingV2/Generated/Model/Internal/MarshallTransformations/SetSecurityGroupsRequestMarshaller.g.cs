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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.ElasticLoadBalancingV2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SetSecurityGroups Request Marshaller
    /// </summary>
    public partial class SetSecurityGroupsRequestMarshaller : IMarshaller<IRequest, SetSecurityGroupsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SetSecurityGroupsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(SetSecurityGroupsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancingV2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "SetSecurityGroups");
            request.Parameters.Add("Version", "2015-12-01");

            if (publicRequest.IsSetEnforceSecurityGroupInboundRulesOnPrivateLinkTraffic())
            {
                request.Parameters.Add("EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic", StringUtils.FromString(publicRequest.EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic));
            }
            if (publicRequest.IsSetLoadBalancerArn())
            {
                request.Parameters.Add("LoadBalancerArn", StringUtils.FromString(publicRequest.LoadBalancerArn));
            }
            if (publicRequest.IsSetSecurityGroups())
            {
                if (publicRequest.SecurityGroups.Count == 0)
                {
                    request.Parameters.Add("SecurityGroups", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SecurityGroups)
                    {
                        request.Parameters.Add("SecurityGroups" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly SetSecurityGroupsRequestMarshaller _instance = new();

        internal static SetSecurityGroupsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SetSecurityGroupsRequestMarshaller Instance => _instance;
    }
}

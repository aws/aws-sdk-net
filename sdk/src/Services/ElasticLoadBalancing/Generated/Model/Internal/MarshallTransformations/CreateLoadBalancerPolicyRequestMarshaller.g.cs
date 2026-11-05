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

using Amazon.ElasticLoadBalancing.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLoadBalancerPolicy Request Marshaller
    /// </summary>
    public partial class CreateLoadBalancerPolicyRequestMarshaller : IMarshaller<IRequest, CreateLoadBalancerPolicyRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLoadBalancerPolicyRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateLoadBalancerPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancing");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateLoadBalancerPolicy");
            request.Parameters.Add("Version", "2012-06-01");

            if (publicRequest.IsSetLoadBalancerName())
            {
                request.Parameters.Add("LoadBalancerName", StringUtils.FromString(publicRequest.LoadBalancerName));
            }
            if (publicRequest.IsSetPolicyAttributes())
            {
                if (publicRequest.PolicyAttributes.Count == 0)
                {
                    request.Parameters.Add("PolicyAttributes", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.PolicyAttributes)
                    {
                        if (item0.IsSetAttributeName())
                        {
                            request.Parameters.Add("PolicyAttributes" + ".member" + "." + index0 + ".AttributeName", StringUtils.FromString(item0.AttributeName));
                        }
                        if (item0.IsSetAttributeValue())
                        {
                            request.Parameters.Add("PolicyAttributes" + ".member" + "." + index0 + ".AttributeValue", StringUtils.FromString(item0.AttributeValue));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetPolicyName())
            {
                request.Parameters.Add("PolicyName", StringUtils.FromString(publicRequest.PolicyName));
            }
            if (publicRequest.IsSetPolicyTypeName())
            {
                request.Parameters.Add("PolicyTypeName", StringUtils.FromString(publicRequest.PolicyTypeName));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateLoadBalancerPolicyRequestMarshaller _instance = new();

        internal static CreateLoadBalancerPolicyRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateLoadBalancerPolicyRequestMarshaller Instance => _instance;
    }
}

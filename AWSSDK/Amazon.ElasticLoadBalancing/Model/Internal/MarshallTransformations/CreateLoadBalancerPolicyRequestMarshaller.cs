/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.ElasticLoadBalancing.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Create Load Balancer Policy Request Marshaller
    /// </summary>       
    public class CreateLoadBalancerPolicyRequestMarshaller : IMarshaller<IRequest, CreateLoadBalancerPolicyRequest>
    {
        public IRequest Marshall(CreateLoadBalancerPolicyRequest createLoadBalancerPolicyRequest)
        {
            IRequest request = new DefaultRequest(createLoadBalancerPolicyRequest, "AmazonElasticLoadBalancing");
            request.Parameters.Add("Action", "CreateLoadBalancerPolicy");
            request.Parameters.Add("Version", "2012-06-01");
            if (createLoadBalancerPolicyRequest != null && createLoadBalancerPolicyRequest.IsSetLoadBalancerName())
            {
                request.Parameters.Add("LoadBalancerName", StringUtils.FromString(createLoadBalancerPolicyRequest.LoadBalancerName));
            }
            if (createLoadBalancerPolicyRequest != null && createLoadBalancerPolicyRequest.IsSetPolicyName())
            {
                request.Parameters.Add("PolicyName", StringUtils.FromString(createLoadBalancerPolicyRequest.PolicyName));
            }
            if (createLoadBalancerPolicyRequest != null && createLoadBalancerPolicyRequest.IsSetPolicyTypeName())
            {
                request.Parameters.Add("PolicyTypeName", StringUtils.FromString(createLoadBalancerPolicyRequest.PolicyTypeName));
            }

            if (createLoadBalancerPolicyRequest != null)
            {
                List<PolicyAttribute> policyAttributesList = createLoadBalancerPolicyRequest.PolicyAttributes;
                int policyAttributesListIndex = 1;
                foreach (PolicyAttribute policyAttributesListValue in policyAttributesList)
                {
                    if (policyAttributesListValue != null && policyAttributesListValue.IsSetAttributeName())
                    {
                        request.Parameters.Add("PolicyAttributes.member." + policyAttributesListIndex + ".AttributeName", StringUtils.FromString(policyAttributesListValue.AttributeName));
                    }
                    if (policyAttributesListValue != null && policyAttributesListValue.IsSetAttributeValue())
                    {
                        request.Parameters.Add("PolicyAttributes.member." + policyAttributesListIndex + ".AttributeValue", StringUtils.FromString(policyAttributesListValue.AttributeValue));
                    }

                    policyAttributesListIndex++;
                }
            }

            return request;
        }
    }
}

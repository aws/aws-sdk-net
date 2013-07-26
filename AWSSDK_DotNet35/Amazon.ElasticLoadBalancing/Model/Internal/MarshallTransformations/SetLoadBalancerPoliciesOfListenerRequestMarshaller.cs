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
    /// Set Load Balancer Policies Of Listener Request Marshaller
    /// </summary>       
    public class SetLoadBalancerPoliciesOfListenerRequestMarshaller : IMarshaller<IRequest, SetLoadBalancerPoliciesOfListenerRequest>
    {
        public IRequest Marshall(SetLoadBalancerPoliciesOfListenerRequest setLoadBalancerPoliciesOfListenerRequest)
        {
            IRequest request = new DefaultRequest(setLoadBalancerPoliciesOfListenerRequest, "AmazonElasticLoadBalancing");
            request.Parameters.Add("Action", "SetLoadBalancerPoliciesOfListener");
            request.Parameters.Add("Version", "2012-06-01");
            if (setLoadBalancerPoliciesOfListenerRequest != null && setLoadBalancerPoliciesOfListenerRequest.IsSetLoadBalancerName())
            {
                request.Parameters.Add("LoadBalancerName", StringUtils.FromString(setLoadBalancerPoliciesOfListenerRequest.LoadBalancerName));
            }
            if (setLoadBalancerPoliciesOfListenerRequest != null && setLoadBalancerPoliciesOfListenerRequest.IsSetLoadBalancerPort())
            {
                request.Parameters.Add("LoadBalancerPort", StringUtils.FromInt(setLoadBalancerPoliciesOfListenerRequest.LoadBalancerPort));
            }
            if (setLoadBalancerPoliciesOfListenerRequest != null)
            {
                List<string> policyNamesList = setLoadBalancerPoliciesOfListenerRequest.PolicyNames;

                int policyNamesListIndex = 1;
                foreach (string policyNamesListValue in policyNamesList)
                { 
                    request.Parameters.Add("PolicyNames.member." + policyNamesListIndex, StringUtils.FromString(policyNamesListValue));
                    policyNamesListIndex++;
                }
            }

            return request;
        }
    }
}

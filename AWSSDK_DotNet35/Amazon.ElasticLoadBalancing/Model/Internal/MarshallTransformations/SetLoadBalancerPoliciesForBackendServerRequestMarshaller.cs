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
    /// Set Load Balancer Policies For Backend Server Request Marshaller
    /// </summary>       
    public class SetLoadBalancerPoliciesForBackendServerRequestMarshaller : IMarshaller<IRequest, SetLoadBalancerPoliciesForBackendServerRequest>
    {
        public IRequest Marshall(SetLoadBalancerPoliciesForBackendServerRequest setLoadBalancerPoliciesForBackendServerRequest)
        {
            IRequest request = new DefaultRequest(setLoadBalancerPoliciesForBackendServerRequest, "AmazonElasticLoadBalancing");
            request.Parameters.Add("Action", "SetLoadBalancerPoliciesForBackendServer");
            request.Parameters.Add("Version", "2012-06-01");
            if (setLoadBalancerPoliciesForBackendServerRequest != null && setLoadBalancerPoliciesForBackendServerRequest.IsSetLoadBalancerName())
            {
                request.Parameters.Add("LoadBalancerName", StringUtils.FromString(setLoadBalancerPoliciesForBackendServerRequest.LoadBalancerName));
            }
            if (setLoadBalancerPoliciesForBackendServerRequest != null && setLoadBalancerPoliciesForBackendServerRequest.IsSetInstancePort())
            {
                request.Parameters.Add("InstancePort", StringUtils.FromInt(setLoadBalancerPoliciesForBackendServerRequest.InstancePort));
            }
            if (setLoadBalancerPoliciesForBackendServerRequest != null)
            {
                List<string> policyNamesList = setLoadBalancerPoliciesForBackendServerRequest.PolicyNames;

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

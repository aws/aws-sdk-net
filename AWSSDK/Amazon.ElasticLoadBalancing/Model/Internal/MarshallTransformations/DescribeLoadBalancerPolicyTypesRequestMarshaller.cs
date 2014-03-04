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
    /// Describe Load Balancer Policy Types Request Marshaller
    /// </summary>       
    public class DescribeLoadBalancerPolicyTypesRequestMarshaller : IMarshaller<IRequest, DescribeLoadBalancerPolicyTypesRequest>
    {
        public IRequest Marshall(DescribeLoadBalancerPolicyTypesRequest describeLoadBalancerPolicyTypesRequest)
        {
            IRequest request = new DefaultRequest(describeLoadBalancerPolicyTypesRequest, "AmazonElasticLoadBalancing");
            request.Parameters.Add("Action", "DescribeLoadBalancerPolicyTypes");
            request.Parameters.Add("Version", "2012-06-01");
            if (describeLoadBalancerPolicyTypesRequest != null)
            {
                List<string> policyTypeNamesList = describeLoadBalancerPolicyTypesRequest.PolicyTypeNames;

                int policyTypeNamesListIndex = 1;
                foreach (string policyTypeNamesListValue in policyTypeNamesList)
                { 
                    request.Parameters.Add("PolicyTypeNames.member." + policyTypeNamesListIndex, StringUtils.FromString(policyTypeNamesListValue));
                    policyTypeNamesListIndex++;
                }
            }

            return request;
        }
    }
}

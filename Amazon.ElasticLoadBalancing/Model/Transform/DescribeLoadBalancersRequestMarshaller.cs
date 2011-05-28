/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticLoadBalancing.Model.Transform
{
    /// <summary>
    /// Describe Load Balancers Request Marshaller
    /// </summary>       
    public class DescribeLoadBalancersRequestMarshaller : IMarshaller<IRequest<DescribeLoadBalancersRequest>, DescribeLoadBalancersRequest> 
    {

        public IRequest<DescribeLoadBalancersRequest> Marshall(DescribeLoadBalancersRequest describeLoadBalancersRequest) 
        {
            IRequest<DescribeLoadBalancersRequest> request = new DefaultRequest<DescribeLoadBalancersRequest>(describeLoadBalancersRequest, "AmazonElasticLoadBalancing");
            request.Parameters.Add("Action", "DescribeLoadBalancers");
            request.Parameters.Add("Version", "2011-04-05");
            if (describeLoadBalancersRequest != null) 
            {
                List<string> loadBalancerNamesList = describeLoadBalancersRequest.LoadBalancerNames;

                int loadBalancerNamesListIndex = 1;
                foreach (string loadBalancerNamesListValue in loadBalancerNamesList) 
                { 
                    request.Parameters.Add("LoadBalancerNames.member." + loadBalancerNamesListIndex, StringUtils.FromString(loadBalancerNamesListValue));
                    loadBalancerNamesListIndex++;
                }
            }


            return request;
        }
    }
}

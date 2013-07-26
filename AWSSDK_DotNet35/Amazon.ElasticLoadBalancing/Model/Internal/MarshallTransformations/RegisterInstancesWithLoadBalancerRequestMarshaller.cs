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
    /// Register Instances With Load Balancer Request Marshaller
    /// </summary>       
    public class RegisterInstancesWithLoadBalancerRequestMarshaller : IMarshaller<IRequest, RegisterInstancesWithLoadBalancerRequest>
    {
        public IRequest Marshall(RegisterInstancesWithLoadBalancerRequest registerInstancesWithLoadBalancerRequest)
        {
            IRequest request = new DefaultRequest(registerInstancesWithLoadBalancerRequest, "AmazonElasticLoadBalancing");
            request.Parameters.Add("Action", "RegisterInstancesWithLoadBalancer");
            request.Parameters.Add("Version", "2012-06-01");
            if (registerInstancesWithLoadBalancerRequest != null && registerInstancesWithLoadBalancerRequest.IsSetLoadBalancerName())
            {
                request.Parameters.Add("LoadBalancerName", StringUtils.FromString(registerInstancesWithLoadBalancerRequest.LoadBalancerName));
            }

            if (registerInstancesWithLoadBalancerRequest != null)
            {
                List<Instance> instancesList = registerInstancesWithLoadBalancerRequest.Instances;
                int instancesListIndex = 1;
                foreach (Instance instancesListValue in instancesList)
                {
                    if (instancesListValue != null && instancesListValue.IsSetInstanceId())
                    {
                        request.Parameters.Add("Instances.member." + instancesListIndex + ".InstanceId", StringUtils.FromString(instancesListValue.InstanceId));
                    }

                    instancesListIndex++;
                }
            }

            return request;
        }
    }
}

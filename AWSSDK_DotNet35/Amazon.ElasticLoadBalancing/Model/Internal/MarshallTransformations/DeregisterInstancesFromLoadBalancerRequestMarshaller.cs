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
    /// Deregister Instances From Load Balancer Request Marshaller
    /// </summary>       
    public class DeregisterInstancesFromLoadBalancerRequestMarshaller : IMarshaller<IRequest, DeregisterInstancesFromLoadBalancerRequest>
    {
        public IRequest Marshall(DeregisterInstancesFromLoadBalancerRequest deregisterInstancesFromLoadBalancerRequest)
        {
            IRequest request = new DefaultRequest(deregisterInstancesFromLoadBalancerRequest, "AmazonElasticLoadBalancing");
            request.Parameters.Add("Action", "DeregisterInstancesFromLoadBalancer");
            request.Parameters.Add("Version", "2012-06-01");
            if (deregisterInstancesFromLoadBalancerRequest != null && deregisterInstancesFromLoadBalancerRequest.IsSetLoadBalancerName())
            {
                request.Parameters.Add("LoadBalancerName", StringUtils.FromString(deregisterInstancesFromLoadBalancerRequest.LoadBalancerName));
            }

            if (deregisterInstancesFromLoadBalancerRequest != null)
            {
                List<Instance> instancesList = deregisterInstancesFromLoadBalancerRequest.Instances;
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

/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Disable Availability Zones For Load Balancer Request Marshaller
    /// </summary>       
    public class DisableAvailabilityZonesForLoadBalancerRequestMarshaller : IMarshaller<IRequest<DisableAvailabilityZonesForLoadBalancerRequest>, DisableAvailabilityZonesForLoadBalancerRequest> 
    {

        public IRequest<DisableAvailabilityZonesForLoadBalancerRequest> Marshall(DisableAvailabilityZonesForLoadBalancerRequest disableAvailabilityZonesForLoadBalancerRequest) 
        {
            IRequest<DisableAvailabilityZonesForLoadBalancerRequest> request = new DefaultRequest<DisableAvailabilityZonesForLoadBalancerRequest>(disableAvailabilityZonesForLoadBalancerRequest, "AmazonElasticLoadBalancing");
            request.Parameters.Add("Action", "DisableAvailabilityZonesForLoadBalancer");
            request.Parameters.Add("Version", "2010-07-01");
            if (disableAvailabilityZonesForLoadBalancerRequest != null && disableAvailabilityZonesForLoadBalancerRequest.IsSetLoadBalancerName()) 
            {
                request.Parameters.Add("LoadBalancerName", StringUtils.FromString(disableAvailabilityZonesForLoadBalancerRequest.LoadBalancerName));
            }
            if (disableAvailabilityZonesForLoadBalancerRequest != null) 
            {
                List<string> availabilityZonesList = disableAvailabilityZonesForLoadBalancerRequest.AvailabilityZones;
                int availabilityZonesListIndex = 1;
                foreach (string availabilityZonesListValue in availabilityZonesList) 
                { 
                    request.Parameters.Add("AvailabilityZones.member." + availabilityZonesListIndex, StringUtils.FromString(availabilityZonesListValue));
                    availabilityZonesListIndex++;
                }
            }


            return request;
        }
    }
}

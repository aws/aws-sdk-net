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
    /// Create Load Balancer Request Marshaller
    /// </summary>       
    public class CreateLoadBalancerRequestMarshaller : IMarshaller<IRequest<CreateLoadBalancerRequest>, CreateLoadBalancerRequest> 
    {

        public IRequest<CreateLoadBalancerRequest> Marshall(CreateLoadBalancerRequest createLoadBalancerRequest) 
        {
            IRequest<CreateLoadBalancerRequest> request = new DefaultRequest<CreateLoadBalancerRequest>(createLoadBalancerRequest, "AmazonElasticLoadBalancing");
            request.Parameters.Add("Action", "CreateLoadBalancer");
            request.Parameters.Add("Version", "2011-04-05");
            if (createLoadBalancerRequest != null && createLoadBalancerRequest.IsSetLoadBalancerName()) 
            {
                request.Parameters.Add("LoadBalancerName", StringUtils.FromString(createLoadBalancerRequest.LoadBalancerName));
            }

            if (createLoadBalancerRequest != null) 
            {
                List<Listener> listenersList = createLoadBalancerRequest.Listeners;
                int listenersListIndex = 1;
                foreach (Listener listenersListValue in listenersList) 
                { 
                    if (listenersListValue != null && listenersListValue.IsSetProtocol()) 
                    {
                        request.Parameters.Add("Listeners.member." + listenersListIndex + ".Protocol", StringUtils.FromString(listenersListValue.Protocol));
                    }
                    if (listenersListValue != null && listenersListValue.IsSetLoadBalancerPort()) 
                    {
                        request.Parameters.Add("Listeners.member." + listenersListIndex + ".LoadBalancerPort", StringUtils.FromInt(listenersListValue.LoadBalancerPort));
                    }
                    if (listenersListValue != null && listenersListValue.IsSetInstancePort()) 
                    {
                        request.Parameters.Add("Listeners.member." + listenersListIndex + ".InstancePort", StringUtils.FromInt(listenersListValue.InstancePort));
                    }
                    if (listenersListValue != null && listenersListValue.IsSetSSLCertificateId()) 
                    {
                        request.Parameters.Add("Listeners.member." + listenersListIndex + ".SSLCertificateId", StringUtils.FromString(listenersListValue.SSLCertificateId));
                    }

                    listenersListIndex++;
                }
            }
            if (createLoadBalancerRequest != null) 
            {
                List<string> availabilityZonesList = createLoadBalancerRequest.AvailabilityZones;

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

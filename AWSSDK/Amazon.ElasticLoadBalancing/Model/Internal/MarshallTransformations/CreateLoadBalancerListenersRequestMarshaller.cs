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
    /// Create Load Balancer Listeners Request Marshaller
    /// </summary>       
    public class CreateLoadBalancerListenersRequestMarshaller : IMarshaller<IRequest, CreateLoadBalancerListenersRequest>
    {
        public IRequest Marshall(CreateLoadBalancerListenersRequest createLoadBalancerListenersRequest)
        {
            IRequest request = new DefaultRequest(createLoadBalancerListenersRequest, "AmazonElasticLoadBalancing");
            request.Parameters.Add("Action", "CreateLoadBalancerListeners");
            request.Parameters.Add("Version", "2012-06-01");
            if (createLoadBalancerListenersRequest != null && createLoadBalancerListenersRequest.IsSetLoadBalancerName())
            {
                request.Parameters.Add("LoadBalancerName", StringUtils.FromString(createLoadBalancerListenersRequest.LoadBalancerName));
            }

            if (createLoadBalancerListenersRequest != null)
            {
                List<Listener> listenersList = createLoadBalancerListenersRequest.Listeners;
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
                    if (listenersListValue != null && listenersListValue.IsSetInstanceProtocol())
                    {
                        request.Parameters.Add("Listeners.member." + listenersListIndex + ".InstanceProtocol", StringUtils.FromString(listenersListValue.InstanceProtocol));
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

            return request;
        }
    }
}

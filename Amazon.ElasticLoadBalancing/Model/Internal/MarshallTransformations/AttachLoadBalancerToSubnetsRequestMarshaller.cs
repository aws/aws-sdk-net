/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Attach Load Balancer To Subnets Request Marshaller
    /// </summary>       
    public class AttachLoadBalancerToSubnetsRequestMarshaller : IMarshaller<IRequest<AttachLoadBalancerToSubnetsRequest>, AttachLoadBalancerToSubnetsRequest>
    {
        public IRequest<AttachLoadBalancerToSubnetsRequest> Marshall(AttachLoadBalancerToSubnetsRequest attachLoadBalancerToSubnetsRequest)
        {
            IRequest<AttachLoadBalancerToSubnetsRequest> request = new DefaultRequest<AttachLoadBalancerToSubnetsRequest>(attachLoadBalancerToSubnetsRequest, "AmazonElasticLoadBalancing");
            request.Parameters.Add("Action", "AttachLoadBalancerToSubnets");
            request.Parameters.Add("Version", "2011-11-15");
            if (attachLoadBalancerToSubnetsRequest != null && attachLoadBalancerToSubnetsRequest.IsSetLoadBalancerName())
            {
                request.Parameters.Add("LoadBalancerName", StringUtils.FromString(attachLoadBalancerToSubnetsRequest.LoadBalancerName));
            }
            if (attachLoadBalancerToSubnetsRequest != null)
            {
                List<string> subnetsList = attachLoadBalancerToSubnetsRequest.Subnets;

                int subnetsListIndex = 1;
                foreach (string subnetsListValue in subnetsList)
                { 
                    request.Parameters.Add("Subnets.member." + subnetsListIndex, StringUtils.FromString(subnetsListValue));
                    subnetsListIndex++;
                }
            }

            return request;
        }
    }
}

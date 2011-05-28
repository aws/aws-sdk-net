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
    /// Create L B Cookie Stickiness Policy Request Marshaller
    /// </summary>       
    public class CreateLBCookieStickinessPolicyRequestMarshaller : IMarshaller<IRequest<CreateLBCookieStickinessPolicyRequest>, CreateLBCookieStickinessPolicyRequest> 
    {

        public IRequest<CreateLBCookieStickinessPolicyRequest> Marshall(CreateLBCookieStickinessPolicyRequest createLBCookieStickinessPolicyRequest) 
        {
            IRequest<CreateLBCookieStickinessPolicyRequest> request = new DefaultRequest<CreateLBCookieStickinessPolicyRequest>(createLBCookieStickinessPolicyRequest, "AmazonElasticLoadBalancing");
            request.Parameters.Add("Action", "CreateLBCookieStickinessPolicy");
            request.Parameters.Add("Version", "2011-04-05");
            if (createLBCookieStickinessPolicyRequest != null && createLBCookieStickinessPolicyRequest.IsSetLoadBalancerName()) 
            {
                request.Parameters.Add("LoadBalancerName", StringUtils.FromString(createLBCookieStickinessPolicyRequest.LoadBalancerName));
            }
            if (createLBCookieStickinessPolicyRequest != null && createLBCookieStickinessPolicyRequest.IsSetPolicyName()) 
            {
                request.Parameters.Add("PolicyName", StringUtils.FromString(createLBCookieStickinessPolicyRequest.PolicyName));
            }
            if (createLBCookieStickinessPolicyRequest != null && createLBCookieStickinessPolicyRequest.IsSetCookieExpirationPeriod()) 
            {
                request.Parameters.Add("CookieExpirationPeriod", StringUtils.FromLong(createLBCookieStickinessPolicyRequest.CookieExpirationPeriod));
            }


            return request;
        }
    }
}

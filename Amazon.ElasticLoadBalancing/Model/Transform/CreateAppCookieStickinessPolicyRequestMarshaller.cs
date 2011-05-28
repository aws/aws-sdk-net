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
    /// Create App Cookie Stickiness Policy Request Marshaller
    /// </summary>       
    public class CreateAppCookieStickinessPolicyRequestMarshaller : IMarshaller<IRequest<CreateAppCookieStickinessPolicyRequest>, CreateAppCookieStickinessPolicyRequest> 
    {

        public IRequest<CreateAppCookieStickinessPolicyRequest> Marshall(CreateAppCookieStickinessPolicyRequest createAppCookieStickinessPolicyRequest) 
        {
            IRequest<CreateAppCookieStickinessPolicyRequest> request = new DefaultRequest<CreateAppCookieStickinessPolicyRequest>(createAppCookieStickinessPolicyRequest, "AmazonElasticLoadBalancing");
            request.Parameters.Add("Action", "CreateAppCookieStickinessPolicy");
            request.Parameters.Add("Version", "2011-04-05");
            if (createAppCookieStickinessPolicyRequest != null && createAppCookieStickinessPolicyRequest.IsSetLoadBalancerName()) 
            {
                request.Parameters.Add("LoadBalancerName", StringUtils.FromString(createAppCookieStickinessPolicyRequest.LoadBalancerName));
            }
            if (createAppCookieStickinessPolicyRequest != null && createAppCookieStickinessPolicyRequest.IsSetPolicyName()) 
            {
                request.Parameters.Add("PolicyName", StringUtils.FromString(createAppCookieStickinessPolicyRequest.PolicyName));
            }
            if (createAppCookieStickinessPolicyRequest != null && createAppCookieStickinessPolicyRequest.IsSetCookieName()) 
            {
                request.Parameters.Add("CookieName", StringUtils.FromString(createAppCookieStickinessPolicyRequest.CookieName));
            }


            return request;
        }
    }
}

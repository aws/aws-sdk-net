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
    /// Configure Health Check Request Marshaller
    /// </summary>       
    public class ConfigureHealthCheckRequestMarshaller : IMarshaller<IRequest, ConfigureHealthCheckRequest>
    {
        public IRequest Marshall(ConfigureHealthCheckRequest configureHealthCheckRequest)
        {
            IRequest request = new DefaultRequest(configureHealthCheckRequest, "AmazonElasticLoadBalancing");
            request.Parameters.Add("Action", "ConfigureHealthCheck");
            request.Parameters.Add("Version", "2012-06-01");
            if (configureHealthCheckRequest != null && configureHealthCheckRequest.IsSetLoadBalancerName())
            {
                request.Parameters.Add("LoadBalancerName", StringUtils.FromString(configureHealthCheckRequest.LoadBalancerName));
            }
            if (configureHealthCheckRequest != null)
            {
                HealthCheck healthCheck = configureHealthCheckRequest.HealthCheck;
                if (healthCheck != null && healthCheck.IsSetTarget())
                {
                    request.Parameters.Add("HealthCheck.Target", StringUtils.FromString(healthCheck.Target));
                }
                if (healthCheck != null && healthCheck.IsSetInterval())
                {
                    request.Parameters.Add("HealthCheck.Interval", StringUtils.FromInt(healthCheck.Interval));
                }
                if (healthCheck != null && healthCheck.IsSetTimeout())
                {
                    request.Parameters.Add("HealthCheck.Timeout", StringUtils.FromInt(healthCheck.Timeout));
                }
                if (healthCheck != null && healthCheck.IsSetUnhealthyThreshold())
                {
                    request.Parameters.Add("HealthCheck.UnhealthyThreshold", StringUtils.FromInt(healthCheck.UnhealthyThreshold));
                }
                if (healthCheck != null && healthCheck.IsSetHealthyThreshold())
                {
                    request.Parameters.Add("HealthCheck.HealthyThreshold", StringUtils.FromInt(healthCheck.HealthyThreshold));
                }
            }

            return request;
        }
    }
}

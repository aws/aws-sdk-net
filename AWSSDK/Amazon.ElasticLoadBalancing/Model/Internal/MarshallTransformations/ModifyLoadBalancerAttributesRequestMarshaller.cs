/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Modify Load Balancer Attributes Request Marshaller
    /// </summary>       
    public class ModifyLoadBalancerAttributesRequestMarshaller : IMarshaller<IRequest, ModifyLoadBalancerAttributesRequest>
    {
        public IRequest Marshall(ModifyLoadBalancerAttributesRequest modifyLoadBalancerAttributesRequest)
        {
            IRequest request = new DefaultRequest(modifyLoadBalancerAttributesRequest, "AmazonElasticLoadBalancing");
            request.Parameters.Add("Action", "ModifyLoadBalancerAttributes");
            request.Parameters.Add("Version", "2012-06-01");
            if (modifyLoadBalancerAttributesRequest != null && modifyLoadBalancerAttributesRequest.IsSetLoadBalancerName())
            {
                request.Parameters.Add("LoadBalancerName", StringUtils.FromString(modifyLoadBalancerAttributesRequest.LoadBalancerName));
            }
            if (modifyLoadBalancerAttributesRequest != null)
            {
                LoadBalancerAttributes loadBalancerAttributes = modifyLoadBalancerAttributesRequest.LoadBalancerAttributes;
                if (loadBalancerAttributes != null)
                {
                    CrossZoneLoadBalancing crossZoneLoadBalancing = loadBalancerAttributes.CrossZoneLoadBalancing;
                    if (crossZoneLoadBalancing != null && crossZoneLoadBalancing.IsSetEnabled())
                    {
                        request.Parameters.Add("LoadBalancerAttributes.CrossZoneLoadBalancing.Enabled", StringUtils.FromBool(crossZoneLoadBalancing.Enabled));
                    }
                }
                if (loadBalancerAttributes != null)
                {
                    AccessLog accessLog = loadBalancerAttributes.AccessLog;
                    if (accessLog != null && accessLog.IsSetEnabled())
                    {
                        request.Parameters.Add("LoadBalancerAttributes.AccessLog.Enabled", StringUtils.FromBool(accessLog.Enabled));
                    }
                    if (accessLog != null && accessLog.IsSetS3BucketName())
                    {
                        request.Parameters.Add("LoadBalancerAttributes.AccessLog.S3BucketName", StringUtils.FromString(accessLog.S3BucketName));
                    }
                    if (accessLog != null && accessLog.IsSetEmitInterval())
                    {
                        request.Parameters.Add("LoadBalancerAttributes.AccessLog.EmitInterval", StringUtils.FromInt(accessLog.EmitInterval));
                    }
                    if (accessLog != null && accessLog.IsSetS3BucketPrefix())
                    {
                        request.Parameters.Add("LoadBalancerAttributes.AccessLog.S3BucketPrefix", StringUtils.FromString(accessLog.S3BucketPrefix));
                    }
                }
                if (loadBalancerAttributes != null)
                {
                    ConnectionDraining connectionDraining = loadBalancerAttributes.ConnectionDraining;
                    if (connectionDraining != null && connectionDraining.IsSetEnabled())
                    {
                        request.Parameters.Add("LoadBalancerAttributes.ConnectionDraining.Enabled", StringUtils.FromBool(connectionDraining.Enabled));
                    }
                    if (connectionDraining != null && connectionDraining.IsSetTimeout())
                    {
                        request.Parameters.Add("LoadBalancerAttributes.ConnectionDraining.Timeout", StringUtils.FromInt(connectionDraining.Timeout));
                    }
                }
            }

            return request;
        }
    }
}

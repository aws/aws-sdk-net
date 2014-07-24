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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticLoadBalancing.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyLoadBalancerAttributes Request Marshaller
    /// </summary>       
    public class ModifyLoadBalancerAttributesRequestMarshaller : IMarshaller<IRequest, ModifyLoadBalancerAttributesRequest>
    {
        public IRequest Marshall(ModifyLoadBalancerAttributesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancing");
            request.Parameters.Add("Action", "ModifyLoadBalancerAttributes");
            request.Parameters.Add("Version", "2012-06-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetLoadBalancerAttributes())
                {
                    if(publicRequest.LoadBalancerAttributes.IsSetAccessLog())
                    {
                        if(publicRequest.LoadBalancerAttributes.AccessLog.IsSetEmitInterval())
                        {
                            request.Parameters.Add("LoadBalancerAttributes" + "." + "AccessLog" + "." + "EmitInterval", StringUtils.FromInt(publicRequest.LoadBalancerAttributes.AccessLog.EmitInterval));
                        }
                        if(publicRequest.LoadBalancerAttributes.AccessLog.IsSetEnabled())
                        {
                            request.Parameters.Add("LoadBalancerAttributes" + "." + "AccessLog" + "." + "Enabled", StringUtils.FromBool(publicRequest.LoadBalancerAttributes.AccessLog.Enabled));
                        }
                        if(publicRequest.LoadBalancerAttributes.AccessLog.IsSetS3BucketName())
                        {
                            request.Parameters.Add("LoadBalancerAttributes" + "." + "AccessLog" + "." + "S3BucketName", StringUtils.FromString(publicRequest.LoadBalancerAttributes.AccessLog.S3BucketName));
                        }
                        if(publicRequest.LoadBalancerAttributes.AccessLog.IsSetS3BucketPrefix())
                        {
                            request.Parameters.Add("LoadBalancerAttributes" + "." + "AccessLog" + "." + "S3BucketPrefix", StringUtils.FromString(publicRequest.LoadBalancerAttributes.AccessLog.S3BucketPrefix));
                        }
                    }
                    if(publicRequest.LoadBalancerAttributes.IsSetConnectionDraining())
                    {
                        if(publicRequest.LoadBalancerAttributes.ConnectionDraining.IsSetEnabled())
                        {
                            request.Parameters.Add("LoadBalancerAttributes" + "." + "ConnectionDraining" + "." + "Enabled", StringUtils.FromBool(publicRequest.LoadBalancerAttributes.ConnectionDraining.Enabled));
                        }
                        if(publicRequest.LoadBalancerAttributes.ConnectionDraining.IsSetTimeout())
                        {
                            request.Parameters.Add("LoadBalancerAttributes" + "." + "ConnectionDraining" + "." + "Timeout", StringUtils.FromInt(publicRequest.LoadBalancerAttributes.ConnectionDraining.Timeout));
                        }
                    }
                    if(publicRequest.LoadBalancerAttributes.IsSetConnectionSettings())
                    {
                        if(publicRequest.LoadBalancerAttributes.ConnectionSettings.IsSetIdleTimeout())
                        {
                            request.Parameters.Add("LoadBalancerAttributes" + "." + "ConnectionSettings" + "." + "IdleTimeout", StringUtils.FromInt(publicRequest.LoadBalancerAttributes.ConnectionSettings.IdleTimeout));
                        }
                    }
                    if(publicRequest.LoadBalancerAttributes.IsSetCrossZoneLoadBalancing())
                    {
                        if(publicRequest.LoadBalancerAttributes.CrossZoneLoadBalancing.IsSetEnabled())
                        {
                            request.Parameters.Add("LoadBalancerAttributes" + "." + "CrossZoneLoadBalancing" + "." + "Enabled", StringUtils.FromBool(publicRequest.LoadBalancerAttributes.CrossZoneLoadBalancing.Enabled));
                        }
                    }
                }
                if(publicRequest.IsSetLoadBalancerName())
                {
                    request.Parameters.Add("LoadBalancerName", StringUtils.FromString(publicRequest.LoadBalancerName));
                }
            }
            return request;
        }
    }
}
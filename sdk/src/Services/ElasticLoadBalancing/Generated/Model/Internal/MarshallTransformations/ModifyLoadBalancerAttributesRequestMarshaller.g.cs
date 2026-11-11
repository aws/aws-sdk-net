/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.ElasticLoadBalancing.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyLoadBalancerAttributes Request Marshaller
    /// </summary>
    public partial class ModifyLoadBalancerAttributesRequestMarshaller : IMarshaller<IRequest, ModifyLoadBalancerAttributesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyLoadBalancerAttributesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyLoadBalancerAttributesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancing");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyLoadBalancerAttributes");
            request.Parameters.Add("Version", "2012-06-01");

            if (publicRequest.IsSetLoadBalancerAttributes())
            {
                if (publicRequest.LoadBalancerAttributes.IsSetAccessLog())
                {
                    if (publicRequest.LoadBalancerAttributes.AccessLog.IsSetEmitInterval())
                    {
                        request.Parameters.Add("LoadBalancerAttributes" + ".AccessLog" + ".EmitInterval", StringUtils.FromInt(publicRequest.LoadBalancerAttributes.AccessLog.EmitInterval.Value));
                    }
                    if (publicRequest.LoadBalancerAttributes.AccessLog.IsSetEnabled())
                    {
                        request.Parameters.Add("LoadBalancerAttributes" + ".AccessLog" + ".Enabled", StringUtils.FromBool(publicRequest.LoadBalancerAttributes.AccessLog.Enabled.Value));
                    }
                    if (publicRequest.LoadBalancerAttributes.AccessLog.IsSetS3BucketName())
                    {
                        request.Parameters.Add("LoadBalancerAttributes" + ".AccessLog" + ".S3BucketName", StringUtils.FromString(publicRequest.LoadBalancerAttributes.AccessLog.S3BucketName));
                    }
                    if (publicRequest.LoadBalancerAttributes.AccessLog.IsSetS3BucketPrefix())
                    {
                        request.Parameters.Add("LoadBalancerAttributes" + ".AccessLog" + ".S3BucketPrefix", StringUtils.FromString(publicRequest.LoadBalancerAttributes.AccessLog.S3BucketPrefix));
                    }
                }
                if (publicRequest.LoadBalancerAttributes.IsSetAdditionalAttributes())
                {
                    if (publicRequest.LoadBalancerAttributes.AdditionalAttributes.Count == 0)
                    {
                        request.Parameters.Add("LoadBalancerAttributes" + ".AdditionalAttributes", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.LoadBalancerAttributes.AdditionalAttributes)
                        {
                            if (item1.IsSetKey())
                            {
                                request.Parameters.Add("LoadBalancerAttributes" + ".AdditionalAttributes" + ".member" + "." + index1 + ".Key", StringUtils.FromString(item1.Key));
                            }
                            if (item1.IsSetValue())
                            {
                                request.Parameters.Add("LoadBalancerAttributes" + ".AdditionalAttributes" + ".member" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.LoadBalancerAttributes.IsSetConnectionDraining())
                {
                    if (publicRequest.LoadBalancerAttributes.ConnectionDraining.IsSetEnabled())
                    {
                        request.Parameters.Add("LoadBalancerAttributes" + ".ConnectionDraining" + ".Enabled", StringUtils.FromBool(publicRequest.LoadBalancerAttributes.ConnectionDraining.Enabled.Value));
                    }
                    if (publicRequest.LoadBalancerAttributes.ConnectionDraining.IsSetTimeout())
                    {
                        request.Parameters.Add("LoadBalancerAttributes" + ".ConnectionDraining" + ".Timeout", StringUtils.FromInt(publicRequest.LoadBalancerAttributes.ConnectionDraining.Timeout.Value));
                    }
                }
                if (publicRequest.LoadBalancerAttributes.IsSetConnectionSettings())
                {
                    if (publicRequest.LoadBalancerAttributes.ConnectionSettings.IsSetIdleTimeout())
                    {
                        request.Parameters.Add("LoadBalancerAttributes" + ".ConnectionSettings" + ".IdleTimeout", StringUtils.FromInt(publicRequest.LoadBalancerAttributes.ConnectionSettings.IdleTimeout.Value));
                    }
                }
                if (publicRequest.LoadBalancerAttributes.IsSetCrossZoneLoadBalancing())
                {
                    if (publicRequest.LoadBalancerAttributes.CrossZoneLoadBalancing.IsSetEnabled())
                    {
                        request.Parameters.Add("LoadBalancerAttributes" + ".CrossZoneLoadBalancing" + ".Enabled", StringUtils.FromBool(publicRequest.LoadBalancerAttributes.CrossZoneLoadBalancing.Enabled.Value));
                    }
                }
            }
            if (publicRequest.IsSetLoadBalancerName())
            {
                request.Parameters.Add("LoadBalancerName", StringUtils.FromString(publicRequest.LoadBalancerName));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyLoadBalancerAttributesRequestMarshaller _instance = new();

        internal static ModifyLoadBalancerAttributesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyLoadBalancerAttributesRequestMarshaller Instance => _instance;
    }
}

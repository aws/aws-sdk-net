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

using Amazon.ElasticLoadBalancingV2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateTargetGroup Request Marshaller
    /// </summary>
    public partial class CreateTargetGroupRequestMarshaller : IMarshaller<IRequest, CreateTargetGroupRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTargetGroupRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateTargetGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancingV2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateTargetGroup");
            request.Parameters.Add("Version", "2015-12-01");

            if (publicRequest.IsSetHealthCheckEnabled())
            {
                request.Parameters.Add("HealthCheckEnabled", StringUtils.FromBool(publicRequest.HealthCheckEnabled.Value));
            }
            if (publicRequest.IsSetHealthCheckIntervalSeconds())
            {
                request.Parameters.Add("HealthCheckIntervalSeconds", StringUtils.FromInt(publicRequest.HealthCheckIntervalSeconds.Value));
            }
            if (publicRequest.IsSetHealthCheckPath())
            {
                request.Parameters.Add("HealthCheckPath", StringUtils.FromString(publicRequest.HealthCheckPath));
            }
            if (publicRequest.IsSetHealthCheckPort())
            {
                request.Parameters.Add("HealthCheckPort", StringUtils.FromString(publicRequest.HealthCheckPort));
            }
            if (publicRequest.IsSetHealthCheckProtocol())
            {
                request.Parameters.Add("HealthCheckProtocol", StringUtils.FromString(publicRequest.HealthCheckProtocol));
            }
            if (publicRequest.IsSetHealthCheckTimeoutSeconds())
            {
                request.Parameters.Add("HealthCheckTimeoutSeconds", StringUtils.FromInt(publicRequest.HealthCheckTimeoutSeconds.Value));
            }
            if (publicRequest.IsSetHealthyThresholdCount())
            {
                request.Parameters.Add("HealthyThresholdCount", StringUtils.FromInt(publicRequest.HealthyThresholdCount.Value));
            }
            if (publicRequest.IsSetIpAddressType())
            {
                request.Parameters.Add("IpAddressType", StringUtils.FromString(publicRequest.IpAddressType));
            }
            if (publicRequest.IsSetMatcher())
            {
                if (publicRequest.Matcher.IsSetGrpcCode())
                {
                    request.Parameters.Add("Matcher" + ".GrpcCode", StringUtils.FromString(publicRequest.Matcher.GrpcCode));
                }
                if (publicRequest.Matcher.IsSetHttpCode())
                {
                    request.Parameters.Add("Matcher" + ".HttpCode", StringUtils.FromString(publicRequest.Matcher.HttpCode));
                }
            }
            if (publicRequest.IsSetName())
            {
                request.Parameters.Add("Name", StringUtils.FromString(publicRequest.Name));
            }
            if (publicRequest.IsSetPort())
            {
                request.Parameters.Add("Port", StringUtils.FromInt(publicRequest.Port.Value));
            }
            if (publicRequest.IsSetProtocol())
            {
                request.Parameters.Add("Protocol", StringUtils.FromString(publicRequest.Protocol));
            }
            if (publicRequest.IsSetProtocolVersion())
            {
                request.Parameters.Add("ProtocolVersion", StringUtils.FromString(publicRequest.ProtocolVersion));
            }
            if (publicRequest.IsSetTags())
            {
                if (publicRequest.Tags.Count == 0)
                {
                    request.Parameters.Add("Tags", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Tags)
                    {
                        if (item0.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + ".member" + "." + index0 + ".Key", StringUtils.FromString(item0.Key));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + ".member" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTargetControlPort())
            {
                request.Parameters.Add("TargetControlPort", StringUtils.FromInt(publicRequest.TargetControlPort.Value));
            }
            if (publicRequest.IsSetTargetType())
            {
                request.Parameters.Add("TargetType", StringUtils.FromString(publicRequest.TargetType));
            }
            if (publicRequest.IsSetUnhealthyThresholdCount())
            {
                request.Parameters.Add("UnhealthyThresholdCount", StringUtils.FromInt(publicRequest.UnhealthyThresholdCount.Value));
            }
            if (publicRequest.IsSetVpcId())
            {
                request.Parameters.Add("VpcId", StringUtils.FromString(publicRequest.VpcId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateTargetGroupRequestMarshaller _instance = new();

        internal static CreateTargetGroupRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateTargetGroupRequestMarshaller Instance => _instance;
    }
}

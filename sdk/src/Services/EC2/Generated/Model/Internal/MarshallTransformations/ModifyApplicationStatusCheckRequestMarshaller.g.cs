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

using Amazon.EC2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyApplicationStatusCheck Request Marshaller
    /// </summary>
    public partial class ModifyApplicationStatusCheckRequestMarshaller : IMarshaller<IRequest, ModifyApplicationStatusCheckRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyApplicationStatusCheckRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyApplicationStatusCheckRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyApplicationStatusCheck");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAggregation())
            {
                request.Parameters.Add("Aggregation", StringUtils.FromString(publicRequest.Aggregation));
            }
            if (publicRequest.IsSetApplicationStatusCheckId())
            {
                request.Parameters.Add("ApplicationStatusCheckId", StringUtils.FromString(publicRequest.ApplicationStatusCheckId));
            }
            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            else
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
            }
            if (publicRequest.IsSetDeviceIndex())
            {
                request.Parameters.Add("DeviceIndex", StringUtils.FromInt(publicRequest.DeviceIndex.Value));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetFailureThreshold())
            {
                request.Parameters.Add("FailureThreshold", StringUtils.FromInt(publicRequest.FailureThreshold.Value));
            }
            if (publicRequest.IsSetHealthCheckPaths())
            {
                if (publicRequest.HealthCheckPaths.Count == 0)
                {
                    request.Parameters.Add("HealthCheckPath", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.HealthCheckPaths)
                    {
                        if (item0.IsSetDestinations())
                        {
                            if (item0.Destinations.Count == 0)
                            {
                                request.Parameters.Add("HealthCheckPath" + "." + index0 + ".Destination", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Destinations)
                                {
                                    if (item1.IsSetSecurityGroupId())
                                    {
                                        request.Parameters.Add("HealthCheckPath" + "." + index0 + ".Destination" + "." + index1 + ".SecurityGroupId", StringUtils.FromString(item1.SecurityGroupId));
                                    }
                                    if (item1.IsSetSubnetId())
                                    {
                                        request.Parameters.Add("HealthCheckPath" + "." + index0 + ".Destination" + "." + index1 + ".SubnetId", StringUtils.FromString(item1.SubnetId));
                                    }
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetSource())
                        {
                            if (item0.Source.IsSetSecurityGroupId())
                            {
                                request.Parameters.Add("HealthCheckPath" + "." + index0 + ".Source" + ".SecurityGroupId", StringUtils.FromString(item0.Source.SecurityGroupId));
                            }
                            if (item0.Source.IsSetSubnetId())
                            {
                                request.Parameters.Add("HealthCheckPath" + "." + index0 + ".Source" + ".SubnetId", StringUtils.FromString(item0.Source.SubnetId));
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetInitializationGracePeriodSeconds())
            {
                request.Parameters.Add("InitializationGracePeriodSeconds", StringUtils.FromInt(publicRequest.InitializationGracePeriodSeconds.Value));
            }
            if (publicRequest.IsSetInterval())
            {
                request.Parameters.Add("Interval", StringUtils.FromInt(publicRequest.Interval.Value));
            }
            if (publicRequest.IsSetIpScope())
            {
                request.Parameters.Add("IpScope", StringUtils.FromString(publicRequest.IpScope));
            }
            if (publicRequest.IsSetIpVersion())
            {
                request.Parameters.Add("IpVersion", StringUtils.FromString(publicRequest.IpVersion));
            }
            if (publicRequest.IsSetPath())
            {
                request.Parameters.Add("Path", StringUtils.FromString(publicRequest.Path));
            }
            if (publicRequest.IsSetPort())
            {
                request.Parameters.Add("Port", StringUtils.FromInt(publicRequest.Port.Value));
            }
            if (publicRequest.IsSetProtocol())
            {
                request.Parameters.Add("Protocol", StringUtils.FromString(publicRequest.Protocol));
            }
            if (publicRequest.IsSetStatusCodeMatcher())
            {
                request.Parameters.Add("StatusCodeMatcher", StringUtils.FromString(publicRequest.StatusCodeMatcher));
            }
            if (publicRequest.IsSetSuccessThreshold())
            {
                request.Parameters.Add("SuccessThreshold", StringUtils.FromInt(publicRequest.SuccessThreshold.Value));
            }
            if (publicRequest.IsSetTimeout())
            {
                request.Parameters.Add("Timeout", StringUtils.FromInt(publicRequest.Timeout.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ModifyApplicationStatusCheckRequestMarshaller _instance = new();

        internal static ModifyApplicationStatusCheckRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyApplicationStatusCheckRequestMarshaller Instance => _instance;
    }
}

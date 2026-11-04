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

using Amazon.AutoScaling.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LaunchInstances Request Marshaller
    /// </summary>
    public partial class LaunchInstancesRequestMarshaller : IMarshaller<IRequest, LaunchInstancesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((LaunchInstancesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(LaunchInstancesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "LaunchInstances");
            request.Parameters.Add("Version", "2011-01-01");

            if (publicRequest.IsSetAutoScalingGroupName())
            {
                request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(publicRequest.AutoScalingGroupName));
            }
            if (publicRequest.IsSetAvailabilityZoneIds())
            {
                if (publicRequest.AvailabilityZoneIds.Count == 0)
                {
                    request.Parameters.Add("AvailabilityZoneIds", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AvailabilityZoneIds)
                    {
                        request.Parameters.Add("AvailabilityZoneIds" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetAvailabilityZones())
            {
                if (publicRequest.AvailabilityZones.Count == 0)
                {
                    request.Parameters.Add("AvailabilityZones", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.AvailabilityZones)
                    {
                        request.Parameters.Add("AvailabilityZones" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            else
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
            }
            if (publicRequest.IsSetRequestedCapacity())
            {
                request.Parameters.Add("RequestedCapacity", StringUtils.FromInt(publicRequest.RequestedCapacity.Value));
            }
            if (publicRequest.IsSetRetryStrategy())
            {
                request.Parameters.Add("RetryStrategy", StringUtils.FromString(publicRequest.RetryStrategy));
            }
            if (publicRequest.IsSetSubnetIds())
            {
                if (publicRequest.SubnetIds.Count == 0)
                {
                    request.Parameters.Add("SubnetIds", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.SubnetIds)
                    {
                        request.Parameters.Add("SubnetIds" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly LaunchInstancesRequestMarshaller _instance = new();

        internal static LaunchInstancesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static LaunchInstancesRequestMarshaller Instance => _instance;
    }
}

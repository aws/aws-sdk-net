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
    /// ModifyReservedInstances Request Marshaller
    /// </summary>
    public partial class ModifyReservedInstancesRequestMarshaller : IMarshaller<IRequest, ModifyReservedInstancesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyReservedInstancesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyReservedInstancesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyReservedInstances");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            if (publicRequest.IsSetReservedInstancesIds())
            {
                if (publicRequest.ReservedInstancesIds.Count == 0)
                {
                    request.Parameters.Add("ReservedInstancesId", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ReservedInstancesIds)
                    {
                        request.Parameters.Add("ReservedInstancesId" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTargetConfigurations())
            {
                if (publicRequest.TargetConfigurations.Count == 0)
                {
                    request.Parameters.Add("ReservedInstancesConfigurationSetItemType", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TargetConfigurations)
                    {
                        if (item0.IsSetAvailabilityZone())
                        {
                            request.Parameters.Add("ReservedInstancesConfigurationSetItemType" + "." + index0 + ".AvailabilityZone", StringUtils.FromString(item0.AvailabilityZone));
                        }
                        if (item0.IsSetAvailabilityZoneId())
                        {
                            request.Parameters.Add("ReservedInstancesConfigurationSetItemType" + "." + index0 + ".AvailabilityZoneId", StringUtils.FromString(item0.AvailabilityZoneId));
                        }
                        if (item0.IsSetInstanceCount())
                        {
                            request.Parameters.Add("ReservedInstancesConfigurationSetItemType" + "." + index0 + ".InstanceCount", StringUtils.FromInt(item0.InstanceCount.Value));
                        }
                        if (item0.IsSetInstanceType())
                        {
                            request.Parameters.Add("ReservedInstancesConfigurationSetItemType" + "." + index0 + ".InstanceType", StringUtils.FromString(item0.InstanceType));
                        }
                        if (item0.IsSetPlatform())
                        {
                            request.Parameters.Add("ReservedInstancesConfigurationSetItemType" + "." + index0 + ".Platform", StringUtils.FromString(item0.Platform));
                        }
                        if (item0.IsSetScope())
                        {
                            request.Parameters.Add("ReservedInstancesConfigurationSetItemType" + "." + index0 + ".Scope", StringUtils.FromString(item0.Scope));
                        }
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

        private static readonly ModifyReservedInstancesRequestMarshaller _instance = new();

        internal static ModifyReservedInstancesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyReservedInstancesRequestMarshaller Instance => _instance;
    }
}

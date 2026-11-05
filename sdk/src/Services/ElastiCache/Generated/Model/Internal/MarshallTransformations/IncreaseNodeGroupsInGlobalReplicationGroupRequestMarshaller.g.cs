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

using Amazon.ElastiCache.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// IncreaseNodeGroupsInGlobalReplicationGroup Request Marshaller
    /// </summary>
    public partial class IncreaseNodeGroupsInGlobalReplicationGroupRequestMarshaller : IMarshaller<IRequest, IncreaseNodeGroupsInGlobalReplicationGroupRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((IncreaseNodeGroupsInGlobalReplicationGroupRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(IncreaseNodeGroupsInGlobalReplicationGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "IncreaseNodeGroupsInGlobalReplicationGroup");
            request.Parameters.Add("Version", "2015-02-02");

            if (publicRequest.IsSetApplyImmediately())
            {
                request.Parameters.Add("ApplyImmediately", StringUtils.FromBool(publicRequest.ApplyImmediately.Value));
            }
            if (publicRequest.IsSetGlobalReplicationGroupId())
            {
                request.Parameters.Add("GlobalReplicationGroupId", StringUtils.FromString(publicRequest.GlobalReplicationGroupId));
            }
            if (publicRequest.IsSetNodeGroupCount())
            {
                request.Parameters.Add("NodeGroupCount", StringUtils.FromInt(publicRequest.NodeGroupCount.Value));
            }
            if (publicRequest.IsSetRegionalConfigurations())
            {
                if (publicRequest.RegionalConfigurations.Count == 0)
                {
                    request.Parameters.Add("RegionalConfigurations", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.RegionalConfigurations)
                    {
                        if (item0.IsSetReplicationGroupId())
                        {
                            request.Parameters.Add("RegionalConfigurations" + ".RegionalConfiguration" + "." + index0 + ".ReplicationGroupId", StringUtils.FromString(item0.ReplicationGroupId));
                        }
                        if (item0.IsSetReplicationGroupRegion())
                        {
                            request.Parameters.Add("RegionalConfigurations" + ".RegionalConfiguration" + "." + index0 + ".ReplicationGroupRegion", StringUtils.FromString(item0.ReplicationGroupRegion));
                        }
                        if (item0.IsSetReshardingConfiguration())
                        {
                            if (item0.ReshardingConfiguration.Count == 0)
                            {
                                request.Parameters.Add("RegionalConfigurations" + ".RegionalConfiguration" + "." + index0 + ".ReshardingConfiguration", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.ReshardingConfiguration)
                                {
                                    if (item1.IsSetNodeGroupId())
                                    {
                                        request.Parameters.Add("RegionalConfigurations" + ".RegionalConfiguration" + "." + index0 + ".ReshardingConfiguration" + ".ReshardingConfiguration" + "." + index1 + ".NodeGroupId", StringUtils.FromString(item1.NodeGroupId));
                                    }
                                    if (item1.IsSetPreferredAvailabilityZones())
                                    {
                                        if (item1.PreferredAvailabilityZones.Count == 0)
                                        {
                                            request.Parameters.Add("RegionalConfigurations" + ".RegionalConfiguration" + "." + index0 + ".ReshardingConfiguration" + ".ReshardingConfiguration" + "." + index1 + ".PreferredAvailabilityZones", "");
                                        }
                                        else
                                        {
                                            int index2 = 1;
                                            foreach (var item2 in item1.PreferredAvailabilityZones)
                                            {
                                                request.Parameters.Add("RegionalConfigurations" + ".RegionalConfiguration" + "." + index0 + ".ReshardingConfiguration" + ".ReshardingConfiguration" + "." + index1 + ".PreferredAvailabilityZones" + ".AvailabilityZone" + "." + index2, StringUtils.FromString(item2));
                                                index2++;
                                            }
                                        }
                                    }
                                    index1++;
                                }
                            }
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

        private static readonly IncreaseNodeGroupsInGlobalReplicationGroupRequestMarshaller _instance = new();

        internal static IncreaseNodeGroupsInGlobalReplicationGroupRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static IncreaseNodeGroupsInGlobalReplicationGroupRequestMarshaller Instance => _instance;
    }
}

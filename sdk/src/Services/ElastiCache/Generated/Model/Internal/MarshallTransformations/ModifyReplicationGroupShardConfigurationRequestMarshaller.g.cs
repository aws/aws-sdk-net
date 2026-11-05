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
    /// ModifyReplicationGroupShardConfiguration Request Marshaller
    /// </summary>
    public partial class ModifyReplicationGroupShardConfigurationRequestMarshaller : IMarshaller<IRequest, ModifyReplicationGroupShardConfigurationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyReplicationGroupShardConfigurationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ModifyReplicationGroupShardConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ModifyReplicationGroupShardConfiguration");
            request.Parameters.Add("Version", "2015-02-02");

            if (publicRequest.IsSetApplyImmediately())
            {
                request.Parameters.Add("ApplyImmediately", StringUtils.FromBool(publicRequest.ApplyImmediately.Value));
            }
            if (publicRequest.IsSetNodeGroupCount())
            {
                request.Parameters.Add("NodeGroupCount", StringUtils.FromInt(publicRequest.NodeGroupCount.Value));
            }
            if (publicRequest.IsSetNodeGroupsToRemove())
            {
                if (publicRequest.NodeGroupsToRemove.Count == 0)
                {
                    request.Parameters.Add("NodeGroupsToRemove", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.NodeGroupsToRemove)
                    {
                        request.Parameters.Add("NodeGroupsToRemove" + ".NodeGroupToRemove" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetNodeGroupsToRetain())
            {
                if (publicRequest.NodeGroupsToRetain.Count == 0)
                {
                    request.Parameters.Add("NodeGroupsToRetain", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.NodeGroupsToRetain)
                    {
                        request.Parameters.Add("NodeGroupsToRetain" + ".NodeGroupToRetain" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetReplicationGroupId())
            {
                request.Parameters.Add("ReplicationGroupId", StringUtils.FromString(publicRequest.ReplicationGroupId));
            }
            if (publicRequest.IsSetReshardingConfiguration())
            {
                if (publicRequest.ReshardingConfiguration.Count == 0)
                {
                    request.Parameters.Add("ReshardingConfiguration", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ReshardingConfiguration)
                    {
                        if (item0.IsSetNodeGroupId())
                        {
                            request.Parameters.Add("ReshardingConfiguration" + ".ReshardingConfiguration" + "." + index0 + ".NodeGroupId", StringUtils.FromString(item0.NodeGroupId));
                        }
                        if (item0.IsSetPreferredAvailabilityZones())
                        {
                            if (item0.PreferredAvailabilityZones.Count == 0)
                            {
                                request.Parameters.Add("ReshardingConfiguration" + ".ReshardingConfiguration" + "." + index0 + ".PreferredAvailabilityZones", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.PreferredAvailabilityZones)
                                {
                                    request.Parameters.Add("ReshardingConfiguration" + ".ReshardingConfiguration" + "." + index0 + ".PreferredAvailabilityZones" + ".AvailabilityZone" + "." + index1, StringUtils.FromString(item1));
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

        private static readonly ModifyReplicationGroupShardConfigurationRequestMarshaller _instance = new();

        internal static ModifyReplicationGroupShardConfigurationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ModifyReplicationGroupShardConfigurationRequestMarshaller Instance => _instance;
    }
}

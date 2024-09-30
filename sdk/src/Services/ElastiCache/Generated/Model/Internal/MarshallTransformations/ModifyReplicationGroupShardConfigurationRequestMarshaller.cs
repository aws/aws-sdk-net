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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyReplicationGroupShardConfiguration Request Marshaller
    /// </summary>       
    public class ModifyReplicationGroupShardConfigurationRequestMarshaller : IMarshaller<IRequest, ModifyReplicationGroupShardConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyReplicationGroupShardConfigurationRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyReplicationGroupShardConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.Parameters.Add("Action", "ModifyReplicationGroupShardConfiguration");
            request.Parameters.Add("Version", "2015-02-02");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetApplyImmediately())
                {
                    request.Parameters.Add("ApplyImmediately", StringUtils.FromBool(publicRequest.ApplyImmediately));
                }
                if(publicRequest.IsSetNodeGroupCount())
                {
                    request.Parameters.Add("NodeGroupCount", StringUtils.FromInt(publicRequest.NodeGroupCount));
                }
                if(publicRequest.IsSetNodeGroupsToRemove())
                {
                    if (publicRequest.NodeGroupsToRemove.Count == 0)
                        request.Parameters.Add("NodeGroupsToRemove", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.NodeGroupsToRemove)
                         {
                             request.Parameters.Add("NodeGroupsToRemove" + "." + "NodeGroupToRemove" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetNodeGroupsToRetain())
                {
                    if (publicRequest.NodeGroupsToRetain.Count == 0)
                        request.Parameters.Add("NodeGroupsToRetain", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.NodeGroupsToRetain)
                         {
                             request.Parameters.Add("NodeGroupsToRetain" + "." + "NodeGroupToRetain" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetReplicationGroupId())
                {
                    request.Parameters.Add("ReplicationGroupId", StringUtils.FromString(publicRequest.ReplicationGroupId));
                }
                if(publicRequest.IsSetReshardingConfiguration())
                {
                    if (publicRequest.ReshardingConfiguration.Count == 0)
                        request.Parameters.Add("ReshardingConfiguration", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ReshardingConfiguration)
                         {
                            if(publicRequestlistValue.IsSetNodeGroupId())
                            {
                                request.Parameters.Add("ReshardingConfiguration" + "." + "ReshardingConfiguration" + "." + publicRequestlistValueIndex + "." + "NodeGroupId", StringUtils.FromString(publicRequestlistValue.NodeGroupId));
                            }
                            if(publicRequestlistValue.IsSetPreferredAvailabilityZones())
                            {
                                if (publicRequestlistValue.PreferredAvailabilityZones.Count == 0)
                                    request.Parameters.Add("ReshardingConfiguration" + "." + "ReshardingConfiguration" + "." + publicRequestlistValueIndex + "." + "PreferredAvailabilityZones", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.PreferredAvailabilityZones)
                                     {
                                         request.Parameters.Add("ReshardingConfiguration" + "." + "ReshardingConfiguration" + "." + publicRequestlistValueIndex + "." + "PreferredAvailabilityZones" + "." + "AvailabilityZone" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static ModifyReplicationGroupShardConfigurationRequestMarshaller _instance = new ModifyReplicationGroupShardConfigurationRequestMarshaller();        

        internal static ModifyReplicationGroupShardConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyReplicationGroupShardConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
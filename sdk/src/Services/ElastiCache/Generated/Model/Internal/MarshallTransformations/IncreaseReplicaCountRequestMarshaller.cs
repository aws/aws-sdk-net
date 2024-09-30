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
    /// IncreaseReplicaCount Request Marshaller
    /// </summary>       
    public class IncreaseReplicaCountRequestMarshaller : IMarshaller<IRequest, IncreaseReplicaCountRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((IncreaseReplicaCountRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(IncreaseReplicaCountRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.Parameters.Add("Action", "IncreaseReplicaCount");
            request.Parameters.Add("Version", "2015-02-02");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetApplyImmediately())
                {
                    request.Parameters.Add("ApplyImmediately", StringUtils.FromBool(publicRequest.ApplyImmediately));
                }
                if(publicRequest.IsSetNewReplicaCount())
                {
                    request.Parameters.Add("NewReplicaCount", StringUtils.FromInt(publicRequest.NewReplicaCount));
                }
                if(publicRequest.IsSetReplicaConfiguration())
                {
                    if (publicRequest.ReplicaConfiguration.Count == 0)
                        request.Parameters.Add("ReplicaConfiguration", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ReplicaConfiguration)
                         {
                            if(publicRequestlistValue.IsSetNewReplicaCount())
                            {
                                request.Parameters.Add("ReplicaConfiguration" + "." + "ConfigureShard" + "." + publicRequestlistValueIndex + "." + "NewReplicaCount", StringUtils.FromInt(publicRequestlistValue.NewReplicaCount));
                            }
                            if(publicRequestlistValue.IsSetNodeGroupId())
                            {
                                request.Parameters.Add("ReplicaConfiguration" + "." + "ConfigureShard" + "." + publicRequestlistValueIndex + "." + "NodeGroupId", StringUtils.FromString(publicRequestlistValue.NodeGroupId));
                            }
                            if(publicRequestlistValue.IsSetPreferredAvailabilityZones())
                            {
                                if (publicRequestlistValue.PreferredAvailabilityZones.Count == 0)
                                    request.Parameters.Add("ReplicaConfiguration" + "." + "ConfigureShard" + "." + publicRequestlistValueIndex + "." + "PreferredAvailabilityZones", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.PreferredAvailabilityZones)
                                     {
                                         request.Parameters.Add("ReplicaConfiguration" + "." + "ConfigureShard" + "." + publicRequestlistValueIndex + "." + "PreferredAvailabilityZones" + "." + "PreferredAvailabilityZone" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                            if(publicRequestlistValue.IsSetPreferredOutpostArns())
                            {
                                if (publicRequestlistValue.PreferredOutpostArns.Count == 0)
                                    request.Parameters.Add("ReplicaConfiguration" + "." + "ConfigureShard" + "." + publicRequestlistValueIndex + "." + "PreferredOutpostArns", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.PreferredOutpostArns)
                                     {
                                         request.Parameters.Add("ReplicaConfiguration" + "." + "ConfigureShard" + "." + publicRequestlistValueIndex + "." + "PreferredOutpostArns" + "." + "PreferredOutpostArn" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetReplicationGroupId())
                {
                    request.Parameters.Add("ReplicationGroupId", StringUtils.FromString(publicRequest.ReplicationGroupId));
                }
            }
            return request;
        }
                    private static IncreaseReplicaCountRequestMarshaller _instance = new IncreaseReplicaCountRequestMarshaller();        

        internal static IncreaseReplicaCountRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IncreaseReplicaCountRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
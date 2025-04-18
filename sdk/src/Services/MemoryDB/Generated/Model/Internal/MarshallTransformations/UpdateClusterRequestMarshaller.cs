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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MemoryDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MemoryDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateCluster Request Marshaller
    /// </summary>       
    public class UpdateClusterRequestMarshaller : IMarshaller<IRequest, UpdateClusterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateClusterRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MemoryDB");
            string target = "AmazonMemoryDB.UpdateCluster";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetACLName())
                {
                    context.Writer.WritePropertyName("ACLName");
                    context.Writer.Write(publicRequest.ACLName);
                }

                if(publicRequest.IsSetClusterName())
                {
                    context.Writer.WritePropertyName("ClusterName");
                    context.Writer.Write(publicRequest.ClusterName);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEngine())
                {
                    context.Writer.WritePropertyName("Engine");
                    context.Writer.Write(publicRequest.Engine);
                }

                if(publicRequest.IsSetEngineVersion())
                {
                    context.Writer.WritePropertyName("EngineVersion");
                    context.Writer.Write(publicRequest.EngineVersion);
                }

                if(publicRequest.IsSetIpDiscovery())
                {
                    context.Writer.WritePropertyName("IpDiscovery");
                    context.Writer.Write(publicRequest.IpDiscovery);
                }

                if(publicRequest.IsSetMaintenanceWindow())
                {
                    context.Writer.WritePropertyName("MaintenanceWindow");
                    context.Writer.Write(publicRequest.MaintenanceWindow);
                }

                if(publicRequest.IsSetNodeType())
                {
                    context.Writer.WritePropertyName("NodeType");
                    context.Writer.Write(publicRequest.NodeType);
                }

                if(publicRequest.IsSetParameterGroupName())
                {
                    context.Writer.WritePropertyName("ParameterGroupName");
                    context.Writer.Write(publicRequest.ParameterGroupName);
                }

                if(publicRequest.IsSetReplicaConfiguration())
                {
                    context.Writer.WritePropertyName("ReplicaConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ReplicaConfigurationRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ReplicaConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSecurityGroupIds())
                {
                    context.Writer.WritePropertyName("SecurityGroupIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSecurityGroupIdsListValue in publicRequest.SecurityGroupIds)
                    {
                            context.Writer.Write(publicRequestSecurityGroupIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetShardConfiguration())
                {
                    context.Writer.WritePropertyName("ShardConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ShardConfigurationRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ShardConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSnapshotRetentionLimit())
                {
                    context.Writer.WritePropertyName("SnapshotRetentionLimit");
                    context.Writer.Write(publicRequest.SnapshotRetentionLimit);
                }

                if(publicRequest.IsSetSnapshotWindow())
                {
                    context.Writer.WritePropertyName("SnapshotWindow");
                    context.Writer.Write(publicRequest.SnapshotWindow);
                }

                if(publicRequest.IsSetSnsTopicArn())
                {
                    context.Writer.WritePropertyName("SnsTopicArn");
                    context.Writer.Write(publicRequest.SnsTopicArn);
                }

                if(publicRequest.IsSetSnsTopicStatus())
                {
                    context.Writer.WritePropertyName("SnsTopicStatus");
                    context.Writer.Write(publicRequest.SnsTopicStatus);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateClusterRequestMarshaller _instance = new UpdateClusterRequestMarshaller();        

        internal static UpdateClusterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateClusterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
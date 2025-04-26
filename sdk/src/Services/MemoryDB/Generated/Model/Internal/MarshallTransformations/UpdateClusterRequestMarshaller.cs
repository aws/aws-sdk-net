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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
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
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetACLName())
            {
                context.Writer.WritePropertyName("ACLName");
                context.Writer.WriteStringValue(publicRequest.ACLName);
            }

            if(publicRequest.IsSetClusterName())
            {
                context.Writer.WritePropertyName("ClusterName");
                context.Writer.WriteStringValue(publicRequest.ClusterName);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEngine())
            {
                context.Writer.WritePropertyName("Engine");
                context.Writer.WriteStringValue(publicRequest.Engine);
            }

            if(publicRequest.IsSetEngineVersion())
            {
                context.Writer.WritePropertyName("EngineVersion");
                context.Writer.WriteStringValue(publicRequest.EngineVersion);
            }

            if(publicRequest.IsSetIpDiscovery())
            {
                context.Writer.WritePropertyName("IpDiscovery");
                context.Writer.WriteStringValue(publicRequest.IpDiscovery);
            }

            if(publicRequest.IsSetMaintenanceWindow())
            {
                context.Writer.WritePropertyName("MaintenanceWindow");
                context.Writer.WriteStringValue(publicRequest.MaintenanceWindow);
            }

            if(publicRequest.IsSetNodeType())
            {
                context.Writer.WritePropertyName("NodeType");
                context.Writer.WriteStringValue(publicRequest.NodeType);
            }

            if(publicRequest.IsSetParameterGroupName())
            {
                context.Writer.WritePropertyName("ParameterGroupName");
                context.Writer.WriteStringValue(publicRequest.ParameterGroupName);
            }

            if(publicRequest.IsSetReplicaConfiguration())
            {
                context.Writer.WritePropertyName("ReplicaConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ReplicaConfigurationRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.ReplicaConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSecurityGroupIds())
            {
                context.Writer.WritePropertyName("SecurityGroupIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSecurityGroupIdsListValue in publicRequest.SecurityGroupIds)
                {
                        context.Writer.WriteStringValue(publicRequestSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetShardConfiguration())
            {
                context.Writer.WritePropertyName("ShardConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ShardConfigurationRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.ShardConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSnapshotRetentionLimit())
            {
                context.Writer.WritePropertyName("SnapshotRetentionLimit");
                context.Writer.WriteNumberValue(publicRequest.SnapshotRetentionLimit.Value);
            }

            if(publicRequest.IsSetSnapshotWindow())
            {
                context.Writer.WritePropertyName("SnapshotWindow");
                context.Writer.WriteStringValue(publicRequest.SnapshotWindow);
            }

            if(publicRequest.IsSetSnsTopicArn())
            {
                context.Writer.WritePropertyName("SnsTopicArn");
                context.Writer.WriteStringValue(publicRequest.SnsTopicArn);
            }

            if(publicRequest.IsSetSnsTopicStatus())
            {
                context.Writer.WritePropertyName("SnsTopicStatus");
                context.Writer.WriteStringValue(publicRequest.SnsTopicStatus);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


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
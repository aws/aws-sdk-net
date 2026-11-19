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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.MemoryDB.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.MemoryDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateCluster Request Marshaller
    /// </summary>
    public partial class UpdateClusterRequestMarshaller : IMarshaller<IRequest, UpdateClusterRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateClusterRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MemoryDB");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/AmazonMemoryDB/operation/UpdateCluster";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetACLName())
                {
                    context.Writer.WriteTextString("ACLName");
                    context.Writer.WriteTextString(publicRequest.ACLName);
                }
                if (publicRequest.IsSetClusterName())
                {
                    context.Writer.WriteTextString("ClusterName");
                    context.Writer.WriteTextString(publicRequest.ClusterName);
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("Description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetEngine())
                {
                    context.Writer.WriteTextString("Engine");
                    context.Writer.WriteTextString(publicRequest.Engine);
                }
                if (publicRequest.IsSetEngineVersion())
                {
                    context.Writer.WriteTextString("EngineVersion");
                    context.Writer.WriteTextString(publicRequest.EngineVersion);
                }
                if (publicRequest.IsSetIpDiscovery())
                {
                    context.Writer.WriteTextString("IpDiscovery");
                    context.Writer.WriteTextString(publicRequest.IpDiscovery);
                }
                if (publicRequest.IsSetMaintenanceWindow())
                {
                    context.Writer.WriteTextString("MaintenanceWindow");
                    context.Writer.WriteTextString(publicRequest.MaintenanceWindow);
                }
                if (publicRequest.IsSetNodeType())
                {
                    context.Writer.WriteTextString("NodeType");
                    context.Writer.WriteTextString(publicRequest.NodeType);
                }
                if (publicRequest.IsSetParameterGroupName())
                {
                    context.Writer.WriteTextString("ParameterGroupName");
                    context.Writer.WriteTextString(publicRequest.ParameterGroupName);
                }
                if (publicRequest.IsSetReplicaConfiguration())
                {
                    context.Writer.WriteTextString("ReplicaConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ReplicaConfigurationRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ReplicaConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetSecurityGroupIds())
                {
                    context.Writer.WriteTextString("SecurityGroupIds");
                    context.Writer.WriteStartArray(publicRequest.SecurityGroupIds.Count);
                    foreach (var publicRequestSecurityGroupIdsListValue in publicRequest.SecurityGroupIds)
                    {
                        context.Writer.WriteTextString(publicRequestSecurityGroupIdsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetShardConfiguration())
                {
                    context.Writer.WriteTextString("ShardConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ShardConfigurationRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ShardConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetSnapshotRetentionLimit())
                {
                    context.Writer.WriteTextString("SnapshotRetentionLimit");
                    context.Writer.WriteInt32(publicRequest.SnapshotRetentionLimit.Value);
                }
                if (publicRequest.IsSetSnapshotWindow())
                {
                    context.Writer.WriteTextString("SnapshotWindow");
                    context.Writer.WriteTextString(publicRequest.SnapshotWindow);
                }
                if (publicRequest.IsSetSnsTopicArn())
                {
                    context.Writer.WriteTextString("SnsTopicArn");
                    context.Writer.WriteTextString(publicRequest.SnsTopicArn);
                }
                if (publicRequest.IsSetSnsTopicStatus())
                {
                    context.Writer.WriteTextString("SnsTopicStatus");
                    context.Writer.WriteTextString(publicRequest.SnsTopicStatus);
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }

            return request;
        }

        private static readonly UpdateClusterRequestMarshaller _instance = new();

        internal static UpdateClusterRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateClusterRequestMarshaller Instance => _instance;
    }
}

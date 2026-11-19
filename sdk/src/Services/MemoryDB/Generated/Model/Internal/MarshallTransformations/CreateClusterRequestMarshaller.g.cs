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
    /// CreateCluster Request Marshaller
    /// </summary>
    public partial class CreateClusterRequestMarshaller : IMarshaller<IRequest, CreateClusterRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateClusterRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MemoryDB");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/AmazonMemoryDB/operation/CreateCluster";
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
                if (publicRequest.IsSetAutoMinorVersionUpgrade())
                {
                    context.Writer.WriteTextString("AutoMinorVersionUpgrade");
                    context.Writer.WriteBoolean(publicRequest.AutoMinorVersionUpgrade.Value);
                }
                if (publicRequest.IsSetClusterName())
                {
                    context.Writer.WriteTextString("ClusterName");
                    context.Writer.WriteTextString(publicRequest.ClusterName);
                }
                if (publicRequest.IsSetDataTiering())
                {
                    context.Writer.WriteTextString("DataTiering");
                    context.Writer.WriteBoolean(publicRequest.DataTiering.Value);
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
                if (publicRequest.IsSetKmsKeyId())
                {
                    context.Writer.WriteTextString("KmsKeyId");
                    context.Writer.WriteTextString(publicRequest.KmsKeyId);
                }
                if (publicRequest.IsSetMaintenanceWindow())
                {
                    context.Writer.WriteTextString("MaintenanceWindow");
                    context.Writer.WriteTextString(publicRequest.MaintenanceWindow);
                }
                if (publicRequest.IsSetMultiRegionClusterName())
                {
                    context.Writer.WriteTextString("MultiRegionClusterName");
                    context.Writer.WriteTextString(publicRequest.MultiRegionClusterName);
                }
                if (publicRequest.IsSetNetworkType())
                {
                    context.Writer.WriteTextString("NetworkType");
                    context.Writer.WriteTextString(publicRequest.NetworkType);
                }
                if (publicRequest.IsSetNodeType())
                {
                    context.Writer.WriteTextString("NodeType");
                    context.Writer.WriteTextString(publicRequest.NodeType);
                }
                if (publicRequest.IsSetNumReplicasPerShard())
                {
                    context.Writer.WriteTextString("NumReplicasPerShard");
                    context.Writer.WriteInt32(publicRequest.NumReplicasPerShard.Value);
                }
                if (publicRequest.IsSetNumShards())
                {
                    context.Writer.WriteTextString("NumShards");
                    context.Writer.WriteInt32(publicRequest.NumShards.Value);
                }
                if (publicRequest.IsSetParameterGroupName())
                {
                    context.Writer.WriteTextString("ParameterGroupName");
                    context.Writer.WriteTextString(publicRequest.ParameterGroupName);
                }
                if (publicRequest.IsSetPort())
                {
                    context.Writer.WriteTextString("Port");
                    context.Writer.WriteInt32(publicRequest.Port.Value);
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
                if (publicRequest.IsSetSnapshotArns())
                {
                    context.Writer.WriteTextString("SnapshotArns");
                    context.Writer.WriteStartArray(publicRequest.SnapshotArns.Count);
                    foreach (var publicRequestSnapshotArnsListValue in publicRequest.SnapshotArns)
                    {
                        context.Writer.WriteTextString(publicRequestSnapshotArnsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetSnapshotName())
                {
                    context.Writer.WriteTextString("SnapshotName");
                    context.Writer.WriteTextString(publicRequest.SnapshotName);
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
                if (publicRequest.IsSetSubnetGroupName())
                {
                    context.Writer.WriteTextString("SubnetGroupName");
                    context.Writer.WriteTextString(publicRequest.SubnetGroupName);
                }
                if (publicRequest.IsSetTLSEnabled())
                {
                    context.Writer.WriteTextString("TLSEnabled");
                    context.Writer.WriteBoolean(publicRequest.TLSEnabled.Value);
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("Tags");
                    context.Writer.WriteStartArray(publicRequest.Tags.Count);
                    foreach (var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
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

        private static readonly CreateClusterRequestMarshaller _instance = new();

        internal static CreateClusterRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateClusterRequestMarshaller Instance => _instance;
    }
}

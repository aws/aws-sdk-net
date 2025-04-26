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
    /// CreateCluster Request Marshaller
    /// </summary>       
    public class CreateClusterRequestMarshaller : IMarshaller<IRequest, CreateClusterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateClusterRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MemoryDB");
            string target = "AmazonMemoryDB.CreateCluster";
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

            if(publicRequest.IsSetAutoMinorVersionUpgrade())
            {
                context.Writer.WritePropertyName("AutoMinorVersionUpgrade");
                context.Writer.WriteBooleanValue(publicRequest.AutoMinorVersionUpgrade.Value);
            }

            if(publicRequest.IsSetClusterName())
            {
                context.Writer.WritePropertyName("ClusterName");
                context.Writer.WriteStringValue(publicRequest.ClusterName);
            }

            if(publicRequest.IsSetDataTiering())
            {
                context.Writer.WritePropertyName("DataTiering");
                context.Writer.WriteBooleanValue(publicRequest.DataTiering.Value);
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

            if(publicRequest.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.WriteStringValue(publicRequest.KmsKeyId);
            }

            if(publicRequest.IsSetMaintenanceWindow())
            {
                context.Writer.WritePropertyName("MaintenanceWindow");
                context.Writer.WriteStringValue(publicRequest.MaintenanceWindow);
            }

            if(publicRequest.IsSetMultiRegionClusterName())
            {
                context.Writer.WritePropertyName("MultiRegionClusterName");
                context.Writer.WriteStringValue(publicRequest.MultiRegionClusterName);
            }

            if(publicRequest.IsSetNetworkType())
            {
                context.Writer.WritePropertyName("NetworkType");
                context.Writer.WriteStringValue(publicRequest.NetworkType);
            }

            if(publicRequest.IsSetNodeType())
            {
                context.Writer.WritePropertyName("NodeType");
                context.Writer.WriteStringValue(publicRequest.NodeType);
            }

            if(publicRequest.IsSetNumReplicasPerShard())
            {
                context.Writer.WritePropertyName("NumReplicasPerShard");
                context.Writer.WriteNumberValue(publicRequest.NumReplicasPerShard.Value);
            }

            if(publicRequest.IsSetNumShards())
            {
                context.Writer.WritePropertyName("NumShards");
                context.Writer.WriteNumberValue(publicRequest.NumShards.Value);
            }

            if(publicRequest.IsSetParameterGroupName())
            {
                context.Writer.WritePropertyName("ParameterGroupName");
                context.Writer.WriteStringValue(publicRequest.ParameterGroupName);
            }

            if(publicRequest.IsSetPort())
            {
                context.Writer.WritePropertyName("Port");
                context.Writer.WriteNumberValue(publicRequest.Port.Value);
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

            if(publicRequest.IsSetSnapshotArns())
            {
                context.Writer.WritePropertyName("SnapshotArns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSnapshotArnsListValue in publicRequest.SnapshotArns)
                {
                        context.Writer.WriteStringValue(publicRequestSnapshotArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSnapshotName())
            {
                context.Writer.WritePropertyName("SnapshotName");
                context.Writer.WriteStringValue(publicRequest.SnapshotName);
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

            if(publicRequest.IsSetSubnetGroupName())
            {
                context.Writer.WritePropertyName("SubnetGroupName");
                context.Writer.WriteStringValue(publicRequest.SubnetGroupName);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTLSEnabled())
            {
                context.Writer.WritePropertyName("TLSEnabled");
                context.Writer.WriteBooleanValue(publicRequest.TLSEnabled.Value);
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
        private static CreateClusterRequestMarshaller _instance = new CreateClusterRequestMarshaller();        

        internal static CreateClusterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateClusterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
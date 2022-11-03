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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetACLName())
                {
                    context.Writer.WritePropertyName("ACLName");
                    context.Writer.Write(publicRequest.ACLName);
                }

                if(publicRequest.IsSetAutoMinorVersionUpgrade())
                {
                    context.Writer.WritePropertyName("AutoMinorVersionUpgrade");
                    context.Writer.Write(publicRequest.AutoMinorVersionUpgrade);
                }

                if(publicRequest.IsSetClusterName())
                {
                    context.Writer.WritePropertyName("ClusterName");
                    context.Writer.Write(publicRequest.ClusterName);
                }

                if(publicRequest.IsSetDataTiering())
                {
                    context.Writer.WritePropertyName("DataTiering");
                    context.Writer.Write(publicRequest.DataTiering);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEngineVersion())
                {
                    context.Writer.WritePropertyName("EngineVersion");
                    context.Writer.Write(publicRequest.EngineVersion);
                }

                if(publicRequest.IsSetKmsKeyId())
                {
                    context.Writer.WritePropertyName("KmsKeyId");
                    context.Writer.Write(publicRequest.KmsKeyId);
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

                if(publicRequest.IsSetNumReplicasPerShard())
                {
                    context.Writer.WritePropertyName("NumReplicasPerShard");
                    context.Writer.Write(publicRequest.NumReplicasPerShard);
                }

                if(publicRequest.IsSetNumShards())
                {
                    context.Writer.WritePropertyName("NumShards");
                    context.Writer.Write(publicRequest.NumShards);
                }

                if(publicRequest.IsSetParameterGroupName())
                {
                    context.Writer.WritePropertyName("ParameterGroupName");
                    context.Writer.Write(publicRequest.ParameterGroupName);
                }

                if(publicRequest.IsSetPort())
                {
                    context.Writer.WritePropertyName("Port");
                    context.Writer.Write(publicRequest.Port);
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

                if(publicRequest.IsSetSnapshotArns())
                {
                    context.Writer.WritePropertyName("SnapshotArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSnapshotArnsListValue in publicRequest.SnapshotArns)
                    {
                            context.Writer.Write(publicRequestSnapshotArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSnapshotName())
                {
                    context.Writer.WritePropertyName("SnapshotName");
                    context.Writer.Write(publicRequest.SnapshotName);
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

                if(publicRequest.IsSetSubnetGroupName())
                {
                    context.Writer.WritePropertyName("SubnetGroupName");
                    context.Writer.Write(publicRequest.SubnetGroupName);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTLSEnabled())
                {
                    context.Writer.WritePropertyName("TLSEnabled");
                    context.Writer.Write(publicRequest.TLSEnabled);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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
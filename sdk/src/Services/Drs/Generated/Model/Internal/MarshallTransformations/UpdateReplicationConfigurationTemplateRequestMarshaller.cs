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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Drs.Model;
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
namespace Amazon.Drs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateReplicationConfigurationTemplate Request Marshaller
    /// </summary>       
    public class UpdateReplicationConfigurationTemplateRequestMarshaller : IMarshaller<IRequest, UpdateReplicationConfigurationTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateReplicationConfigurationTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateReplicationConfigurationTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Drs");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-02-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/UpdateReplicationConfigurationTemplate";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetArn())
            {
                context.Writer.WritePropertyName("arn");
                context.Writer.WriteStringValue(publicRequest.Arn);
            }

            if(publicRequest.IsSetAssociateDefaultSecurityGroup())
            {
                context.Writer.WritePropertyName("associateDefaultSecurityGroup");
                context.Writer.WriteBooleanValue(publicRequest.AssociateDefaultSecurityGroup.Value);
            }

            if(publicRequest.IsSetAutoReplicateNewDisks())
            {
                context.Writer.WritePropertyName("autoReplicateNewDisks");
                context.Writer.WriteBooleanValue(publicRequest.AutoReplicateNewDisks.Value);
            }

            if(publicRequest.IsSetBandwidthThrottling())
            {
                context.Writer.WritePropertyName("bandwidthThrottling");
                context.Writer.WriteNumberValue(publicRequest.BandwidthThrottling.Value);
            }

            if(publicRequest.IsSetCreatePublicIP())
            {
                context.Writer.WritePropertyName("createPublicIP");
                context.Writer.WriteBooleanValue(publicRequest.CreatePublicIP.Value);
            }

            if(publicRequest.IsSetDataPlaneRouting())
            {
                context.Writer.WritePropertyName("dataPlaneRouting");
                context.Writer.WriteStringValue(publicRequest.DataPlaneRouting);
            }

            if(publicRequest.IsSetDefaultLargeStagingDiskType())
            {
                context.Writer.WritePropertyName("defaultLargeStagingDiskType");
                context.Writer.WriteStringValue(publicRequest.DefaultLargeStagingDiskType);
            }

            if(publicRequest.IsSetEbsEncryption())
            {
                context.Writer.WritePropertyName("ebsEncryption");
                context.Writer.WriteStringValue(publicRequest.EbsEncryption);
            }

            if(publicRequest.IsSetEbsEncryptionKeyArn())
            {
                context.Writer.WritePropertyName("ebsEncryptionKeyArn");
                context.Writer.WriteStringValue(publicRequest.EbsEncryptionKeyArn);
            }

            if(publicRequest.IsSetPitPolicy())
            {
                context.Writer.WritePropertyName("pitPolicy");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPitPolicyListValue in publicRequest.PitPolicy)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PITPolicyRuleMarshaller.Instance;
                    marshaller.Marshall(publicRequestPitPolicyListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetReplicationConfigurationTemplateID())
            {
                context.Writer.WritePropertyName("replicationConfigurationTemplateID");
                context.Writer.WriteStringValue(publicRequest.ReplicationConfigurationTemplateID);
            }

            if(publicRequest.IsSetReplicationServerInstanceType())
            {
                context.Writer.WritePropertyName("replicationServerInstanceType");
                context.Writer.WriteStringValue(publicRequest.ReplicationServerInstanceType);
            }

            if(publicRequest.IsSetReplicationServersSecurityGroupsIDs())
            {
                context.Writer.WritePropertyName("replicationServersSecurityGroupsIDs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestReplicationServersSecurityGroupsIDsListValue in publicRequest.ReplicationServersSecurityGroupsIDs)
                {
                        context.Writer.WriteStringValue(publicRequestReplicationServersSecurityGroupsIDsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetStagingAreaSubnetId())
            {
                context.Writer.WritePropertyName("stagingAreaSubnetId");
                context.Writer.WriteStringValue(publicRequest.StagingAreaSubnetId);
            }

            if(publicRequest.IsSetStagingAreaTags())
            {
                context.Writer.WritePropertyName("stagingAreaTags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestStagingAreaTagsKvp in publicRequest.StagingAreaTags)
                {
                    context.Writer.WritePropertyName(publicRequestStagingAreaTagsKvp.Key);
                    var publicRequestStagingAreaTagsValue = publicRequestStagingAreaTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestStagingAreaTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetUseDedicatedReplicationServer())
            {
                context.Writer.WritePropertyName("useDedicatedReplicationServer");
                context.Writer.WriteBooleanValue(publicRequest.UseDedicatedReplicationServer.Value);
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
        private static UpdateReplicationConfigurationTemplateRequestMarshaller _instance = new UpdateReplicationConfigurationTemplateRequestMarshaller();        

        internal static UpdateReplicationConfigurationTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateReplicationConfigurationTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
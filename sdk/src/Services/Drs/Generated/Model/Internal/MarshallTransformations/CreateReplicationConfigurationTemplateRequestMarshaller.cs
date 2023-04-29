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
using ThirdParty.Json.LitJson;

namespace Amazon.Drs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateReplicationConfigurationTemplate Request Marshaller
    /// </summary>       
    public class CreateReplicationConfigurationTemplateRequestMarshaller : IMarshaller<IRequest, CreateReplicationConfigurationTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateReplicationConfigurationTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateReplicationConfigurationTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Drs");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-02-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/CreateReplicationConfigurationTemplate";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAssociateDefaultSecurityGroup())
                {
                    context.Writer.WritePropertyName("associateDefaultSecurityGroup");
                    context.Writer.Write(publicRequest.AssociateDefaultSecurityGroup);
                }

                if(publicRequest.IsSetAutoReplicateNewDisks())
                {
                    context.Writer.WritePropertyName("autoReplicateNewDisks");
                    context.Writer.Write(publicRequest.AutoReplicateNewDisks);
                }

                if(publicRequest.IsSetBandwidthThrottling())
                {
                    context.Writer.WritePropertyName("bandwidthThrottling");
                    context.Writer.Write(publicRequest.BandwidthThrottling);
                }

                if(publicRequest.IsSetCreatePublicIP())
                {
                    context.Writer.WritePropertyName("createPublicIP");
                    context.Writer.Write(publicRequest.CreatePublicIP);
                }

                if(publicRequest.IsSetDataPlaneRouting())
                {
                    context.Writer.WritePropertyName("dataPlaneRouting");
                    context.Writer.Write(publicRequest.DataPlaneRouting);
                }

                if(publicRequest.IsSetDefaultLargeStagingDiskType())
                {
                    context.Writer.WritePropertyName("defaultLargeStagingDiskType");
                    context.Writer.Write(publicRequest.DefaultLargeStagingDiskType);
                }

                if(publicRequest.IsSetEbsEncryption())
                {
                    context.Writer.WritePropertyName("ebsEncryption");
                    context.Writer.Write(publicRequest.EbsEncryption);
                }

                if(publicRequest.IsSetEbsEncryptionKeyArn())
                {
                    context.Writer.WritePropertyName("ebsEncryptionKeyArn");
                    context.Writer.Write(publicRequest.EbsEncryptionKeyArn);
                }

                if(publicRequest.IsSetPitPolicy())
                {
                    context.Writer.WritePropertyName("pitPolicy");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPitPolicyListValue in publicRequest.PitPolicy)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = PITPolicyRuleMarshaller.Instance;
                        marshaller.Marshall(publicRequestPitPolicyListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetReplicationServerInstanceType())
                {
                    context.Writer.WritePropertyName("replicationServerInstanceType");
                    context.Writer.Write(publicRequest.ReplicationServerInstanceType);
                }

                if(publicRequest.IsSetReplicationServersSecurityGroupsIDs())
                {
                    context.Writer.WritePropertyName("replicationServersSecurityGroupsIDs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestReplicationServersSecurityGroupsIDsListValue in publicRequest.ReplicationServersSecurityGroupsIDs)
                    {
                            context.Writer.Write(publicRequestReplicationServersSecurityGroupsIDsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetStagingAreaSubnetId())
                {
                    context.Writer.WritePropertyName("stagingAreaSubnetId");
                    context.Writer.Write(publicRequest.StagingAreaSubnetId);
                }

                if(publicRequest.IsSetStagingAreaTags())
                {
                    context.Writer.WritePropertyName("stagingAreaTags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestStagingAreaTagsKvp in publicRequest.StagingAreaTags)
                    {
                        context.Writer.WritePropertyName(publicRequestStagingAreaTagsKvp.Key);
                        var publicRequestStagingAreaTagsValue = publicRequestStagingAreaTagsKvp.Value;

                            context.Writer.Write(publicRequestStagingAreaTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetUseDedicatedReplicationServer())
                {
                    context.Writer.WritePropertyName("useDedicatedReplicationServer");
                    context.Writer.Write(publicRequest.UseDedicatedReplicationServer);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateReplicationConfigurationTemplateRequestMarshaller _instance = new CreateReplicationConfigurationTemplateRequestMarshaller();        

        internal static CreateReplicationConfigurationTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateReplicationConfigurationTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
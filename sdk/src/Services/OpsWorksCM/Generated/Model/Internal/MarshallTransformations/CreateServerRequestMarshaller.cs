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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorksCM.Model;
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
namespace Amazon.OpsWorksCM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateServer Request Marshaller
    /// </summary>       
    public class CreateServerRequestMarshaller : IMarshaller<IRequest, CreateServerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateServerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateServerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpsWorksCM");
            string target = "OpsWorksCM_V2016_11_01.CreateServer";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-01";
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
            if(publicRequest.IsSetAssociatePublicIpAddress())
            {
                context.Writer.WritePropertyName("AssociatePublicIpAddress");
                context.Writer.WriteBooleanValue(publicRequest.AssociatePublicIpAddress.Value);
            }

            if(publicRequest.IsSetBackupId())
            {
                context.Writer.WritePropertyName("BackupId");
                context.Writer.WriteStringValue(publicRequest.BackupId);
            }

            if(publicRequest.IsSetBackupRetentionCount())
            {
                context.Writer.WritePropertyName("BackupRetentionCount");
                context.Writer.WriteNumberValue(publicRequest.BackupRetentionCount.Value);
            }

            if(publicRequest.IsSetCustomCertificate())
            {
                context.Writer.WritePropertyName("CustomCertificate");
                context.Writer.WriteStringValue(publicRequest.CustomCertificate);
            }

            if(publicRequest.IsSetCustomDomain())
            {
                context.Writer.WritePropertyName("CustomDomain");
                context.Writer.WriteStringValue(publicRequest.CustomDomain);
            }

            if(publicRequest.IsSetCustomPrivateKey())
            {
                context.Writer.WritePropertyName("CustomPrivateKey");
                context.Writer.WriteStringValue(publicRequest.CustomPrivateKey);
            }

            if(publicRequest.IsSetDisableAutomatedBackup())
            {
                context.Writer.WritePropertyName("DisableAutomatedBackup");
                context.Writer.WriteBooleanValue(publicRequest.DisableAutomatedBackup.Value);
            }

            if(publicRequest.IsSetEngine())
            {
                context.Writer.WritePropertyName("Engine");
                context.Writer.WriteStringValue(publicRequest.Engine);
            }

            if(publicRequest.IsSetEngineAttributes())
            {
                context.Writer.WritePropertyName("EngineAttributes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEngineAttributesListValue in publicRequest.EngineAttributes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EngineAttributeMarshaller.Instance;
                    marshaller.Marshall(publicRequestEngineAttributesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetEngineModel())
            {
                context.Writer.WritePropertyName("EngineModel");
                context.Writer.WriteStringValue(publicRequest.EngineModel);
            }

            if(publicRequest.IsSetEngineVersion())
            {
                context.Writer.WritePropertyName("EngineVersion");
                context.Writer.WriteStringValue(publicRequest.EngineVersion);
            }

            if(publicRequest.IsSetInstanceProfileArn())
            {
                context.Writer.WritePropertyName("InstanceProfileArn");
                context.Writer.WriteStringValue(publicRequest.InstanceProfileArn);
            }

            if(publicRequest.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("InstanceType");
                context.Writer.WriteStringValue(publicRequest.InstanceType);
            }

            if(publicRequest.IsSetKeyPair())
            {
                context.Writer.WritePropertyName("KeyPair");
                context.Writer.WriteStringValue(publicRequest.KeyPair);
            }

            if(publicRequest.IsSetPreferredBackupWindow())
            {
                context.Writer.WritePropertyName("PreferredBackupWindow");
                context.Writer.WriteStringValue(publicRequest.PreferredBackupWindow);
            }

            if(publicRequest.IsSetPreferredMaintenanceWindow())
            {
                context.Writer.WritePropertyName("PreferredMaintenanceWindow");
                context.Writer.WriteStringValue(publicRequest.PreferredMaintenanceWindow);
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

            if(publicRequest.IsSetServerName())
            {
                context.Writer.WritePropertyName("ServerName");
                context.Writer.WriteStringValue(publicRequest.ServerName);
            }

            if(publicRequest.IsSetServiceRoleArn())
            {
                context.Writer.WritePropertyName("ServiceRoleArn");
                context.Writer.WriteStringValue(publicRequest.ServiceRoleArn);
            }

            if(publicRequest.IsSetSubnetIds())
            {
                context.Writer.WritePropertyName("SubnetIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSubnetIdsListValue in publicRequest.SubnetIds)
                {
                        context.Writer.WriteStringValue(publicRequestSubnetIdsListValue);
                }
                context.Writer.WriteEndArray();
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
        private static CreateServerRequestMarshaller _instance = new CreateServerRequestMarshaller();        

        internal static CreateServerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateServerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Odb.Model;
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
namespace Amazon.Odb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCloudVmCluster Request Marshaller
    /// </summary>       
    public class CreateCloudVmClusterRequestMarshaller : IMarshaller<IRequest, CreateCloudVmClusterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCloudVmClusterRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCloudVmClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Odb");
            string target = "Odb.CreateCloudVmCluster";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-08-20";
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
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetCloudExadataInfrastructureId())
            {
                context.Writer.WritePropertyName("cloudExadataInfrastructureId");
                context.Writer.WriteStringValue(publicRequest.CloudExadataInfrastructureId);
            }

            if(publicRequest.IsSetClusterName())
            {
                context.Writer.WritePropertyName("clusterName");
                context.Writer.WriteStringValue(publicRequest.ClusterName);
            }

            if(publicRequest.IsSetCpuCoreCount())
            {
                context.Writer.WritePropertyName("cpuCoreCount");
                context.Writer.WriteNumberValue(publicRequest.CpuCoreCount.Value);
            }

            if(publicRequest.IsSetDataCollectionOptions())
            {
                context.Writer.WritePropertyName("dataCollectionOptions");
                context.Writer.WriteStartObject();

                var marshaller = DataCollectionOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataCollectionOptions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDataStorageSizeInTBs())
            {
                context.Writer.WritePropertyName("dataStorageSizeInTBs");
                if(StringUtils.IsSpecialDoubleValue(publicRequest.DataStorageSizeInTBs.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(publicRequest.DataStorageSizeInTBs.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.DataStorageSizeInTBs.Value);
                }
            }

            if(publicRequest.IsSetDbNodeStorageSizeInGBs())
            {
                context.Writer.WritePropertyName("dbNodeStorageSizeInGBs");
                context.Writer.WriteNumberValue(publicRequest.DbNodeStorageSizeInGBs.Value);
            }

            if(publicRequest.IsSetDbServers())
            {
                context.Writer.WritePropertyName("dbServers");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDbServersListValue in publicRequest.DbServers)
                {
                        context.Writer.WriteStringValue(publicRequestDbServersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDisplayName())
            {
                context.Writer.WritePropertyName("displayName");
                context.Writer.WriteStringValue(publicRequest.DisplayName);
            }

            if(publicRequest.IsSetGiVersion())
            {
                context.Writer.WritePropertyName("giVersion");
                context.Writer.WriteStringValue(publicRequest.GiVersion);
            }

            if(publicRequest.IsSetHostname())
            {
                context.Writer.WritePropertyName("hostname");
                context.Writer.WriteStringValue(publicRequest.Hostname);
            }

            if(publicRequest.IsSetIsLocalBackupEnabled())
            {
                context.Writer.WritePropertyName("isLocalBackupEnabled");
                context.Writer.WriteBooleanValue(publicRequest.IsLocalBackupEnabled.Value);
            }

            if(publicRequest.IsSetIsSparseDiskgroupEnabled())
            {
                context.Writer.WritePropertyName("isSparseDiskgroupEnabled");
                context.Writer.WriteBooleanValue(publicRequest.IsSparseDiskgroupEnabled.Value);
            }

            if(publicRequest.IsSetLicenseModel())
            {
                context.Writer.WritePropertyName("licenseModel");
                context.Writer.WriteStringValue(publicRequest.LicenseModel);
            }

            if(publicRequest.IsSetMemorySizeInGBs())
            {
                context.Writer.WritePropertyName("memorySizeInGBs");
                context.Writer.WriteNumberValue(publicRequest.MemorySizeInGBs.Value);
            }

            if(publicRequest.IsSetOdbNetworkId())
            {
                context.Writer.WritePropertyName("odbNetworkId");
                context.Writer.WriteStringValue(publicRequest.OdbNetworkId);
            }

            if(publicRequest.IsSetScanListenerPortTcp())
            {
                context.Writer.WritePropertyName("scanListenerPortTcp");
                context.Writer.WriteNumberValue(publicRequest.ScanListenerPortTcp.Value);
            }

            if(publicRequest.IsSetSshPublicKeys())
            {
                context.Writer.WritePropertyName("sshPublicKeys");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSshPublicKeysListValue in publicRequest.SshPublicKeys)
                {
                        context.Writer.WriteStringValue(publicRequestSshPublicKeysListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSystemVersion())
            {
                context.Writer.WritePropertyName("systemVersion");
                context.Writer.WriteStringValue(publicRequest.SystemVersion);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTimeZone())
            {
                context.Writer.WritePropertyName("timeZone");
                context.Writer.WriteStringValue(publicRequest.TimeZone);
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
        private static CreateCloudVmClusterRequestMarshaller _instance = new CreateCloudVmClusterRequestMarshaller();        

        internal static CreateCloudVmClusterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCloudVmClusterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
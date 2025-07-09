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
    /// CreateCloudAutonomousVmCluster Request Marshaller
    /// </summary>       
    public class CreateCloudAutonomousVmClusterRequestMarshaller : IMarshaller<IRequest, CreateCloudAutonomousVmClusterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCloudAutonomousVmClusterRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCloudAutonomousVmClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Odb");
            string target = "Odb.CreateCloudAutonomousVmCluster";
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
            if(publicRequest.IsSetAutonomousDataStorageSizeInTBs())
            {
                context.Writer.WritePropertyName("autonomousDataStorageSizeInTBs");
                if(StringUtils.IsSpecialDoubleValue(publicRequest.AutonomousDataStorageSizeInTBs.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(publicRequest.AutonomousDataStorageSizeInTBs.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.AutonomousDataStorageSizeInTBs.Value);
                }
            }

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

            if(publicRequest.IsSetCpuCoreCountPerNode())
            {
                context.Writer.WritePropertyName("cpuCoreCountPerNode");
                context.Writer.WriteNumberValue(publicRequest.CpuCoreCountPerNode.Value);
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

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDisplayName())
            {
                context.Writer.WritePropertyName("displayName");
                context.Writer.WriteStringValue(publicRequest.DisplayName);
            }

            if(publicRequest.IsSetIsMtlsEnabledVmCluster())
            {
                context.Writer.WritePropertyName("isMtlsEnabledVmCluster");
                context.Writer.WriteBooleanValue(publicRequest.IsMtlsEnabledVmCluster.Value);
            }

            if(publicRequest.IsSetLicenseModel())
            {
                context.Writer.WritePropertyName("licenseModel");
                context.Writer.WriteStringValue(publicRequest.LicenseModel);
            }

            if(publicRequest.IsSetMaintenanceWindow())
            {
                context.Writer.WritePropertyName("maintenanceWindow");
                context.Writer.WriteStartObject();

                var marshaller = MaintenanceWindowMarshaller.Instance;
                marshaller.Marshall(publicRequest.MaintenanceWindow, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMemoryPerOracleComputeUnitInGBs())
            {
                context.Writer.WritePropertyName("memoryPerOracleComputeUnitInGBs");
                context.Writer.WriteNumberValue(publicRequest.MemoryPerOracleComputeUnitInGBs.Value);
            }

            if(publicRequest.IsSetOdbNetworkId())
            {
                context.Writer.WritePropertyName("odbNetworkId");
                context.Writer.WriteStringValue(publicRequest.OdbNetworkId);
            }

            if(publicRequest.IsSetScanListenerPortNonTls())
            {
                context.Writer.WritePropertyName("scanListenerPortNonTls");
                context.Writer.WriteNumberValue(publicRequest.ScanListenerPortNonTls.Value);
            }

            if(publicRequest.IsSetScanListenerPortTls())
            {
                context.Writer.WritePropertyName("scanListenerPortTls");
                context.Writer.WriteNumberValue(publicRequest.ScanListenerPortTls.Value);
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

            if(publicRequest.IsSetTotalContainerDatabases())
            {
                context.Writer.WritePropertyName("totalContainerDatabases");
                context.Writer.WriteNumberValue(publicRequest.TotalContainerDatabases.Value);
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
        private static CreateCloudAutonomousVmClusterRequestMarshaller _instance = new CreateCloudAutonomousVmClusterRequestMarshaller();        

        internal static CreateCloudAutonomousVmClusterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCloudAutonomousVmClusterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
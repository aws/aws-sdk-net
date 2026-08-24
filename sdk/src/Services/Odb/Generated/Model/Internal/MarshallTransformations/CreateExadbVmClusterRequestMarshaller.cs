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
    /// CreateExadbVmCluster Request Marshaller
    /// </summary>       
    public class CreateExadbVmClusterRequestMarshaller : IMarshaller<IRequest, CreateExadbVmClusterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateExadbVmClusterRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateExadbVmClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Odb");
            string target = "Odb.CreateExadbVmCluster";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-08-20";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
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
            if(publicRequest.IsSetClusterName())
            {
                context.Writer.WritePropertyName("clusterName");
                context.Writer.WriteStringValue(publicRequest.ClusterName);
            }

            if(publicRequest.IsSetDataCollectionOptions())
            {
                context.Writer.WritePropertyName("dataCollectionOptions");
                context.Writer.WriteStartObject();

                var marshaller = DataCollectionOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataCollectionOptions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDisplayName())
            {
                context.Writer.WritePropertyName("displayName");
                context.Writer.WriteStringValue(publicRequest.DisplayName);
            }

            if(publicRequest.IsSetEnabledEcpuCount())
            {
                context.Writer.WritePropertyName("enabledEcpuCount");
                context.Writer.WriteNumberValue(publicRequest.EnabledEcpuCount.Value);
            }

            if(publicRequest.IsSetExascaleDbStorageVaultId())
            {
                context.Writer.WritePropertyName("exascaleDbStorageVaultId");
                context.Writer.WriteStringValue(publicRequest.ExascaleDbStorageVaultId);
            }

            if(publicRequest.IsSetGridImageId())
            {
                context.Writer.WritePropertyName("gridImageId");
                context.Writer.WriteStringValue(publicRequest.GridImageId);
            }

            if(publicRequest.IsSetHostname())
            {
                context.Writer.WritePropertyName("hostname");
                context.Writer.WriteStringValue(publicRequest.Hostname);
            }

            if(publicRequest.IsSetLicenseModel())
            {
                context.Writer.WritePropertyName("licenseModel");
                context.Writer.WriteStringValue(publicRequest.LicenseModel);
            }

            if(publicRequest.IsSetNodeCount())
            {
                context.Writer.WritePropertyName("nodeCount");
                context.Writer.WriteNumberValue(publicRequest.NodeCount.Value);
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

            if(publicRequest.IsSetScanListenerPortTcpSsl())
            {
                context.Writer.WritePropertyName("scanListenerPortTcpSsl");
                context.Writer.WriteNumberValue(publicRequest.ScanListenerPortTcpSsl.Value);
            }

            if(publicRequest.IsSetShape())
            {
                context.Writer.WritePropertyName("shape");
                context.Writer.WriteStringValue(publicRequest.Shape);
            }

            if(publicRequest.IsSetShapeAttribute())
            {
                context.Writer.WritePropertyName("shapeAttribute");
                context.Writer.WriteStringValue(publicRequest.ShapeAttribute);
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

            if(publicRequest.IsSetTotalEcpuCount())
            {
                context.Writer.WritePropertyName("totalEcpuCount");
                context.Writer.WriteNumberValue(publicRequest.TotalEcpuCount.Value);
            }

            if(publicRequest.IsSetVmFileSystemStorageTotalSizeInGBs())
            {
                context.Writer.WritePropertyName("vmFileSystemStorageTotalSizeInGBs");
                context.Writer.WriteNumberValue(publicRequest.VmFileSystemStorageTotalSizeInGBs.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateExadbVmClusterRequestMarshaller _instance = new CreateExadbVmClusterRequestMarshaller();        

        internal static CreateExadbVmClusterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateExadbVmClusterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
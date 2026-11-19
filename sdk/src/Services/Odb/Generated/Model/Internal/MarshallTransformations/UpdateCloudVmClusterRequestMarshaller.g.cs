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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.Odb.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Odb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateCloudVmCluster Request Marshaller
    /// </summary>
    public partial class UpdateCloudVmClusterRequestMarshaller : IMarshaller<IRequest, UpdateCloudVmClusterRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateCloudVmClusterRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateCloudVmClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Odb");
            string target = "Odb.UpdateCloudVmCluster";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-08-20";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetCloudVmClusterId())
            {
                context.Writer.WritePropertyName("cloudVmClusterId");
                context.Writer.WriteStringValue(publicRequest.CloudVmClusterId);
            }
            if (publicRequest.IsSetCpuCoreCount())
            {
                context.Writer.WritePropertyName("cpuCoreCount");
                context.Writer.WriteNumberValue(publicRequest.CpuCoreCount.Value);
            }
            if (publicRequest.IsSetDataCollectionOptions())
            {
                context.Writer.WritePropertyName("dataCollectionOptions");
                context.Writer.WriteStartObject();

                var marshaller = DataCollectionOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataCollectionOptions, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetDataStorageSizeInTBs())
            {
                context.Writer.WritePropertyName("dataStorageSizeInTBs");
                if (StringUtils.IsSpecialDoubleValue(publicRequest.DataStorageSizeInTBs.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(publicRequest.DataStorageSizeInTBs.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.DataStorageSizeInTBs.Value);
                }
            }
            if (publicRequest.IsSetDbNodeStorageSizeInGBs())
            {
                context.Writer.WritePropertyName("dbNodeStorageSizeInGBs");
                context.Writer.WriteNumberValue(publicRequest.DbNodeStorageSizeInGBs.Value);
            }
            if (publicRequest.IsSetDisplayName())
            {
                context.Writer.WritePropertyName("displayName");
                context.Writer.WriteStringValue(publicRequest.DisplayName);
            }
            if (publicRequest.IsSetLicenseModel())
            {
                context.Writer.WritePropertyName("licenseModel");
                context.Writer.WriteStringValue(publicRequest.LicenseModel);
            }
            if (publicRequest.IsSetMemorySizeInGBs())
            {
                context.Writer.WritePropertyName("memorySizeInGBs");
                context.Writer.WriteNumberValue(publicRequest.MemorySizeInGBs.Value);
            }
            if (publicRequest.IsSetSshPublicKeys())
            {
                context.Writer.WritePropertyName("sshPublicKeys");
                context.Writer.WriteStartArray();
                foreach (var publicRequestSshPublicKeysListValue in publicRequest.SshPublicKeys)
                {
                    context.Writer.WriteStringValue(publicRequestSshPublicKeysListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetStorageSizeInGBs())
            {
                context.Writer.WritePropertyName("storageSizeInGBs");
                context.Writer.WriteNumberValue(publicRequest.StorageSizeInGBs.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateCloudVmClusterRequestMarshaller _instance = new();

        internal static UpdateCloudVmClusterRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateCloudVmClusterRequestMarshaller Instance => _instance;
    }
}

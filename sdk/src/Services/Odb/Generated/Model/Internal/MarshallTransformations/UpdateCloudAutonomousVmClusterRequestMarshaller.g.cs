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
    /// UpdateCloudAutonomousVmCluster Request Marshaller
    /// </summary>
    public partial class UpdateCloudAutonomousVmClusterRequestMarshaller : IMarshaller<IRequest, UpdateCloudAutonomousVmClusterRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateCloudAutonomousVmClusterRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateCloudAutonomousVmClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Odb");
            string target = "Odb.UpdateCloudAutonomousVmCluster";
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
            if (publicRequest.IsSetAutonomousDataStorageSizeInTBs())
            {
                context.Writer.WritePropertyName("autonomousDataStorageSizeInTBs");
                if (StringUtils.IsSpecialDoubleValue(publicRequest.AutonomousDataStorageSizeInTBs.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(publicRequest.AutonomousDataStorageSizeInTBs.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.AutonomousDataStorageSizeInTBs.Value);
                }
            }
            if (publicRequest.IsSetCloudAutonomousVmClusterId())
            {
                context.Writer.WritePropertyName("cloudAutonomousVmClusterId");
                context.Writer.WriteStringValue(publicRequest.CloudAutonomousVmClusterId);
            }
            if (publicRequest.IsSetCpuCoreCountPerNode())
            {
                context.Writer.WritePropertyName("cpuCoreCountPerNode");
                context.Writer.WriteNumberValue(publicRequest.CpuCoreCountPerNode.Value);
            }
            if (publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
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
            if (publicRequest.IsSetMaintenanceWindow())
            {
                context.Writer.WritePropertyName("maintenanceWindow");
                context.Writer.WriteStartObject();

                var marshaller = MaintenanceWindowMarshaller.Instance;
                marshaller.Marshall(publicRequest.MaintenanceWindow, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetTotalContainerDatabases())
            {
                context.Writer.WritePropertyName("totalContainerDatabases");
                context.Writer.WriteNumberValue(publicRequest.TotalContainerDatabases.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateCloudAutonomousVmClusterRequestMarshaller _instance = new();

        internal static UpdateCloudAutonomousVmClusterRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateCloudAutonomousVmClusterRequestMarshaller Instance => _instance;
    }
}

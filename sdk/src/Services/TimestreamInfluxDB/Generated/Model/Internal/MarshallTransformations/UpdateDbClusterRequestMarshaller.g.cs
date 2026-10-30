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

using Amazon.TimestreamInfluxDB.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.TimestreamInfluxDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDbCluster Request Marshaller
    /// </summary>
    public partial class UpdateDbClusterRequestMarshaller : IMarshaller<IRequest, UpdateDbClusterRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDbClusterRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateDbClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TimestreamInfluxDB");
            string target = "AmazonTimestreamInfluxDB.UpdateDbCluster";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-01-27";
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
            if (publicRequest.IsSetDbBackupConfigurations())
            {
                context.Writer.WritePropertyName("dbBackupConfigurations");
                context.Writer.WriteStartArray();
                foreach (var publicRequestDbBackupConfigurationsListValue in publicRequest.DbBackupConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DbBackupConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestDbBackupConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetDbClusterId())
            {
                context.Writer.WritePropertyName("dbClusterId");
                context.Writer.WriteStringValue(publicRequest.DbClusterId);
            }
            if (publicRequest.IsSetDbInstanceType())
            {
                context.Writer.WritePropertyName("dbInstanceType");
                context.Writer.WriteStringValue(publicRequest.DbInstanceType);
            }
            if (publicRequest.IsSetDbParameterGroupIdentifier())
            {
                context.Writer.WritePropertyName("dbParameterGroupIdentifier");
                context.Writer.WriteStringValue(publicRequest.DbParameterGroupIdentifier);
            }
            if (publicRequest.IsSetDeploymentConfiguration())
            {
                context.Writer.WritePropertyName("deploymentConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DeploymentConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeploymentConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetFailoverMode())
            {
                context.Writer.WritePropertyName("failoverMode");
                context.Writer.WriteStringValue(publicRequest.FailoverMode);
            }
            if (publicRequest.IsSetLogDeliveryConfiguration())
            {
                context.Writer.WritePropertyName("logDeliveryConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = LogDeliveryConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.LogDeliveryConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetMaintenanceSchedule())
            {
                context.Writer.WritePropertyName("maintenanceSchedule");
                context.Writer.WriteStartObject();

                var marshaller = MaintenanceScheduleMarshaller.Instance;
                marshaller.Marshall(publicRequest.MaintenanceSchedule, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetPort())
            {
                context.Writer.WritePropertyName("port");
                context.Writer.WriteNumberValue(publicRequest.Port.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateDbClusterRequestMarshaller _instance = new();

        internal static UpdateDbClusterRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateDbClusterRequestMarshaller Instance => _instance;
    }
}

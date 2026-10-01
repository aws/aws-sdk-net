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

using Amazon.QuickSight.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartDashboardSnapshotJob Request Marshaller
    /// </summary>
    public partial class StartDashboardSnapshotJobRequestMarshaller : IMarshaller<IRequest, StartDashboardSnapshotJobRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartDashboardSnapshotJobRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StartDashboardSnapshotJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAwsAccountId())
            {
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            }
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));

            if (!publicRequest.IsSetDashboardId())
            {
                throw new AmazonQuickSightException("Request object does not have required field DashboardId set");
            }
            request.AddPathResource("{DashboardId}", StringUtils.FromString(publicRequest.DashboardId));

            request.ResourcePath = "/accounts/{AwsAccountId}/dashboards/{DashboardId}/snapshot-jobs";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetSnapshotConfiguration())
            {
                context.Writer.WritePropertyName("SnapshotConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SnapshotConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.SnapshotConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetSnapshotJobId())
            {
                context.Writer.WritePropertyName("SnapshotJobId");
                context.Writer.WriteStringValue(publicRequest.SnapshotJobId);
            }
            if (publicRequest.IsSetUserConfiguration())
            {
                context.Writer.WritePropertyName("UserConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SnapshotUserConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.UserConfiguration, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly StartDashboardSnapshotJobRequestMarshaller _instance = new();

        internal static StartDashboardSnapshotJobRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartDashboardSnapshotJobRequestMarshaller Instance => _instance;
    }
}

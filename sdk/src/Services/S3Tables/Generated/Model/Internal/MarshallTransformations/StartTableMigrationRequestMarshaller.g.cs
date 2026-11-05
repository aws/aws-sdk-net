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

using Amazon.S3Tables.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.S3Tables.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartTableMigration Request Marshaller
    /// </summary>
    public partial class StartTableMigrationRequestMarshaller : IMarshaller<IRequest, StartTableMigrationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartTableMigrationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StartTableMigrationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.S3Tables");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/start-table-migration";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetDataMigration())
            {
                context.Writer.WritePropertyName("dataMigration");
                context.Writer.WriteStartObject();

                var marshaller = DataMigrationSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataMigration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetDestinationTable())
            {
                context.Writer.WritePropertyName("destinationTable");
                context.Writer.WriteStartObject();

                var marshaller = DestinationTableMarshaller.Instance;
                marshaller.Marshall(publicRequest.DestinationTable, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetMigrationOutput())
            {
                context.Writer.WritePropertyName("migrationOutput");
                context.Writer.WriteStartObject();

                var marshaller = MigrationOutputConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.MigrationOutput, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetReviewMigrationPlan())
            {
                context.Writer.WritePropertyName("reviewMigrationPlan");
                context.Writer.WriteBooleanValue(publicRequest.ReviewMigrationPlan.Value);
            }
            if (publicRequest.IsSetRoleARN())
            {
                context.Writer.WritePropertyName("roleARN");
                context.Writer.WriteStringValue(publicRequest.RoleARN);
            }
            if (publicRequest.IsSetSource())
            {
                context.Writer.WritePropertyName("source");
                context.Writer.WriteStartObject();

                var marshaller = SourceConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Source, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetSourceType())
            {
                context.Writer.WritePropertyName("sourceType");
                context.Writer.WriteStringValue(publicRequest.SourceType);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly StartTableMigrationRequestMarshaller _instance = new();

        internal static StartTableMigrationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartTableMigrationRequestMarshaller Instance => _instance;
    }
}

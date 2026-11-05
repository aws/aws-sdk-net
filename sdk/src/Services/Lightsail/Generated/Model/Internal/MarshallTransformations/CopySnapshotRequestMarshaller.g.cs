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

using Amazon.Lightsail.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CopySnapshot Request Marshaller
    /// </summary>
    public partial class CopySnapshotRequestMarshaller : IMarshaller<IRequest, CopySnapshotRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CopySnapshotRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CopySnapshotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lightsail");
            string target = "Lightsail_20161128.CopySnapshot";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-28";
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
            if (publicRequest.IsSetRestoreDate())
            {
                context.Writer.WritePropertyName("restoreDate");
                context.Writer.WriteStringValue(publicRequest.RestoreDate);
            }
            if (publicRequest.IsSetSourceRegion())
            {
                context.Writer.WritePropertyName("sourceRegion");
                context.Writer.WriteStringValue(publicRequest.SourceRegion);
            }
            if (publicRequest.IsSetSourceResourceName())
            {
                context.Writer.WritePropertyName("sourceResourceName");
                context.Writer.WriteStringValue(publicRequest.SourceResourceName);
            }
            if (publicRequest.IsSetSourceSnapshotName())
            {
                context.Writer.WritePropertyName("sourceSnapshotName");
                context.Writer.WriteStringValue(publicRequest.SourceSnapshotName);
            }
            if (publicRequest.IsSetTargetSnapshotName())
            {
                context.Writer.WritePropertyName("targetSnapshotName");
                context.Writer.WriteStringValue(publicRequest.TargetSnapshotName);
            }
            if (publicRequest.IsSetUseLatestRestorableAutoSnapshot())
            {
                context.Writer.WritePropertyName("useLatestRestorableAutoSnapshot");
                context.Writer.WriteBooleanValue(publicRequest.UseLatestRestorableAutoSnapshot.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CopySnapshotRequestMarshaller _instance = new();

        internal static CopySnapshotRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CopySnapshotRequestMarshaller Instance => _instance;
    }
}

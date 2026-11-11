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

using Amazon.CognitoSync.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateRecords Request Marshaller
    /// </summary>
    public partial class UpdateRecordsRequestMarshaller : IMarshaller<IRequest, UpdateRecordsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateRecordsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateRecordsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoSync");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-06-30";
            request.HttpMethod = "POST";

            if (publicRequest.IsSetClientContext())
            {
                request.Headers["x-amz-Client-Context"] = publicRequest.ClientContext;
            }

            if (!publicRequest.IsSetDatasetName())
            {
                throw new AmazonCognitoSyncException("Request object does not have required field DatasetName set");
            }
            request.AddPathResource("{DatasetName}", StringUtils.FromString(publicRequest.DatasetName));

            if (!publicRequest.IsSetIdentityId())
            {
                throw new AmazonCognitoSyncException("Request object does not have required field IdentityId set");
            }
            request.AddPathResource("{IdentityId}", StringUtils.FromString(publicRequest.IdentityId));

            if (!publicRequest.IsSetIdentityPoolId())
            {
                throw new AmazonCognitoSyncException("Request object does not have required field IdentityPoolId set");
            }
            request.AddPathResource("{IdentityPoolId}", StringUtils.FromString(publicRequest.IdentityPoolId));

            request.ResourcePath = "/identitypools/{IdentityPoolId}/identities/{IdentityId}/datasets/{DatasetName}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetDeviceId())
            {
                context.Writer.WritePropertyName("DeviceId");
                context.Writer.WriteStringValue(publicRequest.DeviceId);
            }
            if (publicRequest.IsSetRecordPatches())
            {
                context.Writer.WritePropertyName("RecordPatches");
                context.Writer.WriteStartArray();
                foreach (var publicRequestRecordPatchesListValue in publicRequest.RecordPatches)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RecordPatchMarshaller.Instance;
                    marshaller.Marshall(publicRequestRecordPatchesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetSyncSessionToken())
            {
                context.Writer.WritePropertyName("SyncSessionToken");
                context.Writer.WriteStringValue(publicRequest.SyncSessionToken);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateRecordsRequestMarshaller _instance = new();

        internal static UpdateRecordsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateRecordsRequestMarshaller Instance => _instance;
    }
}

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

using Amazon.EBS.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.EBS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutSnapshotBlock Request Marshaller
    /// </summary>
    public partial class PutSnapshotBlockRequestMarshaller : IMarshaller<IRequest, PutSnapshotBlockRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutSnapshotBlockRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PutSnapshotBlockRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EBS");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-02";
            request.HttpMethod = "PUT";

            if (publicRequest.IsSetChecksum())
            {
                request.Headers["x-amz-Checksum"] = publicRequest.Checksum;
            }

            if (publicRequest.IsSetChecksumAlgorithm())
            {
                request.Headers["x-amz-Checksum-Algorithm"] = publicRequest.ChecksumAlgorithm;
            }

            if (publicRequest.IsSetDataLength())
            {
                request.Headers["x-amz-Data-Length"] = StringUtils.FromInt(publicRequest.DataLength.Value);
            }

            if (publicRequest.IsSetProgress())
            {
                request.Headers["x-amz-Progress"] = StringUtils.FromInt(publicRequest.Progress.Value);
            }

            if (!publicRequest.IsSetBlockIndex())
            {
                throw new AmazonEBSException("Request object does not have required field BlockIndex set");
            }
            request.AddPathResource("{BlockIndex}", StringUtils.FromInt(publicRequest.BlockIndex.Value));

            if (!publicRequest.IsSetSnapshotId())
            {
                throw new AmazonEBSException("Request object does not have required field SnapshotId set");
            }
            request.AddPathResource("{SnapshotId}", StringUtils.FromString(publicRequest.SnapshotId));

            request.ResourcePath = "/snapshots/{SnapshotId}/blocks/{BlockIndex}";
            request.ContentStream = publicRequest.BlockData ?? new MemoryStream();
            if (request.ContentStream.CanSeek)
            {
                request.ContentStream.Seek(0, SeekOrigin.Begin);
                request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] = request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                request.Headers[Amazon.Util.HeaderKeys.TransferEncodingHeader] = "chunked";
            }
            request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "application/octet-stream";
            request.DisablePayloadSigning = true;

            return request;
        }

        private static readonly PutSnapshotBlockRequestMarshaller _instance = new();

        internal static PutSnapshotBlockRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PutSnapshotBlockRequestMarshaller Instance => _instance;
    }
}

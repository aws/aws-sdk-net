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
    /// GetSnapshotBlock Request Marshaller
    /// </summary>
    public partial class GetSnapshotBlockRequestMarshaller : IMarshaller<IRequest, GetSnapshotBlockRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSnapshotBlockRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetSnapshotBlockRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EBS");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-02";
            request.HttpMethod = "GET";

            if (string.IsNullOrEmpty(publicRequest.BlockToken))
            {
                throw new AmazonEBSException("Request object does not have required field BlockToken set");
            }

            if (publicRequest.IsSetBlockToken())
            {
                request.Parameters.Add("blockToken", StringUtils.FromString(publicRequest.BlockToken));
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

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetSnapshotBlockRequestMarshaller _instance = new();

        internal static GetSnapshotBlockRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetSnapshotBlockRequestMarshaller Instance => _instance;
    }
}

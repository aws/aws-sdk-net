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

using Amazon.BedrockAgentCore.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteMemoryRecord Request Marshaller
    /// </summary>
    public partial class DeleteMemoryRecordRequestMarshaller : IMarshaller<IRequest, DeleteMemoryRecordRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteMemoryRecordRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteMemoryRecordRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCore");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-02-28";
            request.HttpMethod = "DELETE";

            if (publicRequest.IsSetNamespace())
            {
                request.Parameters.Add("namespace", StringUtils.FromString(publicRequest.Namespace));
            }

            if (!publicRequest.IsSetMemoryId())
            {
                throw new AmazonBedrockAgentCoreException("Request object does not have required field MemoryId set");
            }
            request.AddPathResource("{memoryId}", StringUtils.FromString(publicRequest.MemoryId));

            if (!publicRequest.IsSetMemoryRecordId())
            {
                throw new AmazonBedrockAgentCoreException("Request object does not have required field MemoryRecordId set");
            }
            request.AddPathResource("{memoryRecordId}", StringUtils.FromString(publicRequest.MemoryRecordId));

            request.ResourcePath = "/memories/{memoryId}/memoryRecords/{memoryRecordId}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly DeleteMemoryRecordRequestMarshaller _instance = new();

        internal static DeleteMemoryRecordRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteMemoryRecordRequestMarshaller Instance => _instance;
    }
}

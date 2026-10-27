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

using Amazon.BedrockRuntime.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InvokeModelWithBidirectionalStream Request Marshaller
    /// </summary>
    public partial class InvokeModelWithBidirectionalStreamRequestMarshaller : IMarshaller<IRequest, InvokeModelWithBidirectionalStreamRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeModelWithBidirectionalStreamRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(InvokeModelWithBidirectionalStreamRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockRuntime");
#if NET8_0_OR_GREATER
            request.HttpProtocolVersion = System.Net.HttpVersion.Version20;
#endif
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-09-30";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetModelId())
            {
                throw new AmazonBedrockRuntimeException("Request object does not have required field ModelId set");
            }
            request.AddPathResource("{modelId}", StringUtils.FromString(publicRequest.ModelId));

            request.ResourcePath = "/model/{modelId}/invoke-with-bidirectional-stream";
            request.Headers["Content-Type"] = "application/vnd.amazon.eventstream";
            request.EventStreamPublisher = new InvokeModelWithBidirectionalStreamInputPublisherMarshaller(publicRequest.BodyPublisher);

            return request;
        }

        private static readonly InvokeModelWithBidirectionalStreamRequestMarshaller _instance = new();

        internal static InvokeModelWithBidirectionalStreamRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static InvokeModelWithBidirectionalStreamRequestMarshaller Instance => _instance;
    }
}

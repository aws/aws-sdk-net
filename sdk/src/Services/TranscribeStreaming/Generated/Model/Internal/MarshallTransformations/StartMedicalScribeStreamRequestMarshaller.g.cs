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

using Amazon.TranscribeStreaming.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.TranscribeStreaming.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartMedicalScribeStream Request Marshaller
    /// </summary>
    public partial class StartMedicalScribeStreamRequestMarshaller : IMarshaller<IRequest, StartMedicalScribeStreamRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartMedicalScribeStreamRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StartMedicalScribeStreamRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TranscribeStreaming");
#if NET8_0_OR_GREATER
            request.HttpProtocolVersion = System.Net.HttpVersion.Version20;
#endif
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-26";
            request.HttpMethod = "POST";

            if (publicRequest.IsSetLanguageCode())
            {
                request.Headers["x-amzn-transcribe-language-code"] = publicRequest.LanguageCode;
            }

            if (publicRequest.IsSetMediaEncoding())
            {
                request.Headers["x-amzn-transcribe-media-encoding"] = publicRequest.MediaEncoding;
            }

            if (publicRequest.IsSetMediaSampleRateHertz())
            {
                request.Headers["x-amzn-transcribe-sample-rate"] = StringUtils.FromInt(publicRequest.MediaSampleRateHertz.Value);
            }

            if (publicRequest.IsSetSessionId())
            {
                request.Headers["x-amzn-transcribe-session-id"] = publicRequest.SessionId;
            }

            request.ResourcePath = "/medical-scribe-stream";
            request.Headers["Content-Type"] = "application/vnd.amazon.eventstream";
            request.EventStreamPublisher = new MedicalScribeInputStreamPublisherMarshaller(publicRequest.InputStreamPublisher);

            return request;
        }

        private static readonly StartMedicalScribeStreamRequestMarshaller _instance = new();

        internal static StartMedicalScribeStreamRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartMedicalScribeStreamRequestMarshaller Instance => _instance;
    }
}

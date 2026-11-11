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

using Amazon.CloudWatchLogs.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLogAnomalyDetector Request Marshaller
    /// </summary>
    public partial class CreateLogAnomalyDetectorRequestMarshaller : IMarshaller<IRequest, CreateLogAnomalyDetectorRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLogAnomalyDetectorRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateLogAnomalyDetectorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchLogs");
            string target = "Logs_20140328.CreateLogAnomalyDetector";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-03-28";
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
            if (publicRequest.IsSetAnomalyVisibilityTime())
            {
                context.Writer.WritePropertyName("anomalyVisibilityTime");
                context.Writer.WriteNumberValue(publicRequest.AnomalyVisibilityTime.Value);
            }
            if (publicRequest.IsSetDetectorName())
            {
                context.Writer.WritePropertyName("detectorName");
                context.Writer.WriteStringValue(publicRequest.DetectorName);
            }
            if (publicRequest.IsSetEvaluationFrequency())
            {
                context.Writer.WritePropertyName("evaluationFrequency");
                context.Writer.WriteStringValue(publicRequest.EvaluationFrequency);
            }
            if (publicRequest.IsSetFilterPattern())
            {
                context.Writer.WritePropertyName("filterPattern");
                context.Writer.WriteStringValue(publicRequest.FilterPattern);
            }
            if (publicRequest.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("kmsKeyId");
                context.Writer.WriteStringValue(publicRequest.KmsKeyId);
            }
            if (publicRequest.IsSetLogGroupArnList())
            {
                context.Writer.WritePropertyName("logGroupArnList");
                context.Writer.WriteStartArray();
                foreach (var publicRequestLogGroupArnListListValue in publicRequest.LogGroupArnList)
                {
                    context.Writer.WriteStringValue(publicRequestLogGroupArnListListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;
                    context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateLogAnomalyDetectorRequestMarshaller _instance = new();

        internal static CreateLogAnomalyDetectorRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateLogAnomalyDetectorRequestMarshaller Instance => _instance;
    }
}

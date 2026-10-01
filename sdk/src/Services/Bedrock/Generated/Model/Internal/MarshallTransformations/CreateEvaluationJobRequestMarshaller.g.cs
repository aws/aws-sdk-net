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

using Amazon.Bedrock.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateEvaluationJob Request Marshaller
    /// </summary>
    public partial class CreateEvaluationJobRequestMarshaller : IMarshaller<IRequest, CreateEvaluationJobRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEvaluationJobRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateEvaluationJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Bedrock");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-20";
            request.HttpMethod = "POST";

            request.ResourcePath = "/evaluation-jobs";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetApplicationType())
            {
                context.Writer.WritePropertyName("applicationType");
                context.Writer.WriteStringValue(publicRequest.ApplicationType);
            }
            if (publicRequest.IsSetClientRequestToken())
            {
                context.Writer.WritePropertyName("clientRequestToken");
                context.Writer.WriteStringValue(publicRequest.ClientRequestToken);
            }
            else
            {
                context.Writer.WritePropertyName("clientRequestToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetCustomerEncryptionKeyId())
            {
                context.Writer.WritePropertyName("customerEncryptionKeyId");
                context.Writer.WriteStringValue(publicRequest.CustomerEncryptionKeyId);
            }
            if (publicRequest.IsSetEvaluationConfig())
            {
                context.Writer.WritePropertyName("evaluationConfig");
                context.Writer.WriteStartObject();

                var marshaller = EvaluationConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.EvaluationConfig, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetInferenceConfig())
            {
                context.Writer.WritePropertyName("inferenceConfig");
                context.Writer.WriteStartObject();

                var marshaller = EvaluationInferenceConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.InferenceConfig, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetJobDescription())
            {
                context.Writer.WritePropertyName("jobDescription");
                context.Writer.WriteStringValue(publicRequest.JobDescription);
            }
            if (publicRequest.IsSetJobName())
            {
                context.Writer.WritePropertyName("jobName");
                context.Writer.WriteStringValue(publicRequest.JobName);
            }
            if (publicRequest.IsSetJobTags())
            {
                context.Writer.WritePropertyName("jobTags");
                context.Writer.WriteStartArray();
                foreach (var publicRequestJobTagsListValue in publicRequest.JobTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestJobTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetOutputDataConfig())
            {
                context.Writer.WritePropertyName("outputDataConfig");
                context.Writer.WriteStartObject();

                var marshaller = EvaluationOutputDataConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutputDataConfig, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateEvaluationJobRequestMarshaller _instance = new();

        internal static CreateEvaluationJobRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateEvaluationJobRequestMarshaller Instance => _instance;
    }
}

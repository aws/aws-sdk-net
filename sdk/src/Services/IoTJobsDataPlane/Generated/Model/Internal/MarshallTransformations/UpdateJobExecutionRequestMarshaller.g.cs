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

using Amazon.IoTJobsDataPlane.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.IoTJobsDataPlane.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateJobExecution Request Marshaller
    /// </summary>
    public partial class UpdateJobExecutionRequestMarshaller : IMarshaller<IRequest, UpdateJobExecutionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateJobExecutionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateJobExecutionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTJobsDataPlane");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-09-29";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetJobId())
            {
                throw new AmazonIoTJobsDataPlaneException("Request object does not have required field JobId set");
            }
            request.AddPathResource("{jobId}", StringUtils.FromString(publicRequest.JobId));

            if (!publicRequest.IsSetThingName())
            {
                throw new AmazonIoTJobsDataPlaneException("Request object does not have required field ThingName set");
            }
            request.AddPathResource("{thingName}", StringUtils.FromString(publicRequest.ThingName));

            request.ResourcePath = "/things/{thingName}/jobs/{jobId}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetExecutionNumber())
            {
                context.Writer.WritePropertyName("executionNumber");
                context.Writer.WriteNumberValue(publicRequest.ExecutionNumber.Value);
            }
            if (publicRequest.IsSetExpectedVersion())
            {
                context.Writer.WritePropertyName("expectedVersion");
                context.Writer.WriteNumberValue(publicRequest.ExpectedVersion.Value);
            }
            if (publicRequest.IsSetIncludeJobDocument())
            {
                context.Writer.WritePropertyName("includeJobDocument");
                context.Writer.WriteBooleanValue(publicRequest.IncludeJobDocument.Value);
            }
            if (publicRequest.IsSetIncludeJobExecutionState())
            {
                context.Writer.WritePropertyName("includeJobExecutionState");
                context.Writer.WriteBooleanValue(publicRequest.IncludeJobExecutionState.Value);
            }
            if (publicRequest.IsSetStatus())
            {
                context.Writer.WritePropertyName("status");
                context.Writer.WriteStringValue(publicRequest.Status);
            }
            if (publicRequest.IsSetStatusDetails())
            {
                context.Writer.WritePropertyName("statusDetails");
                context.Writer.WriteStartObject();
                foreach (var publicRequestStatusDetailsKvp in publicRequest.StatusDetails)
                {
                    context.Writer.WritePropertyName(publicRequestStatusDetailsKvp.Key);
                    var publicRequestStatusDetailsValue = publicRequestStatusDetailsKvp.Value;
                    context.Writer.WriteStringValue(publicRequestStatusDetailsValue);
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetStepTimeoutInMinutes())
            {
                context.Writer.WritePropertyName("stepTimeoutInMinutes");
                context.Writer.WriteNumberValue(publicRequest.StepTimeoutInMinutes.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateJobExecutionRequestMarshaller _instance = new();

        internal static UpdateJobExecutionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateJobExecutionRequestMarshaller Instance => _instance;
    }
}

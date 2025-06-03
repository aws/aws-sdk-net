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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EMRServerless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.EMRServerless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartJobRun Request Marshaller
    /// </summary>       
    public class StartJobRunRequestMarshaller : IMarshaller<IRequest, StartJobRunRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartJobRunRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartJobRunRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EMRServerless");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-13";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetApplicationId())
                throw new AmazonEMRServerlessException("Request object does not have required field ApplicationId set");
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));
            request.ResourcePath = "/applications/{applicationId}/jobruns";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetConfigurationOverrides())
            {
                context.Writer.WritePropertyName("configurationOverrides");
                context.Writer.WriteStartObject();

                var marshaller = ConfigurationOverridesMarshaller.Instance;
                marshaller.Marshall(publicRequest.ConfigurationOverrides, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetExecutionIamPolicy())
            {
                context.Writer.WritePropertyName("executionIamPolicy");
                context.Writer.WriteStartObject();

                var marshaller = JobRunExecutionIamPolicyMarshaller.Instance;
                marshaller.Marshall(publicRequest.ExecutionIamPolicy, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetExecutionRoleArn())
            {
                context.Writer.WritePropertyName("executionRoleArn");
                context.Writer.WriteStringValue(publicRequest.ExecutionRoleArn);
            }

            if(publicRequest.IsSetExecutionTimeoutMinutes())
            {
                context.Writer.WritePropertyName("executionTimeoutMinutes");
                context.Writer.WriteNumberValue(publicRequest.ExecutionTimeoutMinutes.Value);
            }

            if(publicRequest.IsSetJobDriver())
            {
                context.Writer.WritePropertyName("jobDriver");
                context.Writer.WriteStartObject();

                var marshaller = JobDriverMarshaller.Instance;
                marshaller.Marshall(publicRequest.JobDriver, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMode())
            {
                context.Writer.WritePropertyName("mode");
                context.Writer.WriteStringValue(publicRequest.Mode);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetRetryPolicy())
            {
                context.Writer.WritePropertyName("retryPolicy");
                context.Writer.WriteStartObject();

                var marshaller = RetryPolicyMarshaller.Instance;
                marshaller.Marshall(publicRequest.RetryPolicy, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTags())
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
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static StartJobRunRequestMarshaller _instance = new StartJobRunRequestMarshaller();        

        internal static StartJobRunRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartJobRunRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
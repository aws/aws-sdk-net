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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
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
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLabelingJob Request Marshaller
    /// </summary>       
    public class CreateLabelingJobRequestMarshaller : IMarshaller<IRequest, CreateLabelingJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLabelingJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateLabelingJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateLabelingJob";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetHumanTaskConfig())
            {
                context.Writer.WritePropertyName("HumanTaskConfig");
                context.Writer.WriteStartObject();

                var marshaller = HumanTaskConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.HumanTaskConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInputConfig())
            {
                context.Writer.WritePropertyName("InputConfig");
                context.Writer.WriteStartObject();

                var marshaller = LabelingJobInputConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.InputConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetLabelAttributeName())
            {
                context.Writer.WritePropertyName("LabelAttributeName");
                context.Writer.WriteStringValue(publicRequest.LabelAttributeName);
            }

            if(publicRequest.IsSetLabelCategoryConfigS3Uri())
            {
                context.Writer.WritePropertyName("LabelCategoryConfigS3Uri");
                context.Writer.WriteStringValue(publicRequest.LabelCategoryConfigS3Uri);
            }

            if(publicRequest.IsSetLabelingJobAlgorithmsConfig())
            {
                context.Writer.WritePropertyName("LabelingJobAlgorithmsConfig");
                context.Writer.WriteStartObject();

                var marshaller = LabelingJobAlgorithmsConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.LabelingJobAlgorithmsConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetLabelingJobName())
            {
                context.Writer.WritePropertyName("LabelingJobName");
                context.Writer.WriteStringValue(publicRequest.LabelingJobName);
            }

            if(publicRequest.IsSetOutputConfig())
            {
                context.Writer.WritePropertyName("OutputConfig");
                context.Writer.WriteStartObject();

                var marshaller = LabelingJobOutputConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutputConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            if(publicRequest.IsSetStoppingConditions())
            {
                context.Writer.WritePropertyName("StoppingConditions");
                context.Writer.WriteStartObject();

                var marshaller = LabelingJobStoppingConditionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.StoppingConditions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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
        private static CreateLabelingJobRequestMarshaller _instance = new CreateLabelingJobRequestMarshaller();        

        internal static CreateLabelingJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateLabelingJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
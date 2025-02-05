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
    /// CreateTransformJob Request Marshaller
    /// </summary>       
    public class CreateTransformJobRequestMarshaller : IMarshaller<IRequest, CreateTransformJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTransformJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTransformJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateTransformJob";
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
            if(publicRequest.IsSetBatchStrategy())
            {
                context.Writer.WritePropertyName("BatchStrategy");
                context.Writer.WriteStringValue(publicRequest.BatchStrategy);
            }

            if(publicRequest.IsSetDataCaptureConfig())
            {
                context.Writer.WritePropertyName("DataCaptureConfig");
                context.Writer.WriteStartObject();

                var marshaller = BatchDataCaptureConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataCaptureConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDataProcessing())
            {
                context.Writer.WritePropertyName("DataProcessing");
                context.Writer.WriteStartObject();

                var marshaller = DataProcessingMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataProcessing, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("Environment");
                context.Writer.WriteStartObject();
                foreach (var publicRequestEnvironmentKvp in publicRequest.Environment)
                {
                    context.Writer.WritePropertyName(publicRequestEnvironmentKvp.Key);
                    var publicRequestEnvironmentValue = publicRequestEnvironmentKvp.Value;

                        context.Writer.WriteStringValue(publicRequestEnvironmentValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetExperimentConfig())
            {
                context.Writer.WritePropertyName("ExperimentConfig");
                context.Writer.WriteStartObject();

                var marshaller = ExperimentConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ExperimentConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMaxConcurrentTransforms())
            {
                context.Writer.WritePropertyName("MaxConcurrentTransforms");
                context.Writer.WriteNumberValue(publicRequest.MaxConcurrentTransforms.Value);
            }

            if(publicRequest.IsSetMaxPayloadInMB())
            {
                context.Writer.WritePropertyName("MaxPayloadInMB");
                context.Writer.WriteNumberValue(publicRequest.MaxPayloadInMB.Value);
            }

            if(publicRequest.IsSetModelClientConfig())
            {
                context.Writer.WritePropertyName("ModelClientConfig");
                context.Writer.WriteStartObject();

                var marshaller = ModelClientConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ModelClientConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetModelName())
            {
                context.Writer.WritePropertyName("ModelName");
                context.Writer.WriteStringValue(publicRequest.ModelName);
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

            if(publicRequest.IsSetTransformInput())
            {
                context.Writer.WritePropertyName("TransformInput");
                context.Writer.WriteStartObject();

                var marshaller = TransformInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.TransformInput, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTransformJobName())
            {
                context.Writer.WritePropertyName("TransformJobName");
                context.Writer.WriteStringValue(publicRequest.TransformJobName);
            }

            if(publicRequest.IsSetTransformOutput())
            {
                context.Writer.WritePropertyName("TransformOutput");
                context.Writer.WriteStartObject();

                var marshaller = TransformOutputMarshaller.Instance;
                marshaller.Marshall(publicRequest.TransformOutput, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTransformResources())
            {
                context.Writer.WritePropertyName("TransformResources");
                context.Writer.WriteStartObject();

                var marshaller = TransformResourcesMarshaller.Instance;
                marshaller.Marshall(publicRequest.TransformResources, context);

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
        private static CreateTransformJobRequestMarshaller _instance = new CreateTransformJobRequestMarshaller();        

        internal static CreateTransformJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTransformJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
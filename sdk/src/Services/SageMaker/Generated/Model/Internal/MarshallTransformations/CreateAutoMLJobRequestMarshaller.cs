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
    /// CreateAutoMLJob Request Marshaller
    /// </summary>       
    public class CreateAutoMLJobRequestMarshaller : IMarshaller<IRequest, CreateAutoMLJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAutoMLJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAutoMLJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateAutoMLJob";
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
            if(publicRequest.IsSetAutoMLJobConfig())
            {
                context.Writer.WritePropertyName("AutoMLJobConfig");
                context.Writer.WriteStartObject();

                var marshaller = AutoMLJobConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.AutoMLJobConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAutoMLJobName())
            {
                context.Writer.WritePropertyName("AutoMLJobName");
                context.Writer.WriteStringValue(publicRequest.AutoMLJobName);
            }

            if(publicRequest.IsSetAutoMLJobObjective())
            {
                context.Writer.WritePropertyName("AutoMLJobObjective");
                context.Writer.WriteStartObject();

                var marshaller = AutoMLJobObjectiveMarshaller.Instance;
                marshaller.Marshall(publicRequest.AutoMLJobObjective, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetGenerateCandidateDefinitionsOnly())
            {
                context.Writer.WritePropertyName("GenerateCandidateDefinitionsOnly");
                context.Writer.WriteBooleanValue(publicRequest.GenerateCandidateDefinitionsOnly.Value);
            }

            if(publicRequest.IsSetInputDataConfig())
            {
                context.Writer.WritePropertyName("InputDataConfig");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInputDataConfigListValue in publicRequest.InputDataConfig)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AutoMLChannelMarshaller.Instance;
                    marshaller.Marshall(publicRequestInputDataConfigListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetModelDeployConfig())
            {
                context.Writer.WritePropertyName("ModelDeployConfig");
                context.Writer.WriteStartObject();

                var marshaller = ModelDeployConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ModelDeployConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOutputDataConfig())
            {
                context.Writer.WritePropertyName("OutputDataConfig");
                context.Writer.WriteStartObject();

                var marshaller = AutoMLOutputDataConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutputDataConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetProblemType())
            {
                context.Writer.WritePropertyName("ProblemType");
                context.Writer.WriteStringValue(publicRequest.ProblemType);
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
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
        private static CreateAutoMLJobRequestMarshaller _instance = new CreateAutoMLJobRequestMarshaller();        

        internal static CreateAutoMLJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAutoMLJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Braket.Model;
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
namespace Amazon.Braket.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateJob Request Marshaller
    /// </summary>       
    public class CreateJobRequestMarshaller : IMarshaller<IRequest, CreateJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Braket");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-09-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/job";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAlgorithmSpecification())
            {
                context.Writer.WritePropertyName("algorithmSpecification");
                context.Writer.WriteStartObject();

                var marshaller = AlgorithmSpecificationMarshaller.Instance;
                marshaller.Marshall(publicRequest.AlgorithmSpecification, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetAssociations())
            {
                context.Writer.WritePropertyName("associations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAssociationsListValue in publicRequest.Associations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AssociationMarshaller.Instance;
                    marshaller.Marshall(publicRequestAssociationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetCheckpointConfig())
            {
                context.Writer.WritePropertyName("checkpointConfig");
                context.Writer.WriteStartObject();

                var marshaller = JobCheckpointConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.CheckpointConfig, context);

                context.Writer.WriteEndObject();
            }

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
            if(publicRequest.IsSetDeviceConfig())
            {
                context.Writer.WritePropertyName("deviceConfig");
                context.Writer.WriteStartObject();

                var marshaller = DeviceConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeviceConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetHyperParameters())
            {
                context.Writer.WritePropertyName("hyperParameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestHyperParametersKvp in publicRequest.HyperParameters)
                {
                    context.Writer.WritePropertyName(publicRequestHyperParametersKvp.Key);
                    var publicRequestHyperParametersValue = publicRequestHyperParametersKvp.Value;

                        context.Writer.WriteStringValue(publicRequestHyperParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInputDataConfig())
            {
                context.Writer.WritePropertyName("inputDataConfig");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInputDataConfigListValue in publicRequest.InputDataConfig)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InputFileConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequestInputDataConfigListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetInstanceConfig())
            {
                context.Writer.WritePropertyName("instanceConfig");
                context.Writer.WriteStartObject();

                var marshaller = InstanceConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.InstanceConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetJobName())
            {
                context.Writer.WritePropertyName("jobName");
                context.Writer.WriteStringValue(publicRequest.JobName);
            }

            if(publicRequest.IsSetOutputDataConfig())
            {
                context.Writer.WritePropertyName("outputDataConfig");
                context.Writer.WriteStartObject();

                var marshaller = JobOutputDataConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutputDataConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }

            if(publicRequest.IsSetStoppingCondition())
            {
                context.Writer.WritePropertyName("stoppingCondition");
                context.Writer.WriteStartObject();

                var marshaller = JobStoppingConditionMarshaller.Instance;
                marshaller.Marshall(publicRequest.StoppingCondition, context);

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
        private static CreateJobRequestMarshaller _instance = new CreateJobRequestMarshaller();        

        internal static CreateJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
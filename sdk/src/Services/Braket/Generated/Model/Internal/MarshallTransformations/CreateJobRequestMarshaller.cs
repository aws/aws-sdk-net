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
using ThirdParty.Json.LitJson;

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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAlgorithmSpecification())
                {
                    context.Writer.WritePropertyName("algorithmSpecification");
                    context.Writer.WriteObjectStart();

                    var marshaller = AlgorithmSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AlgorithmSpecification, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCheckpointConfig())
                {
                    context.Writer.WritePropertyName("checkpointConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = JobCheckpointConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CheckpointConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetDeviceConfig())
                {
                    context.Writer.WritePropertyName("deviceConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = DeviceConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeviceConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetHyperParameters())
                {
                    context.Writer.WritePropertyName("hyperParameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestHyperParametersKvp in publicRequest.HyperParameters)
                    {
                        context.Writer.WritePropertyName(publicRequestHyperParametersKvp.Key);
                        var publicRequestHyperParametersValue = publicRequestHyperParametersKvp.Value;

                            context.Writer.Write(publicRequestHyperParametersValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInputDataConfig())
                {
                    context.Writer.WritePropertyName("inputDataConfig");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInputDataConfigListValue in publicRequest.InputDataConfig)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = InputFileConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestInputDataConfigListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetInstanceConfig())
                {
                    context.Writer.WritePropertyName("instanceConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = InstanceConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InstanceConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetJobName())
                {
                    context.Writer.WritePropertyName("jobName");
                    context.Writer.Write(publicRequest.JobName);
                }

                if(publicRequest.IsSetOutputDataConfig())
                {
                    context.Writer.WritePropertyName("outputDataConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = JobOutputDataConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputDataConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetStoppingCondition())
                {
                    context.Writer.WritePropertyName("stoppingCondition");
                    context.Writer.WriteObjectStart();

                    var marshaller = JobStoppingConditionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.StoppingCondition, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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
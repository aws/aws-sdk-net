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
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateProcessingJob Request Marshaller
    /// </summary>       
    public class CreateProcessingJobRequestMarshaller : IMarshaller<IRequest, CreateProcessingJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateProcessingJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateProcessingJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateProcessingJob";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAppSpecification())
                {
                    context.Writer.WritePropertyName("AppSpecification");
                    context.Writer.WriteObjectStart();

                    var marshaller = AppSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AppSpecification, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEnvironment())
                {
                    context.Writer.WritePropertyName("Environment");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestEnvironmentKvp in publicRequest.Environment)
                    {
                        context.Writer.WritePropertyName(publicRequestEnvironmentKvp.Key);
                        var publicRequestEnvironmentValue = publicRequestEnvironmentKvp.Value;

                            context.Writer.Write(publicRequestEnvironmentValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetExperimentConfig())
                {
                    context.Writer.WritePropertyName("ExperimentConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ExperimentConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ExperimentConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNetworkConfig())
                {
                    context.Writer.WritePropertyName("NetworkConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = NetworkConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NetworkConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetProcessingInputs())
                {
                    context.Writer.WritePropertyName("ProcessingInputs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestProcessingInputsListValue in publicRequest.ProcessingInputs)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ProcessingInputMarshaller.Instance;
                        marshaller.Marshall(publicRequestProcessingInputsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetProcessingJobName())
                {
                    context.Writer.WritePropertyName("ProcessingJobName");
                    context.Writer.Write(publicRequest.ProcessingJobName);
                }

                if(publicRequest.IsSetProcessingOutputConfig())
                {
                    context.Writer.WritePropertyName("ProcessingOutputConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ProcessingOutputConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ProcessingOutputConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetProcessingResources())
                {
                    context.Writer.WritePropertyName("ProcessingResources");
                    context.Writer.WriteObjectStart();

                    var marshaller = ProcessingResourcesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ProcessingResources, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("RoleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetStoppingCondition())
                {
                    context.Writer.WritePropertyName("StoppingCondition");
                    context.Writer.WriteObjectStart();

                    var marshaller = ProcessingStoppingConditionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.StoppingCondition, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateProcessingJobRequestMarshaller _instance = new CreateProcessingJobRequestMarshaller();        

        internal static CreateProcessingJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateProcessingJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
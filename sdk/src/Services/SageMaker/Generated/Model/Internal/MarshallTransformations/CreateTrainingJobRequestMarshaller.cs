/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// CreateTrainingJob Request Marshaller
    /// </summary>       
    public class CreateTrainingJobRequestMarshaller : IMarshaller<IRequest, CreateTrainingJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTrainingJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTrainingJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateTrainingJob";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAlgorithmSpecification())
                {
                    context.Writer.WritePropertyName("AlgorithmSpecification");
                    context.Writer.WriteObjectStart();

                    var marshaller = AlgorithmSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AlgorithmSpecification, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetHyperParameters())
                {
                    context.Writer.WritePropertyName("HyperParameters");
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
                    context.Writer.WritePropertyName("InputDataConfig");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInputDataConfigListValue in publicRequest.InputDataConfig)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ChannelMarshaller.Instance;
                        marshaller.Marshall(publicRequestInputDataConfigListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOutputDataConfig())
                {
                    context.Writer.WritePropertyName("OutputDataConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = OutputDataConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputDataConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetResourceConfig())
                {
                    context.Writer.WritePropertyName("ResourceConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ResourceConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ResourceConfig, context);

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

                    var marshaller = StoppingConditionMarshaller.Instance;
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

                if(publicRequest.IsSetTrainingJobName())
                {
                    context.Writer.WritePropertyName("TrainingJobName");
                    context.Writer.Write(publicRequest.TrainingJobName);
                }

                if(publicRequest.IsSetVpcConfig())
                {
                    context.Writer.WritePropertyName("VpcConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = VpcConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VpcConfig, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateTrainingJobRequestMarshaller _instance = new CreateTrainingJobRequestMarshaller();        

        internal static CreateTrainingJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTrainingJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
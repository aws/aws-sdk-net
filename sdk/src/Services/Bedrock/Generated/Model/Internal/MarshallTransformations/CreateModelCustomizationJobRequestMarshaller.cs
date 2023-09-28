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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Bedrock.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateModelCustomizationJob Request Marshaller
    /// </summary>       
    public class CreateModelCustomizationJobRequestMarshaller : IMarshaller<IRequest, CreateModelCustomizationJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateModelCustomizationJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateModelCustomizationJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Bedrock");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-20";
            request.HttpMethod = "POST";

            request.ResourcePath = "/model-customization-jobs";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBaseModelIdentifier())
                {
                    context.Writer.WritePropertyName("baseModelIdentifier");
                    context.Writer.Write(publicRequest.BaseModelIdentifier);
                }

                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("clientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                else if(!(publicRequest.IsSetClientRequestToken()))
                {
                    context.Writer.WritePropertyName("clientRequestToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetCustomModelKmsKeyId())
                {
                    context.Writer.WritePropertyName("customModelKmsKeyId");
                    context.Writer.Write(publicRequest.CustomModelKmsKeyId);
                }

                if(publicRequest.IsSetCustomModelName())
                {
                    context.Writer.WritePropertyName("customModelName");
                    context.Writer.Write(publicRequest.CustomModelName);
                }

                if(publicRequest.IsSetCustomModelTags())
                {
                    context.Writer.WritePropertyName("customModelTags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCustomModelTagsListValue in publicRequest.CustomModelTags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestCustomModelTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
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

                if(publicRequest.IsSetJobName())
                {
                    context.Writer.WritePropertyName("jobName");
                    context.Writer.Write(publicRequest.JobName);
                }

                if(publicRequest.IsSetJobTags())
                {
                    context.Writer.WritePropertyName("jobTags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestJobTagsListValue in publicRequest.JobTags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestJobTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOutputDataConfig())
                {
                    context.Writer.WritePropertyName("outputDataConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = OutputDataConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputDataConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetTrainingDataConfig())
                {
                    context.Writer.WritePropertyName("trainingDataConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = TrainingDataConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TrainingDataConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetValidationDataConfig())
                {
                    context.Writer.WritePropertyName("validationDataConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ValidationDataConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ValidationDataConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVpcConfig())
                {
                    context.Writer.WritePropertyName("vpcConfig");
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
        private static CreateModelCustomizationJobRequestMarshaller _instance = new CreateModelCustomizationJobRequestMarshaller();        

        internal static CreateModelCustomizationJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateModelCustomizationJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
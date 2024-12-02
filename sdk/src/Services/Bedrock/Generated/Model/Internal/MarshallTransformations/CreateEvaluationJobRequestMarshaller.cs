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

#pragma warning disable CS0612,CS0618
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateEvaluationJob Request Marshaller
    /// </summary>       
    public class CreateEvaluationJobRequestMarshaller : IMarshaller<IRequest, CreateEvaluationJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEvaluationJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateEvaluationJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Bedrock");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-20";
            request.HttpMethod = "POST";

            request.ResourcePath = "/evaluation-jobs";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApplicationType())
                {
                    context.Writer.WritePropertyName("applicationType");
                    context.Writer.Write(publicRequest.ApplicationType);
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
                if(publicRequest.IsSetCustomerEncryptionKeyId())
                {
                    context.Writer.WritePropertyName("customerEncryptionKeyId");
                    context.Writer.Write(publicRequest.CustomerEncryptionKeyId);
                }

                if(publicRequest.IsSetEvaluationConfig())
                {
                    context.Writer.WritePropertyName("evaluationConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = EvaluationConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EvaluationConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInferenceConfig())
                {
                    context.Writer.WritePropertyName("inferenceConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = EvaluationInferenceConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InferenceConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetJobDescription())
                {
                    context.Writer.WritePropertyName("jobDescription");
                    context.Writer.Write(publicRequest.JobDescription);
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

                    var marshaller = EvaluationOutputDataConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputDataConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateEvaluationJobRequestMarshaller _instance = new CreateEvaluationJobRequestMarshaller();        

        internal static CreateEvaluationJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEvaluationJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
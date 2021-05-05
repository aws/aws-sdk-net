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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAutoMLJobConfig())
                {
                    context.Writer.WritePropertyName("AutoMLJobConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AutoMLJobConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AutoMLJobConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAutoMLJobName())
                {
                    context.Writer.WritePropertyName("AutoMLJobName");
                    context.Writer.Write(publicRequest.AutoMLJobName);
                }

                if(publicRequest.IsSetAutoMLJobObjective())
                {
                    context.Writer.WritePropertyName("AutoMLJobObjective");
                    context.Writer.WriteObjectStart();

                    var marshaller = AutoMLJobObjectiveMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AutoMLJobObjective, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetGenerateCandidateDefinitionsOnly())
                {
                    context.Writer.WritePropertyName("GenerateCandidateDefinitionsOnly");
                    context.Writer.Write(publicRequest.GenerateCandidateDefinitionsOnly);
                }

                if(publicRequest.IsSetInputDataConfig())
                {
                    context.Writer.WritePropertyName("InputDataConfig");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInputDataConfigListValue in publicRequest.InputDataConfig)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AutoMLChannelMarshaller.Instance;
                        marshaller.Marshall(publicRequestInputDataConfigListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetModelDeployConfig())
                {
                    context.Writer.WritePropertyName("ModelDeployConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ModelDeployConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ModelDeployConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOutputDataConfig())
                {
                    context.Writer.WritePropertyName("OutputDataConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AutoMLOutputDataConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputDataConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetProblemType())
                {
                    context.Writer.WritePropertyName("ProblemType");
                    context.Writer.Write(publicRequest.ProblemType);
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("RoleArn");
                    context.Writer.Write(publicRequest.RoleArn);
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
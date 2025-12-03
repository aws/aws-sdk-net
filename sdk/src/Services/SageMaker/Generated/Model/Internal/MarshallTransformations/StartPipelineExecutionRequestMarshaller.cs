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

#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartPipelineExecution Request Marshaller
    /// </summary>       
    public class StartPipelineExecutionRequestMarshaller : IMarshaller<IRequest, StartPipelineExecutionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartPipelineExecutionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartPipelineExecutionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.StartPipelineExecution";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                else if(!(publicRequest.IsSetClientRequestToken()))
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetMlflowExperimentName())
                {
                    context.Writer.WritePropertyName("MlflowExperimentName");
                    context.Writer.Write(publicRequest.MlflowExperimentName);
                }

                if(publicRequest.IsSetParallelismConfiguration())
                {
                    context.Writer.WritePropertyName("ParallelismConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ParallelismConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ParallelismConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPipelineExecutionDescription())
                {
                    context.Writer.WritePropertyName("PipelineExecutionDescription");
                    context.Writer.Write(publicRequest.PipelineExecutionDescription);
                }

                if(publicRequest.IsSetPipelineExecutionDisplayName())
                {
                    context.Writer.WritePropertyName("PipelineExecutionDisplayName");
                    context.Writer.Write(publicRequest.PipelineExecutionDisplayName);
                }

                if(publicRequest.IsSetPipelineName())
                {
                    context.Writer.WritePropertyName("PipelineName");
                    context.Writer.Write(publicRequest.PipelineName);
                }

                if(publicRequest.IsSetPipelineParameters())
                {
                    context.Writer.WritePropertyName("PipelineParameters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPipelineParametersListValue in publicRequest.PipelineParameters)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ParameterMarshaller.Instance;
                        marshaller.Marshall(publicRequestPipelineParametersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPipelineVersionId())
                {
                    context.Writer.WritePropertyName("PipelineVersionId");
                    context.Writer.Write(publicRequest.PipelineVersionId);
                }

                if(publicRequest.IsSetSelectiveExecutionConfig())
                {
                    context.Writer.WritePropertyName("SelectiveExecutionConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = SelectiveExecutionConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SelectiveExecutionConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartPipelineExecutionRequestMarshaller _instance = new StartPipelineExecutionRequestMarshaller();        

        internal static StartPipelineExecutionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartPipelineExecutionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
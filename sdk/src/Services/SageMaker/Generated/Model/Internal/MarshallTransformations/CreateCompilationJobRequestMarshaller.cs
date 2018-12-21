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
    /// CreateCompilationJob Request Marshaller
    /// </summary>       
    public class CreateCompilationJobRequestMarshaller : IMarshaller<IRequest, CreateCompilationJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCompilationJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCompilationJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateCompilationJob";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCompilationJobName())
                {
                    context.Writer.WritePropertyName("CompilationJobName");
                    context.Writer.Write(publicRequest.CompilationJobName);
                }

                if(publicRequest.IsSetInputConfig())
                {
                    context.Writer.WritePropertyName("InputConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = InputConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InputConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOutputConfig())
                {
                    context.Writer.WritePropertyName("OutputConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = OutputConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputConfig, context);

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

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateCompilationJobRequestMarshaller _instance = new CreateCompilationJobRequestMarshaller();        

        internal static CreateCompilationJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCompilationJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
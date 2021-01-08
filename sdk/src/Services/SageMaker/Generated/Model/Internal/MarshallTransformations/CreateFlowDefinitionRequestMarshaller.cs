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
    /// CreateFlowDefinition Request Marshaller
    /// </summary>       
    public class CreateFlowDefinitionRequestMarshaller : IMarshaller<IRequest, CreateFlowDefinitionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFlowDefinitionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFlowDefinitionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateFlowDefinition";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetFlowDefinitionName())
                {
                    context.Writer.WritePropertyName("FlowDefinitionName");
                    context.Writer.Write(publicRequest.FlowDefinitionName);
                }

                if(publicRequest.IsSetHumanLoopActivationConfig())
                {
                    context.Writer.WritePropertyName("HumanLoopActivationConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = HumanLoopActivationConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.HumanLoopActivationConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetHumanLoopConfig())
                {
                    context.Writer.WritePropertyName("HumanLoopConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = HumanLoopConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.HumanLoopConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetHumanLoopRequestSource())
                {
                    context.Writer.WritePropertyName("HumanLoopRequestSource");
                    context.Writer.WriteObjectStart();

                    var marshaller = HumanLoopRequestSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.HumanLoopRequestSource, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOutputConfig())
                {
                    context.Writer.WritePropertyName("OutputConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = FlowDefinitionOutputConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputConfig, context);

                    context.Writer.WriteObjectEnd();
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
        private static CreateFlowDefinitionRequestMarshaller _instance = new CreateFlowDefinitionRequestMarshaller();        

        internal static CreateFlowDefinitionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFlowDefinitionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
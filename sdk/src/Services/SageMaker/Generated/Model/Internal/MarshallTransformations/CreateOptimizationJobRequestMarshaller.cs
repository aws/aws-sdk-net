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
    /// CreateOptimizationJob Request Marshaller
    /// </summary>       
    public class CreateOptimizationJobRequestMarshaller : IMarshaller<IRequest, CreateOptimizationJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateOptimizationJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateOptimizationJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateOptimizationJob";
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
                if(publicRequest.IsSetDeploymentInstanceType())
                {
                    context.Writer.WritePropertyName("DeploymentInstanceType");
                    context.Writer.Write(publicRequest.DeploymentInstanceType);
                }

                if(publicRequest.IsSetMaxInstanceCount())
                {
                    context.Writer.WritePropertyName("MaxInstanceCount");
                    context.Writer.Write(publicRequest.MaxInstanceCount);
                }

                if(publicRequest.IsSetModelSource())
                {
                    context.Writer.WritePropertyName("ModelSource");
                    context.Writer.WriteObjectStart();

                    var marshaller = OptimizationJobModelSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ModelSource, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOptimizationConfigs())
                {
                    context.Writer.WritePropertyName("OptimizationConfigs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestOptimizationConfigsListValue in publicRequest.OptimizationConfigs)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = OptimizationConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestOptimizationConfigsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOptimizationEnvironment())
                {
                    context.Writer.WritePropertyName("OptimizationEnvironment");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestOptimizationEnvironmentKvp in publicRequest.OptimizationEnvironment)
                    {
                        context.Writer.WritePropertyName(publicRequestOptimizationEnvironmentKvp.Key);
                        var publicRequestOptimizationEnvironmentValue = publicRequestOptimizationEnvironmentKvp.Value;

                            context.Writer.Write(publicRequestOptimizationEnvironmentValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOptimizationJobName())
                {
                    context.Writer.WritePropertyName("OptimizationJobName");
                    context.Writer.Write(publicRequest.OptimizationJobName);
                }

                if(publicRequest.IsSetOutputConfig())
                {
                    context.Writer.WritePropertyName("OutputConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = OptimizationJobOutputConfigMarshaller.Instance;
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

                if(publicRequest.IsSetVpcConfig())
                {
                    context.Writer.WritePropertyName("VpcConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = OptimizationVpcConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VpcConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateOptimizationJobRequestMarshaller _instance = new CreateOptimizationJobRequestMarshaller();        

        internal static CreateOptimizationJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateOptimizationJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
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
    /// CreateModelQualityJobDefinition Request Marshaller
    /// </summary>       
    public class CreateModelQualityJobDefinitionRequestMarshaller : IMarshaller<IRequest, CreateModelQualityJobDefinitionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateModelQualityJobDefinitionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateModelQualityJobDefinitionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateModelQualityJobDefinition";
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
                if(publicRequest.IsSetJobDefinitionName())
                {
                    context.Writer.WritePropertyName("JobDefinitionName");
                    context.Writer.Write(publicRequest.JobDefinitionName);
                }

                if(publicRequest.IsSetJobResources())
                {
                    context.Writer.WritePropertyName("JobResources");
                    context.Writer.WriteObjectStart();

                    var marshaller = MonitoringResourcesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.JobResources, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetModelQualityAppSpecification())
                {
                    context.Writer.WritePropertyName("ModelQualityAppSpecification");
                    context.Writer.WriteObjectStart();

                    var marshaller = ModelQualityAppSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ModelQualityAppSpecification, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetModelQualityBaselineConfig())
                {
                    context.Writer.WritePropertyName("ModelQualityBaselineConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ModelQualityBaselineConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ModelQualityBaselineConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetModelQualityJobInput())
                {
                    context.Writer.WritePropertyName("ModelQualityJobInput");
                    context.Writer.WriteObjectStart();

                    var marshaller = ModelQualityJobInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ModelQualityJobInput, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetModelQualityJobOutputConfig())
                {
                    context.Writer.WritePropertyName("ModelQualityJobOutputConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = MonitoringOutputConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ModelQualityJobOutputConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNetworkConfig())
                {
                    context.Writer.WritePropertyName("NetworkConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = MonitoringNetworkConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NetworkConfig, context);

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

                    var marshaller = MonitoringStoppingConditionMarshaller.Instance;
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
        private static CreateModelQualityJobDefinitionRequestMarshaller _instance = new CreateModelQualityJobDefinitionRequestMarshaller();        

        internal static CreateModelQualityJobDefinitionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateModelQualityJobDefinitionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
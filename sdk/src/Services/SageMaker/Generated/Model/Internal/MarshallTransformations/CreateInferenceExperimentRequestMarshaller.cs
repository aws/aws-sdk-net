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
    /// CreateInferenceExperiment Request Marshaller
    /// </summary>       
    public class CreateInferenceExperimentRequestMarshaller : IMarshaller<IRequest, CreateInferenceExperimentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateInferenceExperimentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateInferenceExperimentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateInferenceExperiment";
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
                if(publicRequest.IsSetDataStorageConfig())
                {
                    context.Writer.WritePropertyName("DataStorageConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = InferenceExperimentDataStorageConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DataStorageConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEndpointName())
                {
                    context.Writer.WritePropertyName("EndpointName");
                    context.Writer.Write(publicRequest.EndpointName);
                }

                if(publicRequest.IsSetKmsKey())
                {
                    context.Writer.WritePropertyName("KmsKey");
                    context.Writer.Write(publicRequest.KmsKey);
                }

                if(publicRequest.IsSetModelVariants())
                {
                    context.Writer.WritePropertyName("ModelVariants");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestModelVariantsListValue in publicRequest.ModelVariants)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ModelVariantConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestModelVariantsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("RoleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetSchedule())
                {
                    context.Writer.WritePropertyName("Schedule");
                    context.Writer.WriteObjectStart();

                    var marshaller = InferenceExperimentScheduleMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Schedule, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetShadowModeConfig())
                {
                    context.Writer.WritePropertyName("ShadowModeConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ShadowModeConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ShadowModeConfig, context);

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

                if(publicRequest.IsSetType())
                {
                    context.Writer.WritePropertyName("Type");
                    context.Writer.Write(publicRequest.Type);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateInferenceExperimentRequestMarshaller _instance = new CreateInferenceExperimentRequestMarshaller();        

        internal static CreateInferenceExperimentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateInferenceExperimentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
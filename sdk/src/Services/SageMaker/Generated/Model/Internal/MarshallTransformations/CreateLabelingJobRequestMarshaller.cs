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
    /// CreateLabelingJob Request Marshaller
    /// </summary>       
    public class CreateLabelingJobRequestMarshaller : IMarshaller<IRequest, CreateLabelingJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLabelingJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateLabelingJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateLabelingJob";
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
                if(publicRequest.IsSetHumanTaskConfig())
                {
                    context.Writer.WritePropertyName("HumanTaskConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = HumanTaskConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.HumanTaskConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInputConfig())
                {
                    context.Writer.WritePropertyName("InputConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = LabelingJobInputConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InputConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLabelAttributeName())
                {
                    context.Writer.WritePropertyName("LabelAttributeName");
                    context.Writer.Write(publicRequest.LabelAttributeName);
                }

                if(publicRequest.IsSetLabelCategoryConfigS3Uri())
                {
                    context.Writer.WritePropertyName("LabelCategoryConfigS3Uri");
                    context.Writer.Write(publicRequest.LabelCategoryConfigS3Uri);
                }

                if(publicRequest.IsSetLabelingJobAlgorithmsConfig())
                {
                    context.Writer.WritePropertyName("LabelingJobAlgorithmsConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = LabelingJobAlgorithmsConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LabelingJobAlgorithmsConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLabelingJobName())
                {
                    context.Writer.WritePropertyName("LabelingJobName");
                    context.Writer.Write(publicRequest.LabelingJobName);
                }

                if(publicRequest.IsSetOutputConfig())
                {
                    context.Writer.WritePropertyName("OutputConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = LabelingJobOutputConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("RoleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetStoppingConditions())
                {
                    context.Writer.WritePropertyName("StoppingConditions");
                    context.Writer.WriteObjectStart();

                    var marshaller = LabelingJobStoppingConditionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.StoppingConditions, context);

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
        private static CreateLabelingJobRequestMarshaller _instance = new CreateLabelingJobRequestMarshaller();        

        internal static CreateLabelingJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateLabelingJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
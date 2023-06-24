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
    /// CreateAutoMLJobV2 Request Marshaller
    /// </summary>       
    public class CreateAutoMLJobV2RequestMarshaller : IMarshaller<IRequest, CreateAutoMLJobV2Request> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAutoMLJobV2Request)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAutoMLJobV2Request publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateAutoMLJobV2";
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
                if(publicRequest.IsSetAutoMLJobInputDataConfig())
                {
                    context.Writer.WritePropertyName("AutoMLJobInputDataConfig");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAutoMLJobInputDataConfigListValue in publicRequest.AutoMLJobInputDataConfig)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AutoMLJobChannelMarshaller.Instance;
                        marshaller.Marshall(publicRequestAutoMLJobInputDataConfigListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
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

                if(publicRequest.IsSetAutoMLProblemTypeConfig())
                {
                    context.Writer.WritePropertyName("AutoMLProblemTypeConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AutoMLProblemTypeConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AutoMLProblemTypeConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDataSplitConfig())
                {
                    context.Writer.WritePropertyName("DataSplitConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AutoMLDataSplitConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DataSplitConfig, context);

                    context.Writer.WriteObjectEnd();
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

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("RoleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetSecurityConfig())
                {
                    context.Writer.WritePropertyName("SecurityConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AutoMLSecurityConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SecurityConfig, context);

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
        private static CreateAutoMLJobV2RequestMarshaller _instance = new CreateAutoMLJobV2RequestMarshaller();        

        internal static CreateAutoMLJobV2RequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAutoMLJobV2RequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
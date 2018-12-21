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
    /// CreateTransformJob Request Marshaller
    /// </summary>       
    public class CreateTransformJobRequestMarshaller : IMarshaller<IRequest, CreateTransformJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTransformJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTransformJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateTransformJob";
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
                if(publicRequest.IsSetBatchStrategy())
                {
                    context.Writer.WritePropertyName("BatchStrategy");
                    context.Writer.Write(publicRequest.BatchStrategy);
                }

                if(publicRequest.IsSetEnvironment())
                {
                    context.Writer.WritePropertyName("Environment");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestEnvironmentKvp in publicRequest.Environment)
                    {
                        context.Writer.WritePropertyName(publicRequestEnvironmentKvp.Key);
                        var publicRequestEnvironmentValue = publicRequestEnvironmentKvp.Value;

                            context.Writer.Write(publicRequestEnvironmentValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaxConcurrentTransforms())
                {
                    context.Writer.WritePropertyName("MaxConcurrentTransforms");
                    context.Writer.Write(publicRequest.MaxConcurrentTransforms);
                }

                if(publicRequest.IsSetMaxPayloadInMB())
                {
                    context.Writer.WritePropertyName("MaxPayloadInMB");
                    context.Writer.Write(publicRequest.MaxPayloadInMB);
                }

                if(publicRequest.IsSetModelName())
                {
                    context.Writer.WritePropertyName("ModelName");
                    context.Writer.Write(publicRequest.ModelName);
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

                if(publicRequest.IsSetTransformInput())
                {
                    context.Writer.WritePropertyName("TransformInput");
                    context.Writer.WriteObjectStart();

                    var marshaller = TransformInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TransformInput, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTransformJobName())
                {
                    context.Writer.WritePropertyName("TransformJobName");
                    context.Writer.Write(publicRequest.TransformJobName);
                }

                if(publicRequest.IsSetTransformOutput())
                {
                    context.Writer.WritePropertyName("TransformOutput");
                    context.Writer.WriteObjectStart();

                    var marshaller = TransformOutputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TransformOutput, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTransformResources())
                {
                    context.Writer.WritePropertyName("TransformResources");
                    context.Writer.WriteObjectStart();

                    var marshaller = TransformResourcesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TransformResources, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateTransformJobRequestMarshaller _instance = new CreateTransformJobRequestMarshaller();        

        internal static CreateTransformJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTransformJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Panorama.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Panorama.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateNodeFromTemplateJob Request Marshaller
    /// </summary>       
    public class CreateNodeFromTemplateJobRequestMarshaller : IMarshaller<IRequest, CreateNodeFromTemplateJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateNodeFromTemplateJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateNodeFromTemplateJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Panorama");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-24";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/packages/template-job";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetJobTags())
                {
                    context.Writer.WritePropertyName("JobTags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestJobTagsListValue in publicRequest.JobTags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = JobResourceTagsMarshaller.Instance;
                        marshaller.Marshall(publicRequestJobTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetNodeDescription())
                {
                    context.Writer.WritePropertyName("NodeDescription");
                    context.Writer.Write(publicRequest.NodeDescription);
                }

                if(publicRequest.IsSetNodeName())
                {
                    context.Writer.WritePropertyName("NodeName");
                    context.Writer.Write(publicRequest.NodeName);
                }

                if(publicRequest.IsSetOutputPackageName())
                {
                    context.Writer.WritePropertyName("OutputPackageName");
                    context.Writer.Write(publicRequest.OutputPackageName);
                }

                if(publicRequest.IsSetOutputPackageVersion())
                {
                    context.Writer.WritePropertyName("OutputPackageVersion");
                    context.Writer.Write(publicRequest.OutputPackageVersion);
                }

                if(publicRequest.IsSetTemplateParameters())
                {
                    context.Writer.WritePropertyName("TemplateParameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTemplateParametersKvp in publicRequest.TemplateParameters)
                    {
                        context.Writer.WritePropertyName(publicRequestTemplateParametersKvp.Key);
                        var publicRequestTemplateParametersValue = publicRequestTemplateParametersKvp.Value;

                            context.Writer.Write(publicRequestTemplateParametersValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTemplateType())
                {
                    context.Writer.WritePropertyName("TemplateType");
                    context.Writer.Write(publicRequest.TemplateType);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateNodeFromTemplateJobRequestMarshaller _instance = new CreateNodeFromTemplateJobRequestMarshaller();        

        internal static CreateNodeFromTemplateJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateNodeFromTemplateJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
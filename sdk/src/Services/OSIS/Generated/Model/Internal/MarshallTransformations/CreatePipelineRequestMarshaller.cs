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
 * Do not modify this file. This file is generated from the osis-2022-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OSIS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.OSIS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreatePipeline Request Marshaller
    /// </summary>       
    public class CreatePipelineRequestMarshaller : IMarshaller<IRequest, CreatePipelineRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreatePipelineRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreatePipelineRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OSIS");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/2022-01-01/osis/createPipeline";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBufferOptions())
                {
                    context.Writer.WritePropertyName("BufferOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = BufferOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.BufferOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEncryptionAtRestOptions())
                {
                    context.Writer.WritePropertyName("EncryptionAtRestOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = EncryptionAtRestOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionAtRestOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLogPublishingOptions())
                {
                    context.Writer.WritePropertyName("LogPublishingOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = LogPublishingOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LogPublishingOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaxUnits())
                {
                    context.Writer.WritePropertyName("MaxUnits");
                    context.Writer.Write(publicRequest.MaxUnits);
                }

                if(publicRequest.IsSetMinUnits())
                {
                    context.Writer.WritePropertyName("MinUnits");
                    context.Writer.Write(publicRequest.MinUnits);
                }

                if(publicRequest.IsSetPipelineConfigurationBody())
                {
                    context.Writer.WritePropertyName("PipelineConfigurationBody");
                    context.Writer.Write(publicRequest.PipelineConfigurationBody);
                }

                if(publicRequest.IsSetPipelineName())
                {
                    context.Writer.WritePropertyName("PipelineName");
                    context.Writer.Write(publicRequest.PipelineName);
                }

                if(publicRequest.IsSetPipelineRoleArn())
                {
                    context.Writer.WritePropertyName("PipelineRoleArn");
                    context.Writer.Write(publicRequest.PipelineRoleArn);
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

                if(publicRequest.IsSetVpcOptions())
                {
                    context.Writer.WritePropertyName("VpcOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = VpcOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VpcOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreatePipelineRequestMarshaller _instance = new CreatePipelineRequestMarshaller();        

        internal static CreatePipelineRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreatePipelineRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMediaPipelines.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ChimeSDKMediaPipelines.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMediaCapturePipeline Request Marshaller
    /// </summary>       
    public class CreateMediaCapturePipelineRequestMarshaller : IMarshaller<IRequest, CreateMediaCapturePipelineRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMediaCapturePipelineRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMediaCapturePipelineRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMediaPipelines");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/sdk-media-capture-pipelines";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetChimeSdkMeetingConfiguration())
                {
                    context.Writer.WritePropertyName("ChimeSdkMeetingConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ChimeSdkMeetingConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ChimeSdkMeetingConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                else if(!(publicRequest.IsSetClientRequestToken()))
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetSinkArn())
                {
                    context.Writer.WritePropertyName("SinkArn");
                    context.Writer.Write(publicRequest.SinkArn);
                }

                if(publicRequest.IsSetSinkIamRoleArn())
                {
                    context.Writer.WritePropertyName("SinkIamRoleArn");
                    context.Writer.Write(publicRequest.SinkIamRoleArn);
                }

                if(publicRequest.IsSetSinkType())
                {
                    context.Writer.WritePropertyName("SinkType");
                    context.Writer.Write(publicRequest.SinkType);
                }

                if(publicRequest.IsSetSourceArn())
                {
                    context.Writer.WritePropertyName("SourceArn");
                    context.Writer.Write(publicRequest.SourceArn);
                }

                if(publicRequest.IsSetSourceType())
                {
                    context.Writer.WritePropertyName("SourceType");
                    context.Writer.Write(publicRequest.SourceType);
                }

                if(publicRequest.IsSetSseAwsKeyManagementParams())
                {
                    context.Writer.WritePropertyName("SseAwsKeyManagementParams");
                    context.Writer.WriteObjectStart();

                    var marshaller = SseAwsKeyManagementParamsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SseAwsKeyManagementParams, context);

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
        private static CreateMediaCapturePipelineRequestMarshaller _instance = new CreateMediaCapturePipelineRequestMarshaller();        

        internal static CreateMediaCapturePipelineRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMediaCapturePipelineRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
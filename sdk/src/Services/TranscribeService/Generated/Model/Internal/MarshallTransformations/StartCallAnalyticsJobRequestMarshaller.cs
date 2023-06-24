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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TranscribeService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.TranscribeService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartCallAnalyticsJob Request Marshaller
    /// </summary>       
    public class StartCallAnalyticsJobRequestMarshaller : IMarshaller<IRequest, StartCallAnalyticsJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartCallAnalyticsJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartCallAnalyticsJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TranscribeService");
            string target = "Transcribe.StartCallAnalyticsJob";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCallAnalyticsJobName())
                {
                    context.Writer.WritePropertyName("CallAnalyticsJobName");
                    context.Writer.Write(publicRequest.CallAnalyticsJobName);
                }

                if(publicRequest.IsSetChannelDefinitions())
                {
                    context.Writer.WritePropertyName("ChannelDefinitions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestChannelDefinitionsListValue in publicRequest.ChannelDefinitions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ChannelDefinitionMarshaller.Instance;
                        marshaller.Marshall(publicRequestChannelDefinitionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDataAccessRoleArn())
                {
                    context.Writer.WritePropertyName("DataAccessRoleArn");
                    context.Writer.Write(publicRequest.DataAccessRoleArn);
                }

                if(publicRequest.IsSetMedia())
                {
                    context.Writer.WritePropertyName("Media");
                    context.Writer.WriteObjectStart();

                    var marshaller = MediaMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Media, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOutputEncryptionKMSKeyId())
                {
                    context.Writer.WritePropertyName("OutputEncryptionKMSKeyId");
                    context.Writer.Write(publicRequest.OutputEncryptionKMSKeyId);
                }

                if(publicRequest.IsSetOutputLocation())
                {
                    context.Writer.WritePropertyName("OutputLocation");
                    context.Writer.Write(publicRequest.OutputLocation);
                }

                if(publicRequest.IsSetSettings())
                {
                    context.Writer.WritePropertyName("Settings");
                    context.Writer.WriteObjectStart();

                    var marshaller = CallAnalyticsJobSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Settings, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartCallAnalyticsJobRequestMarshaller _instance = new StartCallAnalyticsJobRequestMarshaller();        

        internal static StartCallAnalyticsJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartCallAnalyticsJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
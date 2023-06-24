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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PinpointSMSVoiceV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.PinpointSMSVoiceV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateEventDestination Request Marshaller
    /// </summary>       
    public class UpdateEventDestinationRequestMarshaller : IMarshaller<IRequest, UpdateEventDestinationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateEventDestinationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateEventDestinationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PinpointSMSVoiceV2");
            string target = "PinpointSMSVoiceV2.UpdateEventDestination";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCloudWatchLogsDestination())
                {
                    context.Writer.WritePropertyName("CloudWatchLogsDestination");
                    context.Writer.WriteObjectStart();

                    var marshaller = CloudWatchLogsDestinationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CloudWatchLogsDestination, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetConfigurationSetName())
                {
                    context.Writer.WritePropertyName("ConfigurationSetName");
                    context.Writer.Write(publicRequest.ConfigurationSetName);
                }

                if(publicRequest.IsSetEnabled())
                {
                    context.Writer.WritePropertyName("Enabled");
                    context.Writer.Write(publicRequest.Enabled);
                }

                if(publicRequest.IsSetEventDestinationName())
                {
                    context.Writer.WritePropertyName("EventDestinationName");
                    context.Writer.Write(publicRequest.EventDestinationName);
                }

                if(publicRequest.IsSetKinesisFirehoseDestination())
                {
                    context.Writer.WritePropertyName("KinesisFirehoseDestination");
                    context.Writer.WriteObjectStart();

                    var marshaller = KinesisFirehoseDestinationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.KinesisFirehoseDestination, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMatchingEventTypes())
                {
                    context.Writer.WritePropertyName("MatchingEventTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMatchingEventTypesListValue in publicRequest.MatchingEventTypes)
                    {
                            context.Writer.Write(publicRequestMatchingEventTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSnsDestination())
                {
                    context.Writer.WritePropertyName("SnsDestination");
                    context.Writer.WriteObjectStart();

                    var marshaller = SnsDestinationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SnsDestination, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateEventDestinationRequestMarshaller _instance = new UpdateEventDestinationRequestMarshaller();        

        internal static UpdateEventDestinationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateEventDestinationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
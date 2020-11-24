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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchEvents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudWatchEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartReplay Request Marshaller
    /// </summary>       
    public class StartReplayRequestMarshaller : IMarshaller<IRequest, StartReplayRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartReplayRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartReplayRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchEvents");
            string target = "AWSEvents.StartReplay";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-07";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDestination())
                {
                    context.Writer.WritePropertyName("Destination");
                    context.Writer.WriteObjectStart();

                    var marshaller = ReplayDestinationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Destination, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEventEndTime())
                {
                    context.Writer.WritePropertyName("EventEndTime");
                    context.Writer.Write(publicRequest.EventEndTime);
                }

                if(publicRequest.IsSetEventSourceArn())
                {
                    context.Writer.WritePropertyName("EventSourceArn");
                    context.Writer.Write(publicRequest.EventSourceArn);
                }

                if(publicRequest.IsSetEventStartTime())
                {
                    context.Writer.WritePropertyName("EventStartTime");
                    context.Writer.Write(publicRequest.EventStartTime);
                }

                if(publicRequest.IsSetReplayName())
                {
                    context.Writer.WritePropertyName("ReplayName");
                    context.Writer.Write(publicRequest.ReplayName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartReplayRequestMarshaller _instance = new StartReplayRequestMarshaller();        

        internal static StartReplayRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartReplayRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
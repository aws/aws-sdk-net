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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSMIncidents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SSMIncidents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateIncidentRecord Request Marshaller
    /// </summary>       
    public class UpdateIncidentRecordRequestMarshaller : IMarshaller<IRequest, UpdateIncidentRecordRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateIncidentRecordRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateIncidentRecordRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SSMIncidents");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/updateIncidentRecord";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetArn())
                {
                    context.Writer.WritePropertyName("arn");
                    context.Writer.Write(publicRequest.Arn);
                }

                if(publicRequest.IsSetChatChannel())
                {
                    context.Writer.WritePropertyName("chatChannel");
                    context.Writer.WriteObjectStart();

                    var marshaller = ChatChannelMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ChatChannel, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetImpact())
                {
                    context.Writer.WritePropertyName("impact");
                    context.Writer.Write(publicRequest.Impact);
                }

                if(publicRequest.IsSetNotificationTargets())
                {
                    context.Writer.WritePropertyName("notificationTargets");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNotificationTargetsListValue in publicRequest.NotificationTargets)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = NotificationTargetItemMarshaller.Instance;
                        marshaller.Marshall(publicRequestNotificationTargetsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("status");
                    context.Writer.Write(publicRequest.Status);
                }

                if(publicRequest.IsSetSummary())
                {
                    context.Writer.WritePropertyName("summary");
                    context.Writer.Write(publicRequest.Summary);
                }

                if(publicRequest.IsSetTitle())
                {
                    context.Writer.WritePropertyName("title");
                    context.Writer.Write(publicRequest.Title);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateIncidentRecordRequestMarshaller _instance = new UpdateIncidentRecordRequestMarshaller();        

        internal static UpdateIncidentRecordRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateIncidentRecordRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
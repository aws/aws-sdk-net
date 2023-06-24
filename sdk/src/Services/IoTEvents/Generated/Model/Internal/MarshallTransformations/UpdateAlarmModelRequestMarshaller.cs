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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTEvents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAlarmModel Request Marshaller
    /// </summary>       
    public class UpdateAlarmModelRequestMarshaller : IMarshaller<IRequest, UpdateAlarmModelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAlarmModelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAlarmModelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTEvents");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-07-27";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAlarmModelName())
                throw new AmazonIoTEventsException("Request object does not have required field AlarmModelName set");
            request.AddPathResource("{alarmModelName}", StringUtils.FromString(publicRequest.AlarmModelName));
            request.ResourcePath = "/alarm-models/{alarmModelName}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAlarmCapabilities())
                {
                    context.Writer.WritePropertyName("alarmCapabilities");
                    context.Writer.WriteObjectStart();

                    var marshaller = AlarmCapabilitiesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AlarmCapabilities, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAlarmEventActions())
                {
                    context.Writer.WritePropertyName("alarmEventActions");
                    context.Writer.WriteObjectStart();

                    var marshaller = AlarmEventActionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AlarmEventActions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAlarmModelDescription())
                {
                    context.Writer.WritePropertyName("alarmModelDescription");
                    context.Writer.Write(publicRequest.AlarmModelDescription);
                }

                if(publicRequest.IsSetAlarmNotification())
                {
                    context.Writer.WritePropertyName("alarmNotification");
                    context.Writer.WriteObjectStart();

                    var marshaller = AlarmNotificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AlarmNotification, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAlarmRule())
                {
                    context.Writer.WritePropertyName("alarmRule");
                    context.Writer.WriteObjectStart();

                    var marshaller = AlarmRuleMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AlarmRule, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetSeverity())
                {
                    context.Writer.WritePropertyName("severity");
                    context.Writer.Write(publicRequest.Severity);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateAlarmModelRequestMarshaller _instance = new UpdateAlarmModelRequestMarshaller();        

        internal static UpdateAlarmModelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAlarmModelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
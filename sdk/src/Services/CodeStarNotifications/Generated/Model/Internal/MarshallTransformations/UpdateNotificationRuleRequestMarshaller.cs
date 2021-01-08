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
 * Do not modify this file. This file is generated from the codestar-notifications-2019-10-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeStarNotifications.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeStarNotifications.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateNotificationRule Request Marshaller
    /// </summary>       
    public class UpdateNotificationRuleRequestMarshaller : IMarshaller<IRequest, UpdateNotificationRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateNotificationRuleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateNotificationRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeStarNotifications");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-10-15";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/updateNotificationRule";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetArn())
                {
                    context.Writer.WritePropertyName("Arn");
                    context.Writer.Write(publicRequest.Arn);
                }

                if(publicRequest.IsSetDetailType())
                {
                    context.Writer.WritePropertyName("DetailType");
                    context.Writer.Write(publicRequest.DetailType);
                }

                if(publicRequest.IsSetEventTypeIds())
                {
                    context.Writer.WritePropertyName("EventTypeIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEventTypeIdsListValue in publicRequest.EventTypeIds)
                    {
                            context.Writer.Write(publicRequestEventTypeIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("Status");
                    context.Writer.Write(publicRequest.Status);
                }

                if(publicRequest.IsSetTargets())
                {
                    context.Writer.WritePropertyName("Targets");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTargetsListValue in publicRequest.Targets)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TargetMarshaller.Instance;
                        marshaller.Marshall(publicRequestTargetsListValue, context);

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
        private static UpdateNotificationRuleRequestMarshaller _instance = new UpdateNotificationRuleRequestMarshaller();        

        internal static UpdateNotificationRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateNotificationRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateScheduledAudit Request Marshaller
    /// </summary>       
    public class CreateScheduledAuditRequestMarshaller : IMarshaller<IRequest, CreateScheduledAuditRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateScheduledAuditRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateScheduledAuditRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetScheduledAuditName())
                throw new AmazonIoTException("Request object does not have required field ScheduledAuditName set");
            request.AddPathResource("{scheduledAuditName}", StringUtils.FromString(publicRequest.ScheduledAuditName));
            request.ResourcePath = "/audit/scheduledaudits/{scheduledAuditName}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDayOfMonth())
                {
                    context.Writer.WritePropertyName("dayOfMonth");
                    context.Writer.Write(publicRequest.DayOfMonth);
                }

                if(publicRequest.IsSetDayOfWeek())
                {
                    context.Writer.WritePropertyName("dayOfWeek");
                    context.Writer.Write(publicRequest.DayOfWeek);
                }

                if(publicRequest.IsSetFrequency())
                {
                    context.Writer.WritePropertyName("frequency");
                    context.Writer.Write(publicRequest.Frequency);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
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

                if(publicRequest.IsSetTargetCheckNames())
                {
                    context.Writer.WritePropertyName("targetCheckNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTargetCheckNamesListValue in publicRequest.TargetCheckNames)
                    {
                            context.Writer.Write(publicRequestTargetCheckNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateScheduledAuditRequestMarshaller _instance = new CreateScheduledAuditRequestMarshaller();        

        internal static CreateScheduledAuditRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateScheduledAuditRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
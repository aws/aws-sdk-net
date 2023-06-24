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
 * Do not modify this file. This file is generated from the scheduler-2021-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Scheduler.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Scheduler.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSchedule Request Marshaller
    /// </summary>       
    public class UpdateScheduleRequestMarshaller : IMarshaller<IRequest, UpdateScheduleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateScheduleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateScheduleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Scheduler");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-06-30";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetName())
                throw new AmazonSchedulerException("Request object does not have required field Name set");
            request.AddPathResource("{Name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/schedules/{Name}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEndDate())
                {
                    context.Writer.WritePropertyName("EndDate");
                    context.Writer.Write(publicRequest.EndDate);
                }

                if(publicRequest.IsSetFlexibleTimeWindow())
                {
                    context.Writer.WritePropertyName("FlexibleTimeWindow");
                    context.Writer.WriteObjectStart();

                    var marshaller = FlexibleTimeWindowMarshaller.Instance;
                    marshaller.Marshall(publicRequest.FlexibleTimeWindow, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetGroupName())
                {
                    context.Writer.WritePropertyName("GroupName");
                    context.Writer.Write(publicRequest.GroupName);
                }

                if(publicRequest.IsSetKmsKeyArn())
                {
                    context.Writer.WritePropertyName("KmsKeyArn");
                    context.Writer.Write(publicRequest.KmsKeyArn);
                }

                if(publicRequest.IsSetScheduleExpression())
                {
                    context.Writer.WritePropertyName("ScheduleExpression");
                    context.Writer.Write(publicRequest.ScheduleExpression);
                }

                if(publicRequest.IsSetScheduleExpressionTimezone())
                {
                    context.Writer.WritePropertyName("ScheduleExpressionTimezone");
                    context.Writer.Write(publicRequest.ScheduleExpressionTimezone);
                }

                if(publicRequest.IsSetStartDate())
                {
                    context.Writer.WritePropertyName("StartDate");
                    context.Writer.Write(publicRequest.StartDate);
                }

                if(publicRequest.IsSetState())
                {
                    context.Writer.WritePropertyName("State");
                    context.Writer.Write(publicRequest.State);
                }

                if(publicRequest.IsSetTarget())
                {
                    context.Writer.WritePropertyName("Target");
                    context.Writer.WriteObjectStart();

                    var marshaller = TargetMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Target, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateScheduleRequestMarshaller _instance = new UpdateScheduleRequestMarshaller();        

        internal static UpdateScheduleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateScheduleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
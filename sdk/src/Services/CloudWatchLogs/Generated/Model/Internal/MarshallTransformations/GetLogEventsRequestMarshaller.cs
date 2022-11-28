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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetLogEvents Request Marshaller
    /// </summary>       
    public class GetLogEventsRequestMarshaller : IMarshaller<IRequest, GetLogEventsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetLogEventsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetLogEventsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchLogs");
            string target = "Logs_20140328.GetLogEvents";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-03-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEndTime())
                {
                    context.Writer.WritePropertyName("endTime");
                    context.Writer.Write(Amazon.Runtime.Internal.Transform.CustomMarshallTransformations.ConvertDateTimeToEpochMilliseconds(publicRequest.EndTime));
                }

                if(publicRequest.IsSetLimit())
                {
                    context.Writer.WritePropertyName("limit");
                    context.Writer.Write(publicRequest.Limit);
                }

                if(publicRequest.IsSetLogGroupIdentifier())
                {
                    context.Writer.WritePropertyName("logGroupIdentifier");
                    context.Writer.Write(publicRequest.LogGroupIdentifier);
                }

                if(publicRequest.IsSetLogGroupName())
                {
                    context.Writer.WritePropertyName("logGroupName");
                    context.Writer.Write(publicRequest.LogGroupName);
                }

                if(publicRequest.IsSetLogStreamName())
                {
                    context.Writer.WritePropertyName("logStreamName");
                    context.Writer.Write(publicRequest.LogStreamName);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("nextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetStartFromHead())
                {
                    context.Writer.WritePropertyName("startFromHead");
                    context.Writer.Write(publicRequest.StartFromHead);
                }

                if(publicRequest.IsSetStartTime())
                {
                    context.Writer.WritePropertyName("startTime");
                    context.Writer.Write(Amazon.Runtime.Internal.Transform.CustomMarshallTransformations.ConvertDateTimeToEpochMilliseconds(publicRequest.StartTime));
                }

                if(publicRequest.IsSetUnmask())
                {
                    context.Writer.WritePropertyName("unmask");
                    context.Writer.Write(publicRequest.Unmask);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetLogEventsRequestMarshaller _instance = new GetLogEventsRequestMarshaller();        

        internal static GetLogEventsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetLogEventsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
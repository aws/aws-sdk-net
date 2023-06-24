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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TimestreamQuery.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.TimestreamQuery.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateScheduledQuery Request Marshaller
    /// </summary>       
    public class CreateScheduledQueryRequestMarshaller : IMarshaller<IRequest, CreateScheduledQueryRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateScheduledQueryRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateScheduledQueryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TimestreamQuery");
            string target = "Timestream_20181101.CreateScheduledQuery";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
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
                if(publicRequest.IsSetErrorReportConfiguration())
                {
                    context.Writer.WritePropertyName("ErrorReportConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ErrorReportConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ErrorReportConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetKmsKeyId())
                {
                    context.Writer.WritePropertyName("KmsKeyId");
                    context.Writer.Write(publicRequest.KmsKeyId);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetNotificationConfiguration())
                {
                    context.Writer.WritePropertyName("NotificationConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = NotificationConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NotificationConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetQueryString())
                {
                    context.Writer.WritePropertyName("QueryString");
                    context.Writer.Write(publicRequest.QueryString);
                }

                if(publicRequest.IsSetScheduleConfiguration())
                {
                    context.Writer.WritePropertyName("ScheduleConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ScheduleConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ScheduleConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetScheduledQueryExecutionRoleArn())
                {
                    context.Writer.WritePropertyName("ScheduledQueryExecutionRoleArn");
                    context.Writer.Write(publicRequest.ScheduledQueryExecutionRoleArn);
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

                if(publicRequest.IsSetTargetConfiguration())
                {
                    context.Writer.WritePropertyName("TargetConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = TargetConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TargetConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateScheduledQueryRequestMarshaller _instance = new CreateScheduledQueryRequestMarshaller();        

        internal static CreateScheduledQueryRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateScheduledQueryRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
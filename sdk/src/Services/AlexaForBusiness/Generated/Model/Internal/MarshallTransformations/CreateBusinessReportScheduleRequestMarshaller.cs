/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AlexaForBusiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AlexaForBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateBusinessReportSchedule Request Marshaller
    /// </summary>       
    public class CreateBusinessReportScheduleRequestMarshaller : IMarshaller<IRequest, CreateBusinessReportScheduleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateBusinessReportScheduleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateBusinessReportScheduleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AlexaForBusiness");
            string target = "AlexaForBusiness.CreateBusinessReportSchedule";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-09";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                else if(!(publicRequest.IsSetClientRequestToken()))
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetContentRange())
                {
                    context.Writer.WritePropertyName("ContentRange");
                    context.Writer.WriteObjectStart();

                    var marshaller = BusinessReportContentRangeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ContentRange, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFormat())
                {
                    context.Writer.WritePropertyName("Format");
                    context.Writer.Write(publicRequest.Format);
                }

                if(publicRequest.IsSetRecurrence())
                {
                    context.Writer.WritePropertyName("Recurrence");
                    context.Writer.WriteObjectStart();

                    var marshaller = BusinessReportRecurrenceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Recurrence, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetS3BucketName())
                {
                    context.Writer.WritePropertyName("S3BucketName");
                    context.Writer.Write(publicRequest.S3BucketName);
                }

                if(publicRequest.IsSetS3KeyPrefix())
                {
                    context.Writer.WritePropertyName("S3KeyPrefix");
                    context.Writer.Write(publicRequest.S3KeyPrefix);
                }

                if(publicRequest.IsSetScheduleName())
                {
                    context.Writer.WritePropertyName("ScheduleName");
                    context.Writer.Write(publicRequest.ScheduleName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateBusinessReportScheduleRequestMarshaller _instance = new CreateBusinessReportScheduleRequestMarshaller();        

        internal static CreateBusinessReportScheduleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateBusinessReportScheduleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
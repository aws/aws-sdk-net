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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchUpdateSchedule Request Marshaller
    /// </summary>       
    public class BatchUpdateScheduleRequestMarshaller : IMarshaller<IRequest, BatchUpdateScheduleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchUpdateScheduleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchUpdateScheduleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaLive");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "PUT";

            string uriResourcePath = "/prod/channels/{channelId}/schedule";
            if (!publicRequest.IsSetChannelId())
                throw new AmazonMediaLiveException("Request object does not have required field ChannelId set");
            uriResourcePath = uriResourcePath.Replace("{channelId}", StringUtils.FromString(publicRequest.ChannelId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCreates())
                {
                    context.Writer.WritePropertyName("creates");
                    context.Writer.WriteObjectStart();

                    var marshaller = BatchScheduleActionCreateRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Creates, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDeletes())
                {
                    context.Writer.WritePropertyName("deletes");
                    context.Writer.WriteObjectStart();

                    var marshaller = BatchScheduleActionDeleteRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Deletes, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static BatchUpdateScheduleRequestMarshaller _instance = new BatchUpdateScheduleRequestMarshaller();        

        internal static BatchUpdateScheduleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchUpdateScheduleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchRUM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudWatchRUM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutRumEvents Request Marshaller
    /// </summary>       
    public class PutRumEventsRequestMarshaller : IMarshaller<IRequest, PutRumEventsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutRumEventsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutRumEventsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchRUM");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetId())
                throw new AmazonCloudWatchRUMException("Request object does not have required field Id set");
            request.AddPathResource("{Id}", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = "/appmonitors/{Id}/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAppMonitorDetails())
                {
                    context.Writer.WritePropertyName("AppMonitorDetails");
                    context.Writer.WriteObjectStart();

                    var marshaller = AppMonitorDetailsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AppMonitorDetails, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetBatchId())
                {
                    context.Writer.WritePropertyName("BatchId");
                    context.Writer.Write(publicRequest.BatchId);
                }

                if(publicRequest.IsSetRumEvents())
                {
                    context.Writer.WritePropertyName("RumEvents");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRumEventsListValue in publicRequest.RumEvents)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RumEventMarshaller.Instance;
                        marshaller.Marshall(publicRequestRumEventsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetUserDetails())
                {
                    context.Writer.WritePropertyName("UserDetails");
                    context.Writer.WriteObjectStart();

                    var marshaller = UserDetailsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.UserDetails, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"dataplane.";

            return request;
        }
        private static PutRumEventsRequestMarshaller _instance = new PutRumEventsRequestMarshaller();        

        internal static PutRumEventsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutRumEventsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
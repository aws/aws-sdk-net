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
 * Do not modify this file. This file is generated from the cloudtrail-data-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudTrailData.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudTrailData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutAuditEvents Request Marshaller
    /// </summary>       
    public class PutAuditEventsRequestMarshaller : IMarshaller<IRequest, PutAuditEventsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutAuditEventsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutAuditEventsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudTrailData");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-08-11";
            request.HttpMethod = "POST";

            
            if (publicRequest.IsSetChannelArn())
                request.Parameters.Add("channelArn", StringUtils.FromString(publicRequest.ChannelArn));
            
            if (publicRequest.IsSetExternalId())
                request.Parameters.Add("externalId", StringUtils.FromString(publicRequest.ExternalId));
            request.ResourcePath = "/PutAuditEvents";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuditEvents())
                {
                    context.Writer.WritePropertyName("auditEvents");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAuditEventsListValue in publicRequest.AuditEvents)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AuditEventMarshaller.Instance;
                        marshaller.Marshall(publicRequestAuditEventsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;

            return request;
        }
        private static PutAuditEventsRequestMarshaller _instance = new PutAuditEventsRequestMarshaller();        

        internal static PutAuditEventsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutAuditEventsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
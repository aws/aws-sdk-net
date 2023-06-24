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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FraudDetector.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FraudDetector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateEventLabel Request Marshaller
    /// </summary>       
    public class UpdateEventLabelRequestMarshaller : IMarshaller<IRequest, UpdateEventLabelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateEventLabelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateEventLabelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.FraudDetector");
            string target = "AWSHawksNestServiceFacade.UpdateEventLabel";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAssignedLabel())
                {
                    context.Writer.WritePropertyName("assignedLabel");
                    context.Writer.Write(publicRequest.AssignedLabel);
                }

                if(publicRequest.IsSetEventId())
                {
                    context.Writer.WritePropertyName("eventId");
                    context.Writer.Write(publicRequest.EventId);
                }

                if(publicRequest.IsSetEventTypeName())
                {
                    context.Writer.WritePropertyName("eventTypeName");
                    context.Writer.Write(publicRequest.EventTypeName);
                }

                if(publicRequest.IsSetLabelTimestamp())
                {
                    context.Writer.WritePropertyName("labelTimestamp");
                    context.Writer.Write(publicRequest.LabelTimestamp);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateEventLabelRequestMarshaller _instance = new UpdateEventLabelRequestMarshaller();        

        internal static UpdateEventLabelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateEventLabelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.FraudDetector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendEvent Request Marshaller
    /// </summary>       
    public class SendEventRequestMarshaller : IMarshaller<IRequest, SendEventRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendEventRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendEventRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.FraudDetector");
            string target = "AWSHawksNestServiceFacade.SendEvent";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAssignedLabel())
            {
                context.Writer.WritePropertyName("assignedLabel");
                context.Writer.WriteStringValue(publicRequest.AssignedLabel);
            }

            if(publicRequest.IsSetEntities())
            {
                context.Writer.WritePropertyName("entities");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEntitiesListValue in publicRequest.Entities)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EntityMarshaller.Instance;
                    marshaller.Marshall(publicRequestEntitiesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetEventId())
            {
                context.Writer.WritePropertyName("eventId");
                context.Writer.WriteStringValue(publicRequest.EventId);
            }

            if(publicRequest.IsSetEventTimestamp())
            {
                context.Writer.WritePropertyName("eventTimestamp");
                context.Writer.WriteStringValue(publicRequest.EventTimestamp);
            }

            if(publicRequest.IsSetEventTypeName())
            {
                context.Writer.WritePropertyName("eventTypeName");
                context.Writer.WriteStringValue(publicRequest.EventTypeName);
            }

            if(publicRequest.IsSetEventVariables())
            {
                context.Writer.WritePropertyName("eventVariables");
                context.Writer.WriteStartObject();
                foreach (var publicRequestEventVariablesKvp in publicRequest.EventVariables)
                {
                    context.Writer.WritePropertyName(publicRequestEventVariablesKvp.Key);
                    var publicRequestEventVariablesValue = publicRequestEventVariablesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestEventVariablesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetLabelTimestamp())
            {
                context.Writer.WritePropertyName("labelTimestamp");
                context.Writer.WriteStringValue(publicRequest.LabelTimestamp);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static SendEventRequestMarshaller _instance = new SendEventRequestMarshaller();        

        internal static SendEventRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendEventRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
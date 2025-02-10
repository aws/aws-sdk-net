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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
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
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateEventTrigger Request Marshaller
    /// </summary>       
    public class UpdateEventTriggerRequestMarshaller : IMarshaller<IRequest, UpdateEventTriggerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateEventTriggerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateEventTriggerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CustomerProfiles");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-15";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetDomainName())
                throw new AmazonCustomerProfilesException("Request object does not have required field DomainName set");
            request.AddPathResource("{DomainName}", StringUtils.FromString(publicRequest.DomainName));
            if (!publicRequest.IsSetEventTriggerName())
                throw new AmazonCustomerProfilesException("Request object does not have required field EventTriggerName set");
            request.AddPathResource("{EventTriggerName}", StringUtils.FromString(publicRequest.EventTriggerName));
            request.ResourcePath = "/domains/{DomainName}/event-triggers/{EventTriggerName}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEventTriggerConditions())
            {
                context.Writer.WritePropertyName("EventTriggerConditions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEventTriggerConditionsListValue in publicRequest.EventTriggerConditions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EventTriggerConditionMarshaller.Instance;
                    marshaller.Marshall(publicRequestEventTriggerConditionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetEventTriggerLimits())
            {
                context.Writer.WritePropertyName("EventTriggerLimits");
                context.Writer.WriteStartObject();

                var marshaller = EventTriggerLimitsMarshaller.Instance;
                marshaller.Marshall(publicRequest.EventTriggerLimits, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetObjectTypeName())
            {
                context.Writer.WritePropertyName("ObjectTypeName");
                context.Writer.WriteStringValue(publicRequest.ObjectTypeName);
            }

            if(publicRequest.IsSetSegmentFilter())
            {
                context.Writer.WritePropertyName("SegmentFilter");
                context.Writer.WriteStringValue(publicRequest.SegmentFilter);
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
        private static UpdateEventTriggerRequestMarshaller _instance = new UpdateEventTriggerRequestMarshaller();        

        internal static UpdateEventTriggerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateEventTriggerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
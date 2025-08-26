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
 * Do not modify this file. This file is generated from the arc-zonal-shift-2022-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ARCZonalShift.Model;
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
namespace Amazon.ARCZonalShift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreatePracticeRunConfiguration Request Marshaller
    /// </summary>       
    public class CreatePracticeRunConfigurationRequestMarshaller : IMarshaller<IRequest, CreatePracticeRunConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreatePracticeRunConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreatePracticeRunConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ARCZonalShift");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-10-30";
            request.HttpMethod = "POST";

            request.ResourcePath = "/configuration";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAllowedWindows())
            {
                context.Writer.WritePropertyName("allowedWindows");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAllowedWindowsListValue in publicRequest.AllowedWindows)
                {
                        context.Writer.WriteStringValue(publicRequestAllowedWindowsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetBlockedDates())
            {
                context.Writer.WritePropertyName("blockedDates");
                context.Writer.WriteStartArray();
                foreach(var publicRequestBlockedDatesListValue in publicRequest.BlockedDates)
                {
                        context.Writer.WriteStringValue(publicRequestBlockedDatesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetBlockedWindows())
            {
                context.Writer.WritePropertyName("blockedWindows");
                context.Writer.WriteStartArray();
                foreach(var publicRequestBlockedWindowsListValue in publicRequest.BlockedWindows)
                {
                        context.Writer.WriteStringValue(publicRequestBlockedWindowsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetBlockingAlarms())
            {
                context.Writer.WritePropertyName("blockingAlarms");
                context.Writer.WriteStartArray();
                foreach(var publicRequestBlockingAlarmsListValue in publicRequest.BlockingAlarms)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ControlConditionMarshaller.Instance;
                    marshaller.Marshall(publicRequestBlockingAlarmsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOutcomeAlarms())
            {
                context.Writer.WritePropertyName("outcomeAlarms");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOutcomeAlarmsListValue in publicRequest.OutcomeAlarms)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ControlConditionMarshaller.Instance;
                    marshaller.Marshall(publicRequestOutcomeAlarmsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetResourceIdentifier())
            {
                context.Writer.WritePropertyName("resourceIdentifier");
                context.Writer.WriteStringValue(publicRequest.ResourceIdentifier);
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
        private static CreatePracticeRunConfigurationRequestMarshaller _instance = new CreatePracticeRunConfigurationRequestMarshaller();        

        internal static CreatePracticeRunConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreatePracticeRunConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
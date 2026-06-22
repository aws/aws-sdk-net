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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationSignals.Model;
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
namespace Amazon.ApplicationSignals.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetInstrumentationConfigurationStatus Request Marshaller
    /// </summary>       
    public class GetInstrumentationConfigurationStatusRequestMarshaller : IMarshaller<IRequest, GetInstrumentationConfigurationStatusRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetInstrumentationConfigurationStatusRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetInstrumentationConfigurationStatusRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApplicationSignals");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-04-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/get-instrumentation-configuration-status";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetEndTime())
            {
                context.Writer.WritePropertyName("EndTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.EndTime.Value)));
            }

            if(publicRequest.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("Environment");
                context.Writer.WriteStringValue(publicRequest.Environment);
            }

            if(publicRequest.IsSetInstrumentationType())
            {
                context.Writer.WritePropertyName("InstrumentationType");
                context.Writer.WriteStringValue(publicRequest.InstrumentationType);
            }

            if(publicRequest.IsSetLocationIdentifier())
            {
                context.Writer.WritePropertyName("LocationIdentifier");
                context.Writer.WriteStartObject();

                var marshaller = LocationIdentifierMarshaller.Instance;
                marshaller.Marshall(publicRequest.LocationIdentifier, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("MaxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }

            if(publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("NextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }

            if(publicRequest.IsSetService())
            {
                context.Writer.WritePropertyName("Service");
                context.Writer.WriteStringValue(publicRequest.Service);
            }

            if(publicRequest.IsSetSignalType())
            {
                context.Writer.WritePropertyName("SignalType");
                context.Writer.WriteStringValue(publicRequest.SignalType);
            }

            if(publicRequest.IsSetStartTime())
            {
                context.Writer.WritePropertyName("StartTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.StartTime.Value)));
            }

            if(publicRequest.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(publicRequest.Status);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static GetInstrumentationConfigurationStatusRequestMarshaller _instance = new GetInstrumentationConfigurationStatusRequestMarshaller();        

        internal static GetInstrumentationConfigurationStatusRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetInstrumentationConfigurationStatusRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
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
    /// CreateInstrumentationConfiguration Request Marshaller
    /// </summary>       
    public class CreateInstrumentationConfigurationRequestMarshaller : IMarshaller<IRequest, CreateInstrumentationConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateInstrumentationConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateInstrumentationConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApplicationSignals");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-04-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/create-instrumentation-configuration";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAttributeFilters())
            {
                context.Writer.WritePropertyName("AttributeFilters");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAttributeFiltersListValue in publicRequest.AttributeFilters)
                {
                    context.Writer.WriteStartObject();
                    foreach (var publicRequestAttributeFiltersListValueKvp in publicRequestAttributeFiltersListValue)
                    {
                        context.Writer.WritePropertyName(publicRequestAttributeFiltersListValueKvp.Key);
                        var publicRequestAttributeFiltersListValueValue = publicRequestAttributeFiltersListValueKvp.Value;

                            context.Writer.WriteStringValue(publicRequestAttributeFiltersListValueValue);
                    }
                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetCaptureConfiguration())
            {
                context.Writer.WritePropertyName("CaptureConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = CaptureConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.CaptureConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("Environment");
                context.Writer.WriteStringValue(publicRequest.Environment);
            }

            if(publicRequest.IsSetExpiresAt())
            {
                context.Writer.WritePropertyName("ExpiresAt");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.ExpiresAt.Value)));
            }

            if(publicRequest.IsSetInstrumentationType())
            {
                context.Writer.WritePropertyName("InstrumentationType");
                context.Writer.WriteStringValue(publicRequest.InstrumentationType);
            }

            if(publicRequest.IsSetLocation())
            {
                context.Writer.WritePropertyName("Location");
                context.Writer.WriteStartObject();

                var marshaller = LocationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Location, context);

                context.Writer.WriteEndObject();
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

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateInstrumentationConfigurationRequestMarshaller _instance = new CreateInstrumentationConfigurationRequestMarshaller();        

        internal static CreateInstrumentationConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateInstrumentationConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
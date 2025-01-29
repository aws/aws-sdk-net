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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
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
namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateSecurityProfile Request Marshaller
    /// </summary>       
    public class CreateSecurityProfileRequestMarshaller : IMarshaller<IRequest, CreateSecurityProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSecurityProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSecurityProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetSecurityProfileName())
                throw new AmazonIoTException("Request object does not have required field SecurityProfileName set");
            request.AddPathResource("{securityProfileName}", StringUtils.FromString(publicRequest.SecurityProfileName));
            request.ResourcePath = "/security-profiles/{securityProfileName}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAdditionalMetricsToRetain())
            {
                context.Writer.WritePropertyName("additionalMetricsToRetain");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAdditionalMetricsToRetainListValue in publicRequest.AdditionalMetricsToRetain)
                {
                        context.Writer.WriteStringValue(publicRequestAdditionalMetricsToRetainListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAdditionalMetricsToRetainV2())
            {
                context.Writer.WritePropertyName("additionalMetricsToRetainV2");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAdditionalMetricsToRetainV2ListValue in publicRequest.AdditionalMetricsToRetainV2)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MetricToRetainMarshaller.Instance;
                    marshaller.Marshall(publicRequestAdditionalMetricsToRetainV2ListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAlertTargets())
            {
                context.Writer.WritePropertyName("alertTargets");
                context.Writer.WriteStartObject();
                foreach (var publicRequestAlertTargetsKvp in publicRequest.AlertTargets)
                {
                    context.Writer.WritePropertyName(publicRequestAlertTargetsKvp.Key);
                    var publicRequestAlertTargetsValue = publicRequestAlertTargetsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = AlertTargetMarshaller.Instance;
                    marshaller.Marshall(publicRequestAlertTargetsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetBehaviors())
            {
                context.Writer.WritePropertyName("behaviors");
                context.Writer.WriteStartArray();
                foreach(var publicRequestBehaviorsListValue in publicRequest.Behaviors)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = BehaviorMarshaller.Instance;
                    marshaller.Marshall(publicRequestBehaviorsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMetricsExportConfig())
            {
                context.Writer.WritePropertyName("metricsExportConfig");
                context.Writer.WriteStartObject();

                var marshaller = MetricsExportConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.MetricsExportConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSecurityProfileDescription())
            {
                context.Writer.WritePropertyName("securityProfileDescription");
                context.Writer.WriteStringValue(publicRequest.SecurityProfileDescription);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
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
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateSecurityProfileRequestMarshaller _instance = new CreateSecurityProfileRequestMarshaller();        

        internal static CreateSecurityProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSecurityProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
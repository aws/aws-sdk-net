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
    /// UpdateServiceLevelObjective Request Marshaller
    /// </summary>       
    public class UpdateServiceLevelObjectiveRequestMarshaller : IMarshaller<IRequest, UpdateServiceLevelObjectiveRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateServiceLevelObjectiveRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateServiceLevelObjectiveRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApplicationSignals");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-04-15";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetId())
                throw new AmazonApplicationSignalsException("Request object does not have required field Id set");
            request.AddPathResource("{Id}", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = "/slo/{Id}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetBurnRateConfigurations())
            {
                context.Writer.WritePropertyName("BurnRateConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestBurnRateConfigurationsListValue in publicRequest.BurnRateConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = BurnRateConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestBurnRateConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetGoal())
            {
                context.Writer.WritePropertyName("Goal");
                context.Writer.WriteStartObject();

                var marshaller = GoalMarshaller.Instance;
                marshaller.Marshall(publicRequest.Goal, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRequestBasedSliConfig())
            {
                context.Writer.WritePropertyName("RequestBasedSliConfig");
                context.Writer.WriteStartObject();

                var marshaller = RequestBasedServiceLevelIndicatorConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.RequestBasedSliConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSliConfig())
            {
                context.Writer.WritePropertyName("SliConfig");
                context.Writer.WriteStartObject();

                var marshaller = ServiceLevelIndicatorConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.SliConfig, context);

                context.Writer.WriteEndObject();
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
        private static UpdateServiceLevelObjectiveRequestMarshaller _instance = new UpdateServiceLevelObjectiveRequestMarshaller();        

        internal static UpdateServiceLevelObjectiveRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateServiceLevelObjectiveRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
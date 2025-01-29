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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRoomsML.Model;
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
namespace Amazon.CleanRoomsML.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateConfiguredAudienceModel Request Marshaller
    /// </summary>       
    public class UpdateConfiguredAudienceModelRequestMarshaller : IMarshaller<IRequest, UpdateConfiguredAudienceModelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateConfiguredAudienceModelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateConfiguredAudienceModelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CleanRoomsML");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-09-06";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetConfiguredAudienceModelArn())
                throw new AmazonCleanRoomsMLException("Request object does not have required field ConfiguredAudienceModelArn set");
            request.AddPathResource("{configuredAudienceModelArn}", StringUtils.FromString(publicRequest.ConfiguredAudienceModelArn));
            request.ResourcePath = "/configured-audience-model/{configuredAudienceModelArn}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAudienceModelArn())
            {
                context.Writer.WritePropertyName("audienceModelArn");
                context.Writer.WriteStringValue(publicRequest.AudienceModelArn);
            }

            if(publicRequest.IsSetAudienceSizeConfig())
            {
                context.Writer.WritePropertyName("audienceSizeConfig");
                context.Writer.WriteStartObject();

                var marshaller = AudienceSizeConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.AudienceSizeConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetMinMatchingSeedSize())
            {
                context.Writer.WritePropertyName("minMatchingSeedSize");
                context.Writer.WriteNumberValue(publicRequest.MinMatchingSeedSize.Value);
            }

            if(publicRequest.IsSetOutputConfig())
            {
                context.Writer.WritePropertyName("outputConfig");
                context.Writer.WriteStartObject();

                var marshaller = ConfiguredAudienceModelOutputConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutputConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSharedAudienceMetrics())
            {
                context.Writer.WritePropertyName("sharedAudienceMetrics");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSharedAudienceMetricsListValue in publicRequest.SharedAudienceMetrics)
                {
                        context.Writer.WriteStringValue(publicRequestSharedAudienceMetricsListValue);
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
        private static UpdateConfiguredAudienceModelRequestMarshaller _instance = new UpdateConfiguredAudienceModelRequestMarshaller();        

        internal static UpdateConfiguredAudienceModelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateConfiguredAudienceModelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
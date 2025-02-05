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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GroundStation.Model;
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
namespace Amazon.GroundStation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMissionProfile Request Marshaller
    /// </summary>       
    public class UpdateMissionProfileRequestMarshaller : IMarshaller<IRequest, UpdateMissionProfileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMissionProfileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateMissionProfileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GroundStation");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-05-23";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetMissionProfileId())
                throw new AmazonGroundStationException("Request object does not have required field MissionProfileId set");
            request.AddPathResource("{missionProfileId}", StringUtils.FromString(publicRequest.MissionProfileId));
            request.ResourcePath = "/missionprofile/{missionProfileId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetContactPostPassDurationSeconds())
            {
                context.Writer.WritePropertyName("contactPostPassDurationSeconds");
                context.Writer.WriteNumberValue(publicRequest.ContactPostPassDurationSeconds.Value);
            }

            if(publicRequest.IsSetContactPrePassDurationSeconds())
            {
                context.Writer.WritePropertyName("contactPrePassDurationSeconds");
                context.Writer.WriteNumberValue(publicRequest.ContactPrePassDurationSeconds.Value);
            }

            if(publicRequest.IsSetDataflowEdges())
            {
                context.Writer.WritePropertyName("dataflowEdges");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDataflowEdgesListValue in publicRequest.DataflowEdges)
                {
                    context.Writer.WriteStartArray();
                    foreach(var publicRequestDataflowEdgesListValueListValue in publicRequestDataflowEdgesListValue)
                    {
                            context.Writer.WriteStringValue(publicRequestDataflowEdgesListValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMinimumViableContactDurationSeconds())
            {
                context.Writer.WritePropertyName("minimumViableContactDurationSeconds");
                context.Writer.WriteNumberValue(publicRequest.MinimumViableContactDurationSeconds.Value);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetStreamsKmsKey())
            {
                context.Writer.WritePropertyName("streamsKmsKey");
                context.Writer.WriteStartObject();

                var marshaller = KmsKeyMarshaller.Instance;
                marshaller.Marshall(publicRequest.StreamsKmsKey, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetStreamsKmsRole())
            {
                context.Writer.WritePropertyName("streamsKmsRole");
                context.Writer.WriteStringValue(publicRequest.StreamsKmsRole);
            }

            if(publicRequest.IsSetTrackingConfigArn())
            {
                context.Writer.WritePropertyName("trackingConfigArn");
                context.Writer.WriteStringValue(publicRequest.TrackingConfigArn);
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
        private static UpdateMissionProfileRequestMarshaller _instance = new UpdateMissionProfileRequestMarshaller();        

        internal static UpdateMissionProfileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateMissionProfileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
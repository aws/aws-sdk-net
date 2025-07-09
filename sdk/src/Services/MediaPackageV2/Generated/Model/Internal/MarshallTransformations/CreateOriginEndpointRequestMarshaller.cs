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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackageV2.Model;
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
namespace Amazon.MediaPackageV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateOriginEndpoint Request Marshaller
    /// </summary>       
    public class CreateOriginEndpointRequestMarshaller : IMarshaller<IRequest, CreateOriginEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateOriginEndpointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateOriginEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaPackageV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-12-25";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetChannelGroupName())
                throw new AmazonMediaPackageV2Exception("Request object does not have required field ChannelGroupName set");
            request.AddPathResource("{ChannelGroupName}", StringUtils.FromString(publicRequest.ChannelGroupName));
            if (!publicRequest.IsSetChannelName())
                throw new AmazonMediaPackageV2Exception("Request object does not have required field ChannelName set");
            request.AddPathResource("{ChannelName}", StringUtils.FromString(publicRequest.ChannelName));
            request.ResourcePath = "/channelGroup/{ChannelGroupName}/channel/{ChannelName}/originEndpoint";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetContainerType())
            {
                context.Writer.WritePropertyName("ContainerType");
                context.Writer.WriteStringValue(publicRequest.ContainerType);
            }

            if(publicRequest.IsSetDashManifests())
            {
                context.Writer.WritePropertyName("DashManifests");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDashManifestsListValue in publicRequest.DashManifests)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CreateDashManifestConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestDashManifestsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetForceEndpointErrorConfiguration())
            {
                context.Writer.WritePropertyName("ForceEndpointErrorConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ForceEndpointErrorConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ForceEndpointErrorConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetHlsManifests())
            {
                context.Writer.WritePropertyName("HlsManifests");
                context.Writer.WriteStartArray();
                foreach(var publicRequestHlsManifestsListValue in publicRequest.HlsManifests)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CreateHlsManifestConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestHlsManifestsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetLowLatencyHlsManifests())
            {
                context.Writer.WritePropertyName("LowLatencyHlsManifests");
                context.Writer.WriteStartArray();
                foreach(var publicRequestLowLatencyHlsManifestsListValue in publicRequest.LowLatencyHlsManifests)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CreateLowLatencyHlsManifestConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestLowLatencyHlsManifestsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMssManifests())
            {
                context.Writer.WritePropertyName("MssManifests");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMssManifestsListValue in publicRequest.MssManifests)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CreateMssManifestConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestMssManifestsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOriginEndpointName())
            {
                context.Writer.WritePropertyName("OriginEndpointName");
                context.Writer.WriteStringValue(publicRequest.OriginEndpointName);
            }

            if(publicRequest.IsSetSegment())
            {
                context.Writer.WritePropertyName("Segment");
                context.Writer.WriteStartObject();

                var marshaller = SegmentMarshaller.Instance;
                marshaller.Marshall(publicRequest.Segment, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetStartoverWindowSeconds())
            {
                context.Writer.WritePropertyName("StartoverWindowSeconds");
                context.Writer.WriteNumberValue(publicRequest.StartoverWindowSeconds.Value);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
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
            

        
            if (publicRequest.IsSetClientToken()) 
            {
                request.Headers["x-amzn-client-token"] = publicRequest.ClientToken;
            }

            return request;
        }
        private static CreateOriginEndpointRequestMarshaller _instance = new CreateOriginEndpointRequestMarshaller();        

        internal static CreateOriginEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateOriginEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
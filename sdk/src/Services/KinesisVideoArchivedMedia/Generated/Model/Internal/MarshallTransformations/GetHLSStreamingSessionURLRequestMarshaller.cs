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
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisVideoArchivedMedia.Model;
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
namespace Amazon.KinesisVideoArchivedMedia.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetHLSStreamingSessionURL Request Marshaller
    /// </summary>       
    public class GetHLSStreamingSessionURLRequestMarshaller : IMarshaller<IRequest, GetHLSStreamingSessionURLRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetHLSStreamingSessionURLRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetHLSStreamingSessionURLRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KinesisVideoArchivedMedia");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-09-30";
            request.HttpMethod = "POST";

            request.ResourcePath = "/getHLSStreamingSessionURL";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetContainerFormat())
            {
                context.Writer.WritePropertyName("ContainerFormat");
                context.Writer.WriteStringValue(publicRequest.ContainerFormat);
            }

            if(publicRequest.IsSetDiscontinuityMode())
            {
                context.Writer.WritePropertyName("DiscontinuityMode");
                context.Writer.WriteStringValue(publicRequest.DiscontinuityMode);
            }

            if(publicRequest.IsSetDisplayFragmentTimestamp())
            {
                context.Writer.WritePropertyName("DisplayFragmentTimestamp");
                context.Writer.WriteStringValue(publicRequest.DisplayFragmentTimestamp);
            }

            if(publicRequest.IsSetExpires())
            {
                context.Writer.WritePropertyName("Expires");
                context.Writer.WriteNumberValue(publicRequest.Expires.Value);
            }

            if(publicRequest.IsSetHLSFragmentSelector())
            {
                context.Writer.WritePropertyName("HLSFragmentSelector");
                context.Writer.WriteStartObject();

                var marshaller = HLSFragmentSelectorMarshaller.Instance;
                marshaller.Marshall(publicRequest.HLSFragmentSelector, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMaxMediaPlaylistFragmentResults())
            {
                context.Writer.WritePropertyName("MaxMediaPlaylistFragmentResults");
                context.Writer.WriteNumberValue(publicRequest.MaxMediaPlaylistFragmentResults.Value);
            }

            if(publicRequest.IsSetPlaybackMode())
            {
                context.Writer.WritePropertyName("PlaybackMode");
                context.Writer.WriteStringValue(publicRequest.PlaybackMode);
            }

            if(publicRequest.IsSetStreamARN())
            {
                context.Writer.WritePropertyName("StreamARN");
                context.Writer.WriteStringValue(publicRequest.StreamARN);
            }

            if(publicRequest.IsSetStreamName())
            {
                context.Writer.WritePropertyName("StreamName");
                context.Writer.WriteStringValue(publicRequest.StreamName);
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
        private static GetHLSStreamingSessionURLRequestMarshaller _instance = new GetHLSStreamingSessionURLRequestMarshaller();        

        internal static GetHLSStreamingSessionURLRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetHLSStreamingSessionURLRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
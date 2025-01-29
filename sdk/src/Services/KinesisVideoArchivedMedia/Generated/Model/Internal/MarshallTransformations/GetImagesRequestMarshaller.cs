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
    /// GetImages Request Marshaller
    /// </summary>       
    public class GetImagesRequestMarshaller : IMarshaller<IRequest, GetImagesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetImagesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetImagesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KinesisVideoArchivedMedia");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-09-30";
            request.HttpMethod = "POST";

            request.ResourcePath = "/getImages";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetEndTimestamp())
            {
                context.Writer.WritePropertyName("EndTimestamp");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.EndTimestamp.Value)));
            }

            if(publicRequest.IsSetFormat())
            {
                context.Writer.WritePropertyName("Format");
                context.Writer.WriteStringValue(publicRequest.Format);
            }

            if(publicRequest.IsSetFormatConfig())
            {
                context.Writer.WritePropertyName("FormatConfig");
                context.Writer.WriteStartObject();
                foreach (var publicRequestFormatConfigKvp in publicRequest.FormatConfig)
                {
                    context.Writer.WritePropertyName(publicRequestFormatConfigKvp.Key);
                    var publicRequestFormatConfigValue = publicRequestFormatConfigKvp.Value;

                        context.Writer.WriteStringValue(publicRequestFormatConfigValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetHeightPixels())
            {
                context.Writer.WritePropertyName("HeightPixels");
                context.Writer.WriteNumberValue(publicRequest.HeightPixels.Value);
            }

            if(publicRequest.IsSetImageSelectorType())
            {
                context.Writer.WritePropertyName("ImageSelectorType");
                context.Writer.WriteStringValue(publicRequest.ImageSelectorType);
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

            if(publicRequest.IsSetSamplingInterval())
            {
                context.Writer.WritePropertyName("SamplingInterval");
                context.Writer.WriteNumberValue(publicRequest.SamplingInterval.Value);
            }

            if(publicRequest.IsSetStartTimestamp())
            {
                context.Writer.WritePropertyName("StartTimestamp");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.StartTimestamp.Value)));
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

            if(publicRequest.IsSetWidthPixels())
            {
                context.Writer.WritePropertyName("WidthPixels");
                context.Writer.WriteNumberValue(publicRequest.WidthPixels.Value);
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
        private static GetImagesRequestMarshaller _instance = new GetImagesRequestMarshaller();        

        internal static GetImagesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetImagesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
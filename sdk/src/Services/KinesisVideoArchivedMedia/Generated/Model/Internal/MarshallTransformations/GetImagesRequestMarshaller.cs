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
using ThirdParty.Json.LitJson;

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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEndTimestamp())
                {
                    context.Writer.WritePropertyName("EndTimestamp");
                    context.Writer.Write(publicRequest.EndTimestamp);
                }

                if(publicRequest.IsSetFormat())
                {
                    context.Writer.WritePropertyName("Format");
                    context.Writer.Write(publicRequest.Format);
                }

                if(publicRequest.IsSetFormatConfig())
                {
                    context.Writer.WritePropertyName("FormatConfig");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestFormatConfigKvp in publicRequest.FormatConfig)
                    {
                        context.Writer.WritePropertyName(publicRequestFormatConfigKvp.Key);
                        var publicRequestFormatConfigValue = publicRequestFormatConfigKvp.Value;

                            context.Writer.Write(publicRequestFormatConfigValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetHeightPixels())
                {
                    context.Writer.WritePropertyName("HeightPixels");
                    context.Writer.Write(publicRequest.HeightPixels);
                }

                if(publicRequest.IsSetImageSelectorType())
                {
                    context.Writer.WritePropertyName("ImageSelectorType");
                    context.Writer.Write(publicRequest.ImageSelectorType);
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("MaxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("NextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetSamplingInterval())
                {
                    context.Writer.WritePropertyName("SamplingInterval");
                    context.Writer.Write(publicRequest.SamplingInterval);
                }

                if(publicRequest.IsSetStartTimestamp())
                {
                    context.Writer.WritePropertyName("StartTimestamp");
                    context.Writer.Write(publicRequest.StartTimestamp);
                }

                if(publicRequest.IsSetStreamARN())
                {
                    context.Writer.WritePropertyName("StreamARN");
                    context.Writer.Write(publicRequest.StreamARN);
                }

                if(publicRequest.IsSetStreamName())
                {
                    context.Writer.WritePropertyName("StreamName");
                    context.Writer.Write(publicRequest.StreamName);
                }

                if(publicRequest.IsSetWidthPixels())
                {
                    context.Writer.WritePropertyName("WidthPixels");
                    context.Writer.Write(publicRequest.WidthPixels);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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
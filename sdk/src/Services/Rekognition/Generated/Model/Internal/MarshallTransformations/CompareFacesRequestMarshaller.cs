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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Rekognition.Model;
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
namespace Amazon.Rekognition.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CompareFaces Request Marshaller
    /// </summary>       
    public class CompareFacesRequestMarshaller : IMarshaller<IRequest, CompareFacesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CompareFacesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CompareFacesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Rekognition");
            string target = "RekognitionService.CompareFaces";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-06-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetQualityFilter())
            {
                context.Writer.WritePropertyName("QualityFilter");
                context.Writer.WriteStringValue(publicRequest.QualityFilter);
            }

            if(publicRequest.IsSetSimilarityThreshold())
            {
                context.Writer.WritePropertyName("SimilarityThreshold");
                if(StringUtils.IsSpecialFloatValue(publicRequest.SimilarityThreshold.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(publicRequest.SimilarityThreshold.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.SimilarityThreshold.Value);
                }
            }

            if(publicRequest.IsSetSourceImage())
            {
                context.Writer.WritePropertyName("SourceImage");
                context.Writer.WriteStartObject();

                var marshaller = ImageMarshaller.Instance;
                marshaller.Marshall(publicRequest.SourceImage, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTargetImage())
            {
                context.Writer.WritePropertyName("TargetImage");
                context.Writer.WriteStartObject();

                var marshaller = ImageMarshaller.Instance;
                marshaller.Marshall(publicRequest.TargetImage, context);

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
        private static CompareFacesRequestMarshaller _instance = new CompareFacesRequestMarshaller();        

        internal static CompareFacesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CompareFacesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
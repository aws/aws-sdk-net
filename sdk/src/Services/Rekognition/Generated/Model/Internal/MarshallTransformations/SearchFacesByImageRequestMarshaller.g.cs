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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.Rekognition.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Rekognition.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchFacesByImage Request Marshaller
    /// </summary>
    public partial class SearchFacesByImageRequestMarshaller : IMarshaller<IRequest, SearchFacesByImageRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SearchFacesByImageRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(SearchFacesByImageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Rekognition");
            string target = "RekognitionService.SearchFacesByImage";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-06-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetCollectionId())
            {
                context.Writer.WritePropertyName("CollectionId");
                context.Writer.WriteStringValue(publicRequest.CollectionId);
            }
            if (publicRequest.IsSetFaceMatchThreshold())
            {
                context.Writer.WritePropertyName("FaceMatchThreshold");
                if (StringUtils.IsSpecialFloatValue(publicRequest.FaceMatchThreshold.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(publicRequest.FaceMatchThreshold.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.FaceMatchThreshold.Value);
                }
            }
            if (publicRequest.IsSetImage())
            {
                context.Writer.WritePropertyName("Image");
                context.Writer.WriteStartObject();

                var marshaller = ImageMarshaller.Instance;
                marshaller.Marshall(publicRequest.Image, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetMaxFaces())
            {
                context.Writer.WritePropertyName("MaxFaces");
                context.Writer.WriteNumberValue(publicRequest.MaxFaces.Value);
            }
            if (publicRequest.IsSetQualityFilter())
            {
                context.Writer.WritePropertyName("QualityFilter");
                context.Writer.WriteStringValue(publicRequest.QualityFilter);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly SearchFacesByImageRequestMarshaller _instance = new();

        internal static SearchFacesByImageRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SearchFacesByImageRequestMarshaller Instance => _instance;
    }
}

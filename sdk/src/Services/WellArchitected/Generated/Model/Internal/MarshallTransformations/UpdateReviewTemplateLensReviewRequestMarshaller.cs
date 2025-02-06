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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WellArchitected.Model;
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
namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateReviewTemplateLensReview Request Marshaller
    /// </summary>       
    public class UpdateReviewTemplateLensReviewRequestMarshaller : IMarshaller<IRequest, UpdateReviewTemplateLensReviewRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateReviewTemplateLensReviewRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateReviewTemplateLensReviewRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WellArchitected");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-31";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetLensAlias())
                throw new AmazonWellArchitectedException("Request object does not have required field LensAlias set");
            request.AddPathResource("{LensAlias}", StringUtils.FromString(publicRequest.LensAlias));
            if (!publicRequest.IsSetTemplateArn())
                throw new AmazonWellArchitectedException("Request object does not have required field TemplateArn set");
            request.AddPathResource("{TemplateArn}", StringUtils.FromString(publicRequest.TemplateArn));
            request.ResourcePath = "/reviewTemplates/{TemplateArn}/lensReviews/{LensAlias}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetLensNotes())
            {
                context.Writer.WritePropertyName("LensNotes");
                context.Writer.WriteStringValue(publicRequest.LensNotes);
            }

            if(publicRequest.IsSetPillarNotes())
            {
                context.Writer.WritePropertyName("PillarNotes");
                context.Writer.WriteStartObject();
                foreach (var publicRequestPillarNotesKvp in publicRequest.PillarNotes)
                {
                    context.Writer.WritePropertyName(publicRequestPillarNotesKvp.Key);
                    var publicRequestPillarNotesValue = publicRequestPillarNotesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestPillarNotesValue);
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
            


            return request;
        }
        private static UpdateReviewTemplateLensReviewRequestMarshaller _instance = new UpdateReviewTemplateLensReviewRequestMarshaller();        

        internal static UpdateReviewTemplateLensReviewRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateReviewTemplateLensReviewRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
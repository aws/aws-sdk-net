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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
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
namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateFeaturedResultsSet Request Marshaller
    /// </summary>       
    public class UpdateFeaturedResultsSetRequestMarshaller : IMarshaller<IRequest, UpdateFeaturedResultsSetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFeaturedResultsSetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFeaturedResultsSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Kendra");
            string target = "AWSKendraFrontendService.UpdateFeaturedResultsSet";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-02-03";
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
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetFeaturedDocuments())
            {
                context.Writer.WritePropertyName("FeaturedDocuments");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFeaturedDocumentsListValue in publicRequest.FeaturedDocuments)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FeaturedDocumentMarshaller.Instance;
                    marshaller.Marshall(publicRequestFeaturedDocumentsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetFeaturedResultsSetId())
            {
                context.Writer.WritePropertyName("FeaturedResultsSetId");
                context.Writer.WriteStringValue(publicRequest.FeaturedResultsSetId);
            }

            if(publicRequest.IsSetFeaturedResultsSetName())
            {
                context.Writer.WritePropertyName("FeaturedResultsSetName");
                context.Writer.WriteStringValue(publicRequest.FeaturedResultsSetName);
            }

            if(publicRequest.IsSetIndexId())
            {
                context.Writer.WritePropertyName("IndexId");
                context.Writer.WriteStringValue(publicRequest.IndexId);
            }

            if(publicRequest.IsSetQueryTexts())
            {
                context.Writer.WritePropertyName("QueryTexts");
                context.Writer.WriteStartArray();
                foreach(var publicRequestQueryTextsListValue in publicRequest.QueryTexts)
                {
                        context.Writer.WriteStringValue(publicRequestQueryTextsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(publicRequest.Status);
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
        private static UpdateFeaturedResultsSetRequestMarshaller _instance = new UpdateFeaturedResultsSetRequestMarshaller();        

        internal static UpdateFeaturedResultsSetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFeaturedResultsSetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
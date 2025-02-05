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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Translate.Model;
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
namespace Amazon.Translate.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TranslateDocument Request Marshaller
    /// </summary>       
    public class TranslateDocumentRequestMarshaller : IMarshaller<IRequest, TranslateDocumentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((TranslateDocumentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(TranslateDocumentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Translate");
            string target = "AWSShineFrontendService_20170701.TranslateDocument";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-01";
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
            if(publicRequest.IsSetDocument())
            {
                context.Writer.WritePropertyName("Document");
                context.Writer.WriteStartObject();

                var marshaller = DocumentMarshaller.Instance;
                marshaller.Marshall(publicRequest.Document, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSettings())
            {
                context.Writer.WritePropertyName("Settings");
                context.Writer.WriteStartObject();

                var marshaller = TranslationSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Settings, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSourceLanguageCode())
            {
                context.Writer.WritePropertyName("SourceLanguageCode");
                context.Writer.WriteStringValue(publicRequest.SourceLanguageCode);
            }

            if(publicRequest.IsSetTargetLanguageCode())
            {
                context.Writer.WritePropertyName("TargetLanguageCode");
                context.Writer.WriteStringValue(publicRequest.TargetLanguageCode);
            }

            if(publicRequest.IsSetTerminologyNames())
            {
                context.Writer.WritePropertyName("TerminologyNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTerminologyNamesListValue in publicRequest.TerminologyNames)
                {
                        context.Writer.WriteStringValue(publicRequestTerminologyNamesListValue);
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
        private static TranslateDocumentRequestMarshaller _instance = new TranslateDocumentRequestMarshaller();        

        internal static TranslateDocumentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TranslateDocumentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
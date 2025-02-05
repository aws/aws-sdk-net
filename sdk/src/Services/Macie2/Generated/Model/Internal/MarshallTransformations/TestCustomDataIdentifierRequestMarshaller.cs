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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Macie2.Model;
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
namespace Amazon.Macie2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TestCustomDataIdentifier Request Marshaller
    /// </summary>       
    public class TestCustomDataIdentifierRequestMarshaller : IMarshaller<IRequest, TestCustomDataIdentifierRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((TestCustomDataIdentifierRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(TestCustomDataIdentifierRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Macie2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/custom-data-identifiers/test";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetIgnoreWords())
            {
                context.Writer.WritePropertyName("ignoreWords");
                context.Writer.WriteStartArray();
                foreach(var publicRequestIgnoreWordsListValue in publicRequest.IgnoreWords)
                {
                        context.Writer.WriteStringValue(publicRequestIgnoreWordsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetKeywords())
            {
                context.Writer.WritePropertyName("keywords");
                context.Writer.WriteStartArray();
                foreach(var publicRequestKeywordsListValue in publicRequest.Keywords)
                {
                        context.Writer.WriteStringValue(publicRequestKeywordsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMaximumMatchDistance())
            {
                context.Writer.WritePropertyName("maximumMatchDistance");
                context.Writer.WriteNumberValue(publicRequest.MaximumMatchDistance.Value);
            }

            if(publicRequest.IsSetRegex())
            {
                context.Writer.WritePropertyName("regex");
                context.Writer.WriteStringValue(publicRequest.Regex);
            }

            if(publicRequest.IsSetSampleText())
            {
                context.Writer.WritePropertyName("sampleText");
                context.Writer.WriteStringValue(publicRequest.SampleText);
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
        private static TestCustomDataIdentifierRequestMarshaller _instance = new TestCustomDataIdentifierRequestMarshaller();        

        internal static TestCustomDataIdentifierRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TestCustomDataIdentifierRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.B2bi.Model;
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
namespace Amazon.B2bi.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateTransformer Request Marshaller
    /// </summary>       
    public class UpdateTransformerRequestMarshaller : IMarshaller<IRequest, UpdateTransformerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateTransformerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateTransformerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.B2bi");
            string target = "B2BI.UpdateTransformer";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-06-23";
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
            if(publicRequest.IsSetEdiType())
            {
                context.Writer.WritePropertyName("ediType");
                context.Writer.WriteStartObject();

                var marshaller = EdiTypeMarshaller.Instance;
                marshaller.Marshall(publicRequest.EdiType, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFileFormat())
            {
                context.Writer.WritePropertyName("fileFormat");
                context.Writer.WriteStringValue(publicRequest.FileFormat);
            }

            if(publicRequest.IsSetInputConversion())
            {
                context.Writer.WritePropertyName("inputConversion");
                context.Writer.WriteStartObject();

                var marshaller = InputConversionMarshaller.Instance;
                marshaller.Marshall(publicRequest.InputConversion, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMapping())
            {
                context.Writer.WritePropertyName("mapping");
                context.Writer.WriteStartObject();

                var marshaller = MappingMarshaller.Instance;
                marshaller.Marshall(publicRequest.Mapping, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMappingTemplate())
            {
                context.Writer.WritePropertyName("mappingTemplate");
                context.Writer.WriteStringValue(publicRequest.MappingTemplate);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetOutputConversion())
            {
                context.Writer.WritePropertyName("outputConversion");
                context.Writer.WriteStartObject();

                var marshaller = OutputConversionMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutputConversion, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSampleDocument())
            {
                context.Writer.WritePropertyName("sampleDocument");
                context.Writer.WriteStringValue(publicRequest.SampleDocument);
            }

            if(publicRequest.IsSetSampleDocuments())
            {
                context.Writer.WritePropertyName("sampleDocuments");
                context.Writer.WriteStartObject();

                var marshaller = SampleDocumentsMarshaller.Instance;
                marshaller.Marshall(publicRequest.SampleDocuments, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetStatus())
            {
                context.Writer.WritePropertyName("status");
                context.Writer.WriteStringValue(publicRequest.Status);
            }

            if(publicRequest.IsSetTransformerId())
            {
                context.Writer.WritePropertyName("transformerId");
                context.Writer.WriteStringValue(publicRequest.TransformerId);
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
        private static UpdateTransformerRequestMarshaller _instance = new UpdateTransformerRequestMarshaller();        

        internal static UpdateTransformerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateTransformerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
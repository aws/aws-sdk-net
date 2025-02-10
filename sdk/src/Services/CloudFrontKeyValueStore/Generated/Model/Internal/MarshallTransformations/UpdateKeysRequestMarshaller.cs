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
 * Do not modify this file. This file is generated from the cloudfront-keyvaluestore-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFrontKeyValueStore.Model;
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
namespace Amazon.CloudFrontKeyValueStore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateKeys Request Marshaller
    /// </summary>       
    public class UpdateKeysRequestMarshaller : IMarshaller<IRequest, UpdateKeysRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateKeysRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateKeysRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFrontKeyValueStore");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-26";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetKvsARN())
                throw new AmazonCloudFrontKeyValueStoreException("Request object does not have required field KvsARN set");
            request.AddPathResource("{KvsARN}", StringUtils.FromString(publicRequest.KvsARN));
            request.ResourcePath = "/key-value-stores/{KvsARN}/keys";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDeletes())
            {
                context.Writer.WritePropertyName("Deletes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDeletesListValue in publicRequest.Deletes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DeleteKeyRequestListItemMarshaller.Instance;
                    marshaller.Marshall(publicRequestDeletesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPuts())
            {
                context.Writer.WritePropertyName("Puts");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPutsListValue in publicRequest.Puts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PutKeyRequestListItemMarshaller.Instance;
                    marshaller.Marshall(publicRequestPutsListValue, context);

                    context.Writer.WriteEndObject();
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
            

        
            if (publicRequest.IsSetIfMatch()) 
            {
                request.Headers["If-Match"] = publicRequest.IfMatch;
            }

            return request;
        }
        private static UpdateKeysRequestMarshaller _instance = new UpdateKeysRequestMarshaller();        

        internal static UpdateKeysRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateKeysRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
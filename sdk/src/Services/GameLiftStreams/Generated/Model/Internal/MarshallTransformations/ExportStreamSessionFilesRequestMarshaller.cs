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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLiftStreams.Model;
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
namespace Amazon.GameLiftStreams.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ExportStreamSessionFiles Request Marshaller
    /// </summary>       
    public class ExportStreamSessionFilesRequestMarshaller : IMarshaller<IRequest, ExportStreamSessionFilesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ExportStreamSessionFilesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ExportStreamSessionFilesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLiftStreams");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetIdentifier())
                throw new AmazonGameLiftStreamsException("Request object does not have required field Identifier set");
            request.AddPathResource("{Identifier}", StringUtils.FromString(publicRequest.Identifier));
            if (!publicRequest.IsSetStreamSessionIdentifier())
                throw new AmazonGameLiftStreamsException("Request object does not have required field StreamSessionIdentifier set");
            request.AddPathResource("{StreamSessionIdentifier}", StringUtils.FromString(publicRequest.StreamSessionIdentifier));
            request.ResourcePath = "/streamgroups/{Identifier}/streamsessions/{StreamSessionIdentifier}/exportfiles";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetOutputUri())
            {
                context.Writer.WritePropertyName("OutputUri");
                context.Writer.WriteStringValue(publicRequest.OutputUri);
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
        private static ExportStreamSessionFilesRequestMarshaller _instance = new ExportStreamSessionFilesRequestMarshaller();        

        internal static ExportStreamSessionFilesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExportStreamSessionFilesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
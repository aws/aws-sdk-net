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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
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
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportHubContent Request Marshaller
    /// </summary>       
    public class ImportHubContentRequestMarshaller : IMarshaller<IRequest, ImportHubContentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportHubContentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ImportHubContentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.ImportHubContent";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";
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
            if(publicRequest.IsSetDocumentSchemaVersion())
            {
                context.Writer.WritePropertyName("DocumentSchemaVersion");
                context.Writer.WriteStringValue(publicRequest.DocumentSchemaVersion);
            }

            if(publicRequest.IsSetHubContentDescription())
            {
                context.Writer.WritePropertyName("HubContentDescription");
                context.Writer.WriteStringValue(publicRequest.HubContentDescription);
            }

            if(publicRequest.IsSetHubContentDisplayName())
            {
                context.Writer.WritePropertyName("HubContentDisplayName");
                context.Writer.WriteStringValue(publicRequest.HubContentDisplayName);
            }

            if(publicRequest.IsSetHubContentDocument())
            {
                context.Writer.WritePropertyName("HubContentDocument");
                context.Writer.WriteStringValue(publicRequest.HubContentDocument);
            }

            if(publicRequest.IsSetHubContentMarkdown())
            {
                context.Writer.WritePropertyName("HubContentMarkdown");
                context.Writer.WriteStringValue(publicRequest.HubContentMarkdown);
            }

            if(publicRequest.IsSetHubContentName())
            {
                context.Writer.WritePropertyName("HubContentName");
                context.Writer.WriteStringValue(publicRequest.HubContentName);
            }

            if(publicRequest.IsSetHubContentSearchKeywords())
            {
                context.Writer.WritePropertyName("HubContentSearchKeywords");
                context.Writer.WriteStartArray();
                foreach(var publicRequestHubContentSearchKeywordsListValue in publicRequest.HubContentSearchKeywords)
                {
                        context.Writer.WriteStringValue(publicRequestHubContentSearchKeywordsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetHubContentType())
            {
                context.Writer.WritePropertyName("HubContentType");
                context.Writer.WriteStringValue(publicRequest.HubContentType);
            }

            if(publicRequest.IsSetHubContentVersion())
            {
                context.Writer.WritePropertyName("HubContentVersion");
                context.Writer.WriteStringValue(publicRequest.HubContentVersion);
            }

            if(publicRequest.IsSetHubName())
            {
                context.Writer.WritePropertyName("HubName");
                context.Writer.WriteStringValue(publicRequest.HubName);
            }

            if(publicRequest.IsSetSupportStatus())
            {
                context.Writer.WritePropertyName("SupportStatus");
                context.Writer.WriteStringValue(publicRequest.SupportStatus);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

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
            


            return request;
        }
        private static ImportHubContentRequestMarshaller _instance = new ImportHubContentRequestMarshaller();        

        internal static ImportHubContentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImportHubContentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
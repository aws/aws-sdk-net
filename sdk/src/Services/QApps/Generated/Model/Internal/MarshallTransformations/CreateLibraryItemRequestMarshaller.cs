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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QApps.Model;
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
namespace Amazon.QApps.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLibraryItem Request Marshaller
    /// </summary>       
    public class CreateLibraryItemRequestMarshaller : IMarshaller<IRequest, CreateLibraryItemRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLibraryItemRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateLibraryItemRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QApps");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "/catalog.createItem";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAppId())
            {
                context.Writer.WritePropertyName("appId");
                context.Writer.WriteStringValue(publicRequest.AppId);
            }

            if(publicRequest.IsSetAppVersion())
            {
                context.Writer.WritePropertyName("appVersion");
                context.Writer.WriteNumberValue(publicRequest.AppVersion.Value);
            }

            if(publicRequest.IsSetCategories())
            {
                context.Writer.WritePropertyName("categories");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCategoriesListValue in publicRequest.Categories)
                {
                        context.Writer.WriteStringValue(publicRequestCategoriesListValue);
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
            

        
            if (publicRequest.IsSetInstanceId()) 
            {
                request.Headers["instance-id"] = publicRequest.InstanceId;
            }

            return request;
        }
        private static CreateLibraryItemRequestMarshaller _instance = new CreateLibraryItemRequestMarshaller();        

        internal static CreateLibraryItemRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateLibraryItemRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
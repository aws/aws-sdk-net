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
 * Do not modify this file. This file is generated from the directory-service-data-2023-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DirectoryServiceData.Model;
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
namespace Amazon.DirectoryServiceData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchGroups Request Marshaller
    /// </summary>       
    public class SearchGroupsRequestMarshaller : IMarshaller<IRequest, SearchGroupsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SearchGroupsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SearchGroupsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DirectoryServiceData");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-05-31";
            request.HttpMethod = "POST";

            
            if (publicRequest.IsSetDirectoryId())
                request.Parameters.Add("DirectoryId", StringUtils.FromString(publicRequest.DirectoryId));
            request.ResourcePath = "/Groups/SearchGroups";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("MaxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }

            if(publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("NextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }

            if(publicRequest.IsSetRealm())
            {
                context.Writer.WritePropertyName("Realm");
                context.Writer.WriteStringValue(publicRequest.Realm);
            }

            if(publicRequest.IsSetSearchAttributes())
            {
                context.Writer.WritePropertyName("SearchAttributes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSearchAttributesListValue in publicRequest.SearchAttributes)
                {
                        context.Writer.WriteStringValue(publicRequestSearchAttributesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSearchString())
            {
                context.Writer.WritePropertyName("SearchString");
                context.Writer.WriteStringValue(publicRequest.SearchString);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            request.UseQueryString = true;

            return request;
        }
        private static SearchGroupsRequestMarshaller _instance = new SearchGroupsRequestMarshaller();        

        internal static SearchGroupsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchGroupsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
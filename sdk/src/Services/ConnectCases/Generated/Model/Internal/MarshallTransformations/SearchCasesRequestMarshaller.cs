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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectCases.Model;
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
namespace Amazon.ConnectCases.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchCases Request Marshaller
    /// </summary>       
    public class SearchCasesRequestMarshaller : IMarshaller<IRequest, SearchCasesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SearchCasesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SearchCasesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConnectCases");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-10-03";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDomainId())
                throw new AmazonConnectCasesException("Request object does not have required field DomainId set");
            request.AddPathResource("{domainId}", StringUtils.FromString(publicRequest.DomainId));
            request.ResourcePath = "/domains/{domainId}/cases-search";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetFields())
            {
                context.Writer.WritePropertyName("fields");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFieldsListValue in publicRequest.Fields)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FieldIdentifierMarshaller.Instance;
                    marshaller.Marshall(publicRequestFieldsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetFilter())
            {
                context.Writer.WritePropertyName("filter");
                context.Writer.WriteStartObject();

                var marshaller = CaseFilterMarshaller.Instance;
                marshaller.Marshall(publicRequest.Filter, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("maxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }

            if(publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("nextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }

            if(publicRequest.IsSetSearchTerm())
            {
                context.Writer.WritePropertyName("searchTerm");
                context.Writer.WriteStringValue(publicRequest.SearchTerm);
            }

            if(publicRequest.IsSetSorts())
            {
                context.Writer.WritePropertyName("sorts");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSortsListValue in publicRequest.Sorts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SortMarshaller.Instance;
                    marshaller.Marshall(publicRequestSortsListValue, context);

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
        private static SearchCasesRequestMarshaller _instance = new SearchCasesRequestMarshaller();        

        internal static SearchCasesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchCasesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
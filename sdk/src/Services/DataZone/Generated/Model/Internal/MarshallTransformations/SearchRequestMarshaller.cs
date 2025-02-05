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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
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
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Search Request Marshaller
    /// </summary>       
    public class SearchRequestMarshaller : IMarshaller<IRequest, SearchRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SearchRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SearchRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataZone");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDomainIdentifier())
                throw new AmazonDataZoneException("Request object does not have required field DomainIdentifier set");
            request.AddPathResource("{domainIdentifier}", StringUtils.FromString(publicRequest.DomainIdentifier));
            request.ResourcePath = "/v2/domains/{domainIdentifier}/search";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAdditionalAttributes())
            {
                context.Writer.WritePropertyName("additionalAttributes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAdditionalAttributesListValue in publicRequest.AdditionalAttributes)
                {
                        context.Writer.WriteStringValue(publicRequestAdditionalAttributesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetFilters())
            {
                context.Writer.WritePropertyName("filters");
                context.Writer.WriteStartObject();

                var marshaller = FilterClauseMarshaller.Instance;
                marshaller.Marshall(publicRequest.Filters, context);

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

            if(publicRequest.IsSetOwningProjectIdentifier())
            {
                context.Writer.WritePropertyName("owningProjectIdentifier");
                context.Writer.WriteStringValue(publicRequest.OwningProjectIdentifier);
            }

            if(publicRequest.IsSetSearchIn())
            {
                context.Writer.WritePropertyName("searchIn");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSearchInListValue in publicRequest.SearchIn)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SearchInItemMarshaller.Instance;
                    marshaller.Marshall(publicRequestSearchInListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSearchScope())
            {
                context.Writer.WritePropertyName("searchScope");
                context.Writer.WriteStringValue(publicRequest.SearchScope);
            }

            if(publicRequest.IsSetSearchText())
            {
                context.Writer.WritePropertyName("searchText");
                context.Writer.WriteStringValue(publicRequest.SearchText);
            }

            if(publicRequest.IsSetSort())
            {
                context.Writer.WritePropertyName("sort");
                context.Writer.WriteStartObject();

                var marshaller = SearchSortMarshaller.Instance;
                marshaller.Marshall(publicRequest.Sort, context);

                context.Writer.WriteEndObject();
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
        private static SearchRequestMarshaller _instance = new SearchRequestMarshaller();        

        internal static SearchRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
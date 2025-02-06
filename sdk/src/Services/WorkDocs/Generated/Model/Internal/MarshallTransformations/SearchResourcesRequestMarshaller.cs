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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkDocs.Model;
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
namespace Amazon.WorkDocs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchResources Request Marshaller
    /// </summary>       
    public class SearchResourcesRequestMarshaller : IMarshaller<IRequest, SearchResourcesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SearchResourcesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SearchResourcesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkDocs");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-05-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/api/v1/search";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAdditionalResponseFields())
            {
                context.Writer.WritePropertyName("AdditionalResponseFields");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAdditionalResponseFieldsListValue in publicRequest.AdditionalResponseFields)
                {
                        context.Writer.WriteStringValue(publicRequestAdditionalResponseFieldsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetFilters())
            {
                context.Writer.WritePropertyName("Filters");
                context.Writer.WriteStartObject();

                var marshaller = FiltersMarshaller.Instance;
                marshaller.Marshall(publicRequest.Filters, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetLimit())
            {
                context.Writer.WritePropertyName("Limit");
                context.Writer.WriteNumberValue(publicRequest.Limit.Value);
            }

            if(publicRequest.IsSetMarker())
            {
                context.Writer.WritePropertyName("Marker");
                context.Writer.WriteStringValue(publicRequest.Marker);
            }

            if(publicRequest.IsSetOrderBy())
            {
                context.Writer.WritePropertyName("OrderBy");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOrderByListValue in publicRequest.OrderBy)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SearchSortResultMarshaller.Instance;
                    marshaller.Marshall(publicRequestOrderByListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOrganizationId())
            {
                context.Writer.WritePropertyName("OrganizationId");
                context.Writer.WriteStringValue(publicRequest.OrganizationId);
            }

            if(publicRequest.IsSetQueryScopes())
            {
                context.Writer.WritePropertyName("QueryScopes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestQueryScopesListValue in publicRequest.QueryScopes)
                {
                        context.Writer.WriteStringValue(publicRequestQueryScopesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetQueryText())
            {
                context.Writer.WritePropertyName("QueryText");
                context.Writer.WriteStringValue(publicRequest.QueryText);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

        
            if (publicRequest.IsSetAuthenticationToken()) 
            {
                request.Headers["Authentication"] = publicRequest.AuthenticationToken;
            }

            return request;
        }
        private static SearchResourcesRequestMarshaller _instance = new SearchResourcesRequestMarshaller();        

        internal static SearchResourcesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchResourcesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
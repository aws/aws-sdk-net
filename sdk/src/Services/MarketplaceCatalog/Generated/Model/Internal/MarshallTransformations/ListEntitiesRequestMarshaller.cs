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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MarketplaceCatalog.Model;
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
namespace Amazon.MarketplaceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListEntities Request Marshaller
    /// </summary>       
    public class ListEntitiesRequestMarshaller : IMarshaller<IRequest, ListEntitiesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListEntitiesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListEntitiesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MarketplaceCatalog");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-09-17";
            request.HttpMethod = "POST";

            request.ResourcePath = "/ListEntities";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCatalog())
            {
                context.Writer.WritePropertyName("Catalog");
                context.Writer.WriteStringValue(publicRequest.Catalog);
            }

            if(publicRequest.IsSetEntityType())
            {
                context.Writer.WritePropertyName("EntityType");
                context.Writer.WriteStringValue(publicRequest.EntityType);
            }

            if(publicRequest.IsSetEntityTypeFilters())
            {
                context.Writer.WritePropertyName("EntityTypeFilters");
                context.Writer.WriteStartObject();

                var marshaller = EntityTypeFiltersMarshaller.Instance;
                marshaller.Marshall(publicRequest.EntityTypeFilters, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEntityTypeSort())
            {
                context.Writer.WritePropertyName("EntityTypeSort");
                context.Writer.WriteStartObject();

                var marshaller = EntityTypeSortMarshaller.Instance;
                marshaller.Marshall(publicRequest.EntityTypeSort, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFilterList())
            {
                context.Writer.WritePropertyName("FilterList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFilterListListValue in publicRequest.FilterList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FilterMarshaller.Instance;
                    marshaller.Marshall(publicRequestFilterListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

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

            if(publicRequest.IsSetOwnershipType())
            {
                context.Writer.WritePropertyName("OwnershipType");
                context.Writer.WriteStringValue(publicRequest.OwnershipType);
            }

            if(publicRequest.IsSetSort())
            {
                context.Writer.WritePropertyName("Sort");
                context.Writer.WriteStartObject();

                var marshaller = SortMarshaller.Instance;
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
        private static ListEntitiesRequestMarshaller _instance = new ListEntitiesRequestMarshaller();        

        internal static ListEntitiesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListEntitiesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
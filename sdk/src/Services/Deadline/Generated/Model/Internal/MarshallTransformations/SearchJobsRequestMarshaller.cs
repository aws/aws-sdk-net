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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
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
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchJobs Request Marshaller
    /// </summary>       
    public class SearchJobsRequestMarshaller : IMarshaller<IRequest, SearchJobsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SearchJobsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SearchJobsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Deadline");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-10-12";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetFarmId())
                throw new AmazonDeadlineException("Request object does not have required field FarmId set");
            request.AddPathResource("{farmId}", StringUtils.FromString(publicRequest.FarmId));
            request.ResourcePath = "/2023-10-12/farms/{farmId}/search/jobs";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetFilterExpressions())
            {
                context.Writer.WritePropertyName("filterExpressions");
                context.Writer.WriteStartObject();

                var marshaller = SearchGroupedFilterExpressionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.FilterExpressions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetItemOffset())
            {
                context.Writer.WritePropertyName("itemOffset");
                context.Writer.WriteNumberValue(publicRequest.ItemOffset.Value);
            }

            if(publicRequest.IsSetPageSize())
            {
                context.Writer.WritePropertyName("pageSize");
                context.Writer.WriteNumberValue(publicRequest.PageSize.Value);
            }

            if(publicRequest.IsSetQueueIds())
            {
                context.Writer.WritePropertyName("queueIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestQueueIdsListValue in publicRequest.QueueIds)
                {
                        context.Writer.WriteStringValue(publicRequestQueueIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSortExpressions())
            {
                context.Writer.WritePropertyName("sortExpressions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSortExpressionsListValue in publicRequest.SortExpressions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SearchSortExpressionMarshaller.Instance;
                    marshaller.Marshall(publicRequestSortExpressionsListValue, context);

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
            

            
            request.HostPrefix = $"management.";

            return request;
        }
        private static SearchJobsRequestMarshaller _instance = new SearchJobsRequestMarshaller();        

        internal static SearchJobsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchJobsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
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
 * Do not modify this file. This file is generated from the forecastquery-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ForecastQueryService.Model;
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
namespace Amazon.ForecastQueryService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// QueryWhatIfForecast Request Marshaller
    /// </summary>       
    public class QueryWhatIfForecastRequestMarshaller : IMarshaller<IRequest, QueryWhatIfForecastRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((QueryWhatIfForecastRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(QueryWhatIfForecastRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ForecastQueryService");
            string target = "AmazonForecastRuntime.QueryWhatIfForecast";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-06-26";
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
            if(publicRequest.IsSetEndDate())
            {
                context.Writer.WritePropertyName("EndDate");
                context.Writer.WriteStringValue(publicRequest.EndDate);
            }

            if(publicRequest.IsSetFilters())
            {
                context.Writer.WritePropertyName("Filters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestFiltersKvp in publicRequest.Filters)
                {
                    context.Writer.WritePropertyName(publicRequestFiltersKvp.Key);
                    var publicRequestFiltersValue = publicRequestFiltersKvp.Value;

                        context.Writer.WriteStringValue(publicRequestFiltersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("NextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }

            if(publicRequest.IsSetStartDate())
            {
                context.Writer.WritePropertyName("StartDate");
                context.Writer.WriteStringValue(publicRequest.StartDate);
            }

            if(publicRequest.IsSetWhatIfForecastArn())
            {
                context.Writer.WritePropertyName("WhatIfForecastArn");
                context.Writer.WriteStringValue(publicRequest.WhatIfForecastArn);
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
        private static QueryWhatIfForecastRequestMarshaller _instance = new QueryWhatIfForecastRequestMarshaller();        

        internal static QueryWhatIfForecastRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static QueryWhatIfForecastRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
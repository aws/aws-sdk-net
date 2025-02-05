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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchRUM.Model;
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
namespace Amazon.CloudWatchRUM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetAppMonitorData Request Marshaller
    /// </summary>       
    public class GetAppMonitorDataRequestMarshaller : IMarshaller<IRequest, GetAppMonitorDataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetAppMonitorDataRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetAppMonitorDataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchRUM");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetName())
                throw new AmazonCloudWatchRUMException("Request object does not have required field Name set");
            request.AddPathResource("{Name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/appmonitor/{Name}/data";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetFilters())
            {
                context.Writer.WritePropertyName("Filters");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFiltersListValue in publicRequest.Filters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = QueryFilterMarshaller.Instance;
                    marshaller.Marshall(publicRequestFiltersListValue, context);

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

            if(publicRequest.IsSetTimeRange())
            {
                context.Writer.WritePropertyName("TimeRange");
                context.Writer.WriteStartObject();

                var marshaller = TimeRangeMarshaller.Instance;
                marshaller.Marshall(publicRequest.TimeRange, context);

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
        private static GetAppMonitorDataRequestMarshaller _instance = new GetAppMonitorDataRequestMarshaller();        

        internal static GetAppMonitorDataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetAppMonitorDataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
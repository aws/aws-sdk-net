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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResourceGroupsTaggingAPI.Model;
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
namespace Amazon.ResourceGroupsTaggingAPI.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetComplianceSummary Request Marshaller
    /// </summary>       
    public class GetComplianceSummaryRequestMarshaller : IMarshaller<IRequest, GetComplianceSummaryRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetComplianceSummaryRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetComplianceSummaryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ResourceGroupsTaggingAPI");
            string target = "ResourceGroupsTaggingAPI_20170126.GetComplianceSummary";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-01-26";
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
            if(publicRequest.IsSetGroupBy())
            {
                context.Writer.WritePropertyName("GroupBy");
                context.Writer.WriteStartArray();
                foreach(var publicRequestGroupByListValue in publicRequest.GroupBy)
                {
                        context.Writer.WriteStringValue(publicRequestGroupByListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("MaxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }

            if(publicRequest.IsSetPaginationToken())
            {
                context.Writer.WritePropertyName("PaginationToken");
                context.Writer.WriteStringValue(publicRequest.PaginationToken);
            }

            if(publicRequest.IsSetRegionFilters())
            {
                context.Writer.WritePropertyName("RegionFilters");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRegionFiltersListValue in publicRequest.RegionFilters)
                {
                        context.Writer.WriteStringValue(publicRequestRegionFiltersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetResourceTypeFilters())
            {
                context.Writer.WritePropertyName("ResourceTypeFilters");
                context.Writer.WriteStartArray();
                foreach(var publicRequestResourceTypeFiltersListValue in publicRequest.ResourceTypeFilters)
                {
                        context.Writer.WriteStringValue(publicRequestResourceTypeFiltersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTagKeyFilters())
            {
                context.Writer.WritePropertyName("TagKeyFilters");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagKeyFiltersListValue in publicRequest.TagKeyFilters)
                {
                        context.Writer.WriteStringValue(publicRequestTagKeyFiltersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTargetIdFilters())
            {
                context.Writer.WritePropertyName("TargetIdFilters");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTargetIdFiltersListValue in publicRequest.TargetIdFilters)
                {
                        context.Writer.WriteStringValue(publicRequestTargetIdFiltersListValue);
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
        private static GetComplianceSummaryRequestMarshaller _instance = new GetComplianceSummaryRequestMarshaller();        

        internal static GetComplianceSummaryRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetComplianceSummaryRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.ResourceGroupsTaggingAPI.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ResourceGroupsTaggingAPI.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetResources Request Marshaller
    /// </summary>
    public partial class GetResourcesRequestMarshaller : IMarshaller<IRequest, GetResourcesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetResourcesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetResourcesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ResourceGroupsTaggingAPI");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-01-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/ResourceGroupsTaggingAPI_20170126/operation/GetResources";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetExcludeCompliantResources())
                {
                    context.Writer.WriteTextString("ExcludeCompliantResources");
                    context.Writer.WriteBoolean(publicRequest.ExcludeCompliantResources.Value);
                }
                if (publicRequest.IsSetIncludeComplianceDetails())
                {
                    context.Writer.WriteTextString("IncludeComplianceDetails");
                    context.Writer.WriteBoolean(publicRequest.IncludeComplianceDetails.Value);
                }
                if (publicRequest.IsSetPaginationToken())
                {
                    context.Writer.WriteTextString("PaginationToken");
                    context.Writer.WriteTextString(publicRequest.PaginationToken);
                }
                if (publicRequest.IsSetResourceARNList())
                {
                    context.Writer.WriteTextString("ResourceARNList");
                    context.Writer.WriteStartArray(publicRequest.ResourceARNList.Count);
                    foreach (var publicRequestResourceARNListListValue in publicRequest.ResourceARNList)
                    {
                        context.Writer.WriteTextString(publicRequestResourceARNListListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetResourceTypeFilters())
                {
                    context.Writer.WriteTextString("ResourceTypeFilters");
                    context.Writer.WriteStartArray(publicRequest.ResourceTypeFilters.Count);
                    foreach (var publicRequestResourceTypeFiltersListValue in publicRequest.ResourceTypeFilters)
                    {
                        context.Writer.WriteTextString(publicRequestResourceTypeFiltersListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetResourcesPerPage())
                {
                    context.Writer.WriteTextString("ResourcesPerPage");
                    context.Writer.WriteInt32(publicRequest.ResourcesPerPage.Value);
                }
                if (publicRequest.IsSetTagFilters())
                {
                    context.Writer.WriteTextString("TagFilters");
                    context.Writer.WriteStartArray(publicRequest.TagFilters.Count);
                    foreach (var publicRequestTagFiltersListValue in publicRequest.TagFilters)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = TagFilterMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagFiltersListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetTagsPerPage())
                {
                    context.Writer.WriteTextString("TagsPerPage");
                    context.Writer.WriteInt32(publicRequest.TagsPerPage.Value);
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }

            return request;
        }

        private static readonly GetResourcesRequestMarshaller _instance = new();

        internal static GetResourcesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetResourcesRequestMarshaller Instance => _instance;
    }
}

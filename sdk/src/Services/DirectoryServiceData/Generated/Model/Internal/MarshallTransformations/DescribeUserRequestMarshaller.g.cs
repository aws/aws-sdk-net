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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.DirectoryServiceData.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.DirectoryServiceData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeUser Request Marshaller
    /// </summary>
    public partial class DescribeUserRequestMarshaller : IMarshaller<IRequest, DescribeUserRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeUserRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DescribeUserRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DirectoryServiceData");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-05-31";
            request.HttpMethod = "POST";

            if (string.IsNullOrEmpty(publicRequest.DirectoryId))
            {
                throw new AmazonDirectoryServiceDataException("Request object does not have required field DirectoryId set");
            }

            if (publicRequest.IsSetDirectoryId())
            {
                request.Parameters.Add("DirectoryId", StringUtils.FromString(publicRequest.DirectoryId));
            }

            request.ResourcePath = "/Users/DescribeUser";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetOtherAttributes())
            {
                context.Writer.WritePropertyName("OtherAttributes");
                context.Writer.WriteStartArray();
                foreach (var publicRequestOtherAttributesListValue in publicRequest.OtherAttributes)
                {
                    context.Writer.WriteStringValue(publicRequestOtherAttributesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetRealm())
            {
                context.Writer.WritePropertyName("Realm");
                context.Writer.WriteStringValue(publicRequest.Realm);
            }
            if (publicRequest.IsSetSAMAccountName())
            {
                context.Writer.WritePropertyName("SAMAccountName");
                context.Writer.WriteStringValue(publicRequest.SAMAccountName);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            request.UseQueryString = true;

            return request;
        }

        private static readonly DescribeUserRequestMarshaller _instance = new();

        internal static DescribeUserRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeUserRequestMarshaller Instance => _instance;
    }
}

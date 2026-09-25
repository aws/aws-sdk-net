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
    /// CreateUser Request Marshaller
    /// </summary>
    public partial class CreateUserRequestMarshaller : IMarshaller<IRequest, CreateUserRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateUserRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateUserRequest publicRequest)
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

            request.ResourcePath = "/Users/CreateUser";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            else
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetEmailAddress())
            {
                context.Writer.WritePropertyName("EmailAddress");
                context.Writer.WriteStringValue(publicRequest.EmailAddress);
            }
            if (publicRequest.IsSetGivenName())
            {
                context.Writer.WritePropertyName("GivenName");
                context.Writer.WriteStringValue(publicRequest.GivenName);
            }
            if (publicRequest.IsSetOtherAttributes())
            {
                context.Writer.WritePropertyName("OtherAttributes");
                context.Writer.WriteStartObject();
                foreach (var publicRequestOtherAttributesKvp in publicRequest.OtherAttributes)
                {
                    context.Writer.WritePropertyName(publicRequestOtherAttributesKvp.Key);
                    var publicRequestOtherAttributesValue = publicRequestOtherAttributesKvp.Value;
                    context.Writer.WriteStartObject();

                    var marshaller = AttributeValueMarshaller.Instance;
                    marshaller.Marshall(publicRequestOtherAttributesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetSAMAccountName())
            {
                context.Writer.WritePropertyName("SAMAccountName");
                context.Writer.WriteStringValue(publicRequest.SAMAccountName);
            }
            if (publicRequest.IsSetSurname())
            {
                context.Writer.WritePropertyName("Surname");
                context.Writer.WriteStringValue(publicRequest.Surname);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            request.UseQueryString = true;

            return request;
        }

        private static readonly CreateUserRequestMarshaller _instance = new();

        internal static CreateUserRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateUserRequestMarshaller Instance => _instance;
    }
}

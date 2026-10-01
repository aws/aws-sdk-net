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

using Amazon.CustomerProfiles.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDomainLayout Request Marshaller
    /// </summary>
    public partial class UpdateDomainLayoutRequestMarshaller : IMarshaller<IRequest, UpdateDomainLayoutRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDomainLayoutRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateDomainLayoutRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CustomerProfiles");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-15";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetDomainName())
            {
                throw new AmazonCustomerProfilesException("Request object does not have required field DomainName set");
            }
            request.AddPathResource("{DomainName}", StringUtils.FromString(publicRequest.DomainName));

            if (!publicRequest.IsSetLayoutDefinitionName())
            {
                throw new AmazonCustomerProfilesException("Request object does not have required field LayoutDefinitionName set");
            }
            request.AddPathResource("{LayoutDefinitionName}", StringUtils.FromString(publicRequest.LayoutDefinitionName));

            request.ResourcePath = "/domains/{DomainName}/layouts/{LayoutDefinitionName}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }
            if (publicRequest.IsSetDisplayName())
            {
                context.Writer.WritePropertyName("DisplayName");
                context.Writer.WriteStringValue(publicRequest.DisplayName);
            }
            if (publicRequest.IsSetIsDefault())
            {
                context.Writer.WritePropertyName("IsDefault");
                context.Writer.WriteBooleanValue(publicRequest.IsDefault.Value);
            }
            if (publicRequest.IsSetLayout())
            {
                context.Writer.WritePropertyName("Layout");
                context.Writer.WriteStringValue(publicRequest.Layout);
            }
            if (publicRequest.IsSetLayoutType())
            {
                context.Writer.WritePropertyName("LayoutType");
                context.Writer.WriteStringValue(publicRequest.LayoutType);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateDomainLayoutRequestMarshaller _instance = new();

        internal static UpdateDomainLayoutRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateDomainLayoutRequestMarshaller Instance => _instance;
    }
}

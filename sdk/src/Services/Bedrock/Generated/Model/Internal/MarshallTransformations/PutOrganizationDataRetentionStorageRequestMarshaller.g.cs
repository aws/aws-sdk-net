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

using Amazon.Bedrock.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutOrganizationDataRetentionStorage Request Marshaller
    /// </summary>
    public partial class PutOrganizationDataRetentionStorageRequestMarshaller : IMarshaller<IRequest, PutOrganizationDataRetentionStorageRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutOrganizationDataRetentionStorageRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PutOrganizationDataRetentionStorageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Bedrock");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-20";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetModelProvider())
            {
                throw new AmazonBedrockException("Request object does not have required field ModelProvider set");
            }
            request.AddPathResource("{modelProvider}", StringUtils.FromString(publicRequest.ModelProvider));

            request.ResourcePath = "/v1/data_retention/organization-storage/{modelProvider}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetStorageConfiguration())
            {
                context.Writer.WritePropertyName("storageConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DataRetentionStorageConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.StorageConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetStorageDestination())
            {
                context.Writer.WritePropertyName("storageDestination");
                context.Writer.WriteStringValue(publicRequest.StorageDestination);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly PutOrganizationDataRetentionStorageRequestMarshaller _instance = new();

        internal static PutOrganizationDataRetentionStorageRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PutOrganizationDataRetentionStorageRequestMarshaller Instance => _instance;
    }
}

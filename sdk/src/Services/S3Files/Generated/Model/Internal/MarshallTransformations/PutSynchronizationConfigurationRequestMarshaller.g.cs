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

using Amazon.S3Files.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.S3Files.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutSynchronizationConfiguration Request Marshaller
    /// </summary>
    public partial class PutSynchronizationConfigurationRequestMarshaller : IMarshaller<IRequest, PutSynchronizationConfigurationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutSynchronizationConfigurationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PutSynchronizationConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.S3Files");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-05-05";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetFileSystemId())
            {
                throw new AmazonS3FilesException("Request object does not have required field FileSystemId set");
            }
            request.AddPathResource("{fileSystemId}", StringUtils.FromString(publicRequest.FileSystemId));

            request.ResourcePath = "/file-systems/{fileSystemId}/synchronization-configuration";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetExpirationDataRules())
            {
                context.Writer.WritePropertyName("expirationDataRules");
                context.Writer.WriteStartArray();
                foreach (var publicRequestExpirationDataRulesListValue in publicRequest.ExpirationDataRules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ExpirationDataRuleMarshaller.Instance;
                    marshaller.Marshall(publicRequestExpirationDataRulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetImportDataRules())
            {
                context.Writer.WritePropertyName("importDataRules");
                context.Writer.WriteStartArray();
                foreach (var publicRequestImportDataRulesListValue in publicRequest.ImportDataRules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ImportDataRuleMarshaller.Instance;
                    marshaller.Marshall(publicRequestImportDataRulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetLatestVersionNumber())
            {
                context.Writer.WritePropertyName("latestVersionNumber");
                context.Writer.WriteNumberValue(publicRequest.LatestVersionNumber.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly PutSynchronizationConfigurationRequestMarshaller _instance = new();

        internal static PutSynchronizationConfigurationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PutSynchronizationConfigurationRequestMarshaller Instance => _instance;
    }
}

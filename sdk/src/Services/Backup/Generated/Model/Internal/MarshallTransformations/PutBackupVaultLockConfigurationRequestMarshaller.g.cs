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

using Amazon.Backup.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutBackupVaultLockConfiguration Request Marshaller
    /// </summary>
    public partial class PutBackupVaultLockConfigurationRequestMarshaller : IMarshaller<IRequest, PutBackupVaultLockConfigurationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBackupVaultLockConfigurationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PutBackupVaultLockConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Backup");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-15";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetBackupVaultName())
            {
                throw new AmazonBackupException("Request object does not have required field BackupVaultName set");
            }
            request.AddPathResource("{BackupVaultName}", StringUtils.FromString(publicRequest.BackupVaultName));

            request.ResourcePath = "/backup-vaults/{BackupVaultName}/vault-lock";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetChangeableForDays())
            {
                context.Writer.WritePropertyName("ChangeableForDays");
                context.Writer.WriteNumberValue(publicRequest.ChangeableForDays.Value);
            }
            if (publicRequest.IsSetMaxRetentionDays())
            {
                context.Writer.WritePropertyName("MaxRetentionDays");
                context.Writer.WriteNumberValue(publicRequest.MaxRetentionDays.Value);
            }
            if (publicRequest.IsSetMinRetentionDays())
            {
                context.Writer.WritePropertyName("MinRetentionDays");
                context.Writer.WriteNumberValue(publicRequest.MinRetentionDays.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly PutBackupVaultLockConfigurationRequestMarshaller _instance = new();

        internal static PutBackupVaultLockConfigurationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PutBackupVaultLockConfigurationRequestMarshaller Instance => _instance;
    }
}

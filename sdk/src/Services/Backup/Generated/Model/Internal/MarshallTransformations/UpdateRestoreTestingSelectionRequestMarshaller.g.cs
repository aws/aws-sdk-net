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
    /// UpdateRestoreTestingSelection Request Marshaller
    /// </summary>
    public partial class UpdateRestoreTestingSelectionRequestMarshaller : IMarshaller<IRequest, UpdateRestoreTestingSelectionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateRestoreTestingSelectionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateRestoreTestingSelectionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Backup");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-15";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetRestoreTestingPlanName())
            {
                throw new AmazonBackupException("Request object does not have required field RestoreTestingPlanName set");
            }
            request.AddPathResource("{RestoreTestingPlanName}", StringUtils.FromString(publicRequest.RestoreTestingPlanName));

            if (!publicRequest.IsSetRestoreTestingSelectionName())
            {
                throw new AmazonBackupException("Request object does not have required field RestoreTestingSelectionName set");
            }
            request.AddPathResource("{RestoreTestingSelectionName}", StringUtils.FromString(publicRequest.RestoreTestingSelectionName));

            request.ResourcePath = "/restore-testing/plans/{RestoreTestingPlanName}/selections/{RestoreTestingSelectionName}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetRestoreTestingSelection())
            {
                context.Writer.WritePropertyName("RestoreTestingSelection");
                context.Writer.WriteStartObject();

                var marshaller = RestoreTestingSelectionForUpdateMarshaller.Instance;
                marshaller.Marshall(publicRequest.RestoreTestingSelection, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateRestoreTestingSelectionRequestMarshaller _instance = new();

        internal static UpdateRestoreTestingSelectionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateRestoreTestingSelectionRequestMarshaller Instance => _instance;
    }
}

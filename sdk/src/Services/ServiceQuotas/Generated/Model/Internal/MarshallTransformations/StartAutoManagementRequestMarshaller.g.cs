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

using Amazon.ServiceQuotas.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ServiceQuotas.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartAutoManagement Request Marshaller
    /// </summary>
    public partial class StartAutoManagementRequestMarshaller : IMarshaller<IRequest, StartAutoManagementRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartAutoManagementRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StartAutoManagementRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServiceQuotas");
            string target = "ServiceQuotasV20190624.StartAutoManagement";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-06-24";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetExclusionList())
            {
                context.Writer.WritePropertyName("ExclusionList");
                context.Writer.WriteStartObject();
                foreach (var publicRequestExclusionListKvp in publicRequest.ExclusionList)
                {
                    context.Writer.WritePropertyName(publicRequestExclusionListKvp.Key);
                    var publicRequestExclusionListValue = publicRequestExclusionListKvp.Value;
                    context.Writer.WriteStartArray();
                    foreach (var publicRequestExclusionListValueListValue in publicRequestExclusionListValue)
                    {
                        context.Writer.WriteStringValue(publicRequestExclusionListValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetNotificationArn())
            {
                context.Writer.WritePropertyName("NotificationArn");
                context.Writer.WriteStringValue(publicRequest.NotificationArn);
            }
            if (publicRequest.IsSetOptInLevel())
            {
                context.Writer.WritePropertyName("OptInLevel");
                context.Writer.WriteStringValue(publicRequest.OptInLevel);
            }
            if (publicRequest.IsSetOptInType())
            {
                context.Writer.WritePropertyName("OptInType");
                context.Writer.WriteStringValue(publicRequest.OptInType);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly StartAutoManagementRequestMarshaller _instance = new();

        internal static StartAutoManagementRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StartAutoManagementRequestMarshaller Instance => _instance;
    }
}

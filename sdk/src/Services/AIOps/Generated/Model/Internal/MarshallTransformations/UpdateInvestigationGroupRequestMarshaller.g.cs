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

using Amazon.AIOps.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.AIOps.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateInvestigationGroup Request Marshaller
    /// </summary>
    public partial class UpdateInvestigationGroupRequestMarshaller : IMarshaller<IRequest, UpdateInvestigationGroupRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateInvestigationGroupRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateInvestigationGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AIOps");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetIdentifier())
            {
                throw new AmazonAIOpsException("Request object does not have required field Identifier set");
            }
            request.AddPathResource("{identifier}", StringUtils.FromString(publicRequest.Identifier));

            request.ResourcePath = "/investigationGroups/{identifier}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetChatbotNotificationChannel())
            {
                context.Writer.WritePropertyName("chatbotNotificationChannel");
                context.Writer.WriteStartObject();
                foreach (var publicRequestChatbotNotificationChannelKvp in publicRequest.ChatbotNotificationChannel)
                {
                    context.Writer.WritePropertyName(publicRequestChatbotNotificationChannelKvp.Key);
                    var publicRequestChatbotNotificationChannelValue = publicRequestChatbotNotificationChannelKvp.Value;
                    context.Writer.WriteStartArray();
                    foreach (var publicRequestChatbotNotificationChannelValueListValue in publicRequestChatbotNotificationChannelValue)
                    {
                        context.Writer.WriteStringValue(publicRequestChatbotNotificationChannelValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetCrossAccountConfigurations())
            {
                context.Writer.WritePropertyName("crossAccountConfigurations");
                context.Writer.WriteStartArray();
                foreach (var publicRequestCrossAccountConfigurationsListValue in publicRequest.CrossAccountConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CrossAccountConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestCrossAccountConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("encryptionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.EncryptionConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetIsCloudTrailEventHistoryEnabled())
            {
                context.Writer.WritePropertyName("isCloudTrailEventHistoryEnabled");
                context.Writer.WriteBooleanValue(publicRequest.IsCloudTrailEventHistoryEnabled.Value);
            }
            if (publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }
            if (publicRequest.IsSetTagKeyBoundaries())
            {
                context.Writer.WritePropertyName("tagKeyBoundaries");
                context.Writer.WriteStartArray();
                foreach (var publicRequestTagKeyBoundariesListValue in publicRequest.TagKeyBoundaries)
                {
                    context.Writer.WriteStringValue(publicRequestTagKeyBoundariesListValue);
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateInvestigationGroupRequestMarshaller _instance = new();

        internal static UpdateInvestigationGroupRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateInvestigationGroupRequestMarshaller Instance => _instance;
    }
}

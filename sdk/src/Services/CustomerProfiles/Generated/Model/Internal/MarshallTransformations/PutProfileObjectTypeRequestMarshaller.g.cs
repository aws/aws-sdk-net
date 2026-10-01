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
    /// PutProfileObjectType Request Marshaller
    /// </summary>
    public partial class PutProfileObjectTypeRequestMarshaller : IMarshaller<IRequest, PutProfileObjectTypeRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutProfileObjectTypeRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PutProfileObjectTypeRequest publicRequest)
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

            if (!publicRequest.IsSetObjectTypeName())
            {
                throw new AmazonCustomerProfilesException("Request object does not have required field ObjectTypeName set");
            }
            request.AddPathResource("{ObjectTypeName}", StringUtils.FromString(publicRequest.ObjectTypeName));

            request.ResourcePath = "/domains/{DomainName}/object-types/{ObjectTypeName}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAllowProfileCreation())
            {
                context.Writer.WritePropertyName("AllowProfileCreation");
                context.Writer.WriteBooleanValue(publicRequest.AllowProfileCreation.Value);
            }
            if (publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }
            if (publicRequest.IsSetEncryptionKey())
            {
                context.Writer.WritePropertyName("EncryptionKey");
                context.Writer.WriteStringValue(publicRequest.EncryptionKey);
            }
            if (publicRequest.IsSetExpirationDays())
            {
                context.Writer.WritePropertyName("ExpirationDays");
                context.Writer.WriteNumberValue(publicRequest.ExpirationDays.Value);
            }
            if (publicRequest.IsSetFields())
            {
                context.Writer.WritePropertyName("Fields");
                context.Writer.WriteStartObject();
                foreach (var publicRequestFieldsKvp in publicRequest.Fields)
                {
                    context.Writer.WritePropertyName(publicRequestFieldsKvp.Key);
                    var publicRequestFieldsValue = publicRequestFieldsKvp.Value;
                    context.Writer.WriteStartObject();

                    var marshaller = ObjectTypeFieldMarshaller.Instance;
                    marshaller.Marshall(publicRequestFieldsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetKeys())
            {
                context.Writer.WritePropertyName("Keys");
                context.Writer.WriteStartObject();
                foreach (var publicRequestKeysKvp in publicRequest.Keys)
                {
                    context.Writer.WritePropertyName(publicRequestKeysKvp.Key);
                    var publicRequestKeysValue = publicRequestKeysKvp.Value;
                    context.Writer.WriteStartArray();
                    foreach (var publicRequestKeysValueListValue in publicRequestKeysValue)
                    {
                        context.Writer.WriteStartObject();

                        var marshaller = ObjectTypeKeyMarshaller.Instance;
                        marshaller.Marshall(publicRequestKeysValueListValue, context);

                        context.Writer.WriteEndObject();
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetMaxProfileObjectCount())
            {
                context.Writer.WritePropertyName("MaxProfileObjectCount");
                context.Writer.WriteNumberValue(publicRequest.MaxProfileObjectCount.Value);
            }
            if (publicRequest.IsSetSourceLastUpdatedTimestampFormat())
            {
                context.Writer.WritePropertyName("SourceLastUpdatedTimestampFormat");
                context.Writer.WriteStringValue(publicRequest.SourceLastUpdatedTimestampFormat);
            }
            if (publicRequest.IsSetSourcePriority())
            {
                context.Writer.WritePropertyName("SourcePriority");
                context.Writer.WriteNumberValue(publicRequest.SourcePriority.Value);
            }
            if (publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;
                    context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetTemplateId())
            {
                context.Writer.WritePropertyName("TemplateId");
                context.Writer.WriteStringValue(publicRequest.TemplateId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly PutProfileObjectTypeRequestMarshaller _instance = new();

        internal static PutProfileObjectTypeRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PutProfileObjectTypeRequestMarshaller Instance => _instance;
    }
}

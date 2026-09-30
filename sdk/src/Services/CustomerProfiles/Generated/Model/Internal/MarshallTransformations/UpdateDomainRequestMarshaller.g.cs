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
    /// UpdateDomain Request Marshaller
    /// </summary>
    public partial class UpdateDomainRequestMarshaller : IMarshaller<IRequest, UpdateDomainRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDomainRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateDomainRequest publicRequest)
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

            request.ResourcePath = "/domains/{DomainName}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetDataStore())
            {
                context.Writer.WritePropertyName("DataStore");
                context.Writer.WriteStartObject();

                var marshaller = DataStoreRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataStore, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetDeadLetterQueueUrl())
            {
                context.Writer.WritePropertyName("DeadLetterQueueUrl");
                context.Writer.WriteStringValue(publicRequest.DeadLetterQueueUrl);
            }
            if (publicRequest.IsSetDefaultEncryptionKey())
            {
                context.Writer.WritePropertyName("DefaultEncryptionKey");
                context.Writer.WriteStringValue(publicRequest.DefaultEncryptionKey);
            }
            if (publicRequest.IsSetDefaultExpirationDays())
            {
                context.Writer.WritePropertyName("DefaultExpirationDays");
                context.Writer.WriteNumberValue(publicRequest.DefaultExpirationDays.Value);
            }
            if (publicRequest.IsSetMatching())
            {
                context.Writer.WritePropertyName("Matching");
                context.Writer.WriteStartObject();

                var marshaller = MatchingRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.Matching, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetRuleBasedMatching())
            {
                context.Writer.WritePropertyName("RuleBasedMatching");
                context.Writer.WriteStartObject();

                var marshaller = RuleBasedMatchingRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.RuleBasedMatching, context);

                context.Writer.WriteEndObject();
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

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateDomainRequestMarshaller _instance = new();

        internal static UpdateDomainRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateDomainRequestMarshaller Instance => _instance;
    }
}

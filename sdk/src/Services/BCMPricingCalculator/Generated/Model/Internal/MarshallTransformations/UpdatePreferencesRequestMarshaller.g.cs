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

using Amazon.BCMPricingCalculator.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.BCMPricingCalculator.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdatePreferences Request Marshaller
    /// </summary>
    public partial class UpdatePreferencesRequestMarshaller : IMarshaller<IRequest, UpdatePreferencesRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdatePreferencesRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdatePreferencesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BCMPricingCalculator");
            string target = "AWSBCMPricingCalculator.UpdatePreferences";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-06-19";
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
            if (publicRequest.IsSetManagementAccountRateTypeSelections())
            {
                context.Writer.WritePropertyName("managementAccountRateTypeSelections");
                context.Writer.WriteStartArray();
                foreach (var publicRequestManagementAccountRateTypeSelectionsListValue in publicRequest.ManagementAccountRateTypeSelections)
                {
                    context.Writer.WriteStringValue(publicRequestManagementAccountRateTypeSelectionsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetMemberAccountRateTypeSelections())
            {
                context.Writer.WritePropertyName("memberAccountRateTypeSelections");
                context.Writer.WriteStartArray();
                foreach (var publicRequestMemberAccountRateTypeSelectionsListValue in publicRequest.MemberAccountRateTypeSelections)
                {
                    context.Writer.WriteStringValue(publicRequestMemberAccountRateTypeSelectionsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetStandaloneAccountRateTypeSelections())
            {
                context.Writer.WritePropertyName("standaloneAccountRateTypeSelections");
                context.Writer.WriteStartArray();
                foreach (var publicRequestStandaloneAccountRateTypeSelectionsListValue in publicRequest.StandaloneAccountRateTypeSelections)
                {
                    context.Writer.WriteStringValue(publicRequestStandaloneAccountRateTypeSelectionsListValue);
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

        private static readonly UpdatePreferencesRequestMarshaller _instance = new();

        internal static UpdatePreferencesRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdatePreferencesRequestMarshaller Instance => _instance;
    }
}

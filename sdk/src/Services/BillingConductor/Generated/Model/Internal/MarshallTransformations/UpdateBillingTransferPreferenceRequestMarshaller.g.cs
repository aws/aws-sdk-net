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

using Amazon.BillingConductor.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.BillingConductor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateBillingTransferPreference Request Marshaller
    /// </summary>
    public partial class UpdateBillingTransferPreferenceRequestMarshaller : IMarshaller<IRequest, UpdateBillingTransferPreferenceRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateBillingTransferPreferenceRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateBillingTransferPreferenceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BillingConductor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-30";
            request.HttpMethod = "PUT";

            if (publicRequest.IsSetClientToken())
            {
                request.Headers["X-Amzn-Client-Token"] = publicRequest.ClientToken;
            }

            request.ResourcePath = "/update-billing-transfer-preference";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAutoBillingTransferBillingGroupCreation())
            {
                context.Writer.WritePropertyName("AutoBillingTransferBillingGroupCreation");
                context.Writer.WriteStartObject();

                var marshaller = AutoTransferBillingGroupCreationPreferenceMarshaller.Instance;
                marshaller.Marshall(publicRequest.AutoBillingTransferBillingGroupCreation, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetResponsibilityTransferArn())
            {
                context.Writer.WritePropertyName("ResponsibilityTransferArn");
                context.Writer.WriteStringValue(publicRequest.ResponsibilityTransferArn);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateBillingTransferPreferenceRequestMarshaller _instance = new();

        internal static UpdateBillingTransferPreferenceRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateBillingTransferPreferenceRequestMarshaller Instance => _instance;
    }
}

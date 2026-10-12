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

using Amazon.Invoicing.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Invoicing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateProcurementPortalPreferenceStatus Request Marshaller
    /// </summary>
    public partial class UpdateProcurementPortalPreferenceStatusRequestMarshaller : IMarshaller<IRequest, UpdateProcurementPortalPreferenceStatusRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateProcurementPortalPreferenceStatusRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateProcurementPortalPreferenceStatusRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Invoicing");
            string target = "Invoicing.UpdateProcurementPortalPreferenceStatus";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-12-01";
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
            if (publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            else
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetEinvoiceDeliveryPreferenceStatus())
            {
                context.Writer.WritePropertyName("EinvoiceDeliveryPreferenceStatus");
                context.Writer.WriteStringValue(publicRequest.EinvoiceDeliveryPreferenceStatus);
            }
            if (publicRequest.IsSetEinvoiceDeliveryPreferenceStatusReason())
            {
                context.Writer.WritePropertyName("EinvoiceDeliveryPreferenceStatusReason");
                context.Writer.WriteStringValue(publicRequest.EinvoiceDeliveryPreferenceStatusReason);
            }
            if (publicRequest.IsSetProcurementPortalPreferenceArn())
            {
                context.Writer.WritePropertyName("ProcurementPortalPreferenceArn");
                context.Writer.WriteStringValue(publicRequest.ProcurementPortalPreferenceArn);
            }
            if (publicRequest.IsSetPurchaseOrderRetrievalPreferenceStatus())
            {
                context.Writer.WritePropertyName("PurchaseOrderRetrievalPreferenceStatus");
                context.Writer.WriteStringValue(publicRequest.PurchaseOrderRetrievalPreferenceStatus);
            }
            if (publicRequest.IsSetPurchaseOrderRetrievalPreferenceStatusReason())
            {
                context.Writer.WritePropertyName("PurchaseOrderRetrievalPreferenceStatusReason");
                context.Writer.WriteStringValue(publicRequest.PurchaseOrderRetrievalPreferenceStatusReason);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateProcurementPortalPreferenceStatusRequestMarshaller _instance = new();

        internal static UpdateProcurementPortalPreferenceStatusRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateProcurementPortalPreferenceStatusRequestMarshaller Instance => _instance;
    }
}

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

using Amazon.Billing.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Billing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateContractualInvestmentAttestation Request Marshaller
    /// </summary>
    public partial class CreateContractualInvestmentAttestationRequestMarshaller : IMarshaller<IRequest, CreateContractualInvestmentAttestationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateContractualInvestmentAttestationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateContractualInvestmentAttestationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Billing");
            string target = "AWSBilling.CreateContractualInvestmentAttestation";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-09-07";
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
            if (publicRequest.IsSetAdditionalRecipients())
            {
                context.Writer.WritePropertyName("additionalRecipients");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAdditionalRecipientsListValue in publicRequest.AdditionalRecipients)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AdditionalRecipientMarshaller.Instance;
                    marshaller.Marshall(publicRequestAdditionalRecipientsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetApproverDetails())
            {
                context.Writer.WritePropertyName("approverDetails");
                context.Writer.WriteStartObject();

                var marshaller = ApproverDetailsMarshaller.Instance;
                marshaller.Marshall(publicRequest.ApproverDetails, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetAttestationDetails())
            {
                context.Writer.WritePropertyName("attestationDetails");
                context.Writer.WriteStartObject();

                var marshaller = AttestationDetailsMarshaller.Instance;
                marshaller.Marshall(publicRequest.AttestationDetails, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            else
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetContractArn())
            {
                context.Writer.WritePropertyName("contractArn");
                context.Writer.WriteStringValue(publicRequest.ContractArn);
            }
            if (publicRequest.IsSetContractDocumentId())
            {
                context.Writer.WritePropertyName("contractDocumentId");
                context.Writer.WriteStringValue(publicRequest.ContractDocumentId);
            }
            if (publicRequest.IsSetInvestmentDisbursedAt())
            {
                context.Writer.WritePropertyName("investmentDisbursedAt");
                context.Writer.WriteNumberValue(Amazon.Util.AWSSDKUtils.ConvertToUnixEpochSecondsDecimal(publicRequest.InvestmentDisbursedAt.Value));
            }
            if (publicRequest.IsSetInvestmentId())
            {
                context.Writer.WritePropertyName("investmentId");
                context.Writer.WriteStringValue(publicRequest.InvestmentId);
            }
            if (publicRequest.IsSetInvestmentSummaryId())
            {
                context.Writer.WritePropertyName("investmentSummaryId");
                context.Writer.WriteStringValue(publicRequest.InvestmentSummaryId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateContractualInvestmentAttestationRequestMarshaller _instance = new();

        internal static CreateContractualInvestmentAttestationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateContractualInvestmentAttestationRequestMarshaller Instance => _instance;
    }
}

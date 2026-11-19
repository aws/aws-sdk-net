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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.PartnerCentralMarketing.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.PartnerCentralMarketing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCampaign Request Marshaller
    /// </summary>
    public partial class CreateCampaignRequestMarshaller : IMarshaller<IRequest, CreateCampaignRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCampaignRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateCampaignRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PartnerCentralMarketing");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-05-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/AWSPartnerDemandGenerator/operation/CreateCampaign";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetCampaignTemplateId())
                {
                    context.Writer.WriteTextString("CampaignTemplateId");
                    context.Writer.WriteTextString(publicRequest.CampaignTemplateId);
                }
                if (publicRequest.IsSetCatalog())
                {
                    context.Writer.WriteTextString("Catalog");
                    context.Writer.WriteTextString(publicRequest.Catalog);
                }
                if (publicRequest.IsSetClientToken())
                {
                    context.Writer.WriteTextString("ClientToken");
                    context.Writer.WriteTextString(publicRequest.ClientToken);
                }
                else
                {
                    context.Writer.WriteTextString("ClientToken");
                    context.Writer.WriteTextString(Guid.NewGuid().ToString());
                }
                if (publicRequest.IsSetEmailTarget())
                {
                    context.Writer.WriteTextString("EmailTarget");
                    context.Writer.WriteStartMap(null);

                    var marshaller = FileRefMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EmailTarget, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetEmailTargetEngagementGroupIds())
                {
                    context.Writer.WriteTextString("EmailTargetEngagementGroupIds");
                    context.Writer.WriteStartArray(publicRequest.EmailTargetEngagementGroupIds.Count);
                    foreach (var publicRequestEmailTargetEngagementGroupIdsListValue in publicRequest.EmailTargetEngagementGroupIds)
                    {
                        context.Writer.WriteTextString(publicRequestEmailTargetEngagementGroupIdsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetEndOn())
                {
                    context.Writer.WriteTextString("EndOn");
                    context.Writer.WriteTextString(publicRequest.EndOn);
                }
                if (publicRequest.IsSetEstimatedBudget())
                {
                    context.Writer.WriteTextString("EstimatedBudget");
                    context.Writer.WriteStartMap(null);

                    var marshaller = MonetaryValueMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EstimatedBudget, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetName())
                {
                    context.Writer.WriteTextString("Name");
                    context.Writer.WriteTextString(publicRequest.Name);
                }
                if (publicRequest.IsSetPartnerAddress())
                {
                    context.Writer.WriteTextString("PartnerAddress");
                    context.Writer.WriteTextString(publicRequest.PartnerAddress);
                }
                if (publicRequest.IsSetPartnerBadge())
                {
                    context.Writer.WriteTextString("PartnerBadge");
                    context.Writer.WriteStartMap(null);

                    var marshaller = FileRefMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PartnerBadge, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetPrivacyPolicyUrl())
                {
                    context.Writer.WriteTextString("PrivacyPolicyUrl");
                    context.Writer.WriteTextString(publicRequest.PrivacyPolicyUrl);
                }
                if (publicRequest.IsSetSenderEmail())
                {
                    context.Writer.WriteTextString("SenderEmail");
                    context.Writer.WriteTextString(publicRequest.SenderEmail);
                }
                if (publicRequest.IsSetStartOn())
                {
                    context.Writer.WriteTextString("StartOn");
                    context.Writer.WriteTextString(publicRequest.StartOn);
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("Tags");
                    context.Writer.WriteStartArray(publicRequest.Tags.Count);
                    foreach (var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetTargetAudience())
                {
                    context.Writer.WriteTextString("TargetAudience");
                    context.Writer.WriteStartMap(null);

                    var marshaller = TargetAudienceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TargetAudience, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetTotalBudget())
                {
                    context.Writer.WriteTextString("TotalBudget");
                    context.Writer.WriteStartMap(null);

                    var marshaller = MonetaryValueMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TotalBudget, context);

                    context.Writer.WriteEndMap();
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }

            return request;
        }

        private static readonly CreateCampaignRequestMarshaller _instance = new();

        internal static CreateCampaignRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateCampaignRequestMarshaller Instance => _instance;
    }
}

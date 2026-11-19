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
    /// ListCampaigns Request Marshaller
    /// </summary>
    public partial class ListCampaignsRequestMarshaller : IMarshaller<IRequest, ListCampaignsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListCampaignsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ListCampaignsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PartnerCentralMarketing");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-05-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/AWSPartnerDemandGenerator/operation/ListCampaigns";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetCampaignIdentifiers())
                {
                    context.Writer.WriteTextString("CampaignIdentifiers");
                    context.Writer.WriteStartArray(publicRequest.CampaignIdentifiers.Count);
                    foreach (var publicRequestCampaignIdentifiersListValue in publicRequest.CampaignIdentifiers)
                    {
                        context.Writer.WriteTextString(publicRequestCampaignIdentifiersListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetCatalog())
                {
                    context.Writer.WriteTextString("Catalog");
                    context.Writer.WriteTextString(publicRequest.Catalog);
                }
                if (publicRequest.IsSetMaxResults())
                {
                    context.Writer.WriteTextString("MaxResults");
                    context.Writer.WriteInt32(publicRequest.MaxResults.Value);
                }
                if (publicRequest.IsSetName())
                {
                    context.Writer.WriteTextString("Name");
                    context.Writer.WriteTextString(publicRequest.Name);
                }
                if (publicRequest.IsSetNextToken())
                {
                    context.Writer.WriteTextString("NextToken");
                    context.Writer.WriteTextString(publicRequest.NextToken);
                }
                if (publicRequest.IsSetSort())
                {
                    context.Writer.WriteTextString("Sort");
                    context.Writer.WriteStartMap(null);

                    var marshaller = CampaignSortMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Sort, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetStates())
                {
                    context.Writer.WriteTextString("States");
                    context.Writer.WriteStartArray(publicRequest.States.Count);
                    foreach (var publicRequestStatesListValue in publicRequest.States)
                    {
                        context.Writer.WriteTextString(publicRequestStatesListValue);
                    }
                    context.Writer.WriteEndArray();
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

        private static readonly ListCampaignsRequestMarshaller _instance = new();

        internal static ListCampaignsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListCampaignsRequestMarshaller Instance => _instance;
    }
}

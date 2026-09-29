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

using Amazon.ManagedBlockchain.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ManagedBlockchain.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// VoteOnProposal Request Marshaller
    /// </summary>
    public partial class VoteOnProposalRequestMarshaller : IMarshaller<IRequest, VoteOnProposalRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((VoteOnProposalRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(VoteOnProposalRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ManagedBlockchain");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-09-24";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetNetworkId())
            {
                throw new AmazonManagedBlockchainException("Request object does not have required field NetworkId set");
            }
            request.AddPathResource("{NetworkId}", StringUtils.FromString(publicRequest.NetworkId));

            if (!publicRequest.IsSetProposalId())
            {
                throw new AmazonManagedBlockchainException("Request object does not have required field ProposalId set");
            }
            request.AddPathResource("{ProposalId}", StringUtils.FromString(publicRequest.ProposalId));

            request.ResourcePath = "/networks/{NetworkId}/proposals/{ProposalId}/votes";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetVote())
            {
                context.Writer.WritePropertyName("Vote");
                context.Writer.WriteStringValue(publicRequest.Vote);
            }
            if (publicRequest.IsSetVoterMemberId())
            {
                context.Writer.WritePropertyName("VoterMemberId");
                context.Writer.WriteStringValue(publicRequest.VoterMemberId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly VoteOnProposalRequestMarshaller _instance = new();

        internal static VoteOnProposalRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static VoteOnProposalRequestMarshaller Instance => _instance;
    }
}

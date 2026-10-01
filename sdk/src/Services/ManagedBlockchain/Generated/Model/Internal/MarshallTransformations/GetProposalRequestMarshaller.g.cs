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
    /// GetProposal Request Marshaller
    /// </summary>
    public partial class GetProposalRequestMarshaller : IMarshaller<IRequest, GetProposalRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetProposalRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetProposalRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ManagedBlockchain");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-09-24";
            request.HttpMethod = "GET";

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

            request.ResourcePath = "/networks/{NetworkId}/proposals/{ProposalId}";

            return request;
        }

        private static readonly GetProposalRequestMarshaller _instance = new();

        internal static GetProposalRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetProposalRequestMarshaller Instance => _instance;
    }
}

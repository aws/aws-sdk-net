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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ManagedBlockchain.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.ManagedBlockchain.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListProposalVotes Request Marshaller
    /// </summary>       
    public class ListProposalVotesRequestMarshaller : IMarshaller<IRequest, ListProposalVotesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListProposalVotesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListProposalVotesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ManagedBlockchain");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-09-24";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetNetworkId())
                throw new AmazonManagedBlockchainException("Request object does not have required field NetworkId set");
            request.AddPathResource("{networkId}", StringUtils.FromString(publicRequest.NetworkId));
            if (!publicRequest.IsSetProposalId())
                throw new AmazonManagedBlockchainException("Request object does not have required field ProposalId set");
            request.AddPathResource("{proposalId}", StringUtils.FromString(publicRequest.ProposalId));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/networks/{networkId}/proposals/{proposalId}/votes";
            request.UseQueryString = true;

            return request;
        }
        private static ListProposalVotesRequestMarshaller _instance = new ListProposalVotesRequestMarshaller();        

        internal static ListProposalVotesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListProposalVotesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
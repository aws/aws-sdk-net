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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// This is the response object from the ListProposalVotes operation.
    /// </summary>
    public partial class ListProposalVotesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<VoteSummary> _proposalVotes = new List<VoteSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The pagination token that indicates the next set of results to retrieve. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ProposalVotes. 
        /// <para>
        ///  The list of votes. 
        /// </para>
        /// </summary>
        public List<VoteSummary> ProposalVotes
        {
            get { return this._proposalVotes; }
            set { this._proposalVotes = value; }
        }

        // Check to see if ProposalVotes property is set
        internal bool IsSetProposalVotes()
        {
            return this._proposalVotes != null && this._proposalVotes.Count > 0; 
        }

    }
}
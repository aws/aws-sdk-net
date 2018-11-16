/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RAM.Model
{
    /// <summary>
    /// Container for the parameters to the GetResourceShareInvitations operation.
    /// Gets the specified invitations for resource sharing.
    /// </summary>
    public partial class GetResourceShareInvitationsRequest : AmazonRAMRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private List<string> _resourceShareArns = new List<string>();
        private List<string> _resourceShareInvitationArns = new List<string>();

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return with a single call. To retrieve the remaining
        /// results, make another call with the returned <code>nextToken</code> value.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ResourceShareArns. 
        /// <para>
        /// The Amazon Resource Names (ARN) of the resource shares.
        /// </para>
        /// </summary>
        public List<string> ResourceShareArns
        {
            get { return this._resourceShareArns; }
            set { this._resourceShareArns = value; }
        }

        // Check to see if ResourceShareArns property is set
        internal bool IsSetResourceShareArns()
        {
            return this._resourceShareArns != null && this._resourceShareArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceShareInvitationArns. 
        /// <para>
        /// The Amazon Resource Names (ARN) of the invitations.
        /// </para>
        /// </summary>
        public List<string> ResourceShareInvitationArns
        {
            get { return this._resourceShareInvitationArns; }
            set { this._resourceShareInvitationArns = value; }
        }

        // Check to see if ResourceShareInvitationArns property is set
        internal bool IsSetResourceShareInvitationArns()
        {
            return this._resourceShareInvitationArns != null && this._resourceShareInvitationArns.Count > 0; 
        }

    }
}
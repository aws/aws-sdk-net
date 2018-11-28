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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the ListInvitations operation.
    /// </summary>
    public partial class ListInvitationsResponse : AmazonWebServiceResponse
    {
        private List<Invitation> _invitations = new List<Invitation>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Invitations. 
        /// <para>
        /// The details of the invitations returned by the operation.
        /// </para>
        /// </summary>
        public List<Invitation> Invitations
        {
            get { return this._invitations; }
            set { this._invitations = value; }
        }

        // Check to see if Invitations property is set
        internal bool IsSetInvitations()
        {
            return this._invitations != null && this._invitations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that is required for pagination.
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

    }
}
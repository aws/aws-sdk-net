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
    /// Container for the parameters to the ListMembers operation.
    /// Lists details about all member accounts for the current Security Hub master account.
    /// </summary>
    public partial class ListMembersRequest : AmazonSecurityHubRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private bool? _onlyAssociated;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Indicates the maximum number of items that you want in the response. 
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
        /// Paginates results. Set the value of this parameter to NULL on your first call to the
        /// ListMembers operation. For subsequent calls to the operation, fill nextToken in the
        /// request with the value of NextToken from the previous response to continue listing
        /// data. 
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
        /// Gets and sets the property OnlyAssociated. 
        /// <para>
        /// Specifies what member accounts the response includes based on their relationship status
        /// with the master account. The default value is TRUE. If onlyAssociated is set to TRUE,
        /// the response includes member accounts whose relationship status with the master is
        /// set to ENABLED or DISABLED. If onlyAssociated is set to FALSE, the response includes
        /// all existing member accounts. 
        /// </para>
        /// </summary>
        public bool OnlyAssociated
        {
            get { return this._onlyAssociated.GetValueOrDefault(); }
            set { this._onlyAssociated = value; }
        }

        // Check to see if OnlyAssociated property is set
        internal bool IsSetOnlyAssociated()
        {
            return this._onlyAssociated.HasValue; 
        }

    }
}
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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the ListMembers operation.
    /// Retrieves information about the accounts that are associated with an Amazon Macie
    /// master account.
    /// </summary>
    public partial class ListMembersRequest : AmazonMacie2Request
    {
        private int? _maxResults;
        private string _nextToken;
        private string _onlyAssociated;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to include in each page of a paginated response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
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
        /// The nextToken string that specifies which page of results to return in a paginated
        /// response.
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
        /// Specifies which accounts to include in the response, based on the status of an account's
        /// relationship with the master account. By default, the response includes only current
        /// member accounts. To include all accounts, set the value for this parameter to false.
        /// </para>
        /// </summary>
        public string OnlyAssociated
        {
            get { return this._onlyAssociated; }
            set { this._onlyAssociated = value; }
        }

        // Check to see if OnlyAssociated property is set
        internal bool IsSetOnlyAssociated()
        {
            return this._onlyAssociated != null;
        }

    }
}
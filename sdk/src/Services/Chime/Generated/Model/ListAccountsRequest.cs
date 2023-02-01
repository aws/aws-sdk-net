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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the ListAccounts operation.
    /// Lists the Amazon Chime accounts under the administrator's AWS account. You can filter
    /// accounts by account name prefix. To find out which Amazon Chime account a user belongs
    /// to, you can filter by the user's email address, which returns one account result.
    /// </summary>
    public partial class ListAccountsRequest : AmazonChimeRequest
    {
        private int? _maxResults;
        private string _name;
        private string _nextToken;
        private string _userEmail;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. Defaults to 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// Amazon Chime account name prefix with which to filter results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results.
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
        /// Gets and sets the property UserEmail. 
        /// <para>
        /// User email address with which to filter results.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string UserEmail
        {
            get { return this._userEmail; }
            set { this._userEmail = value; }
        }

        // Check to see if UserEmail property is set
        internal bool IsSetUserEmail()
        {
            return this._userEmail != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Container for the parameters to the GetSimilarProfiles operation.
    /// Returns a set of profiles that belong to the same matching group using the <c>matchId</c>
    /// or <c>profileId</c>. You can also specify the type of matching that you want for finding
    /// similar profiles using either <c>RULE_BASED_MATCHING</c> or <c>ML_BASED_MATCHING</c>.
    /// </summary>
    public partial class GetSimilarProfilesRequest : AmazonCustomerProfilesRequest
    {
        private string _domainName;
        private MatchType _matchType;
        private int? _maxResults;
        private string _nextToken;
        private string _searchKey;
        private string _searchValue;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property MatchType. 
        /// <para>
        /// Specify the type of matching to get similar profiles for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MatchType MatchType
        {
            get { return this._matchType; }
            set { this._matchType = value; }
        }

        // Check to see if MatchType property is set
        internal bool IsSetMatchType()
        {
            return this._matchType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of objects returned per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// The pagination token from the previous <c>GetSimilarProfiles</c> API call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property SearchKey. 
        /// <para>
        /// The string indicating the search key to be used.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string SearchKey
        {
            get { return this._searchKey; }
            set { this._searchKey = value; }
        }

        // Check to see if SearchKey property is set
        internal bool IsSetSearchKey()
        {
            return this._searchKey != null;
        }

        /// <summary>
        /// Gets and sets the property SearchValue. 
        /// <para>
        /// The string based on <c>SearchKey</c> to be searched for similar profiles.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string SearchValue
        {
            get { return this._searchValue; }
            set { this._searchValue = value; }
        }

        // Check to see if SearchValue property is set
        internal bool IsSetSearchValue()
        {
            return this._searchValue != null;
        }

    }
}
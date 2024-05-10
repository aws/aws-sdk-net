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
    /// This is the response object from the ListRuleBasedMatches operation.
    /// </summary>
    public partial class ListRuleBasedMatchesResponse : AmazonWebServiceResponse
    {
        private List<string> _matchIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MatchIds. 
        /// <para>
        /// The list of <c>MatchIds</c> for the given domain.
        /// </para>
        /// </summary>
        public List<string> MatchIds
        {
            get { return this._matchIds; }
            set { this._matchIds = value; }
        }

        // Check to see if MatchIds property is set
        internal bool IsSetMatchIds()
        {
            return this._matchIds != null && (this._matchIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token from the previous <c>ListRuleBasedMatches</c> API call.
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

    }
}
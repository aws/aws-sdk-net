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
    /// This is the response object from the GetMatches operation.
    /// </summary>
    public partial class GetMatchesResponse : AmazonWebServiceResponse
    {
        private List<MatchItem> _matches = AWSConfigs.InitializeCollections ? new List<MatchItem>() : null;
        private DateTime? _matchGenerationDate;
        private string _nextToken;
        private int? _potentialMatches;

        /// <summary>
        /// Gets and sets the property Matches. 
        /// <para>
        /// The list of matched profiles for this instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MatchItem> Matches
        {
            get { return this._matches; }
            set { this._matches = value; }
        }

        // Check to see if Matches property is set
        internal bool IsSetMatches()
        {
            return this._matches != null && (this._matches.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MatchGenerationDate. 
        /// <para>
        /// The timestamp this version of Match Result generated.
        /// </para>
        /// </summary>
        public DateTime? MatchGenerationDate
        {
            get { return this._matchGenerationDate; }
            set { this._matchGenerationDate = value; }
        }

        // Check to see if MatchGenerationDate property is set
        internal bool IsSetMatchGenerationDate()
        {
            return this._matchGenerationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are additional results, this is the token for the next set of results.
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
        /// Gets and sets the property PotentialMatches. 
        /// <para>
        /// The number of potential matches found.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? PotentialMatches
        {
            get { return this._potentialMatches; }
            set { this._potentialMatches = value; }
        }

        // Check to see if PotentialMatches property is set
        internal bool IsSetPotentialMatches()
        {
            return this._potentialMatches.HasValue; 
        }

    }
}
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
    /// This is the response object from the GetSimilarProfiles operation.
    /// </summary>
    public partial class GetSimilarProfilesResponse : AmazonWebServiceResponse
    {
        private double? _confidenceScore;
        private string _matchId;
        private MatchType _matchType;
        private string _nextToken;
        private List<string> _profileIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _ruleLevel;

        /// <summary>
        /// Gets and sets the property ConfidenceScore. 
        /// <para>
        /// It only has value when the <c>MatchType</c> is <c>ML_BASED_MATCHING</c>.A number between
        /// 0 and 1, where a higher score means higher similarity. Examining match confidence
        /// scores lets you distinguish between groups of similar records in which the system
        /// is highly confident (which you may decide to merge), groups of similar records about
        /// which the system is uncertain (which you may decide to have reviewed by a human),
        /// and groups of similar records that the system deems to be unlikely (which you may
        /// decide to reject). Given confidence scores vary as per the data input, it should not
        /// be used as an absolute measure of matching quality.
        /// </para>
        /// </summary>
        public double? ConfidenceScore
        {
            get { return this._confidenceScore; }
            set { this._confidenceScore = value; }
        }

        // Check to see if ConfidenceScore property is set
        internal bool IsSetConfidenceScore()
        {
            return this._confidenceScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MatchId. 
        /// <para>
        /// The string <c>matchId</c> that the similar profiles belong to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string MatchId
        {
            get { return this._matchId; }
            set { this._matchId = value; }
        }

        // Check to see if MatchId property is set
        internal bool IsSetMatchId()
        {
            return this._matchId != null;
        }

        /// <summary>
        /// Gets and sets the property MatchType. 
        /// <para>
        /// Specify the type of matching to get similar profiles for.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ProfileIds. 
        /// <para>
        /// Set of <c>profileId</c>s that belong to the same matching group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ProfileIds
        {
            get { return this._profileIds; }
            set { this._profileIds = value; }
        }

        // Check to see if ProfileIds property is set
        internal bool IsSetProfileIds()
        {
            return this._profileIds != null && (this._profileIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RuleLevel. 
        /// <para>
        /// The integer rule level that the profiles matched on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public int? RuleLevel
        {
            get { return this._ruleLevel; }
            set { this._ruleLevel = value; }
        }

        // Check to see if RuleLevel property is set
        internal bool IsSetRuleLevel()
        {
            return this._ruleLevel.HasValue; 
        }

    }
}
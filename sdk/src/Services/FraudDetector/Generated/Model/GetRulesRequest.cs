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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
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
namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Container for the parameters to the GetRules operation.
    /// Get all rules for a detector (paginated) if <c>ruleId</c> and <c>ruleVersion</c> are
    /// not specified. Gets all rules for the detector and the <c>ruleId</c> if present (paginated).
    /// Gets a specific rule if both the <c>ruleId</c> and the <c>ruleVersion</c> are specified.
    /// 
    ///  
    /// <para>
    /// This is a paginated API. Providing null maxResults results in retrieving maximum of
    /// 100 records per page. If you provide maxResults the value must be between 50 and 100.
    /// To get the next page result, a provide a pagination token from GetRulesResult as part
    /// of your request. Null pagination token fetches the records from the beginning.
    /// </para>
    /// </summary>
    public partial class GetRulesRequest : AmazonFraudDetectorRequest
    {
        private string _detectorId;
        private int? _maxResults;
        private string _nextToken;
        private string _ruleId;
        private string _ruleVersion;

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The detector ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of rules to return for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=100)]
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
        /// The next page token.
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
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The rule ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string RuleId
        {
            get { return this._ruleId; }
            set { this._ruleId = value; }
        }

        // Check to see if RuleId property is set
        internal bool IsSetRuleId()
        {
            return this._ruleId != null;
        }

        /// <summary>
        /// Gets and sets the property RuleVersion. 
        /// <para>
        /// The rule version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public string RuleVersion
        {
            get { return this._ruleVersion; }
            set { this._ruleVersion = value; }
        }

        // Check to see if RuleVersion property is set
        internal bool IsSetRuleVersion()
        {
            return this._ruleVersion != null;
        }

    }
}
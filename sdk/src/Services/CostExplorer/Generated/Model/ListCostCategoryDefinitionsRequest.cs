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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the ListCostCategoryDefinitions operation.
    /// Returns the name, Amazon Resource Name (ARN), <c>NumberOfRules</c> and effective dates
    /// of all Cost Categories defined in the account. You have the option to use <c>EffectiveOn</c>
    /// to return a list of Cost Categories that were active on a specific date. If there
    /// is no <c>EffectiveOn</c> specified, you’ll see Cost Categories that are effective
    /// on the current date. If Cost Category is still effective, <c>EffectiveEnd</c> is omitted
    /// in the response. <c>ListCostCategoryDefinitions</c> supports pagination. The request
    /// can have a <c>MaxResults</c> range up to 100.
    /// </summary>
    public partial class ListCostCategoryDefinitionsRequest : AmazonCostExplorerRequest
    {
        private string _effectiveOn;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EffectiveOn. 
        /// <para>
        /// The date when the Cost Category was effective. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=25)]
        public string EffectiveOn
        {
            get { return this._effectiveOn; }
            set { this._effectiveOn = value; }
        }

        // Check to see if EffectiveOn property is set
        internal bool IsSetEffectiveOn()
        {
            return this._effectiveOn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of entries a paginated response contains. 
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
        /// The token to retrieve the next set of results. Amazon Web Services provides the token
        /// when the response from a previous call has more results than the maximum page size.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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
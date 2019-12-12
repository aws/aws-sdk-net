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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the ListCostCategoryDefinitions operation.
    /// <important> 
    /// <para>
    ///  <i> <b>Cost Category is in preview release for AWS Billing and Cost Management and
    /// is subject to change. Your use of Cost Categories is subject to the Beta Service Participation
    /// terms of the <a href="https://aws.amazon.com/service-terms/">AWS Service Terms</a>
    /// (Section 1.10).</b> </i> 
    /// </para>
    ///  </important> 
    /// <para>
    /// Returns the name, ARN and effective dates of all Cost Categories defined in the account.
    /// You have the option to use <code>EffectiveOn</code> to return a list of Cost Categories
    /// that were active on a specific date. If there is no <code>EffectiveOn</code> specified,
    /// you’ll see Cost Categories that are effective on the current date. If Cost Category
    /// is still effective, <code>EffectiveEnd</code> is omitted in the response. 
    /// </para>
    /// </summary>
    public partial class ListCostCategoryDefinitionsRequest : AmazonCostExplorerRequest
    {
        private string _effectiveOn;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EffectiveOn. 
        /// <para>
        ///  The date when the Cost Category was effective. 
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
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token to retrieve the next set of results. Amazon Web Services provides the token
        /// when the response from a previous call has more results than the maximum page size.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can use this information to retrieve the full Cost Category information using
        /// <code>DescribeCostCategory</code>.
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
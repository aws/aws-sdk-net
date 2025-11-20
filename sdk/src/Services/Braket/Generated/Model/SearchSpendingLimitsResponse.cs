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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
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
namespace Amazon.Braket.Model
{
    /// <summary>
    /// This is the response object from the SearchSpendingLimits operation.
    /// </summary>
    public partial class SearchSpendingLimitsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SpendingLimitSummary> _spendingLimits = AWSConfigs.InitializeCollections ? new List<SpendingLimitSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to retrieve the next page of results. This value is null when there are
        /// no more results to return.
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
        /// Gets and sets the property SpendingLimits. 
        /// <para>
        /// An array of spending limit summaries that match the specified filters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SpendingLimitSummary> SpendingLimits
        {
            get { return this._spendingLimits; }
            set { this._spendingLimits = value; }
        }

        // Check to see if SpendingLimits property is set
        internal bool IsSetSpendingLimits()
        {
            return this._spendingLimits != null && (this._spendingLimits.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
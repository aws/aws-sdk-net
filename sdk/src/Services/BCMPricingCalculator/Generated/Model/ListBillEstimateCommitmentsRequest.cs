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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
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
namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Container for the parameters to the ListBillEstimateCommitments operation.
    /// Lists the commitments associated with a bill estimate.
    /// </summary>
    public partial class ListBillEstimateCommitmentsRequest : AmazonBCMPricingCalculatorRequest
    {
        private string _billEstimateId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BillEstimateId. 
        /// <para>
        ///  The unique identifier of the bill estimate to list commitments for. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string BillEstimateId
        {
            get { return this._billEstimateId; }
            set { this._billEstimateId = value; }
        }

        // Check to see if BillEstimateId property is set
        internal bool IsSetBillEstimateId()
        {
            return this._billEstimateId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to return per page. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
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
        ///  A token to retrieve the next page of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
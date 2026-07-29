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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
namespace Amazon.Billing.Model
{
    /// <summary>
    /// This is the response object from the GetCreditAllocationHistory operation.
    /// </summary>
    public partial class GetCreditAllocationHistoryResponse : AmazonWebServiceResponse
    {
        private List<CreditAllocationHistoryEntry> _creditAllocationHistoryList = AWSConfigs.InitializeCollections ? new List<CreditAllocationHistoryEntry>() : null;
        private List<string> _failedMonths = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _nextToken;
        private bool? _partialResults;

        /// <summary>
        /// Gets and sets the property CreditAllocationHistoryList. 
        /// <para>
        /// Allocation entries sorted by <c>billingMonth</c> in descending order.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CreditAllocationHistoryEntry> CreditAllocationHistoryList
        {
            get { return this._creditAllocationHistoryList; }
            set { this._creditAllocationHistoryList = value; }
        }

        // Check to see if CreditAllocationHistoryList property is set
        internal bool IsSetCreditAllocationHistoryList()
        {
            return this._creditAllocationHistoryList != null && (this._creditAllocationHistoryList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailedMonths. 
        /// <para>
        /// Billing months in <c>YYYY-MM</c> format that failed to return data. Non-empty only
        /// when <c>partialResults</c> is <c>true</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailedMonths
        {
            get { return this._failedMonths; }
            set { this._failedMonths = value; }
        }

        // Check to see if FailedMonths property is set
        internal bool IsSetFailedMonths()
        {
            return this._failedMonths != null && (this._failedMonths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token. Present when more pages are available; <c>null</c> when there are
        /// no more results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4095)]
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
        /// Gets and sets the property PartialResults. 
        /// <para>
        ///  <c>true</c> when data could not be retrieved for one or more billing months. The
        /// <c>failedMonths</c> field lists which months are missing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? PartialResults
        {
            get { return this._partialResults; }
            set { this._partialResults = value; }
        }

        // Check to see if PartialResults property is set
        internal bool IsSetPartialResults()
        {
            return this._partialResults.HasValue; 
        }

    }
}
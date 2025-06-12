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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
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
namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// This is the response object from the GetBillingGroupCostReport operation.
    /// </summary>
    public partial class GetBillingGroupCostReportResponse : AmazonWebServiceResponse
    {
        private List<BillingGroupCostReportResultElement> _billingGroupCostReportResults = AWSConfigs.InitializeCollections ? new List<BillingGroupCostReportResultElement>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BillingGroupCostReportResults. 
        /// <para>
        /// The list of margin summary reports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BillingGroupCostReportResultElement> BillingGroupCostReportResults
        {
            get { return this._billingGroupCostReportResults; }
            set { this._billingGroupCostReportResults = value; }
        }

        // Check to see if BillingGroupCostReportResults property is set
        internal bool IsSetBillingGroupCostReportResults()
        {
            return this._billingGroupCostReportResults != null && (this._billingGroupCostReportResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token used on subsequent calls to get reports.
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
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
    /// This is the response object from the GetSavingsPlansUtilizationDetails operation.
    /// </summary>
    public partial class GetSavingsPlansUtilizationDetailsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SavingsPlansUtilizationDetail> _savingsPlansUtilizationDetails = AWSConfigs.InitializeCollections ? new List<SavingsPlansUtilizationDetail>() : null;
        private DateInterval _timePeriod;
        private SavingsPlansUtilizationAggregates _total;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to retrieve the next set of results. Amazon Web Services provides the token
        /// when the response from a previous call has more results than the maximum page size.
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

        /// <summary>
        /// Gets and sets the property SavingsPlansUtilizationDetails. 
        /// <para>
        /// Retrieves a single daily or monthly Savings Plans utilization rate and details for
        /// your account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SavingsPlansUtilizationDetail> SavingsPlansUtilizationDetails
        {
            get { return this._savingsPlansUtilizationDetails; }
            set { this._savingsPlansUtilizationDetails = value; }
        }

        // Check to see if SavingsPlansUtilizationDetails property is set
        internal bool IsSetSavingsPlansUtilizationDetails()
        {
            return this._savingsPlansUtilizationDetails != null && (this._savingsPlansUtilizationDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimePeriod.
        /// </summary>
        [AWSProperty(Required=true)]
        public DateInterval TimePeriod
        {
            get { return this._timePeriod; }
            set { this._timePeriod = value; }
        }

        // Check to see if TimePeriod property is set
        internal bool IsSetTimePeriod()
        {
            return this._timePeriod != null;
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total Savings Plans utilization, regardless of time period.
        /// </para>
        /// </summary>
        public SavingsPlansUtilizationAggregates Total
        {
            get { return this._total; }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total != null;
        }

    }
}
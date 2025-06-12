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
    /// Container for the parameters to the GetBillingGroupCostReport operation.
    /// Retrieves the margin summary report, which includes the Amazon Web Services cost and
    /// charged amount (pro forma cost) by Amazon Web Service for a specific billing group.
    /// </summary>
    public partial class GetBillingGroupCostReportRequest : AmazonBillingConductorRequest
    {
        private string _arn;
        private BillingPeriodRange _billingPeriodRange;
        private List<string> _groupBy = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Number (ARN) that uniquely identifies the billing group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property BillingPeriodRange. 
        /// <para>
        /// A time range for which the margin summary is effective. You can specify up to 12 months.
        /// </para>
        /// </summary>
        public BillingPeriodRange BillingPeriodRange
        {
            get { return this._billingPeriodRange; }
            set { this._billingPeriodRange = value; }
        }

        // Check to see if BillingPeriodRange property is set
        internal bool IsSetBillingPeriodRange()
        {
            return this._billingPeriodRange != null;
        }

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// A list of strings that specify the attributes that are used to break down costs in
        /// the margin summary reports for the billing group. For example, you can view your costs
        /// by the Amazon Web Service name or the billing period.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GroupBy
        {
            get { return this._groupBy; }
            set { this._groupBy = value; }
        }

        // Check to see if GroupBy property is set
        internal bool IsSetGroupBy()
        {
            return this._groupBy != null && (this._groupBy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of margin summary reports to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=200, Max=300)]
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
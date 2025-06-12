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
    /// This is the response object from the ListPricingPlans operation.
    /// </summary>
    public partial class ListPricingPlansResponse : AmazonWebServiceResponse
    {
        private string _billingPeriod;
        private string _nextToken;
        private List<PricingPlanListElement> _pricingPlans = AWSConfigs.InitializeCollections ? new List<PricingPlanListElement>() : null;

        /// <summary>
        /// Gets and sets the property BillingPeriod. 
        /// <para>
        ///  The billing period for which the described pricing plans are applicable. 
        /// </para>
        /// </summary>
        public string BillingPeriod
        {
            get { return this._billingPeriod; }
            set { this._billingPeriod = value; }
        }

        // Check to see if BillingPeriod property is set
        internal bool IsSetBillingPeriod()
        {
            return this._billingPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token that's used on subsequent calls to get pricing plans. 
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
        /// Gets and sets the property PricingPlans. 
        /// <para>
        /// A list of <c>PricingPlanListElement</c> retrieved. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PricingPlanListElement> PricingPlans
        {
            get { return this._pricingPlans; }
            set { this._pricingPlans = value; }
        }

        // Check to see if PricingPlans property is set
        internal bool IsSetPricingPlans()
        {
            return this._pricingPlans != null && (this._pricingPlans.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
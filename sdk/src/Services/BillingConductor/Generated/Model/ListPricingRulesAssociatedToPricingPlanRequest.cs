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
    /// Container for the parameters to the ListPricingRulesAssociatedToPricingPlan operation.
    /// Lists the pricing rules that are associated with a pricing plan.
    /// </summary>
    public partial class ListPricingRulesAssociatedToPricingPlanRequest : AmazonBillingConductorRequest
    {
        private string _billingPeriod;
        private int? _maxResults;
        private string _nextToken;
        private string _pricingPlanArn;

        /// <summary>
        /// Gets and sets the property BillingPeriod. 
        /// <para>
        ///  The billing period for which the pricing rule associations are to be listed. 
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The optional maximum number of pricing rule associations to retrieve.
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
        ///  The optional pagination token returned by a previous call. 
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
        /// Gets and sets the property PricingPlanArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the pricing plan for which associations are to
        /// be listed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PricingPlanArn
        {
            get { return this._pricingPlanArn; }
            set { this._pricingPlanArn = value; }
        }

        // Check to see if PricingPlanArn property is set
        internal bool IsSetPricingPlanArn()
        {
            return this._pricingPlanArn != null;
        }

    }
}
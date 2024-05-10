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
    /// This is the response object from the ListPricingRules operation.
    /// </summary>
    public partial class ListPricingRulesResponse : AmazonWebServiceResponse
    {
        private string _billingPeriod;
        private string _nextToken;
        private List<PricingRuleListElement> _pricingRules = AWSConfigs.InitializeCollections ? new List<PricingRuleListElement>() : null;

        /// <summary>
        /// Gets and sets the property BillingPeriod. 
        /// <para>
        ///  The billing period for which the described pricing rules are applicable. 
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
        ///  The pagination token that's used on subsequent calls to get pricing rules. 
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
        /// Gets and sets the property PricingRules. 
        /// <para>
        ///  A list containing the described pricing rules. 
        /// </para>
        /// </summary>
        public List<PricingRuleListElement> PricingRules
        {
            get { return this._pricingRules; }
            set { this._pricingRules = value; }
        }

        // Check to see if PricingRules property is set
        internal bool IsSetPricingRules()
        {
            return this._pricingRules != null && (this._pricingRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
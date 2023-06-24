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

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// Container for the parameters to the AssociatePricingRules operation.
    /// Connects an array of <code>PricingRuleArns</code> to a defined <code>PricingPlan</code>.
    /// The maximum number <code>PricingRuleArn</code> that can be associated in one call
    /// is 30.
    /// </summary>
    public partial class AssociatePricingRulesRequest : AmazonBillingConductorRequest
    {
        private string _arn;
        private List<string> _pricingRuleArns = new List<string>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The <code>PricingPlanArn</code> that the <code>PricingRuleArns</code> are associated
        /// with. 
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
        /// Gets and sets the property PricingRuleArns. 
        /// <para>
        ///  The <code>PricingRuleArns</code> that are associated with the Pricing Plan. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public List<string> PricingRuleArns
        {
            get { return this._pricingRuleArns; }
            set { this._pricingRuleArns = value; }
        }

        // Check to see if PricingRuleArns property is set
        internal bool IsSetPricingRuleArns()
        {
            return this._pricingRuleArns != null && this._pricingRuleArns.Count > 0; 
        }

    }
}
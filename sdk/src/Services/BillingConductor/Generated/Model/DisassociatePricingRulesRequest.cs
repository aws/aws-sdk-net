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
    /// Container for the parameters to the DisassociatePricingRules operation.
    /// Disassociates a list of pricing rules from a pricing plan.
    /// </summary>
    public partial class DisassociatePricingRulesRequest : AmazonBillingConductorRequest
    {
        private string _arn;
        private List<string> _pricingRuleArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The pricing plan Amazon Resource Name (ARN) to disassociate pricing rules from. 
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
        ///  A list containing the Amazon Resource Name (ARN) of the pricing rules that will be
        /// disassociated. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._pricingRuleArns != null && (this._pricingRuleArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
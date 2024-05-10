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
    /// This is the response object from the ListPricingPlansAssociatedWithPricingRule operation.
    /// </summary>
    public partial class ListPricingPlansAssociatedWithPricingRuleResponse : AmazonWebServiceResponse
    {
        private string _billingPeriod;
        private string _nextToken;
        private List<string> _pricingPlanArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _pricingRuleArn;

        /// <summary>
        /// Gets and sets the property BillingPeriod. 
        /// <para>
        ///  The pricing plan billing period for which associations will be listed. 
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
        ///  The pagination token to be used on subsequent calls. 
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
        /// Gets and sets the property PricingPlanArns. 
        /// <para>
        ///  The list containing pricing plans that are associated with the requested pricing
        /// rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> PricingPlanArns
        {
            get { return this._pricingPlanArns; }
            set { this._pricingPlanArns = value; }
        }

        // Check to see if PricingPlanArns property is set
        internal bool IsSetPricingPlanArns()
        {
            return this._pricingPlanArns != null && (this._pricingPlanArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PricingRuleArn. 
        /// <para>
        ///  The pricing rule Amazon Resource Name (ARN) for which associations will be listed.
        /// 
        /// </para>
        /// </summary>
        public string PricingRuleArn
        {
            get { return this._pricingRuleArn; }
            set { this._pricingRuleArn = value; }
        }

        // Check to see if PricingRuleArn property is set
        internal bool IsSetPricingRuleArn()
        {
            return this._pricingRuleArn != null;
        }

    }
}
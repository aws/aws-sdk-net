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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the ListPricingRulesAssociatedToPricingPlan operation.
    /// </summary>
    public partial class ListPricingRulesAssociatedToPricingPlanResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BillingPeriod. 
        /// <para>
        ///  The billing period for which the pricing rule associations are listed. 
        /// </para>
        /// </summary>
        public string BillingPeriod { get; set; }

        /// <summary>
        /// Checks to see if the BillingPeriod property is set.
        /// </summary>
        internal bool IsSetBillingPeriod() => this.BillingPeriod != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The pagination token to be used on subsequent calls. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PricingPlanArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the pricing plan for which associations are listed.
        /// </para>
        /// </summary>
        public string PricingPlanArn { get; set; }

        /// <summary>
        /// Checks to see if the PricingPlanArn property is set.
        /// </summary>
        internal bool IsSetPricingPlanArn() => this.PricingPlanArn != null;

        /// <summary>
        /// Gets and sets the property PricingRuleArns. 
        /// <para>
        ///  A list containing pricing rules that are associated with the requested pricing plan.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> PricingRuleArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PricingRuleArns property is set.
        /// </summary>
        internal bool IsSetPricingRuleArns() => this.PricingRuleArns != null && (this.PricingRuleArns.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

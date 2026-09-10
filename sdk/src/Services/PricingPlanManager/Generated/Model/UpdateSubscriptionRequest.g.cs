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

namespace Amazon.PricingPlanManager.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSubscription operation. Changes the plan
    /// tier of an existing subscription. <note> <para> Upgrades take effect immediately.
    /// Downgrades are scheduled and the current tier remains unchanged until the end of the
    /// billing cycle (calendar month). You cannot update a subscription while a scheduled
    /// change is pending. To make a new change, first cancel the pending change using <c>CancelSubscriptionChange</c>.
    /// </para> <para> This operation replaces the plan tier value. If you omit the optional
    /// <c>usageLevel</c> field, it is reset to the default. </para> </note>
    /// </summary>
    public partial class UpdateSubscriptionRequest : AmazonPricingPlanManagerRequest
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the subscription to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the request is handled
        /// only once.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The <c>ETag</c> value from a previous <c>GetSubscription</c> or <c>ListSubscriptions</c>
        /// response. This ensures you are updating the expected version of the subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IfMatch { get; set; }

        /// <summary>
        /// Checks to see if the IfMatch property is set.
        /// </summary>
        internal bool IsSetIfMatch() => this.IfMatch != null;

        /// <summary>
        /// Gets and sets the property PlanTier. 
        /// <para>
        /// The new tier level for the subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PlanTier { get; set; }

        /// <summary>
        /// Checks to see if the PlanTier property is set.
        /// </summary>
        internal bool IsSetPlanTier() => this.PlanTier != null;

        /// <summary>
        /// Gets and sets the property UsageLevel. 
        /// <para>
        /// The usage level within the plan tier. Specify <c>DEFAULT</c> for the base configuration.
        /// If omitted, the usage level is reset to the default.
        /// </para>
        /// </summary>
        public string UsageLevel { get; set; }

        /// <summary>
        /// Checks to see if the UsageLevel property is set.
        /// </summary>
        internal bool IsSetUsageLevel() => this.UsageLevel != null;
    }
}

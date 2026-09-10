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
    /// Container for the parameters to the CreateSubscription operation. Creates a flat-rate
    /// pricing subscription for the specified resources. <note> <para> When <c>approvalMode</c>
    /// is set to <c>MANUAL</c>, paid-tier subscriptions are created in <c>PENDING_APPROVAL</c>
    /// status and require a separate <c>ApprovePaidSubscription</c> call before billing starts.
    /// Free-tier subscriptions are always activated immediately regardless of approval mode.
    /// </para> <para> When <c>approvalMode</c> is set to <c>IMMEDIATE</c> or is not specified,
    /// the subscription is activated immediately. </para> </note>
    /// </summary>
    public partial class CreateSubscriptionRequest : AmazonPricingPlanManagerRequest
    {
        /// <summary>
        /// Gets and sets the property ApprovalMode. 
        /// <para>
        /// Determines whether the subscription requires explicit approval before billing starts.
        /// Set to <c>MANUAL</c> to require a separate <c>ApprovePaidSubscription</c> call, or
        /// <c>IMMEDIATE</c> to activate the subscription right away. For paid tier plans, this
        /// defaults to <c>MANUAL</c> if not specified. For the <c>FREE</c> plan tier, only <c>IMMEDIATE</c>
        /// is supported, and it is the default.
        /// </para>
        /// </summary>
        public ApprovalMode ApprovalMode { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalMode property is set.
        /// </summary>
        internal bool IsSetApprovalMode() => this.ApprovalMode != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure that the request is
        /// handled only once. If you send the same request with the same client token, the API
        /// returns the original response without creating a duplicate subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property PlanFamily. 
        /// <para>
        /// The pricing plan family to subscribe to, such as <c>CloudFront</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PlanFamily { get; set; }

        /// <summary>
        /// Checks to see if the PlanFamily property is set.
        /// </summary>
        internal bool IsSetPlanFamily() => this.PlanFamily != null;

        /// <summary>
        /// Gets and sets the property PlanTier. 
        /// <para>
        /// The tier level for the subscription, such as <c>FREE</c>, <c>PRO</c>, <c>BUSINESS</c>,
        /// or <c>PREMIUM</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PlanTier { get; set; }

        /// <summary>
        /// Checks to see if the PlanTier property is set.
        /// </summary>
        internal bool IsSetPlanTier() => this.PlanTier != null;

        /// <summary>
        /// Gets and sets the property ResourceArns. 
        /// <para>
        /// The ARNs of the resources to include in the subscription. Specify one or more supported
        /// resources.
        /// </para>
        ///  <note> 
        /// <para>
        /// For subscriptions in the CloudFront plan family, the resources must include exactly
        /// one Amazon CloudFront distribution and exactly one WAF web ACL. You can also include
        /// other supported resources, such as Amazon Route 53 hosted zones and CloudFront KeyValueStores.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<string> ResourceArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceArns property is set.
        /// </summary>
        internal bool IsSetResourceArns() => this.ResourceArns != null && (this.ResourceArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UsageLevel. 
        /// <para>
        /// The usage level within the plan tier. Specify <c>DEFAULT</c> for the base configuration,
        /// or a higher level if your plan tier supports it.
        /// </para>
        /// </summary>
        public string UsageLevel { get; set; }

        /// <summary>
        /// Checks to see if the UsageLevel property is set.
        /// </summary>
        internal bool IsSetUsageLevel() => this.UsageLevel != null;
    }
}

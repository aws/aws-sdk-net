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
    /// The full details of a flat-rate pricing subscription, including its current configuration,
    /// status, and associated resources.
    /// </summary>
    public partial class Subscription
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies this subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the subscription was created, in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property PlanFamily. 
        /// <para>
        /// The pricing plan family for the subscription, such as <c>CloudFront</c>.
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
        /// The current tier level of the pricing plan, such as <c>FREE</c>, <c>PRO</c>, <c>BUSINESS</c>,
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
        /// The ARNs of the resources covered by this subscription.
        /// </para>
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
        /// Gets and sets the property ScheduledChange. 
        /// <para>
        /// A pending change that will take effect at the end of the current billing period. This
        /// field is present only when a downgrade or cancellation is scheduled.
        /// </para>
        /// </summary>
        public ScheduledChange ScheduledChange { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledChange property is set.
        /// </summary>
        internal bool IsSetScheduledChange() => this.ScheduledChange != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the subscription. For the list of possible values, see the <c>Status</c>
        /// type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A human-readable explanation of the current status, present when additional context
        /// is available.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the subscription was last modified, in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UsageLevel. 
        /// <para>
        /// The usage level within the plan tier. When present, indicates a specific capacity
        /// configuration beyond the base tier.
        /// </para>
        /// </summary>
        public string UsageLevel { get; set; }

        /// <summary>
        /// Checks to see if the UsageLevel property is set.
        /// </summary>
        internal bool IsSetUsageLevel() => this.UsageLevel != null;
    }
}

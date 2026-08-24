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
 * Do not modify this file. This file is generated from the pricing-plan-manager-2025-08-05.normal.json service model.
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
        private string _arn;
        private DateTime? _createdAt;
        private string _planFamily;
        private string _planTier;
        private List<string> _resourceArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ScheduledChange _scheduledChange;
        private Status _status;
        private string _statusReason;
        private DateTime? _updatedAt;
        private string _usageLevel;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies this subscription.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the subscription was created, in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlanFamily. 
        /// <para>
        /// The pricing plan family for the subscription, such as <c>CloudFront</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PlanFamily
        {
            get { return this._planFamily; }
            set { this._planFamily = value; }
        }

        // Check to see if PlanFamily property is set
        internal bool IsSetPlanFamily()
        {
            return this._planFamily != null;
        }

        /// <summary>
        /// Gets and sets the property PlanTier. 
        /// <para>
        /// The current tier level of the pricing plan, such as <c>FREE</c>, <c>PRO</c>, <c>BUSINESS</c>,
        /// or <c>PREMIUM</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PlanTier
        {
            get { return this._planTier; }
            set { this._planTier = value; }
        }

        // Check to see if PlanTier property is set
        internal bool IsSetPlanTier()
        {
            return this._planTier != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArns. 
        /// <para>
        /// The ARNs of the AWS resources covered by this subscription.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> ResourceArns
        {
            get { return this._resourceArns; }
            set { this._resourceArns = value; }
        }

        // Check to see if ResourceArns property is set
        internal bool IsSetResourceArns()
        {
            return this._resourceArns != null && (this._resourceArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScheduledChange. 
        /// <para>
        /// A pending change that will take effect at the end of the current billing period. This
        /// field is present only when a downgrade or cancellation is scheduled.
        /// </para>
        /// </summary>
        public ScheduledChange ScheduledChange
        {
            get { return this._scheduledChange; }
            set { this._scheduledChange = value; }
        }

        // Check to see if ScheduledChange property is set
        internal bool IsSetScheduledChange()
        {
            return this._scheduledChange != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the subscription. For the list of possible values, see the <c>Status</c>
        /// type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A human-readable explanation of the current status, present when additional context
        /// is available.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the subscription was last modified, in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UsageLevel. 
        /// <para>
        /// The usage level within the plan tier. When present, indicates a specific capacity
        /// configuration beyond the base tier.
        /// </para>
        /// </summary>
        public string UsageLevel
        {
            get { return this._usageLevel; }
            set { this._usageLevel = value; }
        }

        // Check to see if UsageLevel property is set
        internal bool IsSetUsageLevel()
        {
            return this._usageLevel != null;
        }

    }
}
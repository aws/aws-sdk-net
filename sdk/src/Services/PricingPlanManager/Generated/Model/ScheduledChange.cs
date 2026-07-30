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
    /// A pending change on a subscription that takes effect at the end of the current billing
    /// period, such as a tier downgrade or cancellation.
    /// </summary>
    public partial class ScheduledChange
    {
        private ScheduledChangeType _changeType;
        private DateTime? _effectiveDate;
        private string _planTier;
        private string _usageLevel;

        /// <summary>
        /// Gets and sets the property ChangeType. 
        /// <para>
        /// The type of pending change. Possible values are <c>DOWNGRADE</c> (a tier change to
        /// a lower level) and <c>CANCELLATION</c> (subscription termination).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScheduledChangeType ChangeType
        {
            get { return this._changeType; }
            set { this._changeType = value; }
        }

        // Check to see if ChangeType property is set
        internal bool IsSetChangeType()
        {
            return this._changeType != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveDate. 
        /// <para>
        /// The date and time when the change takes effect, in ISO 8601 format. This value is
        /// populated after the change is confirmed by the billing system.
        /// </para>
        /// </summary>
        public DateTime? EffectiveDate
        {
            get { return this._effectiveDate; }
            set { this._effectiveDate = value; }
        }

        // Check to see if EffectiveDate property is set
        internal bool IsSetEffectiveDate()
        {
            return this._effectiveDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlanTier. 
        /// <para>
        /// For downgrades, the tier level that the subscription will change to. Not present for
        /// cancellations.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property UsageLevel. 
        /// <para>
        /// For downgrades, the target usage level after the change takes effect.
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
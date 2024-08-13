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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
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
namespace Amazon.Budgets.Model
{
    /// <summary>
    /// A notification that's associated with a budget. A budget can have up to ten notifications.
    /// 
    /// 
    ///  
    /// <para>
    /// Each notification must have at least one subscriber. A notification can have one SNS
    /// subscriber and up to 10 email subscribers, for a total of 11 subscribers.
    /// </para>
    ///  
    /// <para>
    /// For example, if you have a budget for 200 dollars and you want to be notified when
    /// you go over 160 dollars, create a notification with the following parameters:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A notificationType of <c>ACTUAL</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <c>thresholdType</c> of <c>PERCENTAGE</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <c>comparisonOperator</c> of <c>GREATER_THAN</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A notification <c>threshold</c> of <c>80</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Notification
    {
        private ComparisonOperator _comparisonOperator;
        private NotificationState _notificationState;
        private NotificationType _notificationType;
        private double? _threshold;
        private ThresholdType _thresholdType;

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// The comparison that's used for this notification.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComparisonOperator ComparisonOperator
        {
            get { return this._comparisonOperator; }
            set { this._comparisonOperator = value; }
        }

        // Check to see if ComparisonOperator property is set
        internal bool IsSetComparisonOperator()
        {
            return this._comparisonOperator != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationState. 
        /// <para>
        /// Specifies whether this notification is in alarm. If a budget notification is in the
        /// <c>ALARM</c> state, you passed the set threshold for the budget.
        /// </para>
        /// </summary>
        public NotificationState NotificationState
        {
            get { return this._notificationState; }
            set { this._notificationState = value; }
        }

        // Check to see if NotificationState property is set
        internal bool IsSetNotificationState()
        {
            return this._notificationState != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationType. 
        /// <para>
        /// Specifies whether the notification is for how much you have spent (<c>ACTUAL</c>)
        /// or for how much that you're forecasted to spend (<c>FORECASTED</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotificationType NotificationType
        {
            get { return this._notificationType; }
            set { this._notificationType = value; }
        }

        // Check to see if NotificationType property is set
        internal bool IsSetNotificationType()
        {
            return this._notificationType != null;
        }

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The threshold that's associated with a notification. Thresholds are always a percentage,
        /// and many customers find value being alerted between 50% - 200% of the budgeted amount.
        /// The maximum limit for your threshold is 1,000,000% above the budgeted amount.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=15000000000000)]
        public double? Threshold
        {
            get { return this._threshold; }
            set { this._threshold = value; }
        }

        // Check to see if Threshold property is set
        internal bool IsSetThreshold()
        {
            return this._threshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThresholdType. 
        /// <para>
        /// The type of threshold for a notification. For <c>ABSOLUTE_VALUE</c> thresholds, Amazon
        /// Web Services notifies you when you go over or are forecasted to go over your total
        /// cost threshold. For <c>PERCENTAGE</c> thresholds, Amazon Web Services notifies you
        /// when you go over or are forecasted to go over a certain percentage of your forecasted
        /// spend. For example, if you have a budget for 200 dollars and you have a <c>PERCENTAGE</c>
        /// threshold of 80%, Amazon Web Services notifies you when you go over 160 dollars.
        /// </para>
        /// </summary>
        public ThresholdType ThresholdType
        {
            get { return this._thresholdType; }
            set { this._thresholdType = value; }
        }

        // Check to see if ThresholdType property is set
        internal bool IsSetThresholdType()
        {
            return this._thresholdType != null;
        }

    }
}
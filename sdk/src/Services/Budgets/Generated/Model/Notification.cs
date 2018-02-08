/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Budgets.Model
{
    /// <summary>
    /// A notification associated with a budget. A budget can have up to five notifications.
    /// 
    /// 
    ///  
    /// <para>
    /// Each notification must have at least one subscriber. A notification can have one SNS
    /// subscriber and up to ten email subscribers, for a total of 11 subscribers.
    /// </para>
    ///  
    /// <para>
    /// For example, if you have a budget for 200 dollars and you want to be notified when
    /// you go over 160 dollars, create a notification with the following parameters:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A notificationType of <code>ACTUAL</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A comparisonOperator of <code>GREATER_THAN</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A notification threshold of <code>80</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Notification
    {
        private ComparisonOperator _comparisonOperator;
        private NotificationType _notificationType;
        private double? _threshold;
        private ThresholdType _thresholdType;

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// The comparison used for this notification.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property NotificationType. 
        /// <para>
        /// Whether the notification is for how much you have spent (<code>ACTUAL</code>) or for
        /// how much you are forecasted to spend (<code>FORECASTED</code>).
        /// </para>
        /// </summary>
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
        /// The threshold associated with a notification. Thresholds are always a percentage.
        /// </para>
        /// </summary>
        public double Threshold
        {
            get { return this._threshold.GetValueOrDefault(); }
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
        /// The type of threshold for a notification. For <code>ACTUAL</code> thresholds, AWS
        /// notifies you when you go over the threshold, and for <code>FORECASTED</code> thresholds
        /// AWS notifies you when you are forecasted to go over the threshold.
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
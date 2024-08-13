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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
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
namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Information needed to set the timer.
    /// </summary>
    public partial class SetTimerAction
    {
        private string _durationExpression;
        private int? _seconds;
        private string _timerName;

        /// <summary>
        /// Gets and sets the property DurationExpression. 
        /// <para>
        /// The duration of the timer, in seconds. You can use a string expression that includes
        /// numbers, variables (<c>$variable.&lt;variable-name&gt;</c>), and input values (<c>$input.&lt;input-name&gt;.&lt;path-to-datum&gt;</c>)
        /// as the duration. The range of the duration is 1-31622400 seconds. To ensure accuracy,
        /// the minimum duration is 60 seconds. The evaluated result of the duration is rounded
        /// down to the nearest whole number. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string DurationExpression
        {
            get { return this._durationExpression; }
            set { this._durationExpression = value; }
        }

        // Check to see if DurationExpression property is set
        internal bool IsSetDurationExpression()
        {
            return this._durationExpression != null;
        }

        /// <summary>
        /// Gets and sets the property Seconds. 
        /// <para>
        /// The number of seconds until the timer expires. The minimum value is 60 seconds to
        /// ensure accuracy. The maximum value is 31622400 seconds. 
        /// </para>
        /// </summary>
        [Obsolete("seconds is deprecated. You can use durationExpression for SetTimerAction. The value of seconds can be used as a string expression for durationExpression.")]
        [AWSProperty(Min=1, Max=31622400)]
        public int? Seconds
        {
            get { return this._seconds; }
            set { this._seconds = value; }
        }

        // Check to see if Seconds property is set
        internal bool IsSetSeconds()
        {
            return this._seconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimerName. 
        /// <para>
        /// The name of the timer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string TimerName
        {
            get { return this._timerName; }
            set { this._timerName = value; }
        }

        // Check to see if TimerName property is set
        internal bool IsSetTimerName()
        {
            return this._timerName != null;
        }

    }
}
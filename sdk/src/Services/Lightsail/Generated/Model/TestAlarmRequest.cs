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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the TestAlarm operation.
    /// Tests an alarm by displaying a banner on the Amazon Lightsail console. If a notification
    /// trigger is configured for the specified alarm, the test also sends a notification
    /// to the notification protocol (<c>Email</c> and/or <c>SMS</c>) configured for the alarm.
    /// 
    ///  
    /// <para>
    /// An alarm is used to monitor a single metric for one of your resources. When a metric
    /// condition is met, the alarm can notify you by email, SMS text message, and a banner
    /// displayed on the Amazon Lightsail console. For more information, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-alarms">Alarms
    /// in Amazon Lightsail</a>.
    /// </para>
    /// </summary>
    public partial class TestAlarmRequest : AmazonLightsailRequest
    {
        private string _alarmName;
        private AlarmState _state;

        /// <summary>
        /// Gets and sets the property AlarmName. 
        /// <para>
        /// The name of the alarm to test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AlarmName
        {
            get { return this._alarmName; }
            set { this._alarmName = value; }
        }

        // Check to see if AlarmName property is set
        internal bool IsSetAlarmName()
        {
            return this._alarmName != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The alarm state to test.
        /// </para>
        ///  
        /// <para>
        /// An alarm has the following possible states that can be tested:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALARM</c> - The metric is outside of the defined threshold.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSUFFICIENT_DATA</c> - The alarm has just started, the metric is not available,
        /// or not enough data is available for the metric to determine the alarm state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OK</c> - The metric is within the defined threshold.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public AlarmState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}
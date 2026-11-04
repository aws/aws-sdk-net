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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the SetAlarmState operation. Temporarily sets the
    /// state of an alarm for testing purposes. When the updated state differs from the previous
    /// value, the action configured for the appropriate state is invoked. For example, if
    /// your alarm is configured to send an Amazon SNS message when an alarm is triggered,
    /// temporarily changing the alarm state to <c>ALARM</c> sends an SNS message. <para>
    /// Metric alarms returns to their actual state quickly, often within seconds. Because
    /// the metric alarm state change happens quickly, it is typically only visible in the
    /// alarm's <b>History</b> tab in the Amazon CloudWatch console or through <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_DescribeAlarmHistory.html">DescribeAlarmHistory</a>.
    /// </para> <para> If you use <c>SetAlarmState</c> on a composite alarm, the composite
    /// alarm is not guaranteed to return to its actual state. It returns to its actual state
    /// only once any of its children alarms change state. It is also reevaluated if you update
    /// its configuration. </para> <para> If an alarm triggers EC2 Auto Scaling policies or
    /// application Auto Scaling policies, you must include information in the <c>StateReasonData</c>
    /// parameter to enable the policy to take the correct action. </para>
    /// </summary>
    public partial class SetAlarmStateRequest : AmazonCloudWatchRequest
    {
        /// <summary>
        /// Gets and sets the property AlarmName. 
        /// <para>
        /// The name of the alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string AlarmName { get; set; }

        /// <summary>
        /// Checks to see if the AlarmName property is set.
        /// </summary>
        internal bool IsSetAlarmName() => this.AlarmName != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason that this alarm is set to this specific state, in text format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1023)]
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;

        /// <summary>
        /// Gets and sets the property StateReasonData. 
        /// <para>
        /// The reason that this alarm is set to this specific state, in JSON format.
        /// </para>
        ///  
        /// <para>
        /// For SNS or EC2 alarm actions, this is just informational. But for EC2 Auto Scaling
        /// or application Auto Scaling alarm actions, the Auto Scaling policy uses the information
        /// in this field to take the correct action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4000)]
        public string StateReasonData { get; set; }

        /// <summary>
        /// Checks to see if the StateReasonData property is set.
        /// </summary>
        internal bool IsSetStateReasonData() => this.StateReasonData != null;

        /// <summary>
        /// Gets and sets the property StateValue. 
        /// <para>
        /// The value of the state.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StateValue StateValue { get; set; }

        /// <summary>
        /// Checks to see if the StateValue property is set.
        /// </summary>
        internal bool IsSetStateValue() => this.StateValue != null;
    }
}

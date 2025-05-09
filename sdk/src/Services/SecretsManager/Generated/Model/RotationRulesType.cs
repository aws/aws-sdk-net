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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
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
namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// A structure that defines the rotation configuration for the secret.
    /// </summary>
    public partial class RotationRulesType
    {
        private long? _automaticallyAfterDays;
        private string _duration;
        private string _scheduleExpression;

        /// <summary>
        /// Gets and sets the property AutomaticallyAfterDays. 
        /// <para>
        /// The number of days between rotations of the secret. You can use this value to check
        /// that your secret meets your compliance guidelines for how often secrets must be rotated.
        /// If you use this field to set the rotation schedule, Secrets Manager calculates the
        /// next rotation date based on the previous rotation. Manually updating the secret value
        /// by calling <c>PutSecretValue</c> or <c>UpdateSecret</c> is considered a valid rotation.
        /// </para>
        ///  
        /// <para>
        /// In <c>DescribeSecret</c> and <c>ListSecrets</c>, this value is calculated from the
        /// rotation schedule after every successful rotation. In <c>RotateSecret</c>, you can
        /// set the rotation schedule in <c>RotationRules</c> with <c>AutomaticallyAfterDays</c>
        /// or <c>ScheduleExpression</c>, but not both. To set a rotation schedule in hours, use
        /// <c>ScheduleExpression</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public long? AutomaticallyAfterDays
        {
            get { return this._automaticallyAfterDays; }
            set { this._automaticallyAfterDays = value; }
        }

        // Check to see if AutomaticallyAfterDays property is set
        internal bool IsSetAutomaticallyAfterDays()
        {
            return this._automaticallyAfterDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The length of the rotation window in hours, for example <c>3h</c> for a three hour
        /// window. Secrets Manager rotates your secret at any time during this window. The window
        /// must not extend into the next rotation window or the next UTC day. The window starts
        /// according to the <c>ScheduleExpression</c>. If you don't specify a <c>Duration</c>,
        /// for a <c>ScheduleExpression</c> in hours, the window automatically closes after one
        /// hour. For a <c>ScheduleExpression</c> in days, the window automatically closes at
        /// the end of the UTC day. For more information, including examples, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/rotate-secrets_schedule.html">Schedule
        /// expressions in Secrets Manager rotation</a> in the <i>Secrets Manager Users Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=3)]
        public string Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// A <c>cron()</c> or <c>rate()</c> expression that defines the schedule for rotating
        /// your secret. Secrets Manager rotation schedules use UTC time zone. Secrets Manager
        /// rotates your secret any time during a rotation window.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager <c>rate()</c> expressions represent the interval in hours or days
        /// that you want to rotate your secret, for example <c>rate(12 hours)</c> or <c>rate(10
        /// days)</c>. You can rotate a secret as often as every four hours. If you use a <c>rate()</c>
        /// expression, the rotation window starts at midnight. For a rate in hours, the default
        /// rotation window closes after one hour. For a rate in days, the default rotation window
        /// closes at the end of the day. You can set the <c>Duration</c> to change the rotation
        /// window. The rotation window must not extend into the next UTC day or into the next
        /// rotation window.
        /// </para>
        ///  
        /// <para>
        /// You can use a <c>cron()</c> expression to create a rotation schedule that is more
        /// detailed than a rotation interval. For more information, including examples, see <a
        /// href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/rotate-secrets_schedule.html">Schedule
        /// expressions in Secrets Manager rotation</a> in the <i>Secrets Manager Users Guide</i>.
        /// For a cron expression that represents a schedule in hours, the default rotation window
        /// closes after one hour. For a cron expression that represents a schedule in days, the
        /// default rotation window closes at the end of the day. You can set the <c>Duration</c>
        /// to change the rotation window. The rotation window must not extend into the next UTC
        /// day or into the next rotation window.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ScheduleExpression
        {
            get { return this._scheduleExpression; }
            set { this._scheduleExpression = value; }
        }

        // Check to see if ScheduleExpression property is set
        internal bool IsSetScheduleExpression()
        {
            return this._scheduleExpression != null;
        }

    }
}
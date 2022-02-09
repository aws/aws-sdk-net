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
        /// The number of days between automatic scheduled rotations of the secret. You can use
        /// this value to check that your secret meets your compliance guidelines for how often
        /// secrets must be rotated.
        /// </para>
        ///  
        /// <para>
        /// In <code>DescribeSecret</code> and <code>ListSecrets</code>, this value is calculated
        /// from the rotation schedule after every successful rotation. In <code>RotateSecret</code>,
        /// you can set the rotation schedule in <code>RotationRules</code> with <code>AutomaticallyAfterDays</code>
        /// or <code>ScheduleExpression</code>, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public long AutomaticallyAfterDays
        {
            get { return this._automaticallyAfterDays.GetValueOrDefault(); }
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
        /// The length of the rotation window in hours, for example <code>3h</code> for a three
        /// hour window. Secrets Manager rotates your secret at any time during this window. The
        /// window must not go into the next UTC day. If you don't specify this value, the window
        /// automatically ends at the end of the UTC day. The window begins according to the <code>ScheduleExpression</code>.
        /// For more information, including examples, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/rotate-secrets_schedule.html">Schedule
        /// expressions in Secrets Manager rotation</a>.
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
        /// A <code>cron()</code> or <code>rate()</code> expression that defines the schedule
        /// for rotating your secret. Secrets Manager rotation schedules use UTC time zone. 
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager <code>rate()</code> expressions represent the interval in days that
        /// you want to rotate your secret, for example <code>rate(10 days)</code>. If you use
        /// a <code>rate()</code> expression, the rotation window opens at midnight, and Secrets
        /// Manager rotates your secret any time that day after midnight. You can set a <code>Duration</code>
        /// to shorten the rotation window.
        /// </para>
        ///  
        /// <para>
        /// You can use a <code>cron()</code> expression to create rotation schedules that are
        /// more detailed than a rotation interval. For more information, including examples,
        /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/rotate-secrets_schedule.html">Schedule
        /// expressions in Secrets Manager rotation</a>. If you use a <code>cron()</code> expression,
        /// Secrets Manager rotates your secret any time during that day after the window opens.
        /// For example, <code>cron(0 8 1 * ? *)</code> represents a rotation window that occurs
        /// on the first day of every month beginning at 8:00 AM UTC. Secrets Manager rotates
        /// the secret any time that day after 8:00 AM. You can set a <code>Duration</code> to
        /// shorten the rotation window.
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
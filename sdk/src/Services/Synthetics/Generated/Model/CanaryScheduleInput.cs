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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
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
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// This structure specifies how often a canary is to make runs and the date and time
    /// when it should stop making runs.
    /// </summary>
    public partial class CanaryScheduleInput
    {
        private long? _durationInSeconds;
        private string _expression;
        private RetryConfigInput _retryConfig;

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// How long, in seconds, for the canary to continue making regular runs according to
        /// the schedule in the <c>Expression</c> value. If you specify 0, the canary continues
        /// making runs until you stop it. If you omit this field, the default of 0 is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=31622400)]
        public long? DurationInSeconds
        {
            get { return this._durationInSeconds; }
            set { this._durationInSeconds = value; }
        }

        // Check to see if DurationInSeconds property is set
        internal bool IsSetDurationInSeconds()
        {
            return this._durationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// A <c>rate</c> expression or a <c>cron</c> expression that defines how often the canary
        /// is to run.
        /// </para>
        ///  
        /// <para>
        /// For a rate expression, The syntax is <c>rate(<i>number unit</i>)</c>. <i>unit</i>
        /// can be <c>minute</c>, <c>minutes</c>, or <c>hour</c>. 
        /// </para>
        ///  
        /// <para>
        /// For example, <c>rate(1 minute)</c> runs the canary once a minute, <c>rate(10 minutes)</c>
        /// runs it once every 10 minutes, and <c>rate(1 hour)</c> runs it once every hour. You
        /// can specify a frequency between <c>rate(1 minute)</c> and <c>rate(1 hour)</c>.
        /// </para>
        ///  
        /// <para>
        /// Specifying <c>rate(0 minute)</c> or <c>rate(0 hour)</c> is a special value that causes
        /// the canary to run only once when it is started.
        /// </para>
        ///  
        /// <para>
        /// Use <c>cron(<i>expression</i>)</c> to specify a cron expression. You can't schedule
        /// a canary to wait for more than a year before running. For information about the syntax
        /// for cron expressions, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_cron.html">
        /// Scheduling canary runs using cron</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property RetryConfig. 
        /// <para>
        /// A structure that contains the retry configuration for a canary
        /// </para>
        /// </summary>
        public RetryConfigInput RetryConfig
        {
            get { return this._retryConfig; }
            set { this._retryConfig = value; }
        }

        // Check to see if RetryConfig property is set
        internal bool IsSetRetryConfig()
        {
            return this._retryConfig != null;
        }

    }
}
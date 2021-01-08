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

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// How long, in seconds, for the canary to continue making regular runs according to
        /// the schedule in the <code>Expression</code> value. If you specify 0, the canary continues
        /// making runs until you stop it. If you omit this field, the default of 0 is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=31622400)]
        public long DurationInSeconds
        {
            get { return this._durationInSeconds.GetValueOrDefault(); }
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
        /// A rate expression that defines how often the canary is to run. The syntax is <code>rate(<i>number
        /// unit</i>)</code>. <i>unit</i> can be <code>minute</code>, <code>minutes</code>, or
        /// <code>hour</code>. 
        /// </para>
        ///  
        /// <para>
        /// For example, <code>rate(1 minute)</code> runs the canary once a minute, <code>rate(10
        /// minutes)</code> runs it once every 10 minutes, and <code>rate(1 hour)</code> runs
        /// it once every hour. You can specify a frequency between <code>rate(1 minute)</code>
        /// and <code>rate(1 hour)</code>.
        /// </para>
        ///  
        /// <para>
        /// Specifying <code>rate(0 minute)</code> or <code>rate(0 hour)</code> is a special value
        /// that causes the canary to run only once when it is started.
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

    }
}
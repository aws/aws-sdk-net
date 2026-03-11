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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// Enable temporary sampling rate increases when you detect anomalies to improve visibility.
    /// </summary>
    public partial class SamplingRateBoost
    {
        private int? _cooldownWindowMinutes;
        private double? _maxRate;

        /// <summary>
        /// Gets and sets the property CooldownWindowMinutes. 
        /// <para>
        /// Sets the time window (in minutes) in which only one sampling rate boost can be triggered.
        /// After a boost occurs, no further boosts are allowed until the next window.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? CooldownWindowMinutes
        {
            get { return this._cooldownWindowMinutes; }
            set { this._cooldownWindowMinutes = value; }
        }

        // Check to see if CooldownWindowMinutes property is set
        internal bool IsSetCooldownWindowMinutes()
        {
            return this._cooldownWindowMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRate. 
        /// <para>
        /// Defines max temporary sampling rate to apply when a boost is triggered. Calculated
        /// boost rate by X-Ray will be less than or equal to this max rate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public double? MaxRate
        {
            get { return this._maxRate; }
            set { this._maxRate = value; }
        }

        // Check to see if MaxRate property is set
        internal bool IsSetMaxRate()
        {
            return this._maxRate.HasValue; 
        }

    }
}
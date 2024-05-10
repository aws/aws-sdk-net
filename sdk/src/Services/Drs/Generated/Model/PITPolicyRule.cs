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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// A rule in the Point in Time (PIT) policy representing when to take snapshots and how
    /// long to retain them for.
    /// </summary>
    public partial class PITPolicyRule
    {
        private bool? _enabled;
        private int? _interval;
        private int? _retentionDuration;
        private long? _ruleid;
        private PITPolicyRuleUnits _units;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether this rule is enabled or not.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// How often, in the chosen units, a snapshot should be taken.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this._interval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetentionDuration. 
        /// <para>
        /// The duration to retain a snapshot for, in the chosen units.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? RetentionDuration
        {
            get { return this._retentionDuration; }
            set { this._retentionDuration = value; }
        }

        // Check to see if RetentionDuration property is set
        internal bool IsSetRetentionDuration()
        {
            return this._retentionDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleID. 
        /// <para>
        /// The ID of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? RuleID
        {
            get { return this._ruleid; }
            set { this._ruleid = value; }
        }

        // Check to see if RuleID property is set
        internal bool IsSetRuleID()
        {
            return this._ruleid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Units. 
        /// <para>
        /// The units used to measure the interval and retentionDuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PITPolicyRuleUnits Units
        {
            get { return this._units; }
            set { this._units = value; }
        }

        // Check to see if Units property is set
        internal bool IsSetUnits()
        {
            return this._units != null;
        }

    }
}
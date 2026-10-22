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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// A rule in the Point in Time (PIT) policy representing when to take snapshots and how
    /// long to retain them for.
    /// </summary>
    public partial class PITPolicyRule
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether this rule is enabled or not.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// How often, in the chosen units, a snapshot should be taken.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? Interval { get; set; }

        /// <summary>
        /// Checks to see if the Interval property is set.
        /// </summary>
        internal bool IsSetInterval() => this.Interval.HasValue;

        /// <summary>
        /// Gets and sets the property RetentionDuration. 
        /// <para>
        /// The duration to retain a snapshot for, in the chosen units.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? RetentionDuration { get; set; }

        /// <summary>
        /// Checks to see if the RetentionDuration property is set.
        /// </summary>
        internal bool IsSetRetentionDuration() => this.RetentionDuration.HasValue;

        /// <summary>
        /// Gets and sets the property RuleID. 
        /// <para>
        /// The ID of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? RuleID { get; set; }

        /// <summary>
        /// Checks to see if the RuleID property is set.
        /// </summary>
        internal bool IsSetRuleID() => this.RuleID.HasValue;

        /// <summary>
        /// Gets and sets the property Units. 
        /// <para>
        /// The units used to measure the interval and retentionDuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PITPolicyRuleUnits Units { get; set; }

        /// <summary>
        /// Checks to see if the Units property is set.
        /// </summary>
        internal bool IsSetUnits() => this.Units != null;
    }
}

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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
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
namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// The optional auto scaling settings for a table with provisioned throughput capacity.
    /// 
    ///  
    /// <para>
    /// To turn on auto scaling for a table in <c>throughputMode:PROVISIONED</c>, you must
    /// specify the following parameters. 
    /// </para>
    ///  
    /// <para>
    /// Configure the minimum and maximum capacity units. The auto scaling policy ensures
    /// that capacity never goes below the minimum or above the maximum range.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>minimumUnits</c>: The minimum level of throughput the table should always be ready
    /// to support. The value must be between 1 and the max throughput per second quota for
    /// your account (40,000 by default).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>maximumUnits</c>: The maximum level of throughput the table should always be ready
    /// to support. The value must be between 1 and the max throughput per second quota for
    /// your account (40,000 by default).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>scalingPolicy</c>: Amazon Keyspaces supports the <c>target tracking</c> scaling
    /// policy. The auto scaling target is the provisioned capacity of the table. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>targetTrackingScalingPolicyConfiguration</c>: To define the target tracking policy,
    /// you must define the target value. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>targetValue</c>: The target utilization rate of the table. Amazon Keyspaces auto
    /// scaling ensures that the ratio of consumed capacity to provisioned capacity stays
    /// at or near this value. You define <c>targetValue</c> as a percentage. A <c>double</c>
    /// between 20 and 90. (Required)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>disableScaleIn</c>: A <c>boolean</c> that specifies if <c>scale-in</c> is disabled
    /// or enabled for the table. This parameter is disabled by default. To turn on <c>scale-in</c>,
    /// set the <c>boolean</c> value to <c>FALSE</c>. This means that capacity for a table
    /// can be automatically scaled down on your behalf. (Optional) 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>scaleInCooldown</c>: A cooldown period in seconds between scaling activities that
    /// lets the table stabilize before another scale in activity starts. If no value is provided,
    /// the default is 0. (Optional) 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>scaleOutCooldown</c>: A cooldown period in seconds between scaling activities
    /// that lets the table stabilize before another scale out activity starts. If no value
    /// is provided, the default is 0. (Optional) 
    /// </para>
    ///  </li> </ul> </li> </ul> </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/autoscaling.html">Managing
    /// throughput capacity automatically with Amazon Keyspaces auto scaling</a> in the <i>Amazon
    /// Keyspaces Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class AutoScalingSettings
    {
        private bool? _autoScalingDisabled;
        private long? _maximumUnits;
        private long? _minimumUnits;
        private AutoScalingPolicy _scalingPolicy;

        /// <summary>
        /// Gets and sets the property AutoScalingDisabled. 
        /// <para>
        /// This optional parameter enables auto scaling for the table if set to <c>false</c>.
        /// </para>
        /// </summary>
        public bool? AutoScalingDisabled
        {
            get { return this._autoScalingDisabled; }
            set { this._autoScalingDisabled = value; }
        }

        // Check to see if AutoScalingDisabled property is set
        internal bool IsSetAutoScalingDisabled()
        {
            return this._autoScalingDisabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumUnits. 
        /// <para>
        /// Manage costs by specifying the maximum amount of throughput to provision. The value
        /// must be between 1 and the max throughput per second quota for your account (40,000
        /// by default).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? MaximumUnits
        {
            get { return this._maximumUnits; }
            set { this._maximumUnits = value; }
        }

        // Check to see if MaximumUnits property is set
        internal bool IsSetMaximumUnits()
        {
            return this._maximumUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumUnits. 
        /// <para>
        /// The minimum level of throughput the table should always be ready to support. The value
        /// must be between 1 and the max throughput per second quota for your account (40,000
        /// by default).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? MinimumUnits
        {
            get { return this._minimumUnits; }
            set { this._minimumUnits = value; }
        }

        // Check to see if MinimumUnits property is set
        internal bool IsSetMinimumUnits()
        {
            return this._minimumUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScalingPolicy. 
        /// <para>
        /// Amazon Keyspaces supports the <c>target tracking</c> auto scaling policy. With this
        /// policy, Amazon Keyspaces auto scaling ensures that the table's ratio of consumed to
        /// provisioned capacity stays at or near the target value that you specify. You define
        /// the target value as a percentage between 20 and 90.
        /// </para>
        /// </summary>
        public AutoScalingPolicy ScalingPolicy
        {
            get { return this._scalingPolicy; }
            set { this._scalingPolicy = value; }
        }

        // Check to see if ScalingPolicy property is set
        internal bool IsSetScalingPolicy()
        {
            return this._scalingPolicy != null;
        }

    }
}
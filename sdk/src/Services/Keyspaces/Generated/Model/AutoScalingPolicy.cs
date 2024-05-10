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
    /// Amazon Keyspaces supports the <c>target tracking</c> auto scaling policy. With this
    /// policy, Amazon Keyspaces auto scaling ensures that the table's ratio of consumed to
    /// provisioned capacity stays at or near the target value that you specify. You define
    /// the target value as a percentage between 20 and 90.
    /// </summary>
    public partial class AutoScalingPolicy
    {
        private TargetTrackingScalingPolicyConfiguration _targetTrackingScalingPolicyConfiguration;

        /// <summary>
        /// Gets and sets the property TargetTrackingScalingPolicyConfiguration. 
        /// <para>
        /// Auto scaling scales up capacity automatically when traffic exceeds this target utilization
        /// rate, and then back down when it falls below the target. A <c>double</c> between 20
        /// and 90.
        /// </para>
        /// </summary>
        public TargetTrackingScalingPolicyConfiguration TargetTrackingScalingPolicyConfiguration
        {
            get { return this._targetTrackingScalingPolicyConfiguration; }
            set { this._targetTrackingScalingPolicyConfiguration = value; }
        }

        // Check to see if TargetTrackingScalingPolicyConfiguration property is set
        internal bool IsSetTargetTrackingScalingPolicyConfiguration()
        {
            return this._targetTrackingScalingPolicyConfiguration != null;
        }

    }
}
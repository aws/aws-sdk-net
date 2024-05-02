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
    /// The auto scaling policy that scales a table based on the ratio of consumed to provisioned
    /// capacity.
    /// </summary>
    public partial class TargetTrackingScalingPolicyConfiguration
    {
        private bool? _disableScaleIn;
        private int? _scaleInCooldown;
        private int? _scaleOutCooldown;
        private double? _targetValue;

        /// <summary>
        /// Gets and sets the property DisableScaleIn. 
        /// <para>
        /// Specifies if <c>scale-in</c> is enabled.
        /// </para>
        ///  
        /// <para>
        /// When auto scaling automatically decreases capacity for a table, the table <i>scales
        /// in</i>. When scaling policies are set, they can't scale in the table lower than its
        /// minimum capacity.
        /// </para>
        /// </summary>
        public bool? DisableScaleIn
        {
            get { return this._disableScaleIn; }
            set { this._disableScaleIn = value; }
        }

        // Check to see if DisableScaleIn property is set
        internal bool IsSetDisableScaleIn()
        {
            return this._disableScaleIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScaleInCooldown. 
        /// <para>
        /// Specifies a <c>scale-in</c> cool down period.
        /// </para>
        ///  
        /// <para>
        /// A cooldown period in seconds between scaling activities that lets the table stabilize
        /// before another scaling activity starts. 
        /// </para>
        /// </summary>
        public int? ScaleInCooldown
        {
            get { return this._scaleInCooldown; }
            set { this._scaleInCooldown = value; }
        }

        // Check to see if ScaleInCooldown property is set
        internal bool IsSetScaleInCooldown()
        {
            return this._scaleInCooldown.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScaleOutCooldown. 
        /// <para>
        /// Specifies a scale out cool down period.
        /// </para>
        ///  
        /// <para>
        /// A cooldown period in seconds between scaling activities that lets the table stabilize
        /// before another scaling activity starts. 
        /// </para>
        /// </summary>
        public int? ScaleOutCooldown
        {
            get { return this._scaleOutCooldown; }
            set { this._scaleOutCooldown = value; }
        }

        // Check to see if ScaleOutCooldown property is set
        internal bool IsSetScaleOutCooldown()
        {
            return this._scaleOutCooldown.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetValue. 
        /// <para>
        /// Specifies the target value for the target tracking auto scaling policy.
        /// </para>
        ///  
        /// <para>
        /// Amazon Keyspaces auto scaling scales up capacity automatically when traffic exceeds
        /// this target utilization rate, and then back down when it falls below the target. This
        /// ensures that the ratio of consumed capacity to provisioned capacity stays at or near
        /// this value. You define <c>targetValue</c> as a percentage. A <c>double</c> between
        /// 20 and 90.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? TargetValue
        {
            get { return this._targetValue; }
            set { this._targetValue = value; }
        }

        // Check to see if TargetValue property is set
        internal bool IsSetTargetValue()
        {
            return this._targetValue.HasValue; 
        }

    }
}
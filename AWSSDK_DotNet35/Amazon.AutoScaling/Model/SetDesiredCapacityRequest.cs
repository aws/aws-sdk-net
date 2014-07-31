/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the SetDesiredCapacity operation.
    /// Sets the desired size of the specified <a>AutoScalingGroup</a>.
    /// </summary>
    public partial class SetDesiredCapacityRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private int? _desiredCapacity;
        private bool? _honorCooldown;


        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        ///  The name of the Auto Scaling group. 
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property DesiredCapacity. 
        /// <para>
        ///  The new capacity setting for the Auto Scaling group. 
        /// </para>
        /// </summary>
        public int DesiredCapacity
        {
            get { return this._desiredCapacity.GetValueOrDefault(); }
            set { this._desiredCapacity = value; }
        }

        // Check to see if DesiredCapacity property is set
        internal bool IsSetDesiredCapacity()
        {
            return this._desiredCapacity.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property HonorCooldown. 
        /// <para>
        ///  By default, <code>SetDesiredCapacity</code> overrides any cooldown period associated
        /// with the Auto Scaling group. Set to <code>True</code> if you want Auto Scaling to
        /// wait for the cooldown period associated with the Auto Scaling group to complete before
        /// initiating a scaling activity to set your Auto Scaling group to the new capacity setting.
        /// 
        /// </para>
        /// </summary>
        public bool HonorCooldown
        {
            get { return this._honorCooldown.GetValueOrDefault(); }
            set { this._honorCooldown = value; }
        }

        // Check to see if HonorCooldown property is set
        internal bool IsSetHonorCooldown()
        {
            return this._honorCooldown.HasValue; 
        }

    }
}
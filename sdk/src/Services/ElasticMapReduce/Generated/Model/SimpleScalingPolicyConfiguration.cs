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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// An automatic scaling configuration, which describes how the policy adds or removes
    /// instances, the cooldown period, and the number of Amazon EC2 instances that will be
    /// added each time the CloudWatch metric alarm condition is satisfied.
    /// </summary>
    public partial class SimpleScalingPolicyConfiguration
    {
        private AdjustmentType _adjustmentType;
        private int? _coolDown;
        private int? _scalingAdjustment;

        /// <summary>
        /// Gets and sets the property AdjustmentType. 
        /// <para>
        /// The way in which Amazon EC2 instances are added (if <c>ScalingAdjustment</c> is a
        /// positive number) or terminated (if <c>ScalingAdjustment</c> is a negative number)
        /// each time the scaling activity is triggered. <c>CHANGE_IN_CAPACITY</c> is the default.
        /// <c>CHANGE_IN_CAPACITY</c> indicates that the Amazon EC2 instance count increments
        /// or decrements by <c>ScalingAdjustment</c>, which should be expressed as an integer.
        /// <c>PERCENT_CHANGE_IN_CAPACITY</c> indicates the instance count increments or decrements
        /// by the percentage specified by <c>ScalingAdjustment</c>, which should be expressed
        /// as an integer. For example, 20 indicates an increase in 20% increments of cluster
        /// capacity. <c>EXACT_CAPACITY</c> indicates the scaling activity results in an instance
        /// group with the number of Amazon EC2 instances specified by <c>ScalingAdjustment</c>,
        /// which should be expressed as a positive integer.
        /// </para>
        /// </summary>
        public AdjustmentType AdjustmentType
        {
            get { return this._adjustmentType; }
            set { this._adjustmentType = value; }
        }

        // Check to see if AdjustmentType property is set
        internal bool IsSetAdjustmentType()
        {
            return this._adjustmentType != null;
        }

        /// <summary>
        /// Gets and sets the property CoolDown. 
        /// <para>
        /// The amount of time, in seconds, after a scaling activity completes before any further
        /// trigger-related scaling activities can start. The default value is 0.
        /// </para>
        /// </summary>
        public int? CoolDown
        {
            get { return this._coolDown; }
            set { this._coolDown = value; }
        }

        // Check to see if CoolDown property is set
        internal bool IsSetCoolDown()
        {
            return this._coolDown.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScalingAdjustment. 
        /// <para>
        /// The amount by which to scale in or scale out, based on the specified <c>AdjustmentType</c>.
        /// A positive value adds to the instance group's Amazon EC2 instance count while a negative
        /// number removes instances. If <c>AdjustmentType</c> is set to <c>EXACT_CAPACITY</c>,
        /// the number should only be a positive integer. If <c>AdjustmentType</c> is set to <c>PERCENT_CHANGE_IN_CAPACITY</c>,
        /// the value should express the percentage as an integer. For example, -20 indicates
        /// a decrease in 20% increments of cluster capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ScalingAdjustment
        {
            get { return this._scalingAdjustment; }
            set { this._scalingAdjustment = value; }
        }

        // Check to see if ScalingAdjustment property is set
        internal bool IsSetScalingAdjustment()
        {
            return this._scalingAdjustment.HasValue; 
        }

    }
}
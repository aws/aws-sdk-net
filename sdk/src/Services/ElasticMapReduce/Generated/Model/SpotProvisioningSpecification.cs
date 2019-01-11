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

/*
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The launch specification for Spot instances in the instance fleet, which determines
    /// the defined duration and provisioning timeout behavior.
    /// 
    ///  <note> 
    /// <para>
    /// The instance fleet configuration is available only in Amazon EMR versions 4.8.0 and
    /// later, excluding 5.0.x versions.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SpotProvisioningSpecification
    {
        private int? _blockDurationMinutes;
        private SpotProvisioningTimeoutAction _timeoutAction;
        private int? _timeoutDurationMinutes;

        /// <summary>
        /// Gets and sets the property BlockDurationMinutes. 
        /// <para>
        /// The defined duration for Spot instances (also known as Spot blocks) in minutes. When
        /// specified, the Spot instance does not terminate before the defined duration expires,
        /// and defined duration pricing for Spot instances applies. Valid values are 60, 120,
        /// 180, 240, 300, or 360. The duration period starts as soon as a Spot instance receives
        /// its instance ID. At the end of the duration, Amazon EC2 marks the Spot instance for
        /// termination and provides a Spot instance termination notice, which gives the instance
        /// a two-minute warning before it terminates. 
        /// </para>
        /// </summary>
        public int BlockDurationMinutes
        {
            get { return this._blockDurationMinutes.GetValueOrDefault(); }
            set { this._blockDurationMinutes = value; }
        }

        // Check to see if BlockDurationMinutes property is set
        internal bool IsSetBlockDurationMinutes()
        {
            return this._blockDurationMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutAction. 
        /// <para>
        /// The action to take when <code>TargetSpotCapacity</code> has not been fulfilled when
        /// the <code>TimeoutDurationMinutes</code> has expired; that is, when all Spot instances
        /// could not be provisioned within the Spot provisioning timeout. Valid values are <code>TERMINATE_CLUSTER</code>
        /// and <code>SWITCH_TO_ON_DEMAND</code>. SWITCH_TO_ON_DEMAND specifies that if no Spot
        /// instances are available, On-Demand Instances should be provisioned to fulfill any
        /// remaining Spot capacity.
        /// </para>
        /// </summary>
        public SpotProvisioningTimeoutAction TimeoutAction
        {
            get { return this._timeoutAction; }
            set { this._timeoutAction = value; }
        }

        // Check to see if TimeoutAction property is set
        internal bool IsSetTimeoutAction()
        {
            return this._timeoutAction != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutDurationMinutes. 
        /// <para>
        /// The spot provisioning timeout period in minutes. If Spot instances are not provisioned
        /// within this time period, the <code>TimeOutAction</code> is taken. Minimum value is
        /// 5 and maximum value is 1440. The timeout applies only during initial provisioning,
        /// when the cluster is first created.
        /// </para>
        /// </summary>
        public int TimeoutDurationMinutes
        {
            get { return this._timeoutDurationMinutes.GetValueOrDefault(); }
            set { this._timeoutDurationMinutes = value; }
        }

        // Check to see if TimeoutDurationMinutes property is set
        internal bool IsSetTimeoutDurationMinutes()
        {
            return this._timeoutDurationMinutes.HasValue; 
        }

    }
}
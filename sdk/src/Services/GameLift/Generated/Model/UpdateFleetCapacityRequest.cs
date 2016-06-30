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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFleetCapacity operation.
    /// Updates capacity settings for a fleet. Use this action to specify the number of EC2
    /// instances (hosts) that you want this fleet to contain. Before calling this action,
    /// you may want to call <a>DescribeEC2InstanceLimits</a> to get the maximum capacity
    /// based on the fleet's EC2 instance type.
    /// 
    ///  
    /// <para>
    /// If you're using autoscaling (see <a>PutScalingPolicy</a>), you may want to specify
    /// a minimum and/or maximum capacity. If you don't provide these, autoscaling can set
    /// capacity anywhere between zero and the <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_gamelift">service
    /// limits</a>.
    /// </para>
    ///  
    /// <para>
    /// To update fleet capacity, specify the fleet ID and the number of instances you want
    /// the fleet to host. If successful, Amazon GameLift starts or terminates instances so
    /// that the fleet's active instance count matches the desired instance count. You can
    /// view a fleet's current capacity information by calling <a>DescribeFleetCapacity</a>.
    /// If the desired instance count is higher than the instance type's limit, the "Limit
    /// Exceeded" exception occurs.
    /// </para>
    /// </summary>
    public partial class UpdateFleetCapacityRequest : AmazonGameLiftRequest
    {
        private int? _desiredInstances;
        private string _fleetId;
        private int? _maxSize;
        private int? _minSize;

        /// <summary>
        /// Gets and sets the property DesiredInstances. 
        /// <para>
        /// Number of EC2 instances you want this fleet to host.
        /// </para>
        /// </summary>
        public int DesiredInstances
        {
            get { return this._desiredInstances.GetValueOrDefault(); }
            set { this._desiredInstances = value; }
        }

        // Check to see if DesiredInstances property is set
        internal bool IsSetDesiredInstances()
        {
            return this._desiredInstances.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier for the fleet you want to update capacity for. 
        /// </para>
        /// </summary>
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxSize. 
        /// <para>
        /// Maximum value allowed for the fleet's instance count. Default if not set is 1.
        /// </para>
        /// </summary>
        public int MaxSize
        {
            get { return this._maxSize.GetValueOrDefault(); }
            set { this._maxSize = value; }
        }

        // Check to see if MaxSize property is set
        internal bool IsSetMaxSize()
        {
            return this._maxSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinSize. 
        /// <para>
        /// Minimum value allowed for the fleet's instance count. Default if not set is 0.
        /// </para>
        /// </summary>
        public int MinSize
        {
            get { return this._minSize.GetValueOrDefault(); }
            set { this._minSize = value; }
        }

        // Check to see if MinSize property is set
        internal bool IsSetMinSize()
        {
            return this._minSize.HasValue; 
        }

    }
}
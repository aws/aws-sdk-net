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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// The scaling configuration output of a compute fleet.
    /// </summary>
    public partial class ScalingConfigurationOutput
    {
        private int? _desiredCapacity;
        private int? _maxCapacity;
        private FleetScalingType _scalingType;
        private List<TargetTrackingScalingConfiguration> _targetTrackingScalingConfigs = AWSConfigs.InitializeCollections ? new List<TargetTrackingScalingConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property DesiredCapacity. 
        /// <para>
        /// The desired number of instances in the ﬂeet when auto-scaling.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The maximum number of instances in the ﬂeet when auto-scaling.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxCapacity
        {
            get { return this._maxCapacity.GetValueOrDefault(); }
            set { this._maxCapacity = value; }
        }

        // Check to see if MaxCapacity property is set
        internal bool IsSetMaxCapacity()
        {
            return this._maxCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScalingType. 
        /// <para>
        /// The scaling type for a compute fleet.
        /// </para>
        /// </summary>
        public FleetScalingType ScalingType
        {
            get { return this._scalingType; }
            set { this._scalingType = value; }
        }

        // Check to see if ScalingType property is set
        internal bool IsSetScalingType()
        {
            return this._scalingType != null;
        }

        /// <summary>
        /// Gets and sets the property TargetTrackingScalingConfigs. 
        /// <para>
        /// A list of <c>TargetTrackingScalingConfiguration</c> objects.
        /// </para>
        /// </summary>
        public List<TargetTrackingScalingConfiguration> TargetTrackingScalingConfigs
        {
            get { return this._targetTrackingScalingConfigs; }
            set { this._targetTrackingScalingConfigs = value; }
        }

        // Check to see if TargetTrackingScalingConfigs property is set
        internal bool IsSetTargetTrackingScalingConfigs()
        {
            return this._targetTrackingScalingConfigs != null && (this._targetTrackingScalingConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
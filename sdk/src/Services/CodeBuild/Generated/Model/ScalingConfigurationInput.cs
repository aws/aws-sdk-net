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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// The scaling configuration input of a compute fleet.
    /// </summary>
    public partial class ScalingConfigurationInput
    {
        private int? _maxCapacity;
        private FleetScalingType _scalingType;
        private List<TargetTrackingScalingConfiguration> _targetTrackingScalingConfigs = AWSConfigs.InitializeCollections ? new List<TargetTrackingScalingConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The maximum number of instances in the ﬂeet when auto-scaling.
        /// </para>
        /// </summary>
        public int? MaxCapacity
        {
            get { return this._maxCapacity; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
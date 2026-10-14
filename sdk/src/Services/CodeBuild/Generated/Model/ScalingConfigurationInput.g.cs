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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// The scaling configuration input of a compute fleet.
    /// </summary>
    public partial class ScalingConfigurationInput
    {
        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The maximum number of instances in the ﬂeet when auto-scaling.
        /// </para>
        /// </summary>
        public int? MaxCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MaxCapacity property is set.
        /// </summary>
        internal bool IsSetMaxCapacity() => this.MaxCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property ScalingType. 
        /// <para>
        /// The scaling type for a compute fleet.
        /// </para>
        /// </summary>
        public FleetScalingType ScalingType { get; set; }

        /// <summary>
        /// Checks to see if the ScalingType property is set.
        /// </summary>
        internal bool IsSetScalingType() => this.ScalingType != null;

        /// <summary>
        /// Gets and sets the property TargetTrackingScalingConfigs. 
        /// <para>
        /// A list of <c>TargetTrackingScalingConfiguration</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TargetTrackingScalingConfiguration> TargetTrackingScalingConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<TargetTrackingScalingConfiguration>() : null;

        /// <summary>
        /// Checks to see if the TargetTrackingScalingConfigs property is set.
        /// </summary>
        internal bool IsSetTargetTrackingScalingConfigs() => this.TargetTrackingScalingConfigs != null && (this.TargetTrackingScalingConfigs.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

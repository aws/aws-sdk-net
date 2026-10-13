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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// An object with the recommended values for you to specify when creating an autoscaling
    /// policy.
    /// </summary>
    public partial class DynamicScalingConfiguration
    {
        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The recommended maximum capacity to specify for your autoscaling policy.
        /// </para>
        /// </summary>
        public int? MaxCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MaxCapacity property is set.
        /// </summary>
        internal bool IsSetMaxCapacity() => this.MaxCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property MinCapacity. 
        /// <para>
        /// The recommended minimum capacity to specify for your autoscaling policy.
        /// </para>
        /// </summary>
        public int? MinCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MinCapacity property is set.
        /// </summary>
        internal bool IsSetMinCapacity() => this.MinCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property ScaleInCooldown. 
        /// <para>
        /// The recommended scale in cooldown time for your autoscaling policy.
        /// </para>
        /// </summary>
        public int? ScaleInCooldown { get; set; }

        /// <summary>
        /// Checks to see if the ScaleInCooldown property is set.
        /// </summary>
        internal bool IsSetScaleInCooldown() => this.ScaleInCooldown.HasValue;

        /// <summary>
        /// Gets and sets the property ScaleOutCooldown. 
        /// <para>
        /// The recommended scale out cooldown time for your autoscaling policy.
        /// </para>
        /// </summary>
        public int? ScaleOutCooldown { get; set; }

        /// <summary>
        /// Checks to see if the ScaleOutCooldown property is set.
        /// </summary>
        internal bool IsSetScaleOutCooldown() => this.ScaleOutCooldown.HasValue;

        /// <summary>
        /// Gets and sets the property ScalingPolicies. 
        /// <para>
        /// An object of the scaling policies for each metric.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ScalingPolicy> ScalingPolicies { get; set; } = AWSConfigs.InitializeCollections ? new List<ScalingPolicy>() : null;

        /// <summary>
        /// Checks to see if the ScalingPolicies property is set.
        /// </summary>
        internal bool IsSetScalingPolicies() => this.ScalingPolicies != null && (this.ScalingPolicies.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

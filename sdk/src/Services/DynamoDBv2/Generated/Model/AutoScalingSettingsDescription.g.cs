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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents the auto scaling settings for a global table or global secondary index.
    /// </summary>
    public partial class AutoScalingSettingsDescription
    {
        /// <summary>
        /// Gets and sets the property AutoScalingDisabled. 
        /// <para>
        /// Disabled auto scaling for this global table or global secondary index.
        /// </para>
        /// </summary>
        public bool? AutoScalingDisabled { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingDisabled property is set.
        /// </summary>
        internal bool IsSetAutoScalingDisabled() => this.AutoScalingDisabled.HasValue;

        /// <summary>
        /// Gets and sets the property AutoScalingRoleArn. 
        /// <para>
        /// Role ARN used for configuring the auto scaling policy.
        /// </para>
        /// </summary>
        public string AutoScalingRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingRoleArn property is set.
        /// </summary>
        internal bool IsSetAutoScalingRoleArn() => this.AutoScalingRoleArn != null;

        /// <summary>
        /// Gets and sets the property MaximumUnits. 
        /// <para>
        /// The maximum capacity units that a global table or global secondary index should be
        /// scaled up to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? MaximumUnits { get; set; }

        /// <summary>
        /// Checks to see if the MaximumUnits property is set.
        /// </summary>
        internal bool IsSetMaximumUnits() => this.MaximumUnits.HasValue;

        /// <summary>
        /// Gets and sets the property MinimumUnits. 
        /// <para>
        /// The minimum capacity units that a global table or global secondary index should be
        /// scaled down to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? MinimumUnits { get; set; }

        /// <summary>
        /// Checks to see if the MinimumUnits property is set.
        /// </summary>
        internal bool IsSetMinimumUnits() => this.MinimumUnits.HasValue;

        /// <summary>
        /// Gets and sets the property ScalingPolicies. 
        /// <para>
        /// Information about the scaling policies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutoScalingPolicyDescription> ScalingPolicies { get; set; } = AWSConfigs.InitializeCollections ? new List<AutoScalingPolicyDescription>() : null;

        /// <summary>
        /// Checks to see if the ScalingPolicies property is set.
        /// </summary>
        internal bool IsSetScalingPolicies() => this.ScalingPolicies != null && (this.ScalingPolicies.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

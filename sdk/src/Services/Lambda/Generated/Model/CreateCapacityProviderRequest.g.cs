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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCapacityProvider operation. Creates a capacity
    /// provider that manages compute resources for Lambda Event Functions
    /// </summary>
    public partial class CreateCapacityProviderRequest : AmazonLambdaRequest
    {
        /// <summary>
        /// Gets and sets the property CapacityProviderName. 
        /// <para>
        /// The name of the capacity provider. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string CapacityProviderName { get; set; }

        /// <summary>
        /// Checks to see if the CapacityProviderName property is set.
        /// </summary>
        internal bool IsSetCapacityProviderName() => this.CapacityProviderName != null;

        /// <summary>
        /// Gets and sets the property CapacityProviderScalingConfig. 
        /// <para>
        /// The scaling configuration that defines how the capacity provider scales compute instances,
        /// including maximum vCPU count and scaling policies.
        /// </para>
        /// </summary>
        public CapacityProviderScalingConfig CapacityProviderScalingConfig { get; set; }

        /// <summary>
        /// Checks to see if the CapacityProviderScalingConfig property is set.
        /// </summary>
        internal bool IsSetCapacityProviderScalingConfig() => this.CapacityProviderScalingConfig != null;

        /// <summary>
        /// Gets and sets the property InstanceRequirements. 
        /// <para>
        /// The instance requirements that specify the compute instance characteristics, including
        /// architectures and allowed or excluded instance types.
        /// </para>
        /// </summary>
        public InstanceRequirements InstanceRequirements { get; set; }

        /// <summary>
        /// Checks to see if the InstanceRequirements property is set.
        /// </summary>
        internal bool IsSetInstanceRequirements() => this.InstanceRequirements != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the KMS key used to encrypt data associated with the capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property PermissionsConfig. 
        /// <para>
        /// The permissions configuration that specifies the IAM role ARN used by the capacity
        /// provider to manage compute resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CapacityProviderPermissionsConfig PermissionsConfig { get; set; }

        /// <summary>
        /// Checks to see if the PermissionsConfig property is set.
        /// </summary>
        internal bool IsSetPermissionsConfig() => this.PermissionsConfig != null;

        /// <summary>
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// The tag propagation configuration for the capacity provider. Specifies tags to apply
        /// to managed resources at launch.
        /// </para>
        /// </summary>
        public PropagateTags PropagateTags { get; set; }

        /// <summary>
        /// Checks to see if the PropagateTags property is set.
        /// </summary>
        internal bool IsSetPropagateTags() => this.PropagateTags != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to associate with the capacity provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TelemetryConfig. 
        /// <para>
        /// The telemetry configuration for the capacity provider. Specifies logging settings
        /// for managed resources.
        /// </para>
        /// </summary>
        public CapacityProviderTelemetryConfig TelemetryConfig { get; set; }

        /// <summary>
        /// Checks to see if the TelemetryConfig property is set.
        /// </summary>
        internal bool IsSetTelemetryConfig() => this.TelemetryConfig != null;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The VPC configuration for the capacity provider, including subnet IDs and security
        /// group IDs where compute instances will be launched.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CapacityProviderVpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}

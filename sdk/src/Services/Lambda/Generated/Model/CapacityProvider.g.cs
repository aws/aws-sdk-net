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
    /// A capacity provider manages compute resources for Lambda functions.
    /// </summary>
    public partial class CapacityProvider
    {
        /// <summary>
        /// Gets and sets the property CapacityProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string CapacityProviderArn { get; set; }

        /// <summary>
        /// Checks to see if the CapacityProviderArn property is set.
        /// </summary>
        internal bool IsSetCapacityProviderArn() => this.CapacityProviderArn != null;

        /// <summary>
        /// Gets and sets the property CapacityProviderScalingConfig. 
        /// <para>
        /// The scaling configuration for the capacity provider.
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
        /// The instance requirements for compute resources managed by the capacity provider.
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
        /// The ARN of the KMS key used to encrypt the capacity provider's resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time when the capacity provider was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified != null;

        /// <summary>
        /// Gets and sets the property PermissionsConfig. 
        /// <para>
        /// The permissions configuration for the capacity provider.
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
        /// </summary>
        public PropagateTags PropagateTags { get; set; }

        /// <summary>
        /// Checks to see if the PropagateTags property is set.
        /// </summary>
        internal bool IsSetPropagateTags() => this.PropagateTags != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CapacityProviderState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property TelemetryConfig. 
        /// <para>
        /// The telemetry configuration for the capacity provider, including logging settings.
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
        /// The VPC configuration for the capacity provider.
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

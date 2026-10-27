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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The parameters for launching Amazon EC2 instances in a capacity provider.
    /// </summary>
    public partial class LaunchParameters
    {
        /// <summary>
        /// Gets and sets the property CapacityReservationSpecification. 
        /// <para>
        /// The Capacity Reservation targeting option for the instances.
        /// </para>
        /// </summary>
        public CapacityReservationSpecification CapacityReservationSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationSpecification property is set.
        /// </summary>
        internal bool IsSetCapacityReservationSpecification() => this.CapacityReservationSpecification != null;

        /// <summary>
        /// Gets and sets the property EphemeralVolumes. 
        /// <para>
        /// The block device mappings for instance store (ephemeral) volumes. You can specify
        /// up to five mappings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public List<EphemeralBlockDeviceMapping> EphemeralVolumes { get; set; } = AWSConfigs.InitializeCollections ? new List<EphemeralBlockDeviceMapping>() : null;

        /// <summary>
        /// Checks to see if the EphemeralVolumes property is set.
        /// </summary>
        internal bool IsSetEphemeralVolumes() => this.EphemeralVolumes != null && (this.EphemeralVolumes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM instance profile to associate with launched
        /// instances. If provided, this overrides the default instance profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string InstanceProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceProfileArn property is set.
        /// </summary>
        internal bool IsSetInstanceProfileArn() => this.InstanceProfileArn != null;

        /// <summary>
        /// Gets and sets the property InstanceRequirements. 
        /// <para>
        /// The requirements that determine which instance types can be launched.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstanceRequirements InstanceRequirements { get; set; }

        /// <summary>
        /// Checks to see if the InstanceRequirements property is set.
        /// </summary>
        internal bool IsSetInstanceRequirements() => this.InstanceRequirements != null;

        /// <summary>
        /// Gets and sets the property LicenseSpecifications. 
        /// <para>
        /// The license configurations to associate with the instances. You can specify up to
        /// five configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public List<LicenseSpecification> LicenseSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<LicenseSpecification>() : null;

        /// <summary>
        /// Checks to see if the LicenseSpecifications property is set.
        /// </summary>
        internal bool IsSetLicenseSpecifications() => this.LicenseSpecifications != null && (this.LicenseSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Monitoring. 
        /// <para>
        /// The monitoring level for the instances.
        /// </para>
        /// </summary>
        public Monitoring Monitoring { get; set; }

        /// <summary>
        /// Checks to see if the Monitoring property is set.
        /// </summary>
        internal bool IsSetMonitoring() => this.Monitoring != null;

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// The operating system and CPU architecture for the instances.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OperatingSystem OperatingSystem { get; set; }

        /// <summary>
        /// Checks to see if the OperatingSystem property is set.
        /// </summary>
        internal bool IsSetOperatingSystem() => this.OperatingSystem != null;

        /// <summary>
        /// Gets and sets the property PropagatedTags. 
        /// <para>
        /// The tags to propagate to all Amazon EC2 resources (instances, volumes, and network
        /// interfaces) that the capacity provider creates.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> PropagatedTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the PropagatedTags property is set.
        /// </summary>
        internal bool IsSetPropagatedTags() => this.PropagatedTags != null && (this.PropagatedTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SshKeyName. 
        /// <para>
        /// The name of the SSH key pair to configure on the instances for SSH connectivity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SshKeyName { get; set; }

        /// <summary>
        /// Checks to see if the SshKeyName property is set.
        /// </summary>
        internal bool IsSetSshKeyName() => this.SshKeyName != null;
    }
}

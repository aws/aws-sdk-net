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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
        private CapacityReservationSpecification _capacityReservationSpecification;
        private List<EphemeralBlockDeviceMapping> _ephemeralVolumes = AWSConfigs.InitializeCollections ? new List<EphemeralBlockDeviceMapping>() : null;
        private string _instanceProfileArn;
        private InstanceRequirements _instanceRequirements;
        private List<LicenseSpecification> _licenseSpecifications = AWSConfigs.InitializeCollections ? new List<LicenseSpecification>() : null;
        private Monitoring _monitoring;
        private OperatingSystem _operatingSystem;
        private Dictionary<string, string> _propagatedTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _sshKeyName;

        /// <summary>
        /// Gets and sets the property CapacityReservationSpecification. 
        /// <para>
        /// The Capacity Reservation targeting option for the instances.
        /// </para>
        /// </summary>
        public CapacityReservationSpecification CapacityReservationSpecification
        {
            get { return this._capacityReservationSpecification; }
            set { this._capacityReservationSpecification = value; }
        }

        // Check to see if CapacityReservationSpecification property is set
        internal bool IsSetCapacityReservationSpecification()
        {
            return this._capacityReservationSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property EphemeralVolumes. 
        /// <para>
        /// The block device mappings for instance store (ephemeral) volumes. You can specify
        /// up to five mappings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<EphemeralBlockDeviceMapping> EphemeralVolumes
        {
            get { return this._ephemeralVolumes; }
            set { this._ephemeralVolumes = value; }
        }

        // Check to see if EphemeralVolumes property is set
        internal bool IsSetEphemeralVolumes()
        {
            return this._ephemeralVolumes != null && (this._ephemeralVolumes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM instance profile to associate with launched
        /// instances. If provided, this overrides the default instance profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string InstanceProfileArn
        {
            get { return this._instanceProfileArn; }
            set { this._instanceProfileArn = value; }
        }

        // Check to see if InstanceProfileArn property is set
        internal bool IsSetInstanceProfileArn()
        {
            return this._instanceProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceRequirements. 
        /// <para>
        /// The requirements that determine which instance types can be launched.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceRequirements InstanceRequirements
        {
            get { return this._instanceRequirements; }
            set { this._instanceRequirements = value; }
        }

        // Check to see if InstanceRequirements property is set
        internal bool IsSetInstanceRequirements()
        {
            return this._instanceRequirements != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseSpecifications. 
        /// <para>
        /// The license configurations to associate with the instances. You can specify up to
        /// five configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<LicenseSpecification> LicenseSpecifications
        {
            get { return this._licenseSpecifications; }
            set { this._licenseSpecifications = value; }
        }

        // Check to see if LicenseSpecifications property is set
        internal bool IsSetLicenseSpecifications()
        {
            return this._licenseSpecifications != null && (this._licenseSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Monitoring. 
        /// <para>
        /// The monitoring level for the instances.
        /// </para>
        /// </summary>
        public Monitoring Monitoring
        {
            get { return this._monitoring; }
            set { this._monitoring = value; }
        }

        // Check to see if Monitoring property is set
        internal bool IsSetMonitoring()
        {
            return this._monitoring != null;
        }

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// The operating system and CPU architecture for the instances.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OperatingSystem OperatingSystem
        {
            get { return this._operatingSystem; }
            set { this._operatingSystem = value; }
        }

        // Check to see if OperatingSystem property is set
        internal bool IsSetOperatingSystem()
        {
            return this._operatingSystem != null;
        }

        /// <summary>
        /// Gets and sets the property PropagatedTags. 
        /// <para>
        /// The tags to propagate to all Amazon EC2 resources (instances, volumes, and network
        /// interfaces) that the capacity provider creates.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> PropagatedTags
        {
            get { return this._propagatedTags; }
            set { this._propagatedTags = value; }
        }

        // Check to see if PropagatedTags property is set
        internal bool IsSetPropagatedTags()
        {
            return this._propagatedTags != null && (this._propagatedTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SshKeyName. 
        /// <para>
        /// The name of the SSH key pair to configure on the instances for SSH connectivity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SshKeyName
        {
            get { return this._sshKeyName; }
            set { this._sshKeyName = value; }
        }

        // Check to see if SshKeyName property is set
        internal bool IsSetSshKeyName()
        {
            return this._sshKeyName != null;
        }

    }
}
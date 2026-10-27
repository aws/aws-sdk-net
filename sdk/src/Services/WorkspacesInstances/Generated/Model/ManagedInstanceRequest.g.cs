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

namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// Defines comprehensive configuration for a managed WorkSpace Instance.
    /// </summary>
    public partial class ManagedInstanceRequest
    {
        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// Configures block device mappings for storage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BlockDeviceMappingRequest> BlockDeviceMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<BlockDeviceMappingRequest>() : null;

        /// <summary>
        /// Checks to see if the BlockDeviceMappings property is set.
        /// </summary>
        internal bool IsSetBlockDeviceMappings() => this.BlockDeviceMappings != null && (this.BlockDeviceMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CapacityReservationSpecification. 
        /// <para>
        /// Specifies capacity reservation preferences.
        /// </para>
        /// </summary>
        public CapacityReservationSpecification CapacityReservationSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationSpecification property is set.
        /// </summary>
        internal bool IsSetCapacityReservationSpecification() => this.CapacityReservationSpecification != null;

        /// <summary>
        /// Gets and sets the property CpuOptions. 
        /// <para>
        /// Configures CPU-specific settings.
        /// </para>
        /// </summary>
        public CpuOptionsRequest CpuOptions { get; set; }

        /// <summary>
        /// Checks to see if the CpuOptions property is set.
        /// </summary>
        internal bool IsSetCpuOptions() => this.CpuOptions != null;

        /// <summary>
        /// Gets and sets the property CreditSpecification. 
        /// <para>
        /// Defines CPU credit configuration for burstable instances.
        /// </para>
        /// </summary>
        public CreditSpecificationRequest CreditSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CreditSpecification property is set.
        /// </summary>
        internal bool IsSetCreditSpecification() => this.CreditSpecification != null;

        /// <summary>
        /// Gets and sets the property DisableApiStop. 
        /// <para>
        /// Prevents API-initiated instance stop.
        /// </para>
        /// </summary>
        public bool? DisableApiStop { get; set; }

        /// <summary>
        /// Checks to see if the DisableApiStop property is set.
        /// </summary>
        internal bool IsSetDisableApiStop() => this.DisableApiStop.HasValue;

        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Enables optimized EBS performance.
        /// </para>
        /// </summary>
        public bool? EbsOptimized { get; set; }

        /// <summary>
        /// Checks to see if the EbsOptimized property is set.
        /// </summary>
        internal bool IsSetEbsOptimized() => this.EbsOptimized.HasValue;

        /// <summary>
        /// Gets and sets the property EnablePrimaryIpv6. 
        /// <para>
        /// Enables primary IPv6 address configuration.
        /// </para>
        /// </summary>
        public bool? EnablePrimaryIpv6 { get; set; }

        /// <summary>
        /// Checks to see if the EnablePrimaryIpv6 property is set.
        /// </summary>
        internal bool IsSetEnablePrimaryIpv6() => this.EnablePrimaryIpv6.HasValue;

        /// <summary>
        /// Gets and sets the property EnclaveOptions. 
        /// <para>
        /// Configures AWS Nitro Enclave settings.
        /// </para>
        /// </summary>
        public EnclaveOptionsRequest EnclaveOptions { get; set; }

        /// <summary>
        /// Checks to see if the EnclaveOptions property is set.
        /// </summary>
        internal bool IsSetEnclaveOptions() => this.EnclaveOptions != null;

        /// <summary>
        /// Gets and sets the property HibernationOptions. 
        /// <para>
        /// Configures instance hibernation capabilities.
        /// </para>
        /// </summary>
        public HibernationOptionsRequest HibernationOptions { get; set; }

        /// <summary>
        /// Checks to see if the HibernationOptions property is set.
        /// </summary>
        internal bool IsSetHibernationOptions() => this.HibernationOptions != null;

        /// <summary>
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// Specifies IAM instance profile configuration.
        /// </para>
        /// </summary>
        public IamInstanceProfileSpecification IamInstanceProfile { get; set; }

        /// <summary>
        /// Checks to see if the IamInstanceProfile property is set.
        /// </summary>
        internal bool IsSetIamInstanceProfile() => this.IamInstanceProfile != null;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// Identifies the Amazon Machine Image (AMI) for the instance.
        /// </para>
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property InstanceMarketOptions. 
        /// <para>
        /// Configures marketplace-specific deployment options.
        /// </para>
        /// </summary>
        public InstanceMarketOptionsRequest InstanceMarketOptions { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMarketOptions property is set.
        /// </summary>
        internal bool IsSetInstanceMarketOptions() => this.InstanceMarketOptions != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Specifies the WorkSpace Instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property Ipv6AddressCount. 
        /// <para>
        /// Specifies number of IPv6 addresses to assign.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6AddressCount property is set.
        /// </summary>
        internal bool IsSetIpv6AddressCount() => this.Ipv6AddressCount.HasValue;

        /// <summary>
        /// Gets and sets the property Ipv6Addresses. 
        /// <para>
        /// Configures specific IPv6 addresses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceIpv6Address> Ipv6Addresses { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceIpv6Address>() : null;

        /// <summary>
        /// Checks to see if the Ipv6Addresses property is set.
        /// </summary>
        internal bool IsSetIpv6Addresses() => this.Ipv6Addresses != null && (this.Ipv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KernelId. 
        /// <para>
        /// Identifies the kernel for the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string KernelId { get; set; }

        /// <summary>
        /// Checks to see if the KernelId property is set.
        /// </summary>
        internal bool IsSetKernelId() => this.KernelId != null;

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// Specifies the key pair for instance access.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string KeyName { get; set; }

        /// <summary>
        /// Checks to see if the KeyName property is set.
        /// </summary>
        internal bool IsSetKeyName() => this.KeyName != null;

        /// <summary>
        /// Gets and sets the property LicenseSpecifications. 
        /// <para>
        /// Configures license-related settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LicenseConfigurationRequest> LicenseSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<LicenseConfigurationRequest>() : null;

        /// <summary>
        /// Checks to see if the LicenseSpecifications property is set.
        /// </summary>
        internal bool IsSetLicenseSpecifications() => this.LicenseSpecifications != null && (this.LicenseSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaintenanceOptions. 
        /// <para>
        /// Defines automatic maintenance settings.
        /// </para>
        /// </summary>
        public InstanceMaintenanceOptionsRequest MaintenanceOptions { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceOptions property is set.
        /// </summary>
        internal bool IsSetMaintenanceOptions() => this.MaintenanceOptions != null;

        /// <summary>
        /// Gets and sets the property MetadataOptions. 
        /// <para>
        /// Configures instance metadata service settings.
        /// </para>
        /// </summary>
        public InstanceMetadataOptionsRequest MetadataOptions { get; set; }

        /// <summary>
        /// Checks to see if the MetadataOptions property is set.
        /// </summary>
        internal bool IsSetMetadataOptions() => this.MetadataOptions != null;

        /// <summary>
        /// Gets and sets the property Monitoring. 
        /// <para>
        /// Enables or disables detailed instance monitoring.
        /// </para>
        /// </summary>
        public RunInstancesMonitoringEnabled Monitoring { get; set; }

        /// <summary>
        /// Checks to see if the Monitoring property is set.
        /// </summary>
        internal bool IsSetMonitoring() => this.Monitoring != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// Configures network interface settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceNetworkInterfaceSpecification> NetworkInterfaces { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceNetworkInterfaceSpecification>() : null;

        /// <summary>
        /// Checks to see if the NetworkInterfaces property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaces() => this.NetworkInterfaces != null && (this.NetworkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkPerformanceOptions. 
        /// <para>
        /// Defines network performance configuration.
        /// </para>
        /// </summary>
        public InstanceNetworkPerformanceOptionsRequest NetworkPerformanceOptions { get; set; }

        /// <summary>
        /// Checks to see if the NetworkPerformanceOptions property is set.
        /// </summary>
        internal bool IsSetNetworkPerformanceOptions() => this.NetworkPerformanceOptions != null;

        /// <summary>
        /// Gets and sets the property Placement. 
        /// <para>
        /// Specifies instance placement preferences.
        /// </para>
        /// </summary>
        public Placement Placement { get; set; }

        /// <summary>
        /// Checks to see if the Placement property is set.
        /// </summary>
        internal bool IsSetPlacement() => this.Placement != null;

        /// <summary>
        /// Gets and sets the property PrivateDnsNameOptions. 
        /// <para>
        /// Configures private DNS name settings.
        /// </para>
        /// </summary>
        public PrivateDnsNameOptionsRequest PrivateDnsNameOptions { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsNameOptions property is set.
        /// </summary>
        internal bool IsSetPrivateDnsNameOptions() => this.PrivateDnsNameOptions != null;

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// Specifies the primary private IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the PrivateIpAddress property is set.
        /// </summary>
        internal bool IsSetPrivateIpAddress() => this.PrivateIpAddress != null;

        /// <summary>
        /// Gets and sets the property RamdiskId. 
        /// <para>
        /// Identifies the ramdisk for the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string RamdiskId { get; set; }

        /// <summary>
        /// Checks to see if the RamdiskId property is set.
        /// </summary>
        internal bool IsSetRamdiskId() => this.RamdiskId != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// Specifies security group identifiers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// Configures security group settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// Identifies the subnet for the instance.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// Configures resource tagging specifications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 30)]
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserData. 
        /// <para>
        /// Provides custom initialization data for the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 16000)]
        public string UserData { get; set; }

        /// <summary>
        /// Checks to see if the UserData property is set.
        /// </summary>
        internal bool IsSetUserData() => this.UserData != null;
    }
}

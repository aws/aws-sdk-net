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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
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
        private List<BlockDeviceMappingRequest> _blockDeviceMappings = AWSConfigs.InitializeCollections ? new List<BlockDeviceMappingRequest>() : null;
        private CapacityReservationSpecification _capacityReservationSpecification;
        private CpuOptionsRequest _cpuOptions;
        private CreditSpecificationRequest _creditSpecification;
        private bool? _disableApiStop;
        private bool? _ebsOptimized;
        private bool? _enablePrimaryIpv6;
        private EnclaveOptionsRequest _enclaveOptions;
        private HibernationOptionsRequest _hibernationOptions;
        private IamInstanceProfileSpecification _iamInstanceProfile;
        private string _imageId;
        private InstanceMarketOptionsRequest _instanceMarketOptions;
        private string _instanceType;
        private int? _ipv6AddressCount;
        private List<InstanceIpv6Address> _ipv6Addresses = AWSConfigs.InitializeCollections ? new List<InstanceIpv6Address>() : null;
        private string _kernelId;
        private string _keyName;
        private List<LicenseConfigurationRequest> _licenseSpecifications = AWSConfigs.InitializeCollections ? new List<LicenseConfigurationRequest>() : null;
        private InstanceMaintenanceOptionsRequest _maintenanceOptions;
        private InstanceMetadataOptionsRequest _metadataOptions;
        private RunInstancesMonitoringEnabled _monitoring;
        private List<InstanceNetworkInterfaceSpecification> _networkInterfaces = AWSConfigs.InitializeCollections ? new List<InstanceNetworkInterfaceSpecification>() : null;
        private InstanceNetworkPerformanceOptionsRequest _networkPerformanceOptions;
        private Placement _placement;
        private PrivateDnsNameOptionsRequest _privateDnsNameOptions;
        private string _privateIpAddress;
        private string _ramdiskId;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _subnetId;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
        private string _userData;

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// Configures block device mappings for storage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BlockDeviceMappingRequest> BlockDeviceMappings
        {
            get { return this._blockDeviceMappings; }
            set { this._blockDeviceMappings = value; }
        }

        // Check to see if BlockDeviceMappings property is set
        internal bool IsSetBlockDeviceMappings()
        {
            return this._blockDeviceMappings != null && (this._blockDeviceMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationSpecification. 
        /// <para>
        /// Specifies capacity reservation preferences.
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
        /// Gets and sets the property CpuOptions. 
        /// <para>
        /// Configures CPU-specific settings.
        /// </para>
        /// </summary>
        public CpuOptionsRequest CpuOptions
        {
            get { return this._cpuOptions; }
            set { this._cpuOptions = value; }
        }

        // Check to see if CpuOptions property is set
        internal bool IsSetCpuOptions()
        {
            return this._cpuOptions != null;
        }

        /// <summary>
        /// Gets and sets the property CreditSpecification. 
        /// <para>
        /// Defines CPU credit configuration for burstable instances.
        /// </para>
        /// </summary>
        public CreditSpecificationRequest CreditSpecification
        {
            get { return this._creditSpecification; }
            set { this._creditSpecification = value; }
        }

        // Check to see if CreditSpecification property is set
        internal bool IsSetCreditSpecification()
        {
            return this._creditSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property DisableApiStop. 
        /// <para>
        /// Prevents API-initiated instance stop.
        /// </para>
        /// </summary>
        public bool? DisableApiStop
        {
            get { return this._disableApiStop; }
            set { this._disableApiStop = value; }
        }

        // Check to see if DisableApiStop property is set
        internal bool IsSetDisableApiStop()
        {
            return this._disableApiStop.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Enables optimized EBS performance.
        /// </para>
        /// </summary>
        public bool? EbsOptimized
        {
            get { return this._ebsOptimized; }
            set { this._ebsOptimized = value; }
        }

        // Check to see if EbsOptimized property is set
        internal bool IsSetEbsOptimized()
        {
            return this._ebsOptimized.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnablePrimaryIpv6. 
        /// <para>
        /// Enables primary IPv6 address configuration.
        /// </para>
        /// </summary>
        public bool? EnablePrimaryIpv6
        {
            get { return this._enablePrimaryIpv6; }
            set { this._enablePrimaryIpv6 = value; }
        }

        // Check to see if EnablePrimaryIpv6 property is set
        internal bool IsSetEnablePrimaryIpv6()
        {
            return this._enablePrimaryIpv6.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnclaveOptions. 
        /// <para>
        /// Configures AWS Nitro Enclave settings.
        /// </para>
        /// </summary>
        public EnclaveOptionsRequest EnclaveOptions
        {
            get { return this._enclaveOptions; }
            set { this._enclaveOptions = value; }
        }

        // Check to see if EnclaveOptions property is set
        internal bool IsSetEnclaveOptions()
        {
            return this._enclaveOptions != null;
        }

        /// <summary>
        /// Gets and sets the property HibernationOptions. 
        /// <para>
        /// Configures instance hibernation capabilities.
        /// </para>
        /// </summary>
        public HibernationOptionsRequest HibernationOptions
        {
            get { return this._hibernationOptions; }
            set { this._hibernationOptions = value; }
        }

        // Check to see if HibernationOptions property is set
        internal bool IsSetHibernationOptions()
        {
            return this._hibernationOptions != null;
        }

        /// <summary>
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// Specifies IAM instance profile configuration.
        /// </para>
        /// </summary>
        public IamInstanceProfileSpecification IamInstanceProfile
        {
            get { return this._iamInstanceProfile; }
            set { this._iamInstanceProfile = value; }
        }

        // Check to see if IamInstanceProfile property is set
        internal bool IsSetIamInstanceProfile()
        {
            return this._iamInstanceProfile != null;
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// Identifies the Amazon Machine Image (AMI) for the instance.
        /// </para>
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceMarketOptions. 
        /// <para>
        /// Configures marketplace-specific deployment options.
        /// </para>
        /// </summary>
        public InstanceMarketOptionsRequest InstanceMarketOptions
        {
            get { return this._instanceMarketOptions; }
            set { this._instanceMarketOptions = value; }
        }

        // Check to see if InstanceMarketOptions property is set
        internal bool IsSetInstanceMarketOptions()
        {
            return this._instanceMarketOptions != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Specifies the WorkSpace Instance type.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6AddressCount. 
        /// <para>
        /// Specifies number of IPv6 addresses to assign.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? Ipv6AddressCount
        {
            get { return this._ipv6AddressCount; }
            set { this._ipv6AddressCount = value; }
        }

        // Check to see if Ipv6AddressCount property is set
        internal bool IsSetIpv6AddressCount()
        {
            return this._ipv6AddressCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ipv6Addresses. 
        /// <para>
        /// Configures specific IPv6 addresses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceIpv6Address> Ipv6Addresses
        {
            get { return this._ipv6Addresses; }
            set { this._ipv6Addresses = value; }
        }

        // Check to see if Ipv6Addresses property is set
        internal bool IsSetIpv6Addresses()
        {
            return this._ipv6Addresses != null && (this._ipv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KernelId. 
        /// <para>
        /// Identifies the kernel for the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string KernelId
        {
            get { return this._kernelId; }
            set { this._kernelId = value; }
        }

        // Check to see if KernelId property is set
        internal bool IsSetKernelId()
        {
            return this._kernelId != null;
        }

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// Specifies the key pair for instance access.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this._keyName != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseSpecifications. 
        /// <para>
        /// Configures license-related settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LicenseConfigurationRequest> LicenseSpecifications
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
        /// Gets and sets the property MaintenanceOptions. 
        /// <para>
        /// Defines automatic maintenance settings.
        /// </para>
        /// </summary>
        public InstanceMaintenanceOptionsRequest MaintenanceOptions
        {
            get { return this._maintenanceOptions; }
            set { this._maintenanceOptions = value; }
        }

        // Check to see if MaintenanceOptions property is set
        internal bool IsSetMaintenanceOptions()
        {
            return this._maintenanceOptions != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataOptions. 
        /// <para>
        /// Configures instance metadata service settings.
        /// </para>
        /// </summary>
        public InstanceMetadataOptionsRequest MetadataOptions
        {
            get { return this._metadataOptions; }
            set { this._metadataOptions = value; }
        }

        // Check to see if MetadataOptions property is set
        internal bool IsSetMetadataOptions()
        {
            return this._metadataOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Monitoring. 
        /// <para>
        /// Enables or disables detailed instance monitoring.
        /// </para>
        /// </summary>
        public RunInstancesMonitoringEnabled Monitoring
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
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// Configures network interface settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceNetworkInterfaceSpecification> NetworkInterfaces
        {
            get { return this._networkInterfaces; }
            set { this._networkInterfaces = value; }
        }

        // Check to see if NetworkInterfaces property is set
        internal bool IsSetNetworkInterfaces()
        {
            return this._networkInterfaces != null && (this._networkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkPerformanceOptions. 
        /// <para>
        /// Defines network performance configuration.
        /// </para>
        /// </summary>
        public InstanceNetworkPerformanceOptionsRequest NetworkPerformanceOptions
        {
            get { return this._networkPerformanceOptions; }
            set { this._networkPerformanceOptions = value; }
        }

        // Check to see if NetworkPerformanceOptions property is set
        internal bool IsSetNetworkPerformanceOptions()
        {
            return this._networkPerformanceOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Placement. 
        /// <para>
        /// Specifies instance placement preferences.
        /// </para>
        /// </summary>
        public Placement Placement
        {
            get { return this._placement; }
            set { this._placement = value; }
        }

        // Check to see if Placement property is set
        internal bool IsSetPlacement()
        {
            return this._placement != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsNameOptions. 
        /// <para>
        /// Configures private DNS name settings.
        /// </para>
        /// </summary>
        public PrivateDnsNameOptionsRequest PrivateDnsNameOptions
        {
            get { return this._privateDnsNameOptions; }
            set { this._privateDnsNameOptions = value; }
        }

        // Check to see if PrivateDnsNameOptions property is set
        internal bool IsSetPrivateDnsNameOptions()
        {
            return this._privateDnsNameOptions != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// Specifies the primary private IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string PrivateIpAddress
        {
            get { return this._privateIpAddress; }
            set { this._privateIpAddress = value; }
        }

        // Check to see if PrivateIpAddress property is set
        internal bool IsSetPrivateIpAddress()
        {
            return this._privateIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property RamdiskId. 
        /// <para>
        /// Identifies the ramdisk for the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string RamdiskId
        {
            get { return this._ramdiskId; }
            set { this._ramdiskId = value; }
        }

        // Check to see if RamdiskId property is set
        internal bool IsSetRamdiskId()
        {
            return this._ramdiskId != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// Specifies security group identifiers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// Configures security group settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && (this._securityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// Identifies the subnet for the instance.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// Configures resource tagging specifications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserData. 
        /// <para>
        /// Provides custom initialization data for the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=16000)]
        public string UserData
        {
            get { return this._userData; }
            set { this._userData = value; }
        }

        // Check to see if UserData property is set
        internal bool IsSetUserData()
        {
            return this._userData != null;
        }

    }
}
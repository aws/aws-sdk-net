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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// Information about an ODB network.
    /// </summary>
    public partial class OdbNetworkSummary
    {
        private string _availabilityZone;
        private string _availabilityZoneId;
        private string _backupSubnetCidr;
        private string _clientSubnetCidr;
        private DateTime? _createdAt;
        private string _customDomainName;
        private string _defaultDnsPrefix;
        private string _displayName;
        private ManagedServices _managedServices;
        private List<OciDnsForwardingConfig> _ociDnsForwardingConfigs = AWSConfigs.InitializeCollections ? new List<OciDnsForwardingConfig>() : null;
        private string _ociNetworkAnchorId;
        private string _ociNetworkAnchorUrl;
        private string _ociResourceAnchorName;
        private string _ociVcnId;
        private string _ociVcnUrl;
        private string _odbNetworkArn;
        private string _odbNetworkId;
        private List<string> _peeredCidrs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private float? _percentProgress;
        private ResourceStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Amazon Web Services Availability Zone (AZ) where the ODB network is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The AZ ID of the AZ where the ODB network is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property BackupSubnetCidr. 
        /// <para>
        /// The CIDR range of the backup subnet in the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string BackupSubnetCidr
        {
            get { return this._backupSubnetCidr; }
            set { this._backupSubnetCidr = value; }
        }

        // Check to see if BackupSubnetCidr property is set
        internal bool IsSetBackupSubnetCidr()
        {
            return this._backupSubnetCidr != null;
        }

        /// <summary>
        /// Gets and sets the property ClientSubnetCidr. 
        /// <para>
        /// The CIDR range of the client subnet in the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ClientSubnetCidr
        {
            get { return this._clientSubnetCidr; }
            set { this._clientSubnetCidr = value; }
        }

        // Check to see if ClientSubnetCidr property is set
        internal bool IsSetClientSubnetCidr()
        {
            return this._clientSubnetCidr != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the ODB network was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomDomainName. 
        /// <para>
        /// The domain name for the resources in the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CustomDomainName
        {
            get { return this._customDomainName; }
            set { this._customDomainName = value; }
        }

        // Check to see if CustomDomainName property is set
        internal bool IsSetCustomDomainName()
        {
            return this._customDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultDnsPrefix. 
        /// <para>
        /// The DNS prefix to the default DNS domain name. The default DNS domain name is oraclevcn.com.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DefaultDnsPrefix
        {
            get { return this._defaultDnsPrefix; }
            set { this._defaultDnsPrefix = value; }
        }

        // Check to see if DefaultDnsPrefix property is set
        internal bool IsSetDefaultDnsPrefix()
        {
            return this._defaultDnsPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The user-friendly name of the ODB network.
        /// </para>
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedServices. 
        /// <para>
        /// The managed services configuration for the ODB network.
        /// </para>
        /// </summary>
        public ManagedServices ManagedServices
        {
            get { return this._managedServices; }
            set { this._managedServices = value; }
        }

        // Check to see if ManagedServices property is set
        internal bool IsSetManagedServices()
        {
            return this._managedServices != null;
        }

        /// <summary>
        /// Gets and sets the property OciDnsForwardingConfigs. 
        /// <para>
        /// The DNS resolver endpoint in OCI for forwarding DNS queries for the ociPrivateZone
        /// domain.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OciDnsForwardingConfig> OciDnsForwardingConfigs
        {
            get { return this._ociDnsForwardingConfigs; }
            set { this._ociDnsForwardingConfigs = value; }
        }

        // Check to see if OciDnsForwardingConfigs property is set
        internal bool IsSetOciDnsForwardingConfigs()
        {
            return this._ociDnsForwardingConfigs != null && (this._ociDnsForwardingConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OciNetworkAnchorId. 
        /// <para>
        /// The unique identifier of the OCI network anchor for the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string OciNetworkAnchorId
        {
            get { return this._ociNetworkAnchorId; }
            set { this._ociNetworkAnchorId = value; }
        }

        // Check to see if OciNetworkAnchorId property is set
        internal bool IsSetOciNetworkAnchorId()
        {
            return this._ociNetworkAnchorId != null;
        }

        /// <summary>
        /// Gets and sets the property OciNetworkAnchorUrl. 
        /// <para>
        /// The URL of the OCI network anchor for the ODB network.
        /// </para>
        /// </summary>
        public string OciNetworkAnchorUrl
        {
            get { return this._ociNetworkAnchorUrl; }
            set { this._ociNetworkAnchorUrl = value; }
        }

        // Check to see if OciNetworkAnchorUrl property is set
        internal bool IsSetOciNetworkAnchorUrl()
        {
            return this._ociNetworkAnchorUrl != null;
        }

        /// <summary>
        /// Gets and sets the property OciResourceAnchorName. 
        /// <para>
        /// The name of the OCI resource anchor associated with the ODB network.
        /// </para>
        /// </summary>
        public string OciResourceAnchorName
        {
            get { return this._ociResourceAnchorName; }
            set { this._ociResourceAnchorName = value; }
        }

        // Check to see if OciResourceAnchorName property is set
        internal bool IsSetOciResourceAnchorName()
        {
            return this._ociResourceAnchorName != null;
        }

        /// <summary>
        /// Gets and sets the property OciVcnId. 
        /// <para>
        /// The Oracle Cloud ID (OCID) for the Virtual Cloud Network (VCN) associated with the
        /// ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string OciVcnId
        {
            get { return this._ociVcnId; }
            set { this._ociVcnId = value; }
        }

        // Check to see if OciVcnId property is set
        internal bool IsSetOciVcnId()
        {
            return this._ociVcnId != null;
        }

        /// <summary>
        /// Gets and sets the property OciVcnUrl. 
        /// <para>
        /// The URL for the VCN that's associated with the ODB network.
        /// </para>
        /// </summary>
        public string OciVcnUrl
        {
            get { return this._ociVcnUrl; }
            set { this._ociVcnUrl = value; }
        }

        // Check to see if OciVcnUrl property is set
        internal bool IsSetOciVcnUrl()
        {
            return this._ociVcnUrl != null;
        }

        /// <summary>
        /// Gets and sets the property OdbNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ODB network.
        /// </para>
        /// </summary>
        public string OdbNetworkArn
        {
            get { return this._odbNetworkArn; }
            set { this._odbNetworkArn = value; }
        }

        // Check to see if OdbNetworkArn property is set
        internal bool IsSetOdbNetworkArn()
        {
            return this._odbNetworkArn != null;
        }

        /// <summary>
        /// Gets and sets the property OdbNetworkId. 
        /// <para>
        /// The unique identifier of the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=2048)]
        public string OdbNetworkId
        {
            get { return this._odbNetworkId; }
            set { this._odbNetworkId = value; }
        }

        // Check to see if OdbNetworkId property is set
        internal bool IsSetOdbNetworkId()
        {
            return this._odbNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property PeeredCidrs. 
        /// <para>
        /// The list of CIDR ranges from the peered VPC that are allowed access to the ODB network.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public List<string> PeeredCidrs
        {
            get { return this._peeredCidrs; }
            set { this._peeredCidrs = value; }
        }

        // Check to see if PeeredCidrs property is set
        internal bool IsSetPeeredCidrs()
        {
            return this._peeredCidrs != null && (this._peeredCidrs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// The amount of progress made on the current operation on the ODB network, expressed
        /// as a percentage.
        /// </para>
        /// </summary>
        public float? PercentProgress
        {
            get { return this._percentProgress; }
            set { this._percentProgress = value; }
        }

        // Check to see if PercentProgress property is set
        internal bool IsSetPercentProgress()
        {
            return this._percentProgress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the ODB network.
        /// </para>
        /// </summary>
        public ResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the current status of the ODB network.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}
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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// Information about an ODB network.
    /// </summary>
    public partial class OdbNetwork
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Amazon Web Services Availability Zone (AZ) where the ODB network is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The AZ ID of the AZ where the ODB network is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property BackupSubnetCidr. 
        /// <para>
        /// The CIDR range of the backup subnet in the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string BackupSubnetCidr { get; set; }

        /// <summary>
        /// Checks to see if the BackupSubnetCidr property is set.
        /// </summary>
        internal bool IsSetBackupSubnetCidr() => this.BackupSubnetCidr != null;

        /// <summary>
        /// Gets and sets the property ClientSubnetCidr. 
        /// <para>
        /// The CIDR range of the client subnet in the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ClientSubnetCidr { get; set; }

        /// <summary>
        /// Checks to see if the ClientSubnetCidr property is set.
        /// </summary>
        internal bool IsSetClientSubnetCidr() => this.ClientSubnetCidr != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the ODB network was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CustomDomainName. 
        /// <para>
        /// The domain name for the resources in the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CustomDomainName { get; set; }

        /// <summary>
        /// Checks to see if the CustomDomainName property is set.
        /// </summary>
        internal bool IsSetCustomDomainName() => this.CustomDomainName != null;

        /// <summary>
        /// Gets and sets the property DefaultDnsPrefix. 
        /// <para>
        /// The DNS prefix to the default DNS domain name. The default DNS domain name is oraclevcn.com.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DefaultDnsPrefix { get; set; }

        /// <summary>
        /// Checks to see if the DefaultDnsPrefix property is set.
        /// </summary>
        internal bool IsSetDefaultDnsPrefix() => this.DefaultDnsPrefix != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The user-friendly name of the ODB network.
        /// </para>
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Ec2PlacementGroupIds. 
        /// <para>
        /// The list of EC2 Placement Group IDs associated with your ODB network.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Ec2PlacementGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Ec2PlacementGroupIds property is set.
        /// </summary>
        internal bool IsSetEc2PlacementGroupIds() => this.Ec2PlacementGroupIds != null && (this.Ec2PlacementGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ManagedServices. 
        /// <para>
        /// The managed services configuration for the ODB network.
        /// </para>
        /// </summary>
        public ManagedServices ManagedServices { get; set; }

        /// <summary>
        /// Checks to see if the ManagedServices property is set.
        /// </summary>
        internal bool IsSetManagedServices() => this.ManagedServices != null;

        /// <summary>
        /// Gets and sets the property OciDnsForwardingConfigs. 
        /// <para>
        /// The DNS resolver endpoint in OCI for forwarding DNS queries for the ociPrivateZone
        /// domain.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OciDnsForwardingConfig> OciDnsForwardingConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<OciDnsForwardingConfig>() : null;

        /// <summary>
        /// Checks to see if the OciDnsForwardingConfigs property is set.
        /// </summary>
        internal bool IsSetOciDnsForwardingConfigs() => this.OciDnsForwardingConfigs != null && (this.OciDnsForwardingConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OciNetworkAnchorId. 
        /// <para>
        /// The unique identifier of the OCI network anchor for the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string OciNetworkAnchorId { get; set; }

        /// <summary>
        /// Checks to see if the OciNetworkAnchorId property is set.
        /// </summary>
        internal bool IsSetOciNetworkAnchorId() => this.OciNetworkAnchorId != null;

        /// <summary>
        /// Gets and sets the property OciNetworkAnchorUrl. 
        /// <para>
        /// The URL of the OCI network anchor for the ODB network.
        /// </para>
        /// </summary>
        public string OciNetworkAnchorUrl { get; set; }

        /// <summary>
        /// Checks to see if the OciNetworkAnchorUrl property is set.
        /// </summary>
        internal bool IsSetOciNetworkAnchorUrl() => this.OciNetworkAnchorUrl != null;

        /// <summary>
        /// Gets and sets the property OciResourceAnchorName. 
        /// <para>
        /// The name of the OCI resource anchor that's associated with the ODB network.
        /// </para>
        /// </summary>
        public string OciResourceAnchorName { get; set; }

        /// <summary>
        /// Checks to see if the OciResourceAnchorName property is set.
        /// </summary>
        internal bool IsSetOciResourceAnchorName() => this.OciResourceAnchorName != null;

        /// <summary>
        /// Gets and sets the property OciVcnId. 
        /// <para>
        /// The Oracle Cloud ID (OCID) for the Virtual Cloud Network (VCN) that's associated with
        /// the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string OciVcnId { get; set; }

        /// <summary>
        /// Checks to see if the OciVcnId property is set.
        /// </summary>
        internal bool IsSetOciVcnId() => this.OciVcnId != null;

        /// <summary>
        /// Gets and sets the property OciVcnUrl. 
        /// <para>
        /// The URL for the VCN that's associated with the ODB network.
        /// </para>
        /// </summary>
        public string OciVcnUrl { get; set; }

        /// <summary>
        /// Checks to see if the OciVcnUrl property is set.
        /// </summary>
        internal bool IsSetOciVcnUrl() => this.OciVcnUrl != null;

        /// <summary>
        /// Gets and sets the property OdbNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ODB network.
        /// </para>
        /// </summary>
        public string OdbNetworkArn { get; set; }

        /// <summary>
        /// Checks to see if the OdbNetworkArn property is set.
        /// </summary>
        internal bool IsSetOdbNetworkArn() => this.OdbNetworkArn != null;

        /// <summary>
        /// Gets and sets the property OdbNetworkId. 
        /// <para>
        /// The unique identifier of the ODB network.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 6, Max = 2048)]
        public string OdbNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the OdbNetworkId property is set.
        /// </summary>
        internal bool IsSetOdbNetworkId() => this.OdbNetworkId != null;

        /// <summary>
        /// Gets and sets the property PeeredCidrs. 
        /// <para>
        /// The list of CIDR ranges from the peered VPC that are allowed access to the ODB network.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> PeeredCidrs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PeeredCidrs property is set.
        /// </summary>
        internal bool IsSetPeeredCidrs() => this.PeeredCidrs != null && (this.PeeredCidrs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// The amount of progress made on the current operation on the ODB network, expressed
        /// as a percentage.
        /// </para>
        /// </summary>
        public float? PercentProgress { get; set; }

        /// <summary>
        /// Checks to see if the PercentProgress property is set.
        /// </summary>
        internal bool IsSetPercentProgress() => this.PercentProgress.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the ODB network.
        /// </para>
        /// </summary>
        public ResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the current status of the ODB network.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}

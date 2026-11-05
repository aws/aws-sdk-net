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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains information about an Directory Service directory.
    /// </summary>
    public partial class DirectoryDescription
    {
        /// <summary>
        /// Gets and sets the property AccessUrl. 
        /// <para>
        /// The access URL for the directory, such as <c>http://&lt;alias&gt;.awsapps.com</c>.
        /// If no alias exists, <c>&lt;alias&gt;</c> is the directory identifier, such as <c>d-XXXXXXXXXX</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string AccessUrl { get; set; }

        /// <summary>
        /// Checks to see if the AccessUrl property is set.
        /// </summary>
        internal bool IsSetAccessUrl() => this.AccessUrl != null;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias for the directory. If no alias exists, the alias is the directory identifier,
        /// such as <c>d-XXXXXXXXXX</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 62)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property ConnectSettings. 
        /// <para>
        ///  <a>DirectoryConnectSettingsDescription</a> object that contains additional information
        /// about an AD Connector directory. Present only for AD Connector directories.
        /// </para>
        /// </summary>
        public DirectoryConnectSettingsDescription ConnectSettings { get; set; }

        /// <summary>
        /// Checks to see if the ConnectSettings property is set.
        /// </summary>
        internal bool IsSetConnectSettings() => this.ConnectSettings != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DesiredNumberOfDomainControllers. 
        /// <para>
        /// The desired number of domain controllers in the directory if the directory is Microsoft
        /// AD.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2)]
        public int? DesiredNumberOfDomainControllers { get; set; }

        /// <summary>
        /// Checks to see if the DesiredNumberOfDomainControllers property is set.
        /// </summary>
        internal bool IsSetDesiredNumberOfDomainControllers() => this.DesiredNumberOfDomainControllers.HasValue;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The directory identifier.
        /// </para>
        /// </summary>
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property DnsIpAddrs. 
        /// <para>
        /// The IP addresses of the DNS servers for the directory. For a Simple AD or Microsoft
        /// AD directory, these are the IP addresses of the Simple AD or Microsoft AD directory
        /// servers. For an AD Connector directory, these are the IP addresses of self-managed
        /// directory to which the AD Connector is connected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsIpAddrs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DnsIpAddrs property is set.
        /// </summary>
        internal bool IsSetDnsIpAddrs() => this.DnsIpAddrs != null && (this.DnsIpAddrs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DnsIpv6Addrs. 
        /// <para>
        /// The IPv6 addresses of the DNS servers for the directory. For a Simple AD or Microsoft
        /// AD directory, these are the IPv6 addresses of the Simple AD or Microsoft AD directory
        /// servers. For an AD Connector directory, these are the IPv6 addresses of the DNS servers
        /// or domain controllers in your self-managed directory to which the AD Connector is
        /// connected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsIpv6Addrs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DnsIpv6Addrs property is set.
        /// </summary>
        internal bool IsSetDnsIpv6Addrs() => this.DnsIpv6Addrs != null && (this.DnsIpv6Addrs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Edition. 
        /// <para>
        /// The edition associated with this directory.
        /// </para>
        /// </summary>
        public DirectoryEdition Edition { get; set; }

        /// <summary>
        /// Checks to see if the Edition property is set.
        /// </summary>
        internal bool IsSetEdition() => this.Edition != null;

        /// <summary>
        /// Gets and sets the property HybridSettings. 
        /// <para>
        /// Contains information about the hybrid directory configuration for the directory, including
        /// Amazon Web Services System Manager managed node identifiers and DNS IPs.
        /// </para>
        /// </summary>
        public HybridSettingsDescription HybridSettings { get; set; }

        /// <summary>
        /// Checks to see if the HybridSettings property is set.
        /// </summary>
        internal bool IsSetHybridSettings() => this.HybridSettings != null;

        /// <summary>
        /// Gets and sets the property LaunchTime. 
        /// <para>
        /// The date and time when the directory was created.
        /// </para>
        /// </summary>
        public DateTime? LaunchTime { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTime property is set.
        /// </summary>
        internal bool IsSetLaunchTime() => this.LaunchTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The fully qualified name of the directory.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The network type of the directory.
        /// </para>
        /// </summary>
        public NetworkType NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property OsVersion. 
        /// <para>
        /// The operating system (OS) version of the directory.
        /// </para>
        /// </summary>
        public OSVersion OsVersion { get; set; }

        /// <summary>
        /// Checks to see if the OsVersion property is set.
        /// </summary>
        internal bool IsSetOsVersion() => this.OsVersion != null;

        /// <summary>
        /// Gets and sets the property OwnerDirectoryDescription. 
        /// <para>
        /// Describes the Managed Microsoft AD directory in the directory owner account.
        /// </para>
        /// </summary>
        public OwnerDirectoryDescription OwnerDirectoryDescription { get; set; }

        /// <summary>
        /// Checks to see if the OwnerDirectoryDescription property is set.
        /// </summary>
        internal bool IsSetOwnerDirectoryDescription() => this.OwnerDirectoryDescription != null;

        /// <summary>
        /// Gets and sets the property RadiusSettings. 
        /// <para>
        /// Information about the <a>RadiusSettings</a> object configured for this directory.
        /// </para>
        /// </summary>
        public RadiusSettings RadiusSettings { get; set; }

        /// <summary>
        /// Checks to see if the RadiusSettings property is set.
        /// </summary>
        internal bool IsSetRadiusSettings() => this.RadiusSettings != null;

        /// <summary>
        /// Gets and sets the property RadiusStatus. 
        /// <para>
        /// The status of the RADIUS MFA server connection.
        /// </para>
        /// </summary>
        public RadiusStatus RadiusStatus { get; set; }

        /// <summary>
        /// Checks to see if the RadiusStatus property is set.
        /// </summary>
        internal bool IsSetRadiusStatus() => this.RadiusStatus != null;

        /// <summary>
        /// Gets and sets the property RegionsInfo. 
        /// <para>
        /// Lists the Regions where the directory has replicated.
        /// </para>
        /// </summary>
        public RegionsInfo RegionsInfo { get; set; }

        /// <summary>
        /// Checks to see if the RegionsInfo property is set.
        /// </summary>
        internal bool IsSetRegionsInfo() => this.RegionsInfo != null;

        /// <summary>
        /// Gets and sets the property ShareMethod. 
        /// <para>
        /// The method used when sharing a directory to determine whether the directory should
        /// be shared within your Amazon Web Services organization (<c>ORGANIZATIONS</c>) or with
        /// any Amazon Web Services account by sending a shared directory request (<c>HANDSHAKE</c>).
        /// </para>
        /// </summary>
        public ShareMethod ShareMethod { get; set; }

        /// <summary>
        /// Checks to see if the ShareMethod property is set.
        /// </summary>
        internal bool IsSetShareMethod() => this.ShareMethod != null;

        /// <summary>
        /// Gets and sets the property ShareNotes. 
        /// <para>
        /// A directory share request that is sent by the directory owner to the directory consumer.
        /// The request includes a typed message to help the directory consumer administrator
        /// determine whether to approve or reject the share invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string ShareNotes { get; set; }

        /// <summary>
        /// Checks to see if the ShareNotes property is set.
        /// </summary>
        internal bool IsSetShareNotes() => this.ShareNotes != null;

        /// <summary>
        /// Gets and sets the property ShareStatus. 
        /// <para>
        /// Current directory status of the shared Managed Microsoft AD directory.
        /// </para>
        /// </summary>
        public ShareStatus ShareStatus { get; set; }

        /// <summary>
        /// Checks to see if the ShareStatus property is set.
        /// </summary>
        internal bool IsSetShareStatus() => this.ShareStatus != null;

        /// <summary>
        /// Gets and sets the property ShortName. 
        /// <para>
        /// The short name of the directory.
        /// </para>
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Checks to see if the ShortName property is set.
        /// </summary>
        internal bool IsSetShortName() => this.ShortName != null;

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The directory size.
        /// </para>
        /// </summary>
        public DirectorySize Size { get; set; }

        /// <summary>
        /// Checks to see if the Size property is set.
        /// </summary>
        internal bool IsSetSize() => this.Size != null;

        /// <summary>
        /// Gets and sets the property SsoEnabled. 
        /// <para>
        /// Indicates whether single sign-on is enabled for the directory. For more information,
        /// see <a>EnableSso</a> and <a>DisableSso</a>.
        /// </para>
        /// </summary>
        public bool? SsoEnabled { get; set; }

        /// <summary>
        /// Checks to see if the SsoEnabled property is set.
        /// </summary>
        internal bool IsSetSsoEnabled() => this.SsoEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// The current stage of the directory.
        /// </para>
        /// </summary>
        public DirectoryStage Stage { get; set; }

        /// <summary>
        /// Checks to see if the Stage property is set.
        /// </summary>
        internal bool IsSetStage() => this.Stage != null;

        /// <summary>
        /// Gets and sets the property StageLastUpdatedDateTime. 
        /// <para>
        /// The date and time when the stage was last updated.
        /// </para>
        /// </summary>
        public DateTime? StageLastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the StageLastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetStageLastUpdatedDateTime() => this.StageLastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property StageReason. 
        /// <para>
        /// Additional information about the directory stage.
        /// </para>
        /// </summary>
        public string StageReason { get; set; }

        /// <summary>
        /// Checks to see if the StageReason property is set.
        /// </summary>
        internal bool IsSetStageReason() => this.StageReason != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The directory type.
        /// </para>
        /// </summary>
        public DirectoryType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VpcSettings. 
        /// <para>
        /// A <a>DirectoryVpcSettingsDescription</a> object that contains additional information
        /// about a directory. Present only for Simple AD and Managed Microsoft AD directories.
        /// </para>
        /// </summary>
        public DirectoryVpcSettingsDescription VpcSettings { get; set; }

        /// <summary>
        /// Checks to see if the VpcSettings property is set.
        /// </summary>
        internal bool IsSetVpcSettings() => this.VpcSettings != null;
    }
}

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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
        private string _accessUrl;
        private string _alias;
        private DirectoryConnectSettingsDescription _connectSettings;
        private string _description;
        private int? _desiredNumberOfDomainControllers;
        private string _directoryId;
        private List<string> _dnsIpAddrs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _dnsIpv6Addrs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DirectoryEdition _edition;
        private HybridSettingsDescription _hybridSettings;
        private DateTime? _launchTime;
        private string _name;
        private NetworkType _networkType;
        private OSVersion _osVersion;
        private OwnerDirectoryDescription _ownerDirectoryDescription;
        private RadiusSettings _radiusSettings;
        private RadiusStatus _radiusStatus;
        private RegionsInfo _regionsInfo;
        private ShareMethod _shareMethod;
        private string _shareNotes;
        private ShareStatus _shareStatus;
        private string _shortName;
        private DirectorySize _size;
        private bool? _ssoEnabled;
        private DirectoryStage _stage;
        private DateTime? _stageLastUpdatedDateTime;
        private string _stageReason;
        private DirectoryType _type;
        private DirectoryVpcSettingsDescription _vpcSettings;

        /// <summary>
        /// Gets and sets the property AccessUrl. 
        /// <para>
        /// The access URL for the directory, such as <c>http://&lt;alias&gt;.awsapps.com</c>.
        /// If no alias exists, <c>&lt;alias&gt;</c> is the directory identifier, such as <c>d-XXXXXXXXXX</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string AccessUrl
        {
            get { return this._accessUrl; }
            set { this._accessUrl = value; }
        }

        // Check to see if AccessUrl property is set
        internal bool IsSetAccessUrl()
        {
            return this._accessUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias for the directory. If no alias exists, the alias is the directory identifier,
        /// such as <c>d-XXXXXXXXXX</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=62)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectSettings. 
        /// <para>
        ///  <a>DirectoryConnectSettingsDescription</a> object that contains additional information
        /// about an AD Connector directory. Present only for AD Connector directories.
        /// </para>
        /// </summary>
        public DirectoryConnectSettingsDescription ConnectSettings
        {
            get { return this._connectSettings; }
            set { this._connectSettings = value; }
        }

        // Check to see if ConnectSettings property is set
        internal bool IsSetConnectSettings()
        {
            return this._connectSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DesiredNumberOfDomainControllers. 
        /// <para>
        /// The desired number of domain controllers in the directory if the directory is Microsoft
        /// AD.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2)]
        public int? DesiredNumberOfDomainControllers
        {
            get { return this._desiredNumberOfDomainControllers; }
            set { this._desiredNumberOfDomainControllers = value; }
        }

        // Check to see if DesiredNumberOfDomainControllers property is set
        internal bool IsSetDesiredNumberOfDomainControllers()
        {
            return this._desiredNumberOfDomainControllers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The directory identifier.
        /// </para>
        /// </summary>
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property DnsIpAddrs. 
        /// <para>
        /// The IP addresses of the DNS servers for the directory. For a Simple AD or Microsoft
        /// AD directory, these are the IP addresses of the Simple AD or Microsoft AD directory
        /// servers. For an AD Connector directory, these are the IP addresses of self-managed
        /// directory to which the AD Connector is connected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsIpAddrs
        {
            get { return this._dnsIpAddrs; }
            set { this._dnsIpAddrs = value; }
        }

        // Check to see if DnsIpAddrs property is set
        internal bool IsSetDnsIpAddrs()
        {
            return this._dnsIpAddrs != null && (this._dnsIpAddrs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsIpv6Addrs
        {
            get { return this._dnsIpv6Addrs; }
            set { this._dnsIpv6Addrs = value; }
        }

        // Check to see if DnsIpv6Addrs property is set
        internal bool IsSetDnsIpv6Addrs()
        {
            return this._dnsIpv6Addrs != null && (this._dnsIpv6Addrs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Edition. 
        /// <para>
        /// The edition associated with this directory.
        /// </para>
        /// </summary>
        public DirectoryEdition Edition
        {
            get { return this._edition; }
            set { this._edition = value; }
        }

        // Check to see if Edition property is set
        internal bool IsSetEdition()
        {
            return this._edition != null;
        }

        /// <summary>
        /// Gets and sets the property HybridSettings. 
        /// <para>
        /// Contains information about the hybrid directory configuration for the directory, including
        /// Amazon Web Services System Manager managed node identifiers and DNS IPs.
        /// </para>
        /// </summary>
        public HybridSettingsDescription HybridSettings
        {
            get { return this._hybridSettings; }
            set { this._hybridSettings = value; }
        }

        // Check to see if HybridSettings property is set
        internal bool IsSetHybridSettings()
        {
            return this._hybridSettings != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchTime. 
        /// <para>
        /// The date and time when the directory was created.
        /// </para>
        /// </summary>
        public DateTime? LaunchTime
        {
            get { return this._launchTime; }
            set { this._launchTime = value; }
        }

        // Check to see if LaunchTime property is set
        internal bool IsSetLaunchTime()
        {
            return this._launchTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The fully qualified name of the directory.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The network type of the directory.
        /// </para>
        /// </summary>
        public NetworkType NetworkType
        {
            get { return this._networkType; }
            set { this._networkType = value; }
        }

        // Check to see if NetworkType property is set
        internal bool IsSetNetworkType()
        {
            return this._networkType != null;
        }

        /// <summary>
        /// Gets and sets the property OsVersion. 
        /// <para>
        /// The operating system (OS) version of the directory.
        /// </para>
        /// </summary>
        public OSVersion OsVersion
        {
            get { return this._osVersion; }
            set { this._osVersion = value; }
        }

        // Check to see if OsVersion property is set
        internal bool IsSetOsVersion()
        {
            return this._osVersion != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerDirectoryDescription. 
        /// <para>
        /// Describes the Managed Microsoft AD directory in the directory owner account.
        /// </para>
        /// </summary>
        public OwnerDirectoryDescription OwnerDirectoryDescription
        {
            get { return this._ownerDirectoryDescription; }
            set { this._ownerDirectoryDescription = value; }
        }

        // Check to see if OwnerDirectoryDescription property is set
        internal bool IsSetOwnerDirectoryDescription()
        {
            return this._ownerDirectoryDescription != null;
        }

        /// <summary>
        /// Gets and sets the property RadiusSettings. 
        /// <para>
        /// Information about the <a>RadiusSettings</a> object configured for this directory.
        /// </para>
        /// </summary>
        public RadiusSettings RadiusSettings
        {
            get { return this._radiusSettings; }
            set { this._radiusSettings = value; }
        }

        // Check to see if RadiusSettings property is set
        internal bool IsSetRadiusSettings()
        {
            return this._radiusSettings != null;
        }

        /// <summary>
        /// Gets and sets the property RadiusStatus. 
        /// <para>
        /// The status of the RADIUS MFA server connection.
        /// </para>
        /// </summary>
        public RadiusStatus RadiusStatus
        {
            get { return this._radiusStatus; }
            set { this._radiusStatus = value; }
        }

        // Check to see if RadiusStatus property is set
        internal bool IsSetRadiusStatus()
        {
            return this._radiusStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RegionsInfo. 
        /// <para>
        /// Lists the Regions where the directory has replicated.
        /// </para>
        /// </summary>
        public RegionsInfo RegionsInfo
        {
            get { return this._regionsInfo; }
            set { this._regionsInfo = value; }
        }

        // Check to see if RegionsInfo property is set
        internal bool IsSetRegionsInfo()
        {
            return this._regionsInfo != null;
        }

        /// <summary>
        /// Gets and sets the property ShareMethod. 
        /// <para>
        /// The method used when sharing a directory to determine whether the directory should
        /// be shared within your Amazon Web Services organization (<c>ORGANIZATIONS</c>) or with
        /// any Amazon Web Services account by sending a shared directory request (<c>HANDSHAKE</c>).
        /// </para>
        /// </summary>
        public ShareMethod ShareMethod
        {
            get { return this._shareMethod; }
            set { this._shareMethod = value; }
        }

        // Check to see if ShareMethod property is set
        internal bool IsSetShareMethod()
        {
            return this._shareMethod != null;
        }

        /// <summary>
        /// Gets and sets the property ShareNotes. 
        /// <para>
        /// A directory share request that is sent by the directory owner to the directory consumer.
        /// The request includes a typed message to help the directory consumer administrator
        /// determine whether to approve or reject the share invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=1024)]
        public string ShareNotes
        {
            get { return this._shareNotes; }
            set { this._shareNotes = value; }
        }

        // Check to see if ShareNotes property is set
        internal bool IsSetShareNotes()
        {
            return this._shareNotes != null;
        }

        /// <summary>
        /// Gets and sets the property ShareStatus. 
        /// <para>
        /// Current directory status of the shared Managed Microsoft AD directory.
        /// </para>
        /// </summary>
        public ShareStatus ShareStatus
        {
            get { return this._shareStatus; }
            set { this._shareStatus = value; }
        }

        // Check to see if ShareStatus property is set
        internal bool IsSetShareStatus()
        {
            return this._shareStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ShortName. 
        /// <para>
        /// The short name of the directory.
        /// </para>
        /// </summary>
        public string ShortName
        {
            get { return this._shortName; }
            set { this._shortName = value; }
        }

        // Check to see if ShortName property is set
        internal bool IsSetShortName()
        {
            return this._shortName != null;
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The directory size.
        /// </para>
        /// </summary>
        public DirectorySize Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size != null;
        }

        /// <summary>
        /// Gets and sets the property SsoEnabled. 
        /// <para>
        /// Indicates whether single sign-on is enabled for the directory. For more information,
        /// see <a>EnableSso</a> and <a>DisableSso</a>.
        /// </para>
        /// </summary>
        public bool? SsoEnabled
        {
            get { return this._ssoEnabled; }
            set { this._ssoEnabled = value; }
        }

        // Check to see if SsoEnabled property is set
        internal bool IsSetSsoEnabled()
        {
            return this._ssoEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// The current stage of the directory.
        /// </para>
        /// </summary>
        public DirectoryStage Stage
        {
            get { return this._stage; }
            set { this._stage = value; }
        }

        // Check to see if Stage property is set
        internal bool IsSetStage()
        {
            return this._stage != null;
        }

        /// <summary>
        /// Gets and sets the property StageLastUpdatedDateTime. 
        /// <para>
        /// The date and time when the stage was last updated.
        /// </para>
        /// </summary>
        public DateTime? StageLastUpdatedDateTime
        {
            get { return this._stageLastUpdatedDateTime; }
            set { this._stageLastUpdatedDateTime = value; }
        }

        // Check to see if StageLastUpdatedDateTime property is set
        internal bool IsSetStageLastUpdatedDateTime()
        {
            return this._stageLastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StageReason. 
        /// <para>
        /// Additional information about the directory stage.
        /// </para>
        /// </summary>
        public string StageReason
        {
            get { return this._stageReason; }
            set { this._stageReason = value; }
        }

        // Check to see if StageReason property is set
        internal bool IsSetStageReason()
        {
            return this._stageReason != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The directory type.
        /// </para>
        /// </summary>
        public DirectoryType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VpcSettings. 
        /// <para>
        /// A <a>DirectoryVpcSettingsDescription</a> object that contains additional information
        /// about a directory. Present only for Simple AD and Managed Microsoft AD directories.
        /// </para>
        /// </summary>
        public DirectoryVpcSettingsDescription VpcSettings
        {
            get { return this._vpcSettings; }
            set { this._vpcSettings = value; }
        }

        // Check to see if VpcSettings property is set
        internal bool IsSetVpcSettings()
        {
            return this._vpcSettings != null;
        }

    }
}
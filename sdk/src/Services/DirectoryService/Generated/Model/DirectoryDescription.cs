/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains information about an AWS Directory Service directory.
    /// </summary>
    public partial class DirectoryDescription
    {
        private string _accessUrl;
        private string _alias;
        private DirectoryConnectSettingsDescription _connectSettings;
        private string _description;
        private string _directoryId;
        private List<string> _dnsIpAddrs = new List<string>();
        private DateTime? _launchTime;
        private string _name;
        private RadiusSettings _radiusSettings;
        private RadiusStatus _radiusStatus;
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
        /// The access URL for the directory, such as <code>http://&#x3C;alias&#x3E;.awsapps.com</code>.
        /// </para>
        /// </summary>
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
        /// The alias for the directory.
        /// </para>
        /// </summary>
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
        /// A <a>DirectoryConnectSettingsDescription</a> object that contains additional information
        /// about an AD Connector directory. This member is only present if the directory is an
        /// AD Connector directory.
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
        /// The textual description for the directory.
        /// </para>
        /// </summary>
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
        /// The IP addresses of the DNS servers for the directory. For a Simple AD directory,
        /// these are the IP addresses of the Simple AD directory servers. For an AD Connector
        /// directory, these are the IP addresses of the DNS servers or domain controllers in
        /// the on-premises directory that the AD Connector is connected to.
        /// </para>
        /// </summary>
        public List<string> DnsIpAddrs
        {
            get { return this._dnsIpAddrs; }
            set { this._dnsIpAddrs = value; }
        }

        // Check to see if DnsIpAddrs property is set
        internal bool IsSetDnsIpAddrs()
        {
            return this._dnsIpAddrs != null && this._dnsIpAddrs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LaunchTime. 
        /// <para>
        /// Specifies when the directory was created.
        /// </para>
        /// </summary>
        public DateTime LaunchTime
        {
            get { return this._launchTime.GetValueOrDefault(); }
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
        /// The fully-qualified name of the directory.
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
        /// Gets and sets the property RadiusSettings. 
        /// <para>
        /// A <a>RadiusSettings</a> object that contains information about the RADIUS server configured
        /// for this directory.
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
        /// Indicates if single-sign on is enabled for the directory. For more information, see
        /// <a>EnableSso</a> and <a>DisableSso</a>.
        /// </para>
        /// </summary>
        public bool SsoEnabled
        {
            get { return this._ssoEnabled.GetValueOrDefault(); }
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
        /// The date and time that the stage was last updated.
        /// </para>
        /// </summary>
        public DateTime StageLastUpdatedDateTime
        {
            get { return this._stageLastUpdatedDateTime.GetValueOrDefault(); }
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
        /// The directory size.
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
        /// about a Simple AD directory. This member is only present if the directory is a Simple
        /// AD directory.
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
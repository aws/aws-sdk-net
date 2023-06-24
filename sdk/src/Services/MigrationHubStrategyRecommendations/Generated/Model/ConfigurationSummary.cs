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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Summary of the collector configuration.
    /// </summary>
    public partial class ConfigurationSummary
    {
        private List<IPAddressBasedRemoteInfo> _ipAddressBasedRemoteInfoList = new List<IPAddressBasedRemoteInfo>();
        private List<PipelineInfo> _pipelineInfoList = new List<PipelineInfo>();
        private RemoteSourceCodeAnalysisServerInfo _remoteSourceCodeAnalysisServerInfo;
        private List<VcenterBasedRemoteInfo> _vcenterBasedRemoteInfoList = new List<VcenterBasedRemoteInfo>();
        private List<VersionControlInfo> _versionControlInfoList = new List<VersionControlInfo>();

        /// <summary>
        /// Gets and sets the property IpAddressBasedRemoteInfoList. 
        /// <para>
        /// IP address based configurations.
        /// </para>
        /// </summary>
        public List<IPAddressBasedRemoteInfo> IpAddressBasedRemoteInfoList
        {
            get { return this._ipAddressBasedRemoteInfoList; }
            set { this._ipAddressBasedRemoteInfoList = value; }
        }

        // Check to see if IpAddressBasedRemoteInfoList property is set
        internal bool IsSetIpAddressBasedRemoteInfoList()
        {
            return this._ipAddressBasedRemoteInfoList != null && this._ipAddressBasedRemoteInfoList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PipelineInfoList. 
        /// <para>
        /// The list of pipeline info configurations.
        /// </para>
        /// </summary>
        public List<PipelineInfo> PipelineInfoList
        {
            get { return this._pipelineInfoList; }
            set { this._pipelineInfoList = value; }
        }

        // Check to see if PipelineInfoList property is set
        internal bool IsSetPipelineInfoList()
        {
            return this._pipelineInfoList != null && this._pipelineInfoList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RemoteSourceCodeAnalysisServerInfo. 
        /// <para>
        /// Info about the remote server source code configuration.
        /// </para>
        /// </summary>
        public RemoteSourceCodeAnalysisServerInfo RemoteSourceCodeAnalysisServerInfo
        {
            get { return this._remoteSourceCodeAnalysisServerInfo; }
            set { this._remoteSourceCodeAnalysisServerInfo = value; }
        }

        // Check to see if RemoteSourceCodeAnalysisServerInfo property is set
        internal bool IsSetRemoteSourceCodeAnalysisServerInfo()
        {
            return this._remoteSourceCodeAnalysisServerInfo != null;
        }

        /// <summary>
        /// Gets and sets the property VcenterBasedRemoteInfoList. 
        /// <para>
        /// The list of vCenter configurations.
        /// </para>
        /// </summary>
        public List<VcenterBasedRemoteInfo> VcenterBasedRemoteInfoList
        {
            get { return this._vcenterBasedRemoteInfoList; }
            set { this._vcenterBasedRemoteInfoList = value; }
        }

        // Check to see if VcenterBasedRemoteInfoList property is set
        internal bool IsSetVcenterBasedRemoteInfoList()
        {
            return this._vcenterBasedRemoteInfoList != null && this._vcenterBasedRemoteInfoList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VersionControlInfoList. 
        /// <para>
        /// The list of the version control configurations.
        /// </para>
        /// </summary>
        public List<VersionControlInfo> VersionControlInfoList
        {
            get { return this._versionControlInfoList; }
            set { this._versionControlInfoList = value; }
        }

        // Check to see if VersionControlInfoList property is set
        internal bool IsSetVersionControlInfoList()
        {
            return this._versionControlInfoList != null && this._versionControlInfoList.Count > 0; 
        }

    }
}
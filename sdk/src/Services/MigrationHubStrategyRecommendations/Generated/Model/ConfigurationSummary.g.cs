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

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Summary of the collector configuration.
    /// </summary>
    public partial class ConfigurationSummary
    {
        /// <summary>
        /// Gets and sets the property IpAddressBasedRemoteInfoList. 
        /// <para>
        /// IP address based configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IPAddressBasedRemoteInfo> IpAddressBasedRemoteInfoList { get; set; } = AWSConfigs.InitializeCollections ? new List<IPAddressBasedRemoteInfo>() : null;

        /// <summary>
        /// Checks to see if the IpAddressBasedRemoteInfoList property is set.
        /// </summary>
        internal bool IsSetIpAddressBasedRemoteInfoList() => this.IpAddressBasedRemoteInfoList != null && (this.IpAddressBasedRemoteInfoList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PipelineInfoList. 
        /// <para>
        /// The list of pipeline info configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PipelineInfo> PipelineInfoList { get; set; } = AWSConfigs.InitializeCollections ? new List<PipelineInfo>() : null;

        /// <summary>
        /// Checks to see if the PipelineInfoList property is set.
        /// </summary>
        internal bool IsSetPipelineInfoList() => this.PipelineInfoList != null && (this.PipelineInfoList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RemoteSourceCodeAnalysisServerInfo. 
        /// <para>
        /// Info about the remote server source code configuration.
        /// </para>
        /// </summary>
        public RemoteSourceCodeAnalysisServerInfo RemoteSourceCodeAnalysisServerInfo { get; set; }

        /// <summary>
        /// Checks to see if the RemoteSourceCodeAnalysisServerInfo property is set.
        /// </summary>
        internal bool IsSetRemoteSourceCodeAnalysisServerInfo() => this.RemoteSourceCodeAnalysisServerInfo != null;

        /// <summary>
        /// Gets and sets the property VcenterBasedRemoteInfoList. 
        /// <para>
        /// The list of vCenter configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VcenterBasedRemoteInfo> VcenterBasedRemoteInfoList { get; set; } = AWSConfigs.InitializeCollections ? new List<VcenterBasedRemoteInfo>() : null;

        /// <summary>
        /// Checks to see if the VcenterBasedRemoteInfoList property is set.
        /// </summary>
        internal bool IsSetVcenterBasedRemoteInfoList() => this.VcenterBasedRemoteInfoList != null && (this.VcenterBasedRemoteInfoList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VersionControlInfoList. 
        /// <para>
        /// The list of the version control configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VersionControlInfo> VersionControlInfoList { get; set; } = AWSConfigs.InitializeCollections ? new List<VersionControlInfo>() : null;

        /// <summary>
        /// Checks to see if the VersionControlInfoList property is set.
        /// </summary>
        internal bool IsSetVersionControlInfoList() => this.VersionControlInfoList != null && (this.VersionControlInfoList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}

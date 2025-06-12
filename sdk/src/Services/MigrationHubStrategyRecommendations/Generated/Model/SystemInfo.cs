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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Information about the server that hosts application components.
    /// </summary>
    public partial class SystemInfo
    {
        private string _cpuArchitecture;
        private string _fileSystemType;
        private List<NetworkInfo> _networkInfoList = AWSConfigs.InitializeCollections ? new List<NetworkInfo>() : null;
        private OSInfo _osInfo;

        /// <summary>
        /// Gets and sets the property CpuArchitecture. 
        /// <para>
        ///  CPU architecture type for the server. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string CpuArchitecture
        {
            get { return this._cpuArchitecture; }
            set { this._cpuArchitecture = value; }
        }

        // Check to see if CpuArchitecture property is set
        internal bool IsSetCpuArchitecture()
        {
            return this._cpuArchitecture != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemType. 
        /// <para>
        ///  File system type for the server. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FileSystemType
        {
            get { return this._fileSystemType; }
            set { this._fileSystemType = value; }
        }

        // Check to see if FileSystemType property is set
        internal bool IsSetFileSystemType()
        {
            return this._fileSystemType != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInfoList. 
        /// <para>
        ///  Networking information related to a server. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NetworkInfo> NetworkInfoList
        {
            get { return this._networkInfoList; }
            set { this._networkInfoList = value; }
        }

        // Check to see if NetworkInfoList property is set
        internal bool IsSetNetworkInfoList()
        {
            return this._networkInfoList != null && (this._networkInfoList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OsInfo. 
        /// <para>
        ///  Operating system corresponding to a server. 
        /// </para>
        /// </summary>
        public OSInfo OsInfo
        {
            get { return this._osInfo; }
            set { this._osInfo = value; }
        }

        // Check to see if OsInfo property is set
        internal bool IsSetOsInfo()
        {
            return this._osInfo != null;
        }

    }
}
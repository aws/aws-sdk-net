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
    /// Information about the server configured for source code analysis.
    /// </summary>
    public partial class RemoteSourceCodeAnalysisServerInfo
    {
        private string _remoteSourceCodeAnalysisServerConfigurationTimestamp;

        /// <summary>
        /// Gets and sets the property RemoteSourceCodeAnalysisServerConfigurationTimestamp. 
        /// <para>
        /// The time when the remote source code server was configured.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string RemoteSourceCodeAnalysisServerConfigurationTimestamp
        {
            get { return this._remoteSourceCodeAnalysisServerConfigurationTimestamp; }
            set { this._remoteSourceCodeAnalysisServerConfigurationTimestamp = value; }
        }

        // Check to see if RemoteSourceCodeAnalysisServerConfigurationTimestamp property is set
        internal bool IsSetRemoteSourceCodeAnalysisServerConfigurationTimestamp()
        {
            return this._remoteSourceCodeAnalysisServerConfigurationTimestamp != null;
        }

    }
}
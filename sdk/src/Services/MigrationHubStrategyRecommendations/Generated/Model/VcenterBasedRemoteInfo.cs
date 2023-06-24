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
    /// Details about the server in vCenter.
    /// </summary>
    public partial class VcenterBasedRemoteInfo
    {
        private OSType _osType;
        private string _vcenterConfigurationTimeStamp;

        /// <summary>
        /// Gets and sets the property OsType. 
        /// <para>
        /// The type of the operating system.
        /// </para>
        /// </summary>
        public OSType OsType
        {
            get { return this._osType; }
            set { this._osType = value; }
        }

        // Check to see if OsType property is set
        internal bool IsSetOsType()
        {
            return this._osType != null;
        }

        /// <summary>
        /// Gets and sets the property VcenterConfigurationTimeStamp. 
        /// <para>
        /// The time when the remote server based on vCenter was last configured.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string VcenterConfigurationTimeStamp
        {
            get { return this._vcenterConfigurationTimeStamp; }
            set { this._vcenterConfigurationTimeStamp = value; }
        }

        // Check to see if VcenterConfigurationTimeStamp property is set
        internal bool IsSetVcenterConfigurationTimeStamp()
        {
            return this._vcenterConfigurationTimeStamp != null;
        }

    }
}
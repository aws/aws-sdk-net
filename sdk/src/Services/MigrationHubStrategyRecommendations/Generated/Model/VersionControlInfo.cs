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
    /// Details about the version control configuration.
    /// </summary>
    public partial class VersionControlInfo
    {
        private string _versionControlConfigurationTimeStamp;
        private VersionControlType _versionControlType;

        /// <summary>
        /// Gets and sets the property VersionControlConfigurationTimeStamp. 
        /// <para>
        /// The time when the version control system was last configured.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string VersionControlConfigurationTimeStamp
        {
            get { return this._versionControlConfigurationTimeStamp; }
            set { this._versionControlConfigurationTimeStamp = value; }
        }

        // Check to see if VersionControlConfigurationTimeStamp property is set
        internal bool IsSetVersionControlConfigurationTimeStamp()
        {
            return this._versionControlConfigurationTimeStamp != null;
        }

        /// <summary>
        /// Gets and sets the property VersionControlType. 
        /// <para>
        /// The type of version control.
        /// </para>
        /// </summary>
        public VersionControlType VersionControlType
        {
            get { return this._versionControlType; }
            set { this._versionControlType = value; }
        }

        // Check to see if VersionControlType property is set
        internal bool IsSetVersionControlType()
        {
            return this._versionControlType != null;
        }

    }
}
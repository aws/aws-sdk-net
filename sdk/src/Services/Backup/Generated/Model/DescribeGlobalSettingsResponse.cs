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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the DescribeGlobalSettings operation.
    /// </summary>
    public partial class DescribeGlobalSettingsResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _globalSettings = new Dictionary<string, string>();
        private DateTime? _lastUpdateTime;

        /// <summary>
        /// Gets and sets the property GlobalSettings. 
        /// <para>
        /// A list of resources along with the opt-in preferences for the account.
        /// </para>
        /// </summary>
        public Dictionary<string, string> GlobalSettings
        {
            get { return this._globalSettings; }
            set { this._globalSettings = value; }
        }

        // Check to see if GlobalSettings property is set
        internal bool IsSetGlobalSettings()
        {
            return this._globalSettings != null && this._globalSettings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The date and time that the global settings was last updated. This update is in Unix
        /// format and Coordinated Universal Time (UTC). The value of <code>LastUpdateTime</code>
        /// is accurate to milliseconds. For example, the value 1516925490.087 represents Friday,
        /// January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime LastUpdateTime
        {
            get { return this._lastUpdateTime.GetValueOrDefault(); }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

    }
}
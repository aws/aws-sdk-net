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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Panorama.Model
{
    /// <summary>
    /// Network time protocol (NTP) server settings. Use this option to connect to local NTP
    /// servers instead of <code>pool.ntp.org</code>.
    /// </summary>
    public partial class NtpPayload
    {
        private List<string> _ntpServers = new List<string>();

        /// <summary>
        /// Gets and sets the property NtpServers. 
        /// <para>
        /// NTP servers to use, in order of preference.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=5)]
        public List<string> NtpServers
        {
            get { return this._ntpServers; }
            set { this._ntpServers = value; }
        }

        // Check to see if NtpServers property is set
        internal bool IsSetNtpServers()
        {
            return this._ntpServers != null && this._ntpServers.Count > 0; 
        }

    }
}
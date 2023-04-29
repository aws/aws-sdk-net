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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// The network settings that DataSync Discovery uses to connect with your on-premises
    /// storage system's management interface.
    /// </summary>
    public partial class DiscoveryServerConfiguration
    {
        private string _serverHostname;
        private int? _serverPort;

        /// <summary>
        /// Gets and sets the property ServerHostname. 
        /// <para>
        /// The domain name or IP address of your storage system's management interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string ServerHostname
        {
            get { return this._serverHostname; }
            set { this._serverHostname = value; }
        }

        // Check to see if ServerHostname property is set
        internal bool IsSetServerHostname()
        {
            return this._serverHostname != null;
        }

        /// <summary>
        /// Gets and sets the property ServerPort. 
        /// <para>
        /// The network port for accessing the storage system's management interface.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public int ServerPort
        {
            get { return this._serverPort.GetValueOrDefault(); }
            set { this._serverPort = value; }
        }

        // Check to see if ServerPort property is set
        internal bool IsSetServerPort()
        {
            return this._serverPort.HasValue; 
        }

    }
}
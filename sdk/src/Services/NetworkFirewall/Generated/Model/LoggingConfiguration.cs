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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Defines how AWS Network Firewall performs logging for a <a>Firewall</a>.
    /// </summary>
    public partial class LoggingConfiguration
    {
        private List<LogDestinationConfig> _logDestinationConfigs = new List<LogDestinationConfig>();

        /// <summary>
        /// Gets and sets the property LogDestinationConfigs. 
        /// <para>
        /// Defines the logging destinations for the logs for a firewall. Network Firewall generates
        /// logs for stateful rule groups. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<LogDestinationConfig> LogDestinationConfigs
        {
            get { return this._logDestinationConfigs; }
            set { this._logDestinationConfigs = value; }
        }

        // Check to see if LogDestinationConfigs property is set
        internal bool IsSetLogDestinationConfigs()
        {
            return this._logDestinationConfigs != null && this._logDestinationConfigs.Count > 0; 
        }

    }
}
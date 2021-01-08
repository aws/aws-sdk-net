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
    /// Container for the parameters to the UpdateLoggingConfiguration operation.
    /// Sets the logging configuration for the specified firewall. 
    /// 
    ///  
    /// <para>
    /// To change the logging configuration, retrieve the <a>LoggingConfiguration</a> by calling
    /// <a>DescribeLoggingConfiguration</a>, then change it and provide the modified object
    /// to this update call. You must change the logging configuration one <a>LogDestinationConfig</a>
    /// at a time inside the retrieved <a>LoggingConfiguration</a> object. 
    /// </para>
    ///  
    /// <para>
    /// You can perform only one of the following actions in any call to <code>UpdateLoggingConfiguration</code>:
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Create a new log destination object by adding a single <code>LogDestinationConfig</code>
    /// array element to <code>LogDestinationConfigs</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Delete a log destination object by removing a single <code>LogDestinationConfig</code>
    /// array element from <code>LogDestinationConfigs</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Change the <code>LogDestination</code> setting in a single <code>LogDestinationConfig</code>
    /// array element.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can't change the <code>LogDestinationType</code> or <code>LogType</code> in a
    /// <code>LogDestinationConfig</code>. To change these settings, delete the existing <code>LogDestinationConfig</code>
    /// object and create a new one, using two separate calls to this update operation.
    /// </para>
    /// </summary>
    public partial class UpdateLoggingConfigurationRequest : AmazonNetworkFirewallRequest
    {
        private string _firewallArn;
        private string _firewallName;
        private LoggingConfiguration _loggingConfiguration;

        /// <summary>
        /// Gets and sets the property FirewallArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the firewall.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string FirewallArn
        {
            get { return this._firewallArn; }
            set { this._firewallArn = value; }
        }

        // Check to see if FirewallArn property is set
        internal bool IsSetFirewallArn()
        {
            return this._firewallArn != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallName. 
        /// <para>
        /// The descriptive name of the firewall. You can't change the name of a firewall after
        /// you create it.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string FirewallName
        {
            get { return this._firewallName; }
            set { this._firewallName = value; }
        }

        // Check to see if FirewallName property is set
        internal bool IsSetFirewallName()
        {
            return this._firewallName != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// Defines how Network Firewall performs logging for a firewall. If you omit this setting,
        /// Network Firewall disables logging for the firewall.
        /// </para>
        /// </summary>
        public LoggingConfiguration LoggingConfiguration
        {
            get { return this._loggingConfiguration; }
            set { this._loggingConfiguration = value; }
        }

        // Check to see if LoggingConfiguration property is set
        internal bool IsSetLoggingConfiguration()
        {
            return this._loggingConfiguration != null;
        }

    }
}
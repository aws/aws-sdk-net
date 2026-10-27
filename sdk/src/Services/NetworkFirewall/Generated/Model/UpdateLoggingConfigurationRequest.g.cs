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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLoggingConfiguration operation. Sets the
    /// logging configuration for the specified firewall. <para> To change the logging configuration,
    /// retrieve the <a>LoggingConfiguration</a> by calling <a>DescribeLoggingConfiguration</a>,
    /// then change it and provide the modified object to this update call. You must change
    /// the logging configuration one <a>LogDestinationConfig</a> at a time inside the retrieved
    /// <a>LoggingConfiguration</a> object. </para> <para> You can perform only one of the
    /// following actions in any call to <c>UpdateLoggingConfiguration</c>: </para> <ul> <li>
    /// <para> Create a new log destination object by adding a single <c>LogDestinationConfig</c>
    /// array element to <c>LogDestinationConfigs</c>. </para> </li> <li> <para> Delete a
    /// log destination object by removing a single <c>LogDestinationConfig</c> array element
    /// from <c>LogDestinationConfigs</c>. </para> </li> <li> <para> Change the <c>LogDestination</c>
    /// setting in a single <c>LogDestinationConfig</c> array element. </para> </li> </ul>
    /// <para> You can't change the <c>LogDestinationType</c> or <c>LogType</c> in a <c>LogDestinationConfig</c>.
    /// To change these settings, delete the existing <c>LogDestinationConfig</c> object and
    /// create a new one, using two separate calls to this update operation. </para>
    /// </summary>
    public partial class UpdateLoggingConfigurationRequest : AmazonNetworkFirewallRequest
    {
        /// <summary>
        /// Gets and sets the property EnableMonitoringDashboard. 
        /// <para>
        /// A boolean that lets you enable or disable the detailed firewall monitoring dashboard
        /// on the firewall. 
        /// </para>
        ///  
        /// <para>
        /// The monitoring dashboard provides comprehensive visibility into your firewall's flow
        /// logs and alert logs. After you enable detailed monitoring, you can access these dashboards
        /// directly from the <b>Monitoring</b> page of the Network Firewall console.
        /// </para>
        ///  
        /// <para>
        ///  Specify <c>TRUE</c> to enable the the detailed monitoring dashboard on the firewall.
        /// Specify <c>FALSE</c> to disable the the detailed monitoring dashboard on the firewall.
        /// 
        /// </para>
        /// </summary>
        public bool? EnableMonitoringDashboard { get; set; }

        /// <summary>
        /// Checks to see if the EnableMonitoringDashboard property is set.
        /// </summary>
        internal bool IsSetEnableMonitoringDashboard() => this.EnableMonitoringDashboard.HasValue;

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
        [AWSProperty(Min = 1, Max = 256)]
        public string FirewallArn { get; set; }

        /// <summary>
        /// Checks to see if the FirewallArn property is set.
        /// </summary>
        internal bool IsSetFirewallArn() => this.FirewallArn != null;

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
        [AWSProperty(Min = 1, Max = 128)]
        public string FirewallName { get; set; }

        /// <summary>
        /// Checks to see if the FirewallName property is set.
        /// </summary>
        internal bool IsSetFirewallName() => this.FirewallName != null;

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// Defines how Network Firewall performs logging for a firewall. If you omit this setting,
        /// Network Firewall disables logging for the firewall.
        /// </para>
        /// </summary>
        public LoggingConfiguration LoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetLoggingConfiguration() => this.LoggingConfiguration != null;
    }
}

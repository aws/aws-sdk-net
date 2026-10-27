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
    /// This is the response object from the UpdateLoggingConfiguration operation.
    /// </summary>
    public partial class UpdateLoggingConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EnableMonitoringDashboard. 
        /// <para>
        /// A boolean that reflects whether or not the firewall monitoring dashboard is enabled
        /// on a firewall.
        /// </para>
        ///  
        /// <para>
        ///  Returns <c>TRUE</c> when the firewall monitoring dashboard is enabled on the firewall.
        /// Returns <c>FALSE</c> when the firewall monitoring dashboard is not enabled on the
        /// firewall. 
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
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string FirewallName { get; set; }

        /// <summary>
        /// Checks to see if the FirewallName property is set.
        /// </summary>
        internal bool IsSetFirewallName() => this.FirewallName != null;

        /// <summary>
        /// Gets and sets the property LoggingConfiguration.
        /// </summary>
        public LoggingConfiguration LoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetLoggingConfiguration() => this.LoggingConfiguration != null;
    }
}

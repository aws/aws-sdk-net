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

namespace Amazon.MigrationHubOrchestrator.Model
{
    /// <summary>
    /// The summary of the Migration Hub Orchestrator plugin.
    /// </summary>
    public partial class PluginSummary
    {
        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The name of the host.
        /// </para>
        /// </summary>
        public string Hostname { get; set; }

        /// <summary>
        /// Checks to see if the Hostname property is set.
        /// </summary>
        internal bool IsSetHostname() => this.Hostname != null;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address at which the plugin is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property PluginId. 
        /// <para>
        /// The ID of the plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 60)]
        public string PluginId { get; set; }

        /// <summary>
        /// Checks to see if the PluginId property is set.
        /// </summary>
        internal bool IsSetPluginId() => this.PluginId != null;

        /// <summary>
        /// Gets and sets the property RegisteredTime. 
        /// <para>
        /// The time at which the plugin was registered.
        /// </para>
        /// </summary>
        public string RegisteredTime { get; set; }

        /// <summary>
        /// Checks to see if the RegisteredTime property is set.
        /// </summary>
        internal bool IsSetRegisteredTime() => this.RegisteredTime != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the plugin.
        /// </para>
        /// </summary>
        public PluginHealth Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}

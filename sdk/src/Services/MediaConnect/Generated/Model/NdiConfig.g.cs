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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Specifies the configuration settings for NDI sources and outputs.
    /// </summary>
    public partial class NdiConfig
    {
        /// <summary>
        /// Gets and sets the property MachineName. 
        /// <para>
        /// A prefix for the names of the NDI sources that the flow creates. If a custom name
        /// isn't specified, MediaConnect generates a unique 12-character ID as the prefix. 
        /// </para>
        /// </summary>
        public string MachineName { get; set; }

        /// <summary>
        /// Checks to see if the MachineName property is set.
        /// </summary>
        internal bool IsSetMachineName() => this.MachineName != null;

        /// <summary>
        /// Gets and sets the property NdiDiscoveryServers. 
        /// <para>
        /// A list of up to three NDI discovery server configurations. While not required by the
        /// API, this configuration is necessary for NDI functionality to work properly. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NdiDiscoveryServerConfig> NdiDiscoveryServers { get; set; } = AWSConfigs.InitializeCollections ? new List<NdiDiscoveryServerConfig>() : null;

        /// <summary>
        /// Checks to see if the NdiDiscoveryServers property is set.
        /// </summary>
        internal bool IsSetNdiDiscoveryServers() => this.NdiDiscoveryServers != null && (this.NdiDiscoveryServers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NdiState. 
        /// <para>
        /// A setting that controls whether NDI® sources or outputs can be used in the flow. 
        /// </para>
        ///  
        /// <para>
        ///  The default value is <c>DISABLED</c>. This value must be set as <c>ENABLED</c> for
        /// your flow to support NDI sources or outputs. 
        /// </para>
        /// </summary>
        public NdiState NdiState { get; set; }

        /// <summary>
        /// Checks to see if the NdiState property is set.
        /// </summary>
        internal bool IsSetNdiState() => this.NdiState != null;
    }
}

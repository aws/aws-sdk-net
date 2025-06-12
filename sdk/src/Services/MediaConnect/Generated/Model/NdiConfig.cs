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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
    /// Specifies the configuration settings for NDI outputs. Required when the flow includes
    /// NDI outputs.
    /// </summary>
    public partial class NdiConfig
    {
        private string _machineName;
        private List<NdiDiscoveryServerConfig> _ndiDiscoveryServers = AWSConfigs.InitializeCollections ? new List<NdiDiscoveryServerConfig>() : null;
        private NdiState _ndiState;

        /// <summary>
        /// Gets and sets the property MachineName. 
        /// <para>
        /// A prefix for the names of the NDI sources that the flow creates. If a custom name
        /// isn't specified, MediaConnect generates a unique 12-character ID as the prefix. 
        /// </para>
        /// </summary>
        public string MachineName
        {
            get { return this._machineName; }
            set { this._machineName = value; }
        }

        // Check to see if MachineName property is set
        internal bool IsSetMachineName()
        {
            return this._machineName != null;
        }

        /// <summary>
        /// Gets and sets the property NdiDiscoveryServers. 
        /// <para>
        /// A list of up to three NDI discovery server configurations. While not required by the
        /// API, this configuration is necessary for NDI functionality to work properly. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NdiDiscoveryServerConfig> NdiDiscoveryServers
        {
            get { return this._ndiDiscoveryServers; }
            set { this._ndiDiscoveryServers = value; }
        }

        // Check to see if NdiDiscoveryServers property is set
        internal bool IsSetNdiDiscoveryServers()
        {
            return this._ndiDiscoveryServers != null && (this._ndiDiscoveryServers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NdiState. 
        /// <para>
        /// A setting that controls whether NDI outputs can be used in the flow. Must be ENABLED
        /// to add NDI outputs. Default is DISABLED. 
        /// </para>
        /// </summary>
        public NdiState NdiState
        {
            get { return this._ndiState; }
            set { this._ndiState = value; }
        }

        // Check to see if NdiState property is set
        internal bool IsSetNdiState()
        {
            return this._ndiState != null;
        }

    }
}
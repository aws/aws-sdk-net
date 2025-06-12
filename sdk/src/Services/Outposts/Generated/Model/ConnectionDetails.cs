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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Information about a connection.
    /// </summary>
    public partial class ConnectionDetails
    {
        private List<string> _allowedIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clientPublicKey;
        private string _clientTunnelAddress;
        private string _serverEndpoint;
        private string _serverPublicKey;
        private string _serverTunnelAddress;

        /// <summary>
        /// Gets and sets the property AllowedIps. 
        /// <para>
        ///  The allowed IP addresses. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedIps
        {
            get { return this._allowedIps; }
            set { this._allowedIps = value; }
        }

        // Check to see if AllowedIps property is set
        internal bool IsSetAllowedIps()
        {
            return this._allowedIps != null && (this._allowedIps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientPublicKey. 
        /// <para>
        ///  The public key of the client. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=44, Max=44)]
        public string ClientPublicKey
        {
            get { return this._clientPublicKey; }
            set { this._clientPublicKey = value; }
        }

        // Check to see if ClientPublicKey property is set
        internal bool IsSetClientPublicKey()
        {
            return this._clientPublicKey != null;
        }

        /// <summary>
        /// Gets and sets the property ClientTunnelAddress. 
        /// <para>
        ///  The client tunnel address. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=9, Max=18)]
        public string ClientTunnelAddress
        {
            get { return this._clientTunnelAddress; }
            set { this._clientTunnelAddress = value; }
        }

        // Check to see if ClientTunnelAddress property is set
        internal bool IsSetClientTunnelAddress()
        {
            return this._clientTunnelAddress != null;
        }

        /// <summary>
        /// Gets and sets the property ServerEndpoint. 
        /// <para>
        ///  The endpoint for the server. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=9, Max=21)]
        public string ServerEndpoint
        {
            get { return this._serverEndpoint; }
            set { this._serverEndpoint = value; }
        }

        // Check to see if ServerEndpoint property is set
        internal bool IsSetServerEndpoint()
        {
            return this._serverEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ServerPublicKey. 
        /// <para>
        ///  The public key of the server. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=44, Max=44)]
        public string ServerPublicKey
        {
            get { return this._serverPublicKey; }
            set { this._serverPublicKey = value; }
        }

        // Check to see if ServerPublicKey property is set
        internal bool IsSetServerPublicKey()
        {
            return this._serverPublicKey != null;
        }

        /// <summary>
        /// Gets and sets the property ServerTunnelAddress. 
        /// <para>
        ///  The server tunnel address. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=9, Max=18)]
        public string ServerTunnelAddress
        {
            get { return this._serverTunnelAddress; }
            set { this._serverTunnelAddress = value; }
        }

        // Check to see if ServerTunnelAddress property is set
        internal bool IsSetServerTunnelAddress()
        {
            return this._serverTunnelAddress != null;
        }

    }
}
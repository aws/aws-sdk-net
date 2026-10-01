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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Information about a connection.
    /// </summary>
    public partial class ConnectionDetails
    {
        /// <summary>
        /// Gets and sets the property AllowedIps. 
        /// <para>
        ///  The allowed IP addresses. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedIps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedIps property is set.
        /// </summary>
        internal bool IsSetAllowedIps() => this.AllowedIps != null && (this.AllowedIps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientPublicKey. 
        /// <para>
        ///  The public key of the client. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 44, Max = 44)]
        public string ClientPublicKey { get; set; }

        /// <summary>
        /// Checks to see if the ClientPublicKey property is set.
        /// </summary>
        internal bool IsSetClientPublicKey() => this.ClientPublicKey != null;

        /// <summary>
        /// Gets and sets the property ClientTunnelAddress. 
        /// <para>
        ///  The client tunnel address. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 9, Max = 18)]
        public string ClientTunnelAddress { get; set; }

        /// <summary>
        /// Checks to see if the ClientTunnelAddress property is set.
        /// </summary>
        internal bool IsSetClientTunnelAddress() => this.ClientTunnelAddress != null;

        /// <summary>
        /// Gets and sets the property ServerEndpoint. 
        /// <para>
        ///  The endpoint for the server. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 9, Max = 21)]
        public string ServerEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ServerEndpoint property is set.
        /// </summary>
        internal bool IsSetServerEndpoint() => this.ServerEndpoint != null;

        /// <summary>
        /// Gets and sets the property ServerPublicKey. 
        /// <para>
        ///  The public key of the server. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 44, Max = 44)]
        public string ServerPublicKey { get; set; }

        /// <summary>
        /// Checks to see if the ServerPublicKey property is set.
        /// </summary>
        internal bool IsSetServerPublicKey() => this.ServerPublicKey != null;

        /// <summary>
        /// Gets and sets the property ServerTunnelAddress. 
        /// <para>
        ///  The server tunnel address. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 9, Max = 18)]
        public string ServerTunnelAddress { get; set; }

        /// <summary>
        /// Checks to see if the ServerTunnelAddress property is set.
        /// </summary>
        internal bool IsSetServerTunnelAddress() => this.ServerTunnelAddress != null;
    }
}

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

namespace Amazon.IoTSecureTunneling.Model
{
    /// <summary>
    /// Container for the parameters to the RotateTunnelAccessToken operation. Revokes the
    /// current client access token (CAT) and returns new CAT for clients to use when reconnecting
    /// to secure tunneling to access the same tunnel. <para> Requires permission to access
    /// the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">RotateTunnelAccessToken</a>
    /// action. </para> <note> <para> Rotating the CAT doesn't extend the tunnel duration.
    /// For example, say the tunnel duration is 12 hours and the tunnel has already been open
    /// for 4 hours. When you rotate the access tokens, the new tokens that are generated
    /// can only be used for the remaining 8 hours. </para> </note>
    /// </summary>
    public partial class RotateTunnelAccessTokenRequest : AmazonIoTSecureTunnelingRequest
    {
        /// <summary>
        /// Gets and sets the property ClientMode. 
        /// <para>
        /// The mode of the client that will use the client token, which can be either the source
        /// or destination, or both source and destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClientMode ClientMode { get; set; }

        /// <summary>
        /// Checks to see if the ClientMode property is set.
        /// </summary>
        internal bool IsSetClientMode() => this.ClientMode != null;

        /// <summary>
        /// Gets and sets the property DestinationConfig.
        /// </summary>
        public DestinationConfig DestinationConfig { get; set; }

        /// <summary>
        /// Checks to see if the DestinationConfig property is set.
        /// </summary>
        internal bool IsSetDestinationConfig() => this.DestinationConfig != null;

        /// <summary>
        /// Gets and sets the property TunnelId. 
        /// <para>
        /// The tunnel for which you want to rotate the access tokens.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TunnelId { get; set; }

        /// <summary>
        /// Checks to see if the TunnelId property is set.
        /// </summary>
        internal bool IsSetTunnelId() => this.TunnelId != null;
    }
}

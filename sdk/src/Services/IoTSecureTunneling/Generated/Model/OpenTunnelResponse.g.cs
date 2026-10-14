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
    /// This is the response object from the OpenTunnel operation.
    /// </summary>
    public partial class OpenTunnelResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DestinationAccessToken. 
        /// <para>
        /// The access token the destination local proxy uses to connect to IoT Secure Tunneling.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string DestinationAccessToken { get; set; }

        /// <summary>
        /// Checks to see if the DestinationAccessToken property is set.
        /// </summary>
        internal bool IsSetDestinationAccessToken() => this.DestinationAccessToken != null;

        /// <summary>
        /// Gets and sets the property SourceAccessToken. 
        /// <para>
        /// The access token the source local proxy uses to connect to IoT Secure Tunneling.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string SourceAccessToken { get; set; }

        /// <summary>
        /// Checks to see if the SourceAccessToken property is set.
        /// </summary>
        internal bool IsSetSourceAccessToken() => this.SourceAccessToken != null;

        /// <summary>
        /// Gets and sets the property TunnelArn. 
        /// <para>
        /// The Amazon Resource Name for the tunnel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string TunnelArn { get; set; }

        /// <summary>
        /// Checks to see if the TunnelArn property is set.
        /// </summary>
        internal bool IsSetTunnelArn() => this.TunnelArn != null;

        /// <summary>
        /// Gets and sets the property TunnelId. 
        /// <para>
        /// A unique alpha-numeric tunnel ID.
        /// </para>
        /// </summary>
        public string TunnelId { get; set; }

        /// <summary>
        /// Checks to see if the TunnelId property is set.
        /// </summary>
        internal bool IsSetTunnelId() => this.TunnelId != null;
    }
}

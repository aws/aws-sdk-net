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
 * Do not modify this file. This file is generated from the iotsecuretunneling-2018-10-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSecureTunneling.Model
{
    /// <summary>
    /// This is the response object from the OpenTunnel operation.
    /// </summary>
    public partial class OpenTunnelResponse : AmazonWebServiceResponse
    {
        private string _destinationAccessToken;
        private string _sourceAccessToken;
        private string _tunnelArn;
        private string _tunnelId;

        /// <summary>
        /// Gets and sets the property DestinationAccessToken. 
        /// <para>
        /// The access token the destination local proxy uses to connect to IoT Secure Tunneling.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string DestinationAccessToken
        {
            get { return this._destinationAccessToken; }
            set { this._destinationAccessToken = value; }
        }

        // Check to see if DestinationAccessToken property is set
        internal bool IsSetDestinationAccessToken()
        {
            return this._destinationAccessToken != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAccessToken. 
        /// <para>
        /// The access token the source local proxy uses to connect to IoT Secure Tunneling.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string SourceAccessToken
        {
            get { return this._sourceAccessToken; }
            set { this._sourceAccessToken = value; }
        }

        // Check to see if SourceAccessToken property is set
        internal bool IsSetSourceAccessToken()
        {
            return this._sourceAccessToken != null;
        }

        /// <summary>
        /// Gets and sets the property TunnelArn. 
        /// <para>
        /// The Amazon Resource Name for the tunnel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string TunnelArn
        {
            get { return this._tunnelArn; }
            set { this._tunnelArn = value; }
        }

        // Check to see if TunnelArn property is set
        internal bool IsSetTunnelArn()
        {
            return this._tunnelArn != null;
        }

        /// <summary>
        /// Gets and sets the property TunnelId. 
        /// <para>
        /// A unique alpha-numeric tunnel ID.
        /// </para>
        /// </summary>
        public string TunnelId
        {
            get { return this._tunnelId; }
            set { this._tunnelId = value; }
        }

        // Check to see if TunnelId property is set
        internal bool IsSetTunnelId()
        {
            return this._tunnelId != null;
        }

    }
}
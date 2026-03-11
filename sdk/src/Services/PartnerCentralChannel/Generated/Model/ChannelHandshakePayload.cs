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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
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
namespace Amazon.PartnerCentralChannel.Model
{
    /// <summary>
    /// Contains the payload data for different types of channel handshakes.
    /// </summary>
    public partial class ChannelHandshakePayload
    {
        private RevokeServicePeriodPayload _revokeServicePeriodPayload;
        private StartServicePeriodPayload _startServicePeriodPayload;

        /// <summary>
        /// Gets and sets the property RevokeServicePeriodPayload. 
        /// <para>
        /// Payload for revoking a service period handshake.
        /// </para>
        /// </summary>
        public RevokeServicePeriodPayload RevokeServicePeriodPayload
        {
            get { return this._revokeServicePeriodPayload; }
            set { this._revokeServicePeriodPayload = value; }
        }

        // Check to see if RevokeServicePeriodPayload property is set
        internal bool IsSetRevokeServicePeriodPayload()
        {
            return this._revokeServicePeriodPayload != null;
        }

        /// <summary>
        /// Gets and sets the property StartServicePeriodPayload. 
        /// <para>
        /// Payload for starting a service period handshake.
        /// </para>
        /// </summary>
        public StartServicePeriodPayload StartServicePeriodPayload
        {
            get { return this._startServicePeriodPayload; }
            set { this._startServicePeriodPayload = value; }
        }

        // Check to see if StartServicePeriodPayload property is set
        internal bool IsSetStartServicePeriodPayload()
        {
            return this._startServicePeriodPayload != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BackupGateway.Model
{
    /// <summary>
    /// A gateway is an Backup Gateway appliance that runs on the customer's network to provide
    /// seamless connectivity to backup storage in the Amazon Web Services Cloud.
    /// </summary>
    public partial class Gateway
    {
        private string _gatewayArn;
        private string _gatewayDisplayName;
        private GatewayType _gatewayType;
        private string _hypervisorId;
        private DateTime? _lastSeenTime;

        /// <summary>
        /// Gets and sets the property GatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway. Use the <code>ListGateways</code> operation
        /// to return a list of gateways for your account and Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string GatewayArn
        {
            get { return this._gatewayArn; }
            set { this._gatewayArn = value; }
        }

        // Check to see if GatewayArn property is set
        internal bool IsSetGatewayArn()
        {
            return this._gatewayArn != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayDisplayName. 
        /// <para>
        /// The display name of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string GatewayDisplayName
        {
            get { return this._gatewayDisplayName; }
            set { this._gatewayDisplayName = value; }
        }

        // Check to see if GatewayDisplayName property is set
        internal bool IsSetGatewayDisplayName()
        {
            return this._gatewayDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayType. 
        /// <para>
        /// The type of the gateway.
        /// </para>
        /// </summary>
        public GatewayType GatewayType
        {
            get { return this._gatewayType; }
            set { this._gatewayType = value; }
        }

        // Check to see if GatewayType property is set
        internal bool IsSetGatewayType()
        {
            return this._gatewayType != null;
        }

        /// <summary>
        /// Gets and sets the property HypervisorId. 
        /// <para>
        /// The hypervisor ID of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string HypervisorId
        {
            get { return this._hypervisorId; }
            set { this._hypervisorId = value; }
        }

        // Check to see if HypervisorId property is set
        internal bool IsSetHypervisorId()
        {
            return this._hypervisorId != null;
        }

        /// <summary>
        /// Gets and sets the property LastSeenTime. 
        /// <para>
        /// The last time Backup gateway communicated with the gateway, in Unix format and UTC
        /// time.
        /// </para>
        /// </summary>
        public DateTime LastSeenTime
        {
            get { return this._lastSeenTime.GetValueOrDefault(); }
            set { this._lastSeenTime = value; }
        }

        // Check to see if LastSeenTime property is set
        internal bool IsSetLastSeenTime()
        {
            return this._lastSeenTime.HasValue; 
        }

    }
}
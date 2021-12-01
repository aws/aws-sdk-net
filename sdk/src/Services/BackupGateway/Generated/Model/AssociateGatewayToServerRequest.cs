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
    /// Container for the parameters to the AssociateGatewayToServer operation.
    /// Associates a backup gateway with your server. After you complete the association process,
    /// you can back up and restore your VMs through the gateway.
    /// </summary>
    public partial class AssociateGatewayToServerRequest : AmazonBackupGatewayRequest
    {
        private string _gatewayArn;
        private string _serverArn;

        /// <summary>
        /// Gets and sets the property GatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway. Use the <code>ListGateways</code> operation
        /// to return a list of gateways for your account and Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
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
        /// Gets and sets the property ServerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the server that hosts your virtual machines.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string ServerArn
        {
            get { return this._serverArn; }
            set { this._serverArn = value; }
        }

        // Check to see if ServerArn property is set
        internal bool IsSetServerArn()
        {
            return this._serverArn != null;
        }

    }
}
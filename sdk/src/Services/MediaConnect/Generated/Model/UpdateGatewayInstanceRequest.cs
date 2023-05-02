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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateGatewayInstance operation.
    /// Updates the configuration of an existing Gateway Instance.
    /// </summary>
    public partial class UpdateGatewayInstanceRequest : AmazonMediaConnectRequest
    {
        private BridgePlacement _bridgePlacement;
        private string _gatewayInstanceArn;

        /// <summary>
        /// Gets and sets the property BridgePlacement. The availability of the instance to host
        /// new bridges. The bridgePlacement property can be LOCKED or AVAILABLE. If it is LOCKED,
        /// no new bridges can be deployed to this instance. If it is AVAILABLE, new bridges can
        /// be added to this instance.
        /// </summary>
        public BridgePlacement BridgePlacement
        {
            get { return this._bridgePlacement; }
            set { this._bridgePlacement = value; }
        }

        // Check to see if BridgePlacement property is set
        internal bool IsSetBridgePlacement()
        {
            return this._bridgePlacement != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayInstanceArn. The Amazon Resource Name (ARN) of the
        /// instance that you want to update.
        /// </summary>
        [AWSProperty(Required=true)]
        public string GatewayInstanceArn
        {
            get { return this._gatewayInstanceArn; }
            set { this._gatewayInstanceArn = value; }
        }

        // Check to see if GatewayInstanceArn property is set
        internal bool IsSetGatewayInstanceArn()
        {
            return this._gatewayInstanceArn != null;
        }

    }
}
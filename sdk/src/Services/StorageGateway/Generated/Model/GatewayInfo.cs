/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Describes a gateway object.
    /// </summary>
    public partial class GatewayInfo
    {
        private string _gatewayARN;
        private string _gatewayId;
        private string _gatewayName;
        private string _gatewayOperationalState;
        private string _gatewayType;

        /// <summary>
        /// Gets and sets the property GatewayARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway. Use the <a>ListGateways</a> operation
        /// to return a list of gateways for your account and region.
        /// </para>
        /// </summary>
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The unique identifier assigned to your gateway during activation. This ID becomes
        /// part of the gateway Amazon Resource Name (ARN), which you use as input for other operations.
        /// </para>
        /// </summary>
        public string GatewayId
        {
            get { return this._gatewayId; }
            set { this._gatewayId = value; }
        }

        // Check to see if GatewayId property is set
        internal bool IsSetGatewayId()
        {
            return this._gatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayName. 
        /// <para>
        /// The name of the gateway.
        /// </para>
        /// </summary>
        public string GatewayName
        {
            get { return this._gatewayName; }
            set { this._gatewayName = value; }
        }

        // Check to see if GatewayName property is set
        internal bool IsSetGatewayName()
        {
            return this._gatewayName != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayOperationalState. 
        /// <para>
        /// The state of the gateway.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: DISABLED or ACTIVE
        /// </para>
        /// </summary>
        public string GatewayOperationalState
        {
            get { return this._gatewayOperationalState; }
            set { this._gatewayOperationalState = value; }
        }

        // Check to see if GatewayOperationalState property is set
        internal bool IsSetGatewayOperationalState()
        {
            return this._gatewayOperationalState != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayType. 
        /// <para>
        /// The type of the gateway.
        /// </para>
        /// </summary>
        public string GatewayType
        {
            get { return this._gatewayType; }
            set { this._gatewayType = value; }
        }

        // Check to see if GatewayType property is set
        internal bool IsSetGatewayType()
        {
            return this._gatewayType != null;
        }

    }
}
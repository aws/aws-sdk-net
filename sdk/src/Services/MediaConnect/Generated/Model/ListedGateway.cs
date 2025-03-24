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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// A summary of a gateway, including its name, ARN, and status.
    /// </summary>
    public partial class ListedGateway
    {
        private string _gatewayArn;
        private GatewayState _gatewayState;
        private string _name;

        /// <summary>
        /// Gets and sets the property GatewayArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property GatewayState. 
        /// <para>
        ///  The status of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GatewayState GatewayState
        {
            get { return this._gatewayState; }
            set { this._gatewayState = value; }
        }

        // Check to see if GatewayState property is set
        internal bool IsSetGatewayState()
        {
            return this._gatewayState != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}
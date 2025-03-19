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
    /// This is the response object from the DeregisterGatewayInstance operation.
    /// </summary>
    public partial class DeregisterGatewayInstanceResponse : AmazonWebServiceResponse
    {
        private string _gatewayInstanceArn;
        private InstanceState _instanceState;

        /// <summary>
        /// Gets and sets the property GatewayInstanceArn. 
        /// <para>
        ///  The ARN of the instance.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property InstanceState. 
        /// <para>
        ///  The status of the instance.
        /// </para>
        /// </summary>
        public InstanceState InstanceState
        {
            get { return this._instanceState; }
            set { this._instanceState = value; }
        }

        // Check to see if InstanceState property is set
        internal bool IsSetInstanceState()
        {
            return this._instanceState != null;
        }

    }
}
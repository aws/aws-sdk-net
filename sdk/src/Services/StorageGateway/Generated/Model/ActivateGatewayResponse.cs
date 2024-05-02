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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Storage Gateway returns the Amazon Resource Name (ARN) of the activated gateway. It
    /// is a string made of information such as your account, gateway name, and Amazon Web
    /// Services Region. This ARN is used to reference the gateway in other API operations
    /// as well as resource-based authorization.
    /// 
    ///  <note> 
    /// <para>
    /// For gateways activated prior to September 02, 2015, the gateway ARN contains the gateway
    /// name rather than the gateway ID. Changing the name of the gateway has no effect on
    /// the gateway ARN.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ActivateGatewayResponse : AmazonWebServiceResponse
    {
        private string _gatewayARN;

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
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

    }
}
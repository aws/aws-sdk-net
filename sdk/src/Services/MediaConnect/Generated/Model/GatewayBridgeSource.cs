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
    /// The source configuration for cloud flows receiving a stream from a bridge.
    /// </summary>
    public partial class GatewayBridgeSource
    {
        private string _bridgeArn;
        private VpcInterfaceAttachment _vpcInterfaceAttachment;

        /// <summary>
        /// Gets and sets the property BridgeArn. 
        /// <para>
        ///  The ARN of the bridge feeding this flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BridgeArn
        {
            get { return this._bridgeArn; }
            set { this._bridgeArn = value; }
        }

        // Check to see if BridgeArn property is set
        internal bool IsSetBridgeArn()
        {
            return this._bridgeArn != null;
        }

        /// <summary>
        /// Gets and sets the property VpcInterfaceAttachment. 
        /// <para>
        ///  The name of the VPC interface attachment to use for this bridge source.
        /// </para>
        /// </summary>
        public VpcInterfaceAttachment VpcInterfaceAttachment
        {
            get { return this._vpcInterfaceAttachment; }
            set { this._vpcInterfaceAttachment = value; }
        }

        // Check to see if VpcInterfaceAttachment property is set
        internal bool IsSetVpcInterfaceAttachment()
        {
            return this._vpcInterfaceAttachment != null;
        }

    }
}
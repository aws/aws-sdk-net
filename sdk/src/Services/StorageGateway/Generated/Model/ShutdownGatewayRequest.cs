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
    /// Container for the parameters to the ShutdownGateway operation.
    /// Shuts down a gateway. To specify which gateway to shut down, use the Amazon Resource
    /// Name (ARN) of the gateway in the body of your request.
    /// 
    ///  
    /// <para>
    /// The operation shuts down the gateway service component running in the storage gateway's
    /// virtual machine (VM) and not the VM.
    /// </para>
    ///  <note>
    /// <para>
    /// If you want to shut down the VM, it is recommended that you first shut down the gateway
    /// component in the VM to avoid unpredictable conditions.
    /// </para>
    ///  </note> 
    /// <para>
    /// After the gateway is shutdown, you cannot call any other API except <a>StartGateway</a>,
    /// <a>DescribeGatewayInformation</a>, and <a>ListGateways</a>. For more information,
    /// see <a>ActivateGateway</a>. Your applications cannot read from or write to the gateway's
    /// storage volumes, and there are no snapshots taken.
    /// </para>
    ///  <note>
    /// <para>
    /// When you make a shutdown request, you will get a <code>200 OK</code> success response
    /// immediately. However, it might take some time for the gateway to shut down. You can
    /// call the <a>DescribeGatewayInformation</a> API to check the status. For more information,
    /// see <a>ActivateGateway</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// If do not intend to use the gateway again, you must delete the gateway (using <a>DeleteGateway</a>)
    /// to no longer pay software charges associated with the gateway.
    /// </para>
    /// </summary>
    public partial class ShutdownGatewayRequest : AmazonStorageGatewayRequest
    {
        private string _gatewayARN;

        /// <summary>
        /// Gets and sets the property GatewayARN.
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

    }
}
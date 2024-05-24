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
    /// Container for the parameters to the StartGateway operation.
    /// Starts a gateway that you previously shut down (see <a>ShutdownGateway</a>). After
    /// the gateway starts, you can then make other API calls, your applications can read
    /// from or write to the gateway's storage volumes and you will be able to take snapshot
    /// backups.
    /// 
    ///  <note> 
    /// <para>
    /// When you make a request, you will get a 200 OK success response immediately. However,
    /// it might take some time for the gateway to be ready. You should call <a>DescribeGatewayInformation</a>
    /// and check the status before making any additional API calls. For more information,
    /// see <a>ActivateGateway</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// To specify which gateway to start, use the Amazon Resource Name (ARN) of the gateway
    /// in your request.
    /// </para>
    /// </summary>
    public partial class StartGatewayRequest : AmazonStorageGatewayRequest
    {
        private string _gatewayARN;

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
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
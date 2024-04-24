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
 * Do not modify this file. This file is generated from the iotsecuretunneling-2018-10-05.normal.json service model.
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
namespace Amazon.IoTSecureTunneling.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeTunnel operation.
    /// Gets information about a tunnel identified by the unique tunnel id.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeTunnel</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class DescribeTunnelRequest : AmazonIoTSecureTunnelingRequest
    {
        private string _tunnelId;

        /// <summary>
        /// Gets and sets the property TunnelId. 
        /// <para>
        /// The tunnel to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TunnelId
        {
            get { return this._tunnelId; }
            set { this._tunnelId = value; }
        }

        // Check to see if TunnelId property is set
        internal bool IsSetTunnelId()
        {
            return this._tunnelId != null;
        }

    }
}
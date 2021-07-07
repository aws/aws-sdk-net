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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Specifies network configuration information for the gateway associated with the Amazon
    /// FSx file system.
    /// </summary>
    public partial class EndpointNetworkConfiguration
    {
        private List<string> _ipAddresses = new List<string>();

        /// <summary>
        /// Gets and sets the property IpAddresses. 
        /// <para>
        /// A list of gateway IP addresses on which the associated Amazon FSx file system is available.
        /// </para>
        ///  <note> 
        /// <para>
        /// If multiple file systems are associated with this gateway, this field is required.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> IpAddresses
        {
            get { return this._ipAddresses; }
            set { this._ipAddresses = value; }
        }

        // Check to see if IpAddresses property is set
        internal bool IsSetIpAddresses()
        {
            return this._ipAddresses != null && this._ipAddresses.Count > 0; 
        }

    }
}
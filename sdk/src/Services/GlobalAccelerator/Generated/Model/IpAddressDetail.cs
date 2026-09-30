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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
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
namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Detailed information for the IP addresses assigned to the Global Accelerator.
    /// </summary>
    public partial class IpAddressDetail
    {
        private string _ipAddress;
        private string _networkZone;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The static IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Max=45)]
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkZone. 
        /// <para>
        /// The network zone that the specified IP address is located on.
        /// </para>
        /// </summary>
        [AWSProperty(Max=24)]
        public string NetworkZone
        {
            get { return this._networkZone; }
            set { this._networkZone = value; }
        }

        // Check to see if NetworkZone property is set
        internal bool IsSetNetworkZone()
        {
            return this._networkZone != null;
        }

    }
}
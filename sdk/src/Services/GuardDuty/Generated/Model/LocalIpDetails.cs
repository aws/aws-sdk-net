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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the local IP address of the connection.
    /// </summary>
    public partial class LocalIpDetails
    {
        private string _ipAddressV4;
        private string _ipAddressV6;

        /// <summary>
        /// Gets and sets the property IpAddressV4. 
        /// <para>
        /// The IPv4 local address of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string IpAddressV4
        {
            get { return this._ipAddressV4; }
            set { this._ipAddressV4 = value; }
        }

        // Check to see if IpAddressV4 property is set
        internal bool IsSetIpAddressV4()
        {
            return this._ipAddressV4 != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddressV6. 
        /// <para>
        /// The IPv6 local address of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string IpAddressV6
        {
            get { return this._ipAddressV6; }
            set { this._ipAddressV6 = value; }
        }

        // Check to see if IpAddressV6 property is set
        internal bool IsSetIpAddressV6()
        {
            return this._ipAddressV6 != null;
        }

    }
}
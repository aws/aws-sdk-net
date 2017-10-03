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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The tunnel options for a VPN connection.
    /// </summary>
    public partial class VpnTunnelOptionsSpecification
    {
        private string _preSharedKey;
        private string _tunnelInsideCidr;

        /// <summary>
        /// Gets and sets the property PreSharedKey. 
        /// <para>
        /// The pre-shared key (PSK) to establish initial authentication between the virtual private
        /// gateway and customer gateway.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Allowed characters are alphanumeric characters and ._. Must be between
        /// 8 and 64 characters in length and cannot start with zero (0).
        /// </para>
        /// </summary>
        public string PreSharedKey
        {
            get { return this._preSharedKey; }
            set { this._preSharedKey = value; }
        }

        // Check to see if PreSharedKey property is set
        internal bool IsSetPreSharedKey()
        {
            return this._preSharedKey != null;
        }

        /// <summary>
        /// Gets and sets the property TunnelInsideCidr. 
        /// <para>
        /// The range of inside IP addresses for the tunnel. Any specified CIDR blocks must be
        /// unique across all VPN connections that use the same virtual private gateway. 
        /// </para>
        ///  
        /// <para>
        /// Constraints: A size /30 CIDR block from the <code>169.254.0.0/16</code> range. The
        /// following CIDR blocks are reserved and cannot be used:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>169.254.0.0/30</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>169.254.1.0/30</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>169.254.2.0/30</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>169.254.3.0/30</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>169.254.4.0/30</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>169.254.5.0/30</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>169.254.169.252/30</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string TunnelInsideCidr
        {
            get { return this._tunnelInsideCidr; }
            set { this._tunnelInsideCidr = value; }
        }

        // Check to see if TunnelInsideCidr property is set
        internal bool IsSetTunnelInsideCidr()
        {
            return this._tunnelInsideCidr != null;
        }

    }
}
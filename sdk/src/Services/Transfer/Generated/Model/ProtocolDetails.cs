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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// The protocol settings that are configured for your server. 
    /// 
    ///  <note> 
    /// <para>
    ///  This type is only valid in the <code>UpdateServer</code> API. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ProtocolDetails
    {
        private string _passiveIp;

        /// <summary>
        /// Gets and sets the property PassiveIp. 
        /// <para>
        ///  Indicates passive mode, for FTP and FTPS protocols. Enter a single dotted-quad IPv4
        /// address, such as the external IP address of a firewall, router, or load balancer.
        /// For example: 
        /// </para>
        ///  
        /// <para>
        ///  <code> aws transfer update-server --protocol-details PassiveIp=<i>0.0.0.0</i> </code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Replace <code> <i>0.0.0.0</i> </code> in the example above with the actual IP address
        /// you want to use.
        /// </para>
        /// </summary>
        [AWSProperty(Max=15)]
        public string PassiveIp
        {
            get { return this._passiveIp; }
            set { this._passiveIp = value; }
        }

        // Check to see if PassiveIp property is set
        internal bool IsSetPassiveIp()
        {
            return this._passiveIp != null;
        }

    }
}
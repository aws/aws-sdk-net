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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DeprovisionByoipCidr operation.
    /// Releases the specified address range that you provisioned for use with your AWS resources
    /// through bring your own IP addresses (BYOIP) and deletes the corresponding address
    /// pool.
    /// 
    ///  
    /// <para>
    /// Before you can release an address range, you must stop advertising it using <a>WithdrawByoipCidr</a>
    /// and you must not have any IP addresses allocated from its address range.
    /// </para>
    /// </summary>
    public partial class DeprovisionByoipCidrRequest : AmazonEC2Request
    {
        private string _cidr;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The address range, in CIDR notation. The prefix must be the same prefix that you specified
        /// when you provisioned the address range.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Cidr
        {
            get { return this._cidr; }
            set { this._cidr = value; }
        }

        // Check to see if Cidr property is set
        internal bool IsSetCidr()
        {
            return this._cidr != null;
        }

    }
}
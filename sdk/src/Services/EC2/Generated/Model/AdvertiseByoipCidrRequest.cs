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
    /// Container for the parameters to the AdvertiseByoipCidr operation.
    /// Advertises an IPv4 address range that is provisioned for use with your AWS resources
    /// through bring your own IP addresses (BYOIP).
    /// 
    ///  
    /// <para>
    /// You can perform this operation at most once every 10 seconds, even if you specify
    /// different address ranges each time.
    /// </para>
    ///  
    /// <para>
    /// We recommend that you stop advertising the BYOIP CIDR from other locations when you
    /// advertise it from AWS. To minimize down time, you can configure your AWS resources
    /// to use an address from a BYOIP CIDR before it is advertised, and then simultaneously
    /// stop advertising it from the current location and start advertising it through AWS.
    /// </para>
    ///  
    /// <para>
    /// It can take a few minutes before traffic to the specified addresses starts routing
    /// to AWS because of BGP propagation delays.
    /// </para>
    ///  
    /// <para>
    /// To stop advertising the BYOIP CIDR, use <a>WithdrawByoipCidr</a>.
    /// </para>
    /// </summary>
    public partial class AdvertiseByoipCidrRequest : AmazonEC2Request
    {
        private string _cidr;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The IPv4 address range, in CIDR notation.
        /// </para>
        /// </summary>
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
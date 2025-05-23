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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the IPv6 prefix option for a network interface.
    /// </summary>
    public partial class Ipv6PrefixSpecificationRequest
    {
        private string _ipv6Prefix;

        /// <summary>
        /// Gets and sets the property Ipv6Prefix. 
        /// <para>
        /// The IPv6 prefix.
        /// </para>
        /// </summary>
        public string Ipv6Prefix
        {
            get { return this._ipv6Prefix; }
            set { this._ipv6Prefix = value; }
        }

        // Check to see if Ipv6Prefix property is set
        internal bool IsSetIpv6Prefix()
        {
            return this._ipv6Prefix != null;
        }

    }
}
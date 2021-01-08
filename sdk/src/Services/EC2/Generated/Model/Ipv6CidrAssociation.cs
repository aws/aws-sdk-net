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
    /// Describes an IPv6 CIDR block association.
    /// </summary>
    public partial class Ipv6CidrAssociation
    {
        private string _associatedResource;
        private string _ipv6Cidr;

        /// <summary>
        /// Gets and sets the property AssociatedResource. 
        /// <para>
        /// The resource that's associated with the IPv6 CIDR block.
        /// </para>
        /// </summary>
        public string AssociatedResource
        {
            get { return this._associatedResource; }
            set { this._associatedResource = value; }
        }

        // Check to see if AssociatedResource property is set
        internal bool IsSetAssociatedResource()
        {
            return this._associatedResource != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6Cidr. 
        /// <para>
        /// The IPv6 CIDR block.
        /// </para>
        /// </summary>
        public string Ipv6Cidr
        {
            get { return this._ipv6Cidr; }
            set { this._ipv6Cidr = value; }
        }

        // Check to see if Ipv6Cidr property is set
        internal bool IsSetIpv6Cidr()
        {
            return this._ipv6Cidr != null;
        }

    }
}
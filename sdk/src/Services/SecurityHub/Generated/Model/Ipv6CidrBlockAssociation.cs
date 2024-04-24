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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// An IPV6 CIDR block association.
    /// </summary>
    public partial class Ipv6CidrBlockAssociation
    {
        private string _associationId;
        private string _cidrBlockState;
        private string _ipv6CidrBlock;

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The association ID for the IPv6 CIDR block.
        /// </para>
        /// </summary>
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property CidrBlockState. 
        /// <para>
        /// Information about the state of the CIDR block. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>associating</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>associated</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>disassociating</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>disassociated</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failing</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string CidrBlockState
        {
            get { return this._cidrBlockState; }
            set { this._cidrBlockState = value; }
        }

        // Check to see if CidrBlockState property is set
        internal bool IsSetCidrBlockState()
        {
            return this._cidrBlockState != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlock. 
        /// <para>
        /// The IPv6 CIDR block.
        /// </para>
        /// </summary>
        public string Ipv6CidrBlock
        {
            get { return this._ipv6CidrBlock; }
            set { this._ipv6CidrBlock = value; }
        }

        // Check to see if Ipv6CidrBlock property is set
        internal bool IsSetIpv6CidrBlock()
        {
            return this._ipv6CidrBlock != null;
        }

    }
}
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
    /// Describes an IPv4 CIDR block associated with a VPC.
    /// </summary>
    public partial class VpcCidrBlockAssociation
    {
        private string _associationId;
        private string _cidrBlock;
        private VpcCidrBlockState _cidrBlockState;

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The association ID for the IPv4 CIDR block.
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
        /// Gets and sets the property CidrBlock. 
        /// <para>
        /// The IPv4 CIDR block.
        /// </para>
        /// </summary>
        public string CidrBlock
        {
            get { return this._cidrBlock; }
            set { this._cidrBlock = value; }
        }

        // Check to see if CidrBlock property is set
        internal bool IsSetCidrBlock()
        {
            return this._cidrBlock != null;
        }

        /// <summary>
        /// Gets and sets the property CidrBlockState. 
        /// <para>
        /// Information about the state of the CIDR block.
        /// </para>
        /// </summary>
        public VpcCidrBlockState CidrBlockState
        {
            get { return this._cidrBlockState; }
            set { this._cidrBlockState = value; }
        }

        // Check to see if CidrBlockState property is set
        internal bool IsSetCidrBlockState()
        {
            return this._cidrBlockState != null;
        }

    }
}
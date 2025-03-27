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
    /// 
    /// </summary>
    public partial class VpcEncryptionControlExclusions
    {
        private VpcEncryptionControlExclusion _egressOnlyInternetGateway;
        private VpcEncryptionControlExclusion _internetGateway;
        private VpcEncryptionControlExclusion _natGateway;
        private VpcEncryptionControlExclusion _virtualPrivateGateway;
        private VpcEncryptionControlExclusion _vpcPeering;

        /// <summary>
        /// Gets and sets the property EgressOnlyInternetGateway.
        /// </summary>
        public VpcEncryptionControlExclusion EgressOnlyInternetGateway
        {
            get { return this._egressOnlyInternetGateway; }
            set { this._egressOnlyInternetGateway = value; }
        }

        // Check to see if EgressOnlyInternetGateway property is set
        internal bool IsSetEgressOnlyInternetGateway()
        {
            return this._egressOnlyInternetGateway != null;
        }

        /// <summary>
        /// Gets and sets the property InternetGateway.
        /// </summary>
        public VpcEncryptionControlExclusion InternetGateway
        {
            get { return this._internetGateway; }
            set { this._internetGateway = value; }
        }

        // Check to see if InternetGateway property is set
        internal bool IsSetInternetGateway()
        {
            return this._internetGateway != null;
        }

        /// <summary>
        /// Gets and sets the property NatGateway.
        /// </summary>
        public VpcEncryptionControlExclusion NatGateway
        {
            get { return this._natGateway; }
            set { this._natGateway = value; }
        }

        // Check to see if NatGateway property is set
        internal bool IsSetNatGateway()
        {
            return this._natGateway != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualPrivateGateway.
        /// </summary>
        public VpcEncryptionControlExclusion VirtualPrivateGateway
        {
            get { return this._virtualPrivateGateway; }
            set { this._virtualPrivateGateway = value; }
        }

        // Check to see if VirtualPrivateGateway property is set
        internal bool IsSetVirtualPrivateGateway()
        {
            return this._virtualPrivateGateway != null;
        }

        /// <summary>
        /// Gets and sets the property VpcPeering.
        /// </summary>
        public VpcEncryptionControlExclusion VpcPeering
        {
            get { return this._vpcPeering; }
            set { this._vpcPeering = value; }
        }

        // Check to see if VpcPeering property is set
        internal bool IsSetVpcPeering()
        {
            return this._vpcPeering != null;
        }

    }
}
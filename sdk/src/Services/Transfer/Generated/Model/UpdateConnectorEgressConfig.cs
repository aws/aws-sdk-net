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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Structure for updating the egress configuration of an existing connector. Allows modification
    /// of how traffic is routed from the connector to the SFTP server, including VPC_LATTICE
    /// settings.
    /// </summary>
    public partial class UpdateConnectorEgressConfig
    {
        private UpdateConnectorVpcLatticeEgressConfig _vpcLattice;

        /// <summary>
        /// Gets and sets the property VpcLattice. 
        /// <para>
        /// VPC_LATTICE configuration updates for the connector. Use this to modify the Resource
        /// Configuration ARN or port number for VPC-based connectivity.
        /// </para>
        /// </summary>
        public UpdateConnectorVpcLatticeEgressConfig VpcLattice
        {
            get { return this._vpcLattice; }
            set { this._vpcLattice = value; }
        }

        // Check to see if VpcLattice property is set
        internal bool IsSetVpcLattice()
        {
            return this._vpcLattice != null;
        }

    }
}
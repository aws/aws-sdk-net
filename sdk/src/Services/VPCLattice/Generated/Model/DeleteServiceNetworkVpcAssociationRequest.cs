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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteServiceNetworkVpcAssociation operation.
    /// Disassociates the VPC from the service network. You can't disassociate the VPC if
    /// there is a create or update association in progress.
    /// </summary>
    public partial class DeleteServiceNetworkVpcAssociationRequest : AmazonVPCLatticeRequest
    {
        private string _serviceNetworkVpcAssociationIdentifier;

        /// <summary>
        /// Gets and sets the property ServiceNetworkVpcAssociationIdentifier. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=17, Max=2048)]
        public string ServiceNetworkVpcAssociationIdentifier
        {
            get { return this._serviceNetworkVpcAssociationIdentifier; }
            set { this._serviceNetworkVpcAssociationIdentifier = value; }
        }

        // Check to see if ServiceNetworkVpcAssociationIdentifier property is set
        internal bool IsSetServiceNetworkVpcAssociationIdentifier()
        {
            return this._serviceNetworkVpcAssociationIdentifier != null;
        }

    }
}
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
    /// Container for the parameters to the DeleteServiceNetworkServiceAssociation operation.
    /// Deletes the association between a specified service and the specific service network.
    /// This request will fail if an association is still in progress.
    /// </summary>
    public partial class DeleteServiceNetworkServiceAssociationRequest : AmazonVPCLatticeRequest
    {
        private string _serviceNetworkServiceAssociationIdentifier;

        /// <summary>
        /// Gets and sets the property ServiceNetworkServiceAssociationIdentifier. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=17, Max=2048)]
        public string ServiceNetworkServiceAssociationIdentifier
        {
            get { return this._serviceNetworkServiceAssociationIdentifier; }
            set { this._serviceNetworkServiceAssociationIdentifier = value; }
        }

        // Check to see if ServiceNetworkServiceAssociationIdentifier property is set
        internal bool IsSetServiceNetworkServiceAssociationIdentifier()
        {
            return this._serviceNetworkServiceAssociationIdentifier != null;
        }

    }
}
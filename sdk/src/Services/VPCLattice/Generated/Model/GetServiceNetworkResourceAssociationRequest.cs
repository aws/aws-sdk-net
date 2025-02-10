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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the GetServiceNetworkResourceAssociation operation.
    /// Retrieves information about the specified association between a service network and
    /// a resource configuration.
    /// </summary>
    public partial class GetServiceNetworkResourceAssociationRequest : AmazonVPCLatticeRequest
    {
        private string _serviceNetworkResourceAssociationIdentifier;

        /// <summary>
        /// Gets and sets the property ServiceNetworkResourceAssociationIdentifier. 
        /// <para>
        /// The ID of the association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=22, Max=2048)]
        public string ServiceNetworkResourceAssociationIdentifier
        {
            get { return this._serviceNetworkResourceAssociationIdentifier; }
            set { this._serviceNetworkResourceAssociationIdentifier = value; }
        }

        // Check to see if ServiceNetworkResourceAssociationIdentifier property is set
        internal bool IsSetServiceNetworkResourceAssociationIdentifier()
        {
            return this._serviceNetworkResourceAssociationIdentifier != null;
        }

    }
}
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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// This is the response object from the AcceptDirectConnectGatewayAssociationProposal operation.
    /// </summary>
    public partial class AcceptDirectConnectGatewayAssociationProposalResponse : AmazonWebServiceResponse
    {
        private DirectConnectGatewayAssociation _directConnectGatewayAssociation;

        /// <summary>
        /// Gets and sets the property DirectConnectGatewayAssociation. 
        /// <para>
        /// Information about an association between a Direct Connect gateway and a virtual gateway
        /// or transit gateway.
        /// </para>
        /// </summary>
        public DirectConnectGatewayAssociation DirectConnectGatewayAssociation
        {
            get { return this._directConnectGatewayAssociation; }
            set { this._directConnectGatewayAssociation = value; }
        }

        // Check to see if DirectConnectGatewayAssociation property is set
        internal bool IsSetDirectConnectGatewayAssociation()
        {
            return this._directConnectGatewayAssociation != null;
        }

    }
}
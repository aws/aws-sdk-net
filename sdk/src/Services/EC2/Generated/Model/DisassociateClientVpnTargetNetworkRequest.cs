/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateClientVpnTargetNetwork operation.
    /// Disassociates a target network from the specified Client VPN endpoint. When you disassociate
    /// the last target network from a Client VPN, the following happens:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The route that was automatically added for the VPC is deleted
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// All active client connections are terminated
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// New client connections are disallowed
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The Client VPN endpoint's status changes to <code>pending-associate</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DisassociateClientVpnTargetNetworkRequest : AmazonEC2Request
    {
        private string _associationId;
        private string _clientVpnEndpointId;

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of the target network association.
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
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint from which to disassociate the target network.
        /// </para>
        /// </summary>
        public string ClientVpnEndpointId
        {
            get { return this._clientVpnEndpointId; }
            set { this._clientVpnEndpointId = value; }
        }

        // Check to see if ClientVpnEndpointId property is set
        internal bool IsSetClientVpnEndpointId()
        {
            return this._clientVpnEndpointId != null;
        }

    }
}
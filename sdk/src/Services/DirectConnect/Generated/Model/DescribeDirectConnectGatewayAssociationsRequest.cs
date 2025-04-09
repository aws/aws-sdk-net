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
    /// Container for the parameters to the DescribeDirectConnectGatewayAssociations operation.
    /// Lists the associations between your Direct Connect gateways and virtual private gateways
    /// and transit gateways. You must specify one of the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// A Direct Connect gateway
    /// </para>
    ///  
    /// <para>
    /// The response contains all virtual private gateways and transit gateways associated
    /// with the Direct Connect gateway.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A virtual private gateway
    /// </para>
    ///  
    /// <para>
    /// The response contains the Direct Connect gateway.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A transit gateway
    /// </para>
    ///  
    /// <para>
    /// The response contains the Direct Connect gateway.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A Direct Connect gateway and a virtual private gateway
    /// </para>
    ///  
    /// <para>
    /// The response contains the association between the Direct Connect gateway and virtual
    /// private gateway.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A Direct Connect gateway and a transit gateway
    /// </para>
    ///  
    /// <para>
    /// The response contains the association between the Direct Connect gateway and transit
    /// gateway.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A Direct Connect gateway and a virtual private gateway
    /// </para>
    ///  
    /// <para>
    /// The response contains the association between the Direct Connect gateway and virtual
    /// private gateway.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A Direct Connect gateway association to a Cloud WAN core network
    /// </para>
    ///  
    /// <para>
    /// The response contains the Cloud WAN core network ID that the Direct Connect gateway
    /// is associated to.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeDirectConnectGatewayAssociationsRequest : AmazonDirectConnectRequest
    {
        private string _associatedGatewayId;
        private string _associationId;
        private string _directConnectGatewayId;
        private int? _maxResults;
        private string _nextToken;
        private string _virtualGatewayId;

        /// <summary>
        /// Gets and sets the property AssociatedGatewayId. 
        /// <para>
        /// The ID of the associated gateway.
        /// </para>
        /// </summary>
        public string AssociatedGatewayId
        {
            get { return this._associatedGatewayId; }
            set { this._associatedGatewayId = value; }
        }

        // Check to see if AssociatedGatewayId property is set
        internal bool IsSetAssociatedGatewayId()
        {
            return this._associatedGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of the Direct Connect gateway association.
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
        /// Gets and sets the property DirectConnectGatewayId. 
        /// <para>
        /// The ID of the Direct Connect gateway.
        /// </para>
        /// </summary>
        public string DirectConnectGatewayId
        {
            get { return this._directConnectGatewayId; }
            set { this._directConnectGatewayId = value; }
        }

        // Check to see if DirectConnectGatewayId property is set
        internal bool IsSetDirectConnectGatewayId()
        {
            return this._directConnectGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return with a single call. To retrieve the remaining
        /// results, make another call with the returned <c>nextToken</c> value.
        /// </para>
        ///  
        /// <para>
        /// If <c>MaxResults</c> is given a value larger than 100, only 100 results are returned.
        /// </para>
        /// </summary>
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token provided in the previous call to retrieve the next page.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualGatewayId. 
        /// <para>
        /// The ID of the virtual private gateway or transit gateway.
        /// </para>
        /// </summary>
        public string VirtualGatewayId
        {
            get { return this._virtualGatewayId; }
            set { this._virtualGatewayId = value; }
        }

        // Check to see if VirtualGatewayId property is set
        internal bool IsSetVirtualGatewayId()
        {
            return this._virtualGatewayId != null;
        }

    }
}
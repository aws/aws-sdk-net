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
    /// Container for the parameters to the DescribeVirtualInterfaces operation.
    /// Displays all virtual interfaces for an Amazon Web Services account. Virtual interfaces
    /// deleted fewer than 15 minutes before you make the request are also returned. If you
    /// specify a connection ID, only the virtual interfaces associated with the connection
    /// are returned. If you specify a virtual interface ID, then only a single virtual interface
    /// is returned.
    /// 
    ///  
    /// <para>
    /// A virtual interface (VLAN) transmits the traffic between the Direct Connect location
    /// and the customer network.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you're using an <c>asn</c>, the response includes ASN value in both the <c>asn</c>
    /// and <c>asnLong</c> fields.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you're using <c>asnLong</c>, the response returns a value of <c>0</c> (zero) for
    /// the <c>asn</c> attribute because it exceeds the highest ASN value of 2,147,483,647
    /// that it can support
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeVirtualInterfacesRequest : AmazonDirectConnectRequest
    {
        private string _connectionId;
        private int? _maxResults;
        private string _nextToken;
        private string _virtualInterfaceId;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the connection.
        /// </para>
        /// </summary>
        public string ConnectionId
        {
            get { return this._connectionId; }
            set { this._connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this._connectionId != null;
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
        /// The token for the next page of results.
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
        /// Gets and sets the property VirtualInterfaceId. 
        /// <para>
        /// The ID of the virtual interface.
        /// </para>
        /// </summary>
        public string VirtualInterfaceId
        {
            get { return this._virtualInterfaceId; }
            set { this._virtualInterfaceId = value; }
        }

        // Check to see if VirtualInterfaceId property is set
        internal bool IsSetVirtualInterfaceId()
        {
            return this._virtualInterfaceId != null;
        }

    }
}
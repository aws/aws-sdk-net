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
    /// Container for the parameters to the AssociateConnectionWithLag operation.
    /// Associates an existing connection with a link aggregation group (LAG). The connection
    /// is interrupted and re-established as a member of the LAG (connectivity to Amazon Web
    /// Services is interrupted). The connection must be hosted on the same Direct Connect
    /// endpoint as the LAG, and its bandwidth must match the bandwidth for the LAG. You can
    /// re-associate a connection that's currently associated with a different LAG; however,
    /// if removing the connection would cause the original LAG to fall below its setting
    /// for minimum number of operational connections, the request fails.
    /// 
    ///  
    /// <para>
    /// Any virtual interfaces that are directly associated with the connection are automatically
    /// re-associated with the LAG. If the connection was originally associated with a different
    /// LAG, the virtual interfaces remain associated with the original LAG.
    /// </para>
    ///  
    /// <para>
    /// For interconnects, any hosted connections are automatically re-associated with the
    /// LAG. If the interconnect was originally associated with a different LAG, the hosted
    /// connections remain associated with the original LAG.
    /// </para>
    /// </summary>
    public partial class AssociateConnectionWithLagRequest : AmazonDirectConnectRequest
    {
        private string _connectionId;
        private string _lagId;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property LagId. 
        /// <para>
        /// The ID of the LAG with which to associate the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LagId
        {
            get { return this._lagId; }
            set { this._lagId = value; }
        }

        // Check to see if LagId property is set
        internal bool IsSetLagId()
        {
            return this._lagId != null;
        }

    }
}
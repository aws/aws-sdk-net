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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateConnection operation. Updates the Direct
    /// Connect connection configuration. <para> You can update the following parameters for
    /// a connection: </para> <ul> <li> <para> The connection name </para> </li> <li> <para>
    /// The connection's MAC Security (MACsec) encryption mode. </para> </li> </ul>
    /// </summary>
    public partial class UpdateConnectionRequest : AmazonDirectConnectRequest
    {
        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the connection.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeConnections</a> to retrieve the connection ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionId property is set.
        /// </summary>
        internal bool IsSetConnectionId() => this.ConnectionId != null;

        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the connection.
        /// </para>
        /// </summary>
        public string ConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionName property is set.
        /// </summary>
        internal bool IsSetConnectionName() => this.ConnectionName != null;

        /// <summary>
        /// Gets and sets the property EncryptionMode. 
        /// <para>
        /// The connection MAC Security (MACsec) encryption mode.
        /// </para>
        ///  
        /// <para>
        /// The valid values are <c>no_encrypt</c>, <c>should_encrypt</c>, and <c>must_encrypt</c>.
        /// </para>
        /// </summary>
        public string EncryptionMode { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionMode property is set.
        /// </summary>
        internal bool IsSetEncryptionMode() => this.EncryptionMode != null;
    }
}

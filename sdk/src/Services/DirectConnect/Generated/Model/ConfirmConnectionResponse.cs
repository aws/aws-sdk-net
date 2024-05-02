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
    /// This is the response object from the ConfirmConnection operation.
    /// </summary>
    public partial class ConfirmConnectionResponse : AmazonWebServiceResponse
    {
        private ConnectionState _connectionState;

        /// <summary>
        /// Gets and sets the property ConnectionState. 
        /// <para>
        /// The state of the connection. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ordering</c>: The initial state of a hosted connection provisioned on an interconnect.
        /// The connection stays in the ordering state until the owner of the hosted connection
        /// confirms or declines the connection order.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>requested</c>: The initial state of a standard connection. The connection stays
        /// in the requested state until the Letter of Authorization (LOA) is sent to the customer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending</c>: The connection has been approved and is being initialized.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>available</c>: The network link is up and the connection is ready for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>down</c>: The network link is down.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleting</c>: The connection is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleted</c>: The connection has been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rejected</c>: A hosted connection in the <c>ordering</c> state enters the <c>rejected</c>
        /// state if it is deleted by the customer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unknown</c>: The state of the connection is not available.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ConnectionState ConnectionState
        {
            get { return this._connectionState; }
            set { this._connectionState = value; }
        }

        // Check to see if ConnectionState property is set
        internal bool IsSetConnectionState()
        {
            return this._connectionState != null;
        }

    }
}
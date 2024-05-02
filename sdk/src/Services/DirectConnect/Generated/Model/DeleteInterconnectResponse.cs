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
    /// This is the response object from the DeleteInterconnect operation.
    /// </summary>
    public partial class DeleteInterconnectResponse : AmazonWebServiceResponse
    {
        private InterconnectState _interconnectState;

        /// <summary>
        /// Gets and sets the property InterconnectState. 
        /// <para>
        /// The state of the interconnect. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>requested</c>: The initial state of an interconnect. The interconnect stays in
        /// the requested state until the Letter of Authorization (LOA) is sent to the customer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending</c>: The interconnect is approved, and is being initialized.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>available</c>: The network link is up, and the interconnect is ready for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>down</c>: The network link is down.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleting</c>: The interconnect is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleted</c>: The interconnect is deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unknown</c>: The state of the interconnect is not available.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InterconnectState InterconnectState
        {
            get { return this._interconnectState; }
            set { this._interconnectState = value; }
        }

        // Check to see if InterconnectState property is set
        internal bool IsSetInterconnectState()
        {
            return this._interconnectState != null;
        }

    }
}
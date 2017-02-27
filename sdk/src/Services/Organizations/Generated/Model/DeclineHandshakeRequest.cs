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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the DeclineHandshake operation.
    /// Declines a handshake request. This sets the handshake state to <code>DECLINED</code>
    /// and effectively deactivates the request.
    /// 
    ///  
    /// <para>
    /// This operation can be called only from the account that received the handshake. The
    /// originator of the handshake can use <a>CancelHandshake</a> instead. The originator
    /// can't reactivate a declined request, but can re-initiate the process with a new handshake
    /// request.
    /// </para>
    /// </summary>
    public partial class DeclineHandshakeRequest : AmazonOrganizationsRequest
    {
        private string _handshakeId;

        /// <summary>
        /// Gets and sets the property HandshakeId. 
        /// <para>
        /// The unique identifier (ID) of the handshake that you want to decline. You can get
        /// the ID from the <a>ListHandshakesForAccount</a> operation.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for handshake ID string
        /// requires "h-" followed by from 8 to 32 lower-case letters or digits.
        /// </para>
        /// </summary>
        public string HandshakeId
        {
            get { return this._handshakeId; }
            set { this._handshakeId = value; }
        }

        // Check to see if HandshakeId property is set
        internal bool IsSetHandshakeId()
        {
            return this._handshakeId != null;
        }

    }
}
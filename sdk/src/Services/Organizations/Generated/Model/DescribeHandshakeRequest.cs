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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeHandshake operation.
    /// Retrieves information about a previously requested handshake. The handshake ID comes
    /// from the response to the original <a>InviteAccountToOrganization</a> operation that
    /// generated the handshake.
    /// 
    ///  
    /// <para>
    /// You can access handshakes that are <c>ACCEPTED</c>, <c>DECLINED</c>, or <c>CANCELED</c>
    /// for only 30 days after they change to that state. They're then deleted and no longer
    /// accessible.
    /// </para>
    ///  
    /// <para>
    /// This operation can be called from any account in the organization.
    /// </para>
    /// </summary>
    public partial class DescribeHandshakeRequest : AmazonOrganizationsRequest
    {
        private string _handshakeId;

        /// <summary>
        /// Gets and sets the property HandshakeId. 
        /// <para>
        /// The unique identifier (ID) of the handshake that you want information about. You can
        /// get the ID from the original call to <a>InviteAccountToOrganization</a>, or from a
        /// call to <a>ListHandshakesForAccount</a> or <a>ListHandshakesForOrganization</a>.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for handshake ID string
        /// requires "h-" followed by from 8 to 32 lowercase letters or digits.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=34)]
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
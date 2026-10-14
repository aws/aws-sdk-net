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

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the DeclineHandshake operation. Declines a <a>Handshake</a>.
    /// <para> Only the account that receives a handshake can call this operation. The sender
    /// of the handshake can use <a>CancelHandshake</a> to cancel if the handshake hasn't
    /// yet been responded to. </para> <para> You can view canceled handshakes in API responses
    /// for 30 days before they are deleted. </para>
    /// </summary>
    public partial class DeclineHandshakeRequest : AmazonOrganizationsRequest
    {
        /// <summary>
        /// Gets and sets the property HandshakeId. 
        /// <para>
        /// ID for the handshake that you want to decline. You can get the ID from the <a>ListHandshakesForAccount</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for handshake ID string
        /// requires "h-" followed by from 8 to 32 lowercase letters or digits.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 34)]
        public string HandshakeId { get; set; }

        /// <summary>
        /// Checks to see if the HandshakeId property is set.
        /// </summary>
        internal bool IsSetHandshakeId() => this.HandshakeId != null;
    }
}

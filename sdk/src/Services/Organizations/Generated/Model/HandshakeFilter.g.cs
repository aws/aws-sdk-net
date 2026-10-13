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
    /// Contains the filter used to select the handshakes for an operation.
    /// </summary>
    public partial class HandshakeFilter
    {
        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The type of handshake.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>ActionType</c>, you cannot also specify <c>ParentHandshakeId</c>.
        /// </para>
        /// </summary>
        public ActionType ActionType { get; set; }

        /// <summary>
        /// Checks to see if the ActionType property is set.
        /// </summary>
        internal bool IsSetActionType() => this.ActionType != null;

        /// <summary>
        /// Gets and sets the property ParentHandshakeId. 
        /// <para>
        /// The parent handshake. Only used for handshake types that are a child of another type.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>ParentHandshakeId</c>, you cannot also specify <c>ActionType</c>.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for handshake ID string
        /// requires "h-" followed by from 8 to 32 lowercase letters or digits.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 34)]
        public string ParentHandshakeId { get; set; }

        /// <summary>
        /// Checks to see if the ParentHandshakeId property is set.
        /// </summary>
        internal bool IsSetParentHandshakeId() => this.ParentHandshakeId != null;
    }
}

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
    /// Specifies the criteria that are used to select the handshakes for the operation.
    /// </summary>
    public partial class HandshakeFilter
    {
        private ActionType _actionType;
        private string _parentHandshakeId;

        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// Specifies the type of handshake action.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>ActionType</code>, you cannot also specify <code>ParentHandshakeId</code>.
        /// </para>
        /// </summary>
        public ActionType ActionType
        {
            get { return this._actionType; }
            set { this._actionType = value; }
        }

        // Check to see if ActionType property is set
        internal bool IsSetActionType()
        {
            return this._actionType != null;
        }

        /// <summary>
        /// Gets and sets the property ParentHandshakeId. 
        /// <para>
        /// Specifies the parent handshake. Only used for handshake types that are a child of
        /// another type.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>ParentHandshakeId</code>, you cannot also specify <code>ActionType</code>.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for handshake ID string
        /// requires "h-" followed by from 8 to 32 lower-case letters or digits.
        /// </para>
        /// </summary>
        public string ParentHandshakeId
        {
            get { return this._parentHandshakeId; }
            set { this._parentHandshakeId = value; }
        }

        // Check to see if ParentHandshakeId property is set
        internal bool IsSetParentHandshakeId()
        {
            return this._parentHandshakeId != null;
        }

    }
}
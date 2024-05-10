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
    /// This is the response object from the AssociateMacSecKey operation.
    /// </summary>
    public partial class AssociateMacSecKeyResponse : AmazonWebServiceResponse
    {
        private string _connectionId;
        private List<MacSecKey> _macSecKeys = AWSConfigs.InitializeCollections ? new List<MacSecKey>() : null;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the dedicated connection (dxcon-xxxx), or the ID of the LAG (dxlag-xxxx).
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
        /// Gets and sets the property MacSecKeys. 
        /// <para>
        /// The MAC Security (MACsec) security keys associated with the dedicated connection.
        /// </para>
        /// </summary>
        public List<MacSecKey> MacSecKeys
        {
            get { return this._macSecKeys; }
            set { this._macSecKeys = value; }
        }

        // Check to see if MacSecKeys property is set
        internal bool IsSetMacSecKeys()
        {
            return this._macSecKeys != null && (this._macSecKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
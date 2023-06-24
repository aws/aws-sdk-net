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
 * Do not modify this file. This file is generated from the gamesparks-2021-08-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameSparks.Model
{
    /// <summary>
    /// This is the response object from the DisconnectPlayer operation.
    /// </summary>
    public partial class DisconnectPlayerResponse : AmazonWebServiceResponse
    {
        private List<string> _disconnectFailures = new List<string>();
        private List<string> _disconnectSuccesses = new List<string>();

        /// <summary>
        /// Gets and sets the property DisconnectFailures. 
        /// <para>
        /// The list of the connection ids that could not be disconnected.
        /// </para>
        /// </summary>
        public List<string> DisconnectFailures
        {
            get { return this._disconnectFailures; }
            set { this._disconnectFailures = value; }
        }

        // Check to see if DisconnectFailures property is set
        internal bool IsSetDisconnectFailures()
        {
            return this._disconnectFailures != null && this._disconnectFailures.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DisconnectSuccesses. 
        /// <para>
        /// The list of the connection ids that were disconnected.
        /// </para>
        /// </summary>
        public List<string> DisconnectSuccesses
        {
            get { return this._disconnectSuccesses; }
            set { this._disconnectSuccesses = value; }
        }

        // Check to see if DisconnectSuccesses property is set
        internal bool IsSetDisconnectSuccesses()
        {
            return this._disconnectSuccesses != null && this._disconnectSuccesses.Count > 0; 
        }

    }
}
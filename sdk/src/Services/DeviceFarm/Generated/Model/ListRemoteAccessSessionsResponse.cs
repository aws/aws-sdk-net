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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents the response from the server after AWS Device Farm makes a request to return
    /// information about the remote access session.
    /// </summary>
    public partial class ListRemoteAccessSessionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RemoteAccessSession> _remoteAccessSessions = new List<RemoteAccessSession>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier that was returned from the previous call to this operation, which can
        /// be used to return the next set of items in the list.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteAccessSessions. 
        /// <para>
        /// A container representing the metadata from the service about each remote access session
        /// you are requesting.
        /// </para>
        /// </summary>
        public List<RemoteAccessSession> RemoteAccessSessions
        {
            get { return this._remoteAccessSessions; }
            set { this._remoteAccessSessions = value; }
        }

        // Check to see if RemoteAccessSessions property is set
        internal bool IsSetRemoteAccessSessions()
        {
            return this._remoteAccessSessions != null && this._remoteAccessSessions.Count > 0; 
        }

    }
}
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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// This is the response object from the ListRoomMemberships operation.
    /// </summary>
    public partial class ListRoomMembershipsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RoomMembership> _roomMemberships = new List<RoomMembership>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results.
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
        /// Gets and sets the property RoomMemberships. 
        /// <para>
        /// The room membership details.
        /// </para>
        /// </summary>
        public List<RoomMembership> RoomMemberships
        {
            get { return this._roomMemberships; }
            set { this._roomMemberships = value; }
        }

        // Check to see if RoomMemberships property is set
        internal bool IsSetRoomMemberships()
        {
            return this._roomMemberships != null && this._roomMemberships.Count > 0; 
        }

    }
}
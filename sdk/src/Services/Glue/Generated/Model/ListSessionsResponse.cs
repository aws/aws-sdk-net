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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the ListSessions operation.
    /// </summary>
    public partial class ListSessionsResponse : AmazonWebServiceResponse
    {
        private List<string> _ids = new List<string>();
        private string _nextToken;
        private List<Session> _sessions = new List<Session>();

        /// <summary>
        /// Gets and sets the property Ids. 
        /// <para>
        /// Returns the Id of the session. 
        /// </para>
        /// </summary>
        public List<string> Ids
        {
            get { return this._ids; }
            set { this._ids = value; }
        }

        // Check to see if Ids property is set
        internal bool IsSetIds()
        {
            return this._ids != null && this._ids.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results, or null if there are no more result. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=400000)]
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
        /// Gets and sets the property Sessions. 
        /// <para>
        /// Returns the session object. 
        /// </para>
        /// </summary>
        public List<Session> Sessions
        {
            get { return this._sessions; }
            set { this._sessions = value; }
        }

        // Check to see if Sessions property is set
        internal bool IsSetSessions()
        {
            return this._sessions != null && this._sessions.Count > 0; 
        }

    }
}
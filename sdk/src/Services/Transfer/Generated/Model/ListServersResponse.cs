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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// This is the response object from the ListServers operation.
    /// </summary>
    public partial class ListServersResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ListedServer> _servers = new List<ListedServer>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When you can get additional results from the <code>ListServers</code> operation, a
        /// <code>NextToken</code> parameter is returned in the output. In a following command,
        /// you can pass in the <code>NextToken</code> parameter to continue listing additional
        /// servers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6144)]
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
        /// Gets and sets the property Servers. 
        /// <para>
        /// An array of servers that were listed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ListedServer> Servers
        {
            get { return this._servers; }
            set { this._servers = value; }
        }

        // Check to see if Servers property is set
        internal bool IsSetServers()
        {
            return this._servers != null && this._servers.Count > 0; 
        }

    }
}
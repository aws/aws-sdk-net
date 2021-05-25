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
    /// This is the response object from the ListAccesses operation.
    /// </summary>
    public partial class ListAccessesResponse : AmazonWebServiceResponse
    {
        private List<ListedAccess> _accesses = new List<ListedAccess>();
        private string _nextToken;
        private string _serverId;

        /// <summary>
        /// Gets and sets the property Accesses. 
        /// <para>
        /// Returns the accesses and their properties for the <code>ServerId</code> value that
        /// you specify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ListedAccess> Accesses
        {
            get { return this._accesses; }
            set { this._accesses = value; }
        }

        // Check to see if Accesses property is set
        internal bool IsSetAccesses()
        {
            return this._accesses != null && this._accesses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When you can get additional results from the <code>ListAccesses</code> call, a <code>NextToken</code>
        /// parameter is returned in the output. You can then pass in a subsequent command to
        /// the <code>NextToken</code> parameter to continue listing additional accesses.
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
        /// Gets and sets the property ServerId. 
        /// <para>
        /// A system-assigned unique identifier for a server that has users assigned to it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string ServerId
        {
            get { return this._serverId; }
            set { this._serverId = value; }
        }

        // Check to see if ServerId property is set
        internal bool IsSetServerId()
        {
            return this._serverId != null;
        }

    }
}
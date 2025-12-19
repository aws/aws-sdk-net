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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
namespace Amazon.Wickr.Model
{
    /// <summary>
    /// This is the response object from the ListBlockedGuestUsers operation.
    /// </summary>
    public partial class ListBlockedGuestUsersResponse : AmazonWebServiceResponse
    {
        private List<BlockedGuestUser> _blocklist = AWSConfigs.InitializeCollections ? new List<BlockedGuestUser>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Blocklist. 
        /// <para>
        /// A list of blocked guest user objects within the current page.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BlockedGuestUser> Blocklist
        {
            get { return this._blocklist; }
            set { this._blocklist = value; }
        }

        // Check to see if Blocklist property is set
        internal bool IsSetBlocklist()
        {
            return this._blocklist != null && (this._blocklist.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use for retrieving the next page of results. If this is not present,
        /// there are no more results.
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

    }
}
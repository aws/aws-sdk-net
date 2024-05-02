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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// Container for the parameters to the ListExtensibleSourceServers operation.
    /// Returns a list of source servers on a staging account that are extensible, which means
    /// that: a. The source server is not already extended into this Account. b. The source
    /// server on the Account we’re reading from is not an extension of another source server.
    /// </summary>
    public partial class ListExtensibleSourceServersRequest : AmazonDrsRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _stagingAccountID;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of extensible source servers to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token of the next extensible source server to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property StagingAccountID. 
        /// <para>
        /// The Id of the staging Account to retrieve extensible source servers from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string StagingAccountID
        {
            get { return this._stagingAccountID; }
            set { this._stagingAccountID = value; }
        }

        // Check to see if StagingAccountID property is set
        internal bool IsSetStagingAccountID()
        {
            return this._stagingAccountID != null;
        }

    }
}
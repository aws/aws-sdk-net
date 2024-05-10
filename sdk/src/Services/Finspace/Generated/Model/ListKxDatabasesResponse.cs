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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// This is the response object from the ListKxDatabases operation.
    /// </summary>
    public partial class ListKxDatabasesResponse : AmazonWebServiceResponse
    {
        private List<KxDatabaseListEntry> _kxDatabases = AWSConfigs.InitializeCollections ? new List<KxDatabaseListEntry>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property KxDatabases. 
        /// <para>
        /// A list of databases in the kdb environment.
        /// </para>
        /// </summary>
        public List<KxDatabaseListEntry> KxDatabases
        {
            get { return this._kxDatabases; }
            set { this._kxDatabases = value; }
        }

        // Check to see if KxDatabases property is set
        internal bool IsSetKxDatabases()
        {
            return this._kxDatabases != null && (this._kxDatabases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates where a results page should begin.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
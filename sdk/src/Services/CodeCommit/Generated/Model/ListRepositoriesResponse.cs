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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Represents the output of a list repositories operation.
    /// </summary>
    public partial class ListRepositoriesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RepositoryNameIdPair> _repositories = new List<RepositoryNameIdPair>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An enumeration token that allows the operation to batch the results of the operation.
        /// Batch sizes are 1,000 for list repository operations. When the client sends the token
        /// back to AWS CodeCommit, another page of 1,000 records is retrieved.
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
        /// Gets and sets the property Repositories. 
        /// <para>
        /// Lists the repositories called by the list repositories operation.
        /// </para>
        /// </summary>
        public List<RepositoryNameIdPair> Repositories
        {
            get { return this._repositories; }
            set { this._repositories = value; }
        }

        // Check to see if Repositories property is set
        internal bool IsSetRepositories()
        {
            return this._repositories != null && this._repositories.Count > 0; 
        }

    }
}
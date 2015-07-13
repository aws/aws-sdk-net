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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Represents the output of a batch get repositories operation.
    /// </summary>
    public partial class BatchGetRepositoriesResponse : AmazonWebServiceResponse
    {
        private List<RepositoryMetadata> _repositories = new List<RepositoryMetadata>();
        private List<string> _repositoriesNotFound = new List<string>();

        /// <summary>
        /// Gets and sets the property Repositories. 
        /// <para>
        /// A list of repositories returned by the batch get repositories operation.
        /// </para>
        /// </summary>
        public List<RepositoryMetadata> Repositories
        {
            get { return this._repositories; }
            set { this._repositories = value; }
        }

        // Check to see if Repositories property is set
        internal bool IsSetRepositories()
        {
            return this._repositories != null && this._repositories.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RepositoriesNotFound. 
        /// <para>
        /// Returns a list of repository names for which information could not be found.
        /// </para>
        /// </summary>
        public List<string> RepositoriesNotFound
        {
            get { return this._repositoriesNotFound; }
            set { this._repositoriesNotFound = value; }
        }

        // Check to see if RepositoriesNotFound property is set
        internal bool IsSetRepositoriesNotFound()
        {
            return this._repositoriesNotFound != null && this._repositoriesNotFound.Count > 0; 
        }

    }
}
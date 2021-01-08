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
    /// Container for the parameters to the BatchGetCommits operation.
    /// Returns information about the contents of one or more commits in a repository.
    /// </summary>
    public partial class BatchGetCommitsRequest : AmazonCodeCommitRequest
    {
        private List<string> _commitIds = new List<string>();
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property CommitIds. 
        /// <para>
        /// The full commit IDs of the commits to get information about.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must supply the full SHA IDs of each commit. You cannot use shortened SHA IDs.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> CommitIds
        {
            get { return this._commitIds; }
            set { this._commitIds = value; }
        }

        // Check to see if CommitIds property is set
        internal bool IsSetCommitIds()
        {
            return this._commitIds != null && this._commitIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository that contains the commits.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

    }
}
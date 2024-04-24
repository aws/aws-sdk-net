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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
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
namespace Amazon.Proton.Model
{
    /// <summary>
    /// Revision detail data for a commit and push that activates a sync attempt
    /// </summary>
    public partial class Revision
    {
        private string _branch;
        private string _directory;
        private string _repositoryName;
        private RepositoryProvider _repositoryProvider;
        private string _sha;

        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// The repository branch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string Branch
        {
            get { return this._branch; }
            set { this._branch = value; }
        }

        // Check to see if Branch property is set
        internal bool IsSetBranch()
        {
            return this._branch != null;
        }

        /// <summary>
        /// Gets and sets the property Directory. 
        /// <para>
        /// The repository directory changed by a commit and push that activated the sync attempt.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Directory
        {
            get { return this._directory; }
            set { this._directory = value; }
        }

        // Check to see if Directory property is set
        internal bool IsSetDirectory()
        {
            return this._directory != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The repository name.
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

        /// <summary>
        /// Gets and sets the property RepositoryProvider. 
        /// <para>
        /// The repository provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RepositoryProvider RepositoryProvider
        {
            get { return this._repositoryProvider; }
            set { this._repositoryProvider = value; }
        }

        // Check to see if RepositoryProvider property is set
        internal bool IsSetRepositoryProvider()
        {
            return this._repositoryProvider != null;
        }

        /// <summary>
        /// Gets and sets the property Sha. 
        /// <para>
        /// The secure hash algorithm (SHA) hash for the revision.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Sha
        {
            get { return this._sha; }
            set { this._sha = value; }
        }

        // Check to see if Sha property is set
        internal bool IsSetSha()
        {
            return this._sha != null;
        }

    }
}
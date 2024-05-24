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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Container for the parameters to the GetFolder operation.
    /// Returns the contents of a specified folder in a repository.
    /// </summary>
    public partial class GetFolderRequest : AmazonCodeCommitRequest
    {
        private string _commitSpecifier;
        private string _folderPath;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property CommitSpecifier. 
        /// <para>
        /// A fully qualified reference used to identify a commit that contains the version of
        /// the folder's content to return. A fully qualified reference can be a commit ID, branch
        /// name, tag, or reference such as HEAD. If no specifier is provided, the folder content
        /// is returned as it exists in the HEAD commit.
        /// </para>
        /// </summary>
        public string CommitSpecifier
        {
            get { return this._commitSpecifier; }
            set { this._commitSpecifier = value; }
        }

        // Check to see if CommitSpecifier property is set
        internal bool IsSetCommitSpecifier()
        {
            return this._commitSpecifier != null;
        }

        /// <summary>
        /// Gets and sets the property FolderPath. 
        /// <para>
        /// The fully qualified path to the folder whose contents are returned, including the
        /// folder name. For example, /examples is a fully-qualified path to a folder named examples
        /// that was created off of the root directory (/) of a repository. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FolderPath
        {
            get { return this._folderPath; }
            set { this._folderPath = value; }
        }

        // Check to see if FolderPath property is set
        internal bool IsSetFolderPath()
        {
            return this._folderPath != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository.
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
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
    /// Container for the parameters to the GetFile operation.
    /// Returns the base-64 encoded contents of a specified file and its metadata.
    /// </summary>
    public partial class GetFileRequest : AmazonCodeCommitRequest
    {
        private string _commitSpecifier;
        private string _filePath;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property CommitSpecifier. 
        /// <para>
        /// The fully quaified reference that identifies the commit that contains the file. For
        /// example, you can specify a full commit ID, a tag, a branch name, or a reference such
        /// as refs/heads/main. If none is provided, the head commit is used.
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
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The fully qualified path to the file, including the full name and extension of the
        /// file. For example, /examples/file.md is the fully qualified path to a file named file.md
        /// in a folder named examples.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FilePath
        {
            get { return this._filePath; }
            set { this._filePath = value; }
        }

        // Check to see if FilePath property is set
        internal bool IsSetFilePath()
        {
            return this._filePath != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository that contains the file.
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
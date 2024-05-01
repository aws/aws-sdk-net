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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// The event criteria that specify when a specified repository event will start the pipeline
    /// for the specified trigger configuration, such as the lists of Git tags to include
    /// and exclude.
    /// </summary>
    public partial class GitPushFilter
    {
        private GitBranchFilterCriteria _branches;
        private GitFilePathFilterCriteria _filePaths;
        private GitTagFilterCriteria _tags;

        /// <summary>
        /// Gets and sets the property Branches. 
        /// <para>
        /// The field that specifies to filter on branches for the push trigger configuration.
        /// </para>
        /// </summary>
        public GitBranchFilterCriteria Branches
        {
            get { return this._branches; }
            set { this._branches = value; }
        }

        // Check to see if Branches property is set
        internal bool IsSetBranches()
        {
            return this._branches != null;
        }

        /// <summary>
        /// Gets and sets the property FilePaths. 
        /// <para>
        /// The field that specifies to filter on file paths for the push trigger configuration.
        /// </para>
        /// </summary>
        public GitFilePathFilterCriteria FilePaths
        {
            get { return this._filePaths; }
            set { this._filePaths = value; }
        }

        // Check to see if FilePaths property is set
        internal bool IsSetFilePaths()
        {
            return this._filePaths != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The field that contains the details for the Git tags trigger configuration.
        /// </para>
        /// </summary>
        public GitTagFilterCriteria Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null;
        }

    }
}
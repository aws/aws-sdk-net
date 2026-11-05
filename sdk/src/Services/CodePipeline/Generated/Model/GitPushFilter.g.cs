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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Branches. 
        /// <para>
        /// The field that specifies to filter on branches for the push trigger configuration.
        /// </para>
        /// </summary>
        public GitBranchFilterCriteria Branches { get; set; }

        /// <summary>
        /// Checks to see if the Branches property is set.
        /// </summary>
        internal bool IsSetBranches() => this.Branches != null;

        /// <summary>
        /// Gets and sets the property FilePaths. 
        /// <para>
        /// The field that specifies to filter on file paths for the push trigger configuration.
        /// </para>
        /// </summary>
        public GitFilePathFilterCriteria FilePaths { get; set; }

        /// <summary>
        /// Checks to see if the FilePaths property is set.
        /// </summary>
        internal bool IsSetFilePaths() => this.FilePaths != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The field that contains the details for the Git tags trigger configuration.
        /// </para>
        /// </summary>
        public GitTagFilterCriteria Tags { get; set; }

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null;
    }
}

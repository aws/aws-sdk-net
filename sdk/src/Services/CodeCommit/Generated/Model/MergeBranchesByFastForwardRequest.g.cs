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

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Container for the parameters to the MergeBranchesByFastForward operation. Merges two
    /// branches using the fast-forward merge strategy.
    /// </summary>
    public partial class MergeBranchesByFastForwardRequest : AmazonCodeCommitRequest
    {
        /// <summary>
        /// Gets and sets the property DestinationCommitSpecifier. 
        /// <para>
        /// The branch, tag, HEAD, or other fully qualified reference used to identify a commit
        /// (for example, a branch name or a full commit ID).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DestinationCommitSpecifier { get; set; }

        /// <summary>
        /// Checks to see if the DestinationCommitSpecifier property is set.
        /// </summary>
        internal bool IsSetDestinationCommitSpecifier() => this.DestinationCommitSpecifier != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository where you want to merge two branches.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property SourceCommitSpecifier. 
        /// <para>
        /// The branch, tag, HEAD, or other fully qualified reference used to identify a commit
        /// (for example, a branch name or a full commit ID).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceCommitSpecifier { get; set; }

        /// <summary>
        /// Checks to see if the SourceCommitSpecifier property is set.
        /// </summary>
        internal bool IsSetSourceCommitSpecifier() => this.SourceCommitSpecifier != null;

        /// <summary>
        /// Gets and sets the property TargetBranch. 
        /// <para>
        /// The branch where the merge is applied.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string TargetBranch { get; set; }

        /// <summary>
        /// Checks to see if the TargetBranch property is set.
        /// </summary>
        internal bool IsSetTargetBranch() => this.TargetBranch != null;
    }
}

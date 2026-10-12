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
    /// Returns information about the change in the merge state for a pull request event.
    /// </summary>
    public partial class PullRequestMergedStateChangedEventMetadata
    {
        /// <summary>
        /// Gets and sets the property DestinationReference. 
        /// <para>
        /// The name of the branch that the pull request is merged into.
        /// </para>
        /// </summary>
        public string DestinationReference { get; set; }

        /// <summary>
        /// Checks to see if the DestinationReference property is set.
        /// </summary>
        internal bool IsSetDestinationReference() => this.DestinationReference != null;

        /// <summary>
        /// Gets and sets the property MergeMetadata. 
        /// <para>
        /// Information about the merge state change event.
        /// </para>
        /// </summary>
        public MergeMetadata MergeMetadata { get; set; }

        /// <summary>
        /// Checks to see if the MergeMetadata property is set.
        /// </summary>
        internal bool IsSetMergeMetadata() => this.MergeMetadata != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository where the pull request was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;
    }
}

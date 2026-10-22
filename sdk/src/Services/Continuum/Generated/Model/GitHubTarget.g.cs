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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// The GitHub repository a patch is delivered to, and the pull request that carries it
    /// once opened.
    /// </summary>
    public partial class GitHubTarget
    {
        /// <summary>
        /// Gets and sets the property HeadSha. The head commit SHA of the pull request. Absent
        /// until the pull request is opened.
        /// </summary>
        [AWSProperty(Min = 40, Max = 40)]
        public string HeadSha { get; set; }

        /// <summary>
        /// Checks to see if the HeadSha property is set.
        /// </summary>
        internal bool IsSetHeadSha() => this.HeadSha != null;

        /// <summary>
        /// Gets and sets the property Owner. The GitHub user or organization that owns the repository.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property PullRequestNumber. Repository-scoped pull request number
        /// assigned by GitHub.
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? PullRequestNumber { get; set; }

        /// <summary>
        /// Checks to see if the PullRequestNumber property is set.
        /// </summary>
        internal bool IsSetPullRequestNumber() => this.PullRequestNumber.HasValue;

        /// <summary>
        /// Gets and sets the property Repository. The repository name.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Repository { get; set; }

        /// <summary>
        /// Checks to see if the Repository property is set.
        /// </summary>
        internal bool IsSetRepository() => this.Repository != null;
    }
}

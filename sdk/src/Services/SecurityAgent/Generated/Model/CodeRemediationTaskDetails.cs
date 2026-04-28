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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Code remediation details for a single repository
    /// </summary>
    public partial class CodeRemediationTaskDetails
    {
        private string _codeDiffLink;
        private string _pullRequestLink;
        private string _repoName;

        /// <summary>
        /// Gets and sets the property CodeDiffLink. 
        /// <para>
        /// Link to the code diff for the remediation
        /// </para>
        /// </summary>
        public string CodeDiffLink
        {
            get { return this._codeDiffLink; }
            set { this._codeDiffLink = value; }
        }

        // Check to see if CodeDiffLink property is set
        internal bool IsSetCodeDiffLink()
        {
            return this._codeDiffLink != null;
        }

        /// <summary>
        /// Gets and sets the property PullRequestLink. 
        /// <para>
        /// Link to the pull request for the remediation
        /// </para>
        /// </summary>
        public string PullRequestLink
        {
            get { return this._pullRequestLink; }
            set { this._pullRequestLink = value; }
        }

        // Check to see if PullRequestLink property is set
        internal bool IsSetPullRequestLink()
        {
            return this._pullRequestLink != null;
        }

        /// <summary>
        /// Gets and sets the property RepoName. 
        /// <para>
        /// Name of the repository
        /// </para>
        /// </summary>
        public string RepoName
        {
            get { return this._repoName; }
            set { this._repoName = value; }
        }

        // Check to see if RepoName property is set
        internal bool IsSetRepoName()
        {
            return this._repoName != null;
        }

    }
}
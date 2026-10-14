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
    /// Container for the parameters to the OverridePullRequestApprovalRules operation. Sets
    /// aside (overrides) all approval rule requirements for a specified pull request.
    /// </summary>
    public partial class OverridePullRequestApprovalRulesRequest : AmazonCodeCommitRequest
    {
        /// <summary>
        /// Gets and sets the property OverrideStatus. 
        /// <para>
        /// Whether you want to set aside approval rule requirements for the pull request (OVERRIDE)
        /// or revoke a previous override and apply approval rule requirements (REVOKE). REVOKE
        /// status is not stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OverrideStatus OverrideStatus { get; set; }

        /// <summary>
        /// Checks to see if the OverrideStatus property is set.
        /// </summary>
        internal bool IsSetOverrideStatus() => this.OverrideStatus != null;

        /// <summary>
        /// Gets and sets the property PullRequestId. 
        /// <para>
        /// The system-generated ID of the pull request for which you want to override all approval
        /// rule requirements. To get this information, use <a>GetPullRequest</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PullRequestId { get; set; }

        /// <summary>
        /// Checks to see if the PullRequestId property is set.
        /// </summary>
        internal bool IsSetPullRequestId() => this.PullRequestId != null;

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The system-generated ID of the most recent revision of the pull request. You cannot
        /// override approval rules for anything but the most recent revision of a pull request.
        /// To get the revision ID, use GetPullRequest.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RevisionId { get; set; }

        /// <summary>
        /// Checks to see if the RevisionId property is set.
        /// </summary>
        internal bool IsSetRevisionId() => this.RevisionId != null;
    }
}

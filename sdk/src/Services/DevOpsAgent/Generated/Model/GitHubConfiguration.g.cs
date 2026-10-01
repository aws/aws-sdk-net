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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Configuration for GitHub repository integration.
    /// </summary>
    public partial class GitHubConfiguration
    {
        /// <summary>
        /// Gets and sets the property InstanceIdentifier. 
        /// <para>
        /// GitHub instance identifier (e.g., github.com or github.enterprise.com)
        /// </para>
        /// </summary>
        public string InstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the InstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetInstanceIdentifier() => this.InstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The GitHub repository owner name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property OwnerType.
        /// </summary>
        [AWSProperty(Required = true)]
        public GithubRepoOwnerType OwnerType { get; set; }

        /// <summary>
        /// Checks to see if the OwnerType property is set.
        /// </summary>
        internal bool IsSetOwnerType() => this.OwnerType != null;

        /// <summary>
        /// Gets and sets the property RepoId. 
        /// <para>
        /// Associated Github repo ID
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RepoId { get; set; }

        /// <summary>
        /// Checks to see if the RepoId property is set.
        /// </summary>
        internal bool IsSetRepoId() => this.RepoId != null;

        /// <summary>
        /// Gets and sets the property RepoName. 
        /// <para>
        /// Associated Github repo name
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RepoName { get; set; }

        /// <summary>
        /// Checks to see if the RepoName property is set.
        /// </summary>
        internal bool IsSetRepoName() => this.RepoName != null;

        /// <summary>
        /// Gets and sets the property RuntimeRoleArn. 
        /// <para>
        /// Optional role ARN that AIDevOps assumes at runtime for automatic verification testing
        /// and VPC connectivity on this association.
        /// </para>
        /// </summary>
        [Obsolete("Superseded by the ReleaseManagement association. Configure the runtime role on the ReleaseManagement association and reference it via releaseManagementAssociationId.")]
        [AWSProperty(Min = 1, Max = 255)]
        public string RuntimeRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeRoleArn property is set.
        /// </summary>
        internal bool IsSetRuntimeRoleArn() => this.RuntimeRoleArn != null;
    }
}

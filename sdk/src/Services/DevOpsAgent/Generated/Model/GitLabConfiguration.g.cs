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
    /// Configuration for GitLab project integration.
    /// </summary>
    public partial class GitLabConfiguration
    {
        /// <summary>
        /// Gets and sets the property InstanceIdentifier. 
        /// <para>
        /// GitLab instance identifier (e.g., gitlab.com or e2e.gamma.dev.us-east-1.gitlab.falco.ai.aws.dev)
        /// </para>
        /// </summary>
        public string InstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the InstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetInstanceIdentifier() => this.InstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// GitLab numeric project ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Checks to see if the ProjectId property is set.
        /// </summary>
        internal bool IsSetProjectId() => this.ProjectId != null;

        /// <summary>
        /// Gets and sets the property ProjectPath. 
        /// <para>
        /// Full GitLab project path (e.g., namespace/project-name).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProjectPath { get; set; }

        /// <summary>
        /// Checks to see if the ProjectPath property is set.
        /// </summary>
        internal bool IsSetProjectPath() => this.ProjectPath != null;

        /// <summary>
        /// Gets and sets the property ReleaseManagementAssociationId. 
        /// <para>
        /// The identifier of the release management association that this project maps to for
        /// automatic verification testing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ReleaseManagementAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseManagementAssociationId property is set.
        /// </summary>
        internal bool IsSetReleaseManagementAssociationId() => this.ReleaseManagementAssociationId != null;

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

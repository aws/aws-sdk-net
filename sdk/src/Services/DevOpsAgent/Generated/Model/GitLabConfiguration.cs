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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
        private string _instanceIdentifier;
        private string _projectId;
        private string _projectPath;

        /// <summary>
        /// Gets and sets the property InstanceIdentifier. 
        /// <para>
        /// GitLab instance identifier (e.g., gitlab.com or e2e.gamma.dev.us-east-1.gitlab.falco.ai.aws.dev)
        /// </para>
        /// </summary>
        public string InstanceIdentifier
        {
            get { return this._instanceIdentifier; }
            set { this._instanceIdentifier = value; }
        }

        // Check to see if InstanceIdentifier property is set
        internal bool IsSetInstanceIdentifier()
        {
            return this._instanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// GitLab numeric project ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProjectId
        {
            get { return this._projectId; }
            set { this._projectId = value; }
        }

        // Check to see if ProjectId property is set
        internal bool IsSetProjectId()
        {
            return this._projectId != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectPath. 
        /// <para>
        /// Full GitLab project path (e.g., namespace/project-name).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProjectPath
        {
            get { return this._projectPath; }
            set { this._projectPath = value; }
        }

        // Check to see if ProjectPath property is set
        internal bool IsSetProjectPath()
        {
            return this._projectPath != null;
        }

    }
}
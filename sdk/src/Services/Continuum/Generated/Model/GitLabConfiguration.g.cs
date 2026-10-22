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
    /// Configuration for a GitLab integration using a pasted access token.
    /// </summary>
    public partial class GitLabConfiguration
    {
        /// <summary>
        /// Gets and sets the property AccessToken. The GitLab access token (personal, group or
        /// project). Write-only; not stored or returned after creation. If the token carries
        /// the self-rotate scope, rotation is opted in and Continuum manages the token thereafter.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 512)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Checks to see if the AccessToken property is set.
        /// </summary>
        internal bool IsSetAccessToken() => this.AccessToken != null;

        /// <summary>
        /// Gets and sets the property InstanceUrl. The HTTPS base URL of the GitLab instance
        /// (gitlab.com or self-managed).
        /// </summary>
        [AWSProperty(Required = true, Min = 9, Max = 2083)]
        public string InstanceUrl { get; set; }

        /// <summary>
        /// Checks to see if the InstanceUrl property is set.
        /// </summary>
        internal bool IsSetInstanceUrl() => this.InstanceUrl != null;

        /// <summary>
        /// Gets and sets the property TargetPath. The group or project path the integration targets.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string TargetPath { get; set; }

        /// <summary>
        /// Checks to see if the TargetPath property is set.
        /// </summary>
        internal bool IsSetTargetPath() => this.TargetPath != null;

        /// <summary>
        /// Gets and sets the property TargetType. Whether the integration targets a group or
        /// a single project.
        /// </summary>
        [AWSProperty(Required = true)]
        public GitLabTargetType TargetType { get; set; }

        /// <summary>
        /// Checks to see if the TargetType property is set.
        /// </summary>
        internal bool IsSetTargetType() => this.TargetType != null;
    }
}

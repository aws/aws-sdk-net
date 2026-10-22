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
    /// Details for a GitLab integration.
    /// </summary>
    public partial class GitLabDetails
    {
        /// <summary>
        /// Gets and sets the property ExpiresAt. The expiry of the stored access token, for non-rotating
        /// tokens only. A rotated token's original expiry is stale, so this is omitted when tokenRotation
        /// is AUTOMATIC.
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceUrl. The HTTPS base URL of the GitLab instance.
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

        /// <summary>
        /// Gets and sets the property TokenRotation. How the integration's access token is rotated.
        /// AUTOMATIC only when the pasted token had the self-rotate scope and rotation was opted
        /// in at installation time.
        /// </summary>
        [AWSProperty(Required = true)]
        public GitLabTokenRotation TokenRotation { get; set; }

        /// <summary>
        /// Checks to see if the TokenRotation property is set.
        /// </summary>
        internal bool IsSetTokenRotation() => this.TokenRotation != null;
    }
}

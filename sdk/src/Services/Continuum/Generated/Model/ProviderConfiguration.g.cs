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
    /// Provider-specific configuration for creating an integration. Only one member may be
    /// specified.
    /// </summary>
    public partial class ProviderConfiguration
    {
        /// <summary>
        /// Gets and sets the property Github. Configuration for a GitHub.com integration.
        /// </summary>
        public GitHubConfiguration Github { get; set; }

        /// <summary>
        /// Checks to see if the Github property is set.
        /// </summary>
        internal bool IsSetGithub() => this.Github != null;

        /// <summary>
        /// Gets and sets the property Gitlab. Configuration for a GitLab integration.
        /// </summary>
        public GitLabConfiguration Gitlab { get; set; }

        /// <summary>
        /// Checks to see if the Gitlab property is set.
        /// </summary>
        internal bool IsSetGitlab() => this.Gitlab != null;

        /// <summary>
        /// Gets and sets the property S3. Configuration for a customer-managed S3 integration.
        /// </summary>
        public S3Configuration S3 { get; set; }

        /// <summary>
        /// Checks to see if the S3 property is set.
        /// </summary>
        internal bool IsSetS3() => this.S3 != null;
    }
}

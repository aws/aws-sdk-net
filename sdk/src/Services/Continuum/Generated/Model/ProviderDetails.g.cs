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
    /// Provider-specific details for an integration. Only one member will be present.
    /// </summary>
    public partial class ProviderDetails
    {
        /// <summary>
        /// Gets and sets the property Github. Details for a GitHub.com integration.
        /// </summary>
        public GitHubDetails Github { get; set; }

        /// <summary>
        /// Checks to see if the Github property is set.
        /// </summary>
        internal bool IsSetGithub() => this.Github != null;

        /// <summary>
        /// Gets and sets the property Gitlab. Details for a GitLab integration.
        /// </summary>
        public GitLabDetails Gitlab { get; set; }

        /// <summary>
        /// Checks to see if the Gitlab property is set.
        /// </summary>
        internal bool IsSetGitlab() => this.Gitlab != null;

        /// <summary>
        /// Gets and sets the property S3. Public details for a customer-managed S3 integration.
        /// </summary>
        public S3Details S3 { get; set; }

        /// <summary>
        /// Checks to see if the S3 property is set.
        /// </summary>
        internal bool IsSetS3() => this.S3 != null;
    }
}

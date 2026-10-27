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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Contains details required to update a code security integration with a specific repository
    /// provider.
    /// </summary>
    public partial class UpdateIntegrationDetails
    {
        /// <summary>
        /// Gets and sets the property Github. 
        /// <para>
        /// Details specific to updating an integration with GitHub.
        /// </para>
        /// </summary>
        public UpdateGitHubIntegrationDetail Github { get; set; }

        /// <summary>
        /// Checks to see if the Github property is set.
        /// </summary>
        internal bool IsSetGithub() => this.Github != null;

        /// <summary>
        /// Gets and sets the property GitlabSelfManaged. 
        /// <para>
        /// Details specific to updating an integration with a self-managed GitLab instance.
        /// </para>
        /// </summary>
        public UpdateGitLabSelfManagedIntegrationDetail GitlabSelfManaged { get; set; }

        /// <summary>
        /// Checks to see if the GitlabSelfManaged property is set.
        /// </summary>
        internal bool IsSetGitlabSelfManaged() => this.GitlabSelfManaged != null;
    }
}

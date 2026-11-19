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
    /// Contains the details required to update an integration with a GitHub Enterprise Server
    /// instance. Provide one of the following, depending on the step of the setup flow.
    /// </summary>
    public partial class UpdateGitHubEnterpriseServerIntegrationDetail
    {
        /// <summary>
        /// Gets and sets the property AppInstallation. 
        /// <para>
        /// Details for completing the GitHub App installation step of the GitHub Enterprise Server
        /// integration.
        /// </para>
        /// </summary>
        public UpdateGitHubEnterpriseServerAppInstallationDetail AppInstallation { get; set; }

        /// <summary>
        /// Checks to see if the AppInstallation property is set.
        /// </summary>
        internal bool IsSetAppInstallation() => this.AppInstallation != null;

        /// <summary>
        /// Gets and sets the property AppRegistration. 
        /// <para>
        /// Details for completing the GitHub App manifest registration step of the GitHub Enterprise
        /// Server integration.
        /// </para>
        /// </summary>
        public GitHubEnterpriseServerAppRegistrationDetail AppRegistration { get; set; }

        /// <summary>
        /// Checks to see if the AppRegistration property is set.
        /// </summary>
        internal bool IsSetAppRegistration() => this.AppRegistration != null;
    }
}

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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Contains configuration information about the scope for a webhook.
    /// </summary>
    public partial class ScopeConfiguration
    {
        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain of the GitHub Enterprise organization or the GitLab Self Managed group.
        /// Note that this parameter is only required if your project's source type is GITHUB_ENTERPRISE
        /// or GITLAB_SELF_MANAGED.
        /// </para>
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of either the group, enterprise, or organization that will send webhook events
        /// to CodeBuild, depending on the type of webhook.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The type of scope for a GitHub or GitLab webhook. The scope default is GITHUB_ORGANIZATION.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WebhookScopeType Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;
    }
}

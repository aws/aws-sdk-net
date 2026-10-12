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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// A reference to an issue created for a finding in a third-party issue tracker.
    /// </summary>
    public partial class LinkedIssue
    {
        /// <summary>
        /// Gets and sets the property IntegrationId. 
        /// <para>
        /// The integration identifier for the issue-tracker provider.
        /// </para>
        /// </summary>
        public string IntegrationId { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationId property is set.
        /// </summary>
        internal bool IsSetIntegrationId() => this.IntegrationId != null;

        /// <summary>
        /// Gets and sets the property IssueId. 
        /// <para>
        /// The stable numeric issue identifier.
        /// </para>
        /// </summary>
        public string IssueId { get; set; }

        /// <summary>
        /// Checks to see if the IssueId property is set.
        /// </summary>
        internal bool IsSetIssueId() => this.IssueId != null;

        /// <summary>
        /// Gets and sets the property IssueKey. 
        /// <para>
        /// The issue key.
        /// </para>
        /// </summary>
        public string IssueKey { get; set; }

        /// <summary>
        /// Checks to see if the IssueKey property is set.
        /// </summary>
        internal bool IsSetIssueKey() => this.IssueKey != null;

        /// <summary>
        /// Gets and sets the property IssueUrl. 
        /// <para>
        /// The issue URL.
        /// </para>
        /// </summary>
        public string IssueUrl { get; set; }

        /// <summary>
        /// Checks to see if the IssueUrl property is set.
        /// </summary>
        internal bool IsSetIssueUrl() => this.IssueUrl != null;

        /// <summary>
        /// Gets and sets the property ProjectKey. 
        /// <para>
        /// The key of the project the issue belongs to.
        /// </para>
        /// </summary>
        public string ProjectKey { get; set; }

        /// <summary>
        /// Checks to see if the ProjectKey property is set.
        /// </summary>
        internal bool IsSetProjectKey() => this.ProjectKey != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The issue-tracker provider.
        /// </para>
        /// </summary>
        public Provider Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property SiteUrl. 
        /// <para>
        /// The Atlassian Cloud site URL.
        /// </para>
        /// </summary>
        public string SiteUrl { get; set; }

        /// <summary>
        /// Checks to see if the SiteUrl property is set.
        /// </summary>
        internal bool IsSetSiteUrl() => this.SiteUrl != null;
    }
}

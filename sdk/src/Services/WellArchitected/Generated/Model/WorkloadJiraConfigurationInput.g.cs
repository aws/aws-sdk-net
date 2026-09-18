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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Workload-level: Input for the Jira configuration.
    /// </summary>
    public partial class WorkloadJiraConfigurationInput
    {
        /// <summary>
        /// Gets and sets the property IssueManagementStatus. 
        /// <para>
        /// Workload-level: Jira issue management status.
        /// </para>
        /// </summary>
        public WorkloadIssueManagementStatus IssueManagementStatus { get; set; }

        /// <summary>
        /// Checks to see if the IssueManagementStatus property is set.
        /// </summary>
        internal bool IsSetIssueManagementStatus() => this.IssueManagementStatus != null;

        /// <summary>
        /// Gets and sets the property IssueManagementType. 
        /// <para>
        /// Workload-level: Jira issue management type.
        /// </para>
        /// </summary>
        public IssueManagementType IssueManagementType { get; set; }

        /// <summary>
        /// Checks to see if the IssueManagementType property is set.
        /// </summary>
        internal bool IsSetIssueManagementType() => this.IssueManagementType != null;

        /// <summary>
        /// Gets and sets the property JiraProjectKey. 
        /// <para>
        /// Workload-level: Jira project key to sync workloads to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string JiraProjectKey { get; set; }

        /// <summary>
        /// Checks to see if the JiraProjectKey property is set.
        /// </summary>
        internal bool IsSetJiraProjectKey() => this.JiraProjectKey != null;
    }
}

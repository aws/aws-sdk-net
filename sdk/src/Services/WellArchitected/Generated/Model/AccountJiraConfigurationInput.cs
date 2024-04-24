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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
    /// Account-level: Input for the Jira configuration.
    /// </summary>
    public partial class AccountJiraConfigurationInput
    {
        private IntegrationStatusInput _integrationStatus;
        private AccountJiraIssueManagementStatus _issueManagementStatus;
        private IssueManagementType _issueManagementType;
        private string _jiraProjectKey;

        /// <summary>
        /// Gets and sets the property IntegrationStatus. 
        /// <para>
        /// Account-level: Configuration status of the Jira integration.
        /// </para>
        /// </summary>
        public IntegrationStatusInput IntegrationStatus
        {
            get { return this._integrationStatus; }
            set { this._integrationStatus = value; }
        }

        // Check to see if IntegrationStatus property is set
        internal bool IsSetIntegrationStatus()
        {
            return this._integrationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property IssueManagementStatus. 
        /// <para>
        /// Account-level: Jira issue management status.
        /// </para>
        /// </summary>
        public AccountJiraIssueManagementStatus IssueManagementStatus
        {
            get { return this._issueManagementStatus; }
            set { this._issueManagementStatus = value; }
        }

        // Check to see if IssueManagementStatus property is set
        internal bool IsSetIssueManagementStatus()
        {
            return this._issueManagementStatus != null;
        }

        /// <summary>
        /// Gets and sets the property IssueManagementType. 
        /// <para>
        /// Account-level: Jira issue management type.
        /// </para>
        /// </summary>
        public IssueManagementType IssueManagementType
        {
            get { return this._issueManagementType; }
            set { this._issueManagementType = value; }
        }

        // Check to see if IssueManagementType property is set
        internal bool IsSetIssueManagementType()
        {
            return this._issueManagementType != null;
        }

        /// <summary>
        /// Gets and sets the property JiraProjectKey. 
        /// <para>
        /// Account-level: Jira project key to sync workloads to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string JiraProjectKey
        {
            get { return this._jiraProjectKey; }
            set { this._jiraProjectKey = value; }
        }

        // Check to see if JiraProjectKey property is set
        internal bool IsSetJiraProjectKey()
        {
            return this._jiraProjectKey != null;
        }

    }
}
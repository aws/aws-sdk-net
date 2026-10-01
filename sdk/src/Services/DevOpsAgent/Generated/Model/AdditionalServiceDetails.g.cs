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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Union of service-specific details for different service types.
    /// </summary>
    public partial class AdditionalServiceDetails
    {
        /// <summary>
        /// Gets and sets the property Azuredevops. 
        /// <para>
        /// Azure DevOps specific service details.
        /// </para>
        /// </summary>
        public RegisteredAzureDevOpsServiceDetails Azuredevops { get; set; }

        /// <summary>
        /// Checks to see if the Azuredevops property is set.
        /// </summary>
        internal bool IsSetAzuredevops() => this.Azuredevops != null;

        /// <summary>
        /// Gets and sets the property Azureidentity. 
        /// <para>
        /// Azure identity details for services using Azure authentication.
        /// </para>
        /// </summary>
        public RegisteredAzureIdentityDetails Azureidentity { get; set; }

        /// <summary>
        /// Checks to see if the Azureidentity property is set.
        /// </summary>
        internal bool IsSetAzureidentity() => this.Azureidentity != null;

        /// <summary>
        /// Gets and sets the property Github. 
        /// <para>
        /// GitHub-specific service details.
        /// </para>
        /// </summary>
        public RegisteredGithubServiceDetails Github { get; set; }

        /// <summary>
        /// Checks to see if the Github property is set.
        /// </summary>
        internal bool IsSetGithub() => this.Github != null;

        /// <summary>
        /// Gets and sets the property Gitlab. 
        /// <para>
        /// GitLab-specific service details.
        /// </para>
        /// </summary>
        public RegisteredGitLabServiceDetails Gitlab { get; set; }

        /// <summary>
        /// Checks to see if the Gitlab property is set.
        /// </summary>
        internal bool IsSetGitlab() => this.Gitlab != null;

        /// <summary>
        /// Gets and sets the property Mcpserver. 
        /// <para>
        /// MCP server-specific service details.
        /// </para>
        /// </summary>
        public RegisteredMCPServerDetails Mcpserver { get; set; }

        /// <summary>
        /// Checks to see if the Mcpserver property is set.
        /// </summary>
        internal bool IsSetMcpserver() => this.Mcpserver != null;

        /// <summary>
        /// Gets and sets the property Mcpserverdatadog. 
        /// <para>
        /// Datadog MCP server-specific service details.
        /// </para>
        /// </summary>
        public RegisteredMCPServerDetails Mcpserverdatadog { get; set; }

        /// <summary>
        /// Checks to see if the Mcpserverdatadog property is set.
        /// </summary>
        internal bool IsSetMcpserverdatadog() => this.Mcpserverdatadog != null;

        /// <summary>
        /// Gets and sets the property Mcpservergrafana. 
        /// <para>
        /// Grafana MCP server-specific service details.
        /// </para>
        /// </summary>
        public RegisteredGrafanaServerDetails Mcpservergrafana { get; set; }

        /// <summary>
        /// Checks to see if the Mcpservergrafana property is set.
        /// </summary>
        internal bool IsSetMcpservergrafana() => this.Mcpservergrafana != null;

        /// <summary>
        /// Gets and sets the property Mcpservernewrelic. 
        /// <para>
        /// New Relic MCP server-specific service details.
        /// </para>
        /// </summary>
        public RegisteredNewRelicDetails Mcpservernewrelic { get; set; }

        /// <summary>
        /// Checks to see if the Mcpservernewrelic property is set.
        /// </summary>
        internal bool IsSetMcpservernewrelic() => this.Mcpservernewrelic != null;

        /// <summary>
        /// Gets and sets the property Mcpserversigv4. 
        /// <para>
        /// SigV4-authenticated MCP server-specific service details.
        /// </para>
        /// </summary>
        public RegisteredMCPServerSigV4Details Mcpserversigv4 { get; set; }

        /// <summary>
        /// Checks to see if the Mcpserversigv4 property is set.
        /// </summary>
        internal bool IsSetMcpserversigv4() => this.Mcpserversigv4 != null;

        /// <summary>
        /// Gets and sets the property Mcpserversplunk. 
        /// <para>
        /// Splunk MCP server-specific service details.
        /// </para>
        /// </summary>
        public RegisteredMCPServerDetails Mcpserversplunk { get; set; }

        /// <summary>
        /// Checks to see if the Mcpserversplunk property is set.
        /// </summary>
        internal bool IsSetMcpserversplunk() => this.Mcpserversplunk != null;

        /// <summary>
        /// Gets and sets the property Pagerduty. 
        /// <para>
        /// Pagerduty service details.
        /// </para>
        /// </summary>
        public RegisteredPagerDutyDetails Pagerduty { get; set; }

        /// <summary>
        /// Checks to see if the Pagerduty property is set.
        /// </summary>
        internal bool IsSetPagerduty() => this.Pagerduty != null;

        /// <summary>
        /// Gets and sets the property Remoteagent. 
        /// <para>
        /// Remote A2A agent-specific service details (token-based auth).
        /// </para>
        /// </summary>
        public RegisteredRemoteAgentDetails Remoteagent { get; set; }

        /// <summary>
        /// Checks to see if the Remoteagent property is set.
        /// </summary>
        internal bool IsSetRemoteagent() => this.Remoteagent != null;

        /// <summary>
        /// Gets and sets the property Remoteagentsigv4. 
        /// <para>
        /// Remote A2A agent-specific service details (SigV4 auth).
        /// </para>
        /// </summary>
        public RegisteredRemoteAgentSigV4Details Remoteagentsigv4 { get; set; }

        /// <summary>
        /// Checks to see if the Remoteagentsigv4 property is set.
        /// </summary>
        internal bool IsSetRemoteagentsigv4() => this.Remoteagentsigv4 != null;

        /// <summary>
        /// Gets and sets the property Servicenow. 
        /// <para>
        /// ServiceNow-specific service details.
        /// </para>
        /// </summary>
        public RegisteredServiceNowDetails Servicenow { get; set; }

        /// <summary>
        /// Checks to see if the Servicenow property is set.
        /// </summary>
        internal bool IsSetServicenow() => this.Servicenow != null;

        /// <summary>
        /// Gets and sets the property Slack. 
        /// <para>
        /// Slack-specific service details.
        /// </para>
        /// </summary>
        public RegisteredSlackServiceDetails Slack { get; set; }

        /// <summary>
        /// Checks to see if the Slack property is set.
        /// </summary>
        internal bool IsSetSlack() => this.Slack != null;
    }
}

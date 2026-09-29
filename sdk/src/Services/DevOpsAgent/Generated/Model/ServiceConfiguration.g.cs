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
    /// Union of all supported service configuration types. Each service has its own specific
    /// configuration structure.
    /// </summary>
    public partial class ServiceConfiguration
    {
        /// <summary>
        /// Gets and sets the property Aws. 
        /// <para>
        /// AWS monitor account configuration.
        /// </para>
        /// </summary>
        public AWSConfiguration Aws { get; set; }

        /// <summary>
        /// Checks to see if the Aws property is set.
        /// </summary>
        internal bool IsSetAws() => this.Aws != null;

        /// <summary>
        /// Gets and sets the property Azure. 
        /// <para>
        /// Azure subscription integration configuration.
        /// </para>
        /// </summary>
        public AzureConfiguration Azure { get; set; }

        /// <summary>
        /// Checks to see if the Azure property is set.
        /// </summary>
        internal bool IsSetAzure() => this.Azure != null;

        /// <summary>
        /// Gets and sets the property Azuredevops. 
        /// <para>
        /// Azure DevOps project integration configuration.
        /// </para>
        /// </summary>
        public AzureDevOpsConfiguration Azuredevops { get; set; }

        /// <summary>
        /// Checks to see if the Azuredevops property is set.
        /// </summary>
        internal bool IsSetAzuredevops() => this.Azuredevops != null;

        /// <summary>
        /// Gets and sets the property Dynatrace. 
        /// <para>
        /// Dynatrace monitoring integration configuration.
        /// </para>
        /// </summary>
        public DynatraceConfiguration Dynatrace { get; set; }

        /// <summary>
        /// Checks to see if the Dynatrace property is set.
        /// </summary>
        internal bool IsSetDynatrace() => this.Dynatrace != null;

        /// <summary>
        /// Gets and sets the property EventChannel. 
        /// <para>
        /// Event Channel instance integration configuration.
        /// </para>
        /// </summary>
        public EventChannelConfiguration EventChannel { get; set; }

        /// <summary>
        /// Checks to see if the EventChannel property is set.
        /// </summary>
        internal bool IsSetEventChannel() => this.EventChannel != null;

        /// <summary>
        /// Gets and sets the property Github. 
        /// <para>
        /// GitHub repository integration configuration.
        /// </para>
        /// </summary>
        public GitHubConfiguration Github { get; set; }

        /// <summary>
        /// Checks to see if the Github property is set.
        /// </summary>
        internal bool IsSetGithub() => this.Github != null;

        /// <summary>
        /// Gets and sets the property Gitlab. 
        /// <para>
        /// GitLab project integration configuration.
        /// </para>
        /// </summary>
        public GitLabConfiguration Gitlab { get; set; }

        /// <summary>
        /// Checks to see if the Gitlab property is set.
        /// </summary>
        internal bool IsSetGitlab() => this.Gitlab != null;

        /// <summary>
        /// Gets and sets the property Mcpserver. 
        /// <para>
        /// MCP (Model Context Protocol) server integration configuration.
        /// </para>
        /// </summary>
        public MCPServerConfiguration Mcpserver { get; set; }

        /// <summary>
        /// Checks to see if the Mcpserver property is set.
        /// </summary>
        internal bool IsSetMcpserver() => this.Mcpserver != null;

        /// <summary>
        /// Gets and sets the property Mcpserverdatadog. 
        /// <para>
        /// Datadog MCP server integration configuration.
        /// </para>
        /// </summary>
        public MCPServerDatadogConfiguration Mcpserverdatadog { get; set; }

        /// <summary>
        /// Checks to see if the Mcpserverdatadog property is set.
        /// </summary>
        internal bool IsSetMcpserverdatadog() => this.Mcpserverdatadog != null;

        /// <summary>
        /// Gets and sets the property Mcpservergrafana. 
        /// <para>
        /// Grafana MCP server integration configuration.
        /// </para>
        /// </summary>
        public MCPServerGrafanaConfiguration Mcpservergrafana { get; set; }

        /// <summary>
        /// Checks to see if the Mcpservergrafana property is set.
        /// </summary>
        internal bool IsSetMcpservergrafana() => this.Mcpservergrafana != null;

        /// <summary>
        /// Gets and sets the property Mcpservernewrelic. 
        /// <para>
        /// NewRelic instance integration configuration.
        /// </para>
        /// </summary>
        public MCPServerNewRelicConfiguration Mcpservernewrelic { get; set; }

        /// <summary>
        /// Checks to see if the Mcpservernewrelic property is set.
        /// </summary>
        internal bool IsSetMcpservernewrelic() => this.Mcpservernewrelic != null;

        /// <summary>
        /// Gets and sets the property Mcpserversigv4. 
        /// <para>
        /// SigV4-authenticated MCP server integration configuration.
        /// </para>
        /// </summary>
        public MCPServerSigV4Configuration Mcpserversigv4 { get; set; }

        /// <summary>
        /// Checks to see if the Mcpserversigv4 property is set.
        /// </summary>
        internal bool IsSetMcpserversigv4() => this.Mcpserversigv4 != null;

        /// <summary>
        /// Gets and sets the property Mcpserversplunk. 
        /// <para>
        /// Splunk MCP server integration configuration.
        /// </para>
        /// </summary>
        public MCPServerSplunkConfiguration Mcpserversplunk { get; set; }

        /// <summary>
        /// Checks to see if the Mcpserversplunk property is set.
        /// </summary>
        internal bool IsSetMcpserversplunk() => this.Mcpserversplunk != null;

        /// <summary>
        /// Gets and sets the property Pagerduty. 
        /// <para>
        /// PagerDuty integration configuration
        /// </para>
        /// </summary>
        public PagerDutyConfiguration Pagerduty { get; set; }

        /// <summary>
        /// Checks to see if the Pagerduty property is set.
        /// </summary>
        internal bool IsSetPagerduty() => this.Pagerduty != null;

        /// <summary>
        /// Gets and sets the property Remoteagent. 
        /// <para>
        /// Remote A2A agent integration configuration (token-based auth).
        /// </para>
        /// </summary>
        public RemoteAgentConfiguration Remoteagent { get; set; }

        /// <summary>
        /// Checks to see if the Remoteagent property is set.
        /// </summary>
        internal bool IsSetRemoteagent() => this.Remoteagent != null;

        /// <summary>
        /// Gets and sets the property Remoteagentsigv4. 
        /// <para>
        /// Remote A2A agent integration configuration (SigV4 auth).
        /// </para>
        /// </summary>
        public RemoteAgentSigV4Configuration Remoteagentsigv4 { get; set; }

        /// <summary>
        /// Checks to see if the Remoteagentsigv4 property is set.
        /// </summary>
        internal bool IsSetRemoteagentsigv4() => this.Remoteagentsigv4 != null;

        /// <summary>
        /// Gets and sets the property Servicenow. 
        /// <para>
        /// ServiceNow instance integration configuration.
        /// </para>
        /// </summary>
        public ServiceNowConfiguration Servicenow { get; set; }

        /// <summary>
        /// Checks to see if the Servicenow property is set.
        /// </summary>
        internal bool IsSetServicenow() => this.Servicenow != null;

        /// <summary>
        /// Gets and sets the property Slack. 
        /// <para>
        /// Slack workspace integration configuration.
        /// </para>
        /// </summary>
        public SlackConfiguration Slack { get; set; }

        /// <summary>
        /// Checks to see if the Slack property is set.
        /// </summary>
        internal bool IsSetSlack() => this.Slack != null;

        /// <summary>
        /// Gets and sets the property SourceAws. 
        /// <para>
        /// AWS source account configuration for monitoring resources.
        /// </para>
        /// </summary>
        public SourceAwsConfiguration SourceAws { get; set; }

        /// <summary>
        /// Checks to see if the SourceAws property is set.
        /// </summary>
        internal bool IsSetSourceAws() => this.SourceAws != null;
    }
}

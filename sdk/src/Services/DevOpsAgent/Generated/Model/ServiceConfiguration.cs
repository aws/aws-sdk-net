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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
        private AWSConfiguration _aws;
        private AzureConfiguration _azure;
        private AzureDevOpsConfiguration _azuredevops;
        private DynatraceConfiguration _dynatrace;
        private EventChannelConfiguration _eventChannel;
        private GitHubConfiguration _github;
        private GitLabConfiguration _gitlab;
        private MCPServerGrafanaConfiguration _mcpservergrafana;
        private MCPServerNewRelicConfiguration _mcpservernewrelic;
        private PagerDutyConfiguration _pagerduty;
        private ServiceNowConfiguration _servicenow;
        private SlackConfiguration _slack;
        private SourceAwsConfiguration _sourceAws;

        /// <summary>
        /// Gets and sets the property Aws. 
        /// <para>
        /// AWS monitor account configuration.
        /// </para>
        /// </summary>
        public AWSConfiguration Aws
        {
            get { return this._aws; }
            set { this._aws = value; }
        }

        // Check to see if Aws property is set
        internal bool IsSetAws()
        {
            return this._aws != null;
        }

        /// <summary>
        /// Gets and sets the property Azure. 
        /// <para>
        /// Azure subscription integration configuration.
        /// </para>
        /// </summary>
        public AzureConfiguration Azure
        {
            get { return this._azure; }
            set { this._azure = value; }
        }

        // Check to see if Azure property is set
        internal bool IsSetAzure()
        {
            return this._azure != null;
        }

        /// <summary>
        /// Gets and sets the property Azuredevops. 
        /// <para>
        /// Azure DevOps project integration configuration.
        /// </para>
        /// </summary>
        public AzureDevOpsConfiguration Azuredevops
        {
            get { return this._azuredevops; }
            set { this._azuredevops = value; }
        }

        // Check to see if Azuredevops property is set
        internal bool IsSetAzuredevops()
        {
            return this._azuredevops != null;
        }

        /// <summary>
        /// Gets and sets the property Dynatrace. 
        /// <para>
        /// Dynatrace monitoring integration configuration.
        /// </para>
        /// </summary>
        public DynatraceConfiguration Dynatrace
        {
            get { return this._dynatrace; }
            set { this._dynatrace = value; }
        }

        // Check to see if Dynatrace property is set
        internal bool IsSetDynatrace()
        {
            return this._dynatrace != null;
        }

        /// <summary>
        /// Gets and sets the property EventChannel. 
        /// <para>
        /// Event Channel instance integration configuration.
        /// </para>
        /// </summary>
        public EventChannelConfiguration EventChannel
        {
            get { return this._eventChannel; }
            set { this._eventChannel = value; }
        }

        // Check to see if EventChannel property is set
        internal bool IsSetEventChannel()
        {
            return this._eventChannel != null;
        }

        /// <summary>
        /// Gets and sets the property Github. 
        /// <para>
        /// GitHub repository integration configuration.
        /// </para>
        /// </summary>
        public GitHubConfiguration Github
        {
            get { return this._github; }
            set { this._github = value; }
        }

        // Check to see if Github property is set
        internal bool IsSetGithub()
        {
            return this._github != null;
        }

        /// <summary>
        /// Gets and sets the property Gitlab. 
        /// <para>
        /// GitLab project integration configuration.
        /// </para>
        /// </summary>
        public GitLabConfiguration Gitlab
        {
            get { return this._gitlab; }
            set { this._gitlab = value; }
        }

        // Check to see if Gitlab property is set
        internal bool IsSetGitlab()
        {
            return this._gitlab != null;
        }

        /// <summary>
        /// Gets and sets the property Mcpservergrafana. 
        /// <para>
        /// Grafana MCP server integration configuration.
        /// </para>
        /// </summary>
        public MCPServerGrafanaConfiguration Mcpservergrafana
        {
            get { return this._mcpservergrafana; }
            set { this._mcpservergrafana = value; }
        }

        // Check to see if Mcpservergrafana property is set
        internal bool IsSetMcpservergrafana()
        {
            return this._mcpservergrafana != null;
        }

        /// <summary>
        /// Gets and sets the property Mcpservernewrelic. 
        /// <para>
        /// NewRelic instance integration configuration.
        /// </para>
        /// </summary>
        public MCPServerNewRelicConfiguration Mcpservernewrelic
        {
            get { return this._mcpservernewrelic; }
            set { this._mcpservernewrelic = value; }
        }

        // Check to see if Mcpservernewrelic property is set
        internal bool IsSetMcpservernewrelic()
        {
            return this._mcpservernewrelic != null;
        }

        /// <summary>
        /// Gets and sets the property Pagerduty. 
        /// <para>
        /// PagerDuty integration configuration
        /// </para>
        /// </summary>
        public PagerDutyConfiguration Pagerduty
        {
            get { return this._pagerduty; }
            set { this._pagerduty = value; }
        }

        // Check to see if Pagerduty property is set
        internal bool IsSetPagerduty()
        {
            return this._pagerduty != null;
        }

        /// <summary>
        /// Gets and sets the property Servicenow. 
        /// <para>
        /// ServiceNow instance integration configuration.
        /// </para>
        /// </summary>
        public ServiceNowConfiguration Servicenow
        {
            get { return this._servicenow; }
            set { this._servicenow = value; }
        }

        // Check to see if Servicenow property is set
        internal bool IsSetServicenow()
        {
            return this._servicenow != null;
        }

        /// <summary>
        /// Gets and sets the property Slack. 
        /// <para>
        /// Slack workspace integration configuration.
        /// </para>
        /// </summary>
        public SlackConfiguration Slack
        {
            get { return this._slack; }
            set { this._slack = value; }
        }

        // Check to see if Slack property is set
        internal bool IsSetSlack()
        {
            return this._slack != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAws. 
        /// <para>
        /// AWS source account configuration for monitoring resources.
        /// </para>
        /// </summary>
        public SourceAwsConfiguration SourceAws
        {
            get { return this._sourceAws; }
            set { this._sourceAws = value; }
        }

        // Check to see if SourceAws property is set
        internal bool IsSetSourceAws()
        {
            return this._sourceAws != null;
        }

    }
}
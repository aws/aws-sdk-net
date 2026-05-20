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
    /// Union of service-specific details for different service types.
    /// </summary>
    public partial class AdditionalServiceDetails
    {
        private RegisteredAzureDevOpsServiceDetails _azuredevops;
        private RegisteredAzureIdentityDetails _azureidentity;
        private RegisteredGithubServiceDetails _github;
        private RegisteredGitLabServiceDetails _gitlab;
        private RegisteredMCPServerDetails _mcpserver;
        private RegisteredMCPServerDetails _mcpserverdatadog;
        private RegisteredGrafanaServerDetails _mcpservergrafana;
        private RegisteredNewRelicDetails _mcpservernewrelic;
        private RegisteredMCPServerSigV4Details _mcpserversigv4;
        private RegisteredMCPServerDetails _mcpserversplunk;
        private RegisteredPagerDutyDetails _pagerduty;
        private RegisteredServiceNowDetails _servicenow;
        private RegisteredSlackServiceDetails _slack;

        /// <summary>
        /// Gets and sets the property Azuredevops. 
        /// <para>
        /// Azure DevOps specific service details.
        /// </para>
        /// </summary>
        public RegisteredAzureDevOpsServiceDetails Azuredevops
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
        /// Gets and sets the property Azureidentity. 
        /// <para>
        /// Azure identity details for services using Azure authentication.
        /// </para>
        /// </summary>
        public RegisteredAzureIdentityDetails Azureidentity
        {
            get { return this._azureidentity; }
            set { this._azureidentity = value; }
        }

        // Check to see if Azureidentity property is set
        internal bool IsSetAzureidentity()
        {
            return this._azureidentity != null;
        }

        /// <summary>
        /// Gets and sets the property Github. 
        /// <para>
        /// GitHub-specific service details.
        /// </para>
        /// </summary>
        public RegisteredGithubServiceDetails Github
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
        /// GitLab-specific service details.
        /// </para>
        /// </summary>
        public RegisteredGitLabServiceDetails Gitlab
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
        /// Gets and sets the property Mcpserver. 
        /// <para>
        /// MCP server-specific service details.
        /// </para>
        /// </summary>
        public RegisteredMCPServerDetails Mcpserver
        {
            get { return this._mcpserver; }
            set { this._mcpserver = value; }
        }

        // Check to see if Mcpserver property is set
        internal bool IsSetMcpserver()
        {
            return this._mcpserver != null;
        }

        /// <summary>
        /// Gets and sets the property Mcpserverdatadog. 
        /// <para>
        /// Datadog MCP server-specific service details.
        /// </para>
        /// </summary>
        public RegisteredMCPServerDetails Mcpserverdatadog
        {
            get { return this._mcpserverdatadog; }
            set { this._mcpserverdatadog = value; }
        }

        // Check to see if Mcpserverdatadog property is set
        internal bool IsSetMcpserverdatadog()
        {
            return this._mcpserverdatadog != null;
        }

        /// <summary>
        /// Gets and sets the property Mcpservergrafana. 
        /// <para>
        /// Grafana MCP server-specific service details.
        /// </para>
        /// </summary>
        public RegisteredGrafanaServerDetails Mcpservergrafana
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
        /// New Relic MCP server-specific service details.
        /// </para>
        /// </summary>
        public RegisteredNewRelicDetails Mcpservernewrelic
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
        /// Gets and sets the property Mcpserversigv4. 
        /// <para>
        /// SigV4-authenticated MCP server-specific service details.
        /// </para>
        /// </summary>
        public RegisteredMCPServerSigV4Details Mcpserversigv4
        {
            get { return this._mcpserversigv4; }
            set { this._mcpserversigv4 = value; }
        }

        // Check to see if Mcpserversigv4 property is set
        internal bool IsSetMcpserversigv4()
        {
            return this._mcpserversigv4 != null;
        }

        /// <summary>
        /// Gets and sets the property Mcpserversplunk. 
        /// <para>
        /// Splunk MCP server-specific service details.
        /// </para>
        /// </summary>
        public RegisteredMCPServerDetails Mcpserversplunk
        {
            get { return this._mcpserversplunk; }
            set { this._mcpserversplunk = value; }
        }

        // Check to see if Mcpserversplunk property is set
        internal bool IsSetMcpserversplunk()
        {
            return this._mcpserversplunk != null;
        }

        /// <summary>
        /// Gets and sets the property Pagerduty. 
        /// <para>
        /// Pagerduty service details.
        /// </para>
        /// </summary>
        public RegisteredPagerDutyDetails Pagerduty
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
        /// ServiceNow-specific service details.
        /// </para>
        /// </summary>
        public RegisteredServiceNowDetails Servicenow
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
        /// Slack-specific service details.
        /// </para>
        /// </summary>
        public RegisteredSlackServiceDetails Slack
        {
            get { return this._slack; }
            set { this._slack = value; }
        }

        // Check to see if Slack property is set
        internal bool IsSetSlack()
        {
            return this._slack != null;
        }

    }
}
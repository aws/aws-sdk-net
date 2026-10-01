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
    /// Union of service-specific configuration details for service registration.
    /// </summary>
    public partial class ServiceDetails
    {
        /// <summary>
        /// Gets and sets the property Azureidentity. 
        /// <para>
        /// Azure integration with AWS Outbound Identity Federation specific service details.
        /// </para>
        /// </summary>
        public RegisteredAzureIdentityDetails Azureidentity { get; set; }

        /// <summary>
        /// Checks to see if the Azureidentity property is set.
        /// </summary>
        internal bool IsSetAzureidentity() => this.Azureidentity != null;

        /// <summary>
        /// Gets and sets the property Dynatrace. 
        /// <para>
        /// Dynatrace-specific service details.
        /// </para>
        /// </summary>
        public DynatraceServiceDetails Dynatrace { get; set; }

        /// <summary>
        /// Checks to see if the Dynatrace property is set.
        /// </summary>
        internal bool IsSetDynatrace() => this.Dynatrace != null;

        /// <summary>
        /// Gets and sets the property EventChannel. 
        /// <para>
        /// Event Channel specific service details.
        /// </para>
        /// </summary>
        public EventChannelDetails EventChannel { get; set; }

        /// <summary>
        /// Checks to see if the EventChannel property is set.
        /// </summary>
        internal bool IsSetEventChannel() => this.EventChannel != null;

        /// <summary>
        /// Gets and sets the property Gitlab. 
        /// <para>
        /// GitLab-specific service details.
        /// </para>
        /// </summary>
        public GitLabDetails Gitlab { get; set; }

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
        public MCPServerDetails Mcpserver { get; set; }

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
        public DatadogServiceDetails Mcpserverdatadog { get; set; }

        /// <summary>
        /// Checks to see if the Mcpserverdatadog property is set.
        /// </summary>
        internal bool IsSetMcpserverdatadog() => this.Mcpserverdatadog != null;

        /// <summary>
        /// Gets and sets the property Mcpservergrafana. 
        /// <para>
        /// Datadog MCP server-specific service details.
        /// </para>
        /// </summary>
        public GrafanaServiceDetails Mcpservergrafana { get; set; }

        /// <summary>
        /// Checks to see if the Mcpservergrafana property is set.
        /// </summary>
        internal bool IsSetMcpservergrafana() => this.Mcpservergrafana != null;

        /// <summary>
        /// Gets and sets the property Mcpservernewrelic. 
        /// <para>
        /// New Relic-specific service details.
        /// </para>
        /// </summary>
        public NewRelicServiceDetails Mcpservernewrelic { get; set; }

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
        public MCPServerSigV4ServiceDetails Mcpserversigv4 { get; set; }

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
        public MCPServerDetails Mcpserversplunk { get; set; }

        /// <summary>
        /// Checks to see if the Mcpserversplunk property is set.
        /// </summary>
        internal bool IsSetMcpserversplunk() => this.Mcpserversplunk != null;

        /// <summary>
        /// Gets and sets the property Pagerduty. 
        /// <para>
        /// PagerDuty specific service details.
        /// </para>
        /// </summary>
        public PagerDutyDetails Pagerduty { get; set; }

        /// <summary>
        /// Checks to see if the Pagerduty property is set.
        /// </summary>
        internal bool IsSetPagerduty() => this.Pagerduty != null;

        /// <summary>
        /// Gets and sets the property Remoteagent. 
        /// <para>
        /// Remote A2A agent service details (token-based auth).
        /// </para>
        /// </summary>
        public RemoteAgentServiceDetails Remoteagent { get; set; }

        /// <summary>
        /// Checks to see if the Remoteagent property is set.
        /// </summary>
        internal bool IsSetRemoteagent() => this.Remoteagent != null;

        /// <summary>
        /// Gets and sets the property Remoteagentsigv4. 
        /// <para>
        /// Remote A2A agent service details (SigV4 auth).
        /// </para>
        /// </summary>
        public RemoteAgentSigV4ServiceDetails Remoteagentsigv4 { get; set; }

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
        public ServiceNowServiceDetails Servicenow { get; set; }

        /// <summary>
        /// Checks to see if the Servicenow property is set.
        /// </summary>
        internal bool IsSetServicenow() => this.Servicenow != null;
    }
}

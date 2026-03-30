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
    /// Union of service-specific configuration details for service registration.
    /// </summary>
    public partial class ServiceDetails
    {
        private RegisteredAzureIdentityDetails _azureidentity;
        private DynatraceServiceDetails _dynatrace;
        private EventChannelDetails _eventChannel;
        private GitLabDetails _gitlab;
        private MCPServerDetails _mcpserver;
        private DatadogServiceDetails _mcpserverdatadog;
        private GrafanaServiceDetails _mcpservergrafana;
        private NewRelicServiceDetails _mcpservernewrelic;
        private MCPServerSigV4ServiceDetails _mcpserversigv4;
        private MCPServerDetails _mcpserversplunk;
        private PagerDutyDetails _pagerduty;
        private ServiceNowServiceDetails _servicenow;

        /// <summary>
        /// Gets and sets the property Azureidentity. 
        /// <para>
        /// Azure integration with AWS Outbound Identity Federation specific service details.
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
        /// Gets and sets the property Dynatrace. 
        /// <para>
        /// Dynatrace-specific service details.
        /// </para>
        /// </summary>
        public DynatraceServiceDetails Dynatrace
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
        /// Event Channel specific service details.
        /// </para>
        /// </summary>
        public EventChannelDetails EventChannel
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
        /// Gets and sets the property Gitlab. 
        /// <para>
        /// GitLab-specific service details.
        /// </para>
        /// </summary>
        public GitLabDetails Gitlab
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
        public MCPServerDetails Mcpserver
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
        public DatadogServiceDetails Mcpserverdatadog
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
        /// Datadog MCP server-specific service details.
        /// </para>
        /// </summary>
        public GrafanaServiceDetails Mcpservergrafana
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
        /// New Relic-specific service details.
        /// </para>
        /// </summary>
        public NewRelicServiceDetails Mcpservernewrelic
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
        public MCPServerSigV4ServiceDetails Mcpserversigv4
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
        public MCPServerDetails Mcpserversplunk
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
        /// PagerDuty specific service details.
        /// </para>
        /// </summary>
        public PagerDutyDetails Pagerduty
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
        public ServiceNowServiceDetails Servicenow
        {
            get { return this._servicenow; }
            set { this._servicenow = value; }
        }

        // Check to see if Servicenow property is set
        internal bool IsSetServicenow()
        {
            return this._servicenow != null;
        }

    }
}
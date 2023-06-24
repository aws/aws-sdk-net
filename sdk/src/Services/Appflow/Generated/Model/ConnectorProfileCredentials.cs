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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The connector-specific credentials required by a connector.
    /// </summary>
    public partial class ConnectorProfileCredentials
    {
        private AmplitudeConnectorProfileCredentials _amplitude;
        private CustomConnectorProfileCredentials _customConnector;
        private DatadogConnectorProfileCredentials _datadog;
        private DynatraceConnectorProfileCredentials _dynatrace;
        private GoogleAnalyticsConnectorProfileCredentials _googleAnalytics;
        private HoneycodeConnectorProfileCredentials _honeycode;
        private InforNexusConnectorProfileCredentials _inforNexus;
        private MarketoConnectorProfileCredentials _marketo;
        private PardotConnectorProfileCredentials _pardot;
        private RedshiftConnectorProfileCredentials _redshift;
        private SalesforceConnectorProfileCredentials _salesforce;
        private SAPODataConnectorProfileCredentials _sapoData;
        private ServiceNowConnectorProfileCredentials _serviceNow;
        private SingularConnectorProfileCredentials _singular;
        private SlackConnectorProfileCredentials _slack;
        private SnowflakeConnectorProfileCredentials _snowflake;
        private TrendmicroConnectorProfileCredentials _trendmicro;
        private VeevaConnectorProfileCredentials _veeva;
        private ZendeskConnectorProfileCredentials _zendesk;

        /// <summary>
        /// Gets and sets the property Amplitude. 
        /// <para>
        ///  The connector-specific credentials required when using Amplitude. 
        /// </para>
        /// </summary>
        public AmplitudeConnectorProfileCredentials Amplitude
        {
            get { return this._amplitude; }
            set { this._amplitude = value; }
        }

        // Check to see if Amplitude property is set
        internal bool IsSetAmplitude()
        {
            return this._amplitude != null;
        }

        /// <summary>
        /// Gets and sets the property CustomConnector.
        /// </summary>
        public CustomConnectorProfileCredentials CustomConnector
        {
            get { return this._customConnector; }
            set { this._customConnector = value; }
        }

        // Check to see if CustomConnector property is set
        internal bool IsSetCustomConnector()
        {
            return this._customConnector != null;
        }

        /// <summary>
        /// Gets and sets the property Datadog. 
        /// <para>
        ///  The connector-specific credentials required when using Datadog. 
        /// </para>
        /// </summary>
        public DatadogConnectorProfileCredentials Datadog
        {
            get { return this._datadog; }
            set { this._datadog = value; }
        }

        // Check to see if Datadog property is set
        internal bool IsSetDatadog()
        {
            return this._datadog != null;
        }

        /// <summary>
        /// Gets and sets the property Dynatrace. 
        /// <para>
        ///  The connector-specific credentials required when using Dynatrace. 
        /// </para>
        /// </summary>
        public DynatraceConnectorProfileCredentials Dynatrace
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
        /// Gets and sets the property GoogleAnalytics. 
        /// <para>
        ///  The connector-specific credentials required when using Google Analytics. 
        /// </para>
        /// </summary>
        public GoogleAnalyticsConnectorProfileCredentials GoogleAnalytics
        {
            get { return this._googleAnalytics; }
            set { this._googleAnalytics = value; }
        }

        // Check to see if GoogleAnalytics property is set
        internal bool IsSetGoogleAnalytics()
        {
            return this._googleAnalytics != null;
        }

        /// <summary>
        /// Gets and sets the property Honeycode. 
        /// <para>
        ///  The connector-specific credentials required when using Amazon Honeycode. 
        /// </para>
        /// </summary>
        public HoneycodeConnectorProfileCredentials Honeycode
        {
            get { return this._honeycode; }
            set { this._honeycode = value; }
        }

        // Check to see if Honeycode property is set
        internal bool IsSetHoneycode()
        {
            return this._honeycode != null;
        }

        /// <summary>
        /// Gets and sets the property InforNexus. 
        /// <para>
        ///  The connector-specific credentials required when using Infor Nexus. 
        /// </para>
        /// </summary>
        public InforNexusConnectorProfileCredentials InforNexus
        {
            get { return this._inforNexus; }
            set { this._inforNexus = value; }
        }

        // Check to see if InforNexus property is set
        internal bool IsSetInforNexus()
        {
            return this._inforNexus != null;
        }

        /// <summary>
        /// Gets and sets the property Marketo. 
        /// <para>
        ///  The connector-specific credentials required when using Marketo. 
        /// </para>
        /// </summary>
        public MarketoConnectorProfileCredentials Marketo
        {
            get { return this._marketo; }
            set { this._marketo = value; }
        }

        // Check to see if Marketo property is set
        internal bool IsSetMarketo()
        {
            return this._marketo != null;
        }

        /// <summary>
        /// Gets and sets the property Pardot. 
        /// <para>
        /// The connector-specific credentials required when using Salesforce Pardot.
        /// </para>
        /// </summary>
        public PardotConnectorProfileCredentials Pardot
        {
            get { return this._pardot; }
            set { this._pardot = value; }
        }

        // Check to see if Pardot property is set
        internal bool IsSetPardot()
        {
            return this._pardot != null;
        }

        /// <summary>
        /// Gets and sets the property Redshift. 
        /// <para>
        ///  The connector-specific credentials required when using Amazon Redshift. 
        /// </para>
        /// </summary>
        public RedshiftConnectorProfileCredentials Redshift
        {
            get { return this._redshift; }
            set { this._redshift = value; }
        }

        // Check to see if Redshift property is set
        internal bool IsSetRedshift()
        {
            return this._redshift != null;
        }

        /// <summary>
        /// Gets and sets the property Salesforce. 
        /// <para>
        ///  The connector-specific credentials required when using Salesforce. 
        /// </para>
        /// </summary>
        public SalesforceConnectorProfileCredentials Salesforce
        {
            get { return this._salesforce; }
            set { this._salesforce = value; }
        }

        // Check to see if Salesforce property is set
        internal bool IsSetSalesforce()
        {
            return this._salesforce != null;
        }

        /// <summary>
        /// Gets and sets the property SAPOData.
        /// </summary>
        public SAPODataConnectorProfileCredentials SAPOData
        {
            get { return this._sapoData; }
            set { this._sapoData = value; }
        }

        // Check to see if SAPOData property is set
        internal bool IsSetSAPOData()
        {
            return this._sapoData != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNow. 
        /// <para>
        ///  The connector-specific credentials required when using ServiceNow. 
        /// </para>
        /// </summary>
        public ServiceNowConnectorProfileCredentials ServiceNow
        {
            get { return this._serviceNow; }
            set { this._serviceNow = value; }
        }

        // Check to see if ServiceNow property is set
        internal bool IsSetServiceNow()
        {
            return this._serviceNow != null;
        }

        /// <summary>
        /// Gets and sets the property Singular. 
        /// <para>
        ///  The connector-specific credentials required when using Singular. 
        /// </para>
        /// </summary>
        public SingularConnectorProfileCredentials Singular
        {
            get { return this._singular; }
            set { this._singular = value; }
        }

        // Check to see if Singular property is set
        internal bool IsSetSingular()
        {
            return this._singular != null;
        }

        /// <summary>
        /// Gets and sets the property Slack. 
        /// <para>
        ///  The connector-specific credentials required when using Slack. 
        /// </para>
        /// </summary>
        public SlackConnectorProfileCredentials Slack
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
        /// Gets and sets the property Snowflake. 
        /// <para>
        ///  The connector-specific credentials required when using Snowflake. 
        /// </para>
        /// </summary>
        public SnowflakeConnectorProfileCredentials Snowflake
        {
            get { return this._snowflake; }
            set { this._snowflake = value; }
        }

        // Check to see if Snowflake property is set
        internal bool IsSetSnowflake()
        {
            return this._snowflake != null;
        }

        /// <summary>
        /// Gets and sets the property Trendmicro. 
        /// <para>
        ///  The connector-specific credentials required when using Trend Micro. 
        /// </para>
        /// </summary>
        public TrendmicroConnectorProfileCredentials Trendmicro
        {
            get { return this._trendmicro; }
            set { this._trendmicro = value; }
        }

        // Check to see if Trendmicro property is set
        internal bool IsSetTrendmicro()
        {
            return this._trendmicro != null;
        }

        /// <summary>
        /// Gets and sets the property Veeva. 
        /// <para>
        ///  The connector-specific credentials required when using Veeva. 
        /// </para>
        /// </summary>
        public VeevaConnectorProfileCredentials Veeva
        {
            get { return this._veeva; }
            set { this._veeva = value; }
        }

        // Check to see if Veeva property is set
        internal bool IsSetVeeva()
        {
            return this._veeva != null;
        }

        /// <summary>
        /// Gets and sets the property Zendesk. 
        /// <para>
        ///  The connector-specific credentials required when using Zendesk. 
        /// </para>
        /// </summary>
        public ZendeskConnectorProfileCredentials Zendesk
        {
            get { return this._zendesk; }
            set { this._zendesk = value; }
        }

        // Check to see if Zendesk property is set
        internal bool IsSetZendesk()
        {
            return this._zendesk != null;
        }

    }
}
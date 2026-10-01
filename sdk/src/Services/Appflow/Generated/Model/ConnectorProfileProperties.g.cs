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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The connector-specific profile properties required by each connector.
    /// </summary>
    public partial class ConnectorProfileProperties
    {
        /// <summary>
        /// Gets and sets the property Amplitude. 
        /// <para>
        ///  The connector-specific properties required by Amplitude. 
        /// </para>
        /// </summary>
        public AmplitudeConnectorProfileProperties Amplitude { get; set; }

        /// <summary>
        /// Checks to see if the Amplitude property is set.
        /// </summary>
        internal bool IsSetAmplitude() => this.Amplitude != null;

        /// <summary>
        /// Gets and sets the property CustomConnector. 
        /// <para>
        /// The properties required by the custom connector.
        /// </para>
        /// </summary>
        public CustomConnectorProfileProperties CustomConnector { get; set; }

        /// <summary>
        /// Checks to see if the CustomConnector property is set.
        /// </summary>
        internal bool IsSetCustomConnector() => this.CustomConnector != null;

        /// <summary>
        /// Gets and sets the property Datadog. 
        /// <para>
        ///  The connector-specific properties required by Datadog. 
        /// </para>
        /// </summary>
        public DatadogConnectorProfileProperties Datadog { get; set; }

        /// <summary>
        /// Checks to see if the Datadog property is set.
        /// </summary>
        internal bool IsSetDatadog() => this.Datadog != null;

        /// <summary>
        /// Gets and sets the property Dynatrace. 
        /// <para>
        ///  The connector-specific properties required by Dynatrace. 
        /// </para>
        /// </summary>
        public DynatraceConnectorProfileProperties Dynatrace { get; set; }

        /// <summary>
        /// Checks to see if the Dynatrace property is set.
        /// </summary>
        internal bool IsSetDynatrace() => this.Dynatrace != null;

        /// <summary>
        /// Gets and sets the property GoogleAnalytics. 
        /// <para>
        ///  The connector-specific properties required Google Analytics. 
        /// </para>
        /// </summary>
        public GoogleAnalyticsConnectorProfileProperties GoogleAnalytics { get; set; }

        /// <summary>
        /// Checks to see if the GoogleAnalytics property is set.
        /// </summary>
        internal bool IsSetGoogleAnalytics() => this.GoogleAnalytics != null;

        /// <summary>
        /// Gets and sets the property Honeycode. 
        /// <para>
        ///  The connector-specific properties required by Amazon Honeycode. 
        /// </para>
        /// </summary>
        public HoneycodeConnectorProfileProperties Honeycode { get; set; }

        /// <summary>
        /// Checks to see if the Honeycode property is set.
        /// </summary>
        internal bool IsSetHoneycode() => this.Honeycode != null;

        /// <summary>
        /// Gets and sets the property InforNexus. 
        /// <para>
        ///  The connector-specific properties required by Infor Nexus. 
        /// </para>
        /// </summary>
        public InforNexusConnectorProfileProperties InforNexus { get; set; }

        /// <summary>
        /// Checks to see if the InforNexus property is set.
        /// </summary>
        internal bool IsSetInforNexus() => this.InforNexus != null;

        /// <summary>
        /// Gets and sets the property Marketo. 
        /// <para>
        ///  The connector-specific properties required by Marketo. 
        /// </para>
        /// </summary>
        public MarketoConnectorProfileProperties Marketo { get; set; }

        /// <summary>
        /// Checks to see if the Marketo property is set.
        /// </summary>
        internal bool IsSetMarketo() => this.Marketo != null;

        /// <summary>
        /// Gets and sets the property Pardot. 
        /// <para>
        /// The connector-specific properties required by Salesforce Pardot.
        /// </para>
        /// </summary>
        public PardotConnectorProfileProperties Pardot { get; set; }

        /// <summary>
        /// Checks to see if the Pardot property is set.
        /// </summary>
        internal bool IsSetPardot() => this.Pardot != null;

        /// <summary>
        /// Gets and sets the property Redshift. 
        /// <para>
        ///  The connector-specific properties required by Amazon Redshift. 
        /// </para>
        /// </summary>
        public RedshiftConnectorProfileProperties Redshift { get; set; }

        /// <summary>
        /// Checks to see if the Redshift property is set.
        /// </summary>
        internal bool IsSetRedshift() => this.Redshift != null;

        /// <summary>
        /// Gets and sets the property SAPOData.
        /// </summary>
        public SAPODataConnectorProfileProperties SAPOData { get; set; }

        /// <summary>
        /// Checks to see if the SAPOData property is set.
        /// </summary>
        internal bool IsSetSAPOData() => this.SAPOData != null;

        /// <summary>
        /// Gets and sets the property Salesforce. 
        /// <para>
        ///  The connector-specific properties required by Salesforce. 
        /// </para>
        /// </summary>
        public SalesforceConnectorProfileProperties Salesforce { get; set; }

        /// <summary>
        /// Checks to see if the Salesforce property is set.
        /// </summary>
        internal bool IsSetSalesforce() => this.Salesforce != null;

        /// <summary>
        /// Gets and sets the property ServiceNow. 
        /// <para>
        ///  The connector-specific properties required by serviceNow. 
        /// </para>
        /// </summary>
        public ServiceNowConnectorProfileProperties ServiceNow { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNow property is set.
        /// </summary>
        internal bool IsSetServiceNow() => this.ServiceNow != null;

        /// <summary>
        /// Gets and sets the property Singular. 
        /// <para>
        ///  The connector-specific properties required by Singular. 
        /// </para>
        /// </summary>
        public SingularConnectorProfileProperties Singular { get; set; }

        /// <summary>
        /// Checks to see if the Singular property is set.
        /// </summary>
        internal bool IsSetSingular() => this.Singular != null;

        /// <summary>
        /// Gets and sets the property Slack. 
        /// <para>
        ///  The connector-specific properties required by Slack. 
        /// </para>
        /// </summary>
        public SlackConnectorProfileProperties Slack { get; set; }

        /// <summary>
        /// Checks to see if the Slack property is set.
        /// </summary>
        internal bool IsSetSlack() => this.Slack != null;

        /// <summary>
        /// Gets and sets the property Snowflake. 
        /// <para>
        ///  The connector-specific properties required by Snowflake. 
        /// </para>
        /// </summary>
        public SnowflakeConnectorProfileProperties Snowflake { get; set; }

        /// <summary>
        /// Checks to see if the Snowflake property is set.
        /// </summary>
        internal bool IsSetSnowflake() => this.Snowflake != null;

        /// <summary>
        /// Gets and sets the property Trendmicro. 
        /// <para>
        ///  The connector-specific properties required by Trend Micro. 
        /// </para>
        /// </summary>
        public TrendmicroConnectorProfileProperties Trendmicro { get; set; }

        /// <summary>
        /// Checks to see if the Trendmicro property is set.
        /// </summary>
        internal bool IsSetTrendmicro() => this.Trendmicro != null;

        /// <summary>
        /// Gets and sets the property Veeva. 
        /// <para>
        ///  The connector-specific properties required by Veeva. 
        /// </para>
        /// </summary>
        public VeevaConnectorProfileProperties Veeva { get; set; }

        /// <summary>
        /// Checks to see if the Veeva property is set.
        /// </summary>
        internal bool IsSetVeeva() => this.Veeva != null;

        /// <summary>
        /// Gets and sets the property Zendesk. 
        /// <para>
        ///  The connector-specific properties required by Zendesk. 
        /// </para>
        /// </summary>
        public ZendeskConnectorProfileProperties Zendesk { get; set; }

        /// <summary>
        /// Checks to see if the Zendesk property is set.
        /// </summary>
        internal bool IsSetZendesk() => this.Zendesk != null;
    }
}

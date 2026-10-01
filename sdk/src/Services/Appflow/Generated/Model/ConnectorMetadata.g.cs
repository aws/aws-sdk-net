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
    /// A structure to specify connector-specific metadata such as <c>oAuthScopes</c>, <c>supportedRegions</c>,
    /// <c>privateLinkServiceUrl</c>, and so on.
    /// </summary>
    public partial class ConnectorMetadata
    {
        /// <summary>
        /// Gets and sets the property Amplitude. 
        /// <para>
        ///  The connector metadata specific to Amplitude. 
        /// </para>
        /// </summary>
        public AmplitudeMetadata Amplitude { get; set; }

        /// <summary>
        /// Checks to see if the Amplitude property is set.
        /// </summary>
        internal bool IsSetAmplitude() => this.Amplitude != null;

        /// <summary>
        /// Gets and sets the property CustomerProfiles. 
        /// <para>
        ///  The connector metadata specific to Connect Customer Customer Profiles. 
        /// </para>
        /// </summary>
        public CustomerProfilesMetadata CustomerProfiles { get; set; }

        /// <summary>
        /// Checks to see if the CustomerProfiles property is set.
        /// </summary>
        internal bool IsSetCustomerProfiles() => this.CustomerProfiles != null;

        /// <summary>
        /// Gets and sets the property Datadog. 
        /// <para>
        ///  The connector metadata specific to Datadog. 
        /// </para>
        /// </summary>
        public DatadogMetadata Datadog { get; set; }

        /// <summary>
        /// Checks to see if the Datadog property is set.
        /// </summary>
        internal bool IsSetDatadog() => this.Datadog != null;

        /// <summary>
        /// Gets and sets the property Dynatrace. 
        /// <para>
        ///  The connector metadata specific to Dynatrace. 
        /// </para>
        /// </summary>
        public DynatraceMetadata Dynatrace { get; set; }

        /// <summary>
        /// Checks to see if the Dynatrace property is set.
        /// </summary>
        internal bool IsSetDynatrace() => this.Dynatrace != null;

        /// <summary>
        /// Gets and sets the property EventBridge. 
        /// <para>
        ///  The connector metadata specific to Amazon EventBridge. 
        /// </para>
        /// </summary>
        public EventBridgeMetadata EventBridge { get; set; }

        /// <summary>
        /// Checks to see if the EventBridge property is set.
        /// </summary>
        internal bool IsSetEventBridge() => this.EventBridge != null;

        /// <summary>
        /// Gets and sets the property GoogleAnalytics. 
        /// <para>
        ///  The connector metadata specific to Google Analytics. 
        /// </para>
        /// </summary>
        public GoogleAnalyticsMetadata GoogleAnalytics { get; set; }

        /// <summary>
        /// Checks to see if the GoogleAnalytics property is set.
        /// </summary>
        internal bool IsSetGoogleAnalytics() => this.GoogleAnalytics != null;

        /// <summary>
        /// Gets and sets the property Honeycode. 
        /// <para>
        ///  The connector metadata specific to Amazon Honeycode. 
        /// </para>
        /// </summary>
        public HoneycodeMetadata Honeycode { get; set; }

        /// <summary>
        /// Checks to see if the Honeycode property is set.
        /// </summary>
        internal bool IsSetHoneycode() => this.Honeycode != null;

        /// <summary>
        /// Gets and sets the property InforNexus. 
        /// <para>
        ///  The connector metadata specific to Infor Nexus. 
        /// </para>
        /// </summary>
        public InforNexusMetadata InforNexus { get; set; }

        /// <summary>
        /// Checks to see if the InforNexus property is set.
        /// </summary>
        internal bool IsSetInforNexus() => this.InforNexus != null;

        /// <summary>
        /// Gets and sets the property Marketo. 
        /// <para>
        ///  The connector metadata specific to Marketo. 
        /// </para>
        /// </summary>
        public MarketoMetadata Marketo { get; set; }

        /// <summary>
        /// Checks to see if the Marketo property is set.
        /// </summary>
        internal bool IsSetMarketo() => this.Marketo != null;

        /// <summary>
        /// Gets and sets the property Pardot. 
        /// <para>
        /// The connector metadata specific to Salesforce Pardot.
        /// </para>
        /// </summary>
        public PardotMetadata Pardot { get; set; }

        /// <summary>
        /// Checks to see if the Pardot property is set.
        /// </summary>
        internal bool IsSetPardot() => this.Pardot != null;

        /// <summary>
        /// Gets and sets the property Redshift. 
        /// <para>
        ///  The connector metadata specific to Amazon Redshift. 
        /// </para>
        /// </summary>
        public RedshiftMetadata Redshift { get; set; }

        /// <summary>
        /// Checks to see if the Redshift property is set.
        /// </summary>
        internal bool IsSetRedshift() => this.Redshift != null;

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        ///  The connector metadata specific to Amazon S3. 
        /// </para>
        /// </summary>
        public S3Metadata S3 { get; set; }

        /// <summary>
        /// Checks to see if the S3 property is set.
        /// </summary>
        internal bool IsSetS3() => this.S3 != null;

        /// <summary>
        /// Gets and sets the property SAPOData.
        /// </summary>
        public SAPODataMetadata SAPOData { get; set; }

        /// <summary>
        /// Checks to see if the SAPOData property is set.
        /// </summary>
        internal bool IsSetSAPOData() => this.SAPOData != null;

        /// <summary>
        /// Gets and sets the property Salesforce. 
        /// <para>
        ///  The connector metadata specific to Salesforce. 
        /// </para>
        /// </summary>
        public SalesforceMetadata Salesforce { get; set; }

        /// <summary>
        /// Checks to see if the Salesforce property is set.
        /// </summary>
        internal bool IsSetSalesforce() => this.Salesforce != null;

        /// <summary>
        /// Gets and sets the property ServiceNow. 
        /// <para>
        ///  The connector metadata specific to ServiceNow. 
        /// </para>
        /// </summary>
        public ServiceNowMetadata ServiceNow { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNow property is set.
        /// </summary>
        internal bool IsSetServiceNow() => this.ServiceNow != null;

        /// <summary>
        /// Gets and sets the property Singular. 
        /// <para>
        ///  The connector metadata specific to Singular. 
        /// </para>
        /// </summary>
        public SingularMetadata Singular { get; set; }

        /// <summary>
        /// Checks to see if the Singular property is set.
        /// </summary>
        internal bool IsSetSingular() => this.Singular != null;

        /// <summary>
        /// Gets and sets the property Slack. 
        /// <para>
        ///  The connector metadata specific to Slack. 
        /// </para>
        /// </summary>
        public SlackMetadata Slack { get; set; }

        /// <summary>
        /// Checks to see if the Slack property is set.
        /// </summary>
        internal bool IsSetSlack() => this.Slack != null;

        /// <summary>
        /// Gets and sets the property Snowflake. 
        /// <para>
        ///  The connector metadata specific to Snowflake. 
        /// </para>
        /// </summary>
        public SnowflakeMetadata Snowflake { get; set; }

        /// <summary>
        /// Checks to see if the Snowflake property is set.
        /// </summary>
        internal bool IsSetSnowflake() => this.Snowflake != null;

        /// <summary>
        /// Gets and sets the property Trendmicro. 
        /// <para>
        ///  The connector metadata specific to Trend Micro. 
        /// </para>
        /// </summary>
        public TrendmicroMetadata Trendmicro { get; set; }

        /// <summary>
        /// Checks to see if the Trendmicro property is set.
        /// </summary>
        internal bool IsSetTrendmicro() => this.Trendmicro != null;

        /// <summary>
        /// Gets and sets the property Upsolver. 
        /// <para>
        ///  The connector metadata specific to Upsolver. 
        /// </para>
        /// </summary>
        public UpsolverMetadata Upsolver { get; set; }

        /// <summary>
        /// Checks to see if the Upsolver property is set.
        /// </summary>
        internal bool IsSetUpsolver() => this.Upsolver != null;

        /// <summary>
        /// Gets and sets the property Veeva. 
        /// <para>
        ///  The connector metadata specific to Veeva. 
        /// </para>
        /// </summary>
        public VeevaMetadata Veeva { get; set; }

        /// <summary>
        /// Checks to see if the Veeva property is set.
        /// </summary>
        internal bool IsSetVeeva() => this.Veeva != null;

        /// <summary>
        /// Gets and sets the property Zendesk. 
        /// <para>
        ///  The connector metadata specific to Zendesk. 
        /// </para>
        /// </summary>
        public ZendeskMetadata Zendesk { get; set; }

        /// <summary>
        /// Checks to see if the Zendesk property is set.
        /// </summary>
        internal bool IsSetZendesk() => this.Zendesk != null;
    }
}

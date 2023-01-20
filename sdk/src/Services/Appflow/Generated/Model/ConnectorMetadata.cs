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
    /// A structure to specify connector-specific metadata such as <code>oAuthScopes</code>,
    /// <code>supportedRegions</code>, <code>privateLinkServiceUrl</code>, and so on.
    /// </summary>
    public partial class ConnectorMetadata
    {
        private AmplitudeMetadata _amplitude;
        private CustomerProfilesMetadata _customerProfiles;
        private DatadogMetadata _datadog;
        private DynatraceMetadata _dynatrace;
        private EventBridgeMetadata _eventBridge;
        private GoogleAnalyticsMetadata _googleAnalytics;
        private HoneycodeMetadata _honeycode;
        private InforNexusMetadata _inforNexus;
        private MarketoMetadata _marketo;
        private PardotMetadata _pardot;
        private RedshiftMetadata _redshift;
        private S3Metadata _s3;
        private SalesforceMetadata _salesforce;
        private SAPODataMetadata _sapoData;
        private ServiceNowMetadata _serviceNow;
        private SingularMetadata _singular;
        private SlackMetadata _slack;
        private SnowflakeMetadata _snowflake;
        private TrendmicroMetadata _trendmicro;
        private UpsolverMetadata _upsolver;
        private VeevaMetadata _veeva;
        private ZendeskMetadata _zendesk;

        /// <summary>
        /// Gets and sets the property Amplitude. 
        /// <para>
        ///  The connector metadata specific to Amplitude. 
        /// </para>
        /// </summary>
        public AmplitudeMetadata Amplitude
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
        /// Gets and sets the property CustomerProfiles. 
        /// <para>
        ///  The connector metadata specific to Amazon Connect Customer Profiles. 
        /// </para>
        /// </summary>
        public CustomerProfilesMetadata CustomerProfiles
        {
            get { return this._customerProfiles; }
            set { this._customerProfiles = value; }
        }

        // Check to see if CustomerProfiles property is set
        internal bool IsSetCustomerProfiles()
        {
            return this._customerProfiles != null;
        }

        /// <summary>
        /// Gets and sets the property Datadog. 
        /// <para>
        ///  The connector metadata specific to Datadog. 
        /// </para>
        /// </summary>
        public DatadogMetadata Datadog
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
        ///  The connector metadata specific to Dynatrace. 
        /// </para>
        /// </summary>
        public DynatraceMetadata Dynatrace
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
        /// Gets and sets the property EventBridge. 
        /// <para>
        ///  The connector metadata specific to Amazon EventBridge. 
        /// </para>
        /// </summary>
        public EventBridgeMetadata EventBridge
        {
            get { return this._eventBridge; }
            set { this._eventBridge = value; }
        }

        // Check to see if EventBridge property is set
        internal bool IsSetEventBridge()
        {
            return this._eventBridge != null;
        }

        /// <summary>
        /// Gets and sets the property GoogleAnalytics. 
        /// <para>
        ///  The connector metadata specific to Google Analytics. 
        /// </para>
        /// </summary>
        public GoogleAnalyticsMetadata GoogleAnalytics
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
        ///  The connector metadata specific to Amazon Honeycode. 
        /// </para>
        /// </summary>
        public HoneycodeMetadata Honeycode
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
        ///  The connector metadata specific to Infor Nexus. 
        /// </para>
        /// </summary>
        public InforNexusMetadata InforNexus
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
        ///  The connector metadata specific to Marketo. 
        /// </para>
        /// </summary>
        public MarketoMetadata Marketo
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
        /// The connector metadata specific to Salesforce Pardot.
        /// </para>
        /// </summary>
        public PardotMetadata Pardot
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
        ///  The connector metadata specific to Amazon Redshift. 
        /// </para>
        /// </summary>
        public RedshiftMetadata Redshift
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
        /// Gets and sets the property S3. 
        /// <para>
        ///  The connector metadata specific to Amazon S3. 
        /// </para>
        /// </summary>
        public S3Metadata S3
        {
            get { return this._s3; }
            set { this._s3 = value; }
        }

        // Check to see if S3 property is set
        internal bool IsSetS3()
        {
            return this._s3 != null;
        }

        /// <summary>
        /// Gets and sets the property Salesforce. 
        /// <para>
        ///  The connector metadata specific to Salesforce. 
        /// </para>
        /// </summary>
        public SalesforceMetadata Salesforce
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
        public SAPODataMetadata SAPOData
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
        ///  The connector metadata specific to ServiceNow. 
        /// </para>
        /// </summary>
        public ServiceNowMetadata ServiceNow
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
        ///  The connector metadata specific to Singular. 
        /// </para>
        /// </summary>
        public SingularMetadata Singular
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
        ///  The connector metadata specific to Slack. 
        /// </para>
        /// </summary>
        public SlackMetadata Slack
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
        ///  The connector metadata specific to Snowflake. 
        /// </para>
        /// </summary>
        public SnowflakeMetadata Snowflake
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
        ///  The connector metadata specific to Trend Micro. 
        /// </para>
        /// </summary>
        public TrendmicroMetadata Trendmicro
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
        /// Gets and sets the property Upsolver. 
        /// <para>
        ///  The connector metadata specific to Upsolver. 
        /// </para>
        /// </summary>
        public UpsolverMetadata Upsolver
        {
            get { return this._upsolver; }
            set { this._upsolver = value; }
        }

        // Check to see if Upsolver property is set
        internal bool IsSetUpsolver()
        {
            return this._upsolver != null;
        }

        /// <summary>
        /// Gets and sets the property Veeva. 
        /// <para>
        ///  The connector metadata specific to Veeva. 
        /// </para>
        /// </summary>
        public VeevaMetadata Veeva
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
        ///  The connector metadata specific to Zendesk. 
        /// </para>
        /// </summary>
        public ZendeskMetadata Zendesk
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
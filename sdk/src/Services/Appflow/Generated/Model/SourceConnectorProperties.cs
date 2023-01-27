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
    /// Specifies the information that is required to query a particular connector.
    /// </summary>
    public partial class SourceConnectorProperties
    {
        private AmplitudeSourceProperties _amplitude;
        private CustomConnectorSourceProperties _customConnector;
        private DatadogSourceProperties _datadog;
        private DynatraceSourceProperties _dynatrace;
        private GoogleAnalyticsSourceProperties _googleAnalytics;
        private InforNexusSourceProperties _inforNexus;
        private MarketoSourceProperties _marketo;
        private PardotSourceProperties _pardot;
        private S3SourceProperties _s3;
        private SalesforceSourceProperties _salesforce;
        private SAPODataSourceProperties _sapoData;
        private ServiceNowSourceProperties _serviceNow;
        private SingularSourceProperties _singular;
        private SlackSourceProperties _slack;
        private TrendmicroSourceProperties _trendmicro;
        private VeevaSourceProperties _veeva;
        private ZendeskSourceProperties _zendesk;

        /// <summary>
        /// Gets and sets the property Amplitude. 
        /// <para>
        ///  Specifies the information that is required for querying Amplitude. 
        /// </para>
        /// </summary>
        public AmplitudeSourceProperties Amplitude
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
        public CustomConnectorSourceProperties CustomConnector
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
        ///  Specifies the information that is required for querying Datadog. 
        /// </para>
        /// </summary>
        public DatadogSourceProperties Datadog
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
        ///  Specifies the information that is required for querying Dynatrace. 
        /// </para>
        /// </summary>
        public DynatraceSourceProperties Dynatrace
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
        ///  Specifies the information that is required for querying Google Analytics. 
        /// </para>
        /// </summary>
        public GoogleAnalyticsSourceProperties GoogleAnalytics
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
        /// Gets and sets the property InforNexus. 
        /// <para>
        ///  Specifies the information that is required for querying Infor Nexus. 
        /// </para>
        /// </summary>
        public InforNexusSourceProperties InforNexus
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
        ///  Specifies the information that is required for querying Marketo. 
        /// </para>
        /// </summary>
        public MarketoSourceProperties Marketo
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
        /// Specifies the information that is required for querying Salesforce Pardot.
        /// </para>
        /// </summary>
        public PardotSourceProperties Pardot
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
        /// Gets and sets the property S3. 
        /// <para>
        ///  Specifies the information that is required for querying Amazon S3. 
        /// </para>
        /// </summary>
        public S3SourceProperties S3
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
        ///  Specifies the information that is required for querying Salesforce. 
        /// </para>
        /// </summary>
        public SalesforceSourceProperties Salesforce
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
        public SAPODataSourceProperties SAPOData
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
        ///  Specifies the information that is required for querying ServiceNow. 
        /// </para>
        /// </summary>
        public ServiceNowSourceProperties ServiceNow
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
        ///  Specifies the information that is required for querying Singular. 
        /// </para>
        /// </summary>
        public SingularSourceProperties Singular
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
        ///  Specifies the information that is required for querying Slack. 
        /// </para>
        /// </summary>
        public SlackSourceProperties Slack
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
        /// Gets and sets the property Trendmicro. 
        /// <para>
        ///  Specifies the information that is required for querying Trend Micro. 
        /// </para>
        /// </summary>
        public TrendmicroSourceProperties Trendmicro
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
        ///  Specifies the information that is required for querying Veeva. 
        /// </para>
        /// </summary>
        public VeevaSourceProperties Veeva
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
        ///  Specifies the information that is required for querying Zendesk. 
        /// </para>
        /// </summary>
        public ZendeskSourceProperties Zendesk
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
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
    /// The operation to be performed on the provided source fields.
    /// </summary>
    public partial class ConnectorOperator
    {
        private AmplitudeConnectorOperator _amplitude;
        private Operator _customConnector;
        private DatadogConnectorOperator _datadog;
        private DynatraceConnectorOperator _dynatrace;
        private GoogleAnalyticsConnectorOperator _googleAnalytics;
        private InforNexusConnectorOperator _inforNexus;
        private MarketoConnectorOperator _marketo;
        private PardotConnectorOperator _pardot;
        private S3ConnectorOperator _s3;
        private SalesforceConnectorOperator _salesforce;
        private SAPODataConnectorOperator _sapoData;
        private ServiceNowConnectorOperator _serviceNow;
        private SingularConnectorOperator _singular;
        private SlackConnectorOperator _slack;
        private TrendmicroConnectorOperator _trendmicro;
        private VeevaConnectorOperator _veeva;
        private ZendeskConnectorOperator _zendesk;

        /// <summary>
        /// Gets and sets the property Amplitude. 
        /// <para>
        ///  The operation to be performed on the provided Amplitude source fields. 
        /// </para>
        /// </summary>
        public AmplitudeConnectorOperator Amplitude
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
        /// <para>
        /// Operators supported by the custom connector.
        /// </para>
        /// </summary>
        public Operator CustomConnector
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
        ///  The operation to be performed on the provided Datadog source fields. 
        /// </para>
        /// </summary>
        public DatadogConnectorOperator Datadog
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
        ///  The operation to be performed on the provided Dynatrace source fields. 
        /// </para>
        /// </summary>
        public DynatraceConnectorOperator Dynatrace
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
        ///  The operation to be performed on the provided Google Analytics source fields. 
        /// </para>
        /// </summary>
        public GoogleAnalyticsConnectorOperator GoogleAnalytics
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
        ///  The operation to be performed on the provided Infor Nexus source fields. 
        /// </para>
        /// </summary>
        public InforNexusConnectorOperator InforNexus
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
        ///  The operation to be performed on the provided Marketo source fields. 
        /// </para>
        /// </summary>
        public MarketoConnectorOperator Marketo
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
        /// The operation to be performed on the provided Salesforce Pardot source fields.
        /// </para>
        /// </summary>
        public PardotConnectorOperator Pardot
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
        ///  The operation to be performed on the provided Amazon S3 source fields. 
        /// </para>
        /// </summary>
        public S3ConnectorOperator S3
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
        ///  The operation to be performed on the provided Salesforce source fields. 
        /// </para>
        /// </summary>
        public SalesforceConnectorOperator Salesforce
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
        /// <para>
        ///  The operation to be performed on the provided SAPOData source fields. 
        /// </para>
        /// </summary>
        public SAPODataConnectorOperator SAPOData
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
        ///  The operation to be performed on the provided ServiceNow source fields. 
        /// </para>
        /// </summary>
        public ServiceNowConnectorOperator ServiceNow
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
        ///  The operation to be performed on the provided Singular source fields. 
        /// </para>
        /// </summary>
        public SingularConnectorOperator Singular
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
        ///  The operation to be performed on the provided Slack source fields. 
        /// </para>
        /// </summary>
        public SlackConnectorOperator Slack
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
        ///  The operation to be performed on the provided Trend Micro source fields. 
        /// </para>
        /// </summary>
        public TrendmicroConnectorOperator Trendmicro
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
        ///  The operation to be performed on the provided Veeva source fields. 
        /// </para>
        /// </summary>
        public VeevaConnectorOperator Veeva
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
        ///  The operation to be performed on the provided Zendesk source fields. 
        /// </para>
        /// </summary>
        public ZendeskConnectorOperator Zendesk
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
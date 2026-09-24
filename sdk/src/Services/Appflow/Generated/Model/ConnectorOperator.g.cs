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
    /// The operation to be performed on the provided source fields.
    /// </summary>
    public partial class ConnectorOperator
    {
        /// <summary>
        /// Gets and sets the property Amplitude. 
        /// <para>
        ///  The operation to be performed on the provided Amplitude source fields. 
        /// </para>
        /// </summary>
        public AmplitudeConnectorOperator Amplitude { get; set; }

        /// <summary>
        /// Checks to see if the Amplitude property is set.
        /// </summary>
        internal bool IsSetAmplitude() => this.Amplitude != null;

        /// <summary>
        /// Gets and sets the property CustomConnector. 
        /// <para>
        /// Operators supported by the custom connector.
        /// </para>
        /// </summary>
        public Operator CustomConnector { get; set; }

        /// <summary>
        /// Checks to see if the CustomConnector property is set.
        /// </summary>
        internal bool IsSetCustomConnector() => this.CustomConnector != null;

        /// <summary>
        /// Gets and sets the property Datadog. 
        /// <para>
        ///  The operation to be performed on the provided Datadog source fields. 
        /// </para>
        /// </summary>
        public DatadogConnectorOperator Datadog { get; set; }

        /// <summary>
        /// Checks to see if the Datadog property is set.
        /// </summary>
        internal bool IsSetDatadog() => this.Datadog != null;

        /// <summary>
        /// Gets and sets the property Dynatrace. 
        /// <para>
        ///  The operation to be performed on the provided Dynatrace source fields. 
        /// </para>
        /// </summary>
        public DynatraceConnectorOperator Dynatrace { get; set; }

        /// <summary>
        /// Checks to see if the Dynatrace property is set.
        /// </summary>
        internal bool IsSetDynatrace() => this.Dynatrace != null;

        /// <summary>
        /// Gets and sets the property GoogleAnalytics. 
        /// <para>
        ///  The operation to be performed on the provided Google Analytics source fields. 
        /// </para>
        /// </summary>
        public GoogleAnalyticsConnectorOperator GoogleAnalytics { get; set; }

        /// <summary>
        /// Checks to see if the GoogleAnalytics property is set.
        /// </summary>
        internal bool IsSetGoogleAnalytics() => this.GoogleAnalytics != null;

        /// <summary>
        /// Gets and sets the property InforNexus. 
        /// <para>
        ///  The operation to be performed on the provided Infor Nexus source fields. 
        /// </para>
        /// </summary>
        public InforNexusConnectorOperator InforNexus { get; set; }

        /// <summary>
        /// Checks to see if the InforNexus property is set.
        /// </summary>
        internal bool IsSetInforNexus() => this.InforNexus != null;

        /// <summary>
        /// Gets and sets the property Marketo. 
        /// <para>
        ///  The operation to be performed on the provided Marketo source fields. 
        /// </para>
        /// </summary>
        public MarketoConnectorOperator Marketo { get; set; }

        /// <summary>
        /// Checks to see if the Marketo property is set.
        /// </summary>
        internal bool IsSetMarketo() => this.Marketo != null;

        /// <summary>
        /// Gets and sets the property Pardot. 
        /// <para>
        /// The operation to be performed on the provided Salesforce Pardot source fields.
        /// </para>
        /// </summary>
        public PardotConnectorOperator Pardot { get; set; }

        /// <summary>
        /// Checks to see if the Pardot property is set.
        /// </summary>
        internal bool IsSetPardot() => this.Pardot != null;

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        ///  The operation to be performed on the provided Amazon S3 source fields. 
        /// </para>
        /// </summary>
        public S3ConnectorOperator S3 { get; set; }

        /// <summary>
        /// Checks to see if the S3 property is set.
        /// </summary>
        internal bool IsSetS3() => this.S3 != null;

        /// <summary>
        /// Gets and sets the property SAPOData. 
        /// <para>
        ///  The operation to be performed on the provided SAPOData source fields. 
        /// </para>
        /// </summary>
        public SAPODataConnectorOperator SAPOData { get; set; }

        /// <summary>
        /// Checks to see if the SAPOData property is set.
        /// </summary>
        internal bool IsSetSAPOData() => this.SAPOData != null;

        /// <summary>
        /// Gets and sets the property Salesforce. 
        /// <para>
        ///  The operation to be performed on the provided Salesforce source fields. 
        /// </para>
        /// </summary>
        public SalesforceConnectorOperator Salesforce { get; set; }

        /// <summary>
        /// Checks to see if the Salesforce property is set.
        /// </summary>
        internal bool IsSetSalesforce() => this.Salesforce != null;

        /// <summary>
        /// Gets and sets the property ServiceNow. 
        /// <para>
        ///  The operation to be performed on the provided ServiceNow source fields. 
        /// </para>
        /// </summary>
        public ServiceNowConnectorOperator ServiceNow { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNow property is set.
        /// </summary>
        internal bool IsSetServiceNow() => this.ServiceNow != null;

        /// <summary>
        /// Gets and sets the property Singular. 
        /// <para>
        ///  The operation to be performed on the provided Singular source fields. 
        /// </para>
        /// </summary>
        public SingularConnectorOperator Singular { get; set; }

        /// <summary>
        /// Checks to see if the Singular property is set.
        /// </summary>
        internal bool IsSetSingular() => this.Singular != null;

        /// <summary>
        /// Gets and sets the property Slack. 
        /// <para>
        ///  The operation to be performed on the provided Slack source fields. 
        /// </para>
        /// </summary>
        public SlackConnectorOperator Slack { get; set; }

        /// <summary>
        /// Checks to see if the Slack property is set.
        /// </summary>
        internal bool IsSetSlack() => this.Slack != null;

        /// <summary>
        /// Gets and sets the property Trendmicro. 
        /// <para>
        ///  The operation to be performed on the provided Trend Micro source fields. 
        /// </para>
        /// </summary>
        public TrendmicroConnectorOperator Trendmicro { get; set; }

        /// <summary>
        /// Checks to see if the Trendmicro property is set.
        /// </summary>
        internal bool IsSetTrendmicro() => this.Trendmicro != null;

        /// <summary>
        /// Gets and sets the property Veeva. 
        /// <para>
        ///  The operation to be performed on the provided Veeva source fields. 
        /// </para>
        /// </summary>
        public VeevaConnectorOperator Veeva { get; set; }

        /// <summary>
        /// Checks to see if the Veeva property is set.
        /// </summary>
        internal bool IsSetVeeva() => this.Veeva != null;

        /// <summary>
        /// Gets and sets the property Zendesk. 
        /// <para>
        ///  The operation to be performed on the provided Zendesk source fields. 
        /// </para>
        /// </summary>
        public ZendeskConnectorOperator Zendesk { get; set; }

        /// <summary>
        /// Checks to see if the Zendesk property is set.
        /// </summary>
        internal bool IsSetZendesk() => this.Zendesk != null;
    }
}

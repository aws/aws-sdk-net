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
    /// Specifies the information that is required to query a particular connector.
    /// </summary>
    public partial class SourceConnectorProperties
    {
        /// <summary>
        /// Gets and sets the property Amplitude. 
        /// <para>
        ///  Specifies the information that is required for querying Amplitude. 
        /// </para>
        /// </summary>
        public AmplitudeSourceProperties Amplitude { get; set; }

        /// <summary>
        /// Checks to see if the Amplitude property is set.
        /// </summary>
        internal bool IsSetAmplitude() => this.Amplitude != null;

        /// <summary>
        /// Gets and sets the property CustomConnector.
        /// </summary>
        public CustomConnectorSourceProperties CustomConnector { get; set; }

        /// <summary>
        /// Checks to see if the CustomConnector property is set.
        /// </summary>
        internal bool IsSetCustomConnector() => this.CustomConnector != null;

        /// <summary>
        /// Gets and sets the property Datadog. 
        /// <para>
        ///  Specifies the information that is required for querying Datadog. 
        /// </para>
        /// </summary>
        public DatadogSourceProperties Datadog { get; set; }

        /// <summary>
        /// Checks to see if the Datadog property is set.
        /// </summary>
        internal bool IsSetDatadog() => this.Datadog != null;

        /// <summary>
        /// Gets and sets the property Dynatrace. 
        /// <para>
        ///  Specifies the information that is required for querying Dynatrace. 
        /// </para>
        /// </summary>
        public DynatraceSourceProperties Dynatrace { get; set; }

        /// <summary>
        /// Checks to see if the Dynatrace property is set.
        /// </summary>
        internal bool IsSetDynatrace() => this.Dynatrace != null;

        /// <summary>
        /// Gets and sets the property GoogleAnalytics. 
        /// <para>
        ///  Specifies the information that is required for querying Google Analytics. 
        /// </para>
        /// </summary>
        public GoogleAnalyticsSourceProperties GoogleAnalytics { get; set; }

        /// <summary>
        /// Checks to see if the GoogleAnalytics property is set.
        /// </summary>
        internal bool IsSetGoogleAnalytics() => this.GoogleAnalytics != null;

        /// <summary>
        /// Gets and sets the property InforNexus. 
        /// <para>
        ///  Specifies the information that is required for querying Infor Nexus. 
        /// </para>
        /// </summary>
        public InforNexusSourceProperties InforNexus { get; set; }

        /// <summary>
        /// Checks to see if the InforNexus property is set.
        /// </summary>
        internal bool IsSetInforNexus() => this.InforNexus != null;

        /// <summary>
        /// Gets and sets the property Marketo. 
        /// <para>
        ///  Specifies the information that is required for querying Marketo. 
        /// </para>
        /// </summary>
        public MarketoSourceProperties Marketo { get; set; }

        /// <summary>
        /// Checks to see if the Marketo property is set.
        /// </summary>
        internal bool IsSetMarketo() => this.Marketo != null;

        /// <summary>
        /// Gets and sets the property Pardot. 
        /// <para>
        /// Specifies the information that is required for querying Salesforce Pardot.
        /// </para>
        /// </summary>
        public PardotSourceProperties Pardot { get; set; }

        /// <summary>
        /// Checks to see if the Pardot property is set.
        /// </summary>
        internal bool IsSetPardot() => this.Pardot != null;

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        ///  Specifies the information that is required for querying Amazon S3. 
        /// </para>
        /// </summary>
        public S3SourceProperties S3 { get; set; }

        /// <summary>
        /// Checks to see if the S3 property is set.
        /// </summary>
        internal bool IsSetS3() => this.S3 != null;

        /// <summary>
        /// Gets and sets the property SAPOData.
        /// </summary>
        public SAPODataSourceProperties SAPOData { get; set; }

        /// <summary>
        /// Checks to see if the SAPOData property is set.
        /// </summary>
        internal bool IsSetSAPOData() => this.SAPOData != null;

        /// <summary>
        /// Gets and sets the property Salesforce. 
        /// <para>
        ///  Specifies the information that is required for querying Salesforce. 
        /// </para>
        /// </summary>
        public SalesforceSourceProperties Salesforce { get; set; }

        /// <summary>
        /// Checks to see if the Salesforce property is set.
        /// </summary>
        internal bool IsSetSalesforce() => this.Salesforce != null;

        /// <summary>
        /// Gets and sets the property ServiceNow. 
        /// <para>
        ///  Specifies the information that is required for querying ServiceNow. 
        /// </para>
        /// </summary>
        public ServiceNowSourceProperties ServiceNow { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNow property is set.
        /// </summary>
        internal bool IsSetServiceNow() => this.ServiceNow != null;

        /// <summary>
        /// Gets and sets the property Singular. 
        /// <para>
        ///  Specifies the information that is required for querying Singular. 
        /// </para>
        /// </summary>
        public SingularSourceProperties Singular { get; set; }

        /// <summary>
        /// Checks to see if the Singular property is set.
        /// </summary>
        internal bool IsSetSingular() => this.Singular != null;

        /// <summary>
        /// Gets and sets the property Slack. 
        /// <para>
        ///  Specifies the information that is required for querying Slack. 
        /// </para>
        /// </summary>
        public SlackSourceProperties Slack { get; set; }

        /// <summary>
        /// Checks to see if the Slack property is set.
        /// </summary>
        internal bool IsSetSlack() => this.Slack != null;

        /// <summary>
        /// Gets and sets the property Trendmicro. 
        /// <para>
        ///  Specifies the information that is required for querying Trend Micro. 
        /// </para>
        /// </summary>
        public TrendmicroSourceProperties Trendmicro { get; set; }

        /// <summary>
        /// Checks to see if the Trendmicro property is set.
        /// </summary>
        internal bool IsSetTrendmicro() => this.Trendmicro != null;

        /// <summary>
        /// Gets and sets the property Veeva. 
        /// <para>
        ///  Specifies the information that is required for querying Veeva. 
        /// </para>
        /// </summary>
        public VeevaSourceProperties Veeva { get; set; }

        /// <summary>
        /// Checks to see if the Veeva property is set.
        /// </summary>
        internal bool IsSetVeeva() => this.Veeva != null;

        /// <summary>
        /// Gets and sets the property Zendesk. 
        /// <para>
        ///  Specifies the information that is required for querying Zendesk. 
        /// </para>
        /// </summary>
        public ZendeskSourceProperties Zendesk { get; set; }

        /// <summary>
        /// Checks to see if the Zendesk property is set.
        /// </summary>
        internal bool IsSetZendesk() => this.Zendesk != null;
    }
}

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
    /// This stores the information that is required to query a particular connector.
    /// </summary>
    public partial class DestinationConnectorProperties
    {
        /// <summary>
        /// Gets and sets the property CustomConnector. 
        /// <para>
        /// The properties that are required to query the custom Connector.
        /// </para>
        /// </summary>
        public CustomConnectorDestinationProperties CustomConnector { get; set; }

        /// <summary>
        /// Checks to see if the CustomConnector property is set.
        /// </summary>
        internal bool IsSetCustomConnector() => this.CustomConnector != null;

        /// <summary>
        /// Gets and sets the property CustomerProfiles. 
        /// <para>
        ///  The properties required to query Connect Customer Customer Profiles. 
        /// </para>
        /// </summary>
        public CustomerProfilesDestinationProperties CustomerProfiles { get; set; }

        /// <summary>
        /// Checks to see if the CustomerProfiles property is set.
        /// </summary>
        internal bool IsSetCustomerProfiles() => this.CustomerProfiles != null;

        /// <summary>
        /// Gets and sets the property EventBridge. 
        /// <para>
        ///  The properties required to query Amazon EventBridge. 
        /// </para>
        /// </summary>
        public EventBridgeDestinationProperties EventBridge { get; set; }

        /// <summary>
        /// Checks to see if the EventBridge property is set.
        /// </summary>
        internal bool IsSetEventBridge() => this.EventBridge != null;

        /// <summary>
        /// Gets and sets the property Honeycode. 
        /// <para>
        ///  The properties required to query Amazon Honeycode. 
        /// </para>
        /// </summary>
        public HoneycodeDestinationProperties Honeycode { get; set; }

        /// <summary>
        /// Checks to see if the Honeycode property is set.
        /// </summary>
        internal bool IsSetHoneycode() => this.Honeycode != null;

        /// <summary>
        /// Gets and sets the property LookoutMetrics. 
        /// <para>
        ///  The properties required to query Amazon Lookout for Metrics. 
        /// </para>
        /// </summary>
        public LookoutMetricsDestinationProperties LookoutMetrics { get; set; }

        /// <summary>
        /// Checks to see if the LookoutMetrics property is set.
        /// </summary>
        internal bool IsSetLookoutMetrics() => this.LookoutMetrics != null;

        /// <summary>
        /// Gets and sets the property Marketo. 
        /// <para>
        /// The properties required to query Marketo.
        /// </para>
        /// </summary>
        public MarketoDestinationProperties Marketo { get; set; }

        /// <summary>
        /// Checks to see if the Marketo property is set.
        /// </summary>
        internal bool IsSetMarketo() => this.Marketo != null;

        /// <summary>
        /// Gets and sets the property Redshift. 
        /// <para>
        ///  The properties required to query Amazon Redshift. 
        /// </para>
        /// </summary>
        public RedshiftDestinationProperties Redshift { get; set; }

        /// <summary>
        /// Checks to see if the Redshift property is set.
        /// </summary>
        internal bool IsSetRedshift() => this.Redshift != null;

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        ///  The properties required to query Amazon S3. 
        /// </para>
        /// </summary>
        public S3DestinationProperties S3 { get; set; }

        /// <summary>
        /// Checks to see if the S3 property is set.
        /// </summary>
        internal bool IsSetS3() => this.S3 != null;

        /// <summary>
        /// Gets and sets the property SAPOData. 
        /// <para>
        /// The properties required to query SAPOData.
        /// </para>
        /// </summary>
        public SAPODataDestinationProperties SAPOData { get; set; }

        /// <summary>
        /// Checks to see if the SAPOData property is set.
        /// </summary>
        internal bool IsSetSAPOData() => this.SAPOData != null;

        /// <summary>
        /// Gets and sets the property Salesforce. 
        /// <para>
        ///  The properties required to query Salesforce. 
        /// </para>
        /// </summary>
        public SalesforceDestinationProperties Salesforce { get; set; }

        /// <summary>
        /// Checks to see if the Salesforce property is set.
        /// </summary>
        internal bool IsSetSalesforce() => this.Salesforce != null;

        /// <summary>
        /// Gets and sets the property Snowflake. 
        /// <para>
        ///  The properties required to query Snowflake. 
        /// </para>
        /// </summary>
        public SnowflakeDestinationProperties Snowflake { get; set; }

        /// <summary>
        /// Checks to see if the Snowflake property is set.
        /// </summary>
        internal bool IsSetSnowflake() => this.Snowflake != null;

        /// <summary>
        /// Gets and sets the property Upsolver. 
        /// <para>
        ///  The properties required to query Upsolver. 
        /// </para>
        /// </summary>
        public UpsolverDestinationProperties Upsolver { get; set; }

        /// <summary>
        /// Checks to see if the Upsolver property is set.
        /// </summary>
        internal bool IsSetUpsolver() => this.Upsolver != null;

        /// <summary>
        /// Gets and sets the property Zendesk. 
        /// <para>
        /// The properties required to query Zendesk.
        /// </para>
        /// </summary>
        public ZendeskDestinationProperties Zendesk { get; set; }

        /// <summary>
        /// Checks to see if the Zendesk property is set.
        /// </summary>
        internal bool IsSetZendesk() => this.Zendesk != null;
    }
}

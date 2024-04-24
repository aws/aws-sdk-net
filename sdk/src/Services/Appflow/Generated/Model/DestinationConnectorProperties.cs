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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// This stores the information that is required to query a particular connector.
    /// </summary>
    public partial class DestinationConnectorProperties
    {
        private CustomConnectorDestinationProperties _customConnector;
        private CustomerProfilesDestinationProperties _customerProfiles;
        private EventBridgeDestinationProperties _eventBridge;
        private HoneycodeDestinationProperties _honeycode;
        private LookoutMetricsDestinationProperties _lookoutMetrics;
        private MarketoDestinationProperties _marketo;
        private RedshiftDestinationProperties _redshift;
        private S3DestinationProperties _s3;
        private SalesforceDestinationProperties _salesforce;
        private SAPODataDestinationProperties _sapoData;
        private SnowflakeDestinationProperties _snowflake;
        private UpsolverDestinationProperties _upsolver;
        private ZendeskDestinationProperties _zendesk;

        /// <summary>
        /// Gets and sets the property CustomConnector. 
        /// <para>
        /// The properties that are required to query the custom Connector.
        /// </para>
        /// </summary>
        public CustomConnectorDestinationProperties CustomConnector
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
        /// Gets and sets the property CustomerProfiles. 
        /// <para>
        ///  The properties required to query Amazon Connect Customer Profiles. 
        /// </para>
        /// </summary>
        public CustomerProfilesDestinationProperties CustomerProfiles
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
        /// Gets and sets the property EventBridge. 
        /// <para>
        ///  The properties required to query Amazon EventBridge. 
        /// </para>
        /// </summary>
        public EventBridgeDestinationProperties EventBridge
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
        /// Gets and sets the property Honeycode. 
        /// <para>
        ///  The properties required to query Amazon Honeycode. 
        /// </para>
        /// </summary>
        public HoneycodeDestinationProperties Honeycode
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
        /// Gets and sets the property LookoutMetrics. 
        /// <para>
        ///  The properties required to query Amazon Lookout for Metrics. 
        /// </para>
        /// </summary>
        public LookoutMetricsDestinationProperties LookoutMetrics
        {
            get { return this._lookoutMetrics; }
            set { this._lookoutMetrics = value; }
        }

        // Check to see if LookoutMetrics property is set
        internal bool IsSetLookoutMetrics()
        {
            return this._lookoutMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property Marketo. 
        /// <para>
        /// The properties required to query Marketo.
        /// </para>
        /// </summary>
        public MarketoDestinationProperties Marketo
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
        /// Gets and sets the property Redshift. 
        /// <para>
        ///  The properties required to query Amazon Redshift. 
        /// </para>
        /// </summary>
        public RedshiftDestinationProperties Redshift
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
        ///  The properties required to query Amazon S3. 
        /// </para>
        /// </summary>
        public S3DestinationProperties S3
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
        ///  The properties required to query Salesforce. 
        /// </para>
        /// </summary>
        public SalesforceDestinationProperties Salesforce
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
        /// The properties required to query SAPOData.
        /// </para>
        /// </summary>
        public SAPODataDestinationProperties SAPOData
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
        /// Gets and sets the property Snowflake. 
        /// <para>
        ///  The properties required to query Snowflake. 
        /// </para>
        /// </summary>
        public SnowflakeDestinationProperties Snowflake
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
        /// Gets and sets the property Upsolver. 
        /// <para>
        ///  The properties required to query Upsolver. 
        /// </para>
        /// </summary>
        public UpsolverDestinationProperties Upsolver
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
        /// Gets and sets the property Zendesk. 
        /// <para>
        /// The properties required to query Zendesk.
        /// </para>
        /// </summary>
        public ZendeskDestinationProperties Zendesk
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
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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure that is used to specify a connection to create or update.
    /// </summary>
    public partial class ConnectionInput
    {
        private Dictionary<string, string> _athenaProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private AuthenticationConfigurationInput _authenticationConfiguration;
        private Dictionary<string, string> _connectionProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ConnectionType _connectionType;
        private string _description;
        private List<string> _matchCriteria = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private PhysicalConnectionRequirements _physicalConnectionRequirements;
        private Dictionary<string, string> _pythonProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _sparkProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private bool? _validateCredentials;
        private List<string> _validateForComputeEnvironments = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AthenaProperties. 
        /// <para>
        /// Connection properties specific to the Athena compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AthenaProperties
        {
            get { return this._athenaProperties; }
            set { this._athenaProperties = value; }
        }

        // Check to see if AthenaProperties property is set
        internal bool IsSetAthenaProperties()
        {
            return this._athenaProperties != null && (this._athenaProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AuthenticationConfiguration. 
        /// <para>
        /// The authentication properties of the connection.
        /// </para>
        /// </summary>
        public AuthenticationConfigurationInput AuthenticationConfiguration
        {
            get { return this._authenticationConfiguration; }
            set { this._authenticationConfiguration = value; }
        }

        // Check to see if AuthenticationConfiguration property is set
        internal bool IsSetAuthenticationConfiguration()
        {
            return this._authenticationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionProperties. 
        /// <para>
        /// These key-value pairs define parameters for the connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public Dictionary<string, string> ConnectionProperties
        {
            get { return this._connectionProperties; }
            set { this._connectionProperties = value; }
        }

        // Check to see if ConnectionProperties property is set
        internal bool IsSetConnectionProperties()
        {
            return this._connectionProperties != null && (this._connectionProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The type of the connection. Currently, these types are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>JDBC</c> - Designates a connection to a database through Java Database Connectivity
        /// (JDBC).
        /// </para>
        ///  
        /// <para>
        ///  <c>JDBC</c> Connections use the following ConnectionParameters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Required: All of (<c>HOST</c>, <c>PORT</c>, <c>JDBC_ENGINE</c>) or <c>JDBC_CONNECTION_URL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Required: All of (<c>USERNAME</c>, <c>PASSWORD</c>) or <c>SECRET_ID</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optional: <c>JDBC_ENFORCE_SSL</c>, <c>CUSTOM_JDBC_CERT</c>, <c>CUSTOM_JDBC_CERT_STRING</c>,
        /// <c>SKIP_CUSTOM_JDBC_CERT_VALIDATION</c>. These parameters are used to configure SSL
        /// with JDBC.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>KAFKA</c> - Designates a connection to an Apache Kafka streaming platform.
        /// </para>
        ///  
        /// <para>
        ///  <c>KAFKA</c> Connections use the following ConnectionParameters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Required: <c>KAFKA_BOOTSTRAP_SERVERS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optional: <c>KAFKA_SSL_ENABLED</c>, <c>KAFKA_CUSTOM_CERT</c>, <c>KAFKA_SKIP_CUSTOM_CERT_VALIDATION</c>.
        /// These parameters are used to configure SSL with <c>KAFKA</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optional: <c>KAFKA_CLIENT_KEYSTORE</c>, <c>KAFKA_CLIENT_KEYSTORE_PASSWORD</c>, <c>KAFKA_CLIENT_KEY_PASSWORD</c>,
        /// <c>ENCRYPTED_KAFKA_CLIENT_KEYSTORE_PASSWORD</c>, <c>ENCRYPTED_KAFKA_CLIENT_KEY_PASSWORD</c>.
        /// These parameters are used to configure TLS client configuration with SSL in <c>KAFKA</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optional: <c>KAFKA_SASL_MECHANISM</c>. Can be specified as <c>SCRAM-SHA-512</c>, <c>GSSAPI</c>,
        /// or <c>AWS_MSK_IAM</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optional: <c>KAFKA_SASL_SCRAM_USERNAME</c>, <c>KAFKA_SASL_SCRAM_PASSWORD</c>, <c>ENCRYPTED_KAFKA_SASL_SCRAM_PASSWORD</c>.
        /// These parameters are used to configure SASL/SCRAM-SHA-512 authentication with <c>KAFKA</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optional: <c>KAFKA_SASL_GSSAPI_KEYTAB</c>, <c>KAFKA_SASL_GSSAPI_KRB5_CONF</c>, <c>KAFKA_SASL_GSSAPI_SERVICE</c>,
        /// <c>KAFKA_SASL_GSSAPI_PRINCIPAL</c>. These parameters are used to configure SASL/GSSAPI
        /// authentication with <c>KAFKA</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>MONGODB</c> - Designates a connection to a MongoDB document database.
        /// </para>
        ///  
        /// <para>
        ///  <c>MONGODB</c> Connections use the following ConnectionParameters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Required: <c>CONNECTION_URL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Required: All of (<c>USERNAME</c>, <c>PASSWORD</c>) or <c>SECRET_ID</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>VIEW_VALIDATION_REDSHIFT</c> - Designates a connection used for view validation
        /// by Amazon Redshift.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VIEW_VALIDATION_ATHENA</c> - Designates a connection used for view validation
        /// by Amazon Athena.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NETWORK</c> - Designates a network connection to a data source within an Amazon
        /// Virtual Private Cloud environment (Amazon VPC).
        /// </para>
        ///  
        /// <para>
        ///  <c>NETWORK</c> Connections do not require ConnectionParameters. Instead, provide
        /// a PhysicalConnectionRequirements.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MARKETPLACE</c> - Uses configuration settings contained in a connector purchased
        /// from Amazon Web Services Marketplace to read from and write to data stores that are
        /// not natively supported by Glue.
        /// </para>
        ///  
        /// <para>
        ///  <c>MARKETPLACE</c> Connections use the following ConnectionParameters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Required: <c>CONNECTOR_TYPE</c>, <c>CONNECTOR_URL</c>, <c>CONNECTOR_CLASS_NAME</c>,
        /// <c>CONNECTION_URL</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Required for <c>JDBC</c> <c>CONNECTOR_TYPE</c> connections: All of (<c>USERNAME</c>,
        /// <c>PASSWORD</c>) or <c>SECRET_ID</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>CUSTOM</c> - Uses configuration settings contained in a custom connector to read
        /// from and write to data stores that are not natively supported by Glue.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Additionally, a <c>ConnectionType</c> for the following SaaS connectors is supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FACEBOOKADS</c> - Designates a connection to Facebook Ads.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GOOGLEADS</c> - Designates a connection to Google Ads.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GOOGLESHEETS</c> - Designates a connection to Google Sheets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GOOGLEANALYTICS4</c> - Designates a connection to Google Analytics 4.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HUBSPOT</c> - Designates a connection to HubSpot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSTAGRAMADS</c> - Designates a connection to Instagram Ads.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTERCOM</c> - Designates a connection to Intercom.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JIRACLOUD</c> - Designates a connection to Jira Cloud.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MARKETO</c> - Designates a connection to Adobe Marketo Engage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NETSUITEERP</c> - Designates a connection to Oracle NetSuite.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SALESFORCE</c> - Designates a connection to Salesforce using OAuth authentication.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SALESFORCEMARKETINGCLOUD</c> - Designates a connection to Salesforce Marketing
        /// Cloud.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SALESFORCEPARDOT</c> - Designates a connection to Salesforce Marketing Cloud Account
        /// Engagement (MCAE).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SAPODATA</c> - Designates a connection to SAP OData.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SERVICENOW</c> - Designates a connection to ServiceNow.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SLACK</c> - Designates a connection to Slack.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SNAPCHATADS</c> - Designates a connection to Snapchat Ads.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STRIPE</c> - Designates a connection to Stripe.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ZENDESK</c> - Designates a connection to Zendesk.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ZOHOCRM</c> - Designates a connection to Zoho CRM.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information on the connection parameters needed for a particular connector,
        /// see the documentation for the connector in <a href="https://docs.aws.amazon.com/glue/latest/dg/console-connections.html">Adding
        /// an Glue connection</a>in the Glue User Guide.
        /// </para>
        ///  
        /// <para>
        ///  <c>SFTP</c> is not supported.
        /// </para>
        ///  
        /// <para>
        /// For more information about how optional ConnectionProperties are used to configure
        /// features in Glue, consult <a href="https://docs.aws.amazon.com/glue/latest/dg/connection-defining.html">Glue
        /// connection properties</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about how optional ConnectionProperties are used to configure
        /// features in Glue Studio, consult <a href="https://docs.aws.amazon.com/glue/latest/ug/connectors-chapter.html">Using
        /// connectors and connections</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectionType ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }

        // Check to see if ConnectionType property is set
        internal bool IsSetConnectionType()
        {
            return this._connectionType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property MatchCriteria. 
        /// <para>
        /// A list of criteria that can be used in selecting this connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> MatchCriteria
        {
            get { return this._matchCriteria; }
            set { this._matchCriteria = value; }
        }

        // Check to see if MatchCriteria property is set
        internal bool IsSetMatchCriteria()
        {
            return this._matchCriteria != null && (this._matchCriteria.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PhysicalConnectionRequirements. 
        /// <para>
        /// The physical connection requirements, such as virtual private cloud (VPC) and <c>SecurityGroup</c>,
        /// that are needed to successfully make this connection.
        /// </para>
        /// </summary>
        public PhysicalConnectionRequirements PhysicalConnectionRequirements
        {
            get { return this._physicalConnectionRequirements; }
            set { this._physicalConnectionRequirements = value; }
        }

        // Check to see if PhysicalConnectionRequirements property is set
        internal bool IsSetPhysicalConnectionRequirements()
        {
            return this._physicalConnectionRequirements != null;
        }

        /// <summary>
        /// Gets and sets the property PythonProperties. 
        /// <para>
        /// Connection properties specific to the Python compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> PythonProperties
        {
            get { return this._pythonProperties; }
            set { this._pythonProperties = value; }
        }

        // Check to see if PythonProperties property is set
        internal bool IsSetPythonProperties()
        {
            return this._pythonProperties != null && (this._pythonProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SparkProperties. 
        /// <para>
        /// Connection properties specific to the Spark compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SparkProperties
        {
            get { return this._sparkProperties; }
            set { this._sparkProperties = value; }
        }

        // Check to see if SparkProperties property is set
        internal bool IsSetSparkProperties()
        {
            return this._sparkProperties != null && (this._sparkProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ValidateCredentials. 
        /// <para>
        /// A flag to validate the credentials during create connection. Default is true. 
        /// </para>
        /// </summary>
        public bool? ValidateCredentials
        {
            get { return this._validateCredentials; }
            set { this._validateCredentials = value; }
        }

        // Check to see if ValidateCredentials property is set
        internal bool IsSetValidateCredentials()
        {
            return this._validateCredentials.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidateForComputeEnvironments. 
        /// <para>
        /// The compute environments that the specified connection properties are validated against.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ValidateForComputeEnvironments
        {
            get { return this._validateForComputeEnvironments; }
            set { this._validateForComputeEnvironments = value; }
        }

        // Check to see if ValidateForComputeEnvironments property is set
        internal bool IsSetValidateForComputeEnvironments()
        {
            return this._validateForComputeEnvironments != null && (this._validateForComputeEnvironments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
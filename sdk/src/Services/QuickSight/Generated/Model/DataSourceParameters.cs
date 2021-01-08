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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The parameters that Amazon QuickSight uses to connect to your underlying data source.
    /// This is a variant type structure. For this structure to be valid, only one of the
    /// attributes can be non-null.
    /// </summary>
    public partial class DataSourceParameters
    {
        private AmazonElasticsearchParameters _amazonElasticsearchParameters;
        private AthenaParameters _athenaParameters;
        private AuroraParameters _auroraParameters;
        private AuroraPostgreSqlParameters _auroraPostgreSqlParameters;
        private AwsIotAnalyticsParameters _awsIotAnalyticsParameters;
        private JiraParameters _jiraParameters;
        private MariaDbParameters _mariaDbParameters;
        private MySqlParameters _mySqlParameters;
        private OracleParameters _oracleParameters;
        private PostgreSqlParameters _postgreSqlParameters;
        private PrestoParameters _prestoParameters;
        private RdsParameters _rdsParameters;
        private RedshiftParameters _redshiftParameters;
        private S3Parameters _s3Parameters;
        private ServiceNowParameters _serviceNowParameters;
        private SnowflakeParameters _snowflakeParameters;
        private SparkParameters _sparkParameters;
        private SqlServerParameters _sqlServerParameters;
        private TeradataParameters _teradataParameters;
        private TwitterParameters _twitterParameters;

        /// <summary>
        /// Gets and sets the property AmazonElasticsearchParameters. 
        /// <para>
        /// Amazon Elasticsearch Service parameters.
        /// </para>
        /// </summary>
        public AmazonElasticsearchParameters AmazonElasticsearchParameters
        {
            get { return this._amazonElasticsearchParameters; }
            set { this._amazonElasticsearchParameters = value; }
        }

        // Check to see if AmazonElasticsearchParameters property is set
        internal bool IsSetAmazonElasticsearchParameters()
        {
            return this._amazonElasticsearchParameters != null;
        }

        /// <summary>
        /// Gets and sets the property AthenaParameters. 
        /// <para>
        /// Amazon Athena parameters.
        /// </para>
        /// </summary>
        public AthenaParameters AthenaParameters
        {
            get { return this._athenaParameters; }
            set { this._athenaParameters = value; }
        }

        // Check to see if AthenaParameters property is set
        internal bool IsSetAthenaParameters()
        {
            return this._athenaParameters != null;
        }

        /// <summary>
        /// Gets and sets the property AuroraParameters. 
        /// <para>
        /// Amazon Aurora MySQL parameters.
        /// </para>
        /// </summary>
        public AuroraParameters AuroraParameters
        {
            get { return this._auroraParameters; }
            set { this._auroraParameters = value; }
        }

        // Check to see if AuroraParameters property is set
        internal bool IsSetAuroraParameters()
        {
            return this._auroraParameters != null;
        }

        /// <summary>
        /// Gets and sets the property AuroraPostgreSqlParameters. 
        /// <para>
        /// Aurora PostgreSQL parameters.
        /// </para>
        /// </summary>
        public AuroraPostgreSqlParameters AuroraPostgreSqlParameters
        {
            get { return this._auroraPostgreSqlParameters; }
            set { this._auroraPostgreSqlParameters = value; }
        }

        // Check to see if AuroraPostgreSqlParameters property is set
        internal bool IsSetAuroraPostgreSqlParameters()
        {
            return this._auroraPostgreSqlParameters != null;
        }

        /// <summary>
        /// Gets and sets the property AwsIotAnalyticsParameters. 
        /// <para>
        /// AWS IoT Analytics parameters.
        /// </para>
        /// </summary>
        public AwsIotAnalyticsParameters AwsIotAnalyticsParameters
        {
            get { return this._awsIotAnalyticsParameters; }
            set { this._awsIotAnalyticsParameters = value; }
        }

        // Check to see if AwsIotAnalyticsParameters property is set
        internal bool IsSetAwsIotAnalyticsParameters()
        {
            return this._awsIotAnalyticsParameters != null;
        }

        /// <summary>
        /// Gets and sets the property JiraParameters. 
        /// <para>
        /// Jira parameters.
        /// </para>
        /// </summary>
        public JiraParameters JiraParameters
        {
            get { return this._jiraParameters; }
            set { this._jiraParameters = value; }
        }

        // Check to see if JiraParameters property is set
        internal bool IsSetJiraParameters()
        {
            return this._jiraParameters != null;
        }

        /// <summary>
        /// Gets and sets the property MariaDbParameters. 
        /// <para>
        /// MariaDB parameters.
        /// </para>
        /// </summary>
        public MariaDbParameters MariaDbParameters
        {
            get { return this._mariaDbParameters; }
            set { this._mariaDbParameters = value; }
        }

        // Check to see if MariaDbParameters property is set
        internal bool IsSetMariaDbParameters()
        {
            return this._mariaDbParameters != null;
        }

        /// <summary>
        /// Gets and sets the property MySqlParameters. 
        /// <para>
        /// MySQL parameters.
        /// </para>
        /// </summary>
        public MySqlParameters MySqlParameters
        {
            get { return this._mySqlParameters; }
            set { this._mySqlParameters = value; }
        }

        // Check to see if MySqlParameters property is set
        internal bool IsSetMySqlParameters()
        {
            return this._mySqlParameters != null;
        }

        /// <summary>
        /// Gets and sets the property OracleParameters. 
        /// <para>
        /// Oracle parameters.
        /// </para>
        /// </summary>
        public OracleParameters OracleParameters
        {
            get { return this._oracleParameters; }
            set { this._oracleParameters = value; }
        }

        // Check to see if OracleParameters property is set
        internal bool IsSetOracleParameters()
        {
            return this._oracleParameters != null;
        }

        /// <summary>
        /// Gets and sets the property PostgreSqlParameters. 
        /// <para>
        /// PostgreSQL parameters.
        /// </para>
        /// </summary>
        public PostgreSqlParameters PostgreSqlParameters
        {
            get { return this._postgreSqlParameters; }
            set { this._postgreSqlParameters = value; }
        }

        // Check to see if PostgreSqlParameters property is set
        internal bool IsSetPostgreSqlParameters()
        {
            return this._postgreSqlParameters != null;
        }

        /// <summary>
        /// Gets and sets the property PrestoParameters. 
        /// <para>
        /// Presto parameters.
        /// </para>
        /// </summary>
        public PrestoParameters PrestoParameters
        {
            get { return this._prestoParameters; }
            set { this._prestoParameters = value; }
        }

        // Check to see if PrestoParameters property is set
        internal bool IsSetPrestoParameters()
        {
            return this._prestoParameters != null;
        }

        /// <summary>
        /// Gets and sets the property RdsParameters. 
        /// <para>
        /// Amazon RDS parameters.
        /// </para>
        /// </summary>
        public RdsParameters RdsParameters
        {
            get { return this._rdsParameters; }
            set { this._rdsParameters = value; }
        }

        // Check to see if RdsParameters property is set
        internal bool IsSetRdsParameters()
        {
            return this._rdsParameters != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftParameters. 
        /// <para>
        /// Amazon Redshift parameters.
        /// </para>
        /// </summary>
        public RedshiftParameters RedshiftParameters
        {
            get { return this._redshiftParameters; }
            set { this._redshiftParameters = value; }
        }

        // Check to see if RedshiftParameters property is set
        internal bool IsSetRedshiftParameters()
        {
            return this._redshiftParameters != null;
        }

        /// <summary>
        /// Gets and sets the property S3Parameters. 
        /// <para>
        /// S3 parameters.
        /// </para>
        /// </summary>
        public S3Parameters S3Parameters
        {
            get { return this._s3Parameters; }
            set { this._s3Parameters = value; }
        }

        // Check to see if S3Parameters property is set
        internal bool IsSetS3Parameters()
        {
            return this._s3Parameters != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNowParameters. 
        /// <para>
        /// ServiceNow parameters.
        /// </para>
        /// </summary>
        public ServiceNowParameters ServiceNowParameters
        {
            get { return this._serviceNowParameters; }
            set { this._serviceNowParameters = value; }
        }

        // Check to see if ServiceNowParameters property is set
        internal bool IsSetServiceNowParameters()
        {
            return this._serviceNowParameters != null;
        }

        /// <summary>
        /// Gets and sets the property SnowflakeParameters. 
        /// <para>
        /// Snowflake parameters.
        /// </para>
        /// </summary>
        public SnowflakeParameters SnowflakeParameters
        {
            get { return this._snowflakeParameters; }
            set { this._snowflakeParameters = value; }
        }

        // Check to see if SnowflakeParameters property is set
        internal bool IsSetSnowflakeParameters()
        {
            return this._snowflakeParameters != null;
        }

        /// <summary>
        /// Gets and sets the property SparkParameters. 
        /// <para>
        /// Spark parameters.
        /// </para>
        /// </summary>
        public SparkParameters SparkParameters
        {
            get { return this._sparkParameters; }
            set { this._sparkParameters = value; }
        }

        // Check to see if SparkParameters property is set
        internal bool IsSetSparkParameters()
        {
            return this._sparkParameters != null;
        }

        /// <summary>
        /// Gets and sets the property SqlServerParameters. 
        /// <para>
        /// SQL Server parameters.
        /// </para>
        /// </summary>
        public SqlServerParameters SqlServerParameters
        {
            get { return this._sqlServerParameters; }
            set { this._sqlServerParameters = value; }
        }

        // Check to see if SqlServerParameters property is set
        internal bool IsSetSqlServerParameters()
        {
            return this._sqlServerParameters != null;
        }

        /// <summary>
        /// Gets and sets the property TeradataParameters. 
        /// <para>
        /// Teradata parameters.
        /// </para>
        /// </summary>
        public TeradataParameters TeradataParameters
        {
            get { return this._teradataParameters; }
            set { this._teradataParameters = value; }
        }

        // Check to see if TeradataParameters property is set
        internal bool IsSetTeradataParameters()
        {
            return this._teradataParameters != null;
        }

        /// <summary>
        /// Gets and sets the property TwitterParameters. 
        /// <para>
        /// Twitter parameters.
        /// </para>
        /// </summary>
        public TwitterParameters TwitterParameters
        {
            get { return this._twitterParameters; }
            set { this._twitterParameters = value; }
        }

        // Check to see if TwitterParameters property is set
        internal bool IsSetTwitterParameters()
        {
            return this._twitterParameters != null;
        }

    }
}
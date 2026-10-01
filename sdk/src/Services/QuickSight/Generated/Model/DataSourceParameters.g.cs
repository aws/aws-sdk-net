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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The parameters that Quick Sight uses to connect to your underlying data source. This
    /// is a variant type structure. For this structure to be valid, only one of the attributes
    /// can be non-null.
    /// </summary>
    public partial class DataSourceParameters
    {
        /// <summary>
        /// Gets and sets the property AmazonElasticsearchParameters. 
        /// <para>
        /// The parameters for OpenSearch.
        /// </para>
        /// </summary>
        public AmazonElasticsearchParameters AmazonElasticsearchParameters { get; set; }

        /// <summary>
        /// Checks to see if the AmazonElasticsearchParameters property is set.
        /// </summary>
        internal bool IsSetAmazonElasticsearchParameters() => this.AmazonElasticsearchParameters != null;

        /// <summary>
        /// Gets and sets the property AmazonOpenSearchParameters. 
        /// <para>
        /// The parameters for OpenSearch.
        /// </para>
        /// </summary>
        public AmazonOpenSearchParameters AmazonOpenSearchParameters { get; set; }

        /// <summary>
        /// Checks to see if the AmazonOpenSearchParameters property is set.
        /// </summary>
        internal bool IsSetAmazonOpenSearchParameters() => this.AmazonOpenSearchParameters != null;

        /// <summary>
        /// Gets and sets the property AthenaParameters. 
        /// <para>
        /// The parameters for Amazon Athena.
        /// </para>
        /// </summary>
        public AthenaParameters AthenaParameters { get; set; }

        /// <summary>
        /// Checks to see if the AthenaParameters property is set.
        /// </summary>
        internal bool IsSetAthenaParameters() => this.AthenaParameters != null;

        /// <summary>
        /// Gets and sets the property AuroraParameters. 
        /// <para>
        /// The parameters for Amazon Aurora MySQL.
        /// </para>
        /// </summary>
        public AuroraParameters AuroraParameters { get; set; }

        /// <summary>
        /// Checks to see if the AuroraParameters property is set.
        /// </summary>
        internal bool IsSetAuroraParameters() => this.AuroraParameters != null;

        /// <summary>
        /// Gets and sets the property AuroraPostgreSqlParameters. 
        /// <para>
        /// The parameters for Amazon Aurora.
        /// </para>
        /// </summary>
        public AuroraPostgreSqlParameters AuroraPostgreSqlParameters { get; set; }

        /// <summary>
        /// Checks to see if the AuroraPostgreSqlParameters property is set.
        /// </summary>
        internal bool IsSetAuroraPostgreSqlParameters() => this.AuroraPostgreSqlParameters != null;

        /// <summary>
        /// Gets and sets the property AwsIotAnalyticsParameters. 
        /// <para>
        /// The parameters for IoT Analytics.
        /// </para>
        /// </summary>
        public AwsIotAnalyticsParameters AwsIotAnalyticsParameters { get; set; }

        /// <summary>
        /// Checks to see if the AwsIotAnalyticsParameters property is set.
        /// </summary>
        internal bool IsSetAwsIotAnalyticsParameters() => this.AwsIotAnalyticsParameters != null;

        /// <summary>
        /// Gets and sets the property BigQueryParameters. 
        /// <para>
        /// The parameters that are required to connect to a Google BigQuery data source.
        /// </para>
        /// </summary>
        public BigQueryParameters BigQueryParameters { get; set; }

        /// <summary>
        /// Checks to see if the BigQueryParameters property is set.
        /// </summary>
        internal bool IsSetBigQueryParameters() => this.BigQueryParameters != null;

        /// <summary>
        /// Gets and sets the property ConfluenceParameters. 
        /// <para>
        /// The parameters for Confluence.
        /// </para>
        /// </summary>
        public ConfluenceParameters ConfluenceParameters { get; set; }

        /// <summary>
        /// Checks to see if the ConfluenceParameters property is set.
        /// </summary>
        internal bool IsSetConfluenceParameters() => this.ConfluenceParameters != null;

        /// <summary>
        /// Gets and sets the property CustomConnectionParameters. 
        /// <para>
        /// The parameters for custom connectors.
        /// </para>
        /// </summary>
        public CustomConnectionParameters CustomConnectionParameters { get; set; }

        /// <summary>
        /// Checks to see if the CustomConnectionParameters property is set.
        /// </summary>
        internal bool IsSetCustomConnectionParameters() => this.CustomConnectionParameters != null;

        /// <summary>
        /// Gets and sets the property DatabricksParameters. 
        /// <para>
        /// The parameters that are required to connect to a Databricks data source.
        /// </para>
        /// </summary>
        public DatabricksParameters DatabricksParameters { get; set; }

        /// <summary>
        /// Checks to see if the DatabricksParameters property is set.
        /// </summary>
        internal bool IsSetDatabricksParameters() => this.DatabricksParameters != null;

        /// <summary>
        /// Gets and sets the property ExasolParameters. 
        /// <para>
        /// The parameters for Exasol.
        /// </para>
        /// </summary>
        public ExasolParameters ExasolParameters { get; set; }

        /// <summary>
        /// Checks to see if the ExasolParameters property is set.
        /// </summary>
        internal bool IsSetExasolParameters() => this.ExasolParameters != null;

        /// <summary>
        /// Gets and sets the property FMKBParameters. 
        /// <para>
        /// The parameters for a fully managed knowledge base data source.
        /// </para>
        /// </summary>
        public FMKBParameters FMKBParameters { get; set; }

        /// <summary>
        /// Checks to see if the FMKBParameters property is set.
        /// </summary>
        internal bool IsSetFMKBParameters() => this.FMKBParameters != null;

        /// <summary>
        /// Gets and sets the property GoogleDriveParameters. 
        /// <para>
        /// The parameters for a Google Drive data source.
        /// </para>
        /// </summary>
        public GoogleDriveParameters GoogleDriveParameters { get; set; }

        /// <summary>
        /// Checks to see if the GoogleDriveParameters property is set.
        /// </summary>
        internal bool IsSetGoogleDriveParameters() => this.GoogleDriveParameters != null;

        /// <summary>
        /// Gets and sets the property ImpalaParameters. 
        /// <para>
        /// The parameters for Impala.
        /// </para>
        /// </summary>
        public ImpalaParameters ImpalaParameters { get; set; }

        /// <summary>
        /// Checks to see if the ImpalaParameters property is set.
        /// </summary>
        internal bool IsSetImpalaParameters() => this.ImpalaParameters != null;

        /// <summary>
        /// Gets and sets the property JiraParameters. 
        /// <para>
        /// The parameters for Jira.
        /// </para>
        /// </summary>
        public JiraParameters JiraParameters { get; set; }

        /// <summary>
        /// Checks to see if the JiraParameters property is set.
        /// </summary>
        internal bool IsSetJiraParameters() => this.JiraParameters != null;

        /// <summary>
        /// Gets and sets the property MariaDbParameters. 
        /// <para>
        /// The parameters for MariaDB.
        /// </para>
        /// </summary>
        public MariaDbParameters MariaDbParameters { get; set; }

        /// <summary>
        /// Checks to see if the MariaDbParameters property is set.
        /// </summary>
        internal bool IsSetMariaDbParameters() => this.MariaDbParameters != null;

        /// <summary>
        /// Gets and sets the property MySqlParameters. 
        /// <para>
        /// The parameters for MySQL.
        /// </para>
        /// </summary>
        public MySqlParameters MySqlParameters { get; set; }

        /// <summary>
        /// Checks to see if the MySqlParameters property is set.
        /// </summary>
        internal bool IsSetMySqlParameters() => this.MySqlParameters != null;

        /// <summary>
        /// Gets and sets the property OneDriveParameters. 
        /// <para>
        /// The parameters for an OneDrive data source.
        /// </para>
        /// </summary>
        public OneDriveParameters OneDriveParameters { get; set; }

        /// <summary>
        /// Checks to see if the OneDriveParameters property is set.
        /// </summary>
        internal bool IsSetOneDriveParameters() => this.OneDriveParameters != null;

        /// <summary>
        /// Gets and sets the property OracleParameters. 
        /// <para>
        /// The parameters for Oracle.
        /// </para>
        /// </summary>
        public OracleParameters OracleParameters { get; set; }

        /// <summary>
        /// Checks to see if the OracleParameters property is set.
        /// </summary>
        internal bool IsSetOracleParameters() => this.OracleParameters != null;

        /// <summary>
        /// Gets and sets the property PostgreSqlParameters. 
        /// <para>
        /// The parameters for PostgreSQL.
        /// </para>
        /// </summary>
        public PostgreSqlParameters PostgreSqlParameters { get; set; }

        /// <summary>
        /// Checks to see if the PostgreSqlParameters property is set.
        /// </summary>
        internal bool IsSetPostgreSqlParameters() => this.PostgreSqlParameters != null;

        /// <summary>
        /// Gets and sets the property PrestoParameters. 
        /// <para>
        /// The parameters for Presto.
        /// </para>
        /// </summary>
        public PrestoParameters PrestoParameters { get; set; }

        /// <summary>
        /// Checks to see if the PrestoParameters property is set.
        /// </summary>
        internal bool IsSetPrestoParameters() => this.PrestoParameters != null;

        /// <summary>
        /// Gets and sets the property QBusinessParameters. 
        /// <para>
        /// The parameters for Amazon Q Business.
        /// </para>
        /// </summary>
        public QBusinessParameters QBusinessParameters { get; set; }

        /// <summary>
        /// Checks to see if the QBusinessParameters property is set.
        /// </summary>
        internal bool IsSetQBusinessParameters() => this.QBusinessParameters != null;

        /// <summary>
        /// Gets and sets the property RdsParameters. 
        /// <para>
        /// The parameters for Amazon RDS.
        /// </para>
        /// </summary>
        public RdsParameters RdsParameters { get; set; }

        /// <summary>
        /// Checks to see if the RdsParameters property is set.
        /// </summary>
        internal bool IsSetRdsParameters() => this.RdsParameters != null;

        /// <summary>
        /// Gets and sets the property RedshiftParameters. 
        /// <para>
        /// The parameters for Amazon Redshift.
        /// </para>
        /// </summary>
        public RedshiftParameters RedshiftParameters { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftParameters property is set.
        /// </summary>
        internal bool IsSetRedshiftParameters() => this.RedshiftParameters != null;

        /// <summary>
        /// Gets and sets the property S3KnowledgeBaseParameters. 
        /// <para>
        /// The parameters for S3 Knowledge Base.
        /// </para>
        /// </summary>
        public S3KnowledgeBaseParameters S3KnowledgeBaseParameters { get; set; }

        /// <summary>
        /// Checks to see if the S3KnowledgeBaseParameters property is set.
        /// </summary>
        internal bool IsSetS3KnowledgeBaseParameters() => this.S3KnowledgeBaseParameters != null;

        /// <summary>
        /// Gets and sets the property S3Parameters. 
        /// <para>
        /// The parameters for S3.
        /// </para>
        /// </summary>
        public S3Parameters S3Parameters { get; set; }

        /// <summary>
        /// Checks to see if the S3Parameters property is set.
        /// </summary>
        internal bool IsSetS3Parameters() => this.S3Parameters != null;

        /// <summary>
        /// Gets and sets the property S3TablesParameters. 
        /// <para>
        /// The parameters for S3 Tables.
        /// </para>
        /// </summary>
        public S3TablesParameters S3TablesParameters { get; set; }

        /// <summary>
        /// Checks to see if the S3TablesParameters property is set.
        /// </summary>
        internal bool IsSetS3TablesParameters() => this.S3TablesParameters != null;

        /// <summary>
        /// Gets and sets the property ServiceNowParameters. 
        /// <para>
        /// The parameters for ServiceNow.
        /// </para>
        /// </summary>
        public ServiceNowParameters ServiceNowParameters { get; set; }

        /// <summary>
        /// Checks to see if the ServiceNowParameters property is set.
        /// </summary>
        internal bool IsSetServiceNowParameters() => this.ServiceNowParameters != null;

        /// <summary>
        /// Gets and sets the property SharePointParameters. 
        /// <para>
        /// The parameters for a SharePoint data source.
        /// </para>
        /// </summary>
        public SharePointParameters SharePointParameters { get; set; }

        /// <summary>
        /// Checks to see if the SharePointParameters property is set.
        /// </summary>
        internal bool IsSetSharePointParameters() => this.SharePointParameters != null;

        /// <summary>
        /// Gets and sets the property SnowflakeParameters. 
        /// <para>
        /// The parameters for Snowflake.
        /// </para>
        /// </summary>
        public SnowflakeParameters SnowflakeParameters { get; set; }

        /// <summary>
        /// Checks to see if the SnowflakeParameters property is set.
        /// </summary>
        internal bool IsSetSnowflakeParameters() => this.SnowflakeParameters != null;

        /// <summary>
        /// Gets and sets the property SparkParameters. 
        /// <para>
        /// The parameters for Spark.
        /// </para>
        /// </summary>
        public SparkParameters SparkParameters { get; set; }

        /// <summary>
        /// Checks to see if the SparkParameters property is set.
        /// </summary>
        internal bool IsSetSparkParameters() => this.SparkParameters != null;

        /// <summary>
        /// Gets and sets the property SqlServerParameters. 
        /// <para>
        /// The parameters for SQL Server.
        /// </para>
        /// </summary>
        public SqlServerParameters SqlServerParameters { get; set; }

        /// <summary>
        /// Checks to see if the SqlServerParameters property is set.
        /// </summary>
        internal bool IsSetSqlServerParameters() => this.SqlServerParameters != null;

        /// <summary>
        /// Gets and sets the property StarburstParameters. 
        /// <para>
        /// The parameters that are required to connect to a Starburst data source.
        /// </para>
        /// </summary>
        public StarburstParameters StarburstParameters { get; set; }

        /// <summary>
        /// Checks to see if the StarburstParameters property is set.
        /// </summary>
        internal bool IsSetStarburstParameters() => this.StarburstParameters != null;

        /// <summary>
        /// Gets and sets the property TeradataParameters. 
        /// <para>
        /// The parameters for Teradata.
        /// </para>
        /// </summary>
        public TeradataParameters TeradataParameters { get; set; }

        /// <summary>
        /// Checks to see if the TeradataParameters property is set.
        /// </summary>
        internal bool IsSetTeradataParameters() => this.TeradataParameters != null;

        /// <summary>
        /// Gets and sets the property TrinoParameters. 
        /// <para>
        /// The parameters that are required to connect to a Trino data source.
        /// </para>
        /// </summary>
        public TrinoParameters TrinoParameters { get; set; }

        /// <summary>
        /// Checks to see if the TrinoParameters property is set.
        /// </summary>
        internal bool IsSetTrinoParameters() => this.TrinoParameters != null;

        /// <summary>
        /// Gets and sets the property TwitterParameters. 
        /// <para>
        /// The parameters for Twitter.
        /// </para>
        /// </summary>
        public TwitterParameters TwitterParameters { get; set; }

        /// <summary>
        /// Checks to see if the TwitterParameters property is set.
        /// </summary>
        internal bool IsSetTwitterParameters() => this.TwitterParameters != null;

        /// <summary>
        /// Gets and sets the property WebCrawlerParameters. 
        /// <para>
        /// The parameters for Web Crawler.
        /// </para>
        /// </summary>
        public WebCrawlerParameters WebCrawlerParameters { get; set; }

        /// <summary>
        /// Checks to see if the WebCrawlerParameters property is set.
        /// </summary>
        internal bool IsSetWebCrawlerParameters() => this.WebCrawlerParameters != null;
    }
}

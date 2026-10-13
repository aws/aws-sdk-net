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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// <c>CodeGenConfigurationNode</c> enumerates all valid Node types. One and only one
    /// of its member variables can be populated.
    /// </summary>
    public partial class CodeGenConfigurationNode
    {
        /// <summary>
        /// Gets and sets the property Aggregate. 
        /// <para>
        /// Specifies a transform that groups rows by chosen fields and computes the aggregated
        /// value by specified function.
        /// </para>
        /// </summary>
        public Aggregate Aggregate { get; set; }

        /// <summary>
        /// Checks to see if the Aggregate property is set.
        /// </summary>
        internal bool IsSetAggregate() => this.Aggregate != null;

        /// <summary>
        /// Gets and sets the property AmazonRedshiftSource. 
        /// <para>
        /// Specifies a target that writes to a data source in Amazon Redshift.
        /// </para>
        /// </summary>
        public AmazonRedshiftSource AmazonRedshiftSource { get; set; }

        /// <summary>
        /// Checks to see if the AmazonRedshiftSource property is set.
        /// </summary>
        internal bool IsSetAmazonRedshiftSource() => this.AmazonRedshiftSource != null;

        /// <summary>
        /// Gets and sets the property AmazonRedshiftTarget. 
        /// <para>
        /// Specifies a target that writes to a data target in Amazon Redshift.
        /// </para>
        /// </summary>
        public AmazonRedshiftTarget AmazonRedshiftTarget { get; set; }

        /// <summary>
        /// Checks to see if the AmazonRedshiftTarget property is set.
        /// </summary>
        internal bool IsSetAmazonRedshiftTarget() => this.AmazonRedshiftTarget != null;

        /// <summary>
        /// Gets and sets the property ApplyMapping. 
        /// <para>
        /// Specifies a transform that maps data property keys in the data source to data property
        /// keys in the data target. You can rename keys, modify the data types for keys, and
        /// choose which keys to drop from the dataset.
        /// </para>
        /// </summary>
        public ApplyMapping ApplyMapping { get; set; }

        /// <summary>
        /// Checks to see if the ApplyMapping property is set.
        /// </summary>
        internal bool IsSetApplyMapping() => this.ApplyMapping != null;

        /// <summary>
        /// Gets and sets the property AthenaConnectorSource. 
        /// <para>
        /// Specifies a connector to an Amazon Athena data source.
        /// </para>
        /// </summary>
        public AthenaConnectorSource AthenaConnectorSource { get; set; }

        /// <summary>
        /// Checks to see if the AthenaConnectorSource property is set.
        /// </summary>
        internal bool IsSetAthenaConnectorSource() => this.AthenaConnectorSource != null;

        /// <summary>
        /// Gets and sets the property CatalogDeltaSource. 
        /// <para>
        /// Specifies a Delta Lake data source that is registered in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public CatalogDeltaSource CatalogDeltaSource { get; set; }

        /// <summary>
        /// Checks to see if the CatalogDeltaSource property is set.
        /// </summary>
        internal bool IsSetCatalogDeltaSource() => this.CatalogDeltaSource != null;

        /// <summary>
        /// Gets and sets the property CatalogHudiSource. 
        /// <para>
        /// Specifies a Hudi data source that is registered in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public CatalogHudiSource CatalogHudiSource { get; set; }

        /// <summary>
        /// Checks to see if the CatalogHudiSource property is set.
        /// </summary>
        internal bool IsSetCatalogHudiSource() => this.CatalogHudiSource != null;

        /// <summary>
        /// Gets and sets the property CatalogIcebergSource. 
        /// <para>
        /// Specifies an Apache Iceberg data source that is registered in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public CatalogIcebergSource CatalogIcebergSource { get; set; }

        /// <summary>
        /// Checks to see if the CatalogIcebergSource property is set.
        /// </summary>
        internal bool IsSetCatalogIcebergSource() => this.CatalogIcebergSource != null;

        /// <summary>
        /// Gets and sets the property CatalogKafkaSource. 
        /// <para>
        /// Specifies an Apache Kafka data store in the Data Catalog.
        /// </para>
        /// </summary>
        public CatalogKafkaSource CatalogKafkaSource { get; set; }

        /// <summary>
        /// Checks to see if the CatalogKafkaSource property is set.
        /// </summary>
        internal bool IsSetCatalogKafkaSource() => this.CatalogKafkaSource != null;

        /// <summary>
        /// Gets and sets the property CatalogKinesisSource. 
        /// <para>
        /// Specifies a Kinesis data source in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public CatalogKinesisSource CatalogKinesisSource { get; set; }

        /// <summary>
        /// Checks to see if the CatalogKinesisSource property is set.
        /// </summary>
        internal bool IsSetCatalogKinesisSource() => this.CatalogKinesisSource != null;

        /// <summary>
        /// Gets and sets the property CatalogSource. 
        /// <para>
        /// Specifies a data store in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public CatalogSource CatalogSource { get; set; }

        /// <summary>
        /// Checks to see if the CatalogSource property is set.
        /// </summary>
        internal bool IsSetCatalogSource() => this.CatalogSource != null;

        /// <summary>
        /// Gets and sets the property CatalogTarget. 
        /// <para>
        /// Specifies a target that uses a Glue Data Catalog table.
        /// </para>
        /// </summary>
        public BasicCatalogTarget CatalogTarget { get; set; }

        /// <summary>
        /// Checks to see if the CatalogTarget property is set.
        /// </summary>
        internal bool IsSetCatalogTarget() => this.CatalogTarget != null;

        /// <summary>
        /// Gets and sets the property ConnectorDataSource. 
        /// <para>
        /// Specifies a source generated with standard connection options.
        /// </para>
        /// </summary>
        public ConnectorDataSource ConnectorDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorDataSource property is set.
        /// </summary>
        internal bool IsSetConnectorDataSource() => this.ConnectorDataSource != null;

        /// <summary>
        /// Gets and sets the property ConnectorDataTarget. 
        /// <para>
        /// Specifies a target generated with standard connection options.
        /// </para>
        /// </summary>
        public ConnectorDataTarget ConnectorDataTarget { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorDataTarget property is set.
        /// </summary>
        internal bool IsSetConnectorDataTarget() => this.ConnectorDataTarget != null;

        /// <summary>
        /// Gets and sets the property CustomCode. 
        /// <para>
        /// Specifies a transform that uses custom code you provide to perform the data transformation.
        /// The output is a collection of DynamicFrames.
        /// </para>
        /// </summary>
        public CustomCode CustomCode { get; set; }

        /// <summary>
        /// Checks to see if the CustomCode property is set.
        /// </summary>
        internal bool IsSetCustomCode() => this.CustomCode != null;

        /// <summary>
        /// Gets and sets the property DirectJDBCSource.
        /// </summary>
        public DirectJDBCSource DirectJDBCSource { get; set; }

        /// <summary>
        /// Checks to see if the DirectJDBCSource property is set.
        /// </summary>
        internal bool IsSetDirectJDBCSource() => this.DirectJDBCSource != null;

        /// <summary>
        /// Gets and sets the property DirectKafkaSource. 
        /// <para>
        /// Specifies an Apache Kafka data store.
        /// </para>
        /// </summary>
        public DirectKafkaSource DirectKafkaSource { get; set; }

        /// <summary>
        /// Checks to see if the DirectKafkaSource property is set.
        /// </summary>
        internal bool IsSetDirectKafkaSource() => this.DirectKafkaSource != null;

        /// <summary>
        /// Gets and sets the property DirectKinesisSource. 
        /// <para>
        /// Specifies a direct Amazon Kinesis data source.
        /// </para>
        /// </summary>
        public DirectKinesisSource DirectKinesisSource { get; set; }

        /// <summary>
        /// Checks to see if the DirectKinesisSource property is set.
        /// </summary>
        internal bool IsSetDirectKinesisSource() => this.DirectKinesisSource != null;

        /// <summary>
        /// Gets and sets the property DropDuplicates. 
        /// <para>
        /// Specifies a transform that removes rows of repeating data from a data set.
        /// </para>
        /// </summary>
        public DropDuplicates DropDuplicates { get; set; }

        /// <summary>
        /// Checks to see if the DropDuplicates property is set.
        /// </summary>
        internal bool IsSetDropDuplicates() => this.DropDuplicates != null;

        /// <summary>
        /// Gets and sets the property DropFields. 
        /// <para>
        /// Specifies a transform that chooses the data property keys that you want to drop.
        /// </para>
        /// </summary>
        public DropFields DropFields { get; set; }

        /// <summary>
        /// Checks to see if the DropFields property is set.
        /// </summary>
        internal bool IsSetDropFields() => this.DropFields != null;

        /// <summary>
        /// Gets and sets the property DropNullFields. 
        /// <para>
        /// Specifies a transform that removes columns from the dataset if all values in the column
        /// are 'null'. By default, Glue Studio will recognize null objects, but some values such
        /// as empty strings, strings that are "null", -1 integers or other placeholders such
        /// as zeros, are not automatically recognized as nulls.
        /// </para>
        /// </summary>
        public DropNullFields DropNullFields { get; set; }

        /// <summary>
        /// Checks to see if the DropNullFields property is set.
        /// </summary>
        internal bool IsSetDropNullFields() => this.DropNullFields != null;

        /// <summary>
        /// Gets and sets the property DynamicTransform. 
        /// <para>
        /// Specifies a custom visual transform created by a user.
        /// </para>
        /// </summary>
        public DynamicTransform DynamicTransform { get; set; }

        /// <summary>
        /// Checks to see if the DynamicTransform property is set.
        /// </summary>
        internal bool IsSetDynamicTransform() => this.DynamicTransform != null;

        /// <summary>
        /// Gets and sets the property DynamoDBCatalogSource. 
        /// <para>
        /// Specifies a DynamoDBC Catalog data store in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public DynamoDBCatalogSource DynamoDBCatalogSource { get; set; }

        /// <summary>
        /// Checks to see if the DynamoDBCatalogSource property is set.
        /// </summary>
        internal bool IsSetDynamoDBCatalogSource() => this.DynamoDBCatalogSource != null;

        /// <summary>
        /// Gets and sets the property DynamoDBELTConnectorSource. 
        /// <para>
        /// Specifies a DynamoDB ELT connector source for extracting data from DynamoDB tables.
        /// </para>
        /// </summary>
        public DynamoDBELTConnectorSource DynamoDBELTConnectorSource { get; set; }

        /// <summary>
        /// Checks to see if the DynamoDBELTConnectorSource property is set.
        /// </summary>
        internal bool IsSetDynamoDBELTConnectorSource() => this.DynamoDBELTConnectorSource != null;

        /// <summary>
        /// Gets and sets the property EvaluateDataQuality. 
        /// <para>
        /// Specifies your data quality evaluation criteria.
        /// </para>
        /// </summary>
        public EvaluateDataQuality EvaluateDataQuality { get; set; }

        /// <summary>
        /// Checks to see if the EvaluateDataQuality property is set.
        /// </summary>
        internal bool IsSetEvaluateDataQuality() => this.EvaluateDataQuality != null;

        /// <summary>
        /// Gets and sets the property EvaluateDataQualityMultiFrame. 
        /// <para>
        /// Specifies your data quality evaluation criteria. Allows multiple input data and returns
        /// a collection of Dynamic Frames.
        /// </para>
        /// </summary>
        public EvaluateDataQualityMultiFrame EvaluateDataQualityMultiFrame { get; set; }

        /// <summary>
        /// Checks to see if the EvaluateDataQualityMultiFrame property is set.
        /// </summary>
        internal bool IsSetEvaluateDataQualityMultiFrame() => this.EvaluateDataQualityMultiFrame != null;

        /// <summary>
        /// Gets and sets the property FillMissingValues. 
        /// <para>
        /// Specifies a transform that locates records in the dataset that have missing values
        /// and adds a new field with a value determined by imputation. The input data set is
        /// used to train the machine learning model that determines what the missing value should
        /// be.
        /// </para>
        /// </summary>
        public FillMissingValues FillMissingValues { get; set; }

        /// <summary>
        /// Checks to see if the FillMissingValues property is set.
        /// </summary>
        internal bool IsSetFillMissingValues() => this.FillMissingValues != null;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Specifies a transform that splits a dataset into two, based on a filter condition.
        /// </para>
        /// </summary>
        public Filter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property GovernedCatalogSource. 
        /// <para>
        /// Specifies a data source in a goverened Data Catalog.
        /// </para>
        /// </summary>
        public GovernedCatalogSource GovernedCatalogSource { get; set; }

        /// <summary>
        /// Checks to see if the GovernedCatalogSource property is set.
        /// </summary>
        internal bool IsSetGovernedCatalogSource() => this.GovernedCatalogSource != null;

        /// <summary>
        /// Gets and sets the property GovernedCatalogTarget. 
        /// <para>
        /// Specifies a data target that writes to a goverened catalog.
        /// </para>
        /// </summary>
        public GovernedCatalogTarget GovernedCatalogTarget { get; set; }

        /// <summary>
        /// Checks to see if the GovernedCatalogTarget property is set.
        /// </summary>
        internal bool IsSetGovernedCatalogTarget() => this.GovernedCatalogTarget != null;

        /// <summary>
        /// Gets and sets the property JDBCConnectorSource. 
        /// <para>
        /// Specifies a connector to a JDBC data source.
        /// </para>
        /// </summary>
        public JDBCConnectorSource JDBCConnectorSource { get; set; }

        /// <summary>
        /// Checks to see if the JDBCConnectorSource property is set.
        /// </summary>
        internal bool IsSetJDBCConnectorSource() => this.JDBCConnectorSource != null;

        /// <summary>
        /// Gets and sets the property JDBCConnectorTarget. 
        /// <para>
        /// Specifies a data target that writes to Amazon S3 in Apache Parquet columnar storage.
        /// </para>
        /// </summary>
        public JDBCConnectorTarget JDBCConnectorTarget { get; set; }

        /// <summary>
        /// Checks to see if the JDBCConnectorTarget property is set.
        /// </summary>
        internal bool IsSetJDBCConnectorTarget() => this.JDBCConnectorTarget != null;

        /// <summary>
        /// Gets and sets the property Join. 
        /// <para>
        /// Specifies a transform that joins two datasets into one dataset using a comparison
        /// phrase on the specified data property keys. You can use inner, outer, left, right,
        /// left semi, and left anti joins.
        /// </para>
        /// </summary>
        public Join Join { get; set; }

        /// <summary>
        /// Checks to see if the Join property is set.
        /// </summary>
        internal bool IsSetJoin() => this.Join != null;

        /// <summary>
        /// Gets and sets the property Merge. 
        /// <para>
        /// Specifies a transform that merges a <c>DynamicFrame</c> with a staging <c>DynamicFrame</c>
        /// based on the specified primary keys to identify records. Duplicate records (records
        /// with the same primary keys) are not de-duplicated. 
        /// </para>
        /// </summary>
        public Merge Merge { get; set; }

        /// <summary>
        /// Checks to see if the Merge property is set.
        /// </summary>
        internal bool IsSetMerge() => this.Merge != null;

        /// <summary>
        /// Gets and sets the property MicrosoftSQLServerCatalogSource. 
        /// <para>
        /// Specifies a Microsoft SQL server data source in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public MicrosoftSQLServerCatalogSource MicrosoftSQLServerCatalogSource { get; set; }

        /// <summary>
        /// Checks to see if the MicrosoftSQLServerCatalogSource property is set.
        /// </summary>
        internal bool IsSetMicrosoftSQLServerCatalogSource() => this.MicrosoftSQLServerCatalogSource != null;

        /// <summary>
        /// Gets and sets the property MicrosoftSQLServerCatalogTarget. 
        /// <para>
        /// Specifies a target that uses Microsoft SQL.
        /// </para>
        /// </summary>
        public MicrosoftSQLServerCatalogTarget MicrosoftSQLServerCatalogTarget { get; set; }

        /// <summary>
        /// Checks to see if the MicrosoftSQLServerCatalogTarget property is set.
        /// </summary>
        internal bool IsSetMicrosoftSQLServerCatalogTarget() => this.MicrosoftSQLServerCatalogTarget != null;

        /// <summary>
        /// Gets and sets the property MySQLCatalogSource. 
        /// <para>
        /// Specifies a MySQL data source in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public MySQLCatalogSource MySQLCatalogSource { get; set; }

        /// <summary>
        /// Checks to see if the MySQLCatalogSource property is set.
        /// </summary>
        internal bool IsSetMySQLCatalogSource() => this.MySQLCatalogSource != null;

        /// <summary>
        /// Gets and sets the property MySQLCatalogTarget. 
        /// <para>
        /// Specifies a target that uses MySQL.
        /// </para>
        /// </summary>
        public MySQLCatalogTarget MySQLCatalogTarget { get; set; }

        /// <summary>
        /// Checks to see if the MySQLCatalogTarget property is set.
        /// </summary>
        internal bool IsSetMySQLCatalogTarget() => this.MySQLCatalogTarget != null;

        /// <summary>
        /// Gets and sets the property OracleSQLCatalogSource. 
        /// <para>
        /// Specifies an Oracle data source in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public OracleSQLCatalogSource OracleSQLCatalogSource { get; set; }

        /// <summary>
        /// Checks to see if the OracleSQLCatalogSource property is set.
        /// </summary>
        internal bool IsSetOracleSQLCatalogSource() => this.OracleSQLCatalogSource != null;

        /// <summary>
        /// Gets and sets the property OracleSQLCatalogTarget. 
        /// <para>
        /// Specifies a target that uses Oracle SQL.
        /// </para>
        /// </summary>
        public OracleSQLCatalogTarget OracleSQLCatalogTarget { get; set; }

        /// <summary>
        /// Checks to see if the OracleSQLCatalogTarget property is set.
        /// </summary>
        internal bool IsSetOracleSQLCatalogTarget() => this.OracleSQLCatalogTarget != null;

        /// <summary>
        /// Gets and sets the property PIIDetection. 
        /// <para>
        /// Specifies a transform that identifies, removes or masks PII data.
        /// </para>
        /// </summary>
        public PIIDetection PIIDetection { get; set; }

        /// <summary>
        /// Checks to see if the PIIDetection property is set.
        /// </summary>
        internal bool IsSetPIIDetection() => this.PIIDetection != null;

        /// <summary>
        /// Gets and sets the property PostgreSQLCatalogSource. 
        /// <para>
        /// Specifies a PostgresSQL data source in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public PostgreSQLCatalogSource PostgreSQLCatalogSource { get; set; }

        /// <summary>
        /// Checks to see if the PostgreSQLCatalogSource property is set.
        /// </summary>
        internal bool IsSetPostgreSQLCatalogSource() => this.PostgreSQLCatalogSource != null;

        /// <summary>
        /// Gets and sets the property PostgreSQLCatalogTarget. 
        /// <para>
        /// Specifies a target that uses Postgres SQL.
        /// </para>
        /// </summary>
        public PostgreSQLCatalogTarget PostgreSQLCatalogTarget { get; set; }

        /// <summary>
        /// Checks to see if the PostgreSQLCatalogTarget property is set.
        /// </summary>
        internal bool IsSetPostgreSQLCatalogTarget() => this.PostgreSQLCatalogTarget != null;

        /// <summary>
        /// Gets and sets the property Recipe. 
        /// <para>
        /// Specifies a Glue DataBrew recipe node.
        /// </para>
        /// </summary>
        public Recipe Recipe { get; set; }

        /// <summary>
        /// Checks to see if the Recipe property is set.
        /// </summary>
        internal bool IsSetRecipe() => this.Recipe != null;

        /// <summary>
        /// Gets and sets the property RedshiftSource. 
        /// <para>
        /// Specifies an Amazon Redshift data store.
        /// </para>
        /// </summary>
        public RedshiftSource RedshiftSource { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftSource property is set.
        /// </summary>
        internal bool IsSetRedshiftSource() => this.RedshiftSource != null;

        /// <summary>
        /// Gets and sets the property RedshiftTarget. 
        /// <para>
        /// Specifies a target that uses Amazon Redshift.
        /// </para>
        /// </summary>
        public RedshiftTarget RedshiftTarget { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftTarget property is set.
        /// </summary>
        internal bool IsSetRedshiftTarget() => this.RedshiftTarget != null;

        /// <summary>
        /// Gets and sets the property RelationalCatalogSource. 
        /// <para>
        /// Specifies a relational catalog data store in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public RelationalCatalogSource RelationalCatalogSource { get; set; }

        /// <summary>
        /// Checks to see if the RelationalCatalogSource property is set.
        /// </summary>
        internal bool IsSetRelationalCatalogSource() => this.RelationalCatalogSource != null;

        /// <summary>
        /// Gets and sets the property RenameField. 
        /// <para>
        /// Specifies a transform that renames a single data property key.
        /// </para>
        /// </summary>
        public RenameField RenameField { get; set; }

        /// <summary>
        /// Checks to see if the RenameField property is set.
        /// </summary>
        internal bool IsSetRenameField() => this.RenameField != null;

        /// <summary>
        /// Gets and sets the property Route. 
        /// <para>
        /// Specifies a route node that directs data to different output paths based on defined
        /// filtering conditions.
        /// </para>
        /// </summary>
        public Route Route { get; set; }

        /// <summary>
        /// Checks to see if the Route property is set.
        /// </summary>
        internal bool IsSetRoute() => this.Route != null;

        /// <summary>
        /// Gets and sets the property S3CatalogDeltaSource. 
        /// <para>
        /// Specifies a Delta Lake data source that is registered in the Glue Data Catalog. The
        /// data source must be stored in Amazon S3.
        /// </para>
        /// </summary>
        public S3CatalogDeltaSource S3CatalogDeltaSource { get; set; }

        /// <summary>
        /// Checks to see if the S3CatalogDeltaSource property is set.
        /// </summary>
        internal bool IsSetS3CatalogDeltaSource() => this.S3CatalogDeltaSource != null;

        /// <summary>
        /// Gets and sets the property S3CatalogHudiSource. 
        /// <para>
        /// Specifies a Hudi data source that is registered in the Glue Data Catalog. The data
        /// source must be stored in Amazon S3.
        /// </para>
        /// </summary>
        public S3CatalogHudiSource S3CatalogHudiSource { get; set; }

        /// <summary>
        /// Checks to see if the S3CatalogHudiSource property is set.
        /// </summary>
        internal bool IsSetS3CatalogHudiSource() => this.S3CatalogHudiSource != null;

        /// <summary>
        /// Gets and sets the property S3CatalogIcebergSource. 
        /// <para>
        /// Specifies an Apache Iceberg data source that is registered in the Glue Data Catalog.
        /// The Iceberg data source must be stored in Amazon S3.
        /// </para>
        /// </summary>
        public S3CatalogIcebergSource S3CatalogIcebergSource { get; set; }

        /// <summary>
        /// Checks to see if the S3CatalogIcebergSource property is set.
        /// </summary>
        internal bool IsSetS3CatalogIcebergSource() => this.S3CatalogIcebergSource != null;

        /// <summary>
        /// Gets and sets the property S3CatalogSource. 
        /// <para>
        /// Specifies an Amazon S3 data store in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public S3CatalogSource S3CatalogSource { get; set; }

        /// <summary>
        /// Checks to see if the S3CatalogSource property is set.
        /// </summary>
        internal bool IsSetS3CatalogSource() => this.S3CatalogSource != null;

        /// <summary>
        /// Gets and sets the property S3CatalogTarget. 
        /// <para>
        /// Specifies a data target that writes to Amazon S3 using the Glue Data Catalog.
        /// </para>
        /// </summary>
        public S3CatalogTarget S3CatalogTarget { get; set; }

        /// <summary>
        /// Checks to see if the S3CatalogTarget property is set.
        /// </summary>
        internal bool IsSetS3CatalogTarget() => this.S3CatalogTarget != null;

        /// <summary>
        /// Gets and sets the property S3CsvSource. 
        /// <para>
        /// Specifies a command-separated value (CSV) data store stored in Amazon S3.
        /// </para>
        /// </summary>
        public S3CsvSource S3CsvSource { get; set; }

        /// <summary>
        /// Checks to see if the S3CsvSource property is set.
        /// </summary>
        internal bool IsSetS3CsvSource() => this.S3CsvSource != null;

        /// <summary>
        /// Gets and sets the property S3DeltaCatalogTarget. 
        /// <para>
        /// Specifies a target that writes to a Delta Lake data source in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public S3DeltaCatalogTarget S3DeltaCatalogTarget { get; set; }

        /// <summary>
        /// Checks to see if the S3DeltaCatalogTarget property is set.
        /// </summary>
        internal bool IsSetS3DeltaCatalogTarget() => this.S3DeltaCatalogTarget != null;

        /// <summary>
        /// Gets and sets the property S3DeltaDirectTarget. 
        /// <para>
        /// Specifies a target that writes to a Delta Lake data source in Amazon S3.
        /// </para>
        /// </summary>
        public S3DeltaDirectTarget S3DeltaDirectTarget { get; set; }

        /// <summary>
        /// Checks to see if the S3DeltaDirectTarget property is set.
        /// </summary>
        internal bool IsSetS3DeltaDirectTarget() => this.S3DeltaDirectTarget != null;

        /// <summary>
        /// Gets and sets the property S3DeltaSource. 
        /// <para>
        /// Specifies a Delta Lake data source stored in Amazon S3.
        /// </para>
        /// </summary>
        public S3DeltaSource S3DeltaSource { get; set; }

        /// <summary>
        /// Checks to see if the S3DeltaSource property is set.
        /// </summary>
        internal bool IsSetS3DeltaSource() => this.S3DeltaSource != null;

        /// <summary>
        /// Gets and sets the property S3DirectTarget. 
        /// <para>
        /// Specifies a data target that writes to Amazon S3.
        /// </para>
        /// </summary>
        public S3DirectTarget S3DirectTarget { get; set; }

        /// <summary>
        /// Checks to see if the S3DirectTarget property is set.
        /// </summary>
        internal bool IsSetS3DirectTarget() => this.S3DirectTarget != null;

        /// <summary>
        /// Gets and sets the property S3ExcelSource. 
        /// <para>
        /// Defines configuration parameters for reading Excel files from Amazon S3.
        /// </para>
        /// </summary>
        public S3ExcelSource S3ExcelSource { get; set; }

        /// <summary>
        /// Checks to see if the S3ExcelSource property is set.
        /// </summary>
        internal bool IsSetS3ExcelSource() => this.S3ExcelSource != null;

        /// <summary>
        /// Gets and sets the property S3GlueParquetTarget. 
        /// <para>
        /// Specifies a data target that writes to Amazon S3 in Apache Parquet columnar storage.
        /// </para>
        /// </summary>
        public S3GlueParquetTarget S3GlueParquetTarget { get; set; }

        /// <summary>
        /// Checks to see if the S3GlueParquetTarget property is set.
        /// </summary>
        internal bool IsSetS3GlueParquetTarget() => this.S3GlueParquetTarget != null;

        /// <summary>
        /// Gets and sets the property S3HudiCatalogTarget. 
        /// <para>
        /// Specifies a target that writes to a Hudi data source in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public S3HudiCatalogTarget S3HudiCatalogTarget { get; set; }

        /// <summary>
        /// Checks to see if the S3HudiCatalogTarget property is set.
        /// </summary>
        internal bool IsSetS3HudiCatalogTarget() => this.S3HudiCatalogTarget != null;

        /// <summary>
        /// Gets and sets the property S3HudiDirectTarget. 
        /// <para>
        /// Specifies a target that writes to a Hudi data source in Amazon S3.
        /// </para>
        /// </summary>
        public S3HudiDirectTarget S3HudiDirectTarget { get; set; }

        /// <summary>
        /// Checks to see if the S3HudiDirectTarget property is set.
        /// </summary>
        internal bool IsSetS3HudiDirectTarget() => this.S3HudiDirectTarget != null;

        /// <summary>
        /// Gets and sets the property S3HudiSource. 
        /// <para>
        /// Specifies a Hudi data source stored in Amazon S3.
        /// </para>
        /// </summary>
        public S3HudiSource S3HudiSource { get; set; }

        /// <summary>
        /// Checks to see if the S3HudiSource property is set.
        /// </summary>
        internal bool IsSetS3HudiSource() => this.S3HudiSource != null;

        /// <summary>
        /// Gets and sets the property S3HyperDirectTarget. 
        /// <para>
        /// Defines configuration parameters for writing data to Amazon S3 using HyperDirect optimization.
        /// </para>
        /// </summary>
        public S3HyperDirectTarget S3HyperDirectTarget { get; set; }

        /// <summary>
        /// Checks to see if the S3HyperDirectTarget property is set.
        /// </summary>
        internal bool IsSetS3HyperDirectTarget() => this.S3HyperDirectTarget != null;

        /// <summary>
        /// Gets and sets the property S3IcebergCatalogTarget. 
        /// <para>
        /// Specifies an Apache Iceberg catalog target that writes data to Amazon S3 and registers
        /// the table in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public S3IcebergCatalogTarget S3IcebergCatalogTarget { get; set; }

        /// <summary>
        /// Checks to see if the S3IcebergCatalogTarget property is set.
        /// </summary>
        internal bool IsSetS3IcebergCatalogTarget() => this.S3IcebergCatalogTarget != null;

        /// <summary>
        /// Gets and sets the property S3IcebergDirectTarget. 
        /// <para>
        /// Defines configuration parameters for writing data to Amazon S3 as an Apache Iceberg
        /// table.
        /// </para>
        /// </summary>
        public S3IcebergDirectTarget S3IcebergDirectTarget { get; set; }

        /// <summary>
        /// Checks to see if the S3IcebergDirectTarget property is set.
        /// </summary>
        internal bool IsSetS3IcebergDirectTarget() => this.S3IcebergDirectTarget != null;

        /// <summary>
        /// Gets and sets the property S3JsonSource. 
        /// <para>
        /// Specifies a JSON data store stored in Amazon S3.
        /// </para>
        /// </summary>
        public S3JsonSource S3JsonSource { get; set; }

        /// <summary>
        /// Checks to see if the S3JsonSource property is set.
        /// </summary>
        internal bool IsSetS3JsonSource() => this.S3JsonSource != null;

        /// <summary>
        /// Gets and sets the property S3ParquetSource. 
        /// <para>
        /// Specifies an Apache Parquet data store stored in Amazon S3.
        /// </para>
        /// </summary>
        public S3ParquetSource S3ParquetSource { get; set; }

        /// <summary>
        /// Checks to see if the S3ParquetSource property is set.
        /// </summary>
        internal bool IsSetS3ParquetSource() => this.S3ParquetSource != null;

        /// <summary>
        /// Gets and sets the property SelectFields. 
        /// <para>
        /// Specifies a transform that chooses the data property keys that you want to keep.
        /// </para>
        /// </summary>
        public SelectFields SelectFields { get; set; }

        /// <summary>
        /// Checks to see if the SelectFields property is set.
        /// </summary>
        internal bool IsSetSelectFields() => this.SelectFields != null;

        /// <summary>
        /// Gets and sets the property SelectFromCollection. 
        /// <para>
        /// Specifies a transform that chooses one <c>DynamicFrame</c> from a collection of <c>DynamicFrames</c>.
        /// The output is the selected <c>DynamicFrame</c> 
        /// </para>
        /// </summary>
        public SelectFromCollection SelectFromCollection { get; set; }

        /// <summary>
        /// Checks to see if the SelectFromCollection property is set.
        /// </summary>
        internal bool IsSetSelectFromCollection() => this.SelectFromCollection != null;

        /// <summary>
        /// Gets and sets the property SnowflakeSource. 
        /// <para>
        /// Specifies a Snowflake data source.
        /// </para>
        /// </summary>
        public SnowflakeSource SnowflakeSource { get; set; }

        /// <summary>
        /// Checks to see if the SnowflakeSource property is set.
        /// </summary>
        internal bool IsSetSnowflakeSource() => this.SnowflakeSource != null;

        /// <summary>
        /// Gets and sets the property SnowflakeTarget. 
        /// <para>
        /// Specifies a target that writes to a Snowflake data source.
        /// </para>
        /// </summary>
        public SnowflakeTarget SnowflakeTarget { get; set; }

        /// <summary>
        /// Checks to see if the SnowflakeTarget property is set.
        /// </summary>
        internal bool IsSetSnowflakeTarget() => this.SnowflakeTarget != null;

        /// <summary>
        /// Gets and sets the property SparkConnectorSource. 
        /// <para>
        /// Specifies a connector to an Apache Spark data source.
        /// </para>
        /// </summary>
        public SparkConnectorSource SparkConnectorSource { get; set; }

        /// <summary>
        /// Checks to see if the SparkConnectorSource property is set.
        /// </summary>
        internal bool IsSetSparkConnectorSource() => this.SparkConnectorSource != null;

        /// <summary>
        /// Gets and sets the property SparkConnectorTarget. 
        /// <para>
        /// Specifies a target that uses an Apache Spark connector.
        /// </para>
        /// </summary>
        public SparkConnectorTarget SparkConnectorTarget { get; set; }

        /// <summary>
        /// Checks to see if the SparkConnectorTarget property is set.
        /// </summary>
        internal bool IsSetSparkConnectorTarget() => this.SparkConnectorTarget != null;

        /// <summary>
        /// Gets and sets the property SparkSQL. 
        /// <para>
        /// Specifies a transform where you enter a SQL query using Spark SQL syntax to transform
        /// the data. The output is a single <c>DynamicFrame</c>.
        /// </para>
        /// </summary>
        public SparkSQL SparkSQL { get; set; }

        /// <summary>
        /// Checks to see if the SparkSQL property is set.
        /// </summary>
        internal bool IsSetSparkSQL() => this.SparkSQL != null;

        /// <summary>
        /// Gets and sets the property Spigot. 
        /// <para>
        /// Specifies a transform that writes samples of the data to an Amazon S3 bucket.
        /// </para>
        /// </summary>
        public Spigot Spigot { get; set; }

        /// <summary>
        /// Checks to see if the Spigot property is set.
        /// </summary>
        internal bool IsSetSpigot() => this.Spigot != null;

        /// <summary>
        /// Gets and sets the property SplitFields. 
        /// <para>
        /// Specifies a transform that splits data property keys into two <c>DynamicFrames</c>.
        /// The output is a collection of <c>DynamicFrames</c>: one with selected data property
        /// keys, and one with the remaining data property keys.
        /// </para>
        /// </summary>
        public SplitFields SplitFields { get; set; }

        /// <summary>
        /// Checks to see if the SplitFields property is set.
        /// </summary>
        internal bool IsSetSplitFields() => this.SplitFields != null;

        /// <summary>
        /// Gets and sets the property Union. 
        /// <para>
        /// Specifies a transform that combines the rows from two or more datasets into a single
        /// result.
        /// </para>
        /// </summary>
        public Union Union { get; set; }

        /// <summary>
        /// Checks to see if the Union property is set.
        /// </summary>
        internal bool IsSetUnion() => this.Union != null;
    }
}

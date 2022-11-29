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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// <code>CodeGenConfigurationNode</code> enumerates all valid Node types. One and only
    /// one of its member variables can be populated.
    /// </summary>
    public partial class CodeGenConfigurationNode
    {
        private Aggregate _aggregate;
        private ApplyMapping _applyMapping;
        private AthenaConnectorSource _athenaConnectorSource;
        private CatalogKafkaSource _catalogKafkaSource;
        private CatalogKinesisSource _catalogKinesisSource;
        private CatalogSource _catalogSource;
        private BasicCatalogTarget _catalogTarget;
        private CustomCode _customCode;
        private DirectKafkaSource _directKafkaSource;
        private DirectKinesisSource _directKinesisSource;
        private DropDuplicates _dropDuplicates;
        private DropFields _dropFields;
        private DropNullFields _dropNullFields;
        private DynamicTransform _dynamicTransform;
        private DynamoDBCatalogSource _dynamoDBCatalogSource;
        private FillMissingValues _fillMissingValues;
        private Filter _filter;
        private GovernedCatalogSource _governedCatalogSource;
        private GovernedCatalogTarget _governedCatalogTarget;
        private JDBCConnectorSource _jdbcConnectorSource;
        private JDBCConnectorTarget _jdbcConnectorTarget;
        private Join _join;
        private Merge _merge;
        private MicrosoftSQLServerCatalogSource _microsoftSQLServerCatalogSource;
        private MicrosoftSQLServerCatalogTarget _microsoftSQLServerCatalogTarget;
        private MySQLCatalogSource _mySQLCatalogSource;
        private MySQLCatalogTarget _mySQLCatalogTarget;
        private OracleSQLCatalogSource _oracleSQLCatalogSource;
        private OracleSQLCatalogTarget _oracleSQLCatalogTarget;
        private PIIDetection _piiDetection;
        private PostgreSQLCatalogSource _postgreSQLCatalogSource;
        private PostgreSQLCatalogTarget _postgreSQLCatalogTarget;
        private RedshiftSource _redshiftSource;
        private RedshiftTarget _redshiftTarget;
        private RelationalCatalogSource _relationalCatalogSource;
        private RenameField _renameField;
        private S3CatalogSource _s3CatalogSource;
        private S3CatalogTarget _s3CatalogTarget;
        private S3CsvSource _s3CsvSource;
        private S3DirectTarget _s3DirectTarget;
        private S3GlueParquetTarget _s3GlueParquetTarget;
        private S3JsonSource _s3JsonSource;
        private S3ParquetSource _s3ParquetSource;
        private SelectFields _selectFields;
        private SelectFromCollection _selectFromCollection;
        private SparkConnectorSource _sparkConnectorSource;
        private SparkConnectorTarget _sparkConnectorTarget;
        private SparkSQL _sparkSQL;
        private Spigot _spigot;
        private SplitFields _splitFields;
        private Union _union;

        /// <summary>
        /// Gets and sets the property Aggregate. 
        /// <para>
        /// Specifies a transform that groups rows by chosen fields and computes the aggregated
        /// value by specified function.
        /// </para>
        /// </summary>
        public Aggregate Aggregate
        {
            get { return this._aggregate; }
            set { this._aggregate = value; }
        }

        // Check to see if Aggregate property is set
        internal bool IsSetAggregate()
        {
            return this._aggregate != null;
        }

        /// <summary>
        /// Gets and sets the property ApplyMapping. 
        /// <para>
        /// Specifies a transform that maps data property keys in the data source to data property
        /// keys in the data target. You can rename keys, modify the data types for keys, and
        /// choose which keys to drop from the dataset.
        /// </para>
        /// </summary>
        public ApplyMapping ApplyMapping
        {
            get { return this._applyMapping; }
            set { this._applyMapping = value; }
        }

        // Check to see if ApplyMapping property is set
        internal bool IsSetApplyMapping()
        {
            return this._applyMapping != null;
        }

        /// <summary>
        /// Gets and sets the property AthenaConnectorSource. 
        /// <para>
        /// Specifies a connector to an Amazon Athena data source.
        /// </para>
        /// </summary>
        public AthenaConnectorSource AthenaConnectorSource
        {
            get { return this._athenaConnectorSource; }
            set { this._athenaConnectorSource = value; }
        }

        // Check to see if AthenaConnectorSource property is set
        internal bool IsSetAthenaConnectorSource()
        {
            return this._athenaConnectorSource != null;
        }

        /// <summary>
        /// Gets and sets the property CatalogKafkaSource. 
        /// <para>
        /// Specifies an Apache Kafka data store in the Data Catalog.
        /// </para>
        /// </summary>
        public CatalogKafkaSource CatalogKafkaSource
        {
            get { return this._catalogKafkaSource; }
            set { this._catalogKafkaSource = value; }
        }

        // Check to see if CatalogKafkaSource property is set
        internal bool IsSetCatalogKafkaSource()
        {
            return this._catalogKafkaSource != null;
        }

        /// <summary>
        /// Gets and sets the property CatalogKinesisSource. 
        /// <para>
        /// Specifies a Kinesis data source in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public CatalogKinesisSource CatalogKinesisSource
        {
            get { return this._catalogKinesisSource; }
            set { this._catalogKinesisSource = value; }
        }

        // Check to see if CatalogKinesisSource property is set
        internal bool IsSetCatalogKinesisSource()
        {
            return this._catalogKinesisSource != null;
        }

        /// <summary>
        /// Gets and sets the property CatalogSource. 
        /// <para>
        /// Specifies a data store in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public CatalogSource CatalogSource
        {
            get { return this._catalogSource; }
            set { this._catalogSource = value; }
        }

        // Check to see if CatalogSource property is set
        internal bool IsSetCatalogSource()
        {
            return this._catalogSource != null;
        }

        /// <summary>
        /// Gets and sets the property CatalogTarget. 
        /// <para>
        /// Specifies a target that uses a Glue Data Catalog table.
        /// </para>
        /// </summary>
        public BasicCatalogTarget CatalogTarget
        {
            get { return this._catalogTarget; }
            set { this._catalogTarget = value; }
        }

        // Check to see if CatalogTarget property is set
        internal bool IsSetCatalogTarget()
        {
            return this._catalogTarget != null;
        }

        /// <summary>
        /// Gets and sets the property CustomCode. 
        /// <para>
        /// Specifies a transform that uses custom code you provide to perform the data transformation.
        /// The output is a collection of DynamicFrames.
        /// </para>
        /// </summary>
        public CustomCode CustomCode
        {
            get { return this._customCode; }
            set { this._customCode = value; }
        }

        // Check to see if CustomCode property is set
        internal bool IsSetCustomCode()
        {
            return this._customCode != null;
        }

        /// <summary>
        /// Gets and sets the property DirectKafkaSource. 
        /// <para>
        /// Specifies an Apache Kafka data store.
        /// </para>
        /// </summary>
        public DirectKafkaSource DirectKafkaSource
        {
            get { return this._directKafkaSource; }
            set { this._directKafkaSource = value; }
        }

        // Check to see if DirectKafkaSource property is set
        internal bool IsSetDirectKafkaSource()
        {
            return this._directKafkaSource != null;
        }

        /// <summary>
        /// Gets and sets the property DirectKinesisSource. 
        /// <para>
        /// Specifies a direct Amazon Kinesis data source.
        /// </para>
        /// </summary>
        public DirectKinesisSource DirectKinesisSource
        {
            get { return this._directKinesisSource; }
            set { this._directKinesisSource = value; }
        }

        // Check to see if DirectKinesisSource property is set
        internal bool IsSetDirectKinesisSource()
        {
            return this._directKinesisSource != null;
        }

        /// <summary>
        /// Gets and sets the property DropDuplicates. 
        /// <para>
        /// Specifies a transform that removes rows of repeating data from a data set.
        /// </para>
        /// </summary>
        public DropDuplicates DropDuplicates
        {
            get { return this._dropDuplicates; }
            set { this._dropDuplicates = value; }
        }

        // Check to see if DropDuplicates property is set
        internal bool IsSetDropDuplicates()
        {
            return this._dropDuplicates != null;
        }

        /// <summary>
        /// Gets and sets the property DropFields. 
        /// <para>
        /// Specifies a transform that chooses the data property keys that you want to drop.
        /// </para>
        /// </summary>
        public DropFields DropFields
        {
            get { return this._dropFields; }
            set { this._dropFields = value; }
        }

        // Check to see if DropFields property is set
        internal bool IsSetDropFields()
        {
            return this._dropFields != null;
        }

        /// <summary>
        /// Gets and sets the property DropNullFields. 
        /// <para>
        /// Specifies a transform that removes columns from the dataset if all values in the column
        /// are 'null'. By default, Glue Studio will recognize null objects, but some values such
        /// as empty strings, strings that are "null", -1 integers or other placeholders such
        /// as zeros, are not automatically recognized as nulls.
        /// </para>
        /// </summary>
        public DropNullFields DropNullFields
        {
            get { return this._dropNullFields; }
            set { this._dropNullFields = value; }
        }

        // Check to see if DropNullFields property is set
        internal bool IsSetDropNullFields()
        {
            return this._dropNullFields != null;
        }

        /// <summary>
        /// Gets and sets the property DynamicTransform. 
        /// <para>
        /// Specifies a custom visual transform created by a user.
        /// </para>
        /// </summary>
        public DynamicTransform DynamicTransform
        {
            get { return this._dynamicTransform; }
            set { this._dynamicTransform = value; }
        }

        // Check to see if DynamicTransform property is set
        internal bool IsSetDynamicTransform()
        {
            return this._dynamicTransform != null;
        }

        /// <summary>
        /// Gets and sets the property DynamoDBCatalogSource.
        /// </summary>
        public DynamoDBCatalogSource DynamoDBCatalogSource
        {
            get { return this._dynamoDBCatalogSource; }
            set { this._dynamoDBCatalogSource = value; }
        }

        // Check to see if DynamoDBCatalogSource property is set
        internal bool IsSetDynamoDBCatalogSource()
        {
            return this._dynamoDBCatalogSource != null;
        }

        /// <summary>
        /// Gets and sets the property FillMissingValues. 
        /// <para>
        /// Specifies a transform that locates records in the dataset that have missing values
        /// and adds a new field with a value determined by imputation. The input data set is
        /// used to train the machine learning model that determines what the missing value should
        /// be.
        /// </para>
        /// </summary>
        public FillMissingValues FillMissingValues
        {
            get { return this._fillMissingValues; }
            set { this._fillMissingValues = value; }
        }

        // Check to see if FillMissingValues property is set
        internal bool IsSetFillMissingValues()
        {
            return this._fillMissingValues != null;
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Specifies a transform that splits a dataset into two, based on a filter condition.
        /// </para>
        /// </summary>
        public Filter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property GovernedCatalogSource. 
        /// <para>
        /// Specifies a data source in a goverened Data Catalog.
        /// </para>
        /// </summary>
        public GovernedCatalogSource GovernedCatalogSource
        {
            get { return this._governedCatalogSource; }
            set { this._governedCatalogSource = value; }
        }

        // Check to see if GovernedCatalogSource property is set
        internal bool IsSetGovernedCatalogSource()
        {
            return this._governedCatalogSource != null;
        }

        /// <summary>
        /// Gets and sets the property GovernedCatalogTarget. 
        /// <para>
        /// Specifies a data target that writes to a goverened catalog.
        /// </para>
        /// </summary>
        public GovernedCatalogTarget GovernedCatalogTarget
        {
            get { return this._governedCatalogTarget; }
            set { this._governedCatalogTarget = value; }
        }

        // Check to see if GovernedCatalogTarget property is set
        internal bool IsSetGovernedCatalogTarget()
        {
            return this._governedCatalogTarget != null;
        }

        /// <summary>
        /// Gets and sets the property JDBCConnectorSource. 
        /// <para>
        /// Specifies a connector to a JDBC data source.
        /// </para>
        /// </summary>
        public JDBCConnectorSource JDBCConnectorSource
        {
            get { return this._jdbcConnectorSource; }
            set { this._jdbcConnectorSource = value; }
        }

        // Check to see if JDBCConnectorSource property is set
        internal bool IsSetJDBCConnectorSource()
        {
            return this._jdbcConnectorSource != null;
        }

        /// <summary>
        /// Gets and sets the property JDBCConnectorTarget. 
        /// <para>
        /// Specifies a data target that writes to Amazon S3 in Apache Parquet columnar storage.
        /// </para>
        /// </summary>
        public JDBCConnectorTarget JDBCConnectorTarget
        {
            get { return this._jdbcConnectorTarget; }
            set { this._jdbcConnectorTarget = value; }
        }

        // Check to see if JDBCConnectorTarget property is set
        internal bool IsSetJDBCConnectorTarget()
        {
            return this._jdbcConnectorTarget != null;
        }

        /// <summary>
        /// Gets and sets the property Join. 
        /// <para>
        /// Specifies a transform that joins two datasets into one dataset using a comparison
        /// phrase on the specified data property keys. You can use inner, outer, left, right,
        /// left semi, and left anti joins.
        /// </para>
        /// </summary>
        public Join Join
        {
            get { return this._join; }
            set { this._join = value; }
        }

        // Check to see if Join property is set
        internal bool IsSetJoin()
        {
            return this._join != null;
        }

        /// <summary>
        /// Gets and sets the property Merge. 
        /// <para>
        /// Specifies a transform that merges a <code>DynamicFrame</code> with a staging <code>DynamicFrame</code>
        /// based on the specified primary keys to identify records. Duplicate records (records
        /// with the same primary keys) are not de-duplicated. 
        /// </para>
        /// </summary>
        public Merge Merge
        {
            get { return this._merge; }
            set { this._merge = value; }
        }

        // Check to see if Merge property is set
        internal bool IsSetMerge()
        {
            return this._merge != null;
        }

        /// <summary>
        /// Gets and sets the property MicrosoftSQLServerCatalogSource. 
        /// <para>
        /// Specifies a Microsoft SQL server data source in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public MicrosoftSQLServerCatalogSource MicrosoftSQLServerCatalogSource
        {
            get { return this._microsoftSQLServerCatalogSource; }
            set { this._microsoftSQLServerCatalogSource = value; }
        }

        // Check to see if MicrosoftSQLServerCatalogSource property is set
        internal bool IsSetMicrosoftSQLServerCatalogSource()
        {
            return this._microsoftSQLServerCatalogSource != null;
        }

        /// <summary>
        /// Gets and sets the property MicrosoftSQLServerCatalogTarget. 
        /// <para>
        /// Specifies a target that uses Microsoft SQL.
        /// </para>
        /// </summary>
        public MicrosoftSQLServerCatalogTarget MicrosoftSQLServerCatalogTarget
        {
            get { return this._microsoftSQLServerCatalogTarget; }
            set { this._microsoftSQLServerCatalogTarget = value; }
        }

        // Check to see if MicrosoftSQLServerCatalogTarget property is set
        internal bool IsSetMicrosoftSQLServerCatalogTarget()
        {
            return this._microsoftSQLServerCatalogTarget != null;
        }

        /// <summary>
        /// Gets and sets the property MySQLCatalogSource. 
        /// <para>
        /// Specifies a MySQL data source in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public MySQLCatalogSource MySQLCatalogSource
        {
            get { return this._mySQLCatalogSource; }
            set { this._mySQLCatalogSource = value; }
        }

        // Check to see if MySQLCatalogSource property is set
        internal bool IsSetMySQLCatalogSource()
        {
            return this._mySQLCatalogSource != null;
        }

        /// <summary>
        /// Gets and sets the property MySQLCatalogTarget. 
        /// <para>
        /// Specifies a target that uses MySQL.
        /// </para>
        /// </summary>
        public MySQLCatalogTarget MySQLCatalogTarget
        {
            get { return this._mySQLCatalogTarget; }
            set { this._mySQLCatalogTarget = value; }
        }

        // Check to see if MySQLCatalogTarget property is set
        internal bool IsSetMySQLCatalogTarget()
        {
            return this._mySQLCatalogTarget != null;
        }

        /// <summary>
        /// Gets and sets the property OracleSQLCatalogSource. 
        /// <para>
        /// Specifies an Oracle data source in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public OracleSQLCatalogSource OracleSQLCatalogSource
        {
            get { return this._oracleSQLCatalogSource; }
            set { this._oracleSQLCatalogSource = value; }
        }

        // Check to see if OracleSQLCatalogSource property is set
        internal bool IsSetOracleSQLCatalogSource()
        {
            return this._oracleSQLCatalogSource != null;
        }

        /// <summary>
        /// Gets and sets the property OracleSQLCatalogTarget. 
        /// <para>
        /// Specifies a target that uses Oracle SQL.
        /// </para>
        /// </summary>
        public OracleSQLCatalogTarget OracleSQLCatalogTarget
        {
            get { return this._oracleSQLCatalogTarget; }
            set { this._oracleSQLCatalogTarget = value; }
        }

        // Check to see if OracleSQLCatalogTarget property is set
        internal bool IsSetOracleSQLCatalogTarget()
        {
            return this._oracleSQLCatalogTarget != null;
        }

        /// <summary>
        /// Gets and sets the property PIIDetection. 
        /// <para>
        /// Specifies a transform that identifies, removes or masks PII data.
        /// </para>
        /// </summary>
        public PIIDetection PIIDetection
        {
            get { return this._piiDetection; }
            set { this._piiDetection = value; }
        }

        // Check to see if PIIDetection property is set
        internal bool IsSetPIIDetection()
        {
            return this._piiDetection != null;
        }

        /// <summary>
        /// Gets and sets the property PostgreSQLCatalogSource. 
        /// <para>
        /// Specifies a PostgresSQL data source in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public PostgreSQLCatalogSource PostgreSQLCatalogSource
        {
            get { return this._postgreSQLCatalogSource; }
            set { this._postgreSQLCatalogSource = value; }
        }

        // Check to see if PostgreSQLCatalogSource property is set
        internal bool IsSetPostgreSQLCatalogSource()
        {
            return this._postgreSQLCatalogSource != null;
        }

        /// <summary>
        /// Gets and sets the property PostgreSQLCatalogTarget. 
        /// <para>
        /// Specifies a target that uses Postgres SQL.
        /// </para>
        /// </summary>
        public PostgreSQLCatalogTarget PostgreSQLCatalogTarget
        {
            get { return this._postgreSQLCatalogTarget; }
            set { this._postgreSQLCatalogTarget = value; }
        }

        // Check to see if PostgreSQLCatalogTarget property is set
        internal bool IsSetPostgreSQLCatalogTarget()
        {
            return this._postgreSQLCatalogTarget != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftSource. 
        /// <para>
        /// Specifies an Amazon Redshift data store.
        /// </para>
        /// </summary>
        public RedshiftSource RedshiftSource
        {
            get { return this._redshiftSource; }
            set { this._redshiftSource = value; }
        }

        // Check to see if RedshiftSource property is set
        internal bool IsSetRedshiftSource()
        {
            return this._redshiftSource != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftTarget. 
        /// <para>
        /// Specifies a target that uses Amazon Redshift.
        /// </para>
        /// </summary>
        public RedshiftTarget RedshiftTarget
        {
            get { return this._redshiftTarget; }
            set { this._redshiftTarget = value; }
        }

        // Check to see if RedshiftTarget property is set
        internal bool IsSetRedshiftTarget()
        {
            return this._redshiftTarget != null;
        }

        /// <summary>
        /// Gets and sets the property RelationalCatalogSource.
        /// </summary>
        public RelationalCatalogSource RelationalCatalogSource
        {
            get { return this._relationalCatalogSource; }
            set { this._relationalCatalogSource = value; }
        }

        // Check to see if RelationalCatalogSource property is set
        internal bool IsSetRelationalCatalogSource()
        {
            return this._relationalCatalogSource != null;
        }

        /// <summary>
        /// Gets and sets the property RenameField. 
        /// <para>
        /// Specifies a transform that renames a single data property key.
        /// </para>
        /// </summary>
        public RenameField RenameField
        {
            get { return this._renameField; }
            set { this._renameField = value; }
        }

        // Check to see if RenameField property is set
        internal bool IsSetRenameField()
        {
            return this._renameField != null;
        }

        /// <summary>
        /// Gets and sets the property S3CatalogSource. 
        /// <para>
        /// Specifies an Amazon S3 data store in the Glue Data Catalog.
        /// </para>
        /// </summary>
        public S3CatalogSource S3CatalogSource
        {
            get { return this._s3CatalogSource; }
            set { this._s3CatalogSource = value; }
        }

        // Check to see if S3CatalogSource property is set
        internal bool IsSetS3CatalogSource()
        {
            return this._s3CatalogSource != null;
        }

        /// <summary>
        /// Gets and sets the property S3CatalogTarget. 
        /// <para>
        /// Specifies a data target that writes to Amazon S3 using the Glue Data Catalog.
        /// </para>
        /// </summary>
        public S3CatalogTarget S3CatalogTarget
        {
            get { return this._s3CatalogTarget; }
            set { this._s3CatalogTarget = value; }
        }

        // Check to see if S3CatalogTarget property is set
        internal bool IsSetS3CatalogTarget()
        {
            return this._s3CatalogTarget != null;
        }

        /// <summary>
        /// Gets and sets the property S3CsvSource. 
        /// <para>
        /// Specifies a command-separated value (CSV) data store stored in Amazon S3.
        /// </para>
        /// </summary>
        public S3CsvSource S3CsvSource
        {
            get { return this._s3CsvSource; }
            set { this._s3CsvSource = value; }
        }

        // Check to see if S3CsvSource property is set
        internal bool IsSetS3CsvSource()
        {
            return this._s3CsvSource != null;
        }

        /// <summary>
        /// Gets and sets the property S3DirectTarget. 
        /// <para>
        /// Specifies a data target that writes to Amazon S3.
        /// </para>
        /// </summary>
        public S3DirectTarget S3DirectTarget
        {
            get { return this._s3DirectTarget; }
            set { this._s3DirectTarget = value; }
        }

        // Check to see if S3DirectTarget property is set
        internal bool IsSetS3DirectTarget()
        {
            return this._s3DirectTarget != null;
        }

        /// <summary>
        /// Gets and sets the property S3GlueParquetTarget. 
        /// <para>
        /// Specifies a data target that writes to Amazon S3 in Apache Parquet columnar storage.
        /// </para>
        /// </summary>
        public S3GlueParquetTarget S3GlueParquetTarget
        {
            get { return this._s3GlueParquetTarget; }
            set { this._s3GlueParquetTarget = value; }
        }

        // Check to see if S3GlueParquetTarget property is set
        internal bool IsSetS3GlueParquetTarget()
        {
            return this._s3GlueParquetTarget != null;
        }

        /// <summary>
        /// Gets and sets the property S3JsonSource. 
        /// <para>
        /// Specifies a JSON data store stored in Amazon S3.
        /// </para>
        /// </summary>
        public S3JsonSource S3JsonSource
        {
            get { return this._s3JsonSource; }
            set { this._s3JsonSource = value; }
        }

        // Check to see if S3JsonSource property is set
        internal bool IsSetS3JsonSource()
        {
            return this._s3JsonSource != null;
        }

        /// <summary>
        /// Gets and sets the property S3ParquetSource. 
        /// <para>
        /// Specifies an Apache Parquet data store stored in Amazon S3.
        /// </para>
        /// </summary>
        public S3ParquetSource S3ParquetSource
        {
            get { return this._s3ParquetSource; }
            set { this._s3ParquetSource = value; }
        }

        // Check to see if S3ParquetSource property is set
        internal bool IsSetS3ParquetSource()
        {
            return this._s3ParquetSource != null;
        }

        /// <summary>
        /// Gets and sets the property SelectFields. 
        /// <para>
        /// Specifies a transform that chooses the data property keys that you want to keep.
        /// </para>
        /// </summary>
        public SelectFields SelectFields
        {
            get { return this._selectFields; }
            set { this._selectFields = value; }
        }

        // Check to see if SelectFields property is set
        internal bool IsSetSelectFields()
        {
            return this._selectFields != null;
        }

        /// <summary>
        /// Gets and sets the property SelectFromCollection. 
        /// <para>
        /// Specifies a transform that chooses one <code>DynamicFrame</code> from a collection
        /// of <code>DynamicFrames</code>. The output is the selected <code>DynamicFrame</code>
        /// 
        /// </para>
        /// </summary>
        public SelectFromCollection SelectFromCollection
        {
            get { return this._selectFromCollection; }
            set { this._selectFromCollection = value; }
        }

        // Check to see if SelectFromCollection property is set
        internal bool IsSetSelectFromCollection()
        {
            return this._selectFromCollection != null;
        }

        /// <summary>
        /// Gets and sets the property SparkConnectorSource. 
        /// <para>
        /// Specifies a connector to an Apache Spark data source.
        /// </para>
        /// </summary>
        public SparkConnectorSource SparkConnectorSource
        {
            get { return this._sparkConnectorSource; }
            set { this._sparkConnectorSource = value; }
        }

        // Check to see if SparkConnectorSource property is set
        internal bool IsSetSparkConnectorSource()
        {
            return this._sparkConnectorSource != null;
        }

        /// <summary>
        /// Gets and sets the property SparkConnectorTarget. 
        /// <para>
        /// Specifies a target that uses an Apache Spark connector.
        /// </para>
        /// </summary>
        public SparkConnectorTarget SparkConnectorTarget
        {
            get { return this._sparkConnectorTarget; }
            set { this._sparkConnectorTarget = value; }
        }

        // Check to see if SparkConnectorTarget property is set
        internal bool IsSetSparkConnectorTarget()
        {
            return this._sparkConnectorTarget != null;
        }

        /// <summary>
        /// Gets and sets the property SparkSQL. 
        /// <para>
        /// Specifies a transform where you enter a SQL query using Spark SQL syntax to transform
        /// the data. The output is a single <code>DynamicFrame</code>.
        /// </para>
        /// </summary>
        public SparkSQL SparkSQL
        {
            get { return this._sparkSQL; }
            set { this._sparkSQL = value; }
        }

        // Check to see if SparkSQL property is set
        internal bool IsSetSparkSQL()
        {
            return this._sparkSQL != null;
        }

        /// <summary>
        /// Gets and sets the property Spigot. 
        /// <para>
        /// Specifies a transform that writes samples of the data to an Amazon S3 bucket.
        /// </para>
        /// </summary>
        public Spigot Spigot
        {
            get { return this._spigot; }
            set { this._spigot = value; }
        }

        // Check to see if Spigot property is set
        internal bool IsSetSpigot()
        {
            return this._spigot != null;
        }

        /// <summary>
        /// Gets and sets the property SplitFields. 
        /// <para>
        /// Specifies a transform that splits data property keys into two <code>DynamicFrames</code>.
        /// The output is a collection of <code>DynamicFrames</code>: one with selected data property
        /// keys, and one with the remaining data property keys.
        /// </para>
        /// </summary>
        public SplitFields SplitFields
        {
            get { return this._splitFields; }
            set { this._splitFields = value; }
        }

        // Check to see if SplitFields property is set
        internal bool IsSetSplitFields()
        {
            return this._splitFields != null;
        }

        /// <summary>
        /// Gets and sets the property Union. 
        /// <para>
        /// Specifies a transform that combines the rows from two or more datasets into a single
        /// result.
        /// </para>
        /// </summary>
        public Union Union
        {
            get { return this._union; }
            set { this._union = value; }
        }

        // Check to see if Union property is set
        internal bool IsSetUnion()
        {
            return this._union != null;
        }

    }
}
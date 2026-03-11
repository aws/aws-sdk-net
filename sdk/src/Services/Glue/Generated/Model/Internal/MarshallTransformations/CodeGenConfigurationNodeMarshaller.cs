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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CodeGenConfigurationNode Marshaller
    /// </summary>
    public class CodeGenConfigurationNodeMarshaller : IRequestMarshaller<CodeGenConfigurationNode, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CodeGenConfigurationNode requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAggregate())
            {
                context.Writer.WritePropertyName("Aggregate");
                context.Writer.WriteStartObject();

                var marshaller = AggregateMarshaller.Instance;
                marshaller.Marshall(requestObject.Aggregate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAmazonRedshiftSource())
            {
                context.Writer.WritePropertyName("AmazonRedshiftSource");
                context.Writer.WriteStartObject();

                var marshaller = AmazonRedshiftSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.AmazonRedshiftSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAmazonRedshiftTarget())
            {
                context.Writer.WritePropertyName("AmazonRedshiftTarget");
                context.Writer.WriteStartObject();

                var marshaller = AmazonRedshiftTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.AmazonRedshiftTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetApplyMapping())
            {
                context.Writer.WritePropertyName("ApplyMapping");
                context.Writer.WriteStartObject();

                var marshaller = ApplyMappingMarshaller.Instance;
                marshaller.Marshall(requestObject.ApplyMapping, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAthenaConnectorSource())
            {
                context.Writer.WritePropertyName("AthenaConnectorSource");
                context.Writer.WriteStartObject();

                var marshaller = AthenaConnectorSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.AthenaConnectorSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCatalogDeltaSource())
            {
                context.Writer.WritePropertyName("CatalogDeltaSource");
                context.Writer.WriteStartObject();

                var marshaller = CatalogDeltaSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.CatalogDeltaSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCatalogHudiSource())
            {
                context.Writer.WritePropertyName("CatalogHudiSource");
                context.Writer.WriteStartObject();

                var marshaller = CatalogHudiSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.CatalogHudiSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCatalogIcebergSource())
            {
                context.Writer.WritePropertyName("CatalogIcebergSource");
                context.Writer.WriteStartObject();

                var marshaller = CatalogIcebergSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.CatalogIcebergSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCatalogKafkaSource())
            {
                context.Writer.WritePropertyName("CatalogKafkaSource");
                context.Writer.WriteStartObject();

                var marshaller = CatalogKafkaSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.CatalogKafkaSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCatalogKinesisSource())
            {
                context.Writer.WritePropertyName("CatalogKinesisSource");
                context.Writer.WriteStartObject();

                var marshaller = CatalogKinesisSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.CatalogKinesisSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCatalogSource())
            {
                context.Writer.WritePropertyName("CatalogSource");
                context.Writer.WriteStartObject();

                var marshaller = CatalogSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.CatalogSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCatalogTarget())
            {
                context.Writer.WritePropertyName("CatalogTarget");
                context.Writer.WriteStartObject();

                var marshaller = BasicCatalogTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.CatalogTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetConnectorDataSource())
            {
                context.Writer.WritePropertyName("ConnectorDataSource");
                context.Writer.WriteStartObject();

                var marshaller = ConnectorDataSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.ConnectorDataSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetConnectorDataTarget())
            {
                context.Writer.WritePropertyName("ConnectorDataTarget");
                context.Writer.WriteStartObject();

                var marshaller = ConnectorDataTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.ConnectorDataTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCustomCode())
            {
                context.Writer.WritePropertyName("CustomCode");
                context.Writer.WriteStartObject();

                var marshaller = CustomCodeMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomCode, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDirectJDBCSource())
            {
                context.Writer.WritePropertyName("DirectJDBCSource");
                context.Writer.WriteStartObject();

                var marshaller = DirectJDBCSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.DirectJDBCSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDirectKafkaSource())
            {
                context.Writer.WritePropertyName("DirectKafkaSource");
                context.Writer.WriteStartObject();

                var marshaller = DirectKafkaSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.DirectKafkaSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDirectKinesisSource())
            {
                context.Writer.WritePropertyName("DirectKinesisSource");
                context.Writer.WriteStartObject();

                var marshaller = DirectKinesisSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.DirectKinesisSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDropDuplicates())
            {
                context.Writer.WritePropertyName("DropDuplicates");
                context.Writer.WriteStartObject();

                var marshaller = DropDuplicatesMarshaller.Instance;
                marshaller.Marshall(requestObject.DropDuplicates, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDropFields())
            {
                context.Writer.WritePropertyName("DropFields");
                context.Writer.WriteStartObject();

                var marshaller = DropFieldsMarshaller.Instance;
                marshaller.Marshall(requestObject.DropFields, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDropNullFields())
            {
                context.Writer.WritePropertyName("DropNullFields");
                context.Writer.WriteStartObject();

                var marshaller = DropNullFieldsMarshaller.Instance;
                marshaller.Marshall(requestObject.DropNullFields, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDynamicTransform())
            {
                context.Writer.WritePropertyName("DynamicTransform");
                context.Writer.WriteStartObject();

                var marshaller = DynamicTransformMarshaller.Instance;
                marshaller.Marshall(requestObject.DynamicTransform, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDynamoDBCatalogSource())
            {
                context.Writer.WritePropertyName("DynamoDBCatalogSource");
                context.Writer.WriteStartObject();

                var marshaller = DynamoDBCatalogSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.DynamoDBCatalogSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDynamoDBELTConnectorSource())
            {
                context.Writer.WritePropertyName("DynamoDBELTConnectorSource");
                context.Writer.WriteStartObject();

                var marshaller = DynamoDBELTConnectorSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.DynamoDBELTConnectorSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEvaluateDataQuality())
            {
                context.Writer.WritePropertyName("EvaluateDataQuality");
                context.Writer.WriteStartObject();

                var marshaller = EvaluateDataQualityMarshaller.Instance;
                marshaller.Marshall(requestObject.EvaluateDataQuality, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEvaluateDataQualityMultiFrame())
            {
                context.Writer.WritePropertyName("EvaluateDataQualityMultiFrame");
                context.Writer.WriteStartObject();

                var marshaller = EvaluateDataQualityMultiFrameMarshaller.Instance;
                marshaller.Marshall(requestObject.EvaluateDataQualityMultiFrame, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFillMissingValues())
            {
                context.Writer.WritePropertyName("FillMissingValues");
                context.Writer.WriteStartObject();

                var marshaller = FillMissingValuesMarshaller.Instance;
                marshaller.Marshall(requestObject.FillMissingValues, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFilter())
            {
                context.Writer.WritePropertyName("Filter");
                context.Writer.WriteStartObject();

                var marshaller = FilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Filter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGovernedCatalogSource())
            {
                context.Writer.WritePropertyName("GovernedCatalogSource");
                context.Writer.WriteStartObject();

                var marshaller = GovernedCatalogSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.GovernedCatalogSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGovernedCatalogTarget())
            {
                context.Writer.WritePropertyName("GovernedCatalogTarget");
                context.Writer.WriteStartObject();

                var marshaller = GovernedCatalogTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.GovernedCatalogTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetJDBCConnectorSource())
            {
                context.Writer.WritePropertyName("JDBCConnectorSource");
                context.Writer.WriteStartObject();

                var marshaller = JDBCConnectorSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.JDBCConnectorSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetJDBCConnectorTarget())
            {
                context.Writer.WritePropertyName("JDBCConnectorTarget");
                context.Writer.WriteStartObject();

                var marshaller = JDBCConnectorTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.JDBCConnectorTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetJoin())
            {
                context.Writer.WritePropertyName("Join");
                context.Writer.WriteStartObject();

                var marshaller = JoinMarshaller.Instance;
                marshaller.Marshall(requestObject.Join, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMerge())
            {
                context.Writer.WritePropertyName("Merge");
                context.Writer.WriteStartObject();

                var marshaller = MergeMarshaller.Instance;
                marshaller.Marshall(requestObject.Merge, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMicrosoftSQLServerCatalogSource())
            {
                context.Writer.WritePropertyName("MicrosoftSQLServerCatalogSource");
                context.Writer.WriteStartObject();

                var marshaller = MicrosoftSQLServerCatalogSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.MicrosoftSQLServerCatalogSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMicrosoftSQLServerCatalogTarget())
            {
                context.Writer.WritePropertyName("MicrosoftSQLServerCatalogTarget");
                context.Writer.WriteStartObject();

                var marshaller = MicrosoftSQLServerCatalogTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.MicrosoftSQLServerCatalogTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMySQLCatalogSource())
            {
                context.Writer.WritePropertyName("MySQLCatalogSource");
                context.Writer.WriteStartObject();

                var marshaller = MySQLCatalogSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.MySQLCatalogSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMySQLCatalogTarget())
            {
                context.Writer.WritePropertyName("MySQLCatalogTarget");
                context.Writer.WriteStartObject();

                var marshaller = MySQLCatalogTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.MySQLCatalogTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOracleSQLCatalogSource())
            {
                context.Writer.WritePropertyName("OracleSQLCatalogSource");
                context.Writer.WriteStartObject();

                var marshaller = OracleSQLCatalogSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.OracleSQLCatalogSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOracleSQLCatalogTarget())
            {
                context.Writer.WritePropertyName("OracleSQLCatalogTarget");
                context.Writer.WriteStartObject();

                var marshaller = OracleSQLCatalogTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.OracleSQLCatalogTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPIIDetection())
            {
                context.Writer.WritePropertyName("PIIDetection");
                context.Writer.WriteStartObject();

                var marshaller = PIIDetectionMarshaller.Instance;
                marshaller.Marshall(requestObject.PIIDetection, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPostgreSQLCatalogSource())
            {
                context.Writer.WritePropertyName("PostgreSQLCatalogSource");
                context.Writer.WriteStartObject();

                var marshaller = PostgreSQLCatalogSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.PostgreSQLCatalogSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPostgreSQLCatalogTarget())
            {
                context.Writer.WritePropertyName("PostgreSQLCatalogTarget");
                context.Writer.WriteStartObject();

                var marshaller = PostgreSQLCatalogTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.PostgreSQLCatalogTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRecipe())
            {
                context.Writer.WritePropertyName("Recipe");
                context.Writer.WriteStartObject();

                var marshaller = RecipeMarshaller.Instance;
                marshaller.Marshall(requestObject.Recipe, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRedshiftSource())
            {
                context.Writer.WritePropertyName("RedshiftSource");
                context.Writer.WriteStartObject();

                var marshaller = RedshiftSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.RedshiftSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRedshiftTarget())
            {
                context.Writer.WritePropertyName("RedshiftTarget");
                context.Writer.WriteStartObject();

                var marshaller = RedshiftTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.RedshiftTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRelationalCatalogSource())
            {
                context.Writer.WritePropertyName("RelationalCatalogSource");
                context.Writer.WriteStartObject();

                var marshaller = RelationalCatalogSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.RelationalCatalogSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRenameField())
            {
                context.Writer.WritePropertyName("RenameField");
                context.Writer.WriteStartObject();

                var marshaller = RenameFieldMarshaller.Instance;
                marshaller.Marshall(requestObject.RenameField, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRoute())
            {
                context.Writer.WritePropertyName("Route");
                context.Writer.WriteStartObject();

                var marshaller = RouteMarshaller.Instance;
                marshaller.Marshall(requestObject.Route, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3CatalogDeltaSource())
            {
                context.Writer.WritePropertyName("S3CatalogDeltaSource");
                context.Writer.WriteStartObject();

                var marshaller = S3CatalogDeltaSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.S3CatalogDeltaSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3CatalogHudiSource())
            {
                context.Writer.WritePropertyName("S3CatalogHudiSource");
                context.Writer.WriteStartObject();

                var marshaller = S3CatalogHudiSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.S3CatalogHudiSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3CatalogIcebergSource())
            {
                context.Writer.WritePropertyName("S3CatalogIcebergSource");
                context.Writer.WriteStartObject();

                var marshaller = S3CatalogIcebergSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.S3CatalogIcebergSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3CatalogSource())
            {
                context.Writer.WritePropertyName("S3CatalogSource");
                context.Writer.WriteStartObject();

                var marshaller = S3CatalogSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.S3CatalogSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3CatalogTarget())
            {
                context.Writer.WritePropertyName("S3CatalogTarget");
                context.Writer.WriteStartObject();

                var marshaller = S3CatalogTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.S3CatalogTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3CsvSource())
            {
                context.Writer.WritePropertyName("S3CsvSource");
                context.Writer.WriteStartObject();

                var marshaller = S3CsvSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.S3CsvSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3DeltaCatalogTarget())
            {
                context.Writer.WritePropertyName("S3DeltaCatalogTarget");
                context.Writer.WriteStartObject();

                var marshaller = S3DeltaCatalogTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.S3DeltaCatalogTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3DeltaDirectTarget())
            {
                context.Writer.WritePropertyName("S3DeltaDirectTarget");
                context.Writer.WriteStartObject();

                var marshaller = S3DeltaDirectTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.S3DeltaDirectTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3DeltaSource())
            {
                context.Writer.WritePropertyName("S3DeltaSource");
                context.Writer.WriteStartObject();

                var marshaller = S3DeltaSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.S3DeltaSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3DirectTarget())
            {
                context.Writer.WritePropertyName("S3DirectTarget");
                context.Writer.WriteStartObject();

                var marshaller = S3DirectTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.S3DirectTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3ExcelSource())
            {
                context.Writer.WritePropertyName("S3ExcelSource");
                context.Writer.WriteStartObject();

                var marshaller = S3ExcelSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.S3ExcelSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3GlueParquetTarget())
            {
                context.Writer.WritePropertyName("S3GlueParquetTarget");
                context.Writer.WriteStartObject();

                var marshaller = S3GlueParquetTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.S3GlueParquetTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3HudiCatalogTarget())
            {
                context.Writer.WritePropertyName("S3HudiCatalogTarget");
                context.Writer.WriteStartObject();

                var marshaller = S3HudiCatalogTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.S3HudiCatalogTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3HudiDirectTarget())
            {
                context.Writer.WritePropertyName("S3HudiDirectTarget");
                context.Writer.WriteStartObject();

                var marshaller = S3HudiDirectTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.S3HudiDirectTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3HudiSource())
            {
                context.Writer.WritePropertyName("S3HudiSource");
                context.Writer.WriteStartObject();

                var marshaller = S3HudiSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.S3HudiSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3HyperDirectTarget())
            {
                context.Writer.WritePropertyName("S3HyperDirectTarget");
                context.Writer.WriteStartObject();

                var marshaller = S3HyperDirectTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.S3HyperDirectTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3IcebergCatalogTarget())
            {
                context.Writer.WritePropertyName("S3IcebergCatalogTarget");
                context.Writer.WriteStartObject();

                var marshaller = S3IcebergCatalogTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.S3IcebergCatalogTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3IcebergDirectTarget())
            {
                context.Writer.WritePropertyName("S3IcebergDirectTarget");
                context.Writer.WriteStartObject();

                var marshaller = S3IcebergDirectTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.S3IcebergDirectTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3JsonSource())
            {
                context.Writer.WritePropertyName("S3JsonSource");
                context.Writer.WriteStartObject();

                var marshaller = S3JsonSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.S3JsonSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3ParquetSource())
            {
                context.Writer.WritePropertyName("S3ParquetSource");
                context.Writer.WriteStartObject();

                var marshaller = S3ParquetSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.S3ParquetSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSelectFields())
            {
                context.Writer.WritePropertyName("SelectFields");
                context.Writer.WriteStartObject();

                var marshaller = SelectFieldsMarshaller.Instance;
                marshaller.Marshall(requestObject.SelectFields, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSelectFromCollection())
            {
                context.Writer.WritePropertyName("SelectFromCollection");
                context.Writer.WriteStartObject();

                var marshaller = SelectFromCollectionMarshaller.Instance;
                marshaller.Marshall(requestObject.SelectFromCollection, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSnowflakeSource())
            {
                context.Writer.WritePropertyName("SnowflakeSource");
                context.Writer.WriteStartObject();

                var marshaller = SnowflakeSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.SnowflakeSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSnowflakeTarget())
            {
                context.Writer.WritePropertyName("SnowflakeTarget");
                context.Writer.WriteStartObject();

                var marshaller = SnowflakeTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.SnowflakeTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSparkConnectorSource())
            {
                context.Writer.WritePropertyName("SparkConnectorSource");
                context.Writer.WriteStartObject();

                var marshaller = SparkConnectorSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.SparkConnectorSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSparkConnectorTarget())
            {
                context.Writer.WritePropertyName("SparkConnectorTarget");
                context.Writer.WriteStartObject();

                var marshaller = SparkConnectorTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.SparkConnectorTarget, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSparkSQL())
            {
                context.Writer.WritePropertyName("SparkSQL");
                context.Writer.WriteStartObject();

                var marshaller = SparkSQLMarshaller.Instance;
                marshaller.Marshall(requestObject.SparkSQL, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSpigot())
            {
                context.Writer.WritePropertyName("Spigot");
                context.Writer.WriteStartObject();

                var marshaller = SpigotMarshaller.Instance;
                marshaller.Marshall(requestObject.Spigot, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSplitFields())
            {
                context.Writer.WritePropertyName("SplitFields");
                context.Writer.WriteStartObject();

                var marshaller = SplitFieldsMarshaller.Instance;
                marshaller.Marshall(requestObject.SplitFields, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUnion())
            {
                context.Writer.WritePropertyName("Union");
                context.Writer.WriteStartObject();

                var marshaller = UnionMarshaller.Instance;
                marshaller.Marshall(requestObject.Union, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CodeGenConfigurationNodeMarshaller Instance = new CodeGenConfigurationNodeMarshaller();

    }
}
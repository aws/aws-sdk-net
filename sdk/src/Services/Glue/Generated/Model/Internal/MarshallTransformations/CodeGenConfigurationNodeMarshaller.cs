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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAggregate())
            {
                context.Writer.WritePropertyName("Aggregate");
                context.Writer.WriteObjectStart();

                var marshaller = AggregateMarshaller.Instance;
                marshaller.Marshall(requestObject.Aggregate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetApplyMapping())
            {
                context.Writer.WritePropertyName("ApplyMapping");
                context.Writer.WriteObjectStart();

                var marshaller = ApplyMappingMarshaller.Instance;
                marshaller.Marshall(requestObject.ApplyMapping, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAthenaConnectorSource())
            {
                context.Writer.WritePropertyName("AthenaConnectorSource");
                context.Writer.WriteObjectStart();

                var marshaller = AthenaConnectorSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.AthenaConnectorSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCatalogHudiSource())
            {
                context.Writer.WritePropertyName("CatalogHudiSource");
                context.Writer.WriteObjectStart();

                var marshaller = CatalogHudiSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.CatalogHudiSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCatalogKafkaSource())
            {
                context.Writer.WritePropertyName("CatalogKafkaSource");
                context.Writer.WriteObjectStart();

                var marshaller = CatalogKafkaSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.CatalogKafkaSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCatalogKinesisSource())
            {
                context.Writer.WritePropertyName("CatalogKinesisSource");
                context.Writer.WriteObjectStart();

                var marshaller = CatalogKinesisSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.CatalogKinesisSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCatalogSource())
            {
                context.Writer.WritePropertyName("CatalogSource");
                context.Writer.WriteObjectStart();

                var marshaller = CatalogSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.CatalogSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCatalogTarget())
            {
                context.Writer.WritePropertyName("CatalogTarget");
                context.Writer.WriteObjectStart();

                var marshaller = BasicCatalogTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.CatalogTarget, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCustomCode())
            {
                context.Writer.WritePropertyName("CustomCode");
                context.Writer.WriteObjectStart();

                var marshaller = CustomCodeMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomCode, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDirectJDBCSource())
            {
                context.Writer.WritePropertyName("DirectJDBCSource");
                context.Writer.WriteObjectStart();

                var marshaller = DirectJDBCSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.DirectJDBCSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDirectKafkaSource())
            {
                context.Writer.WritePropertyName("DirectKafkaSource");
                context.Writer.WriteObjectStart();

                var marshaller = DirectKafkaSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.DirectKafkaSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDirectKinesisSource())
            {
                context.Writer.WritePropertyName("DirectKinesisSource");
                context.Writer.WriteObjectStart();

                var marshaller = DirectKinesisSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.DirectKinesisSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDropDuplicates())
            {
                context.Writer.WritePropertyName("DropDuplicates");
                context.Writer.WriteObjectStart();

                var marshaller = DropDuplicatesMarshaller.Instance;
                marshaller.Marshall(requestObject.DropDuplicates, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDropFields())
            {
                context.Writer.WritePropertyName("DropFields");
                context.Writer.WriteObjectStart();

                var marshaller = DropFieldsMarshaller.Instance;
                marshaller.Marshall(requestObject.DropFields, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDropNullFields())
            {
                context.Writer.WritePropertyName("DropNullFields");
                context.Writer.WriteObjectStart();

                var marshaller = DropNullFieldsMarshaller.Instance;
                marshaller.Marshall(requestObject.DropNullFields, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDynamicTransform())
            {
                context.Writer.WritePropertyName("DynamicTransform");
                context.Writer.WriteObjectStart();

                var marshaller = DynamicTransformMarshaller.Instance;
                marshaller.Marshall(requestObject.DynamicTransform, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDynamoDBCatalogSource())
            {
                context.Writer.WritePropertyName("DynamoDBCatalogSource");
                context.Writer.WriteObjectStart();

                var marshaller = DynamoDBCatalogSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.DynamoDBCatalogSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEvaluateDataQuality())
            {
                context.Writer.WritePropertyName("EvaluateDataQuality");
                context.Writer.WriteObjectStart();

                var marshaller = EvaluateDataQualityMarshaller.Instance;
                marshaller.Marshall(requestObject.EvaluateDataQuality, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFillMissingValues())
            {
                context.Writer.WritePropertyName("FillMissingValues");
                context.Writer.WriteObjectStart();

                var marshaller = FillMissingValuesMarshaller.Instance;
                marshaller.Marshall(requestObject.FillMissingValues, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFilter())
            {
                context.Writer.WritePropertyName("Filter");
                context.Writer.WriteObjectStart();

                var marshaller = FilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Filter, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGovernedCatalogSource())
            {
                context.Writer.WritePropertyName("GovernedCatalogSource");
                context.Writer.WriteObjectStart();

                var marshaller = GovernedCatalogSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.GovernedCatalogSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGovernedCatalogTarget())
            {
                context.Writer.WritePropertyName("GovernedCatalogTarget");
                context.Writer.WriteObjectStart();

                var marshaller = GovernedCatalogTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.GovernedCatalogTarget, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetJDBCConnectorSource())
            {
                context.Writer.WritePropertyName("JDBCConnectorSource");
                context.Writer.WriteObjectStart();

                var marshaller = JDBCConnectorSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.JDBCConnectorSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetJDBCConnectorTarget())
            {
                context.Writer.WritePropertyName("JDBCConnectorTarget");
                context.Writer.WriteObjectStart();

                var marshaller = JDBCConnectorTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.JDBCConnectorTarget, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetJoin())
            {
                context.Writer.WritePropertyName("Join");
                context.Writer.WriteObjectStart();

                var marshaller = JoinMarshaller.Instance;
                marshaller.Marshall(requestObject.Join, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMerge())
            {
                context.Writer.WritePropertyName("Merge");
                context.Writer.WriteObjectStart();

                var marshaller = MergeMarshaller.Instance;
                marshaller.Marshall(requestObject.Merge, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMicrosoftSQLServerCatalogSource())
            {
                context.Writer.WritePropertyName("MicrosoftSQLServerCatalogSource");
                context.Writer.WriteObjectStart();

                var marshaller = MicrosoftSQLServerCatalogSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.MicrosoftSQLServerCatalogSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMicrosoftSQLServerCatalogTarget())
            {
                context.Writer.WritePropertyName("MicrosoftSQLServerCatalogTarget");
                context.Writer.WriteObjectStart();

                var marshaller = MicrosoftSQLServerCatalogTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.MicrosoftSQLServerCatalogTarget, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMySQLCatalogSource())
            {
                context.Writer.WritePropertyName("MySQLCatalogSource");
                context.Writer.WriteObjectStart();

                var marshaller = MySQLCatalogSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.MySQLCatalogSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMySQLCatalogTarget())
            {
                context.Writer.WritePropertyName("MySQLCatalogTarget");
                context.Writer.WriteObjectStart();

                var marshaller = MySQLCatalogTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.MySQLCatalogTarget, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOracleSQLCatalogSource())
            {
                context.Writer.WritePropertyName("OracleSQLCatalogSource");
                context.Writer.WriteObjectStart();

                var marshaller = OracleSQLCatalogSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.OracleSQLCatalogSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOracleSQLCatalogTarget())
            {
                context.Writer.WritePropertyName("OracleSQLCatalogTarget");
                context.Writer.WriteObjectStart();

                var marshaller = OracleSQLCatalogTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.OracleSQLCatalogTarget, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPIIDetection())
            {
                context.Writer.WritePropertyName("PIIDetection");
                context.Writer.WriteObjectStart();

                var marshaller = PIIDetectionMarshaller.Instance;
                marshaller.Marshall(requestObject.PIIDetection, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPostgreSQLCatalogSource())
            {
                context.Writer.WritePropertyName("PostgreSQLCatalogSource");
                context.Writer.WriteObjectStart();

                var marshaller = PostgreSQLCatalogSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.PostgreSQLCatalogSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPostgreSQLCatalogTarget())
            {
                context.Writer.WritePropertyName("PostgreSQLCatalogTarget");
                context.Writer.WriteObjectStart();

                var marshaller = PostgreSQLCatalogTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.PostgreSQLCatalogTarget, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRedshiftSource())
            {
                context.Writer.WritePropertyName("RedshiftSource");
                context.Writer.WriteObjectStart();

                var marshaller = RedshiftSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.RedshiftSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRedshiftTarget())
            {
                context.Writer.WritePropertyName("RedshiftTarget");
                context.Writer.WriteObjectStart();

                var marshaller = RedshiftTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.RedshiftTarget, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRelationalCatalogSource())
            {
                context.Writer.WritePropertyName("RelationalCatalogSource");
                context.Writer.WriteObjectStart();

                var marshaller = RelationalCatalogSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.RelationalCatalogSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRenameField())
            {
                context.Writer.WritePropertyName("RenameField");
                context.Writer.WriteObjectStart();

                var marshaller = RenameFieldMarshaller.Instance;
                marshaller.Marshall(requestObject.RenameField, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetS3CatalogHudiSource())
            {
                context.Writer.WritePropertyName("S3CatalogHudiSource");
                context.Writer.WriteObjectStart();

                var marshaller = S3CatalogHudiSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.S3CatalogHudiSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetS3CatalogSource())
            {
                context.Writer.WritePropertyName("S3CatalogSource");
                context.Writer.WriteObjectStart();

                var marshaller = S3CatalogSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.S3CatalogSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetS3CatalogTarget())
            {
                context.Writer.WritePropertyName("S3CatalogTarget");
                context.Writer.WriteObjectStart();

                var marshaller = S3CatalogTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.S3CatalogTarget, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetS3CsvSource())
            {
                context.Writer.WritePropertyName("S3CsvSource");
                context.Writer.WriteObjectStart();

                var marshaller = S3CsvSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.S3CsvSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetS3DirectTarget())
            {
                context.Writer.WritePropertyName("S3DirectTarget");
                context.Writer.WriteObjectStart();

                var marshaller = S3DirectTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.S3DirectTarget, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetS3GlueParquetTarget())
            {
                context.Writer.WritePropertyName("S3GlueParquetTarget");
                context.Writer.WriteObjectStart();

                var marshaller = S3GlueParquetTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.S3GlueParquetTarget, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetS3HudiCatalogTarget())
            {
                context.Writer.WritePropertyName("S3HudiCatalogTarget");
                context.Writer.WriteObjectStart();

                var marshaller = S3HudiCatalogTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.S3HudiCatalogTarget, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetS3HudiDirectTarget())
            {
                context.Writer.WritePropertyName("S3HudiDirectTarget");
                context.Writer.WriteObjectStart();

                var marshaller = S3HudiDirectTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.S3HudiDirectTarget, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetS3HudiSource())
            {
                context.Writer.WritePropertyName("S3HudiSource");
                context.Writer.WriteObjectStart();

                var marshaller = S3HudiSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.S3HudiSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetS3JsonSource())
            {
                context.Writer.WritePropertyName("S3JsonSource");
                context.Writer.WriteObjectStart();

                var marshaller = S3JsonSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.S3JsonSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetS3ParquetSource())
            {
                context.Writer.WritePropertyName("S3ParquetSource");
                context.Writer.WriteObjectStart();

                var marshaller = S3ParquetSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.S3ParquetSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSelectFields())
            {
                context.Writer.WritePropertyName("SelectFields");
                context.Writer.WriteObjectStart();

                var marshaller = SelectFieldsMarshaller.Instance;
                marshaller.Marshall(requestObject.SelectFields, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSelectFromCollection())
            {
                context.Writer.WritePropertyName("SelectFromCollection");
                context.Writer.WriteObjectStart();

                var marshaller = SelectFromCollectionMarshaller.Instance;
                marshaller.Marshall(requestObject.SelectFromCollection, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSparkConnectorSource())
            {
                context.Writer.WritePropertyName("SparkConnectorSource");
                context.Writer.WriteObjectStart();

                var marshaller = SparkConnectorSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.SparkConnectorSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSparkConnectorTarget())
            {
                context.Writer.WritePropertyName("SparkConnectorTarget");
                context.Writer.WriteObjectStart();

                var marshaller = SparkConnectorTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.SparkConnectorTarget, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSparkSQL())
            {
                context.Writer.WritePropertyName("SparkSQL");
                context.Writer.WriteObjectStart();

                var marshaller = SparkSQLMarshaller.Instance;
                marshaller.Marshall(requestObject.SparkSQL, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSpigot())
            {
                context.Writer.WritePropertyName("Spigot");
                context.Writer.WriteObjectStart();

                var marshaller = SpigotMarshaller.Instance;
                marshaller.Marshall(requestObject.Spigot, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSplitFields())
            {
                context.Writer.WritePropertyName("SplitFields");
                context.Writer.WriteObjectStart();

                var marshaller = SplitFieldsMarshaller.Instance;
                marshaller.Marshall(requestObject.SplitFields, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetUnion())
            {
                context.Writer.WritePropertyName("Union");
                context.Writer.WriteObjectStart();

                var marshaller = UnionMarshaller.Instance;
                marshaller.Marshall(requestObject.Union, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CodeGenConfigurationNodeMarshaller Instance = new CodeGenConfigurationNodeMarshaller();

    }
}
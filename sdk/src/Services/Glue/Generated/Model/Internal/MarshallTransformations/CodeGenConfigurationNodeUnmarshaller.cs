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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CodeGenConfigurationNode Object
    /// </summary>  
    public class CodeGenConfigurationNodeUnmarshaller : IJsonUnmarshaller<CodeGenConfigurationNode, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public CodeGenConfigurationNode Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            CodeGenConfigurationNode unmarshalledObject = new CodeGenConfigurationNode();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Aggregate", targetDepth, ref reader))
                {
                    var unmarshaller = AggregateUnmarshaller.Instance;
                    unmarshalledObject.Aggregate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AmazonRedshiftSource", targetDepth, ref reader))
                {
                    var unmarshaller = AmazonRedshiftSourceUnmarshaller.Instance;
                    unmarshalledObject.AmazonRedshiftSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AmazonRedshiftTarget", targetDepth, ref reader))
                {
                    var unmarshaller = AmazonRedshiftTargetUnmarshaller.Instance;
                    unmarshalledObject.AmazonRedshiftTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ApplyMapping", targetDepth, ref reader))
                {
                    var unmarshaller = ApplyMappingUnmarshaller.Instance;
                    unmarshalledObject.ApplyMapping = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AthenaConnectorSource", targetDepth, ref reader))
                {
                    var unmarshaller = AthenaConnectorSourceUnmarshaller.Instance;
                    unmarshalledObject.AthenaConnectorSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CatalogDeltaSource", targetDepth, ref reader))
                {
                    var unmarshaller = CatalogDeltaSourceUnmarshaller.Instance;
                    unmarshalledObject.CatalogDeltaSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CatalogHudiSource", targetDepth, ref reader))
                {
                    var unmarshaller = CatalogHudiSourceUnmarshaller.Instance;
                    unmarshalledObject.CatalogHudiSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CatalogIcebergSource", targetDepth, ref reader))
                {
                    var unmarshaller = CatalogIcebergSourceUnmarshaller.Instance;
                    unmarshalledObject.CatalogIcebergSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CatalogKafkaSource", targetDepth, ref reader))
                {
                    var unmarshaller = CatalogKafkaSourceUnmarshaller.Instance;
                    unmarshalledObject.CatalogKafkaSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CatalogKinesisSource", targetDepth, ref reader))
                {
                    var unmarshaller = CatalogKinesisSourceUnmarshaller.Instance;
                    unmarshalledObject.CatalogKinesisSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CatalogSource", targetDepth, ref reader))
                {
                    var unmarshaller = CatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.CatalogSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CatalogTarget", targetDepth, ref reader))
                {
                    var unmarshaller = BasicCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.CatalogTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ConnectorDataSource", targetDepth, ref reader))
                {
                    var unmarshaller = ConnectorDataSourceUnmarshaller.Instance;
                    unmarshalledObject.ConnectorDataSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ConnectorDataTarget", targetDepth, ref reader))
                {
                    var unmarshaller = ConnectorDataTargetUnmarshaller.Instance;
                    unmarshalledObject.ConnectorDataTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CustomCode", targetDepth, ref reader))
                {
                    var unmarshaller = CustomCodeUnmarshaller.Instance;
                    unmarshalledObject.CustomCode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DirectJDBCSource", targetDepth, ref reader))
                {
                    var unmarshaller = DirectJDBCSourceUnmarshaller.Instance;
                    unmarshalledObject.DirectJDBCSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DirectKafkaSource", targetDepth, ref reader))
                {
                    var unmarshaller = DirectKafkaSourceUnmarshaller.Instance;
                    unmarshalledObject.DirectKafkaSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DirectKinesisSource", targetDepth, ref reader))
                {
                    var unmarshaller = DirectKinesisSourceUnmarshaller.Instance;
                    unmarshalledObject.DirectKinesisSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DropDuplicates", targetDepth, ref reader))
                {
                    var unmarshaller = DropDuplicatesUnmarshaller.Instance;
                    unmarshalledObject.DropDuplicates = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DropFields", targetDepth, ref reader))
                {
                    var unmarshaller = DropFieldsUnmarshaller.Instance;
                    unmarshalledObject.DropFields = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DropNullFields", targetDepth, ref reader))
                {
                    var unmarshaller = DropNullFieldsUnmarshaller.Instance;
                    unmarshalledObject.DropNullFields = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DynamicTransform", targetDepth, ref reader))
                {
                    var unmarshaller = DynamicTransformUnmarshaller.Instance;
                    unmarshalledObject.DynamicTransform = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DynamoDBCatalogSource", targetDepth, ref reader))
                {
                    var unmarshaller = DynamoDBCatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.DynamoDBCatalogSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DynamoDBELTConnectorSource", targetDepth, ref reader))
                {
                    var unmarshaller = DynamoDBELTConnectorSourceUnmarshaller.Instance;
                    unmarshalledObject.DynamoDBELTConnectorSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EvaluateDataQuality", targetDepth, ref reader))
                {
                    var unmarshaller = EvaluateDataQualityUnmarshaller.Instance;
                    unmarshalledObject.EvaluateDataQuality = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EvaluateDataQualityMultiFrame", targetDepth, ref reader))
                {
                    var unmarshaller = EvaluateDataQualityMultiFrameUnmarshaller.Instance;
                    unmarshalledObject.EvaluateDataQualityMultiFrame = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FillMissingValues", targetDepth, ref reader))
                {
                    var unmarshaller = FillMissingValuesUnmarshaller.Instance;
                    unmarshalledObject.FillMissingValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Filter", targetDepth, ref reader))
                {
                    var unmarshaller = FilterUnmarshaller.Instance;
                    unmarshalledObject.Filter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GovernedCatalogSource", targetDepth, ref reader))
                {
                    var unmarshaller = GovernedCatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.GovernedCatalogSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GovernedCatalogTarget", targetDepth, ref reader))
                {
                    var unmarshaller = GovernedCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.GovernedCatalogTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JDBCConnectorSource", targetDepth, ref reader))
                {
                    var unmarshaller = JDBCConnectorSourceUnmarshaller.Instance;
                    unmarshalledObject.JDBCConnectorSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JDBCConnectorTarget", targetDepth, ref reader))
                {
                    var unmarshaller = JDBCConnectorTargetUnmarshaller.Instance;
                    unmarshalledObject.JDBCConnectorTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Join", targetDepth, ref reader))
                {
                    var unmarshaller = JoinUnmarshaller.Instance;
                    unmarshalledObject.Join = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Merge", targetDepth, ref reader))
                {
                    var unmarshaller = MergeUnmarshaller.Instance;
                    unmarshalledObject.Merge = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MicrosoftSQLServerCatalogSource", targetDepth, ref reader))
                {
                    var unmarshaller = MicrosoftSQLServerCatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.MicrosoftSQLServerCatalogSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MicrosoftSQLServerCatalogTarget", targetDepth, ref reader))
                {
                    var unmarshaller = MicrosoftSQLServerCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.MicrosoftSQLServerCatalogTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MySQLCatalogSource", targetDepth, ref reader))
                {
                    var unmarshaller = MySQLCatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.MySQLCatalogSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MySQLCatalogTarget", targetDepth, ref reader))
                {
                    var unmarshaller = MySQLCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.MySQLCatalogTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OracleSQLCatalogSource", targetDepth, ref reader))
                {
                    var unmarshaller = OracleSQLCatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.OracleSQLCatalogSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OracleSQLCatalogTarget", targetDepth, ref reader))
                {
                    var unmarshaller = OracleSQLCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.OracleSQLCatalogTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PIIDetection", targetDepth, ref reader))
                {
                    var unmarshaller = PIIDetectionUnmarshaller.Instance;
                    unmarshalledObject.PIIDetection = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PostgreSQLCatalogSource", targetDepth, ref reader))
                {
                    var unmarshaller = PostgreSQLCatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.PostgreSQLCatalogSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PostgreSQLCatalogTarget", targetDepth, ref reader))
                {
                    var unmarshaller = PostgreSQLCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.PostgreSQLCatalogTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Recipe", targetDepth, ref reader))
                {
                    var unmarshaller = RecipeUnmarshaller.Instance;
                    unmarshalledObject.Recipe = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RedshiftSource", targetDepth, ref reader))
                {
                    var unmarshaller = RedshiftSourceUnmarshaller.Instance;
                    unmarshalledObject.RedshiftSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RedshiftTarget", targetDepth, ref reader))
                {
                    var unmarshaller = RedshiftTargetUnmarshaller.Instance;
                    unmarshalledObject.RedshiftTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RelationalCatalogSource", targetDepth, ref reader))
                {
                    var unmarshaller = RelationalCatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.RelationalCatalogSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RenameField", targetDepth, ref reader))
                {
                    var unmarshaller = RenameFieldUnmarshaller.Instance;
                    unmarshalledObject.RenameField = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Route", targetDepth, ref reader))
                {
                    var unmarshaller = RouteUnmarshaller.Instance;
                    unmarshalledObject.Route = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3CatalogDeltaSource", targetDepth, ref reader))
                {
                    var unmarshaller = S3CatalogDeltaSourceUnmarshaller.Instance;
                    unmarshalledObject.S3CatalogDeltaSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3CatalogHudiSource", targetDepth, ref reader))
                {
                    var unmarshaller = S3CatalogHudiSourceUnmarshaller.Instance;
                    unmarshalledObject.S3CatalogHudiSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3CatalogIcebergSource", targetDepth, ref reader))
                {
                    var unmarshaller = S3CatalogIcebergSourceUnmarshaller.Instance;
                    unmarshalledObject.S3CatalogIcebergSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3CatalogSource", targetDepth, ref reader))
                {
                    var unmarshaller = S3CatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.S3CatalogSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3CatalogTarget", targetDepth, ref reader))
                {
                    var unmarshaller = S3CatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.S3CatalogTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3CsvSource", targetDepth, ref reader))
                {
                    var unmarshaller = S3CsvSourceUnmarshaller.Instance;
                    unmarshalledObject.S3CsvSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3DeltaCatalogTarget", targetDepth, ref reader))
                {
                    var unmarshaller = S3DeltaCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.S3DeltaCatalogTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3DeltaDirectTarget", targetDepth, ref reader))
                {
                    var unmarshaller = S3DeltaDirectTargetUnmarshaller.Instance;
                    unmarshalledObject.S3DeltaDirectTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3DeltaSource", targetDepth, ref reader))
                {
                    var unmarshaller = S3DeltaSourceUnmarshaller.Instance;
                    unmarshalledObject.S3DeltaSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3DirectTarget", targetDepth, ref reader))
                {
                    var unmarshaller = S3DirectTargetUnmarshaller.Instance;
                    unmarshalledObject.S3DirectTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3ExcelSource", targetDepth, ref reader))
                {
                    var unmarshaller = S3ExcelSourceUnmarshaller.Instance;
                    unmarshalledObject.S3ExcelSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3GlueParquetTarget", targetDepth, ref reader))
                {
                    var unmarshaller = S3GlueParquetTargetUnmarshaller.Instance;
                    unmarshalledObject.S3GlueParquetTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3HudiCatalogTarget", targetDepth, ref reader))
                {
                    var unmarshaller = S3HudiCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.S3HudiCatalogTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3HudiDirectTarget", targetDepth, ref reader))
                {
                    var unmarshaller = S3HudiDirectTargetUnmarshaller.Instance;
                    unmarshalledObject.S3HudiDirectTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3HudiSource", targetDepth, ref reader))
                {
                    var unmarshaller = S3HudiSourceUnmarshaller.Instance;
                    unmarshalledObject.S3HudiSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3HyperDirectTarget", targetDepth, ref reader))
                {
                    var unmarshaller = S3HyperDirectTargetUnmarshaller.Instance;
                    unmarshalledObject.S3HyperDirectTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3IcebergCatalogTarget", targetDepth, ref reader))
                {
                    var unmarshaller = S3IcebergCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.S3IcebergCatalogTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3IcebergDirectTarget", targetDepth, ref reader))
                {
                    var unmarshaller = S3IcebergDirectTargetUnmarshaller.Instance;
                    unmarshalledObject.S3IcebergDirectTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3JsonSource", targetDepth, ref reader))
                {
                    var unmarshaller = S3JsonSourceUnmarshaller.Instance;
                    unmarshalledObject.S3JsonSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3ParquetSource", targetDepth, ref reader))
                {
                    var unmarshaller = S3ParquetSourceUnmarshaller.Instance;
                    unmarshalledObject.S3ParquetSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SelectFields", targetDepth, ref reader))
                {
                    var unmarshaller = SelectFieldsUnmarshaller.Instance;
                    unmarshalledObject.SelectFields = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SelectFromCollection", targetDepth, ref reader))
                {
                    var unmarshaller = SelectFromCollectionUnmarshaller.Instance;
                    unmarshalledObject.SelectFromCollection = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SnowflakeSource", targetDepth, ref reader))
                {
                    var unmarshaller = SnowflakeSourceUnmarshaller.Instance;
                    unmarshalledObject.SnowflakeSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SnowflakeTarget", targetDepth, ref reader))
                {
                    var unmarshaller = SnowflakeTargetUnmarshaller.Instance;
                    unmarshalledObject.SnowflakeTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SparkConnectorSource", targetDepth, ref reader))
                {
                    var unmarshaller = SparkConnectorSourceUnmarshaller.Instance;
                    unmarshalledObject.SparkConnectorSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SparkConnectorTarget", targetDepth, ref reader))
                {
                    var unmarshaller = SparkConnectorTargetUnmarshaller.Instance;
                    unmarshalledObject.SparkConnectorTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SparkSQL", targetDepth, ref reader))
                {
                    var unmarshaller = SparkSQLUnmarshaller.Instance;
                    unmarshalledObject.SparkSQL = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Spigot", targetDepth, ref reader))
                {
                    var unmarshaller = SpigotUnmarshaller.Instance;
                    unmarshalledObject.Spigot = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SplitFields", targetDepth, ref reader))
                {
                    var unmarshaller = SplitFieldsUnmarshaller.Instance;
                    unmarshalledObject.SplitFields = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Union", targetDepth, ref reader))
                {
                    var unmarshaller = UnionUnmarshaller.Instance;
                    unmarshalledObject.Union = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CodeGenConfigurationNodeUnmarshaller _instance = new CodeGenConfigurationNodeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CodeGenConfigurationNodeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
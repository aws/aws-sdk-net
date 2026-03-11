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
                if (context.TestExpression("Aggregate", targetDepth))
                {
                    var unmarshaller = AggregateUnmarshaller.Instance;
                    unmarshalledObject.Aggregate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AmazonRedshiftSource", targetDepth))
                {
                    var unmarshaller = AmazonRedshiftSourceUnmarshaller.Instance;
                    unmarshalledObject.AmazonRedshiftSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AmazonRedshiftTarget", targetDepth))
                {
                    var unmarshaller = AmazonRedshiftTargetUnmarshaller.Instance;
                    unmarshalledObject.AmazonRedshiftTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ApplyMapping", targetDepth))
                {
                    var unmarshaller = ApplyMappingUnmarshaller.Instance;
                    unmarshalledObject.ApplyMapping = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AthenaConnectorSource", targetDepth))
                {
                    var unmarshaller = AthenaConnectorSourceUnmarshaller.Instance;
                    unmarshalledObject.AthenaConnectorSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CatalogDeltaSource", targetDepth))
                {
                    var unmarshaller = CatalogDeltaSourceUnmarshaller.Instance;
                    unmarshalledObject.CatalogDeltaSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CatalogHudiSource", targetDepth))
                {
                    var unmarshaller = CatalogHudiSourceUnmarshaller.Instance;
                    unmarshalledObject.CatalogHudiSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CatalogIcebergSource", targetDepth))
                {
                    var unmarshaller = CatalogIcebergSourceUnmarshaller.Instance;
                    unmarshalledObject.CatalogIcebergSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CatalogKafkaSource", targetDepth))
                {
                    var unmarshaller = CatalogKafkaSourceUnmarshaller.Instance;
                    unmarshalledObject.CatalogKafkaSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CatalogKinesisSource", targetDepth))
                {
                    var unmarshaller = CatalogKinesisSourceUnmarshaller.Instance;
                    unmarshalledObject.CatalogKinesisSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CatalogSource", targetDepth))
                {
                    var unmarshaller = CatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.CatalogSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CatalogTarget", targetDepth))
                {
                    var unmarshaller = BasicCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.CatalogTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ConnectorDataSource", targetDepth))
                {
                    var unmarshaller = ConnectorDataSourceUnmarshaller.Instance;
                    unmarshalledObject.ConnectorDataSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ConnectorDataTarget", targetDepth))
                {
                    var unmarshaller = ConnectorDataTargetUnmarshaller.Instance;
                    unmarshalledObject.ConnectorDataTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CustomCode", targetDepth))
                {
                    var unmarshaller = CustomCodeUnmarshaller.Instance;
                    unmarshalledObject.CustomCode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DirectJDBCSource", targetDepth))
                {
                    var unmarshaller = DirectJDBCSourceUnmarshaller.Instance;
                    unmarshalledObject.DirectJDBCSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DirectKafkaSource", targetDepth))
                {
                    var unmarshaller = DirectKafkaSourceUnmarshaller.Instance;
                    unmarshalledObject.DirectKafkaSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DirectKinesisSource", targetDepth))
                {
                    var unmarshaller = DirectKinesisSourceUnmarshaller.Instance;
                    unmarshalledObject.DirectKinesisSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DropDuplicates", targetDepth))
                {
                    var unmarshaller = DropDuplicatesUnmarshaller.Instance;
                    unmarshalledObject.DropDuplicates = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DropFields", targetDepth))
                {
                    var unmarshaller = DropFieldsUnmarshaller.Instance;
                    unmarshalledObject.DropFields = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DropNullFields", targetDepth))
                {
                    var unmarshaller = DropNullFieldsUnmarshaller.Instance;
                    unmarshalledObject.DropNullFields = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DynamicTransform", targetDepth))
                {
                    var unmarshaller = DynamicTransformUnmarshaller.Instance;
                    unmarshalledObject.DynamicTransform = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DynamoDBCatalogSource", targetDepth))
                {
                    var unmarshaller = DynamoDBCatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.DynamoDBCatalogSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DynamoDBELTConnectorSource", targetDepth))
                {
                    var unmarshaller = DynamoDBELTConnectorSourceUnmarshaller.Instance;
                    unmarshalledObject.DynamoDBELTConnectorSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EvaluateDataQuality", targetDepth))
                {
                    var unmarshaller = EvaluateDataQualityUnmarshaller.Instance;
                    unmarshalledObject.EvaluateDataQuality = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EvaluateDataQualityMultiFrame", targetDepth))
                {
                    var unmarshaller = EvaluateDataQualityMultiFrameUnmarshaller.Instance;
                    unmarshalledObject.EvaluateDataQualityMultiFrame = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FillMissingValues", targetDepth))
                {
                    var unmarshaller = FillMissingValuesUnmarshaller.Instance;
                    unmarshalledObject.FillMissingValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Filter", targetDepth))
                {
                    var unmarshaller = FilterUnmarshaller.Instance;
                    unmarshalledObject.Filter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GovernedCatalogSource", targetDepth))
                {
                    var unmarshaller = GovernedCatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.GovernedCatalogSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GovernedCatalogTarget", targetDepth))
                {
                    var unmarshaller = GovernedCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.GovernedCatalogTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JDBCConnectorSource", targetDepth))
                {
                    var unmarshaller = JDBCConnectorSourceUnmarshaller.Instance;
                    unmarshalledObject.JDBCConnectorSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JDBCConnectorTarget", targetDepth))
                {
                    var unmarshaller = JDBCConnectorTargetUnmarshaller.Instance;
                    unmarshalledObject.JDBCConnectorTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Join", targetDepth))
                {
                    var unmarshaller = JoinUnmarshaller.Instance;
                    unmarshalledObject.Join = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Merge", targetDepth))
                {
                    var unmarshaller = MergeUnmarshaller.Instance;
                    unmarshalledObject.Merge = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MicrosoftSQLServerCatalogSource", targetDepth))
                {
                    var unmarshaller = MicrosoftSQLServerCatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.MicrosoftSQLServerCatalogSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MicrosoftSQLServerCatalogTarget", targetDepth))
                {
                    var unmarshaller = MicrosoftSQLServerCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.MicrosoftSQLServerCatalogTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MySQLCatalogSource", targetDepth))
                {
                    var unmarshaller = MySQLCatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.MySQLCatalogSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MySQLCatalogTarget", targetDepth))
                {
                    var unmarshaller = MySQLCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.MySQLCatalogTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OracleSQLCatalogSource", targetDepth))
                {
                    var unmarshaller = OracleSQLCatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.OracleSQLCatalogSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OracleSQLCatalogTarget", targetDepth))
                {
                    var unmarshaller = OracleSQLCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.OracleSQLCatalogTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PIIDetection", targetDepth))
                {
                    var unmarshaller = PIIDetectionUnmarshaller.Instance;
                    unmarshalledObject.PIIDetection = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PostgreSQLCatalogSource", targetDepth))
                {
                    var unmarshaller = PostgreSQLCatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.PostgreSQLCatalogSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PostgreSQLCatalogTarget", targetDepth))
                {
                    var unmarshaller = PostgreSQLCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.PostgreSQLCatalogTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Recipe", targetDepth))
                {
                    var unmarshaller = RecipeUnmarshaller.Instance;
                    unmarshalledObject.Recipe = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RedshiftSource", targetDepth))
                {
                    var unmarshaller = RedshiftSourceUnmarshaller.Instance;
                    unmarshalledObject.RedshiftSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RedshiftTarget", targetDepth))
                {
                    var unmarshaller = RedshiftTargetUnmarshaller.Instance;
                    unmarshalledObject.RedshiftTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RelationalCatalogSource", targetDepth))
                {
                    var unmarshaller = RelationalCatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.RelationalCatalogSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RenameField", targetDepth))
                {
                    var unmarshaller = RenameFieldUnmarshaller.Instance;
                    unmarshalledObject.RenameField = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Route", targetDepth))
                {
                    var unmarshaller = RouteUnmarshaller.Instance;
                    unmarshalledObject.Route = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3CatalogDeltaSource", targetDepth))
                {
                    var unmarshaller = S3CatalogDeltaSourceUnmarshaller.Instance;
                    unmarshalledObject.S3CatalogDeltaSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3CatalogHudiSource", targetDepth))
                {
                    var unmarshaller = S3CatalogHudiSourceUnmarshaller.Instance;
                    unmarshalledObject.S3CatalogHudiSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3CatalogIcebergSource", targetDepth))
                {
                    var unmarshaller = S3CatalogIcebergSourceUnmarshaller.Instance;
                    unmarshalledObject.S3CatalogIcebergSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3CatalogSource", targetDepth))
                {
                    var unmarshaller = S3CatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.S3CatalogSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3CatalogTarget", targetDepth))
                {
                    var unmarshaller = S3CatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.S3CatalogTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3CsvSource", targetDepth))
                {
                    var unmarshaller = S3CsvSourceUnmarshaller.Instance;
                    unmarshalledObject.S3CsvSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3DeltaCatalogTarget", targetDepth))
                {
                    var unmarshaller = S3DeltaCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.S3DeltaCatalogTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3DeltaDirectTarget", targetDepth))
                {
                    var unmarshaller = S3DeltaDirectTargetUnmarshaller.Instance;
                    unmarshalledObject.S3DeltaDirectTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3DeltaSource", targetDepth))
                {
                    var unmarshaller = S3DeltaSourceUnmarshaller.Instance;
                    unmarshalledObject.S3DeltaSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3DirectTarget", targetDepth))
                {
                    var unmarshaller = S3DirectTargetUnmarshaller.Instance;
                    unmarshalledObject.S3DirectTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3ExcelSource", targetDepth))
                {
                    var unmarshaller = S3ExcelSourceUnmarshaller.Instance;
                    unmarshalledObject.S3ExcelSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3GlueParquetTarget", targetDepth))
                {
                    var unmarshaller = S3GlueParquetTargetUnmarshaller.Instance;
                    unmarshalledObject.S3GlueParquetTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3HudiCatalogTarget", targetDepth))
                {
                    var unmarshaller = S3HudiCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.S3HudiCatalogTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3HudiDirectTarget", targetDepth))
                {
                    var unmarshaller = S3HudiDirectTargetUnmarshaller.Instance;
                    unmarshalledObject.S3HudiDirectTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3HudiSource", targetDepth))
                {
                    var unmarshaller = S3HudiSourceUnmarshaller.Instance;
                    unmarshalledObject.S3HudiSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3HyperDirectTarget", targetDepth))
                {
                    var unmarshaller = S3HyperDirectTargetUnmarshaller.Instance;
                    unmarshalledObject.S3HyperDirectTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3IcebergCatalogTarget", targetDepth))
                {
                    var unmarshaller = S3IcebergCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.S3IcebergCatalogTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3IcebergDirectTarget", targetDepth))
                {
                    var unmarshaller = S3IcebergDirectTargetUnmarshaller.Instance;
                    unmarshalledObject.S3IcebergDirectTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3JsonSource", targetDepth))
                {
                    var unmarshaller = S3JsonSourceUnmarshaller.Instance;
                    unmarshalledObject.S3JsonSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3ParquetSource", targetDepth))
                {
                    var unmarshaller = S3ParquetSourceUnmarshaller.Instance;
                    unmarshalledObject.S3ParquetSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SelectFields", targetDepth))
                {
                    var unmarshaller = SelectFieldsUnmarshaller.Instance;
                    unmarshalledObject.SelectFields = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SelectFromCollection", targetDepth))
                {
                    var unmarshaller = SelectFromCollectionUnmarshaller.Instance;
                    unmarshalledObject.SelectFromCollection = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SnowflakeSource", targetDepth))
                {
                    var unmarshaller = SnowflakeSourceUnmarshaller.Instance;
                    unmarshalledObject.SnowflakeSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SnowflakeTarget", targetDepth))
                {
                    var unmarshaller = SnowflakeTargetUnmarshaller.Instance;
                    unmarshalledObject.SnowflakeTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SparkConnectorSource", targetDepth))
                {
                    var unmarshaller = SparkConnectorSourceUnmarshaller.Instance;
                    unmarshalledObject.SparkConnectorSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SparkConnectorTarget", targetDepth))
                {
                    var unmarshaller = SparkConnectorTargetUnmarshaller.Instance;
                    unmarshalledObject.SparkConnectorTarget = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SparkSQL", targetDepth))
                {
                    var unmarshaller = SparkSQLUnmarshaller.Instance;
                    unmarshalledObject.SparkSQL = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Spigot", targetDepth))
                {
                    var unmarshaller = SpigotUnmarshaller.Instance;
                    unmarshalledObject.Spigot = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SplitFields", targetDepth))
                {
                    var unmarshaller = SplitFieldsUnmarshaller.Instance;
                    unmarshalledObject.SplitFields = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Union", targetDepth))
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
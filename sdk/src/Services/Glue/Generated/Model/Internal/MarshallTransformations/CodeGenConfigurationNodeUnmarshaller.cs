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
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CodeGenConfigurationNode Object
    /// </summary>  
    public class CodeGenConfigurationNodeUnmarshaller : IUnmarshaller<CodeGenConfigurationNode, XmlUnmarshallerContext>, IUnmarshaller<CodeGenConfigurationNode, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CodeGenConfigurationNode IUnmarshaller<CodeGenConfigurationNode, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CodeGenConfigurationNode Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CodeGenConfigurationNode unmarshalledObject = new CodeGenConfigurationNode();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Aggregate", targetDepth))
                {
                    var unmarshaller = AggregateUnmarshaller.Instance;
                    unmarshalledObject.Aggregate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ApplyMapping", targetDepth))
                {
                    var unmarshaller = ApplyMappingUnmarshaller.Instance;
                    unmarshalledObject.ApplyMapping = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AthenaConnectorSource", targetDepth))
                {
                    var unmarshaller = AthenaConnectorSourceUnmarshaller.Instance;
                    unmarshalledObject.AthenaConnectorSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CatalogKafkaSource", targetDepth))
                {
                    var unmarshaller = CatalogKafkaSourceUnmarshaller.Instance;
                    unmarshalledObject.CatalogKafkaSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CatalogKinesisSource", targetDepth))
                {
                    var unmarshaller = CatalogKinesisSourceUnmarshaller.Instance;
                    unmarshalledObject.CatalogKinesisSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CatalogSource", targetDepth))
                {
                    var unmarshaller = CatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.CatalogSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CatalogTarget", targetDepth))
                {
                    var unmarshaller = BasicCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.CatalogTarget = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomCode", targetDepth))
                {
                    var unmarshaller = CustomCodeUnmarshaller.Instance;
                    unmarshalledObject.CustomCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DirectKafkaSource", targetDepth))
                {
                    var unmarshaller = DirectKafkaSourceUnmarshaller.Instance;
                    unmarshalledObject.DirectKafkaSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DirectKinesisSource", targetDepth))
                {
                    var unmarshaller = DirectKinesisSourceUnmarshaller.Instance;
                    unmarshalledObject.DirectKinesisSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DropDuplicates", targetDepth))
                {
                    var unmarshaller = DropDuplicatesUnmarshaller.Instance;
                    unmarshalledObject.DropDuplicates = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DropFields", targetDepth))
                {
                    var unmarshaller = DropFieldsUnmarshaller.Instance;
                    unmarshalledObject.DropFields = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DropNullFields", targetDepth))
                {
                    var unmarshaller = DropNullFieldsUnmarshaller.Instance;
                    unmarshalledObject.DropNullFields = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DynamicTransform", targetDepth))
                {
                    var unmarshaller = DynamicTransformUnmarshaller.Instance;
                    unmarshalledObject.DynamicTransform = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DynamoDBCatalogSource", targetDepth))
                {
                    var unmarshaller = DynamoDBCatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.DynamoDBCatalogSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluateDataQuality", targetDepth))
                {
                    var unmarshaller = EvaluateDataQualityUnmarshaller.Instance;
                    unmarshalledObject.EvaluateDataQuality = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FillMissingValues", targetDepth))
                {
                    var unmarshaller = FillMissingValuesUnmarshaller.Instance;
                    unmarshalledObject.FillMissingValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Filter", targetDepth))
                {
                    var unmarshaller = FilterUnmarshaller.Instance;
                    unmarshalledObject.Filter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GovernedCatalogSource", targetDepth))
                {
                    var unmarshaller = GovernedCatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.GovernedCatalogSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GovernedCatalogTarget", targetDepth))
                {
                    var unmarshaller = GovernedCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.GovernedCatalogTarget = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JDBCConnectorSource", targetDepth))
                {
                    var unmarshaller = JDBCConnectorSourceUnmarshaller.Instance;
                    unmarshalledObject.JDBCConnectorSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JDBCConnectorTarget", targetDepth))
                {
                    var unmarshaller = JDBCConnectorTargetUnmarshaller.Instance;
                    unmarshalledObject.JDBCConnectorTarget = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Join", targetDepth))
                {
                    var unmarshaller = JoinUnmarshaller.Instance;
                    unmarshalledObject.Join = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Merge", targetDepth))
                {
                    var unmarshaller = MergeUnmarshaller.Instance;
                    unmarshalledObject.Merge = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MicrosoftSQLServerCatalogSource", targetDepth))
                {
                    var unmarshaller = MicrosoftSQLServerCatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.MicrosoftSQLServerCatalogSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MicrosoftSQLServerCatalogTarget", targetDepth))
                {
                    var unmarshaller = MicrosoftSQLServerCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.MicrosoftSQLServerCatalogTarget = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MySQLCatalogSource", targetDepth))
                {
                    var unmarshaller = MySQLCatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.MySQLCatalogSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MySQLCatalogTarget", targetDepth))
                {
                    var unmarshaller = MySQLCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.MySQLCatalogTarget = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OracleSQLCatalogSource", targetDepth))
                {
                    var unmarshaller = OracleSQLCatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.OracleSQLCatalogSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OracleSQLCatalogTarget", targetDepth))
                {
                    var unmarshaller = OracleSQLCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.OracleSQLCatalogTarget = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PIIDetection", targetDepth))
                {
                    var unmarshaller = PIIDetectionUnmarshaller.Instance;
                    unmarshalledObject.PIIDetection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PostgreSQLCatalogSource", targetDepth))
                {
                    var unmarshaller = PostgreSQLCatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.PostgreSQLCatalogSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PostgreSQLCatalogTarget", targetDepth))
                {
                    var unmarshaller = PostgreSQLCatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.PostgreSQLCatalogTarget = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RedshiftSource", targetDepth))
                {
                    var unmarshaller = RedshiftSourceUnmarshaller.Instance;
                    unmarshalledObject.RedshiftSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RedshiftTarget", targetDepth))
                {
                    var unmarshaller = RedshiftTargetUnmarshaller.Instance;
                    unmarshalledObject.RedshiftTarget = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RelationalCatalogSource", targetDepth))
                {
                    var unmarshaller = RelationalCatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.RelationalCatalogSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RenameField", targetDepth))
                {
                    var unmarshaller = RenameFieldUnmarshaller.Instance;
                    unmarshalledObject.RenameField = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3CatalogSource", targetDepth))
                {
                    var unmarshaller = S3CatalogSourceUnmarshaller.Instance;
                    unmarshalledObject.S3CatalogSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3CatalogTarget", targetDepth))
                {
                    var unmarshaller = S3CatalogTargetUnmarshaller.Instance;
                    unmarshalledObject.S3CatalogTarget = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3CsvSource", targetDepth))
                {
                    var unmarshaller = S3CsvSourceUnmarshaller.Instance;
                    unmarshalledObject.S3CsvSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3DirectTarget", targetDepth))
                {
                    var unmarshaller = S3DirectTargetUnmarshaller.Instance;
                    unmarshalledObject.S3DirectTarget = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3GlueParquetTarget", targetDepth))
                {
                    var unmarshaller = S3GlueParquetTargetUnmarshaller.Instance;
                    unmarshalledObject.S3GlueParquetTarget = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3JsonSource", targetDepth))
                {
                    var unmarshaller = S3JsonSourceUnmarshaller.Instance;
                    unmarshalledObject.S3JsonSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3ParquetSource", targetDepth))
                {
                    var unmarshaller = S3ParquetSourceUnmarshaller.Instance;
                    unmarshalledObject.S3ParquetSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SelectFields", targetDepth))
                {
                    var unmarshaller = SelectFieldsUnmarshaller.Instance;
                    unmarshalledObject.SelectFields = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SelectFromCollection", targetDepth))
                {
                    var unmarshaller = SelectFromCollectionUnmarshaller.Instance;
                    unmarshalledObject.SelectFromCollection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SparkConnectorSource", targetDepth))
                {
                    var unmarshaller = SparkConnectorSourceUnmarshaller.Instance;
                    unmarshalledObject.SparkConnectorSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SparkConnectorTarget", targetDepth))
                {
                    var unmarshaller = SparkConnectorTargetUnmarshaller.Instance;
                    unmarshalledObject.SparkConnectorTarget = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SparkSQL", targetDepth))
                {
                    var unmarshaller = SparkSQLUnmarshaller.Instance;
                    unmarshalledObject.SparkSQL = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Spigot", targetDepth))
                {
                    var unmarshaller = SpigotUnmarshaller.Instance;
                    unmarshalledObject.Spigot = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SplitFields", targetDepth))
                {
                    var unmarshaller = SplitFieldsUnmarshaller.Instance;
                    unmarshalledObject.SplitFields = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Union", targetDepth))
                {
                    var unmarshaller = UnionUnmarshaller.Instance;
                    unmarshalledObject.Union = unmarshaller.Unmarshall(context);
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
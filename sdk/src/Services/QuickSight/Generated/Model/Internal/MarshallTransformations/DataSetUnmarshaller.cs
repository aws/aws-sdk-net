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
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataSet Object
    /// </summary>  
    public class DataSetUnmarshaller : IJsonUnmarshaller<DataSet, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public DataSet Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            DataSet unmarshalledObject = new DataSet();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ColumnGroups", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ColumnGroup, ColumnGroupUnmarshaller>(ColumnGroupUnmarshaller.Instance);
                    unmarshalledObject.ColumnGroups = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ColumnLevelPermissionRules", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ColumnLevelPermissionRule, ColumnLevelPermissionRuleUnmarshaller>(ColumnLevelPermissionRuleUnmarshaller.Instance);
                    unmarshalledObject.ColumnLevelPermissionRules = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ConsumedSpiceCapacityInBytes", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.ConsumedSpiceCapacityInBytes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreatedTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DataSetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataSetId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DatasetParameters", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DatasetParameter, DatasetParameterUnmarshaller>(DatasetParameterUnmarshaller.Instance);
                    unmarshalledObject.DatasetParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DataSetUsageConfiguration", targetDepth))
                {
                    var unmarshaller = DataSetUsageConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DataSetUsageConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FieldFolders", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, FieldFolder, StringUnmarshaller, FieldFolderUnmarshaller>(StringUnmarshaller.Instance, FieldFolderUnmarshaller.Instance);
                    unmarshalledObject.FieldFolders = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ImportMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImportMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LastUpdatedTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdatedTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LogicalTableMap", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, LogicalTable, StringUnmarshaller, LogicalTableUnmarshaller>(StringUnmarshaller.Instance, LogicalTableUnmarshaller.Instance);
                    unmarshalledObject.LogicalTableMap = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OutputColumns", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<OutputColumn, OutputColumnUnmarshaller>(OutputColumnUnmarshaller.Instance);
                    unmarshalledObject.OutputColumns = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PerformanceConfiguration", targetDepth))
                {
                    var unmarshaller = PerformanceConfigurationUnmarshaller.Instance;
                    unmarshalledObject.PerformanceConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PhysicalTableMap", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, PhysicalTable, StringUnmarshaller, PhysicalTableUnmarshaller>(StringUnmarshaller.Instance, PhysicalTableUnmarshaller.Instance);
                    unmarshalledObject.PhysicalTableMap = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RowLevelPermissionDataSet", targetDepth))
                {
                    var unmarshaller = RowLevelPermissionDataSetUnmarshaller.Instance;
                    unmarshalledObject.RowLevelPermissionDataSet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RowLevelPermissionTagConfiguration", targetDepth))
                {
                    var unmarshaller = RowLevelPermissionTagConfigurationUnmarshaller.Instance;
                    unmarshalledObject.RowLevelPermissionTagConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UseAs", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UseAs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DataSetUnmarshaller _instance = new DataSetUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataSetUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
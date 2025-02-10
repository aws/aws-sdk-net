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
    /// Response Unmarshaller for AnalysisDefinition Object
    /// </summary>  
    public class AnalysisDefinitionUnmarshaller : IJsonUnmarshaller<AnalysisDefinition, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AnalysisDefinition Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AnalysisDefinition unmarshalledObject = new AnalysisDefinition();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AnalysisDefaults", targetDepth))
                {
                    var unmarshaller = AnalysisDefaultsUnmarshaller.Instance;
                    unmarshalledObject.AnalysisDefaults = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CalculatedFields", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<CalculatedField, CalculatedFieldUnmarshaller>(CalculatedFieldUnmarshaller.Instance);
                    unmarshalledObject.CalculatedFields = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ColumnConfigurations", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ColumnConfiguration, ColumnConfigurationUnmarshaller>(ColumnConfigurationUnmarshaller.Instance);
                    unmarshalledObject.ColumnConfigurations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DataSetIdentifierDeclarations", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DataSetIdentifierDeclaration, DataSetIdentifierDeclarationUnmarshaller>(DataSetIdentifierDeclarationUnmarshaller.Instance);
                    unmarshalledObject.DataSetIdentifierDeclarations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FilterGroups", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<FilterGroup, FilterGroupUnmarshaller>(FilterGroupUnmarshaller.Instance);
                    unmarshalledObject.FilterGroups = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Options", targetDepth))
                {
                    var unmarshaller = AssetOptionsUnmarshaller.Instance;
                    unmarshalledObject.Options = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ParameterDeclarations", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ParameterDeclaration, ParameterDeclarationUnmarshaller>(ParameterDeclarationUnmarshaller.Instance);
                    unmarshalledObject.ParameterDeclarations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("QueryExecutionOptions", targetDepth))
                {
                    var unmarshaller = QueryExecutionOptionsUnmarshaller.Instance;
                    unmarshalledObject.QueryExecutionOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Sheets", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<SheetDefinition, SheetDefinitionUnmarshaller>(SheetDefinitionUnmarshaller.Instance);
                    unmarshalledObject.Sheets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StaticFiles", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<StaticFile, StaticFileUnmarshaller>(StaticFileUnmarshaller.Instance);
                    unmarshalledObject.StaticFiles = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AnalysisDefinitionUnmarshaller _instance = new AnalysisDefinitionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AnalysisDefinitionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}